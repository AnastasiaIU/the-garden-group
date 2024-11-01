﻿namespace UI
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
            panelTicketsHolder = new Panel();
            txtBoxFilter = new TextBox();
            btnFilter = new Button();
            searchtextbox = new TextBox();
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketDescription = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketDeadline = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            ticketPriority = new ColumnHeader();
            label15 = new Label();
            searchbtn = new Button();
            SortOrderComboBox = new ComboBox();
            btnViewTicket = new Button();
            splitterTicketsOverview = new Splitter();
            btnEditTicket = new Button();
            btnAddTicket = new Button();
            btnEscalate = new Button();
            lblTicketsOverview = new Label();
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
            lblVTDeadlineValue = new Label();
            lblVTDeadline = new Label();
            lblVTEscalatedValue = new Label();
            lblVTEscalated = new Label();
            lblVTReportingUserValue = new Label();
            lblVTReportingUser = new Label();
            lblVTDescriptionValue = new Label();
            lblVTCreationDateValue = new Label();
            lblVTResolvedValue = new Label();
            lblVTPriorityValue = new Label();
            lblVTStatusValue = new Label();
            lblVTIncidentValue = new Label();
            lblVTTitleValue = new Label();
            lblVTServiceDeskValue = new Label();
            lblVTDescription = new Label();
            lblVTCreationDate = new Label();
            lblVTResolved = new Label();
            lblVTPriority = new Label();
            lblVTStatus = new Label();
            lblVTIncident = new Label();
            lblVTTitle = new Label();
            lblVTServiceDesk = new Label();
            splitterViewTicket = new Splitter();
            lblViewTicketTitle = new Label();
            menuStrip.SuspendLayout();
            pnlDbError = new Panel();
            databaseErrorMessageLbl = new Label();
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
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(546, 49);
            lblLicense.Margin = new Padding(2, 0, 2, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 10, 0);
            lblLicense.Size = new Size(242, 15);
            lblLicense.TabIndex = 2;
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
            btnLogin.TabIndex = 3;
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
            txtBoxLoginUsername.TabIndex = 1;
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
            txtBoxLoginPassword.TabIndex = 2;
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
            chartOpen.TabIndex = 0;
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
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            chartClosed.Series.Add(series5);
            chartClosed.Size = new Size(150, 180);
            chartClosed.TabIndex = 0;
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
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(panelTicketsHolder);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Controls.Add(btnEditTicket);
            pnlTicketsOverview.Controls.Add(btnAddTicket);
            pnlTicketsOverview.Controls.Add(btnEscalate);
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 122);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(784, 758);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // panelTicketsHolder
            // 
            panelTicketsHolder.Controls.Add(txtBoxFilter);
            panelTicketsHolder.Controls.Add(btnFilter);
            panelTicketsHolder.Controls.Add(searchtextbox);
            panelTicketsHolder.Controls.Add(ticketsListView);
            panelTicketsHolder.Controls.Add(label15);
            panelTicketsHolder.Controls.Add(searchbtn);
            panelTicketsHolder.Controls.Add(SortOrderComboBox);
            panelTicketsHolder.Controls.Add(btnViewTicket);
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
            txtBoxFilter.TabIndex = 3;
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
            btnFilter.TabIndex = 4;
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
            searchtextbox.TabIndex = 1;
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
            ticketsListView.Size = new Size(780, 500);
            ticketsListView.TabIndex = 6;
            ticketsListView.UseCompatibleStateImageBehavior = false;
            ticketsListView.View = View.Details;
            ticketsListView.SelectedIndexChanged += ticketsListView_SelectedIndexChanged;
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
            searchbtn.TabIndex = 2;
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
            SortOrderComboBox.TabIndex = 5;
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
            btnViewTicket.Location = new Point(0, 620);
            btnViewTicket.Name = "btnViewTicket";
            btnViewTicket.Size = new Size(150, 30);
            btnViewTicket.TabIndex = 7;
            btnViewTicket.Text = "VIEW TICKET";
            btnViewTicket.UseVisualStyleBackColor = false;
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
            // btnEditTicket
            // 
            btnEditTicket.BackColor = Color.LightGray;
            btnEditTicket.Enabled = false;
            btnEditTicket.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditTicket.Location = new Point(450, 722);
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
            btnAddTicket.Location = new Point(341, 722);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(100, 31);
            btnAddTicket.TabIndex = 6;
            btnAddTicket.Text = "ADD TICKET";
            btnAddTicket.UseVisualStyleBackColor = false;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnEscalate
            // 
            btnEscalate.BackColor = Color.LightGray;
            btnEscalate.Enabled = false;
            btnEscalate.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnEscalate.Location = new Point(561, 722);
            btnEscalate.Name = "btnEscalate";
            btnEscalate.Size = new Size(100, 31);
            btnEscalate.TabIndex = 3;
            btnEscalate.Text = "ESCALATE";
            btnEscalate.UseVisualStyleBackColor = false;
            btnEscalate.Click += btnEscalate_Click;
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

            usersList.Location = new Point(29, 63);
            usersList.GridLines = true;
            usersList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            usersList.Location = new Point(0, 0);
            usersList.Margin = new Padding(2);
            usersList.Name = "usersList";
            usersList.Size = new Size(780, 500);
            usersList.TabIndex = 1;
            usersList.TabStop = false;
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
            btnEditEmployee.TabIndex = 3;
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
            btnAddEmployee.TabIndex = 2;
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
            descriptionTxtBox.TabIndex = 8;
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
            titleTxtBox.TabIndex = 2;
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
            deadlineCmbBox.TabIndex = 7;
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
            isResolvedCmbBox.TabIndex = 6;
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
            priorityCmbBox.TabIndex = 5;
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
            statusCmbBox.TabIndex = 4;
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
            typeOfAccidentCmbBox.TabIndex = 3;
            // 
            // serviceDeskUserCmbBox
            // 
            serviceDeskUserCmbBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serviceDeskUserCmbBox.FormattingEnabled = true;
            serviceDeskUserCmbBox.Location = new Point(165, 0);
            serviceDeskUserCmbBox.Name = "serviceDeskUserCmbBox";
            serviceDeskUserCmbBox.Size = new Size(200, 29);
            serviceDeskUserCmbBox.TabIndex = 1;
            // 
            // cancelTicketBtn
            // 
            cancelTicketBtn.BackColor = Color.DarkGray;
            cancelTicketBtn.FlatAppearance.BorderSize = 0;
            cancelTicketBtn.FlatStyle = FlatStyle.Flat;
            cancelTicketBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cancelTicketBtn.ForeColor = Color.White;
            cancelTicketBtn.Location = new Point(160, 400);
            cancelTicketBtn.Name = "cancelTicketBtn";
            cancelTicketBtn.Size = new Size(150, 30);
            cancelTicketBtn.TabIndex = 10;
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
            closeTicketBtn.TabIndex = 11;
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
            editTicketBtn.TabIndex = 9;
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
            addTicketBtn.TabIndex = 9;
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
            panelAddEditUserHolder.Size = new Size(470, 300);
            panelAddEditUserHolder.TabIndex = 0;
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
            btnCreateEmployee.Location = new Point(0, 260);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(150, 30);
            btnCreateEmployee.TabIndex = 7;
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
            btnDeleteEmployee.Location = new Point(320, 260);
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
            btnUpdateEmployee.Location = new Point(0, 260);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(150, 30);
            btnUpdateEmployee.TabIndex = 7;
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
            comboBoxTypeUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeUser.FormattingEnabled = true;
            comboBoxTypeUser.Items.AddRange(new object[] { "RegularEmployee", "ServiceDeskEmployee" });
            comboBoxTypeUser.Location = new Point(165, 80);
            comboBoxTypeUser.Name = "comboBoxTypeUser";
            comboBoxTypeUser.Size = new Size(200, 29);
            comboBoxTypeUser.TabIndex = 3;
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
            textBoxBranch.TabIndex = 6;
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
            textBoxPhoneNumber.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(165, 0);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(200, 29);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmailAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailAddress.Location = new Point(165, 120);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.Size = new Size(200, 29);
            textBoxEmailAddress.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            textBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(165, 40);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(200, 29);
            textBoxLastName.TabIndex = 2;
            // 
            // btnCancelChangesEmployee
            // 
            btnCancelChangesEmployee.BackColor = Color.DarkGray;
            btnCancelChangesEmployee.FlatAppearance.BorderSize = 0;
            btnCancelChangesEmployee.FlatStyle = FlatStyle.Flat;
            btnCancelChangesEmployee.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelChangesEmployee.ForeColor = Color.White;
            btnCancelChangesEmployee.Location = new Point(160, 260);
            btnCancelChangesEmployee.Name = "btnCancelChangesEmployee";
            btnCancelChangesEmployee.Size = new Size(150, 30);
            btnCancelChangesEmployee.TabIndex = 9;
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
            pnlViewTicket.BackColor = Color.White;
            pnlViewTicket.Controls.Add(lblVTDeadlineValue);
            pnlViewTicket.Controls.Add(lblVTDeadline);
            pnlViewTicket.Controls.Add(lblVTEscalatedValue);
            pnlViewTicket.Controls.Add(lblVTEscalated);
            pnlViewTicket.Controls.Add(lblVTReportingUserValue);
            pnlViewTicket.Controls.Add(lblVTReportingUser);
            pnlViewTicket.Controls.Add(lblVTDescriptionValue);
            pnlViewTicket.Controls.Add(lblVTCreationDateValue);
            pnlViewTicket.Controls.Add(lblVTResolvedValue);
            pnlViewTicket.Controls.Add(lblVTPriorityValue);
            pnlViewTicket.Controls.Add(lblVTStatusValue);
            pnlViewTicket.Controls.Add(lblVTIncidentValue);
            pnlViewTicket.Controls.Add(lblVTTitleValue);
            pnlViewTicket.Controls.Add(lblVTServiceDeskValue);
            pnlViewTicket.Controls.Add(lblVTDescription);
            pnlViewTicket.Controls.Add(lblVTCreationDate);
            pnlViewTicket.Controls.Add(lblVTResolved);
            pnlViewTicket.Controls.Add(lblVTPriority);
            pnlViewTicket.Controls.Add(lblVTStatus);
            pnlViewTicket.Controls.Add(lblVTIncident);
            pnlViewTicket.Controls.Add(lblVTTitle);
            pnlViewTicket.Controls.Add(lblVTServiceDesk);
            pnlViewTicket.Controls.Add(splitterViewTicket);
            pnlViewTicket.Controls.Add(lblViewTicketTitle);
            pnlViewTicket.Location = new Point(0, 130);
            pnlViewTicket.Name = "pnlViewTicket";
            pnlViewTicket.Size = new Size(634, 599);
            pnlViewTicket.TabIndex = 0;
            // 
            // lblVTDeadlineValue
            // 
            lblVTDeadlineValue.AutoSize = true;
            lblVTDeadlineValue.Location = new Point(160, 361);
            lblVTDeadlineValue.Name = "lblVTDeadlineValue";
            lblVTDeadlineValue.Size = new Size(0, 15);
            lblVTDeadlineValue.TabIndex = 27;
            // 
            // lblVTDeadline
            // 
            lblVTDeadline.AutoSize = true;
            lblVTDeadline.Location = new Point(45, 361);
            lblVTDeadline.Name = "lblVTDeadline";
            lblVTDeadline.Size = new Size(56, 15);
            lblVTDeadline.TabIndex = 26;
            lblVTDeadline.Text = "Deadline:";
            // 
            // lblVTEscalatedValue
            // 
            lblVTEscalatedValue.AutoSize = true;
            lblVTEscalatedValue.Location = new Point(160, 294);
            lblVTEscalatedValue.Name = "lblVTEscalatedValue";
            lblVTEscalatedValue.Size = new Size(0, 15);
            lblVTEscalatedValue.TabIndex = 25;
            // 
            // lblVTEscalated
            // 
            lblVTEscalated.AutoSize = true;
            lblVTEscalated.Location = new Point(45, 294);
            lblVTEscalated.Name = "lblVTEscalated";
            lblVTEscalated.Size = new Size(59, 15);
            lblVTEscalated.TabIndex = 24;
            lblVTEscalated.Text = "Escalated:";
            // 
            // lblVTReportingUserValue
            // 
            lblVTReportingUserValue.AutoSize = true;
            lblVTReportingUserValue.Location = new Point(160, 61);
            lblVTReportingUserValue.Name = "lblVTReportingUserValue";
            lblVTReportingUserValue.Size = new Size(0, 15);
            lblVTReportingUserValue.TabIndex = 23;
            // 
            // lblVTReportingUser
            // 
            lblVTReportingUser.AutoSize = true;
            lblVTReportingUser.Location = new Point(45, 61);
            lblVTReportingUser.Name = "lblVTReportingUser";
            lblVTReportingUser.Size = new Size(87, 15);
            lblVTReportingUser.TabIndex = 22;
            lblVTReportingUser.Text = "Reporting user:";
            // 
            // lblVTDescriptionValue
            // 
            lblVTDescriptionValue.AutoSize = true;
            lblVTDescriptionValue.Location = new Point(160, 380);
            lblVTDescriptionValue.Name = "lblVTDescriptionValue";
            lblVTDescriptionValue.Size = new Size(0, 15);
            lblVTDescriptionValue.TabIndex = 21;
            // 
            // lblVTCreationDateValue
            // 
            lblVTCreationDateValue.AutoSize = true;
            lblVTCreationDateValue.Location = new Point(160, 330);
            lblVTCreationDateValue.Name = "lblVTCreationDateValue";
            lblVTCreationDateValue.Size = new Size(0, 15);
            lblVTCreationDateValue.TabIndex = 20;
            // 
            // lblVTResolvedValue
            // 
            lblVTResolvedValue.AutoSize = true;
            lblVTResolvedValue.Location = new Point(160, 265);
            lblVTResolvedValue.Name = "lblVTResolvedValue";
            lblVTResolvedValue.Size = new Size(0, 15);
            lblVTResolvedValue.TabIndex = 19;
            // 
            // lblVTPriorityValue
            // 
            lblVTPriorityValue.AutoSize = true;
            lblVTPriorityValue.Location = new Point(160, 230);
            lblVTPriorityValue.Name = "lblVTPriorityValue";
            lblVTPriorityValue.Size = new Size(0, 15);
            lblVTPriorityValue.TabIndex = 18;
            // 
            // lblVTStatusValue
            // 
            lblVTStatusValue.AutoSize = true;
            lblVTStatusValue.Location = new Point(160, 193);
            lblVTStatusValue.Name = "lblVTStatusValue";
            lblVTStatusValue.Size = new Size(0, 15);
            lblVTStatusValue.TabIndex = 17;
            // 
            // lblVTIncidentValue
            // 
            lblVTIncidentValue.AutoSize = true;
            lblVTIncidentValue.Location = new Point(160, 156);
            lblVTIncidentValue.Name = "lblVTIncidentValue";
            lblVTIncidentValue.Size = new Size(0, 15);
            lblVTIncidentValue.TabIndex = 16;
            // 
            // lblVTTitleValue
            // 
            lblVTTitleValue.AutoSize = true;
            lblVTTitleValue.Location = new Point(160, 121);
            lblVTTitleValue.Name = "lblVTTitleValue";
            lblVTTitleValue.Size = new Size(0, 15);
            lblVTTitleValue.TabIndex = 15;
            // 
            // lblVTServiceDeskValue
            // 
            lblVTServiceDeskValue.AutoSize = true;
            lblVTServiceDeskValue.Location = new Point(160, 91);
            lblVTServiceDeskValue.Name = "lblVTServiceDeskValue";
            lblVTServiceDeskValue.Size = new Size(0, 15);
            lblVTServiceDeskValue.TabIndex = 14;
            // 
            // lblVTDescription
            // 
            lblVTDescription.AutoSize = true;
            lblVTDescription.Location = new Point(45, 380);
            lblVTDescription.Name = "lblVTDescription";
            lblVTDescription.Size = new Size(70, 15);
            lblVTDescription.TabIndex = 13;
            lblVTDescription.Text = "Description:";
            // 
            // lblVTCreationDate
            // 
            lblVTCreationDate.AutoSize = true;
            lblVTCreationDate.Location = new Point(45, 330);
            lblVTCreationDate.Name = "lblVTCreationDate";
            lblVTCreationDate.Size = new Size(81, 15);
            lblVTCreationDate.TabIndex = 12;
            lblVTCreationDate.Text = "Creation date:";
            // 
            // lblVTResolved
            // 
            lblVTResolved.AutoSize = true;
            lblVTResolved.Location = new Point(45, 265);
            lblVTResolved.Name = "lblVTResolved";
            lblVTResolved.Size = new Size(57, 15);
            lblVTResolved.TabIndex = 11;
            lblVTResolved.Text = "Resolved:";
            // 
            // lblVTPriority
            // 
            lblVTPriority.AutoSize = true;
            lblVTPriority.Location = new Point(45, 230);
            lblVTPriority.Name = "lblVTPriority";
            lblVTPriority.Size = new Size(48, 15);
            lblVTPriority.TabIndex = 10;
            lblVTPriority.Text = "Priority:";
            // 
            // lblVTStatus
            // 
            lblVTStatus.AutoSize = true;
            lblVTStatus.Location = new Point(45, 193);
            lblVTStatus.Name = "lblVTStatus";
            lblVTStatus.Size = new Size(42, 15);
            lblVTStatus.TabIndex = 9;
            lblVTStatus.Text = "Status:";
            // 
            // lblVTIncident
            // 
            lblVTIncident.AutoSize = true;
            lblVTIncident.Location = new Point(45, 156);
            lblVTIncident.Name = "lblVTIncident";
            lblVTIncident.Size = new Size(94, 15);
            lblVTIncident.TabIndex = 8;
            lblVTIncident.Text = "Type of incident:";
            // 
            // lblVTTitle
            // 
            lblVTTitle.AutoSize = true;
            lblVTTitle.Location = new Point(45, 121);
            lblVTTitle.Name = "lblVTTitle";
            lblVTTitle.Size = new Size(32, 15);
            lblVTTitle.TabIndex = 7;
            lblVTTitle.Text = "Title:";
            // 
            // lblVTServiceDesk
            // 
            lblVTServiceDesk.AutoSize = true;
            lblVTServiceDesk.Location = new Point(45, 91);
            lblVTServiceDesk.Name = "lblVTServiceDesk";
            lblVTServiceDesk.Size = new Size(99, 15);
            lblVTServiceDesk.TabIndex = 6;
            lblVTServiceDesk.Text = "Service desk user:";
            // 
            // splitterViewTicket
            // 
            splitterViewTicket.BackColor = Color.Black;
            splitterViewTicket.Dock = DockStyle.Top;
            splitterViewTicket.Location = new Point(0, 0);
            splitterViewTicket.Margin = new Padding(5);
            splitterViewTicket.Name = "splitterViewTicket";
            splitterViewTicket.Size = new Size(634, 1);
            splitterViewTicket.TabIndex = 0;
            splitterViewTicket.TabStop = false;
            // 
            // lblViewTicketTitle
            // 
            lblViewTicketTitle.AutoSize = true;
            lblViewTicketTitle.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            lblViewTicketTitle.Location = new Point(19, 13);
            lblViewTicketTitle.Name = "lblViewTicketTitle";
            lblViewTicketTitle.Size = new Size(129, 25);
            lblViewTicketTitle.TabIndex = 1;
            lblViewTicketTitle.Text = "Ticket Details";
            // 
            // pnlDbError
            // 
            pnlDbError.BackColor = Color.White;
            pnlDbError.Controls.Add(databaseErrorMessageLbl);
            pnlDbError.Location = new Point(-1, 111);
            pnlDbError.Name = "pnlDbError";
            pnlDbError.Size = new Size(634, 478);
            pnlDbError.TabIndex = 12;
            // 
            // databaseErrorMessageLbl
            // 
            databaseErrorMessageLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            databaseErrorMessageLbl.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            databaseErrorMessageLbl.Location = new Point(135, 151);
            databaseErrorMessageLbl.Name = "databaseErrorMessageLbl";
            databaseErrorMessageLbl.Size = new Size(326, 95);
            databaseErrorMessageLbl.TabIndex = 0;
            databaseErrorMessageLbl.Text = "The application couldn't establish a connection to the database. Please check your internet connection or contact the help desk.";
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(784, 881);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlUsers);
            Controls.Add(pnlLogin);
            Controls.Add(menuStrip);
            Controls.Add(pnlViewTicket);
            Controls.Add(pnlDbError);
            Controls.Add(pnlAddEditUser);
            Controls.Add(pnlUsers);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(pnlAddEditUser);
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
            pnlViewTicket.PerformLayout();
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
        private ColumnHeader userEmail;
        private ColumnHeader userFirstName;
        private ColumnHeader userLastName;
        private ColumnHeader userTicketCount;
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
        private Button searchbtn;
        private TextBox searchtextbox;
        private ColumnHeader ticketCreationDate;
        private Button btnEditTicket;
        private Button btnAddTicket;
        private Button cancelTicketBtn;
        private Button closeTicketBtn;
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
        private Button btnViewTicket;
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
        private TextBox searchtextbox;
        private ListView ticketsListView;
        private ColumnHeader ticketTitle;
        private ColumnHeader ticketDescription;
        private ColumnHeader ticketReportingUser;
        private ColumnHeader ticketCreationDate;
        private ColumnHeader ticketDeadline;
        private ColumnHeader ticketStatus;
        private ColumnHeader ticketPriority;
        private Label label15;
        private Button searchbtn;
        private ComboBox SortOrderComboBox;
        private Button btnViewTicket;
        private Panel panelUsersHandler;
        private Panel panelAddEditUserHolder;
        private Button btnCreateEmployee;
        private TextBox txtBoxFilter;
        private Button btnFilter;
        private Panel panelAddEditTicketHolder;
        private Button editTicketBtn;
    }
}
