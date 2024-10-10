using Model;
using Service;
using System.Drawing;
using System.Media;
using System.Numerics;

namespace UI
{
    public partial class GardenDeskForm : Form
    {
        private readonly EmployeeService employeeService = new();
        private readonly TicketService ticketService = new();
        private Employee? currentEmployee = null;
        // Tina
        private Ticket? selectedTicket;
        private Employee? selectedEmployee;

        public GardenDeskForm()
        {
            InitializeComponent();
            ShowPanel(pnlLogin);
        }

        #region UI Logic

        private void ShowPanel(Panel panel)
        {
            string panelName = Properties.Resources.PanelPrefix;

            foreach (Control control in Controls)
                if (control.Name.StartsWith(panelName)) control.Hide();

            if (panel.Name == Properties.Resources.LoginPanel)
                menuStrip.Visible = false;
            else
                menuStrip.Visible = true;

            panel.Show();
        }

        private async Task DisplayTicketsAsync(Employee employee)
        {
            List<Ticket> tickets;

            // Check the role of the employee to determine which tickets to get
            if (employee.Role == EmployeeRole.RegularEmployee)
            {
                tickets = await ticketService.GetTicketsForRegularEmployeeAsync(employee.EmployeeId);
            }
            else
            {
                tickets = await ticketService.GetAllTicketsForServiceDeskEmployeeAsync();
            }

            ticketsListView.Items.Clear();

            foreach (var ticket in tickets)
            {

                ListViewItem item = new ListViewItem(ticket.Title);
                item.SubItems.Add($"{ticket.ReportingEmployeeFirstName} {ticket.ReportingEmployeeLastName}");
                item.SubItems.Add(ticket.Deadline.ToString("MM/dd/yyyy HH:mm"));
                item.SubItems.Add(ticket.Status.ToString());

                item.Tag = ticket;

                ticketsListView.Items.Add(item);
            }
        }

