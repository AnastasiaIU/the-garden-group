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
            lblDashboard = new Label();
            splitterDashboard = new Splitter();
            pnlTicketsOverview = new Panel();
            btnEscalate = new Button();
            lblTicketsOverview = new Label();
            splitterTicketsOverview = new Splitter();
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            pnlUsers = new Panel();
            btnEditEmployee = new Button();
            btnAddEmployee = new Button();
            usersList = new ListView();
            leftColumn = new ColumnHeader();
            userId = new ColumnHeader();
            userEmail = new ColumnHeader();
            userFirstName = new ColumnHeader();
            userLastName = new ColumnHeader();
            userTicketCount = new ColumnHeader();
            lblUsers = new Label();
            splitterUsers = new Splitter();
            pnlAddEditTicket = new Panel();
            lblAddEditTicket = new Label();
            splitterAddEditTicket = new Splitter();
            menuStripBackground = new PictureBox();
            pnlAddEditUser = new Panel();
            btnCreateEmployee = new Button();
            btnCancelEdit = new Button();
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
            logo.Location = new Point(18, 0);
            logo.Margin = new Padding(4, 2, 4, 2);
            logo.Name = "logo";
            logo.Size = new Size(131, 131);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblGardenDesk
            // 
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(849, 0);
            lblGardenDesk.Margin = new Padding(4, 0, 4, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 12, 18, 0);
            lblGardenDesk.Size = new Size(261, 56);
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(800, 88);
            lblLicense.Margin = new Padding(4, 0, 4, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 18, 0);
            lblLicense.Size = new Size(313, 26);
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
            menuStrip.Location = new Point(0, 140);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(1110, 56);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip";
            // 
            // menuItemDashboard
            // 
            menuItemDashboard.AutoSize = false;
            menuItemDashboard.Name = "menuItemDashboard";
            menuItemDashboard.Size = new Size(210, 30);
            menuItemDashboard.Text = "Dashboard";
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
            pnlLogin.Location = new Point(0, 196);
            pnlLogin.Margin = new Padding(5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1110, 1048);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(424, 665);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(262, 79);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // lblLoginWrongCredentials
            // 
            lblLoginWrongCredentials.AutoSize = true;
            lblLoginWrongCredentials.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWrongCredentials.ForeColor = Color.Red;
            lblLoginWrongCredentials.Location = new Point(292, 578);
            lblLoginWrongCredentials.Margin = new Padding(5, 0, 5, 0);
            lblLoginWrongCredentials.Name = "lblLoginWrongCredentials";
            lblLoginWrongCredentials.Size = new Size(521, 38);
            lblLoginWrongCredentials.TabIndex = 0;
            lblLoginWrongCredentials.Text = "Wrong username or password. Try again.";
            lblLoginWrongCredentials.Visible = false;
            // 
            // txtBoxLoginPassword
            // 
            txtBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginPassword.Location = new Point(292, 490);
            txtBoxLoginPassword.Margin = new Padding(5);
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(524, 45);
            txtBoxLoginPassword.TabIndex = 2;
            // 
            // txtBoxLoginUsername
            // 
            txtBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginUsername.Location = new Point(292, 350);
            txtBoxLoginUsername.Margin = new Padding(5);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(524, 45);
            txtBoxLoginUsername.TabIndex = 1;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(292, 438);
            lblLoginPassword.Margin = new Padding(5, 0, 5, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(138, 38);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(292, 298);
            lblLoginUsername.Margin = new Padding(5, 0, 5, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(148, 38);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(262, 122);
            lblLoginPrompt.Margin = new Padding(5, 0, 5, 0);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new Size(584, 98);
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
            lblLoginGardenDesk.Size = new Size(1110, 65);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 196);
            pnlDashboard.Margin = new Padding(5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1110, 1048);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(399, 30);
            lblDashboard.Margin = new Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(268, 57);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "DASHBOARD";
            // 
            // splitterDashboard
            // 
            splitterDashboard.BackColor = Color.Black;
            splitterDashboard.Dock = DockStyle.Top;
            splitterDashboard.Location = new Point(0, 0);
            splitterDashboard.Margin = new Padding(5);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(1110, 2);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(btnEscalate);
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Controls.Add(ticketsListView);
            pnlTicketsOverview.Location = new Point(0, 196);
            pnlTicketsOverview.Margin = new Padding(5);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(1110, 1048);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // btnEscalate
            // 
            btnEscalate.BackColor = Color.Tomato;
            btnEscalate.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnEscalate.Location = new Point(704, 27);
            btnEscalate.Name = "btnEscalate";
            btnEscalate.Size = new Size(151, 47);
            btnEscalate.TabIndex = 3;
            btnEscalate.Text = "ESCALATE";
            btnEscalate.UseVisualStyleBackColor = false;
            btnEscalate.Visible = false;
            //btnEscalate.Click += btnEscalate_Click;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(34, 23);
            lblTicketsOverview.Margin = new Padding(5, 0, 5, 0);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Size = new Size(301, 51);
            lblTicketsOverview.TabIndex = 1;
            lblTicketsOverview.Text = "Tickets Overview";
            // 
            // splitterTicketsOverview
            // 
            splitterTicketsOverview.BackColor = Color.Black;
            splitterTicketsOverview.Dock = DockStyle.Top;
            splitterTicketsOverview.Location = new Point(0, 0);
            splitterTicketsOverview.Margin = new Padding(5);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(1110, 2);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // ticketsListView
            // 
            ticketsListView.BackColor = SystemColors.InactiveCaption;
            ticketsListView.Columns.AddRange(new ColumnHeader[] { ticketTitle, ticketReportingUser, ticketCreationDate, ticketStatus });
            ticketsListView.FullRowSelect = true;
            ticketsListView.Location = new Point(50, 111);
            ticketsListView.Margin = new Padding(4);
            ticketsListView.Name = "ticketsListView";
            ticketsListView.Size = new Size(1015, 668);
            ticketsListView.TabIndex = 2;
            ticketsListView.UseCompatibleStateImageBehavior = false;
            ticketsListView.View = View.Details;
            // Tina
            //ticketsListView.SelectedIndexChanged += ticketsListView_SelectedIndexChanged;
            // 
            // ticketTitle
            // 
            ticketTitle.Text = "Title";
            ticketTitle.Width = 370;
            // 
            // ticketReportingUser
            // 
            ticketReportingUser.Text = "Reported By";
            ticketReportingUser.Width = 130;
            // 
            // ticketCreationDate
            // 
            ticketCreationDate.Text = "Deadline";
            ticketCreationDate.Width = 190;
            // 
            // ticketStatus
            // 
            ticketStatus.Text = "Status";
            ticketStatus.Width = 100;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(btnEditEmployee);
            pnlUsers.Controls.Add(btnAddEmployee);
            pnlUsers.Controls.Add(usersList);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Location = new Point(0, 196);
            pnlUsers.Margin = new Padding(5);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(1110, 1048);
            pnlUsers.TabIndex = 7;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(250, 185, 115);
            btnEditEmployee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditEmployee.Location = new Point(873, 73);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(212, 49);
            btnEditEmployee.TabIndex = 4;
            btnEditEmployee.Text = "EDIT EMPLOYEE";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Visible = false;
            btnEditEmployee.Click += btnEditUser_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.LightGreen;
            btnAddEmployee.Location = new Point(873, 73);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(212, 49);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "+ ADD NEW EMPLOYEE";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // usersList
            // 
            usersList.Columns.AddRange(new ColumnHeader[] { leftColumn, userId, userEmail, userFirstName, userLastName, userTicketCount });
            usersList.FullRowSelect = true;
            listViewItem1.Tag = "ID";
            usersList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            usersList.Location = new Point(21, 164);
            usersList.Margin = new Padding(5);
            usersList.Name = "usersList";
            usersList.Size = new Size(1064, 860);
            usersList.TabIndex = 2;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
            // Tina
            usersList.SelectedIndexChanged += usersList_SelectedIndexChanged;
            // 
            // leftColumn
            // 
            leftColumn.Text = "";
            leftColumn.Width = 0;
            // 
            // userId
            // 
            userId.Text = "ID";
            userId.TextAlign = HorizontalAlignment.Center;
            userId.Width = 250;
            // 
            // userEmail
            // 
            userEmail.Text = "Email";
            userEmail.TextAlign = HorizontalAlignment.Center;
            userEmail.Width = 250;
            // 
            // userFirstName
            // 
            userFirstName.Text = "First Name";
            userFirstName.TextAlign = HorizontalAlignment.Center;
            userFirstName.Width = 135;
            // 
            // userLastName
            // 
            userLastName.Text = "Last Name";
            userLastName.TextAlign = HorizontalAlignment.Center;
            userLastName.Width = 135;
            // 
            // userTicketCount
            // 
            userTicketCount.Text = "#tickets";
            userTicketCount.TextAlign = HorizontalAlignment.Center;
            userTicketCount.Width = 110;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsers.ForeColor = SystemColors.WindowFrame;
            lblUsers.Location = new Point(21, 65);
            lblUsers.Margin = new Padding(5, 0, 5, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(385, 57);
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
            splitterUsers.Size = new Size(1110, 2);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 196);
            pnlAddEditTicket.Margin = new Padding(5);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(1110, 1048);
            pnlAddEditTicket.TabIndex = 8;
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.AutoSize = true;
            lblAddEditTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(399, 30);
            lblAddEditTicket.Margin = new Padding(5, 0, 5, 0);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Size = new Size(308, 57);
            lblAddEditTicket.TabIndex = 1;
            lblAddEditTicket.Text = "Add/Edit Ticket";
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(5);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(1110, 2);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // menuStripBackground
            // 
            menuStripBackground.BackColor = Color.White;
            menuStripBackground.Location = new Point(0, 140);
            menuStripBackground.Margin = new Padding(5);
            menuStripBackground.Name = "menuStripBackground";
            menuStripBackground.Size = new Size(1110, 56);
            menuStripBackground.TabIndex = 9;
            menuStripBackground.TabStop = false;
            // 
            // pnlAddEditUser
            // 
            pnlAddEditUser.BackColor = Color.White;
            pnlAddEditUser.Controls.Add(btnCreateEmployee);
            pnlAddEditUser.Controls.Add(btnCancelEdit);
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
            pnlAddEditUser.Location = new Point(0, 196);
            pnlAddEditUser.Margin = new Padding(5);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(1110, 1048);
            pnlAddEditUser.TabIndex = 10;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.BackColor = Color.LightGreen;
            btnCreateEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateEmployee.Location = new Point(569, 712);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(226, 67);
            btnCreateEmployee.TabIndex = 17;
            btnCreateEmployee.Text = "Create Employee";
            btnCreateEmployee.UseVisualStyleBackColor = false;
            btnCreateEmployee.Visible = false;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnCancelEdit
            // 
            btnCancelEdit.BackColor = Color.Silver;
            btnCancelEdit.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelEdit.Location = new Point(319, 712);
            btnCancelEdit.Name = "btnCancelEdit";
            btnCancelEdit.Size = new Size(226, 67);
            btnCancelEdit.TabIndex = 16;
            btnCancelEdit.Text = "Cancel Changes";
            btnCancelEdit.UseVisualStyleBackColor = false;
            btnCancelEdit.Click += btnCancelEdit_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.BackColor = Color.Orange;
            btnUpdateEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateEmployee.Location = new Point(569, 712);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(226, 67);
            btnUpdateEmployee.TabIndex = 15;
            btnUpdateEmployee.Text = "Update Employee";
            btnUpdateEmployee.UseVisualStyleBackColor = false;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // comboBoxTypeUser
            // 
            comboBoxTypeUser.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxTypeUser.FormattingEnabled = true;
            comboBoxTypeUser.Items.AddRange(new object[] { "RegularEmployee", "ServiceDeskEmployee" });
            comboBoxTypeUser.Location = new Point(443, 273);
            comboBoxTypeUser.Name = "comboBoxTypeUser";
            comboBoxTypeUser.Size = new Size(231, 39);
            comboBoxTypeUser.TabIndex = 14;
            // 
            // textBoxBranch
            // 
            textBoxBranch.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBranch.Location = new Point(443, 461);
            textBoxBranch.Name = "textBoxBranch";
            textBoxBranch.Size = new Size(231, 38);
            textBoxBranch.TabIndex = 13;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPhoneNumber.Location = new Point(443, 398);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(231, 38);
            textBoxPhoneNumber.TabIndex = 12;
            // 
            // textBoxEmailAddress
            // 
            textBoxEmailAddress.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmailAddress.Location = new Point(443, 337);
            textBoxEmailAddress.Name = "textBoxEmailAddress";
            textBoxEmailAddress.Size = new Size(231, 38);
            textBoxEmailAddress.TabIndex = 11;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLastName.Location = new Point(443, 208);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(231, 38);
            textBoxLastName.TabIndex = 10;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFirstName.Location = new Point(443, 142);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(231, 38);
            textBoxFirstName.TabIndex = 9;
            // 
            // lblBranchEdit
            // 
            lblBranchEdit.AutoSize = true;
            lblBranchEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblBranchEdit.Location = new Point(54, 467);
            lblBranchEdit.Name = "lblBranchEdit";
            lblBranchEdit.Size = new Size(92, 32);
            lblBranchEdit.TabIndex = 8;
            lblBranchEdit.Text = "Branch:";
            // 
            // lblPhoneNumberEdit
            // 
            lblPhoneNumberEdit.AutoSize = true;
            lblPhoneNumberEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumberEdit.Location = new Point(54, 404);
            lblPhoneNumberEdit.Name = "lblPhoneNumberEdit";
            lblPhoneNumberEdit.Size = new Size(178, 32);
            lblPhoneNumberEdit.TabIndex = 7;
            lblPhoneNumberEdit.Text = "Phone number:";
            // 
            // lblEmailAddressEdit
            // 
            lblEmailAddressEdit.AutoSize = true;
            lblEmailAddressEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailAddressEdit.Location = new Point(54, 343);
            lblEmailAddressEdit.Name = "lblEmailAddressEdit";
            lblEmailAddressEdit.Size = new Size(174, 32);
            lblEmailAddressEdit.TabIndex = 6;
            lblEmailAddressEdit.Text = "E-mail address:";
            // 
            // lblTypeUserEdit
            // 
            lblTypeUserEdit.AutoSize = true;
            lblTypeUserEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblTypeUserEdit.Location = new Point(54, 280);
            lblTypeUserEdit.Name = "lblTypeUserEdit";
            lblTypeUserEdit.Size = new Size(158, 32);
            lblTypeUserEdit.TabIndex = 5;
            lblTypeUserEdit.Text = "Type of user: ";
            // 
            // lblLastNameEdit
            // 
            lblLastNameEdit.AutoSize = true;
            lblLastNameEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastNameEdit.Location = new Point(54, 214);
            lblLastNameEdit.Name = "lblLastNameEdit";
            lblLastNameEdit.Size = new Size(127, 32);
            lblLastNameEdit.TabIndex = 4;
            lblLastNameEdit.Text = "Last name:";
            // 
            // lblFirstNameEdit
            // 
            lblFirstNameEdit.AutoSize = true;
            lblFirstNameEdit.Font = new Font("Segoe UI", 9.857143F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstNameEdit.Location = new Point(51, 148);
            lblFirstNameEdit.Name = "lblFirstNameEdit";
            lblFirstNameEdit.Size = new Size(130, 32);
            lblFirstNameEdit.TabIndex = 3;
            lblFirstNameEdit.Text = "First name:";
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.Tomato;
            btnDeleteEmployee.Font = new Font("Segoe UI Semibold", 9.857143F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteEmployee.Location = new Point(817, 712);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(226, 67);
            btnDeleteEmployee.TabIndex = 2;
            btnDeleteEmployee.Text = "Delete Employee";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(51, 50);
            lblAddEditUser.Margin = new Padding(5, 0, 5, 0);
            lblAddEditUser.Name = "lblAddEditUser";
            lblAddEditUser.Size = new Size(284, 57);
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
            splitterAddEditUser.Size = new Size(1110, 2);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(168F, 168F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(1110, 1027);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
            Controls.Add(menuStripBackground);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlLogin);
            Controls.Add(pnlUsers);
            Controls.Add(pnlAddEditUser);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlDashboard);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 2, 4, 2);
            Name = "GardenDeskForm";
            Text = "GardenDesk";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
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
        private ColumnHeader userId;
        private ColumnHeader userEmail;
        private ColumnHeader userFirstName;
        private ColumnHeader userLastName;
        private ColumnHeader userTicketCount;
        private ListView ticketsListView;
        private ColumnHeader ticketTitle;
        private ColumnHeader ticketReportingUser;
        private ColumnHeader ticketCreationDate;
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
        private Button btnCancelEdit;
        private Button btnUpdateEmployee;
        private Button btnCreateEmployee;
        private Button btnEscalate;
    }
}
