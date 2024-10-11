using Model;
using Service;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class GardenDeskForm : Form
    {
        private readonly EmployeeService employeeService = new();
        private readonly TicketService ticketService = new();
        private Employee? currentEmployee = null;

        private int numberOfOpenTickets;
        private int numberOfClosedTickets;
        private int numberOfResolvedTickets;
        private int numberOfAllTickets;

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

                await GetTicketsForCurrentEmployee();
                await LoadCharts();
            }
        }

        #endregion

        #region Dashboard Logic

        private async Task GetTicketsForCurrentEmployee()
        {
            if (currentEmployee.Role == EmployeeRole.ServiceDeskEmployee)
            {
                numberOfOpenTickets = await ticketService.CountOpenTicketsForServiceDeskUserAsync(currentEmployee.EmployeeId);
                numberOfClosedTickets = await ticketService.CountClosedTicketsForServiceDeskUserAsync(currentEmployee.EmployeeId);
                numberOfResolvedTickets = await ticketService.CountResolvedTicketsForServiceDeskUserAsync(currentEmployee.EmployeeId);
            }
            else
            {
                numberOfOpenTickets = await ticketService.CountOpenTicketsForReportingUserAsync(currentEmployee.EmployeeId);
                numberOfClosedTickets = await ticketService.CountClosedTicketsForReportingUserAsync(currentEmployee.EmployeeId);
                numberOfResolvedTickets = await ticketService.CountResolvedTicketsForReportingUserAsync(currentEmployee.EmployeeId);
            }
            numberOfAllTickets = await ticketService.CountTicketsForEmployeeAsync(currentEmployee.EmployeeId);
        }

        private async Task LoadCharts()
        {
            SetUpCharts();

            chartResolved.Series["s1"].Points.AddXY("", numberOfResolvedTickets);
            chartResolved.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfResolvedTickets);
            lblResolvedNumber.Text = $"{numberOfResolvedTickets}/{numberOfAllTickets}";

            chartOpen.Series["s1"].Points.AddXY("", numberOfOpenTickets);
            chartOpen.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfOpenTickets);
            lblOpenNumber.Text = $"{numberOfOpenTickets}/{numberOfAllTickets}";

            chartClosed.Series["s1"].Points.AddXY("", numberOfClosedTickets);
            chartClosed.Series["s1"].Points.AddXY("", numberOfAllTickets - numberOfClosedTickets);
            lblClosedNumber.Text = $"{numberOfClosedTickets}/{numberOfAllTickets}";

            chartResolved.Series["s1"].Points[0].Color = Color.Orange;
            chartResolved.Series["s1"].Points[1].Color = Color.Gray;

            chartOpen.Series["s1"].Points[0].Color = Color.Green;
            chartOpen.Series["s1"].Points[1].Color = Color.Gray;

            chartClosed.Series["s1"].Points[0].Color = Color.Red;
            chartClosed.Series["s1"].Points[1].Color = Color.Gray;
        }

        private async Task SetUpCharts()
        {
            foreach (Chart chart in pnlDashboard.Controls)
            {
                chart.Series.Clear();
                chart.Series.Add("s1");
                chart.Series[0].ChartType = SeriesChartType.Doughnut;
            }
        }

        #endregion

        #region Event Handlers

        private async void menuItemUsers_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlUsers);
            await DisplayEmployeesAsync();
        }

        private async void menuItemDashboard_Click(object sender, EventArgs e)
        {
            ShowPanel(pnlDashboard);
        }

        #endregion

        private void lblOpenNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblClosedNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
