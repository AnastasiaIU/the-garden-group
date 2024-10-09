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
            ListViewItem listViewItem2 = new ListViewItem("");
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
            submitTicketBtn = new Button();
            cancelButton = new Button();
            descriptionRTBox = new RichTextBox();
            subjectTBox = new TextBox();
            deadLineCBox = new ComboBox();
            priorityCBox = new ComboBox();
            repByUserCBox = new ComboBox();
            typeIncidCBox = new ComboBox();
            dateTimeRepCBox = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            logo.Location = new Point(20, 0);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(149, 149);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblGardenDesk
            // 
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(971, 0);
            lblGardenDesk.Margin = new Padding(4, 0, 4, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 13, 20, 0);
            lblGardenDesk.Size = new Size(299, 64);
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(915, 100);
            lblLicense.Margin = new Padding(4, 0, 4, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 20, 0);
            lblLicense.Size = new Size(357, 29);
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
            menuStrip.Location = new Point(0, 160);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 3, 0, 3);
            menuStrip.Size = new Size(1268, 64);
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
            pnlLogin.Location = new Point(0, 224);
            pnlLogin.Margin = new Padding(5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1268, 1197);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(484, 760);
            btnLogin.Margin = new Padding(5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 91);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lblLoginWrongCredentials
            // 
            lblLoginWrongCredentials.AutoSize = true;
            lblLoginWrongCredentials.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginWrongCredentials.ForeColor = Color.Red;
            lblLoginWrongCredentials.Location = new Point(333, 660);
            lblLoginWrongCredentials.Margin = new Padding(5, 0, 5, 0);
            lblLoginWrongCredentials.Name = "lblLoginWrongCredentials";
            lblLoginWrongCredentials.Size = new Size(597, 45);
            lblLoginWrongCredentials.TabIndex = 0;
            lblLoginWrongCredentials.Text = "Wrong username or password. Try again.";
            lblLoginWrongCredentials.Visible = false;
            // 
            // txtBoxLoginPassword
            // 
            txtBoxLoginPassword.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginPassword.Location = new Point(333, 560);
            txtBoxLoginPassword.Margin = new Padding(5);
            txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            txtBoxLoginPassword.PasswordChar = '•';
            txtBoxLoginPassword.PlaceholderText = " Enter password";
            txtBoxLoginPassword.Size = new Size(598, 50);
            txtBoxLoginPassword.TabIndex = 2;
            // 
            // txtBoxLoginUsername
            // 
            txtBoxLoginUsername.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLoginUsername.Location = new Point(333, 400);
            txtBoxLoginUsername.Margin = new Padding(5);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(598, 50);
            txtBoxLoginUsername.TabIndex = 1;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(333, 500);
            lblLoginPassword.Margin = new Padding(5, 0, 5, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(160, 45);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(333, 340);
            lblLoginUsername.Margin = new Padding(5, 0, 5, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(170, 45);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(300, 140);
            lblLoginPrompt.Margin = new Padding(5, 0, 5, 0);
            lblLoginPrompt.Name = "lblLoginPrompt";
            lblLoginPrompt.Size = new Size(668, 112);
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
            lblLoginGardenDesk.Size = new Size(1268, 75);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 224);
            pnlDashboard.Margin = new Padding(5);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1268, 1197);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(456, 35);
            lblDashboard.Margin = new Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(309, 65);
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
            splitterDashboard.Size = new Size(1268, 3);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 224);
            pnlTicketsOverview.Margin = new Padding(5);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(1268, 1197);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(456, 27);
            lblTicketsOverview.Margin = new Padding(5, 0, 5, 0);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Size = new Size(427, 72);
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
            splitterTicketsOverview.Size = new Size(1268, 3);
            splitterTicketsOverview.TabIndex = 0;
            splitterTicketsOverview.TabStop = false;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(usersList);
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitterUsers);
            pnlUsers.Location = new Point(0, 224);
            pnlUsers.Margin = new Padding(5);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(1268, 1197);
            pnlUsers.TabIndex = 7;
            // 
            // usersList
            // 
            usersList.Columns.AddRange(new ColumnHeader[] { leftColumn, userId, userEmail, userFirstName, userLastName, userTicketCount });
            listViewItem2.Tag = "ID";
            usersList.Items.AddRange(new ListViewItem[] { listViewItem2 });
            usersList.Location = new Point(24, 188);
            usersList.Margin = new Padding(5);
            usersList.Name = "usersList";
            usersList.Size = new Size(1216, 983);
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
            lblUsers.Location = new Point(24, 75);
            lblUsers.Margin = new Padding(5, 0, 5, 0);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(441, 65);
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
            splitterUsers.Size = new Size(1268, 3);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(submitTicketBtn);
            pnlAddEditTicket.Controls.Add(cancelButton);
            pnlAddEditTicket.Controls.Add(descriptionRTBox);
            pnlAddEditTicket.Controls.Add(subjectTBox);
            pnlAddEditTicket.Controls.Add(deadLineCBox);
            pnlAddEditTicket.Controls.Add(priorityCBox);
            pnlAddEditTicket.Controls.Add(repByUserCBox);
            pnlAddEditTicket.Controls.Add(typeIncidCBox);
            pnlAddEditTicket.Controls.Add(dateTimeRepCBox);
            pnlAddEditTicket.Controls.Add(label7);
            pnlAddEditTicket.Controls.Add(label6);
            pnlAddEditTicket.Controls.Add(label5);
            pnlAddEditTicket.Controls.Add(label4);
            pnlAddEditTicket.Controls.Add(label3);
            pnlAddEditTicket.Controls.Add(label2);
            pnlAddEditTicket.Controls.Add(label1);
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 224);
            pnlAddEditTicket.Margin = new Padding(5);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(1268, 1197);
            pnlAddEditTicket.TabIndex = 8;
            // 
            // submitTicketBtn
            // 
            submitTicketBtn.Location = new Point(666, 1030);
            submitTicketBtn.Name = "submitTicketBtn";
            submitTicketBtn.Size = new Size(170, 88);
            submitTicketBtn.TabIndex = 17;
            submitTicketBtn.Text = "SUBMIT TICKET";
            submitTicketBtn.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(415, 1030);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(170, 88);
            cancelButton.TabIndex = 16;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // descriptionRTBox
            // 
            descriptionRTBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionRTBox.Location = new Point(415, 745);
            descriptionRTBox.Name = "descriptionRTBox";
            descriptionRTBox.Size = new Size(422, 228);
            descriptionRTBox.TabIndex = 15;
            descriptionRTBox.Text = "";
            // 
            // subjectTBox
            // 
            subjectTBox.BorderStyle = BorderStyle.FixedSingle;
            subjectTBox.Location = new Point(415, 227);
            subjectTBox.Name = "subjectTBox";
            subjectTBox.Size = new Size(421, 39);
            subjectTBox.TabIndex = 14;
            // 
            // deadLineCBox
            // 
            deadLineCBox.FormattingEnabled = true;
            deadLineCBox.Location = new Point(415, 642);
            deadLineCBox.Name = "deadLineCBox";
            deadLineCBox.Size = new Size(422, 40);
            deadLineCBox.TabIndex = 13;
            // 
            // priorityCBox
            // 
            priorityCBox.FormattingEnabled = true;
            priorityCBox.Location = new Point(415, 536);
            priorityCBox.Name = "priorityCBox";
            priorityCBox.Size = new Size(422, 40);
            priorityCBox.TabIndex = 12;
            // 
            // repByUserCBox
            // 
            repByUserCBox.FormattingEnabled = true;
            repByUserCBox.Location = new Point(415, 422);
            repByUserCBox.Name = "repByUserCBox";
            repByUserCBox.Size = new Size(422, 40);
            repByUserCBox.TabIndex = 11;
            // 
            // typeIncidCBox
            // 
            typeIncidCBox.FormattingEnabled = true;
            typeIncidCBox.Location = new Point(415, 320);
            typeIncidCBox.Name = "typeIncidCBox";
            typeIncidCBox.Size = new Size(422, 40);
            typeIncidCBox.TabIndex = 10;
            // 
            // dateTimeRepCBox
            // 
            dateTimeRepCBox.FormattingEnabled = true;
            dateTimeRepCBox.Location = new Point(414, 137);
            dateTimeRepCBox.Name = "dateTimeRepCBox";
            dateTimeRepCBox.Size = new Size(422, 40);
            dateTimeRepCBox.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 745);
            label7.Name = "label7";
            label7.Size = new Size(140, 32);
            label7.TabIndex = 8;
            label7.Text = "Description:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(120, 650);
            label6.Name = "label6";
            label6.Size = new Size(223, 32);
            label6.TabIndex = 7;
            label6.Text = "Deadline/follow up:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 544);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 6;
            label5.Text = "Priority:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 430);
            label4.Name = "label4";
            label4.Size = new Size(201, 32);
            label4.TabIndex = 5;
            label4.Text = "Reported by user:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 328);
            label3.Name = "label3";
            label3.Size = new Size(192, 32);
            label3.TabIndex = 4;
            label3.Text = "Type of incident:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 230);
            label2.Name = "label2";
            label2.Size = new Size(220, 32);
            label2.TabIndex = 3;
            label2.Text = "Subject of incident:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 140);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 2;
            label1.Text = "Date/time reported:";
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.AutoSize = true;
            lblAddEditTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(456, 27);
            lblAddEditTicket.Margin = new Padding(5, 0, 5, 0);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Size = new Size(58, 65);
            lblAddEditTicket.TabIndex = 1;
            lblAddEditTicket.Text = "...";
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(5);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(1268, 3);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // menuStripBackground
            // 
            menuStripBackground.BackColor = Color.White;
            menuStripBackground.Location = new Point(0, 160);
            menuStripBackground.Margin = new Padding(5);
            menuStripBackground.Name = "menuStripBackground";
            menuStripBackground.Size = new Size(1268, 64);
            menuStripBackground.TabIndex = 9;
            menuStripBackground.TabStop = false;
            // 
            // pnlAddEditUser
            // 
            pnlAddEditUser.BackColor = Color.White;
            pnlAddEditUser.Controls.Add(lblAddEditUser);
            pnlAddEditUser.Controls.Add(splitterAddEditUser);
            pnlAddEditUser.Location = new Point(0, 224);
            pnlAddEditUser.Margin = new Padding(5);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(1268, 1197);
            pnlAddEditUser.TabIndex = 10;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(456, 35);
            lblAddEditUser.Margin = new Padding(5, 0, 5, 0);
            lblAddEditUser.Name = "lblAddEditUser";
            lblAddEditUser.Size = new Size(322, 65);
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
            splitterAddEditUser.Size = new Size(1268, 3);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(1268, 1421);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlUsers);
            Controls.Add(pnlLogin);
            Controls.Add(pnlAddEditUser);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
            Controls.Add(menuStripBackground);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
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
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox subjectTBox;
        private ComboBox deadLineCBox;
        private ComboBox priorityCBox;
        private ComboBox repByUserCBox;
        private ComboBox typeIncidCBox;
        private RichTextBox descriptionRTBox;
        private Button submitTicketBtn;
        private Button cancelButton;
        public ComboBox dateTimeRepCBox;
    }
}
