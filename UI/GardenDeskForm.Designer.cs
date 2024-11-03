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
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip = new ToolStrip();
            menuItemDashboard = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            menuItemIncidents = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            menuItemUsers = new ToolStripMenuItem();
            logo = new PictureBox();
            lblGardenDesk = new Label();
            lblLicense = new Label();
            pnlLogin = new Panel();
            panelLoginHolder = new Panel();
            lblLoginLoading = new Label();
            lblLoginUsername = new Label();
            btnLogin = new Button();
            lblLoginPassword = new Label();
            lblLoginWrongCredentials = new Label();
            txtBoxLoginUsername = new TextBox();
            txtBoxLoginPassword = new TextBox();
            lblLoginPrompt = new Label();
            lblLoginGardenDesk = new Label();
            pnlDashboard = new Panel();
            splitterDashboard = new Splitter();
            panelChartHolder = new Panel();
            lblOpen = new Label();
            chartOpen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartClosed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            chartResolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label4 = new Label();
            lblOpenNumber = new Label();
            label1 = new Label();
            lblClosedNumber = new Label();
            label2 = new Label();
            lblResolvedNumber = new Label();
            lblOpenDescription = new Label();
            lblDashboard = new Label();
            pnlTicketsOverview = new Panel();
            splitterTicketsOverview = new Splitter();
            lblTicketsOverview = new Label();
            panelTicketsHolder = new Panel();
            txtBoxFilter = new TextBox();
            btnFilter = new Button();
            searchtextbox = new TextBox();
            btnAddTicket = new Button();
            label15 = new Label();
            searchbtn = new Button();
            SortOrderComboBox = new ComboBox();
            btnViewTicket = new Button();
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketDescription = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketDeadline = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            ticketPriority = new ColumnHeader();
            pnlUsers = new Panel();
            splitterUsers = new Splitter();
            panelUsersHandler = new Panel();
            usersList = new ListView();
            userEmail = new ColumnHeader();
            userFirstName = new ColumnHeader();
            userLastName = new ColumnHeader();
            userTicketCount = new ColumnHeader();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            lblUsers = new Label();
            pnlAddEditTicket = new Panel();
            splitterAddEditTicket = new Splitter();
            panelAddEditTicketHolder = new Panel();
            label7 = new Label();
            label8 = new Label();
            descriptionTxtBox = new TextBox();
            label9 = new Label();
            titleTxtBox = new TextBox();
            label10 = new Label();
            deadlineCmbBox = new ComboBox();
            label11 = new Label();
            isResolvedCmbBox = new ComboBox();
            label12 = new Label();
            priorityCmbBox = new ComboBox();
            label13 = new Label();
            statusCmbBox = new ComboBox();
            label14 = new Label();
            typeOfAccidentCmbBox = new ComboBox();
            serviceDeskUserCmbBox = new ComboBox();
            cancelTicketBtn = new Button();
            closeTicketBtn = new Button();
            editTicketBtn = new Button();
            addTicketBtn = new Button();
            lblAddEditTicket = new Label();
            pnlAddEditUser = new Panel();
            splitterAddEditUser = new Splitter();
            panelAddEditUserHolder = new Panel();
            lblAddEditUserError = new Label();
            lblFirstNameEdit = new Label();
            btnCreateEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnUpdateEmployee = new Button();
            lblLastNameEdit = new Label();
            lblTypeUserEdit = new Label();
            lblEmailAddressEdit = new Label();
            comboBoxTypeUser = new ComboBox();
            lblPhoneNumberEdit = new Label();
            textBoxBranch = new TextBox();
            lblBranchEdit = new Label();
            textBoxPhoneNumber = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxEmailAddress = new TextBox();
            textBoxLastName = new TextBox();
            btnCancelChangesEmployee = new Button();
            lblAddEditUser = new Label();
            pnlViewTicket = new Panel();
            panelViewTicketHolder = new Panel();
            cmbBoxServiceDesk = new ComboBox();
            btnCloseViewTicket = new Button();
            btnTransfer = new Button();
            btnEditTicket = new Button();
            btnEscalate = new Button();
            lblVTReportingUser = new Label();
            lblVTServiceDesk = new Label();
            lblVTDeadlineValue = new Label();
            lblVTTitle = new Label();
            lblVTDeadline = new Label();
            lblVTIncident = new Label();
            lblVTEscalatedValue = new Label();
            lblVTStatus = new Label();
            lblVTEscalated = new Label();
            lblVTPriority = new Label();
            lblVTReportingUserValue = new Label();
            lblVTResolved = new Label();
            lblVTCreationDate = new Label();
            lblVTDescriptionValue = new Label();
            lblVTDescription = new Label();
            lblVTCreationDateValue = new Label();
            lblVTServiceDeskValue = new Label();
            lblVTResolvedValue = new Label();
            lblVTTitleValue = new Label();
            lblVTPriorityValue = new Label();
            lblVTIncidentValue = new Label();
            lblVTStatusValue = new Label();
            splitterViewTicket = new Splitter();
            lblViewTicketTitle = new Label();
            pnlDbError = new Panel();
            databaseErrorMessageLbl = new Label();
            toolTipEscalated = new ToolTip(components);
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            pnlLogin.SuspendLayout();
            panelLoginHolder.SuspendLayout();
            pnlDashboard.SuspendLayout();
            panelChartHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResolved).BeginInit();
            pnlTicketsOverview.SuspendLayout();
            panelTicketsHolder.SuspendLayout();
            pnlUsers.SuspendLayout();
            panelUsersHandler.SuspendLayout();
            pnlAddEditTicket.SuspendLayout();
            panelAddEditTicketHolder.SuspendLayout();
            pnlAddEditUser.SuspendLayout();
            panelAddEditUserHolder.SuspendLayout();
            pnlViewTicket.SuspendLayout();
            panelViewTicketHolder.SuspendLayout();
            pnlDbError.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.AutoSize = false;
            menuStrip.BackColor = Color.White;
            menuStrip.BackgroundImageLayout = ImageLayout.None;
            menuStrip.CanOverflow = false;
            menuStrip.Dock = DockStyle.None;
            menuStrip.GripStyle = ToolStripGripStyle.Hidden;
            menuStrip.ImageScalingSize = new Size(32, 32);
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemDashboard, toolStripSeparator1, menuItemIncidents, toolStripSeparator2, menuItemUsers });
            menuStrip.Location = new Point(0, 80);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(3, 1, 0, 1);
            menuStrip.ShowItemToolTips = false;
            menuStrip.Size = new Size(784, 42);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.AutoSize = false;
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new Size(76, 40);
            menuItemDashboard.Text = "Dashboard";
            menuItemDashboard.Visible = false;
            menuItemDashboard.Click += menuItemDashboard_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 40);
            toolStripSeparator1.Visible = false;
            // 
            // menuItemIncidents
            // 
            menuItemIncidents.AutoSize = false;
            menuItemIncidents.Name = "menuItemIncidents";
            menuItemIncidents.Size = new Size(136, 40);
            menuItemIncidents.Text = "Incident Management";
            menuItemIncidents.Visible = false;
            menuItemIncidents.Click += menuItemIncidents_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 40);
            toolStripSeparator2.Visible = false;
            // 
            // menuItemUsers
            // 
            menuItemUsers.AutoSize = false;
            menuItemUsers.Name = "menuItemUsers";
            menuItemUsers.Size = new Size(110, 40);
            menuItemUsers.Text = "User Managment";
            menuItemUsers.Visible = false;
            menuItemUsers.Click += menuItemUsers_Click;
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
            lblGardenDesk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(570, 0);
            lblGardenDesk.Margin = new Padding(2, 0, 2, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 7, 10, 0);
            lblGardenDesk.Size = new Size(218, 32);
            lblGardenDesk.TabIndex = 0;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(549, 42);
            lblLicense.Margin = new Padding(2, 0, 2, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 10, 0);
            lblLicense.Size = new Size(242, 15);
            lblLicense.TabIndex = 0;
            lblLicense.Text = "Licensed to: The Garden Group";
            lblLicense.TextAlign = ContentAlignment.TopRight;
            // 
            // pnlLogin
            // 
            pnlLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLogin.AutoSize = true;
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(panelLoginHolder);
            pnlLogin.Controls.Add(lblLoginPrompt);
            pnlLogin.Controls.Add(lblLoginGardenDesk);
            pnlLogin.Location = new Point(0, 80);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(793, 803);
            pnlLogin.TabIndex = 0;
            pnlLogin.VisibleChanged += PanelLoginVisibilityChanged;
            // 
            // panelLoginHolder
            // 
            panelLoginHolder.Controls.Add(lblLoginLoading);
            panelLoginHolder.Controls.Add(lblLoginUsername);
            panelLoginHolder.Controls.Add(btnLogin);
            panelLoginHolder.Controls.Add(lblLoginPassword);
            panelLoginHolder.Controls.Add(lblLoginWrongCredentials);
            panelLoginHolder.Controls.Add(txtBoxLoginUsername);
            panelLoginHolder.Controls.Add(txtBoxLoginPassword);
            panelLoginHolder.Location = new Point(0, 180);
            panelLoginHolder.Name = "panelLoginHolder";
            panelLoginHolder.Size = new Size(300, 250);
            panelLoginHolder.TabIndex = 0;
            // 
            // lblLoginLoading
            // 
            lblLoginLoading.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginLoading.ForeColor = SystemColors.ControlText;
            lblLoginLoading.Location = new Point(0, 159);
            lblLoginLoading.Name = "lblLoginLoading";
            lblLoginLoading.Size = new Size(300, 21);
            lblLoginLoading.TabIndex = 0;
            lblLoginLoading.Text = "Trying to log in...";
            lblLoginLoading.TextAlign = ContentAlignment.TopCenter;
            lblLoginLoading.Visible = false;
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(0, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(84, 21);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(100, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += OnLoginButtonClick;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(0, 80);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(79, 21);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginWrongCredentials
            // 
            lblLoginWrongCredentials.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWrongCredentials.ForeColor = Color.Red;
            lblLoginWrongCredentials.Location = new Point(0, 159);
            lblLoginWrongCredentials.Name = "lblLoginWrongCredentials";
            lblLoginWrongCredentials.Size = new Size(300, 21);
            lblLoginWrongCredentials.TabIndex = 0;
            lblLoginWrongCredentials.Text = "Wrong username or password. Try again.";
            lblLoginWrongCredentials.TextAlign = ContentAlignment.TopCenter;
            lblLoginWrongCredentials.Visible = false;
            // 
            // txtBoxLoginUsername
            // 
            txtBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginUsername.Location = new Point(0, 30);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(300, 29);
            txtBoxLoginUsername.TabIndex = 0;
            txtBoxLoginUsername.TextChanged += OnTextBoxLoginTextChanged;
            // 
            // txtBoxLoginPassword
            // 
            txtBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginPassword.Location = new Point(0, 110);
            txtBoxLoginPassword.Margin = new Padding(4);
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(300, 29);
            txtBoxLoginPassword.TabIndex = 1;
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(0, 88);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Padding = new Padding(0, 20, 0, 0);
            lblLoginPrompt.Size = new Size(788, 62);
            lblLoginPrompt.TabIndex = 0;
            lblLoginPrompt.Text = "Please provide login credentials to log in to GardenDesk for The Garden Group.";
            lblLoginPrompt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLoginGardenDesk
            // 
            lblLoginGardenDesk.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblLoginGardenDesk.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginGardenDesk.Location = new Point(0, 42);
            lblLoginGardenDesk.Margin = new Padding(5, 0, 5, 0);
            lblLoginGardenDesk.Name = "lblLoginGardenDesk";
            lblLoginGardenDesk.Padding = new Padding(0, 10, 0, 0);
            lblLoginGardenDesk.Size = new Size(793, 46);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Controls.Add(panelChartHolder);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new Point(0, 122);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(784, 761);
            pnlDashboard.TabIndex = 0;
            // 
            // splitterDashboard
            // 
            splitterDashboard.BackColor = SystemColors.ControlDark;
            splitterDashboard.Dock = DockStyle.Top;
            splitterDashboard.Location = new Point(0, 0);
            splitterDashboard.Margin = new Padding(5);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(784, 1);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // panelChartHolder
            // 
            panelChartHolder.Controls.Add(lblOpen);
            panelChartHolder.Controls.Add(chartOpen);
            panelChartHolder.Controls.Add(chartClosed);
            panelChartHolder.Controls.Add(label3);
            panelChartHolder.Controls.Add(chartResolved);
            panelChartHolder.Controls.Add(label4);
            panelChartHolder.Controls.Add(lblOpenNumber);
            panelChartHolder.Controls.Add(label1);
            panelChartHolder.Controls.Add(lblClosedNumber);
            panelChartHolder.Controls.Add(label2);
            panelChartHolder.Controls.Add(lblResolvedNumber);
            panelChartHolder.Controls.Add(lblOpenDescription);
            panelChartHolder.Location = new Point(0, 80);
            panelChartHolder.Name = "panelChartHolder";
            panelChartHolder.Size = new Size(700, 310);
            panelChartHolder.TabIndex = 16;
            // 
            // lblOpen
            // 
            lblOpen.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpen.Location = new Point(0, 0);
            lblOpen.Name = "lblOpen";
            lblOpen.Size = new Size(200, 25);
            lblOpen.TabIndex = 0;
            lblOpen.Text = "Open incidents";
            lblOpen.TextAlign = ContentAlignment.TopCenter;
            // 
            // chartOpen
            // 
            chartArea1.Name = "ChartArea1";
            chartOpen.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOpen.Legends.Add(legend1);
            chartOpen.Location = new Point(25, 108);
            chartOpen.Name = "chartOpen";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOpen.Series.Add(series1);
            chartOpen.Size = new Size(150, 180);
            chartOpen.TabIndex = 2;
            chartOpen.TabStop = false;
            chartOpen.Text = "chart1";
            // 
            // chartClosed
            // 
            chartArea2.Name = "ChartArea1";
            chartClosed.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartClosed.Legends.Add(legend2);
            chartClosed.Location = new Point(275, 108);
            chartClosed.Name = "chartClosed";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartClosed.Series.Add(series2);
            chartClosed.Size = new Size(150, 180);
            chartClosed.TabIndex = 0;
            chartClosed.TabStop = false;
            chartClosed.Text = "chart2";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(500, 25);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 10, 0, 0);
            label3.Size = new Size(200, 65);
            label3.TabIndex = 13;
            label3.Text = "all tickets currently resolved and closed";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // chartResolved
            // 
            chartArea3.Name = "ChartArea1";
            chartResolved.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartResolved.Legends.Add(legend3);
            chartResolved.Location = new Point(525, 108);
            chartResolved.Name = "chartResolved";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartResolved.Series.Add(series3);
            chartResolved.Size = new Size(150, 180);
            chartResolved.TabIndex = 0;
            chartResolved.TabStop = false;
            chartResolved.Text = "chart3";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(500, 0);
            label4.Name = "label4";
            label4.Size = new Size(200, 25);
            label4.TabIndex = 12;
            label4.Text = "Resolved incidents";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpenNumber
            // 
            lblOpenNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblOpenNumber.Location = new Point(0, 288);
            lblOpenNumber.Name = "lblOpenNumber";
            lblOpenNumber.Size = new Size(200, 20);
            lblOpenNumber.TabIndex = 5;
            lblOpenNumber.Text = "label1";
            lblOpenNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 25);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 10, 0, 0);
            label1.Size = new Size(200, 65);
            label1.TabIndex = 11;
            label1.Text = "all tickets currently closed without resolving";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblClosedNumber
            // 
            lblClosedNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClosedNumber.Location = new Point(250, 288);
            lblClosedNumber.Name = "lblClosedNumber";
            lblClosedNumber.Size = new Size(200, 20);
            lblClosedNumber.TabIndex = 0;
            lblClosedNumber.Text = "label2";
            lblClosedNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 0);
            label2.Name = "label2";
            label2.Size = new Size(200, 25);
            label2.TabIndex = 0;
            label2.Text = "Closed incidents";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblResolvedNumber
            // 
            lblResolvedNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblResolvedNumber.Location = new Point(500, 288);
            lblResolvedNumber.Name = "lblResolvedNumber";
            lblResolvedNumber.Size = new Size(200, 20);
            lblResolvedNumber.TabIndex = 0;
            lblResolvedNumber.Text = "label3";
            lblResolvedNumber.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblOpenDescription
            // 
            lblOpenDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOpenDescription.Location = new Point(0, 25);
            lblOpenDescription.Name = "lblOpenDescription";
            lblOpenDescription.Padding = new Padding(0, 10, 0, 0);
            lblOpenDescription.Size = new Size(200, 65);
            lblOpenDescription.TabIndex = 9;
            lblOpenDescription.Text = "all tickets currently open";
            lblOpenDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDashboard
            // 
            lblDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDashboard.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblDashboard.Location = new Point(0, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Padding = new Padding(0, 10, 0, 0);
            lblDashboard.Size = new Size(784, 46);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Current incidents";
            lblDashboard.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlTicketsOverview.AutoScroll = true;
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(panelTicketsHolder);
            pnlTicketsOverview.Location = new Point(0, 122);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(784, 758);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // splitterTicketsOverview
            // 
            splitterTicketsOverview.BackColor = SystemColors.ControlDark;
            splitterTicketsOverview.Dock = DockStyle.Top;
            splitterTicketsOverview.Location = new Point(0, 0);
            splitterTicketsOverview.Margin = new Padding(5);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(784, 1);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTicketsOverview.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(0, 0);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Padding = new Padding(0, 10, 0, 0);
            lblTicketsOverview.Size = new Size(784, 46);
            lblTicketsOverview.TabIndex = 0;
            lblTicketsOverview.Text = "Tickets overview";
            lblTicketsOverview.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelTicketsHolder
            // 
            panelTicketsHolder.Controls.Add(txtBoxFilter);
            panelTicketsHolder.Controls.Add(btnFilter);
            panelTicketsHolder.Controls.Add(searchtextbox);
            panelTicketsHolder.Controls.Add(btnAddTicket);
            panelTicketsHolder.Controls.Add(label15);
            panelTicketsHolder.Controls.Add(searchbtn);
            panelTicketsHolder.Controls.Add(SortOrderComboBox);
            panelTicketsHolder.Controls.Add(btnViewTicket);
            panelTicketsHolder.Controls.Add(ticketsListView);
            panelTicketsHolder.Location = new Point(0, 70);
            panelTicketsHolder.Name = "panelTicketsHolder";
            panelTicketsHolder.Size = new Size(780, 660);
            panelTicketsHolder.TabIndex = 8;
            // 
            // txtBoxFilter
            // 
            txtBoxFilter.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFilter.Location = new Point(0, 50);
            txtBoxFilter.Name = "txtBoxFilter";
            txtBoxFilter.PlaceholderText = "Filter by common keywords";
            txtBoxFilter.Size = new Size(300, 29);
            txtBoxFilter.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.OliveDrab;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(320, 49);
            btnFilter.Margin = new Padding(0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 30);
            btnFilter.TabIndex = 3;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // searchtextbox
            // 
            searchtextbox.BorderStyle = BorderStyle.FixedSingle;
            searchtextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchtextbox.Location = new Point(0, 1);
            searchtextbox.Name = "searchtextbox";
            searchtextbox.PlaceholderText = "Search by title or description";
            searchtextbox.Size = new Size(300, 29);
            searchtextbox.TabIndex = 0;
            // 
            // btnAddTicket
            // 
            btnAddTicket.BackColor = Color.Peru;
            btnAddTicket.FlatAppearance.BorderSize = 0;
            btnAddTicket.FlatStyle = FlatStyle.Flat;
            btnAddTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddTicket.ForeColor = Color.White;
            btnAddTicket.Location = new Point(638, 50);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(142, 30);
            btnAddTicket.TabIndex = 7;
            btnAddTicket.Text = "ADD TICKET";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(478, 3);
            label15.Name = "label15";
            label15.Size = new Size(122, 21);
            label15.TabIndex = 0;
            label15.Text = "Sort by priority :";
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.OliveDrab;
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(320, 0);
            searchbtn.Margin = new Padding(0);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(100, 30);
            searchbtn.TabIndex = 1;
            searchbtn.Text = "SEARCH";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // SortOrderComboBox
            // 
            SortOrderComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SortOrderComboBox.FormattingEnabled = true;
            SortOrderComboBox.Items.AddRange(new object[] { "Low to High", "High to Low" });
            SortOrderComboBox.Location = new Point(610, 0);
            SortOrderComboBox.Name = "SortOrderComboBox";
            SortOrderComboBox.Size = new Size(170, 29);
            SortOrderComboBox.TabIndex = 4;
            SortOrderComboBox.SelectedIndexChanged += SortOrderComboBox_SelectedIndexChanged;
            // 
            // btnViewTicket
            // 
            btnViewTicket.BackColor = Color.LightGray;
            btnViewTicket.Enabled = false;
            btnViewTicket.FlatAppearance.BorderSize = 0;
            btnViewTicket.FlatStyle = FlatStyle.Flat;
            btnViewTicket.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewTicket.ForeColor = SystemColors.ControlText;
            btnViewTicket.Location = new Point(478, 50);
            btnViewTicket.Name = "btnViewTicket";
            btnViewTicket.Size = new Size(142, 30);
            btnViewTicket.TabIndex = 6;
            btnViewTicket.Text = "VIEW TICKET";
            btnViewTicket.UseVisualStyleBackColor = false;
            btnViewTicket.Click += OnViewTicketButtonClick;
            // 
            // ticketsListView
            // 
            ticketsListView.AutoArrange = false;
            ticketsListView.BackColor = SystemColors.Control;
            ticketsListView.BorderStyle = BorderStyle.FixedSingle;
            ticketsListView.Columns.AddRange(new ColumnHeader[] { ticketTitle, ticketDescription, ticketReportingUser, ticketCreationDate, ticketDeadline, ticketStatus, ticketPriority });
            ticketsListView.FullRowSelect = true;
            ticketsListView.GridLines = true;
            ticketsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ticketsListView.Location = new Point(0, 100);
            ticketsListView.Margin = new Padding(2);
            ticketsListView.MultiSelect = false;
            ticketsListView.Name = "ticketsListView";
            ticketsListView.Size = new Size(780, 450);
            ticketsListView.TabIndex = 5;
            ticketsListView.UseCompatibleStateImageBehavior = false;
            ticketsListView.View = View.Details;
            ticketsListView.SelectedIndexChanged += ticketsListView_SelectedIndexChanged;
            ticketsListView.MouseMove += ticketsListView_MouseMove;
            // 
            // ticketTitle
            // 
            ticketTitle.Tag = "";
            ticketTitle.Text = "Title";
            ticketTitle.Width = 100;
            // 
            // ticketDescription
            // 
            ticketDescription.Tag = "";
            ticketDescription.Text = "Description";
            ticketDescription.Width = 100;
            // 
            // ticketReportingUser
            // 
            ticketReportingUser.Tag = "";
            ticketReportingUser.Text = "Reported by";
            ticketReportingUser.Width = 100;
            // 
            // ticketCreationDate
            // 
            ticketCreationDate.Tag = "";
            ticketCreationDate.Text = "Creation date";
            ticketCreationDate.Width = 100;
            // 
            // ticketDeadline
            // 
            ticketDeadline.Tag = "";
            ticketDeadline.Text = "Deadline";
            ticketDeadline.Width = 100;
            // 
            // ticketStatus
            // 
            ticketStatus.Tag = "";
            ticketStatus.Text = "Status";
            ticketStatus.Width = 100;
            // 
            // ticketPriority
            // 
            ticketPriority.Text = "Priority";
            ticketPriority.Width = 100;
            // 
            // pnlUsers
            // 
            pnlUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Controls.Add(panelUsersHandler);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Location = new Point(0, 122);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(784, 758);
            pnlUsers.TabIndex = 0;
            // 
            // splitterUsers
            // 
            splitterUsers.BackColor = SystemColors.ControlDark;
            splitterUsers.Dock = DockStyle.Top;
            splitterUsers.Location = new Point(0, 0);
            splitterUsers.Margin = new Padding(5);
            splitterUsers.Name = "splitterUsers";
            splitterUsers.Size = new Size(784, 1);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // panelUsersHandler
            // 
            panelUsersHandler.Controls.Add(usersList);
            panelUsersHandler.Controls.Add(btnEditEmployee);
            panelUsersHandler.Controls.Add(btnAddEmployee);
            panelUsersHandler.Location = new Point(0, 70);
            panelUsersHandler.Name = "panelUsersHandler";
            panelUsersHandler.Size = new Size(780, 550);
            panelUsersHandler.TabIndex = 0;
            // 
            // usersList
            // 
            usersList.BackColor = SystemColors.Control;
            usersList.BorderStyle = BorderStyle.FixedSingle;
            usersList.Columns.AddRange(new ColumnHeader[] { userEmail, userFirstName, userLastName, userTicketCount });
            usersList.FullRowSelect = true;
            usersList.GridLines = true;
            usersList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            usersList.Location = new Point(0, 0);
            usersList.Margin = new Padding(2);
            usersList.Name = "usersList";
            usersList.Size = new Size(780, 500);
            usersList.TabIndex = 0;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
            usersList.SelectedIndexChanged += usersList_SelectedIndexChanged;
            // 
            // userEmail
            // 
            userEmail.Text = "Email";
            userEmail.Width = 200;
            // 
            // userFirstName
            // 
            userFirstName.Text = "First name";
            userFirstName.Width = 150;
            // 
            // userLastName
            // 
            userLastName.Text = "Last name";
            userLastName.Width = 150;
            // 
            // userTicketCount
            // 
            userTicketCount.Text = "Number of tickets";
            userTicketCount.Width = 150;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.LightGray;
            btnEditEmployee.Enabled = false;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmployee.Location = new Point(160, 515);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(150, 30);
            btnEditEmployee.TabIndex = 2;
            btnEditEmployee.Text = "EDIT EMPLOYEE";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Click += btnEditUser_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.OliveDrab;
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddEmployee.ForeColor = Color.WhiteSmoke;
            btnAddEmployee.Location = new Point(0, 515);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(150, 30);
            btnAddEmployee.TabIndex = 1;
            btnAddEmployee.Text = "ADD EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lblUsers
            // 
            lblUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUsers.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsers.ForeColor = SystemColors.ControlText;
            lblUsers.Location = new Point(0, 0);
            lblUsers.Margin = new Padding(2, 0, 2, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Padding = new Padding(0, 10, 0, 0);
            lblUsers.Size = new Size(784, 46);
            lblUsers.TabIndex = 0;
            lblUsers.Text = "User management";
            lblUsers.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Controls.Add(panelAddEditTicketHolder);
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 122);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(784, 758);
            pnlAddEditTicket.TabIndex = 0;
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = SystemColors.ControlDark;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(5);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(784, 1);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // panelAddEditTicketHolder
            // 
            panelAddEditTicketHolder.Controls.Add(label7);
            panelAddEditTicketHolder.Controls.Add(label8);
            panelAddEditTicketHolder.Controls.Add(descriptionTxtBox);
            panelAddEditTicketHolder.Controls.Add(label9);
            panelAddEditTicketHolder.Controls.Add(titleTxtBox);
            panelAddEditTicketHolder.Controls.Add(label10);
            panelAddEditTicketHolder.Controls.Add(deadlineCmbBox);
            panelAddEditTicketHolder.Controls.Add(label11);
            panelAddEditTicketHolder.Controls.Add(isResolvedCmbBox);
            panelAddEditTicketHolder.Controls.Add(label12);
            panelAddEditTicketHolder.Controls.Add(priorityCmbBox);
            panelAddEditTicketHolder.Controls.Add(label13);
            panelAddEditTicketHolder.Controls.Add(statusCmbBox);
            panelAddEditTicketHolder.Controls.Add(label14);
            panelAddEditTicketHolder.Controls.Add(typeOfAccidentCmbBox);
            panelAddEditTicketHolder.Controls.Add(serviceDeskUserCmbBox);
            panelAddEditTicketHolder.Controls.Add(cancelTicketBtn);
            panelAddEditTicketHolder.Controls.Add(closeTicketBtn);
            panelAddEditTicketHolder.Controls.Add(editTicketBtn);
            panelAddEditTicketHolder.Controls.Add(addTicketBtn);
            panelAddEditTicketHolder.Location = new Point(0, 70);
            panelAddEditTicketHolder.Name = "panelAddEditTicketHolder";
            panelAddEditTicketHolder.Size = new Size(470, 430);
            panelAddEditTicketHolder.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(0, 4);
            label7.Name = "label7";
            label7.Size = new Size(137, 21);
            label7.TabIndex = 6;
            label7.Text = "Service desk user :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, 42);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 7;
            label8.Text = "Title :";
            // 
            // descriptionTxtBox
            // 
            descriptionTxtBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTxtBox.Location = new Point(165, 290);
            descriptionTxtBox.Multiline = true;
            descriptionTxtBox.Name = "descriptionTxtBox";
            descriptionTxtBox.Size = new Size(250, 80);
            descriptionTxtBox.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(0, 83);
            label9.Name = "label9";
            label9.Size = new Size(126, 21);
            label9.TabIndex = 8;
            label9.Text = "Type of incident :";
            // 
            // titleTxtBox
            // 
            titleTxtBox.BorderStyle = BorderStyle.FixedSingle;
            titleTxtBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTxtBox.Location = new Point(165, 40);
            titleTxtBox.Name = "titleTxtBox";
            titleTxtBox.Size = new Size(200, 29);
            titleTxtBox.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(0, 123);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 9;
            label10.Text = "Status :";
            // 
            // deadlineCmbBox
            // 
            deadlineCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deadlineCmbBox.FormattingEnabled = true;
            deadlineCmbBox.Items.AddRange(new object[] { "+ 7 days", "+ 14 days", "+ 28 days", "+ 6 months" });
            deadlineCmbBox.Location = new Point(165, 240);
            deadlineCmbBox.Name = "deadlineCmbBox";
            deadlineCmbBox.Size = new Size(200, 29);
            deadlineCmbBox.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(0, 163);
            label11.Name = "label11";
            label11.Size = new Size(68, 21);
            label11.TabIndex = 10;
            label11.Text = "Priority :";
            // 
            // isResolvedCmbBox
            // 
            isResolvedCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            isResolvedCmbBox.FormattingEnabled = true;
            isResolvedCmbBox.Items.AddRange(new object[] { "Yes", "No" });
            isResolvedCmbBox.Location = new Point(165, 200);
            isResolvedCmbBox.Name = "isResolvedCmbBox";
            isResolvedCmbBox.Size = new Size(200, 29);
            isResolvedCmbBox.TabIndex = 5;
            isResolvedCmbBox.SelectedIndexChanged += isResolvedCmbBox_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(0, 203);
            label12.Name = "label12";
            label12.Size = new Size(91, 21);
            label12.TabIndex = 11;
            label12.Text = "Is resolved :";
            // 
            // priorityCmbBox
            // 
            priorityCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priorityCmbBox.FormattingEnabled = true;
            priorityCmbBox.Items.AddRange(new object[] { "Low", "Medium", "High" });
            priorityCmbBox.Location = new Point(165, 160);
            priorityCmbBox.Name = "priorityCmbBox";
            priorityCmbBox.Size = new Size(200, 29);
            priorityCmbBox.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(0, 243);
            label13.Name = "label13";
            label13.Size = new Size(78, 21);
            label13.TabIndex = 12;
            label13.Text = "Deadline :";
            // 
            // statusCmbBox
            // 
            statusCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            statusCmbBox.FormattingEnabled = true;
            statusCmbBox.Items.AddRange(new object[] { "Open", "Closed" });
            statusCmbBox.Location = new Point(165, 120);
            statusCmbBox.Name = "statusCmbBox";
            statusCmbBox.Size = new Size(200, 29);
            statusCmbBox.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(0, 292);
            label14.Name = "label14";
            label14.Size = new Size(96, 21);
            label14.TabIndex = 13;
            label14.Text = "Description :";
            // 
            // typeOfAccidentCmbBox
            // 
            typeOfAccidentCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            typeOfAccidentCmbBox.FormattingEnabled = true;
            typeOfAccidentCmbBox.Items.AddRange(new object[] { "Software", "Service", "Hardware" });
            typeOfAccidentCmbBox.Location = new Point(165, 80);
            typeOfAccidentCmbBox.Name = "typeOfAccidentCmbBox";
            typeOfAccidentCmbBox.Size = new Size(200, 29);
            typeOfAccidentCmbBox.TabIndex = 2;
            // 
            // serviceDeskUserCmbBox
            // 
            serviceDeskUserCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceDeskUserCmbBox.FormattingEnabled = true;
            serviceDeskUserCmbBox.Location = new Point(165, 0);
            serviceDeskUserCmbBox.Name = "serviceDeskUserCmbBox";
            serviceDeskUserCmbBox.Size = new Size(200, 29);
            serviceDeskUserCmbBox.TabIndex = 0;
            // 
            // cancelTicketBtn
            // 
            cancelTicketBtn.BackColor = Color.DimGray;
            cancelTicketBtn.FlatAppearance.BorderSize = 0;
            cancelTicketBtn.FlatStyle = FlatStyle.Flat;
            cancelTicketBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cancelTicketBtn.ForeColor = Color.White;
            cancelTicketBtn.Location = new Point(160, 400);
            cancelTicketBtn.Name = "cancelTicketBtn";
            cancelTicketBtn.Size = new Size(150, 30);
            cancelTicketBtn.TabIndex = 9;
            cancelTicketBtn.Text = "CANCEL CHANGES";
            cancelTicketBtn.UseVisualStyleBackColor = false;
            cancelTicketBtn.Click += cancelTicketBtn_Click;
            // 
            // closeTicketBtn
            // 
            closeTicketBtn.BackColor = Color.Firebrick;
            closeTicketBtn.FlatAppearance.BorderSize = 0;
            closeTicketBtn.FlatStyle = FlatStyle.Flat;
            closeTicketBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            closeTicketBtn.ForeColor = Color.White;
            closeTicketBtn.Location = new Point(320, 400);
            closeTicketBtn.Name = "closeTicketBtn";
            closeTicketBtn.Size = new Size(150, 30);
            closeTicketBtn.TabIndex = 10;
            closeTicketBtn.Text = "CLOSE TICKET";
            closeTicketBtn.UseVisualStyleBackColor = false;
            closeTicketBtn.Visible = false;
            closeTicketBtn.Click += closeTicketBtn_Click;
            // 
            // editTicketBtn
            // 
            editTicketBtn.BackColor = Color.OliveDrab;
            editTicketBtn.FlatAppearance.BorderSize = 0;
            editTicketBtn.FlatStyle = FlatStyle.Flat;
            editTicketBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            editTicketBtn.ForeColor = Color.White;
            editTicketBtn.Location = new Point(0, 400);
            editTicketBtn.Name = "editTicketBtn";
            editTicketBtn.Size = new Size(150, 30);
            editTicketBtn.TabIndex = 8;
            editTicketBtn.Text = "EDIT TICKET";
            editTicketBtn.UseVisualStyleBackColor = false;
            editTicketBtn.Visible = false;
            editTicketBtn.Click += editTicketBtn_Click;
            // 
            // addTicketBtn
            // 
            addTicketBtn.BackColor = Color.OliveDrab;
            addTicketBtn.FlatAppearance.BorderSize = 0;
            addTicketBtn.FlatStyle = FlatStyle.Flat;
            addTicketBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            addTicketBtn.ForeColor = Color.White;
            addTicketBtn.Location = new Point(0, 400);
            addTicketBtn.Name = "addTicketBtn";
            addTicketBtn.Size = new Size(150, 30);
            addTicketBtn.TabIndex = 8;
            addTicketBtn.Text = "ADD TICKET";
            addTicketBtn.UseVisualStyleBackColor = false;
            addTicketBtn.Click += addTicketBtn_Click;
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddEditTicket.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(0, 0);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Padding = new Padding(0, 10, 0, 0);
            lblAddEditTicket.Size = new Size(784, 46);
            lblAddEditTicket.TabIndex = 0;
            lblAddEditTicket.Text = "Add/Edit Ticket";
            lblAddEditTicket.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlAddEditUser
            // 
            pnlAddEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlAddEditUser.BackColor = Color.White;
            pnlAddEditUser.Controls.Add(splitterAddEditUser);
            pnlAddEditUser.Controls.Add(panelAddEditUserHolder);
            pnlAddEditUser.Controls.Add(lblAddEditUser);
            pnlAddEditUser.Location = new Point(0, 122);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(784, 758);
            pnlAddEditUser.TabIndex = 0;
            // 
            // splitterAddEditUser
            // 
            splitterAddEditUser.BackColor = SystemColors.ControlDark;
            splitterAddEditUser.Dock = DockStyle.Top;
            splitterAddEditUser.Location = new Point(0, 0);
            splitterAddEditUser.Margin = new Padding(5);
            splitterAddEditUser.Name = "splitterAddEditUser";
            splitterAddEditUser.Size = new Size(784, 1);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // panelAddEditUserHolder
            // 
            panelAddEditUserHolder.Controls.Add(lblAddEditUserError);
            panelAddEditUserHolder.Controls.Add(lblFirstNameEdit);
            panelAddEditUserHolder.Controls.Add(btnCreateEmployee);
            panelAddEditUserHolder.Controls.Add(btnDeleteEmployee);
            panelAddEditUserHolder.Controls.Add(btnUpdateEmployee);
            panelAddEditUserHolder.Controls.Add(lblLastNameEdit);
            panelAddEditUserHolder.Controls.Add(lblTypeUserEdit);
            panelAddEditUserHolder.Controls.Add(lblEmailAddressEdit);
            panelAddEditUserHolder.Controls.Add(comboBoxTypeUser);
            panelAddEditUserHolder.Controls.Add(lblPhoneNumberEdit);
            panelAddEditUserHolder.Controls.Add(textBoxBranch);
            panelAddEditUserHolder.Controls.Add(lblBranchEdit);
            panelAddEditUserHolder.Controls.Add(textBoxPhoneNumber);
            panelAddEditUserHolder.Controls.Add(textBoxFirstName);
            panelAddEditUserHolder.Controls.Add(textBoxEmailAddress);
            panelAddEditUserHolder.Controls.Add(textBoxLastName);
            panelAddEditUserHolder.Controls.Add(btnCancelChangesEmployee);
            panelAddEditUserHolder.Location = new Point(0, 70);
            panelAddEditUserHolder.Name = "panelAddEditUserHolder";
            panelAddEditUserHolder.Size = new Size(483, 332);
            panelAddEditUserHolder.TabIndex = 0;
            // 
            // lblAddEditUserError
            // 
            lblAddEditUserError.AutoSize = true;
            lblAddEditUserError.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUserError.ForeColor = Color.Red;
            lblAddEditUserError.Location = new Point(0, 243);
            lblAddEditUserError.Name = "lblAddEditUserError";
            lblAddEditUserError.Size = new Size(0, 21);
            lblAddEditUserError.TabIndex = 9;
            // 
            // lblFirstNameEdit
            // 
            lblFirstNameEdit.AutoSize = true;
            lblFirstNameEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstNameEdit.Location = new Point(0, 4);
            lblFirstNameEdit.Name = "lblFirstNameEdit";
            lblFirstNameEdit.Size = new Size(86, 21);
            lblFirstNameEdit.TabIndex = 3;
            lblFirstNameEdit.Text = "First name:";
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.OliveDrab;
            btnCreateEmployee.FlatAppearance.BorderSize = 0;
            btnCreateEmployee.FlatStyle = FlatStyle.Flat;
            btnCreateEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.ForeColor = Color.White;
            btnCreateEmployee.Location = new Point(0, 292);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(150, 30);
            btnCreateEmployee.TabIndex = 6;
            btnCreateEmployee.Text = "CREATE EMPLOYEE";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Visible = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Firebrick;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.ForeColor = Color.White;
            btnDeleteEmployee.Location = new Point(320, 292);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(150, 30);
            btnDeleteEmployee.TabIndex = 8;
            btnDeleteEmployee.Text = "DELETE EMPLOYEE";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = Color.OliveDrab;
            btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            btnUpdateEmployee.FlatStyle = FlatStyle.Flat;
            btnUpdateEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.ForeColor = Color.White;
            btnUpdateEmployee.Location = new Point(0, 292);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(150, 30);
            btnUpdateEmployee.TabIndex = 6;
            btnUpdateEmployee.Text = "UPDATE EMPLOYEE";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // lblLastNameEdit
            // 
            lblLastNameEdit.AutoSize = true;
            lblLastNameEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNameEdit.Location = new Point(0, 45);
            lblLastNameEdit.Name = "lblLastNameEdit";
            lblLastNameEdit.Size = new Size(84, 21);
            lblLastNameEdit.TabIndex = 4;
            lblLastNameEdit.Text = "Last name:";
            // 
            // lblTypeUserEdit
            // 
            lblTypeUserEdit.AutoSize = true;
            lblTypeUserEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeUserEdit.Location = new Point(0, 83);
            lblTypeUserEdit.Name = "lblTypeUserEdit";
            lblTypeUserEdit.Size = new Size(101, 21);
            lblTypeUserEdit.TabIndex = 5;
            lblTypeUserEdit.Text = "Type of user: ";
            // 
            // lblEmailAddressEdit
            // 
            lblEmailAddressEdit.AutoSize = true;
            lblEmailAddressEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailAddressEdit.Location = new Point(0, 123);
            lblEmailAddressEdit.Name = "lblEmailAddressEdit";
            lblEmailAddressEdit.Size = new Size(115, 21);
            lblEmailAddressEdit.TabIndex = 6;
            lblEmailAddressEdit.Text = "E-mail address:";
            // 
            // comboBoxTypeUser
            // 
            comboBoxTypeUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeUser.FormattingEnabled = true;
            comboBoxTypeUser.Items.AddRange(new object[] { "RegularEmployee", "ServiceDeskEmployee" });
            comboBoxTypeUser.Location = new Point(165, 80);
            comboBoxTypeUser.Name = "comboBoxTypeUser";
            comboBoxTypeUser.Size = new Size(200, 29);
            comboBoxTypeUser.TabIndex = 2;
            // 
            // lblPhoneNumberEdit
            // 
            lblPhoneNumberEdit.AutoSize = true;
            lblPhoneNumberEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumberEdit.Location = new Point(0, 163);
            lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            lblPhoneNumberEdit.Size = new Size(116, 21);
            lblPhoneNumberEdit.TabIndex = 7;
            lblPhoneNumberEdit.Text = "Phone number:";
            // 
            // textBoxBranch
            // 
            textBoxBranch.BorderStyle = BorderStyle.FixedSingle;
            textBoxBranch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBranch.Location = new Point(165, 200);
            textBoxBranch.Name = "textBoxBranch";
            textBoxBranch.Size = new Size(200, 29);
            textBoxBranch.TabIndex = 5;
            // 
            // lblBranchEdit
            // 
            lblBranchEdit.AutoSize = true;
            lblBranchEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBranchEdit.Location = new Point(0, 203);
            lblBranchEdit.Name = "lblBranchEdit";
            lblBranchEdit.Size = new Size(61, 21);
            lblBranchEdit.TabIndex = 8;
            lblBranchEdit.Text = "Branch:";
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(165, 160);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(200, 29);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(165, 0);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 29);
            textBoxFirstName.TabIndex = 0;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailAddress.Location = new Point(165, 120);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.Size = new Size(200, 29);
            textBoxEmailAddress.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(165, 40);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 29);
            textBoxLastName.TabIndex = 1;
            // 
            // btnCancelChangesEmployee
            // 
            btnCancelChangesEmployee.BackColor = Color.DimGray;
            btnCancelChangesEmployee.FlatAppearance.BorderSize = 0;
            btnCancelChangesEmployee.FlatStyle = FlatStyle.Flat;
            btnCancelChangesEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelChangesEmployee.ForeColor = Color.White;
            btnCancelChangesEmployee.Location = new Point(160, 292);
            btnCancelChangesEmployee.Name = "btnCancelChangesEmployee";
            btnCancelChangesEmployee.Size = new Size(150, 30);
            btnCancelChangesEmployee.TabIndex = 7;
            btnCancelChangesEmployee.Text = "CANCEL CHANGES";
            btnCancelChangesEmployee.UseVisualStyleBackColor = false;
            btnCancelChangesEmployee.Click += btnCancelChangesEmployee_Click;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblAddEditUser.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(0, 0);
            lblAddEditUser.Margin = new Padding(0);
            lblAddEditUser.Name = "lblAddEditUser";
            lblAddEditUser.Padding = new Padding(0, 10, 0, 0);
            lblAddEditUser.Size = new Size(784, 46);
            lblAddEditUser.TabIndex = 0;
            lblAddEditUser.Text = "Add/Edit User";
            lblAddEditUser.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlViewTicket
            // 
            pnlViewTicket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlViewTicket.BackColor = Color.White;
            pnlViewTicket.Controls.Add(panelViewTicketHolder);
            pnlViewTicket.Controls.Add(splitterViewTicket);
            pnlViewTicket.Controls.Add(lblViewTicketTitle);
            pnlViewTicket.Location = new Point(0, 122);
            pnlViewTicket.Name = "pnlViewTicket";
            pnlViewTicket.Size = new Size(784, 758);
            pnlViewTicket.TabIndex = 0;
            // 
            // panelViewTicketHolder
            // 
            panelViewTicketHolder.Controls.Add(cmbBoxServiceDesk);
            panelViewTicketHolder.Controls.Add(btnCloseViewTicket);
            panelViewTicketHolder.Controls.Add(btnTransfer);
            panelViewTicketHolder.Controls.Add(btnEditTicket);
            panelViewTicketHolder.Controls.Add(btnEscalate);
            panelViewTicketHolder.Controls.Add(lblVTReportingUser);
            panelViewTicketHolder.Controls.Add(lblVTServiceDesk);
            panelViewTicketHolder.Controls.Add(lblVTDeadlineValue);
            panelViewTicketHolder.Controls.Add(lblVTTitle);
            panelViewTicketHolder.Controls.Add(lblVTDeadline);
            panelViewTicketHolder.Controls.Add(lblVTIncident);
            panelViewTicketHolder.Controls.Add(lblVTEscalatedValue);
            panelViewTicketHolder.Controls.Add(lblVTStatus);
            panelViewTicketHolder.Controls.Add(lblVTEscalated);
            panelViewTicketHolder.Controls.Add(lblVTPriority);
            panelViewTicketHolder.Controls.Add(lblVTReportingUserValue);
            panelViewTicketHolder.Controls.Add(lblVTResolved);
            panelViewTicketHolder.Controls.Add(lblVTCreationDate);
            panelViewTicketHolder.Controls.Add(lblVTDescriptionValue);
            panelViewTicketHolder.Controls.Add(lblVTDescription);
            panelViewTicketHolder.Controls.Add(lblVTCreationDateValue);
            panelViewTicketHolder.Controls.Add(lblVTServiceDeskValue);
            panelViewTicketHolder.Controls.Add(lblVTResolvedValue);
            panelViewTicketHolder.Controls.Add(lblVTTitleValue);
            panelViewTicketHolder.Controls.Add(lblVTPriorityValue);
            panelViewTicketHolder.Controls.Add(lblVTIncidentValue);
            panelViewTicketHolder.Controls.Add(lblVTStatusValue);
            panelViewTicketHolder.Location = new Point(0, 70);
            panelViewTicketHolder.Name = "panelViewTicketHolder";
            panelViewTicketHolder.Size = new Size(580, 550);
            panelViewTicketHolder.TabIndex = 0;
            // 
            // cmbBoxServiceDesk
            // 
            cmbBoxServiceDesk.DropDownHeight = 300;
            cmbBoxServiceDesk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBoxServiceDesk.FormattingEnabled = true;
            cmbBoxServiceDesk.IntegralHeight = false;
            cmbBoxServiceDesk.Location = new Point(165, 31);
            cmbBoxServiceDesk.MaxDropDownItems = 7;
            cmbBoxServiceDesk.Name = "cmbBoxServiceDesk";
            cmbBoxServiceDesk.Size = new Size(200, 29);
            cmbBoxServiceDesk.TabIndex = 2;
            cmbBoxServiceDesk.Visible = false;
            // 
            // btnCloseViewTicket
            // 
            btnCloseViewTicket.BackColor = Color.DimGray;
            btnCloseViewTicket.ForeColor = Color.White;
            btnCloseViewTicket.FlatAppearance.BorderSize = 0;
            btnCloseViewTicket.FlatStyle = FlatStyle.Flat;
            btnCloseViewTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseViewTicket.Location = new Point(160, 520);
            btnCloseViewTicket.Name = "btnCloseViewTicket";
            btnCloseViewTicket.Size = new Size(150, 30);
            btnCloseViewTicket.TabIndex = 1;
            btnCloseViewTicket.Text = "CLOSE VIEW";
            btnCloseViewTicket.UseVisualStyleBackColor = false;
            btnCloseViewTicket.Click += OnCloseViewButtonClick;
            // 
            // btnTransfer
            // 
            btnTransfer.BackColor = Color.Peru;
            btnTransfer.FlatAppearance.BorderSize = 0;
            btnTransfer.FlatStyle = FlatStyle.Flat;
            btnTransfer.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnTransfer.ForeColor = Color.White;
            btnTransfer.Location = new Point(430, 31);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(150, 30);
            btnTransfer.TabIndex = 3;
            btnTransfer.Text = "TRANSFER TICKET";
            btnTransfer.UseVisualStyleBackColor = false;
            btnTransfer.Click += OnTransferTicketButtonClick;
            // 
            // btnEditTicket
            // 
            btnEditTicket.BackColor = Color.OliveDrab;
            btnEditTicket.FlatAppearance.BorderSize = 0;
            btnEditTicket.FlatStyle = FlatStyle.Flat;
            btnEditTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditTicket.ForeColor = Color.White;
            btnEditTicket.Location = new Point(0, 520);
            btnEditTicket.Name = "btnEditTicket";
            btnEditTicket.Size = new Size(150, 30);
            btnEditTicket.TabIndex = 0;
            btnEditTicket.Text = "EDIT TICKET";
            btnEditTicket.UseVisualStyleBackColor = false;
            btnEditTicket.Click += btnEditTicket_Click;
            // 
            // btnEscalate
            // 
            btnEscalate.BackColor = Color.LightGray;
            btnEscalate.Enabled = false;
            btnEscalate.FlatAppearance.BorderSize = 0;
            btnEscalate.FlatStyle = FlatStyle.Flat;
            btnEscalate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnEscalate.Location = new Point(430, 241);
            btnEscalate.Name = "btnEscalate";
            btnEscalate.Size = new Size(150, 30);
            btnEscalate.TabIndex = 4;
            btnEscalate.Text = "ESCALATE";
            btnEscalate.UseVisualStyleBackColor = false;
            btnEscalate.Click += btnEscalate_Click;
            // 
            // lblVTReportingUser
            // 
            lblVTReportingUser.AutoSize = true;
            lblVTReportingUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTReportingUser.Location = new Point(0, 0);
            lblVTReportingUser.Name = "lblVTReportingUser";
            lblVTReportingUser.Size = new Size(116, 21);
            lblVTReportingUser.TabIndex = 0;
            lblVTReportingUser.Text = "Reporting user:";
            // 
            // lblVTServiceDesk
            // 
            lblVTServiceDesk.AutoSize = true;
            lblVTServiceDesk.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTServiceDesk.Location = new Point(0, 35);
            lblVTServiceDesk.Name = "lblVTServiceDesk";
            lblVTServiceDesk.Size = new Size(133, 21);
            lblVTServiceDesk.TabIndex = 0;
            lblVTServiceDesk.Text = "Service desk user:";
            // 
            // lblVTDeadlineValue
            // 
            lblVTDeadlineValue.AutoSize = true;
            lblVTDeadlineValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTDeadlineValue.Location = new Point(165, 315);
            lblVTDeadlineValue.Name = "lblVTDeadlineValue";
            lblVTDeadlineValue.Size = new Size(69, 21);
            lblVTDeadlineValue.TabIndex = 0;
            lblVTDeadlineValue.Text = "deadline";
            // 
            // lblVTTitle
            // 
            lblVTTitle.AutoSize = true;
            lblVTTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTTitle.Location = new Point(0, 70);
            lblVTTitle.Name = "lblVTTitle";
            lblVTTitle.Size = new Size(42, 21);
            lblVTTitle.TabIndex = 0;
            lblVTTitle.Text = "Title:";
            // 
            // lblVTDeadline
            // 
            lblVTDeadline.AutoSize = true;
            lblVTDeadline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTDeadline.Location = new Point(0, 315);
            lblVTDeadline.Name = "lblVTDeadline";
            lblVTDeadline.Size = new Size(74, 21);
            lblVTDeadline.TabIndex = 0;
            lblVTDeadline.Text = "Deadline:";
            // 
            // lblVTIncident
            // 
            lblVTIncident.AutoSize = true;
            lblVTIncident.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTIncident.Location = new Point(0, 105);
            lblVTIncident.Name = "lblVTIncident";
            lblVTIncident.Size = new Size(122, 21);
            lblVTIncident.TabIndex = 0;
            lblVTIncident.Text = "Type of incident:";
            // 
            // lblVTEscalatedValue
            // 
            lblVTEscalatedValue.AutoSize = true;
            lblVTEscalatedValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTEscalatedValue.Location = new Point(165, 245);
            lblVTEscalatedValue.Name = "lblVTEscalatedValue";
            lblVTEscalatedValue.Size = new Size(74, 21);
            lblVTEscalatedValue.TabIndex = 0;
            lblVTEscalatedValue.Text = "escalated";
            // 
            // lblVTStatus
            // 
            lblVTStatus.AutoSize = true;
            lblVTStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTStatus.Location = new Point(0, 140);
            lblVTStatus.Name = "lblVTStatus";
            lblVTStatus.Size = new Size(55, 21);
            lblVTStatus.TabIndex = 0;
            lblVTStatus.Text = "Status:";
            // 
            // lblVTEscalated
            // 
            lblVTEscalated.AutoSize = true;
            lblVTEscalated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTEscalated.Location = new Point(0, 245);
            lblVTEscalated.Name = "lblVTEscalated";
            lblVTEscalated.Size = new Size(77, 21);
            lblVTEscalated.TabIndex = 0;
            lblVTEscalated.Text = "Escalated:";
            // 
            // lblVTPriority
            // 
            lblVTPriority.AutoSize = true;
            lblVTPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTPriority.Location = new Point(0, 175);
            lblVTPriority.Name = "lblVTPriority";
            lblVTPriority.Size = new Size(64, 21);
            lblVTPriority.TabIndex = 0;
            lblVTPriority.Text = "Priority:";
            // 
            // lblVTReportingUserValue
            // 
            lblVTReportingUserValue.AutoSize = true;
            lblVTReportingUserValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTReportingUserValue.Location = new Point(165, 0);
            lblVTReportingUserValue.Name = "lblVTReportingUserValue";
            lblVTReportingUserValue.Size = new Size(109, 21);
            lblVTReportingUserValue.TabIndex = 0;
            lblVTReportingUserValue.Text = "reporting user";
            // 
            // lblVTResolved
            // 
            lblVTResolved.AutoSize = true;
            lblVTResolved.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTResolved.Location = new Point(0, 210);
            lblVTResolved.Name = "lblVTResolved";
            lblVTResolved.Size = new Size(76, 21);
            lblVTResolved.TabIndex = 0;
            lblVTResolved.Text = "Resolved:";
            // 
            // lblVTCreationDate
            // 
            lblVTCreationDate.AutoSize = true;
            lblVTCreationDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTCreationDate.Location = new Point(0, 280);
            lblVTCreationDate.Name = "lblVTCreationDate";
            lblVTCreationDate.Size = new Size(106, 21);
            lblVTCreationDate.TabIndex = 0;
            lblVTCreationDate.Text = "Creation date:";
            // 
            // lblVTDescriptionValue
            // 
            lblVTDescriptionValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTDescriptionValue.Location = new Point(165, 350);
            lblVTDescriptionValue.Name = "lblVTDescriptionValue";
            lblVTDescriptionValue.Size = new Size(250, 150);
            lblVTDescriptionValue.TabIndex = 0;
            lblVTDescriptionValue.Text = "description";
            // 
            // lblVTDescription
            // 
            lblVTDescription.AutoSize = true;
            lblVTDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTDescription.Location = new Point(0, 350);
            lblVTDescription.Name = "lblVTDescription";
            lblVTDescription.Size = new Size(92, 21);
            lblVTDescription.TabIndex = 0;
            lblVTDescription.Text = "Description:";
            // 
            // lblVTCreationDateValue
            // 
            lblVTCreationDateValue.AutoSize = true;
            lblVTCreationDateValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTCreationDateValue.Location = new Point(165, 280);
            lblVTCreationDateValue.Name = "lblVTCreationDateValue";
            lblVTCreationDateValue.Size = new Size(61, 21);
            lblVTCreationDateValue.TabIndex = 0;
            lblVTCreationDateValue.Text = "created";
            // 
            // lblVTServiceDeskValue
            // 
            lblVTServiceDeskValue.AutoSize = true;
            lblVTServiceDeskValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTServiceDeskValue.Location = new Point(165, 35);
            lblVTServiceDeskValue.Name = "lblVTServiceDeskValue";
            lblVTServiceDeskValue.Size = new Size(128, 21);
            lblVTServiceDeskValue.TabIndex = 0;
            lblVTServiceDeskValue.Text = "service desk user";
            // 
            // lblVTResolvedValue
            // 
            lblVTResolvedValue.AutoSize = true;
            lblVTResolvedValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTResolvedValue.Location = new Point(165, 210);
            lblVTResolvedValue.Name = "lblVTResolvedValue";
            lblVTResolvedValue.Size = new Size(69, 21);
            lblVTResolvedValue.TabIndex = 0;
            lblVTResolvedValue.Text = "resolved";
            // 
            // lblVTTitleValue
            // 
            lblVTTitleValue.AutoSize = true;
            lblVTTitleValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTTitleValue.Location = new Point(165, 70);
            lblVTTitleValue.Name = "lblVTTitleValue";
            lblVTTitleValue.Size = new Size(36, 21);
            lblVTTitleValue.TabIndex = 0;
            lblVTTitleValue.Text = "title";
            // 
            // lblVTPriorityValue
            // 
            lblVTPriorityValue.AutoSize = true;
            lblVTPriorityValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTPriorityValue.Location = new Point(165, 175);
            lblVTPriorityValue.Name = "lblVTPriorityValue";
            lblVTPriorityValue.Size = new Size(61, 21);
            lblVTPriorityValue.TabIndex = 0;
            lblVTPriorityValue.Text = "priority";
            // 
            // lblVTIncidentValue
            // 
            lblVTIncidentValue.AutoSize = true;
            lblVTIncidentValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTIncidentValue.Location = new Point(165, 105);
            lblVTIncidentValue.Name = "lblVTIncidentValue";
            lblVTIncidentValue.Size = new Size(99, 21);
            lblVTIncidentValue.TabIndex = 0;
            lblVTIncidentValue.Text = "incident type";
            // 
            // lblVTStatusValue
            // 
            lblVTStatusValue.AutoSize = true;
            lblVTStatusValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblVTStatusValue.Location = new Point(165, 140);
            lblVTStatusValue.Name = "lblVTStatusValue";
            lblVTStatusValue.Size = new Size(51, 21);
            lblVTStatusValue.TabIndex = 0;
            lblVTStatusValue.Text = "status";
            // 
            // splitterViewTicket
            // 
            splitterViewTicket.BackColor = SystemColors.ControlDark;
            splitterViewTicket.Dock = DockStyle.Top;
            splitterViewTicket.Location = new Point(0, 0);
            splitterViewTicket.Margin = new Padding(5);
            splitterViewTicket.Name = "splitterViewTicket";
            splitterViewTicket.Size = new Size(784, 1);
            splitterViewTicket.TabIndex = 0;
            splitterViewTicket.TabStop = false;
            // 
            // lblViewTicketTitle
            // 
            lblViewTicketTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblViewTicketTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblViewTicketTitle.Location = new Point(0, 0);
            lblViewTicketTitle.Name = "lblViewTicketTitle";
            lblViewTicketTitle.Padding = new Padding(0, 10, 0, 0);
            lblViewTicketTitle.Size = new Size(784, 46);
            lblViewTicketTitle.TabIndex = 0;
            lblViewTicketTitle.Text = "Ticket Details";
            lblViewTicketTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDbError
            // 
            pnlDbError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDbError.BackColor = Color.White;
            pnlDbError.Controls.Add(databaseErrorMessageLbl);
            pnlDbError.Location = new Point(0, 80);
            pnlDbError.Name = "pnlDbError";
            pnlDbError.Size = new Size(784, 800);
            pnlDbError.TabIndex = 0;
            // 
            // databaseErrorMessageLbl
            // 
            databaseErrorMessageLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            databaseErrorMessageLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            databaseErrorMessageLbl.ImageAlign = ContentAlignment.TopCenter;
            databaseErrorMessageLbl.Location = new Point(0, 150);
            databaseErrorMessageLbl.Name = "databaseErrorMessageLbl";
            databaseErrorMessageLbl.Size = new Size(784, 100);
            databaseErrorMessageLbl.TabIndex = 0;
            databaseErrorMessageLbl.Text = "The application couldn't establish a connection to the database. Please check your internet connection or contact the help desk.";
            databaseErrorMessageLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(784, 804);
            Controls.Add(lblGardenDesk);
            Controls.Add(lblLicense);
            Controls.Add(logo);
            Controls.Add(pnlUsers);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlLogin);
            Controls.Add(pnlDbError);
            Controls.Add(pnlViewTicket);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlAddEditUser);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2, 1, 2, 1);
            Name = "GardenDeskForm";
            Text = "GardenDesk";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            pnlLogin.ResumeLayout(false);
            panelLoginHolder.ResumeLayout(false);
            panelLoginHolder.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            panelChartHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResolved).EndInit();
            pnlTicketsOverview.ResumeLayout(false);
            panelTicketsHolder.ResumeLayout(false);
            panelTicketsHolder.PerformLayout();
            pnlUsers.ResumeLayout(false);
            panelUsersHandler.ResumeLayout(false);
            pnlAddEditTicket.ResumeLayout(false);
            panelAddEditTicketHolder.ResumeLayout(false);
            panelAddEditTicketHolder.PerformLayout();
            pnlAddEditUser.ResumeLayout(false);
            panelAddEditUserHolder.ResumeLayout(false);
            panelAddEditUserHolder.PerformLayout();
            pnlViewTicket.ResumeLayout(false);
            panelViewTicketHolder.ResumeLayout(false);
            panelViewTicketHolder.PerformLayout();
            pnlDbError.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private Label lblGardenDesk;
        private Label lblLicense;
        private ToolStrip menuStrip;
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
        private Label lblEmailError;
        private Label lblLastNameError;
        private Button searchbtn;
        private TextBox searchtextbox;
        private ColumnHeader ticketCreationDate;
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
        private ComboBox SortOrderComboBox;
        private Label label15;
        private Panel pnlDbError;
        private Label databaseErrorMessageLbl;
        private ColumnHeader ticketDescription;
        private Panel pnlViewTicket;
        private Label lblVTDescriptionValue;
        private Label lblVTCreationDateValue;
        private Label lblVTResolvedValue;
        private Label lblVTPriorityValue;
        private Label lblVTStatusValue;
        private Label lblVTIncidentValue;
        private Label lblVTTitleValue;
        private Label lblVTServiceDeskValue;
        private Label lblVTDescription;
        private Label lblVTCreationDate;
        private Label lblVTResolved;
        private Label lblVTPriority;
        private Label lblVTStatus;
        private Label lblVTIncident;
        private Label lblVTTitle;
        private Label lblVTServiceDesk;
        private Splitter splitterViewTicket;
        private Label lblViewTicketTitle;
        private Label lblVTReportingUserValue;
        private Label lblVTReportingUser;
        private Label lblVTEscalatedValue;
        private Label lblVTEscalated;
        private Label lblVTDeadlineValue;
        private Label lblVTDeadline;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Panel panelChartHolder;
        private Panel panelLoginHolder;
        private Panel panelTicketsHolder;
        private ColumnHeader ticketPriority;
        private Panel panelUsersHandler;
        private Panel panelAddEditUserHolder;
        private TextBox txtBoxFilter;
        private Button btnFilter;
        private Panel panelAddEditTicketHolder;
        private Panel panelViewTicketHolder;
        private Button btnTransfer;
        private Button btnCloseViewTicket;
        private ComboBox cmbBoxServiceDesk;
        private Label lblLoginLoading;
        private Button btnViewTicket;
        private Label lblAddEditUserError;
        private Label lblBranchError;
        private Label lblPhoneNumberError;
        private Label lblTypeUserError;
        private ToolTip toolTipEscalated;
    }
}
