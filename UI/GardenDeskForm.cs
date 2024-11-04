using Model;
using MongoDB.Driver;
using Service;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    /// <summary>
    /// Represents the main form for the GardenDesk application, which manages and displays different panels
    /// for user login, dashboard, ticket and employee management.
    /// </summary>
    public partial class GardenDeskForm : Form
    {
        // Services for handling employee and ticket operations
        private readonly EmployeeService employeeService = new();
        private readonly TicketService ticketService = new();

        // Currently logged-in employee
        private Employee? loggedInEmployee = null;

        // Selected ticket in the tickets listview
        private Ticket? selectedTicket;

        // Selected employee in the employees listview
        private Employee? selectedEmployee;

        //Vlad
        private int numberOfOpenTickets;
        private int numberOfClosedTickets;
        private int numberOfResolvedTickets;
        private int numberOfAllTickets;

        #region Sia Login panel and Transfer ticket

        /// <summary>
        /// Initializes a new instance of the <see cref="GardenDeskForm"/> class,
        /// setting up the login panel and verifying database connectivity.
        /// </summary>
        public GardenDeskForm()
        {
            InitializeComponent();

            // Set up the menu strip width
            menuStrip.Width = Screen.FromHandle(Handle).Bounds.Width;

            // Show the login panel
            SetIndentForHolderPanel(panelLoginHolder);
            ShowPanel(pnlLogin);

            // Display a message if there is a database connection issue
            if (!employeeService.IsDatabaseInitiated())
                ShowDatabaseError();
        }

        /// <summary>
        /// Centers the specified holder panel horizontally within the form by calculating and applying an indent 
        /// based on the screen width.
        /// </summary>
        /// <param name="holderPanel">The panel to center horizontally within the form.</param>
        private void SetIndentForHolderPanel(Panel holderPanel)
        {
            if (holderPanel.Left.Equals(0))
            {
                // Calculate indent based on screen width and the provided panel
                int indent = Screen.FromHandle(Handle).Bounds.Width / 2 - holderPanel.Width / 2;

                // Apply the calculated indent
                holderPanel.Left += indent;
            }
        }

        /// <summary>
        /// Configures and displays the menu items in the menu strip based on the current user's role.
        /// Regular employees will not have access to the user management menu item, and all items are resized
        /// to evenly fill the menu strip width.
        /// </summary>
        private void SetUpMenuStrip()
        {
            List<ToolStripItem> menuItems = new List<ToolStripItem>();

            foreach (ToolStripItem menuItem in menuStrip.Items)
            {
                // Display all items, including separators
                menuItem.Visible = true;

                // Store temporary all menu items
                if (menuItem is ToolStripMenuItem)
                    menuItems.Add(menuItem);

                // Remove and hide the user management for a regular employee
                if (menuItem.Name.Equals(menuItemUsers.Name) && loggedInEmployee is not null && loggedInEmployee.Role.Equals(EmployeeRole.RegularEmployee))
                {
                    menuItems.Remove(menuItem);
                    menuItem.Visible = false;
                    toolStripSeparator2.Visible = false;
                }
            }

            // Resize menu items to fill the menu strip width
            foreach (ToolStripItem menuItem in menuItems)
            {
                menuItem.Width = menuStrip.Width / menuItems.Count - toolStripSeparator1.Width - menuStrip.Padding.Horizontal;
            }
        }

        /// <summary>
        /// Displays the specified panel, hiding all other panels and managing the visibility of the menu bar.
        /// </summary>
        /// <param name="panel">The panel to display.</param>
        private void ShowPanel(Panel panel)
        {
            string panelPrefix = Properties.Resources.PanelPrefix;

            // Hide all panels
            foreach (Control control in Controls)
                if (control.Name.StartsWith(panelPrefix)) control.Hide();

            // Show the provided panel
            panel.Show();
        }

        /// <summary>
        /// Handles the visibility change event for the login panel, setting the form's Accept button 
        /// to <see cref="btnLogin"/> when the login panel is visible. This allows the Enter key to 
        /// trigger the login action automatically.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PanelLoginVisibilityChanged(object sender, EventArgs e)
        {
            if (pnlLogin.Visible)
                AcceptButton = btnLogin;
            else
                AcceptButton = null;
        }

        /// <summary>
        /// Handles the login button click event, initiating the login attempt.
        /// </summary>
        private async void OnLoginButtonClick(object sender, EventArgs e)
        {
            await AttemptLogin();
        }

        /// <summary>
        /// Attempts to log in the user by verifying credentials with the employee service.
        /// Displays an error if login fails; otherwise, sets the menu according with a user role and
        /// initiates and shows the dashboard panel.
        /// </summary>
        private async Task AttemptLogin()
        {
            try
            {
                lblLoginLoading.Visible = true;

                string username = txtBoxLoginUsername.Text;
                string password = txtBoxLoginPassword.Text;

                Employee? employee = await employeeService.GetEmployeeByUsernameAndPassword(username, password);

                if (employee == null)
                {
                    lblLoginLoading.Visible = false;
                    lblLoginWrongCredentials.Visible = true;
                }
                else
                {
                    loggedInEmployee = employee;

                    // Set up the menu according with a user role
                    SetUpMenuStrip();

                    SetUserRoleAccess();

                    // Initiate and show Dashboard panel
                    SetIndentForHolderPanel(panelChartHolder);
                    ShowPanel(pnlDashboard);
                    await GetTicketsForCurrentEmployee();
                    LoadCharts();
                }
            }
            catch
            {
                ShowDatabaseError();
                lblLoginLoading.Visible = false;
                await TryToReconnect(pnlLogin);
            }
        }

        /// <summary>
        /// Configures the column widths of the <see cref="ticketsListView"/> control based on its total width.
        /// Each column is assigned a proportional width to ensure a balanced and readable layout.
        /// </summary>
        private void SetTicketsListViewColumns()
        {
            int tableWidth = ticketsListView.Width;

            // Set the column widths based on the table width
            ticketsListView.Columns[0].Width = (int)(tableWidth * 0.18);
            ticketsListView.Columns[1].Width = (int)(tableWidth * 0.20);
            ticketsListView.Columns[2].Width = (int)(tableWidth * 0.16);
            ticketsListView.Columns[3].Width = (int)(tableWidth * 0.14);
            ticketsListView.Columns[4].Width = (int)(tableWidth * 0.14);
            ticketsListView.Columns[5].Width = (int)(tableWidth * 0.07);
            ticketsListView.Columns[6].Width = (int)(tableWidth * 0.09);
        }

        /// <summary>
        /// Configures the column widths of the <see cref="usersList"/> control based on its total width.
        /// Each column is assigned a proportional width to ensure a balanced and readable layout for user data.
        /// </summary>
        private void SetUsersListViewColumns()
        {
            int tableWidth = usersList.Width;

            // Set the column widths based on the table width
            usersList.Columns[0].Width = (int)(tableWidth * 0.25);
            usersList.Columns[1].Width = (int)(tableWidth * 0.25);
            usersList.Columns[2].Width = (int)(tableWidth * 0.25);
            usersList.Columns[3].Width = (int)(tableWidth * 0.22);
        }

        /// <summary>
        /// Handles the click event for the "View Ticket" button, centers the ticket view panel,
        /// fills in ticket details, and displays the panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnViewTicketButtonClick(object sender, EventArgs e)
        {
            SetIndentForHolderPanel(panelViewTicketHolder);
            FillViewTicketFields();
            ShowPanel(pnlViewTicket);
        }

        /// <summary>
        /// Resets the selection in the tickets overview by clearing the selected employee 
        /// and disabling the "View Ticket" button.
        /// </summary>
        private void ResetTicketsOverviewSelection()
        {
            selectedEmployee = null;
            ChangeButtonState(btnViewTicket, Color.LightGray, SystemColors.ControlText, false);
        }

        /// <summary>
        /// Handles the click event for the "Close View" button, returns to the tickets overview view, 
        /// and resets the view ticket panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseViewButtonClick(object sender, EventArgs e)
        {
            ShowTicketsView();
            ResetViewTicket();
        }

        /// <summary>
        /// Fills in the fields in the "View Ticket" panel with the selected ticket's details. 
        /// Retrieves the assigned service desk employee's information asynchronously.
        /// </summary>
        private async void FillViewTicketFields()
        {
            try
            {
                // the selectedTicket is guaranteed not to be null here
#nullable disable
                Employee serviceDeskEmployee = await employeeService.GetEmployeeById(selectedTicket.ServiceDeskUser);

                lblVTReportingUserValue.Text = selectedTicket.ReportingEmployeeFirstName + " " + selectedTicket.ReportingEmployeeLastName;
                lblVTServiceDeskValue.Text = serviceDeskEmployee.ToString();
                lblVTTitleValue.Text = selectedTicket.Title;
                lblVTIncidentValue.Text = selectedTicket.IncidentType.ToString();
                lblVTStatusValue.Text = selectedTicket.Status.ToString();
                lblVTPriorityValue.Text = selectedTicket.Priority.ToString();
                lblVTResolvedValue.Text = selectedTicket.IsResolved ? Properties.Resources.Yes : Properties.Resources.No;
                lblVTEscalatedValue.Text = selectedTicket.IsEscalated ? Properties.Resources.Yes : Properties.Resources.No;
                lblVTCreationDateValue.Text = selectedTicket.CreationDate.ToString();
                lblVTDeadlineValue.Text = selectedTicket.Deadline.ToString();
                lblVTDescriptionValue.Text = selectedTicket.Description;
#nullable enable
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlViewTicket);
            }
        }

        /// <summary>
        /// Handles the click event for the "Transfer Ticket" button. 
        /// If the service desk dropdown is visible, updates the ticket's assigned service desk employee; 
        /// otherwise, populates the dropdown with service desk employees for selection.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private async void OnTransferTicketButtonClick(object sender, EventArgs e)
        {
            try
            {
                // the selectedTicket and EmployeeId are guaranteed not to be null here
#nullable disable
                if (cmbBoxServiceDesk.Visible)
                {
                    Employee serviceDeskUser = ((Employee)cmbBoxServiceDesk.SelectedItem);
                    selectedTicket.ServiceDeskUser = serviceDeskUser.EmployeeId;
                    lblVTServiceDeskValue.Text = serviceDeskUser.ToString();
                    await ticketService.UpdateServiceDeskEmployee(selectedTicket);
                    ResetViewTicket();
                }
                else
                {
                    List<Employee> serviceDeskEmployees = await employeeService.GetAllServiceDeskEmployeesSorted();
                    cmbBoxServiceDesk.Items.Clear();
                    cmbBoxServiceDesk.Items.AddRange(serviceDeskEmployees.ToArray());
                    cmbBoxServiceDesk.SelectedItem = serviceDeskEmployees.Find(e => e.EmployeeId.Equals(selectedTicket.ServiceDeskUser));
                    lblVTServiceDeskValue.Visible = false;
                    cmbBoxServiceDesk.Visible = true;
                    btnTransfer.Text = Properties.Resources.Save;
                }
#nullable enable
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlViewTicket);
            }
        }

        /// <summary>
        /// Resets the view ticket panel to its initial state by hiding the service desk selection dropdown
        /// and resetting the "Transfer" button text.
        /// </summary>
        private void ResetViewTicket()
        {
            cmbBoxServiceDesk.Visible = false;
            lblVTServiceDeskValue.Visible = true;
            btnTransfer.Text = Properties.Resources.TransferTicket;
        }

        /// <summary>
        /// Handles the text changed event for the login text boxes, hiding the "wrong credentials" label
        /// whenever the user modifies the login input. This provides immediate feedback, clearing any 
        /// previous error message as the user enters new information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTextBoxLoginTextChanged(object sender, EventArgs e)
        {
            lblLoginWrongCredentials.Visible = false;
        }

        #endregion

        #region Tina Create/Update/Delete User Logic

        #region Create Employee

        /// <summary>
        /// Initializes the Add/Edit panel for creating a new employee
        /// </summary>
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Set up the Add/Edit panel for adding a new employee
            lblAddEditUser.Text = "Create new employee";
            btnCreateEmployee.Visible = true;
            btnDeleteEmployee.Visible = false;
            btnUpdateEmployee.Visible = false;

            ClearAddEditPnlInputs(); // in the case of a previous operation in this panel

            ShowPanel(pnlAddEditUser);
            SetIndentForHolderPanel(panelAddEditUserHolder);
        }

        /// <summary>
        /// Creates a new employee upon click and refreshes view
        /// </summary>
        private async void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = CreateEmployeeObject();
                await employeeService.CreateEmployeeAsync(newEmployee);

                // Show confirmation message
                MessageBox.Show($"Warm welcome to {newEmployee.FirstName} {newEmployee.LastName}!");

                await ShowUsersView();
            }
            catch (Exception exception)
            {
                // Display message for all non-database exceptions
                if (exception is not MongoException)
                {
                    lblAddEditUserError.Text = exception.Message;
                }

                // Handle MongoDB-related exceptions
                else
                {
                    ShowDatabaseError();
                    await TryToReconnect(pnlUsers);
                }
            }
        }

        /// <summary>
        /// Validates input fields and constructs a new Employee object with the provided data and optional employeeId.
        /// </summary>
        private Employee CreateEmployeeObject(string? employeeId = null)
        {
            string firstName = ValidateInput(textBoxFirstName.Text, "^[a-zA-Z ]*$", Properties.Resources.EmployeeFirstNameError); // first name should not contain any numbers
            string lastName = ValidateInput(textBoxLastName.Text, "^[a-zA-Z ]*$", Properties.Resources.EmployeeLastNameError); // last name should not contain any numbers
            string email = ValidateInput(textBoxEmailAddress.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", Properties.Resources.EmployeeEmailError); // email should contain @ in a proper email format
            string phoneNumber = ValidateInput(textBoxPhoneNumber.Text, @"^\+?[0-9]{1,16}$", Properties.Resources.EmployeePhoneError); // phoneNumber should not exceeed 16 digits & only contain numbers and the plus sign
            string employeeRoleInput = ValidateInput(comboBoxTypeUser.Text, "^.+$", Properties.Resources.EmployeeRoleError); // a combobox item should be selected
            EmployeeRole employeeRole = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), employeeRoleInput);
            string branch = ValidateInput(textBoxBranch.Text, "^[a-zA-Z ]*$", Properties.Resources.EmployeeBranchError); // branch name should not contain any numbers

            return new Employee(firstName, lastName, email, phoneNumber, employeeRole, branch, false, null, employeeId);
        }

        /// <summary>
        /// Validates the input text against a specified regular expression condition and throws an exception with an error message if validation fails.
        /// </summary>
        /// <param name="text">The input field's text</param>
        /// <param name="condition">The regular expression condition</param>
        /// <param name="errorMessage">The error message to be displayed when an exception is thrown</param>
        private string ValidateInput(string text, string? condition, string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(text) || (condition != null && !Regex.IsMatch(text, condition)))
            {
                throw new Exception(errorMessage);
            }
            return text;
        }

        /// <summary>
        /// Resets all input fields and the error label in the Add/Edit panel to their default (empty) state.
        /// </summary>
        private void ClearAddEditPnlInputs()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            comboBoxTypeUser.SelectedItem = null;
            textBoxEmailAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxBranch.Text = "";
            lblAddEditUserError.Text = "";
        }

        #endregion

        #region Edit Employee

        /// <summary>
        /// Sets up the Add/Edit panel for editing the selected employee's information
        /// </summary>
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Retrieves the selected employee object from the list view's selected item.
            selectedEmployee = (Employee)usersList.SelectedItems[0].Tag;

            // Set up the Add/Edit panel for editing the employee's info
            lblAddEditUser.Text = "Edit employee information";
            btnCreateEmployee.Visible = false;
            btnDeleteEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;

            // Prefill input fields with selected employee's info
            PrefillEditInputs();

            ShowPanel(pnlAddEditUser);
            SetIndentForHolderPanel(panelAddEditUserHolder);
        }

        /// <summary>
        /// Asynchronously updates the selected employee's information upon click and refreshes view
        /// </summary>
        private async void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // the selectedEmployee is guaranteed not to be null here
