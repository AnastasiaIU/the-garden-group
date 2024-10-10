using Model;
using Service;
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

        private async Task DisplayEmployeesAsync()
        {
            usersList.Items.Clear();
            List<Employee> employees = await employeeService.GetAllEmployeesAsync();

            foreach (var employee in employees)
            {
                int ticketsPerEmployee = await ticketService.CountTicketsForEmployeeAsync(employee.EmployeeId);

                ListViewItem item = new();

                item.SubItems.Add(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(ticketsPerEmployee.ToString());
                item.Tag = employee;

                usersList.Items.Add(item);
            }
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
                ShowPanel(pnlDashboard);
            }
        }

        #endregion

        #region Event Handlers

        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            UsersView();
            // Tina
            // this code kept being repeated in multiple other functions so I just made it its own method
            // the original code is below
            //ShowPanel(pnlUsers);
            //await DisplayEmployeesAsync();
        }

        private async void menuItemIncidents_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlTicketsOverview);
            await DisplayTicketsAsync(currentEmployee);
        }


        #endregion

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
                string phoneNumber = TextBoxEmpty(textBoxPhoneNumber.Text, "The phone number cannot be empty");
                if (!Enum.TryParse(comboBoxTypeUser.Text, out EmployeeRole employeeRole))
                    throw new Exception("Parsing the employee role failed.");
                string branch = TextBoxEmpty(textBoxBranch.Text, "The branch cannot be empty");
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
        private void ticketsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ticketsListView.SelectedItems.Count > 0)
            {
                btnEscalate.Visible = true;
            }
            else
            {
                btnEscalate.Visible = false;
            }
        }
        private async void btnEscalate_Click(object sender, EventArgs e)
        {
            selectedTicket = (Ticket)ticketsListView.SelectedItems[0].Tag;
            await ticketService.EscalateTicket(selectedTicket.TicketId);
            MessageBox.Show($"'{selectedTicket.Title}' has been escalated.");
            await DisplayTicketsAsync(currentEmployee);
        }
        #endregion
    }
}
