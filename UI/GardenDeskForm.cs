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
        private Ticket selectedTicket;
        private Employee selectedEmployee;

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
        // method to disable/enable buttons based on the employee role
        private void SetUserRoleAccess()
        {
            if (currentEmployee.Role == EmployeeRole.ServiceDeskEmployee)
            {
                btnEditEmployee.Visible = true;
                btnEscalate.Visible = true;
            }
            else
            {
                btnEditEmployee.Visible = false;
                btnEscalate.Visible = false;
                usersList.FullRowSelect = false;
                ticketsListView.FullRowSelect = false;
            }
        }
        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            ShowUsersView();
            // Tina
            // this code kept being repeated in multiple other functions so I just made it its own method
            // check the new method out cause it has multiple other functions
            // the original code is below
            //ShowPanel(pnlUsers);
            //await DisplayEmployeesAsync();
        }

        //Tina's comment
        //this method was repeated twice
        //private async void menuItemIncidents_Click(object sender, EventArgs e)
        //{
        //    ShowPanel(pnlTicketsOverview);
        //    await DisplayTicketsAsync(currentEmployee);
        //}


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


        #region Tina Create/Update/Delete User Logic
        #region Create employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            lblAddEditUser.Text = "Create new employee";

            // button for creating an employee becomes visible
            btnCreateEmployee.Visible = true;

            // buttons for editting an employee becomes invisible
            btnDeleteEmployee.Visible = false;
            btnUpdateEmployee.Visible = false;

            // make sure all text boxes are empty from previous edits
            EmptyAllTextBox();
            ShowPanel(pnlAddEditUser);
        }
        private async void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                Employee newEmployee = CreateEmployee();
                await employeeService.CreateEmployeeAsync(newEmployee);
                // create a method 
                MessageBox.Show($"Warm welcome to {newEmployee.FirstName} {newEmployee.LastName}!");
                // go back to the user view
                ShowUsersView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // method to create an employee object based on the user inputs
        private Employee CreateEmployee()
        {
            // check for each input if they're empty
            string firstName = IsInputBoxEmpty(textBoxFirstName.Text, "The first name cannot be empty");
            string lastName = IsInputBoxEmpty(textBoxLastName.Text, "The last name cannot be empty");
            string email = IsInputBoxEmpty(textBoxEmailAddress.Text, "The e-mail address cannot be empty");
            string phoneNumber = IsInputBoxEmpty(textBoxPhoneNumber.Text, "The phone number cannot be empty");
            // first making sure the combo box is not empty then parsing it
            // I could put a default selected text for combo box so you wouldn't have to check if it's empty
            // but then the user could not notice that something is already selected and they could make a mistake
            // and I'm designing for forgiveness here. I care about the user :(
            string employeeRoleInput = IsInputBoxEmpty(comboBoxTypeUser.Text, "The employee role cannot be empty");
            EmployeeRole employeeRole = (EmployeeRole)Enum.Parse(typeof(EmployeeRole), employeeRoleInput);
            string branch = IsInputBoxEmpty(textBoxBranch.Text, "The branch cannot be empty");
            return new Employee(firstName, lastName, email, phoneNumber, employeeRole, branch);
        }

        //  a method to make sure the textbox is not empty, if yes then throw an exception
        private string IsInputBoxEmpty(string inputBoxString, string errorMessage)
        {
            if (inputBoxString == string.Empty || inputBoxString == null)
                throw new Exception(errorMessage);

            return inputBoxString;
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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            // set the selected employee to the current selected item in the list view
            selectedEmployee = (Employee)usersList.SelectedItems[0].Tag;

            // refresh the students panel so new information shows up
            lblAddEditUser.Text = "Edit employee information";

            // make the button for creating an employee invisible
            btnCreateEmployee.Visible = false;

            // the buttons and textboxes are changed before the panel is loaded to prevent them flickering after the panel loads
            // make the buttons for editting an employee visible
            btnDeleteEmployee.Visible = true;
            btnUpdateEmployee.Visible = true;
            // Prefill the text boxes with selected users' info
            PrefillTextbox();

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

        // method to make the edit employee button enabled once the user has selected an employee
        // and make the add user btn disabled
        private void usersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                ChangeButtonState(btnEditEmployee, Color.Orange, true);
                ChangeButtonState(btnAddEmployee, Color.LightGray, false);
            }
            // the add button becomes enabled once you have unselected
            else
            {
                ChangeButtonState(btnEditEmployee, Color.LightGray, false);
                ChangeButtonState(btnAddEmployee, Color.LightGreen, true);
            }
        }

        // method to change the enablement and coloration of the buttons
        // Do you want this method to be outside of this region if others' also need to change a button or something?
        private void ChangeButtonState(Button button, Color color, bool enablement)
        {
            // Tina
            button.Enabled = enablement;
            button.BackColor = color;
        }
        #endregion
        #endregion
        #region Tina Escalate Ticket
        // if a ticket is selected the escalate button gets enabled, if not it becomes disabled
        private void ticketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                // set the global variable selectedTicket to the first thing that is selected
                selectedTicket = (Ticket)ticketsListView.SelectedItems[0].Tag;
                // making sure that the selected ticket is not already escalated or closed
                if (selectedTicket.IsEscalated == false && selectedTicket.Status != Status.Closed)
                {
                    ChangeButtonState(btnEscalate, Color.Tomato, true);
                }
            }
            else
            {
                ChangeButtonState(btnEscalate, Color.LightGray, false); ;
            }
        }
        private async void btnEscalate_Click(object sender, EventArgs e)
        {
            // escalate the ticket using the method from the service and dal layer
            await ticketService.EscalateTicket(selectedTicket.TicketId);

            // confirm that this ticket has been escalated
            MessageBox.Show($"'{selectedTicket.Title}' has been escalated.");

            // refresh the list of tickets again
            // I suggest making a method like ShowUsersView for Tickets as well
            await DisplayTicketsAsync(currentEmployee);
            ChangeButtonState(btnEscalate, Color.LightGray, false);
        }
        #endregion
    }
}