#nullable disable

                await employeeService.UpdateEmployeeAsync(CreateEmployeeObject(selectedEmployee.EmployeeId));

                // Show confirmation message
                MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName}'s information has been updated.");

                await ShowUsersView();

#nullable enable
            }
            catch (Exception exception)
            {
                // Display message for all non-database exceptions
                if (exception is not MongoException)
                {
                    lblAddEditUserError.Text = exception.Message;
                }

                // Handle MongoDB-related exceptions
                else
                {
                    ShowDatabaseError();
                    await TryToReconnect(pnlUsers);
                }
            }
        }

        /// <summary>
        /// Prefills the input fields in the Add/Edit panel with the selected employee's existing data to facilitate editing.
        /// </summary>
        private void PrefillEditInputs()
        {
            textBoxFirstName.Text = selectedEmployee.FirstName;
            textBoxLastName.Text = selectedEmployee.LastName;
            comboBoxTypeUser.SelectedItem = selectedEmployee.Role.ToString();
            textBoxEmailAddress.Text = selectedEmployee.Email;
            textBoxPhoneNumber.Text = selectedEmployee.PhoneNumber;
            textBoxBranch.Text = selectedEmployee.Branch;
            lblAddEditUserError.Text = "";
        }

        #endregion

        #region Delete Employee/Cancel Changes

        /// <summary>
        /// Deletes the selected employee after user confirmation upon click and updates view
        /// </summary>
        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                // the selectedEmployee is guaranteed not to be null here