        private async void menuItemIncidents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketsOverview);
            await DisplayTicketsAsync(currentEmployee);
        }

        #endregion

        #region Login Logic

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBoxLoginUsername.Text;
            string password = txtBoxLoginPassword.Text;

            Employee? employee = await employeeService.GetEmployeeByUsernameAndPasswordAsync(username, password);

            if (employee == null)
            {
                lblLoginWrongCredentials.Visible = true;
            }
            else
            {
                currentEmployee = employee;

                //Tina
                SetUserRoleAccess();

                ShowPanel(pnlDashboard);
            }
        }

        #endregion

        #region User Management Logic

        // Tina 
        // Set access to user and ticket management based on current employee's role
        private void SetUserRoleAccess()
        {
            if (currentEmployee.Role == EmployeeRole.RegularEmployee)
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

        #endregion

        // Tina's comment: are these two methods not supposed to be inside a region?
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

            // button for creating an employee becomes visible
            btnCreateEmployee.Visible = true;

            // buttons for editting an employee becomes invisible
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

            // make the button for creating an employee invisible
            btnCreateEmployee.Visible = false;

            // the buttons and textboxes are changed before the panel is loaded to prevent them flickering after the panel loads
            // make the buttons for editting an employee visible
            btnDeleteEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;

            // Prefill input fields with selected employee's info
            PrefillEditInputs();

            ShowPanel(pnlAddEditUser);
        }
        private async void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            await employeeService.UpdateEmployeeAsync(selectedEmployee.EmployeeId, CreateEmployee());
            // confirm that the employee's info has been updated
            MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName}'s information has been updated.");
            ShowUsersView();
        }
        // prefill the textboxes and combobox
        private void PrefillTextbox()
        {
            textBoxFirstName.Text = selectedEmployee.FirstName;
            textBoxLastName.Text = selectedEmployee.LastName;
            comboBoxTypeUser.SelectedItem = selectedEmployee.Role.ToString();
            textBoxEmailAddress.Text = selectedEmployee.Email;
            textBoxPhoneNumber.Text = selectedEmployee.PhoneNumber;
            textBoxBranch.Text = selectedEmployee.Branch;
        }
        #endregion
        #region Delete employee logic
        // method to delete the employee (my poor amigo)
        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete())
            {
                await employeeService.DeleteEmployeeByID(selectedEmployee.EmployeeId);
                // confirm that the employee was deleted
                MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName} will be missed...");
                ShowUsersView();
            }
        }
        // ask the user to confirm deleting the employee
        private bool ConfirmDelete()
        {
            // add a message box to get confirmation for deleting them
            string messageTop = "Confirmation";
            string messageText = "Are you sure you wish to delete this employee?";
            return MessageBox.Show(messageText, messageTop, MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        #endregion
        private void btnCancelChangesEmployee_Click(object sender, EventArgs e)
        {
            ShowUsersView();
        }
        #region Users view and buttons control
        // method to show the panel, refresh the employees list and the buttons
        private async void ShowUsersView()
        {
            ShowPanel(pnlUsers);
            ChangeButtonState(btnEditEmployee, Color.LightGray, false);
            ChangeButtonState(btnAddEmployee, Color.LightGreen, true);
            await DisplayEmployeesAsync();
        }
        #endregion

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

            await DisplayTicketsAsync(currentEmployee);
            ChangeButtonState(btnEscalate, Color.LightGray, false);
        #region Tina Create/Update/Delete User Logic
        #region Create employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            lblAddEditUser.Text = "Create new employee";
            btnCreateEmployee.Visible = true;
            btnDeleteEmployee.Visible = false;
            btnUpdateEmployee.Visible = false;
            EmptyAllTextBox();
            ShowPanel(pnlAddEditUser);
        }
        private async void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            await employeeService.CreateEmployeeAsync(CreateEmployee());
            // i feel like this part could be written better
            ConfirmCreated(CreateEmployee());
            UsersView();
        }

        private Employee CreateEmployee()
        {
            try
            {
                string firstName = TextBoxEmpty(textBoxFirstName.Text, "The first name cannot be empty");
                string lastName = TextBoxEmpty(textBoxLastName.Text, "The last name cannot be empty");
                string email = TextBoxEmpty(textBoxEmailAddress.Text, "The e-mail address cannot be empty");
                string phoneNumber = TextBoxEmpty(textBoxFirstName.Text, "The phone number cannot be empty");
                if (!Enum.TryParse(comboBoxTypeUser.Text, out EmployeeRole employeeRole))
                    throw new Exception("Parsing the employee role failed.");
                string branch = TextBoxEmpty(textBoxBranch.Text, "The brnach cannot be empty");
                return new Employee(firstName, lastName, email, phoneNumber, employeeRole, branch);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }
        //  a method to make sure the textbox is not empty, if yes then throw an exception
        private string TextBoxEmpty(string textboxString, string errorMessage)
        {
            if (textboxString == null || textboxString == string.Empty)
                throw new Exception(errorMessage);

            return textboxString;
        }
        private void ConfirmCreated(Employee employee)
        {
            MessageBox.Show($"Warm welcome to {employee.FirstName} {employee.LastName}!");
            // I want it to play a happy song when an employee is added 
            //SoundPlayer player = new SoundPlayer(@"confetti.wav");
            //player.Play();
        }
        // making sure that all text boxes are empty for a new employee
        private void EmptyAllTextBox()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            comboBoxTypeUser.SelectedItem = null;
            textBoxEmailAddress.Text = "";
            textBoxPhoneNumber.Text = "";
            textBoxBranch.Text = "";
        }
        #endregion 
        #region Edit employee
        // method to make the edit employee button visible once the user has selected an employee
        // and make the add user btn invisible
        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                btnEditEmployee.Visible = true;
                btnAddEmployee.Visible = false;
            }
            // the add button becomes visible once you have unselected
            else
            {
                btnEditEmployee.Visible = false;
                btnAddEmployee.Visible = true;
            }
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // set the selected employee to the current selected item in the list view
            selectedEmployee = (Employee)usersList.SelectedItems[0].Tag;
            // refresh the students panel so new information shows up
            lblAddEditUser.Text = "Edit employee information";
            btnCreateEmployee.Visible = false;
            btnDeleteEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;
            ShowPanel(pnlAddEditUser);
            FillTexbox();
        }
        private async void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            await employeeService.UpdateEmployeeAsync(selectedEmployee.EmployeeId, CreateEmployee());
            MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName}'s information has been updated.");
            UsersView();
        }
        // prefill the textboxes
        private void FillTexbox()
        {
            textBoxFirstName.Text = selectedEmployee.FirstName;
            textBoxLastName.Text = selectedEmployee.LastName;
            comboBoxTypeUser.SelectedItem = selectedEmployee.Role.ToString();
            textBoxEmailAddress.Text = selectedEmployee.Email;
            textBoxPhoneNumber.Text = selectedEmployee.PhoneNumber;
            textBoxBranch.Text = selectedEmployee.Branch;
        }
        #endregion
        #region Delete employee logic
        // method to delete the employee (my poor amigo)
        private async void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (ConfirmDelete() == DialogResult.Yes)
            {
                await employeeService.DeleteEmployeeByID(selectedEmployee.EmployeeId);
                ConfirmDeleted();
                UsersView();
            }
        }
        // ask the user if they really wanna do this
        private DialogResult ConfirmDelete()
        {
            // add a message box to get confirmation for deleting them
            string messageTop = "Confirmation";
            string messageText = "Are you sure you wish to delete this employee?";
            return MessageBox.Show(messageText, messageTop, MessageBoxButtons.YesNo);
        }
        // confirm message that the employee was deleted
        private void ConfirmDeleted()
        {
            MessageBox.Show($"{selectedEmployee.FirstName} {selectedEmployee.LastName} will be missed...");
            // I want it to play a sad song when an employee is deleted 
            //SoundPlayer player = new SoundPlayer(@"sad-trumpet.wav");
            //player.Play();
        }
        #endregion
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            UsersView();
        }
        // method to show the panel, refresh the employees list and the buttons
        private async void UsersView()
        {
            ShowPanel(pnlUsers);
            btnEditEmployee.Visible = false;
            btnAddEmployee.Visible = true;
            await DisplayEmployeesAsync();
        }
        #endregion

        #region Tina Escalate Ticket
        //private void ticketsListView_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (ticketsListView.SelectedItems.Count > 0)
        //    {
        //        btnEscalate.Visible = true;
        //    }
        //    else
        //    {
        //        btnEscalate.Visible = false;
        //    }
        //}
        //private async void btnEscalate_Click(object sender, EventArgs e)
        //{
        //    selectedTicket = (Ticket)ticketsListView.SelectedItems[0].Tag;
        //    await ticketService.EscalateTicket(selectedTicket.TicketId);
        //    await DisplayTicketsAsync(currentEmployee);
        //}
        #endregion
    }
}