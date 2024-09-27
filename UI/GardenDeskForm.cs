using Model;
using Service;

namespace UI
{
    public partial class GardenDeskForm : Form
    {
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

        private async Task LoadEmployeesAsync()
        {
            EmployeeService employeeService = new();
            List<Employee> employees = await employeeService.GetAllEmployeesAsync();

            await DisplayEmployees(employees);
        }

        private async Task DisplayEmployees(List<Employee> employees)
        {
            usersList.Items.Clear();
            TicketService ticketService = new();

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

        #endregion

        #region Event Handlers

        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUsers);
            await LoadEmployeesAsync();
        }

        #endregion
    }
}
