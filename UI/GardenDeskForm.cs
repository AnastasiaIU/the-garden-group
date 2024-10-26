using Model;
using Service;
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

        // Tina
        private Ticket? selectedTicket;
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

            // Show the login panel
            ShowPanel(pnlLogin);
            // Display a message if there is a database connection issue
            if (!employeeService.IsDatabaseInitiated())
                DisplayDatabaseError();
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

            // Hide menu for the login panel
            if (panel.Name.Equals(Properties.Resources.LoginPanel))
                menuStrip.Visible = false;
            else
                menuStrip.Visible = true;

            // Show the provided panel
            panel.Show();
        }

        /// <summary>
        /// Displays an error message in the login panel when there is a database connection issue.
        /// Hides all other login panel controls.
        /// </summary>
        private void DisplayDatabaseError()
        {
            // Hide all elements for the login panel
            foreach (Control control in Controls)
                if (control.Name.Equals(Properties.Resources.LoginPanel))
                    foreach (Control loginControl in control.Controls)
                        loginControl.Hide();

            // Show the error message
            lblLoginPrompt.Text = Properties.Resources.DatabaseError;
            lblLoginPrompt.Visible = true;
        }

        /// <summary>
        /// Handles the login button click event, initiating the login attempt.
        /// </summary>
        private async void OnLoginButtonClick(object sender, EventArgs e)
        {
            await AttemptLogin();
        }

        /// <summary>
        /// Initiates the login attempt when the Enter key is pressed in the username or password text boxes.
        /// </summary>
        private async void OnTextBoxLoginKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                await AttemptLogin();
            }
        }

        /// <summary>
        /// Attempts to log in the user by verifying credentials with the employee service.
        /// Displays an error if login fails; otherwise, sets the menu according with a user role and
        /// initiates and shows the dashboard panel.
        /// </summary>
        private async Task AttemptLogin()
        {
            string username = txtBoxLoginUsername.Text;
            string password = txtBoxLoginPassword.Text;

            Employee? employee = await employeeService.GetEmployeeByUsernameAndPassword(username, password);

            if (employee == null)
            {
                lblLoginWrongCredentials.Visible = true;
            }
            else
            {
                loggedInEmployee = employee;

                // Sets the menu according with a user role
                SetUserRoleAccess();

                // Initiate and show Dashboard panel
                await GetTicketsForCurrentEmployee();
                LoadCharts();
                ShowPanel(pnlDashboard);
            }
        }

        #endregion

        #region User Management Logic

        // Tina 
        // Set access to user and ticket management based on current employee's role
        private void SetUserRoleAccess()
        {
            if (loggedInEmployee.Role == EmployeeRole.RegularEmployee)
            {
                // Regular employee is not authorised for any user management
                menuItemUsers.Visible = false;

                // Regular employee is not authorised for escalating a ticket
                btnEscalate.Visible = false;
            }
        }

        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            ShowUsersView();
        }

        private async Task DisplayEmployeesAsync()
        {
            usersList.Items.Clear();
            List<Employee> employees = await employeeService.GetAllEmployeesWithCountedTicketsAsync();
            List<ListViewItem> items = new();
            FillListView(employees, items);
            usersList.Items.AddRange(items.ToArray());
        }

        private void FillListView(List<Employee> employees, List<ListViewItem> items)
        {
            foreach (var employee in employees)
            {
                ListViewItem item = new();

                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.OpenTickets.ToString());
                item.Tag = employee;

                items.Add(item);
            }
        }
        #endregion

        #region Tina Create/Update/Delete User Logic

        #region Create Employee

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            // Set up the Add/Edit panel for adding a new employee
            lblAddEditUser.Text = "Create new employee";
            btnCreateEmployee.Visible = true;
            btnDeleteEmployee.Visible = false;
            btnUpdateEmployee.Visible = false;

            ClearEdittedInputs(); // in the case of a previous edit operation

            ShowPanel(pnlAddEditUser);
        }

        private async void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = CreateEmployeeObject();
                await employeeService.CreateEmployeeAsync(newEmployee);

                // Show confirmation message
                MessageBox.Show($"Warm welcome to {newEmployee.FirstName} {newEmployee.LastName}!");

                ShowUsersView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Creates an employee object based on the user inputs
        private Employee CreateEmployeeObject(string? employeeId = null)
        {
            // Check if each input field is empty
            string firstName = IsInputBoxEmpty(textBoxFirstName.Text, Properties.Resources.EmployeeFirstNameError);
            string lastName = IsInputBoxEmpty(textBoxLastName.Text, Properties.Resources.EmployeeLastNameError);
            string email = IsInputBoxEmpty(textBoxEmailAddress.Text, Properties.Resources.EmployeeEmailError);
            string phoneNumber = IsInputBoxEmpty(textBoxPhoneNumber.Text, Properties.Resources.EmployeePhoneError);
            string employeeRoleInput = IsInputBoxEmpty(comboBoxTypeUser.Text, Properties.Resources.EmployeeRoleError);
            EmployeeRole employeeRole = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), employeeRoleInput);
            string branch = IsInputBoxEmpty(textBoxBranch.Text, Properties.Resources.EmployeeBranchError);

            return new Employee(firstName, lastName, email, phoneNumber, employeeRole, branch, null, employeeId);
        }

        // Checks if an input box is empty
        private string IsInputBoxEmpty(string inputBoxString, string errorMessage)
        {
            if (inputBoxString == string.Empty || inputBoxString == null)
                throw new Exception(errorMessage);

            return inputBoxString;
        }

        // Clear all input fields in the Add/Edit panel
        private void ClearEdittedInputs()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            comboBoxTypeUser.SelectedItem = null;
            textBoxEmailAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxBranch.Text = "";
        }

        #endregion

        #region Edit Employee

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // Get the selected employee from the list view's selected item
            selectedEmployee = (Employee)usersList.SelectedItems[0].Tag;

            // Set up the Add/Edit panel for editing the employee's info
            lblAddEditUser.Text = "Edit employee information";
            btnCreateEmployee.Visible = false;
            btnDeleteEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;

            // Prefill input fields with selected employee's info
            PrefillEditInputs();

            ShowPanel(pnlAddEditUser);
        }

        private async void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            await employeeService.UpdateEmployeeAsync(CreateEmployeeObject(selectedEmployee.EmployeeId));

            // Show confirmation message
            MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName}'s information has been updated.");

            ShowUsersView();
        }

        // Prefill the inputs with the selected employee's existing data to edit
        private void PrefillEditInputs()
        {
            textBoxFirstName.Text = selectedEmployee.FirstName;
            textBoxLastName.Text = selectedEmployee.LastName;
            comboBoxTypeUser.SelectedItem = selectedEmployee.Role.ToString();
            textBoxEmailAddress.Text = selectedEmployee.Email;
            textBoxPhoneNumber.Text = selectedEmployee.PhoneNumber;
            textBoxBranch.Text = selectedEmployee.Branch;
        }

        #endregion

        #region Delete Employee/Cancel Changes

        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                await employeeService.DeleteEmployeeByID(selectedEmployee.EmployeeId);

                // Show confirmation message
                MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has been deleted.");

                ShowUsersView();
            }
        }

        // Prompts user to confirm if they want to delete the employee
        private bool ConfirmDelete()
        {
            string messageTop = Properties.Resources.ConfirmDeleteMessageTop;
            string messageText = Properties.Resources.ConfirmDeleteMessageText;
            bool answer = MessageBox.Show(messageText, messageTop, MessageBoxButtons.YesNo) == DialogResult.Yes ? true : false;
            return answer;
        }

        // Cancels any changes and return to the user list view without saving
        private void btnCancelChangesEmployee_Click(object sender, EventArgs e)
        {
            ShowUsersView();
        }

        #endregion

        #region Users view control

        // Set up the Users panel
        private async void ShowUsersView()
        {
            ChangeButtonState(btnEditEmployee, Color.LightGray, false);
            await DisplayEmployeesAsync();
            ShowPanel(pnlUsers);
        }

        // Enable the edit button once an employee is selected
        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
                ChangeButtonState(btnEditEmployee, Color.Orange, true);
            else
                ChangeButtonState(btnEditEmployee, Color.LightGray, false);
        }

        // Changes the enablement and color of a button
        private void ChangeButtonState(Button button, Color color, bool enablement)
        {
            button.Enabled = enablement;
            button.BackColor = color;
        }

        #endregion

        #endregion

        #region Tina Escalate Ticket

        // Enable the escalate button if a non-closed and non-escalated ticket is selected
        private void ticketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                selectedTicket = (Ticket)ticketsListView.SelectedItems[0].Tag;

                if (selectedTicket.IsEscalated == false && selectedTicket.Status != Status.Closed)
                {
                    ChangeButtonState(btnEscalate, Color.Tomato, true);
                }
            }

            else
                ChangeButtonState(btnEscalate, Color.LightGray, false); ;
        }

        private async void btnEscalate_Click(object sender, EventArgs e)
        {
            await ticketService.EscalateTicket(selectedTicket.TicketId);

            // Show confirmation message
            MessageBox.Show($"'{selectedTicket.Title}' has been escalated.");

            // Disable escalate button after the operation
            ChangeButtonState(btnEscalate, Color.LightGray, false);

            await DisplayTicketsAsync(loggedInEmployee);
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
            foreach (Control control in pnlDashboard.Controls)
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

        private void PopulateTicketsListView(List<Ticket> tickets)
        {
            ticketsListView.Items.Clear();

            foreach (var ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.Title);
                item.SubItems.Add(ticket.Description);
                item.SubItems.Add($"{ticket.ReportingEmployeeFirstName} {ticket.ReportingEmployeeLastName}");
                item.SubItems.Add(ticket.CreationDate.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(ticket.Deadline.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(ticket.Status.ToString());

                item.Tag = ticket;

                ticketsListView.Items.Add(item);
            }
        }

        private async void menuItemIncidents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketsOverview);
            await DisplayTicketsAsync(loggedInEmployee);
        }

        private async void searchbtn_Click(object sender, EventArgs e)
        {
            string keywordString = searchtextbox.Text;
            if (string.IsNullOrWhiteSpace(keywordString))
            {
                await DisplayTicketsAsync(loggedInEmployee);
                return;
            }
            List<Ticket> tickets = await ticketService.SearchTicketsByKeywordsAsync(loggedInEmployee, keywordString);

            PopulateTicketsListView(tickets);
        }

        #endregion
    }
}