#nullable disable

                if (ConfirmDelete(selectedEmployee))
                {
                    await employeeService.DeleteEmployeeByID(selectedEmployee);

                    // Show confirmation message
                    MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has been deleted.");

                    await ShowUsersView();
                }
#nullable enable
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlUsers);
            }
        }

        /// <summary>
        /// Prompts the user to confirm the deletion of the selected employee 
        /// </summary>
        private bool ConfirmDelete(Employee employee)
        {
            string messageTop = Properties.Resources.ConfirmDeleteMessageTop;
            string messageText = $"Are you sure you want to delete this employee? \nRemember to transfer their {employee.OpenTickets} open tickets.";
            bool answer = MessageBox.Show(messageText, messageTop, MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            return answer;
        }

        /// <summary>
        /// Cancels any changes made to the employee information and returns to the user view.
        /// </summary>
        private async void btnCancelChangesEmployee_Click(object sender, EventArgs e)
        {
            await ShowUsersView();
        }

        #endregion

        #region Users view control

        /// <summary>
        /// Configures user interface access based on the logged-in employee's role, 
        /// hiding escalation and transfer buttons for regular employees.
        /// </summary>
        private void SetUserRoleAccess()
        {
            // the selectedTicket is guaranteed not to be null here
#nullable disable

            if (loggedInEmployee.Role == EmployeeRole.RegularEmployee)
            {
                btnEscalate.Visible = false;
                btnTransfer.Visible = false;
            }

#nullable enable
        }

        /// <summary>
        /// Displays the users view asynchronously when the users menu item is clicked.
        /// </summary>
        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            await ShowUsersView();
        }

        /// <summary>
        /// Configures and displays the Users panel by changing button states, 
        /// displaying employee data asynchronously, and setting up the list view columns.
        /// </summary>
        private async Task ShowUsersView()
        {
            try
            {
                ChangeButtonState(btnEditEmployee, Color.LightGray, SystemColors.ControlText, false);
                await DisplayEmployeesAsync();
                ShowPanel(pnlUsers);
                SetIndentForHolderPanel(panelUsersHandler);
                SetUsersListViewColumns();
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlUsers);
            }
        }

        /// <summary>
        /// Updates the edit employee button state based on the selection in the users list; 
        /// enables the button if an item is selected, otherwise disables it.
        /// </summary>
        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
                ChangeButtonState(btnEditEmployee, Color.Peru, Color.White, true);
            else
                ChangeButtonState(btnEditEmployee, Color.LightGray, SystemColors.ControlText, false);
        }

        /// <summary>
        /// Configures the state of a button by setting its enabled status, background color, and text color.
        /// </summary>
        /// <param name="button">The button to be configured</param>
        /// <param name="background">The new background color of the button</param>
        /// <param name="textColor">The new text color of the button</param>
        /// <param name="enablement">The state of being enabled or disabled</param>
        private void ChangeButtonState(Button button, Color background, Color textColor, bool enablement)
        {
            button.Enabled = enablement;
            button.BackColor = background;
            button.ForeColor = textColor;
        }

        #endregion

        #endregion

        #region Tina Escalate Ticket

        /// <summary>
        /// Enables the escalate button if a selected ticket is not escalated and not closed, 
        /// and always enables the view ticket button when a ticket is selected
        /// </summary>
        private void ticketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                selectedTicket = (Ticket)ticketsListView.SelectedItems[0].Tag;

                if (selectedTicket.IsEscalated == false && selectedTicket.Status != Status.Closed)
                {
                    ChangeButtonState(btnEscalate, Color.Firebrick, Color.White, true);
                }
                else
                    ChangeButtonState(btnEscalate, Color.LightGray, SystemColors.ControlText, false);

                ChangeButtonState(btnViewTicket, Color.OliveDrab, Color.White, true);
            }
        }

        /// <summary>
        /// Escalates the selected ticket asynchronously upon click
        /// </summary>
        private async void btnEscalate_Click(object sender, EventArgs e)
        {
            try
            {
                // the selectedTicket is guaranteed not to be null here
#nullable disable
              
                await ticketService.EscalateTicket(selectedTicket);

                // Disable escalate button after the operation
                ChangeButtonState(btnEscalate, Color.LightGray, SystemColors.ControlText, false);

                // Update the escalate label to the ticket's current state
                lblVTEscalatedValue.Text = selectedTicket.IsEscalated ? Properties.Resources.Yes : Properties.Resources.No;

#nullable enable
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlViewTicket);
            }
        }

        /// <summary>
        /// Highlights the escalated list view item by changing its background color to MistyRose.
        /// </summary>
        private void HighlightEscalatedTicket(ListViewItem item)
        {
            item.BackColor = Color.MistyRose;
        }

        /// <summary>
        /// Displays a tooltip for escalated tickets when the mouse hovers over them, 
        /// and hides the tooltip when not hovering over a relevant item.
        /// </summary>
        private void ticketsListView_MouseMove(object sender, MouseEventArgs e)
        {
            ListViewItem item = ticketsListView.GetItemAt(e.X, e.Y);

            // Clear previous tooltip
            toolTipEscalated.Hide(ticketsListView);

            if (item != null && item.BackColor == Color.MistyRose) // the background of the escalated tickets is misty rose
            {
                toolTipEscalated.Show(Properties.Resources.EscalatedTicketToolTip, ticketsListView, e.Location);
            }
        }

        #endregion

        #region Vladyslav Dashboard panel

        private async Task GetTicketsForCurrentEmployee()
        {
            if (loggedInEmployee.Role == EmployeeRole.ServiceDeskEmployee)
            {
                numberOfOpenTickets = await ticketService.GetAmountOfAllOpenTicketsAsync();
                numberOfClosedTickets = await ticketService.GetAmountOfAllClosedTicketsAsync();
                numberOfResolvedTickets = await ticketService.GetAmountOfAllResolvedTicketsAsync();
                numberOfAllTickets = await ticketService.GetAmountOfAllTicketsAsync();
            }
            else
            {
                numberOfOpenTickets = await ticketService.GetAmountOfAllOpenTicketsForReportingUserAsync(loggedInEmployee);
                numberOfClosedTickets = await ticketService.GetAmountOfAllClosedTicketsForReportingUserAsync(loggedInEmployee);
                numberOfResolvedTickets = await ticketService.GetAmountOfAllResolvedTicketsForReportingUserAsync(loggedInEmployee);
                numberOfAllTickets = await ticketService.GetAmountOfAllTicketsForReportingUserAsync(loggedInEmployee);
            }
        }

        private void LoadCharts()
        {
            SetUpCharts();

            chartOpen.Series["s1"].Points.AddXY("", numberOfOpenTickets);
            chartOpen.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfOpenTickets);
            lblOpenNumber.Text = $"{numberOfOpenTickets}/{numberOfAllTickets}";
            chartOpen.Series["s1"].Points[0].Color = Color.Red;
            chartOpen.Series["s1"].Points[1].Color = Color.Gray;

            chartClosed.Series["s1"].Points.AddXY("", numberOfClosedTickets);
            chartClosed.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfClosedTickets);
            lblClosedNumber.Text = $"{numberOfClosedTickets}/{numberOfAllTickets}";
            chartClosed.Series["s1"].Points[0].Color = Color.Orange;
            chartClosed.Series["s1"].Points[1].Color = Color.Gray;

            chartResolved.Series["s1"].Points.AddXY("", numberOfResolvedTickets);
            chartResolved.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfResolvedTickets);
            lblResolvedNumber.Text = $"{numberOfResolvedTickets}/{numberOfAllTickets}";
            chartResolved.Series["s1"].Points[0].Color = Color.Green;
            chartResolved.Series["s1"].Points[1].Color = Color.Gray;
        }

        private void SetUpCharts()
        {
            foreach (Control control in panelChartHolder.Controls)
            {
                if (control is Chart)
                {
                    Chart chart = (Chart)control;
                    chart.Series.Clear();
                    chart.Legends.Clear();
                    chart.Series.Add("s1");
                    chart.Series[0].ChartType = SeriesChartType.Doughnut;
                }
            }
        }

        private void menuItemDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        #endregion

        #region Naz Tickets Overview and Search Feature

        private async Task DisplayTicketsAsync(Employee employee)
        {
            try
            {
                List<Ticket> tickets;

                // Check the role of the employee to determine which tickets to get
                if (employee.Role == EmployeeRole.RegularEmployee)
                {
                    tickets = await ticketService.GetTicketsForRegularEmployeeAsync(employee);
                }
                else
                {
                    tickets = await ticketService.GetAllTicketsWithReportingUserNameAsync();
                }

                PopulateTicketsListView(tickets);
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlTicketsOverview);
            }
        }

        private void PopulateTicketsListView(List<Ticket> tickets)
        {
            ticketsListView.Items.Clear();

            foreach (var ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Title);
                item.SubItems.Add(ticket.Description);

                // Tina - Mark the reporting employee as deleted if so
                if (!ticket.ReportingEmployeeDeleted)
                    item.SubItems.Add($"{ticket.ReportingEmployeeFirstName} {ticket.ReportingEmployeeLastName}");
                else
                    item.SubItems.Add($"{ticket.ReportingEmployeeFirstName} {ticket.ReportingEmployeeLastName} (deleted)");

                item.SubItems.Add(ticket.CreationDate.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(ticket.Deadline.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(ticket.Status.ToString());
                item.SubItems.Add(ticket.Priority.ToString());

                // Tina - Highlight the ticket in the list if it is escalated 
                if (ticket.IsEscalated)
                    HighlightEscalatedTicket(item);

                item.Tag = ticket;

                ticketsListView.Items.Add(item);
            }
        }

        private async void menuItemIncidents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketsOverview);
            searchtextbox.Clear();
            noTicketsFoundlbl.Visible = false;
            SetIndentForHolderPanel(panelTicketsHolder);
            SetTicketsListViewColumns();
            await DisplayTicketsAsync(loggedInEmployee);
            ResetTicketsOverviewSelection();
        }

        private async void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                noTicketsFoundlbl.Visible = false;
                string keywordString = searchtextbox.Text;
                if (string.IsNullOrWhiteSpace(keywordString))
                {
                    await DisplayTicketsAsync(loggedInEmployee); // if the search box is ampty, show all tickets
                    return;
                }
                List<Ticket> tickets = await ticketService.SearchTicketsByKeywordsAsync(loggedInEmployee, keywordString);

                if (tickets.Count == 0)
                {
                    ticketsListView.Items.Clear();
                    noTicketsFoundlbl.Visible = true;
                    noTicketsFoundlbl.BringToFront();
                    noTicketsFoundlbl.Location = new Point( ticketsListView.Left + (ticketsListView.Width - noTicketsFoundlbl.Width) /2,
                        ticketsListView.Top + (ticketsListView.Height - noTicketsFoundlbl.Height) / 2);
                }
                else
                {
                    PopulateTicketsListView(tickets);
                }
            }
            catch
            {
                ShowDatabaseError();
                await TryToReconnect(pnlTicketsOverview);
            }
        }

        #endregion

        #region Danylo Create/Update/Close Ticket Logic

        #region Create Ticket

        private async void btnAddTicket_Click(object sender, EventArgs e)
        {
            ConfigureTicketPanel("Create new ticket", true, false, false, true);
            await PopulateServiceDeskEmployeeComboBoxAsync();
            serviceDeskUserCmbBox.Enabled = true;
            ClearInputs();
            ShowPanel(pnlAddEditTicket);
            SetIndentForHolderPanel(panelAddEditTicketHolder);
        }

        private async void ShowTicketsView()
        {
            noTicketsFoundlbl.Visible = false;
            await DisplayTicketsAsync(loggedInEmployee);
            ShowPanel(pnlTicketsOverview);
            CleanSortOrderComboBox();
            ResetTicketsOverviewSelection();
        }

        private async void addTicketBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket newTicket = CreateTicketObject(DateTime.Now);
                await ticketService.AddTicketAsync(newTicket);
                ShowTicketsView();
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private Ticket CreateTicketObject(DateTime time, string? ticketId = null)
        {
            var ticket = new Ticket(
                reportingUser: loggedInEmployee.EmployeeId,
                serviceDeskUser: GetServiceDeskUserId(serviceDeskUserCmbBox, "Service Desk User is required."),
                title: ValidateInput(titleTxtBox.Text, null, "Title is required."),
                description: ValidateInput(descriptionTxtBox.Text, null, "Description is required."),
                status: ParseEnum<Status>(ValidateInput(statusCmbBox.Text, null, "Status is required.")),
                priority: ParseEnum<Priority>(ValidateInput(priorityCmbBox.Text, null, "Priority is required.")),
                isResolved: ParseBoolean(ValidateInput(isResolvedCmbBox.Text, null, "Resolution status is required.")),
                isEscalated: false,
                deadline: CalculateDeadline(ValidateInput(deadlineCmbBox.Text, null, "Deadline is required."), time),
                incidentType: ParseEnum<IncidentType>(ValidateInput(typeOfAccidentCmbBox.Text, null, "Incident Type is required.")),
                creationDate: time,
                ticketId: ticketId
            );

            return ticket;
        }

        private string GetServiceDeskUserId(ComboBox comboBox, string errorMessage)
        {
            var selectedEmployee = comboBox.SelectedValue as Employee;
            return selectedEmployee?.EmployeeId ?? throw new Exception(errorMessage);
        }

        private void DisplayMessage(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private T ParseEnum<T>(string value) where T : struct
        {
            if (Enum.TryParse(value, true, out T result) && Enum.IsDefined(typeof(T), result))
                return result;

            throw new ArgumentException("Invalid value for " + typeof(T).Name);
        }

        private bool ParseBoolean(string value)
        {
            return value.Equals("Yes", StringComparison.OrdinalIgnoreCase);
        }

        private void isResolvedCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isResolvedCmbBox.SelectedItem != null && isResolvedCmbBox.SelectedItem.ToString() == "Yes")
            {
                statusCmbBox.SelectedItem = "Closed";
                statusCmbBox.Enabled = false;
            }
            else
            {
                statusCmbBox.Enabled = true;
            }
        }

        private async Task PopulateServiceDeskEmployeeComboBoxAsync(string? id = null)
        {
            List<Employee> employees = await employeeService.GetAllEmployeesWithCountedTickets();
            List<Employee> serviceDeskEmployees = employees.Where(employee => employee.Role == EmployeeRole.ServiceDeskEmployee).ToList();

            var serviceDeskrEmployees = employees
                .Where(employee => employee.Role == EmployeeRole.ServiceDeskEmployee)
                .Select(employee => new
                {
                    FullName = $"{employee.FirstName} {employee.LastName}",
                    Employee = employee
                })
                .ToList();

            serviceDeskUserCmbBox.DataSource = serviceDeskrEmployees;
            serviceDeskUserCmbBox.DisplayMember = "FullName";
            serviceDeskUserCmbBox.ValueMember = "Employee";

            SetSelectedEmployeeById(serviceDeskEmployees, id);
        }

        private void SetSelectedEmployeeById(List<Employee> serviceDeskEmployees, string? id)
        {
            var matchingEmployee = serviceDeskEmployees
                .FirstOrDefault(emp => emp.EmployeeId == id);

            int index = serviceDeskEmployees.IndexOf(matchingEmployee);
            serviceDeskUserCmbBox.SelectedIndex = index;
        }

        public DateTime CalculateDeadline(string selectedOption, DateTime time) =>
            selectedOption switch
            {
                "+ 7 days" => time.AddDays(7),
                "+ 14 days" => time.AddDays(14),
                "+ 28 days" => time.AddDays(28),
                "+ 6 months" => time.AddMonths(6),
                _ => time
            };

        private void ClearInputs()
        {
            serviceDeskUserCmbBox.SelectedItem = null;
            titleTxtBox.Text = string.Empty;
            typeOfAccidentCmbBox.SelectedItem = null;
            statusCmbBox.SelectedItem = null;
            priorityCmbBox.SelectedItem = null;
            isResolvedCmbBox.SelectedItem = null;
            deadlineCmbBox.Text = string.Empty;
            deadlineCmbBox.SelectedItem = null;
            descriptionTxtBox.Text = string.Empty;
        }
        private void cancelTicketBtn_Click(object sender, EventArgs e)
        {
            ShowTicketsView();
        }

        private void ConfigureTicketPanel(string label, bool showAdd, bool showEdit, bool showClose, bool enableServiceDeskCombo)
        {
            lblAddEditTicket.Text = label;
            addTicketBtn.Visible = showAdd;
            editTicketBtn.Visible = showEdit;
            closeTicketBtn.Visible = showClose;
            serviceDeskUserCmbBox.Enabled = enableServiceDeskCombo;
        }

        #endregion

        #region Update Ticket

        private async void btnEditTicket_Click(object sender, EventArgs e)
        {
            ConfigureTicketPanel("Edit ticket", false, true, true, false);
            await PrefillEditTicketInputs();
            ShowPanel(pnlAddEditTicket);
            SetIndentForHolderPanel(panelAddEditTicketHolder);
        }

        private async void editTicketBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var updatedTicket = CreateTicketObject(selectedTicket.Deadline, selectedTicket.TicketId);
                await ticketService.UpdateTicketAsync(updatedTicket);
                ShowTicketsView();
            }
            catch (Exception ex)
            {
                DisplayMessage(ex.Message);
            }
        }

        private async Task PrefillEditTicketInputs()
        {
            await PopulateServiceDeskEmployeeComboBoxAsync(selectedTicket.ServiceDeskUser);

            titleTxtBox.Text = selectedTicket.Title;
            typeOfAccidentCmbBox.Text = selectedTicket.IncidentType.ToString();
            statusCmbBox.Text = selectedTicket.Status.ToString();
            priorityCmbBox.Text = selectedTicket.Priority.ToString();
            isResolvedCmbBox.Text = selectedTicket.IsResolved ? "Yes" : "No";
            deadlineCmbBox.Text = selectedTicket.Deadline.ToString("MM/dd/yyyy");
            descriptionTxtBox.Text = selectedTicket.Description;

            serviceDeskUserCmbBox.Enabled = false;
        }

        #endregion

        #region Close Ticket
        private async void closeTicketBtn_Click(object sender, EventArgs e)
        {
            if (selectedTicket.Status == Status.Closed)
            {
                MessageBox.Show("The ticket is already closed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            await ticketService.CloseTicketAsync(selectedTicket.TicketId);

            ShowTicketsView();
        }

        #endregion

        #endregion

        #region Danylo Sort by Priority Feature

        private async Task SortAndDisplayTicketsByPriorityAsync()
        {
            noTicketsFoundlbl.Visible = false;
            List<Ticket> tickets = await GetTicketsAsync();
            bool isAscendingOrder = SortOrderComboBox.SelectedItem != null && SortOrderComboBox.SelectedItem.ToString() == "Low to High";
            tickets = SortTicketsByPriority(tickets, isAscendingOrder);
            PopulateTicketsListView(tickets);
        }

        private async Task<List<Ticket>> GetTicketsAsync()
        {
            return loggedInEmployee.Role == EmployeeRole.RegularEmployee
                ? await ticketService.GetTicketsForRegularEmployeeAsync(loggedInEmployee)
                : await ticketService.GetAllTicketsWithReportingUserNameAsync();
        }

        private List<Ticket> SortTicketsByPriority(List<Ticket> tickets, bool ascending)
        {
            return ascending ? tickets.OrderBy(ticket => ticket.Priority).ToList() : tickets.OrderByDescending(ticket => ticket.Priority).ToList();
        }

        private async void SortOrderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await SortAndDisplayTicketsByPriorityAsync();
        }

        private void CleanSortOrderComboBox()
        {
            SortOrderComboBox.SelectedIndex = -1;
        }

        #endregion

        #region Orest User Management

        private async Task DisplayEmployeesAsync()
        {
            bool isInternetAvailable = await employeeService.IsDatabaseConnctionAvailable();

            if (!isInternetAvailable)
            {
                ShowDatabaseError();
                await TryToReconnect(pnlUsers);
            }

            usersList.Items.Clear();
            List<Employee> employees = await employeeService.GetAllEmployeesWithCountedTickets();
            List<ListViewItem> items = new();
            FillListView(employees, items);
            usersList.Items.AddRange(items.ToArray());
        }

        private void FillListView(List<Employee> employees, List<ListViewItem> items)
        {
            foreach (var employee in employees)
            {
                ListViewItem item = new(employee.Email);

                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.OpenTickets.ToString());
                item.Tag = employee;

                items.Add(item);
            }
        }

        private void ShowDatabaseError()
        {
            ShowPanel(pnlDbError);
        }

        /// <summary>
        /// This method is used to reconnect to the database and view a panel after the connection was lost.
        /// </summary>
        /// <param name="panel">A spacific panel which needs to be open after connection was restored.</param>
        private async Task TryToReconnect(Panel panel)
        {
            bool isReconnect = false;

            while (!isReconnect)
            {
                await Task.Delay(TimeSpan.FromSeconds(10));
                isReconnect = await employeeService.IsDatabaseConnctionAvailable();
            }

            ShowPanel(panel);
        }

        #endregion

    }
}