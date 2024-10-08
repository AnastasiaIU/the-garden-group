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
            ListViewItem listViewItem1 = new ListViewItem("");
            logo = new PictureBox();
            lblGardenDesk = new Label();
            lblLicense = new Label();
            menuStrip = new MenuStrip();
            menuItemDashboard = new ToolStripMenuItem();
            menuItemIncedents = new ToolStripMenuItem();
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
            lblTicketsOverview = new Label();
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            splitterTicketsOverview = new Splitter();
            pnlUsers = new Panel();
            btnAddUser = new Button();
            usersList = new ListView();
            leftColumn = new ColumnHeader();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemDashboard, menuItemIncedents, menuItemUsers });
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
            // 
            // menuItemIncedents
            // 
            menuItemIncedents.AutoSize = false;
            menuItemIncedents.Name = "menuItemIncedents";
            menuItemIncedents.Size = new Size(210, 30);
            menuItemIncedents.Text = "Incedent Management";
            menuItemIncedents.Click += menuItemIncedents_Click;
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
            btnLogin.Click += BtnLogin_Click;
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
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(300, 29);
            txtBoxLoginPassword.TabIndex = 2;
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
            lblLoginPrompt.Size = new Size(334, 56);
            lblLoginPrompt.TabIndex = 0;
            lblLoginPrompt.Text = "Please provide login credentials to log in to GardenDesk for The Garden Group.";
            lblLoginPrompt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLoginGardenDesk
            // 
            lblLoginGardenDesk.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginGardenDesk.Location = new Point(0, 0);
            lblLoginGardenDesk.Name = "lblLoginGardenDesk";
            lblLoginGardenDesk.Size = new Size(634, 37);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 112);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(634, 599);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(228, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(152, 32);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "DASHBOARD";
            // 
            // splitterDashboard
            // 
            splitterDashboard.BackColor = Color.Black;
            splitterDashboard.Dock = DockStyle.Top;
            splitterDashboard.Location = new Point(0, 0);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(634, 1);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(ticketsListView);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 112);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(634, 599);
            pnlTicketsOverview.TabIndex = 6;
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
            ticketsListView.Columns.AddRange(new ColumnHeader[] { ticketTitle, ticketReportingUser, ticketCreationDate, ticketStatus });
            ticketsListView.Location = new Point(29, 63);
            ticketsListView.Margin = new Padding(2);
            ticketsListView.Name = "ticketsListView";
            ticketsListView.Size = new Size(582, 383);
            ticketsListView.TabIndex = 2;
            ticketsListView.UseCompatibleStateImageBehavior = false;
            ticketsListView.View = View.Details;
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
            // splitterTicketsOverview
            // 
            splitterTicketsOverview.BackColor = Color.Black;
            splitterTicketsOverview.Dock = DockStyle.Top;
            splitterTicketsOverview.Location = new Point(0, 0);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(634, 1);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(btnAddUser);
            pnlUsers.Controls.Add(usersList);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Location = new Point(0, 112);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(634, 599);
            pnlUsers.TabIndex = 7;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.YellowGreen;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Location = new Point(495, 11);
            btnAddUser.Margin = new Padding(1);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(116, 38);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "+ADD NEW USER";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
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
            splitterUsers.Name = "splitterUsers";
            splitterUsers.Size = new Size(634, 1);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 112);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(634, 599);
            pnlAddEditTicket.TabIndex = 8;
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
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(634, 1);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
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
            pnlAddEditUser.Controls.Add(lblAddEditUser);
            pnlAddEditUser.Controls.Add(splitterAddEditUser);
            pnlAddEditUser.Location = new Point(0, 112);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(634, 599);
            pnlAddEditUser.TabIndex = 10;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(228, 17);
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
            splitterAddEditUser.Name = "splitterAddEditUser";
            splitterAddEditUser.Size = new Size(634, 1);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(634, 587);
            Controls.Add(pnlUsers);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlLogin);
            Controls.Add(pnlAddEditUser);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlDashboard);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
            Controls.Add(menuStripBackground);
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
        private ToolStripMenuItem menuItemIncedents;
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
        private ColumnHeader ticketCreationDate;
        private ColumnHeader ticketStatus;
        private Button btnAddUser;
    }
}
