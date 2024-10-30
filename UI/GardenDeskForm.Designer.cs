namespace UI
{
    partial class GardenDeskForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            ListViewItem listViewItem1 = new ListViewItem("");
            logo = new PictureBox();
            lblGardenDesk = new Label();
            lblLicense = new Label();
            menuStrip = new MenuStrip();
            menuItemDashboard = new ToolStripMenuItem();
            menuItemIncidents = new ToolStripMenuItem();
            menuItemUsers = new ToolStripMenuItem();
            pnlLogin = new Panel();
            btnLogin = new Button();
            lblLoginWrongCredentials = new Label();
            txtBoxLoginPassword = new TextBox();
            txtBoxLoginUsername = new TextBox();
            lblLoginPassword = new Label();
            lblLoginUsername = new Label();
            lblLoginPrompt = new Label();
            lblLoginGardenDesk = new Label();
            pnlDashboard = new Panel();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            lblOpenDescription = new Label();
            lblOpen = new Label();
            lblResolvedNumber = new Label();
            lblClosedNumber = new Label();
            lblOpenNumber = new Label();
            chartResolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartClosed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartOpen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblDashboard = new Label();
            splitterDashboard = new Splitter();
            pnlTicketsOverview = new Panel();
            sortExplanationLbl = new Label();
            SortByPriorityBtn = new Button();
            btnEditTicket = new Button();
            btnAddTicket = new Button();
            searchbtn = new Button();
            searchtextbox = new TextBox();
            btnEscalate = new Button();
            lblTicketsOverview = new Label();
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketDescription = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketDeadline = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            splitterTicketsOverview = new Splitter();
            pnlUsers = new Panel();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            usersList = new ListView();
            leftColumn = new ColumnHeader();
            userEmail = new ColumnHeader();
            userFirstName = new ColumnHeader();
            userLastName = new ColumnHeader();
            userTicketCount = new ColumnHeader();
            lblUsers = new Label();
            splitterUsers = new Splitter();
            pnlAddEditTicket = new Panel();
            descriptionTxtBox = new TextBox();
            titleTxtBox = new TextBox();
            deadlineCmbBox = new ComboBox();
            isResolvedCmbBox = new ComboBox();
            priorityCmbBox = new ComboBox();
            statusCmbBox = new ComboBox();
            typeOfAccidentCmbBox = new ComboBox();
            serviceDeskUserCmbBox = new ComboBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cancelTicketBtn = new Button();
            closeTicketBtn = new Button();
            editTicketBtn = new Button();
            addTicketBtn = new Button();
            splitterAddEditTicket = new Splitter();
            lblAddEditTicket = new Label();
            menuStripBackground = new PictureBox();
            pnlAddEditUser = new Panel();
            btnCreateEmployee = new Button();
            btnCancelChangesEmployee = new Button();
            btnUpdateEmployee = new Button();
            comboBoxTypeUser = new ComboBox();
            textBoxBranch = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxEmailAddress = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            lblBranchEdit = new Label();
            lblPhoneNumberEdit = new Label();
            lblEmailAddressEdit = new Label();
            lblTypeUserEdit = new Label();
            lblLastNameEdit = new Label();
            lblFirstNameEdit = new Label();
            btnDeleteEmployee = new Button();
            lblAddEditUser = new Label();
            splitterAddEditUser = new Splitter();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            menuStrip.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResolved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOpen).BeginInit();
            pnlTicketsOverview.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlAddEditTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuStripBackground).BeginInit();
            pnlAddEditUser.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(10, 0);
            logo.Margin = new Padding(2, 1, 2, 1);
            logo.Name = "logo";
            logo.Size = new Size(75, 75);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblGardenDesk
            // 
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(485, 0);
            lblGardenDesk.Margin = new Padding(2, 0, 2, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 7, 10, 0);
            lblGardenDesk.Size = new Size(149, 32);
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(457, 50);
            lblLicense.Margin = new Padding(2, 0, 2, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 10, 0);
            lblLicense.Size = new Size(179, 15);
            lblLicense.TabIndex = 2;
            lblLicense.Text = "Licensed to: The Garden Group";
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.White;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemDashboard, menuItemIncidents, menuItemUsers });
            menuStrip.Location = new Point(0, 80);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(3, 1, 0, 1);
            menuStrip.Size = new Size(634, 32);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.AutoSize = false;
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new Size(210, 30);
            menuItemDashboard.Text = "Dashboard";
            menuItemDashboard.Click += menuItemDashboard_Click;
            // 
            // menuItemIncidents
            // 
            menuItemIncidents.AutoSize = false;
            menuItemIncidents.Name = "menuItemIncidents";
            menuItemIncidents.Size = new Size(210, 30);
            menuItemIncidents.Text = "Incident Management";
            menuItemIncidents.Click += menuItemIncidents_Click;
            // 
            // menuItemUsers
            // 
            menuItemUsers.AutoSize = false;
            menuItemUsers.Name = "menuItemUsers";
            menuItemUsers.Size = new Size(210, 30);
            menuItemUsers.Text = "User Managment";
            menuItemUsers.Click += menuItemUsers_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(lblLoginWrongCredentials);
            pnlLogin.Controls.Add(txtBoxLoginPassword);
            pnlLogin.Controls.Add(txtBoxLoginUsername);
            pnlLogin.Controls.Add(lblLoginPassword);
            pnlLogin.Controls.Add(lblLoginUsername);
            pnlLogin.Controls.Add(lblLoginPrompt);
            pnlLogin.Controls.Add(lblLoginGardenDesk);
            pnlLogin.Location = new Point(0, 112);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(634, 599);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(242, 380);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += OnLoginButtonClick;
            // 
            // lblLoginWrongCredentials
            // 
            lblLoginWrongCredentials.AutoSize = true;
            lblLoginWrongCredentials.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWrongCredentials.ForeColor = Color.Red;
            lblLoginWrongCredentials.Location = new Point(167, 330);
            lblLoginWrongCredentials.Name = "lblLoginWrongCredentials";
            lblLoginWrongCredentials.Size = new Size(294, 21);
            lblLoginWrongCredentials.TabIndex = 0;
            lblLoginWrongCredentials.Text = "Wrong username or password. Try again.";
            lblLoginWrongCredentials.Visible = false;
            // 
            // txtBoxLoginPassword
            // 
            txtBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginPassword.Location = new Point(167, 280);
            txtBoxLoginPassword.Margin = new Padding(4);
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(300, 29);
            txtBoxLoginPassword.TabIndex = 2;
            txtBoxLoginPassword.KeyPress += OnTextBoxLoginKeyPress;
            // 
            // txtBoxLoginUsername
            // 
            txtBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginUsername.Location = new Point(167, 200);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(300, 29);
            txtBoxLoginUsername.TabIndex = 1;
            txtBoxLoginUsername.KeyPress += OnTextBoxLoginKeyPress;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(167, 250);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(79, 21);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(167, 170);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(84, 21);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(150, 70);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new Size(334, 100);
            lblLoginPrompt.TabIndex = 0;
            lblLoginPrompt.Text = "Please provide login credentials to log in to GardenDesk for The Garden Group.";
            lblLoginPrompt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLoginGardenDesk
            // 
            lblLoginGardenDesk.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginGardenDesk.Location = new Point(0, 0);
            lblLoginGardenDesk.Margin = new Padding(5, 0, 5, 0);
            lblLoginGardenDesk.Name = "lblLoginGardenDesk";
            lblLoginGardenDesk.Size = new Size(634, 37);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(label6);
            pnlDashboard.Controls.Add(label5);
            pnlDashboard.Controls.Add(label3);
            pnlDashboard.Controls.Add(label4);
            pnlDashboard.Controls.Add(label1);
            pnlDashboard.Controls.Add(label2);
            pnlDashboard.Controls.Add(lblOpenDescription);
            pnlDashboard.Controls.Add(lblOpen);
            pnlDashboard.Controls.Add(lblResolvedNumber);
            pnlDashboard.Controls.Add(lblClosedNumber);
            pnlDashboard.Controls.Add(lblOpenNumber);
            pnlDashboard.Controls.Add(chartResolved);
            pnlDashboard.Controls.Add(chartClosed);
            pnlDashboard.Controls.Add(chartOpen);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 112);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(634, 599);
            pnlDashboard.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(485, 151);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 15;
            label6.Text = "and closed";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(236, 151);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 14;
            label5.Text = "without resolving";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(423, 129);
            label3.Name = "label3";
            label3.Size = new Size(200, 20);
            label3.TabIndex = 13;
            label3.Text = "all tickets currently resolved";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(439, 89);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 12;
            label4.Text = "Resolved incidents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(205, 129);
            label1.Name = "label1";
            label1.Size = new Size(185, 20);
            label1.TabIndex = 11;
            label1.Text = "all tickets currently closed";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(217, 89);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 10;
            label2.Text = "Closed incidents";
            // 
            // lblOpenDescription
            // 
            lblOpenDescription.AutoSize = true;
            lblOpenDescription.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpenDescription.Location = new Point(5, 129);
            lblOpenDescription.Name = "lblOpenDescription";
            lblOpenDescription.Size = new Size(177, 20);
            lblOpenDescription.TabIndex = 9;
            lblOpenDescription.Text = "all tickets currently open";
            // 
            // lblOpen
            // 
            lblOpen.AutoSize = true;
            lblOpen.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpen.Location = new Point(17, 89);
            lblOpen.Name = "lblOpen";
            lblOpen.Size = new Size(145, 25);
            lblOpen.TabIndex = 8;
            lblOpen.Text = "Open incidents";
            // 
            // lblResolvedNumber
            // 
            lblResolvedNumber.AutoSize = true;
            lblResolvedNumber.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblResolvedNumber.Location = new Point(495, 418);
            lblResolvedNumber.Name = "lblResolvedNumber";
            lblResolvedNumber.Size = new Size(50, 19);
            lblResolvedNumber.TabIndex = 7;
            lblResolvedNumber.Text = "label3";
            // 
            // lblClosedNumber
            // 
            lblClosedNumber.AutoSize = true;
            lblClosedNumber.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblClosedNumber.Location = new Point(275, 418);
            lblClosedNumber.Name = "lblClosedNumber";
            lblClosedNumber.Size = new Size(50, 19);
            lblClosedNumber.TabIndex = 6;
            lblClosedNumber.Text = "label2";
            lblClosedNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOpenNumber
            // 
            lblOpenNumber.AutoSize = true;
            lblOpenNumber.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpenNumber.Location = new Point(71, 418);
            lblOpenNumber.Name = "lblOpenNumber";
            lblOpenNumber.Size = new Size(51, 20);
            lblOpenNumber.TabIndex = 5;
            lblOpenNumber.Text = "label1";
            lblOpenNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartResolved
            // 
            chartArea1.Name = "ChartArea1";
            chartResolved.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResolved.Legends.Add(legend1);
            chartResolved.Location = new Point(440, 235);
            chartResolved.Name = "chartResolved";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResolved.Series.Add(series1);
            chartResolved.Size = new Size(155, 180);
            chartResolved.TabIndex = 4;
            chartResolved.Text = "chart3";
            // 
            // chartClosed
            // 
            chartArea2.Name = "ChartArea1";
            chartClosed.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartClosed.Legends.Add(legend2);
            chartClosed.Location = new Point(228, 235);
            chartClosed.Name = "chartClosed";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartClosed.Series.Add(series2);
            chartClosed.Size = new Size(155, 180);
            chartClosed.TabIndex = 3;
            chartClosed.Text = "chart2";
            // 
            // chartOpen
            // 
            chartArea3.Name = "ChartArea1";
            chartOpen.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartOpen.Legends.Add(legend3);
            chartOpen.Location = new Point(23, 235);
            chartOpen.Name = "chartOpen";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartOpen.Series.Add(series3);
            chartOpen.Size = new Size(155, 180);
            chartOpen.TabIndex = 2;
            chartOpen.Text = "chart1";
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(228, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(197, 32);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Current incidents";
            // 
            // splitterDashboard
            // 
            splitterDashboard.BackColor = Color.Black;
            splitterDashboard.Dock = DockStyle.Top;
            splitterDashboard.Location = new Point(0, 0);
            splitterDashboard.Margin = new Padding(5);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(634, 1);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(sortExplanationLbl);
            pnlTicketsOverview.Controls.Add(SortByPriorityBtn);
            pnlTicketsOverview.Controls.Add(btnEditTicket);
            pnlTicketsOverview.Controls.Add(btnAddTicket);
            pnlTicketsOverview.Controls.Add(searchbtn);
            pnlTicketsOverview.Controls.Add(searchtextbox);
            pnlTicketsOverview.Controls.Add(btnEscalate);
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(ticketsListView);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 112);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(634, 599);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // sortExplanationLbl
            // 
            sortExplanationLbl.AutoSize = true;
            sortExplanationLbl.Font = new Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point);
            sortExplanationLbl.Location = new Point(457, 93);
            sortExplanationLbl.Name = "sortExplanationLbl";
            sortExplanationLbl.Size = new Size(0, 12);
            sortExplanationLbl.TabIndex = 9;
            // 
            // SortByPriorityBtn
            // 
            SortByPriorityBtn.BackColor = Color.Black;
            SortByPriorityBtn.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            SortByPriorityBtn.ForeColor = SystemColors.HighlightText;
            SortByPriorityBtn.Location = new Point(457, 55);
            SortByPriorityBtn.Name = "SortByPriorityBtn";
            SortByPriorityBtn.Size = new Size(154, 38);
            SortByPriorityBtn.TabIndex = 8;
            SortByPriorityBtn.Text = "SORT BY PRIORITY";
            SortByPriorityBtn.UseVisualStyleBackColor = false;
            SortByPriorityBtn.Click += SortByPriorityBtn_Click;
            // 
            // btnEditTicket
            // 
            btnEditTicket.BackColor = Color.LightGray;
            btnEditTicket.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditTicket.Location = new Point(400, 12);
            btnEditTicket.Name = "btnEditTicket";
            btnEditTicket.Size = new Size(100, 31);
            btnEditTicket.TabIndex = 7;
            btnEditTicket.Text = "EDIT TICKET";
            btnEditTicket.UseVisualStyleBackColor = false;
            btnEditTicket.Click += btnEditTicket_Click;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BackColor = Color.Black;
            btnAddTicket.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTicket.ForeColor = SystemColors.HighlightText;
            btnAddTicket.Location = new Point(291, 12);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(100, 31);
            btnAddTicket.TabIndex = 6;
            btnAddTicket.Text = "ADD TICKET";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Gray;
            searchbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = SystemColors.ButtonHighlight;
            searchbtn.Location = new Point(271, 55);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(93, 38);
            searchbtn.TabIndex = 5;
            searchbtn.Text = "SEARCH";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchtextbox
            // 
            searchtextbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            searchtextbox.Location = new Point(29, 64);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.PlaceholderText = "Search for tickets..";
            searchtextbox.Size = new Size(236, 25);
            searchtextbox.TabIndex = 4;
            // 
            // btnEscalate
            // 
            btnEscalate.BackColor = Color.LightGray;
            btnEscalate.Enabled = false;
            btnEscalate.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnEscalate.Location = new Point(511, 12);
            btnEscalate.Name = "btnEscalate";
            btnEscalate.Size = new Size(100, 31);
            btnEscalate.TabIndex = 3;
            btnEscalate.Text = "ESCALATE";
            btnEscalate.UseVisualStyleBackColor = false;
            btnEscalate.Click += btnEscalate_Click;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(19, 13);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Size = new Size(177, 30);
            lblTicketsOverview.TabIndex = 1;
            lblTicketsOverview.Text = "Tickets Overview";
            // 
            // ticketsListView
            // 
            ticketsListView.BackColor = SystemColors.InactiveCaption;
            ticketsListView.Columns.AddRange(new ColumnHeader[] { ticketTitle, ticketDescription, ticketReportingUser, ticketCreationDate, ticketDeadline, ticketStatus });
            ticketsListView.FullRowSelect = true;
            ticketsListView.Location = new Point(29, 110);
            ticketsListView.Margin = new Padding(2);
            ticketsListView.Name = "ticketsListView";
            ticketsListView.Size = new Size(582, 336);
            ticketsListView.TabIndex = 2;
            ticketsListView.UseCompatibleStateImageBehavior = false;
            ticketsListView.View = View.Details;
            ticketsListView.SelectedIndexChanged += ticketsListView_SelectedIndexChanged;
            // 
            // ticketTitle
            // 
            ticketTitle.Text = "Title";
            ticketTitle.Width = 350;
            // 
            // ticketDescription
            // 
            ticketDescription.Text = "Description";
            ticketDescription.Width = 300;
            // 
            // ticketReportingUser
            // 
            ticketReportingUser.Text = "Reported By";
            ticketReportingUser.Width = 130;
            // 
            // ticketCreationDate
            // 
            ticketCreationDate.Text = "Creation Date";
            ticketCreationDate.Width = 190;
            // 
            // ticketDeadline
            // 
            ticketDeadline.Text = "Deadline";
            ticketDeadline.Width = 190;
            // 
            // ticketStatus
            // 
            ticketStatus.Text = "Status";
            ticketStatus.Width = 100;
            // 
            // splitterTicketsOverview
            // 
            splitterTicketsOverview.BackColor = Color.Black;
            splitterTicketsOverview.Dock = DockStyle.Top;
            splitterTicketsOverview.Location = new Point(0, 0);
            splitterTicketsOverview.Margin = new Padding(5);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(634, 1);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(btnEditEmployee);
            pnlUsers.Controls.Add(btnAddEmployee);
            pnlUsers.Controls.Add(usersList);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Location = new Point(0, 112);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(634, 599);
            pnlUsers.TabIndex = 7;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.LightGray;
            btnEditEmployee.Enabled = false;
            btnEditEmployee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmployee.Location = new Point(353, 17);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(126, 31);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "EDIT EMPLOYEE";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditUser_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.LightGreen;
            btnAddEmployee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployee.Location = new Point(485, 17);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(126, 31);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "ADD EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // usersList
            // 
            usersList.BackColor = SystemColors.InactiveCaption;
            usersList.Columns.AddRange(new ColumnHeader[] { leftColumn, userEmail, userFirstName, userLastName, userTicketCount });
            usersList.FullRowSelect = true;
            listViewItem1.Tag = "ID";
            usersList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            usersList.Location = new Point(29, 63);
            usersList.Margin = new Padding(2);
            usersList.Name = "usersList";
            usersList.Size = new Size(582, 383);
            usersList.TabIndex = 2;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
            usersList.SelectedIndexChanged += usersList_SelectedIndexChanged;
            // 
            // leftColumn
            // 
            leftColumn.Text = "";
            leftColumn.Width = 0;
            // 
            // userEmail
            // 
            userEmail.Text = "Email";
            userEmail.Width = 200;
            // 
            // userFirstName
            // 
            userFirstName.Text = "First Name";
            userFirstName.Width = 150;
            // 
            // userLastName
            // 
            userLastName.Text = "Last Name";
            userLastName.Width = 150;
            // 
            // userTicketCount
            // 
            userTicketCount.Text = "#tickets";
            userTicketCount.Width = 100;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsers.ForeColor = SystemColors.ControlText;
            lblUsers.Location = new Point(19, 13);
            lblUsers.Margin = new Padding(2, 0, 2, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(191, 30);
            lblUsers.TabIndex = 1;
            lblUsers.Text = "User management";
            // 
            // splitterUsers
            // 
            splitterUsers.BackColor = Color.Black;
            splitterUsers.Dock = DockStyle.Top;
            splitterUsers.Location = new Point(0, 0);
            splitterUsers.Margin = new Padding(5);
            splitterUsers.Name = "splitterUsers";
            splitterUsers.Size = new Size(634, 1);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(descriptionTxtBox);
            pnlAddEditTicket.Controls.Add(titleTxtBox);
            pnlAddEditTicket.Controls.Add(deadlineCmbBox);
            pnlAddEditTicket.Controls.Add(isResolvedCmbBox);
            pnlAddEditTicket.Controls.Add(priorityCmbBox);
            pnlAddEditTicket.Controls.Add(statusCmbBox);
            pnlAddEditTicket.Controls.Add(typeOfAccidentCmbBox);
            pnlAddEditTicket.Controls.Add(serviceDeskUserCmbBox);
            pnlAddEditTicket.Controls.Add(label14);
            pnlAddEditTicket.Controls.Add(label13);
            pnlAddEditTicket.Controls.Add(label12);
            pnlAddEditTicket.Controls.Add(label11);
            pnlAddEditTicket.Controls.Add(label10);
            pnlAddEditTicket.Controls.Add(label9);
            pnlAddEditTicket.Controls.Add(label8);
            pnlAddEditTicket.Controls.Add(label7);
            pnlAddEditTicket.Controls.Add(cancelTicketBtn);
            pnlAddEditTicket.Controls.Add(closeTicketBtn);
            pnlAddEditTicket.Controls.Add(editTicketBtn);
            pnlAddEditTicket.Controls.Add(addTicketBtn);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 112);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(634, 599);
            pnlAddEditTicket.TabIndex = 8;
            // 
            // descriptionTxtBox
            // 
            descriptionTxtBox.Location = new Point(167, 316);
            descriptionTxtBox.Multiline = true;
            descriptionTxtBox.Name = "descriptionTxtBox";
            descriptionTxtBox.Size = new Size(216, 74);
            descriptionTxtBox.TabIndex = 21;
            // 
            // titleTxtBox
            // 
            titleTxtBox.Location = new Point(167, 91);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(216, 23);
            titleTxtBox.TabIndex = 20;
            // 
            // deadlineCmbBox
            // 
            deadlineCmbBox.FormattingEnabled = true;
            deadlineCmbBox.Items.AddRange(new object[] { "+ 7 days", "+ 14 days", "+ 28 days", "+ 6 months" });
            deadlineCmbBox.Location = new Point(167, 272);
            deadlineCmbBox.Name = "deadlineCmbBox";
            deadlineCmbBox.Size = new Size(121, 23);
            deadlineCmbBox.TabIndex = 19;
            // 
            // isResolvedCmbBox
            // 
            isResolvedCmbBox.FormattingEnabled = true;
            isResolvedCmbBox.Items.AddRange(new object[] { "Yes", "No" });
            isResolvedCmbBox.Location = new Point(167, 235);
            isResolvedCmbBox.Name = "isResolvedCmbBox";
            isResolvedCmbBox.Size = new Size(121, 23);
            isResolvedCmbBox.TabIndex = 18;
            // 
            // priorityCmbBox
            // 
            priorityCmbBox.FormattingEnabled = true;
            priorityCmbBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityCmbBox.Location = new Point(167, 200);
            priorityCmbBox.Name = "priorityCmbBox";
            priorityCmbBox.Size = new Size(121, 23);
            priorityCmbBox.TabIndex = 17;
            // 
            // statusCmbBox
            // 
            statusCmbBox.FormattingEnabled = true;
            statusCmbBox.Items.AddRange(new object[] { "Open", "Closed" });
            statusCmbBox.Location = new Point(167, 163);
            statusCmbBox.Name = "statusCmbBox";
            statusCmbBox.Size = new Size(121, 23);
            statusCmbBox.TabIndex = 16;
            // 
            // typeOfAccidentCmbBox
            // 
            typeOfAccidentCmbBox.FormattingEnabled = true;
            typeOfAccidentCmbBox.Items.AddRange(new object[] { "Software", "Service", "Hardware" });
            typeOfAccidentCmbBox.Location = new Point(167, 126);
            typeOfAccidentCmbBox.Name = "typeOfAccidentCmbBox";
            typeOfAccidentCmbBox.Size = new Size(121, 23);
            typeOfAccidentCmbBox.TabIndex = 15;
            // 
            // serviceDeskUserCmbBox
            // 
            serviceDeskUserCmbBox.FormattingEnabled = true;
            serviceDeskUserCmbBox.Location = new Point(167, 61);
            serviceDeskUserCmbBox.Name = "serviceDeskUserCmbBox";
            serviceDeskUserCmbBox.Size = new Size(121, 23);
            serviceDeskUserCmbBox.TabIndex = 14;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(52, 321);
            label14.Name = "label14";
            label14.Size = new Size(73, 15);
            label14.TabIndex = 13;
            label14.Text = "Description :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(52, 275);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 12;
            label13.Text = "Deadline :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 238);
            label12.Name = "label12";
            label12.Size = new Size(68, 15);
            label12.TabIndex = 11;
            label12.Text = "Is resolved :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 203);
            label11.Name = "label11";
            label11.Size = new Size(51, 15);
            label11.TabIndex = 10;
            label11.Text = "Priority :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(52, 166);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 9;
            label10.Text = "Status :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(52, 129);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 8;
            label9.Text = "Type of incident :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(52, 94);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 7;
            label8.Text = "Title :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 64);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 6;
            label7.Text = "Service desk user :";
            // 
            // cancelTicketBtn
            // 
            cancelTicketBtn.BackColor = Color.Black;
            cancelTicketBtn.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            cancelTicketBtn.ForeColor = SystemColors.HighlightText;
            cancelTicketBtn.Location = new Point(482, 409);
            cancelTicketBtn.Name = "cancelTicketBtn";
            cancelTicketBtn.Size = new Size(140, 40);
            cancelTicketBtn.TabIndex = 5;
            cancelTicketBtn.Text = "Cancel Changes";
            cancelTicketBtn.UseVisualStyleBackColor = false;
            cancelTicketBtn.Click += cancelTicketBtn_Click;
            // 
            // closeTicketBtn
            // 
            closeTicketBtn.BackColor = Color.Tomato;
            closeTicketBtn.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            closeTicketBtn.Location = new Point(157, 410);
            closeTicketBtn.Name = "closeTicketBtn";
            closeTicketBtn.Size = new Size(140, 40);
            closeTicketBtn.TabIndex = 4;
            closeTicketBtn.Text = "Close Ticket";
            closeTicketBtn.UseVisualStyleBackColor = false;
            closeTicketBtn.Click += closeTicketBtn_Click;
            // 
            // editTicketBtn
            // 
            editTicketBtn.BackColor = Color.Yellow;
            editTicketBtn.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            editTicketBtn.Location = new Point(321, 409);
            editTicketBtn.Name = "editTicketBtn";
            editTicketBtn.Size = new Size(140, 40);
            editTicketBtn.TabIndex = 3;
            editTicketBtn.Text = "Edit Ticket";
            editTicketBtn.UseVisualStyleBackColor = false;
            editTicketBtn.Click += editTicketBtn_Click;
            // 
            // addTicketBtn
            // 
            addTicketBtn.BackColor = Color.LightGreen;
            addTicketBtn.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            addTicketBtn.Location = new Point(321, 409);
            addTicketBtn.Name = "addTicketBtn";
            addTicketBtn.Size = new Size(140, 40);
            addTicketBtn.TabIndex = 2;
            addTicketBtn.Text = "Add Ticket";
            addTicketBtn.UseVisualStyleBackColor = false;
            addTicketBtn.Click += addTicketBtn_Click;
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(5);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(634, 1);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.AutoSize = true;
            lblAddEditTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(228, 17);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Size = new Size(176, 32);
            lblAddEditTicket.TabIndex = 1;
            lblAddEditTicket.Text = "Add/Edit Ticket";
            // 
            // menuStripBackground
            // 
            menuStripBackground.BackColor = Color.White;
            menuStripBackground.Location = new Point(0, 80);
            menuStripBackground.Name = "menuStripBackground";
            menuStripBackground.Size = new Size(634, 32);
            menuStripBackground.TabIndex = 9;
            menuStripBackground.TabStop = false;
            // 
            // pnlAddEditUser
            // 
            pnlAddEditUser.BackColor = Color.White;
            pnlAddEditUser.Controls.Add(btnCreateEmployee);
            pnlAddEditUser.Controls.Add(btnCancelChangesEmployee);
            pnlAddEditUser.Controls.Add(btnUpdateEmployee);
            pnlAddEditUser.Controls.Add(comboBoxTypeUser);
            pnlAddEditUser.Controls.Add(textBoxBranch);
            pnlAddEditUser.Controls.Add(textBoxPhoneNumber);
            pnlAddEditUser.Controls.Add(textBoxEmailAddress);
            pnlAddEditUser.Controls.Add(textBoxLastName);
            pnlAddEditUser.Controls.Add(textBoxFirstName);
            pnlAddEditUser.Controls.Add(lblBranchEdit);
            pnlAddEditUser.Controls.Add(lblPhoneNumberEdit);
            pnlAddEditUser.Controls.Add(lblEmailAddressEdit);
            pnlAddEditUser.Controls.Add(lblTypeUserEdit);
            pnlAddEditUser.Controls.Add(lblLastNameEdit);
            pnlAddEditUser.Controls.Add(lblFirstNameEdit);
            pnlAddEditUser.Controls.Add(btnDeleteEmployee);
            pnlAddEditUser.Controls.Add(lblAddEditUser);
            pnlAddEditUser.Controls.Add(splitterAddEditUser);
            pnlAddEditUser.Location = new Point(0, 112);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(634, 599);
            pnlAddEditUser.TabIndex = 10;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.LightGreen;
            btnCreateEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.Location = new Point(471, 406);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(140, 40);
            btnCreateEmployee.TabIndex = 17;
            btnCreateEmployee.Text = "Create Employee";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Visible = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnCancelChangesEmployee
            // 
            btnCancelChangesEmployee.BackColor = Color.Silver;
            btnCancelChangesEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelChangesEmployee.Location = new Point(321, 406);
            btnCancelChangesEmployee.Name = "btnCancelChangesEmployee";
            btnCancelChangesEmployee.Size = new Size(140, 40);
            btnCancelChangesEmployee.TabIndex = 16;
            btnCancelChangesEmployee.Text = "Cancel Changes";
            btnCancelChangesEmployee.UseVisualStyleBackColor = false;
            btnCancelChangesEmployee.Click += btnCancelChangesEmployee_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = Color.Orange;
            btnUpdateEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.Location = new Point(471, 406);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(140, 40);
            btnUpdateEmployee.TabIndex = 15;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // comboBoxTypeUser
            // 
            comboBoxTypeUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeUser.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeUser.FormattingEnabled = true;
            comboBoxTypeUser.Items.AddRange(new object[] { "RegularEmployee", "ServiceDeskEmployee" });
            comboBoxTypeUser.Location = new Point(199, 163);
            comboBoxTypeUser.Name = "comboBoxTypeUser";
            comboBoxTypeUser.Size = new Size(155, 25);
            comboBoxTypeUser.TabIndex = 14;
            // 
            // textBoxBranch
            // 
            textBoxBranch.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBranch.Location = new Point(199, 283);
            textBoxBranch.Name = "textBoxBranch";
            textBoxBranch.Size = new Size(155, 25);
            textBoxBranch.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(199, 243);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(155, 25);
            textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailAddress.Location = new Point(199, 203);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.Size = new Size(155, 25);
            textBoxEmailAddress.TabIndex = 11;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(199, 123);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(155, 25);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(199, 83);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(155, 25);
            textBoxFirstName.TabIndex = 9;
            // 
            // lblBranchEdit
            // 
            lblBranchEdit.AutoSize = true;
            lblBranchEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblBranchEdit.Location = new Point(36, 290);
            lblBranchEdit.Name = "lblBranchEdit";
            lblBranchEdit.Size = new Size(54, 19);
            lblBranchEdit.TabIndex = 8;
            lblBranchEdit.Text = "Branch:";
            // 
            // lblPhoneNumberEdit
            // 
            lblPhoneNumberEdit.AutoSize = true;
            lblPhoneNumberEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumberEdit.Location = new Point(36, 249);
            lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            lblPhoneNumberEdit.Size = new Size(103, 19);
            lblPhoneNumberEdit.TabIndex = 7;
            lblPhoneNumberEdit.Text = "Phone number:";
            // 
            // lblEmailAddressEdit
            // 
            lblEmailAddressEdit.AutoSize = true;
            lblEmailAddressEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailAddressEdit.Location = new Point(36, 210);
            lblEmailAddressEdit.Name = "lblEmailAddressEdit";
            lblEmailAddressEdit.Size = new Size(101, 19);
            lblEmailAddressEdit.TabIndex = 6;
            lblEmailAddressEdit.Text = "E-mail address:";
            // 
            // lblTypeUserEdit
            // 
            lblTypeUserEdit.AutoSize = true;
            lblTypeUserEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeUserEdit.Location = new Point(35, 169);
            lblTypeUserEdit.Name = "lblTypeUserEdit";
            lblTypeUserEdit.Size = new Size(90, 19);
            lblTypeUserEdit.TabIndex = 5;
            lblTypeUserEdit.Text = "Type of user: ";
            // 
            // lblLastNameEdit
            // 
            lblLastNameEdit.AutoSize = true;
            lblLastNameEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNameEdit.Location = new Point(35, 129);
            lblLastNameEdit.Name = "lblLastNameEdit";
            lblLastNameEdit.Size = new Size(75, 19);
            lblLastNameEdit.TabIndex = 4;
            lblLastNameEdit.Text = "Last name:";
            // 
            // lblFirstNameEdit
            // 
            lblFirstNameEdit.AutoSize = true;
            lblFirstNameEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstNameEdit.Location = new Point(35, 89);
            lblFirstNameEdit.Name = "lblFirstNameEdit";
            lblFirstNameEdit.Size = new Size(76, 19);
            lblFirstNameEdit.TabIndex = 3;
            lblFirstNameEdit.Text = "First name:";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Tomato;
            btnDeleteEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.Location = new Point(167, 406);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(140, 40);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(36, 29);
            lblAddEditUser.Margin = new Padding(5, 0, 5, 0);
            lblAddEditUser.Name = "lblAddEditUser";
            lblAddEditUser.Size = new Size(160, 32);
            lblAddEditUser.TabIndex = 1;
            lblAddEditUser.Text = "Add/Edit User";
            // 
            // splitterAddEditUser
            // 
            splitterAddEditUser.BackColor = Color.Black;
            splitterAddEditUser.Dock = DockStyle.Top;
            splitterAddEditUser.Location = new Point(0, 0);
            splitterAddEditUser.Margin = new Padding(5);
            splitterAddEditUser.Name = "splitterAddEditUser";
            splitterAddEditUser.Size = new Size(634, 2);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(634, 587);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlLogin);
            Controls.Add(pnlDashboard);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
            Controls.Add(menuStripBackground);
            Controls.Add(pnlUsers);
            Controls.Add(pnlAddEditUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip;
            Margin = new Padding(2, 1, 2, 1);
            Name = "GardenDeskForm";
            Text = "GardenDesk";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResolved).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOpen).EndInit();
            pnlTicketsOverview.ResumeLayout(false);
            pnlTicketsOverview.PerformLayout();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            pnlAddEditTicket.ResumeLayout(false);
            pnlAddEditTicket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuStripBackground).EndInit();
            pnlAddEditUser.ResumeLayout(false);
            pnlAddEditUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logo;
        private Label lblGardenDesk;
        private Label lblLicense;
        private MenuStrip menuStrip;
        private ToolStripMenuItem menuItemDashboard;
        private ToolStripMenuItem menuItemIncidents;
        private ToolStripMenuItem menuItemUsers;
        private Panel pnlLogin;
        private Panel pnlDashboard;
        private Splitter splitterDashboard;
        private Label lblDashboard;
        private Label lblLoginGardenDesk;
        private Panel pnlTicketsOverview;
        private Label lblTicketsOverview;
        private Splitter splitterTicketsOverview;
        private Panel pnlUsers;
        private Label lblUsers;
        private Splitter splitterUsers;
        private Panel pnlAddEditTicket;
        private Label lblAddEditTicket;
        private Splitter splitterAddEditTicket;
        private PictureBox menuStripBackground;
        private Panel pnlAddEditUser;
        private Label lblAddEditUser;
        private Splitter splitterAddEditUser;
        private Button btnLogin;
        private Label lblLoginWrongCredentials;
        private TextBox txtBoxLoginPassword;
        private TextBox txtBoxLoginUsername;
        private Label lblLoginPassword;
        private Label lblLoginUsername;
        private Label lblLoginPrompt;
        private ListView usersList;
        private ColumnHeader leftColumn;
        private ColumnHeader userEmail;
        private ColumnHeader userFirstName;
        private ColumnHeader userLastName;
        private ColumnHeader userTicketCount;
        private ListView ticketsListView;
        private ColumnHeader ticketTitle;
        private ColumnHeader ticketReportingUser;
        private ColumnHeader ticketDeadline;
        private ColumnHeader ticketStatus;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
        private Label lblFirstNameEdit;
        private Label lblTypeUserEdit;
        private Label lblLastNameEdit;
        private Label lblBranchEdit;
        private Label lblPhoneNumberEdit;
        private Label lblEmailAddressEdit;
        private TextBox textBoxEmailAddress;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxBranch;
        private ComboBox comboBoxTypeUser;
        private Button btnCancelChangesEmployee;
        private Button btnUpdateEmployee;
        private Button btnCreateEmployee;
        private Button btnEscalate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResolved;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClosed;
        private Label lblClosedNumber;
        private Label lblOpenNumber;
        private Label lblResolvedNumber;
        private Label lblOpenDescription;
        private Label lblOpen;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Button searchbtn;
        private TextBox searchtextbox;
        private ColumnHeader ticketCreationDate;
        private ColumnHeader ticketDescription;
        private Button btnEditTicket;
        private Button btnAddTicket;
        private Button cancelTicketBtn;
        private Button closeTicketBtn;
        private Button editTicketBtn;
        private Button addTicketBtn;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label13;
        private Label label14;
        private ComboBox statusCmbBox;
        private ComboBox typeOfAccidentCmbBox;
        private ComboBox serviceDeskUserCmbBox;
        private TextBox descriptionTxtBox;
        private TextBox titleTxtBox;
        private ComboBox deadlineCmbBox;
        private ComboBox isResolvedCmbBox;
        private ComboBox priorityCmbBox;
        private Button SortByPriorityBtn;
        private Label sortExplanationLbl;
    }
}
