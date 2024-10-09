using Model;
using Service;

namespace UI
{
    public partial class GardenDeskForm : Form
    {
        private readonly EmployeeService employeeService = new();
        private readonly TicketService ticketService = new();
        private Employee? currentEmployee = null;

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

                ticketsListView.Items.Add(item);
            }
        }

        private async void menuItemIncedents_Click(object sender, EventArgs e)
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
                ShowPanel(pnlDashboard);
            }
        }

        #endregion

        #region User Management Logic

        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUsers);

            if (currentEmployee.Role == EmployeeRole.RegularEmployee)
            {
                btnAddUser.Visible = false;
            }

            await DisplayEmployeesAsync();
        }

        private async Task DisplayEmployeesAsync()
        {
            usersList.Items.Clear();
            List<Employee> employees = await employeeService.GetAllEmployeesAsync();
            List<ListViewItem> items = new();
            FillListView(employees, items);
            usersList.Items.AddRange(items.ToArray());
        }

        private void FillListView(List<Employee> employees, List<ListViewItem> items)
        {
            foreach (var employee in employees)
            {
                ListViewItem item = new();

                item.SubItems.Add(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(employee.OpenTickets.ToString());
                item.Tag = employee;

                items.Add(item);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlAddEditUser);
        }

        #endregion
    }
}