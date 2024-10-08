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
            ticketsListView = new ListView();
            ticketTitle = new ColumnHeader();
            ticketReportingUser = new ColumnHeader();
            ticketCreationDate = new ColumnHeader();
            ticketStatus = new ColumnHeader();
            lblTicketsOverview = new Label();
            splitterTicketsOverview = new Splitter();
            pnlUsers = new Panel();
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
            logo.Location = new Point(15, 0);
            logo.Margin = new Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new Size(112, 112);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblGardenDesk
            // 
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(728, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 10, 15, 0);
            lblGardenDesk.Size = new Size(224, 48);
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(686, 75);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 15, 0);
            lblLicense.Size = new Size(268, 22);
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
            menuStrip.Location = new Point(0, 120);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(4, 2, 0, 2);
            menuStrip.Size = new Size(951, 48);
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
            pnlLogin.Location = new Point(0, 168);
            pnlLogin.Margin = new Padding(4);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(951, 898);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(363, 570);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 68);
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
            lblLoginWrongCredentials.Location = new Point(250, 495);
            lblLoginWrongCredentials.Margin = new Padding(4, 0, 4, 0);
            lblLoginWrongCredentials.Name = "lblLoginWrongCredentials";
            lblLoginWrongCredentials.Size = new Size(446, 32);
            lblLoginWrongCredentials.TabIndex = 0;
            lblLoginWrongCredentials.Text = "Wrong username or password. Try again.";
            lblLoginWrongCredentials.Visible = false;
            // 
            // txtBoxLoginPassword
            // 
            txtBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginPassword.Location = new Point(250, 420);
            txtBoxLoginPassword.Margin = new Padding(4);
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(449, 39);
            txtBoxLoginPassword.TabIndex = 2;
            // 
            // txtBoxLoginUsername
            // 
            txtBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginUsername.Location = new Point(250, 300);
            txtBoxLoginUsername.Margin = new Padding(4);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(449, 39);
            txtBoxLoginUsername.TabIndex = 1;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(250, 375);
            lblLoginPassword.Margin = new Padding(4, 0, 4, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(116, 32);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(250, 255);
            lblLoginUsername.Margin = new Padding(4, 0, 4, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(126, 32);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(225, 105);
            lblLoginPrompt.Margin = new Padding(4, 0, 4, 0);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new Size(501, 84);
            lblLoginPrompt.TabIndex = 0;
            lblLoginPrompt.Text = "Please provide login credentials to log in to GardenDesk for The Garden Group.";
            lblLoginPrompt.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLoginGardenDesk
            // 
            lblLoginGardenDesk.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginGardenDesk.Location = new Point(0, 0);
            lblLoginGardenDesk.Margin = new Padding(4, 0, 4, 0);
            lblLoginGardenDesk.Name = "lblLoginGardenDesk";
            lblLoginGardenDesk.Size = new Size(951, 56);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 168);
            pnlDashboard.Margin = new Padding(4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(951, 898);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(342, 26);
            lblDashboard.Margin = new Padding(4, 0, 4, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(229, 48);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "DASHBOARD";
            // 
            // splitterDashboard
            // 
            splitterDashboard.BackColor = Color.Black;
            splitterDashboard.Dock = DockStyle.Top;
            splitterDashboard.Location = new Point(0, 0);
            splitterDashboard.Margin = new Padding(4);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(951, 2);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(ticketsListView);
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 168);
            pnlTicketsOverview.Margin = new Padding(4);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(951, 898);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // ticketsListView
            // 
            ticketsListView.BackColor = SystemColors.InactiveCaption;
            ticketsListView.Columns.AddRange(new ColumnHeader[] { ticketTitle, ticketReportingUser, ticketCreationDate, ticketStatus });
            ticketsListView.Location = new Point(43, 95);
            ticketsListView.Name = "ticketsListView";
            ticketsListView.Size = new Size(871, 573);
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
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(29, 20);
            lblTicketsOverview.Margin = new Padding(4, 0, 4, 0);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Size = new Size(257, 45);
            lblTicketsOverview.TabIndex = 1;
            lblTicketsOverview.Text = "Tickets Overview";
            // 
            // splitterTicketsOverview
            // 
            splitterTicketsOverview.BackColor = Color.Black;
            splitterTicketsOverview.Dock = DockStyle.Top;
            splitterTicketsOverview.Location = new Point(0, 0);
            splitterTicketsOverview.Margin = new Padding(4);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(951, 2);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(usersList);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Location = new Point(0, 168);
            pnlUsers.Margin = new Padding(4);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(951, 898);
            pnlUsers.TabIndex = 7;
            // 
            // usersList
            // 
            usersList.Columns.AddRange(new ColumnHeader[] { leftColumn, userId, userEmail, userFirstName, userLastName, userTicketCount });
            listViewItem1.Tag = "ID";
            usersList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            usersList.Location = new Point(18, 141);
            usersList.Margin = new Padding(4);
            usersList.Name = "usersList";
            usersList.Size = new Size(913, 738);
            usersList.TabIndex = 2;
            usersList.UseCompatibleStateImageBehavior = false;
            usersList.View = View.Details;
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
            lblUsers.Location = new Point(18, 56);
            lblUsers.Margin = new Padding(4, 0, 4, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(327, 48);
            lblUsers.TabIndex = 1;
            lblUsers.Text = "User management";
            // 
            // splitterUsers
            // 
            splitterUsers.BackColor = Color.Black;
            splitterUsers.Dock = DockStyle.Top;
            splitterUsers.Location = new Point(0, 0);
            splitterUsers.Margin = new Padding(4);
            splitterUsers.Name = "splitterUsers";
            splitterUsers.Size = new Size(951, 2);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 168);
            pnlAddEditTicket.Margin = new Padding(4);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(951, 898);
            pnlAddEditTicket.TabIndex = 8;
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.AutoSize = true;
            lblAddEditTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(342, 26);
            lblAddEditTicket.Margin = new Padding(4, 0, 4, 0);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Size = new Size(263, 48);
            lblAddEditTicket.TabIndex = 1;
            lblAddEditTicket.Text = "Add/Edit Ticket";
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(4);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(951, 2);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // menuStripBackground
            // 
            menuStripBackground.BackColor = Color.White;
            menuStripBackground.Location = new Point(0, 120);
            menuStripBackground.Margin = new Padding(4);
            menuStripBackground.Name = "menuStripBackground";
            menuStripBackground.Size = new Size(951, 48);
            menuStripBackground.TabIndex = 9;
            menuStripBackground.TabStop = false;
            // 
            // pnlAddEditUser
            // 
            pnlAddEditUser.BackColor = Color.White;
            pnlAddEditUser.Controls.Add(lblAddEditUser);
            pnlAddEditUser.Controls.Add(splitterAddEditUser);
            pnlAddEditUser.Location = new Point(0, 168);
            pnlAddEditUser.Margin = new Padding(4);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(951, 898);
            pnlAddEditUser.TabIndex = 10;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(342, 26);
            lblAddEditUser.Margin = new Padding(4, 0, 4, 0);
            lblAddEditUser.Name = "lblAddEditUser";
            lblAddEditUser.Size = new Size(241, 48);
            lblAddEditUser.TabIndex = 1;
            lblAddEditUser.Text = "Add/Edit User";
            // 
            // splitterAddEditUser
            // 
            splitterAddEditUser.BackColor = Color.Black;
            splitterAddEditUser.Dock = DockStyle.Top;
            splitterAddEditUser.Location = new Point(0, 0);
            splitterAddEditUser.Margin = new Padding(4);
            splitterAddEditUser.Name = "splitterAddEditUser";
            splitterAddEditUser.Size = new Size(951, 2);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(951, 880);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(pnlLogin);
            Controls.Add(pnlUsers);
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
            Margin = new Padding(3, 2, 3, 2);
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
    }
}
