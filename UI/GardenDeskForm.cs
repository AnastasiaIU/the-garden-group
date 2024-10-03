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
            List<Ticket> openTickets = await ticketService.GetOpenTicketsForEmployeeAsync();
            List<ListViewItem> items = new();
            Dictionary<string, int> ticketCounts = ticketService.CountTickets(openTickets);
            FillListView(ticketCounts, employees, items);
            usersList.Items.AddRange(items.ToArray());
        }

        private void FillListView(Dictionary<string, int> ticketCounts, List<Employee> employees, List<ListViewItem> items)
        {
            foreach (var employee in employees)
            {
                int ticketsPerEmployee = ticketCounts.ContainsKey(employee.EmployeeId) ? ticketCounts[employee.EmployeeId] : 0;

                ListViewItem item = new();

                item.SubItems.Add(employee.EmployeeId.ToString());
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(employee.FirstName);
                item.SubItems.Add(employee.LastName);
                item.SubItems.Add(ticketsPerEmployee.ToString());
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