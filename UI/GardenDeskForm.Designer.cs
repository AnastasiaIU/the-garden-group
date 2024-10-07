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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            lblAddEditTicket = new Label();
            splitterAddEditTicket = new Splitter();
            menuStripBackground = new PictureBox();
            pnlAddEditUser = new Panel();
            lblAddEditUser = new Label();
            splitterAddEditUser = new Splitter();
            chartResolved = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartOpen = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartClosed = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnShowList = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            menuStrip.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlTicketsOverview.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlAddEditTicket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuStripBackground).BeginInit();
            pnlAddEditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResolved).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOpen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(20, 0);
            logo.Margin = new Padding(4, 2, 4, 2);
            logo.Name = "logo";
            logo.Size = new Size(150, 150);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // lblGardenDesk
            // 
            lblGardenDesk.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblGardenDesk.Location = new Point(970, 0);
            lblGardenDesk.Margin = new Padding(4, 0, 4, 0);
            lblGardenDesk.Name = "lblGardenDesk";
            lblGardenDesk.Padding = new Padding(0, 14, 20, 0);
            lblGardenDesk.Size = new Size(298, 64);
            lblGardenDesk.TabIndex = 1;
            lblGardenDesk.Text = "GardenDesk";
            lblGardenDesk.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblLicense
            // 
            lblLicense.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblLicense.Location = new Point(914, 100);
            lblLicense.Margin = new Padding(4, 0, 4, 0);
            lblLicense.Name = "lblLicense";
            lblLicense.Padding = new Padding(0, 0, 20, 0);
            lblLicense.Size = new Size(358, 30);
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
            pnlLogin.Margin = new Padding(6);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1268, 1198);
            pnlLogin.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OliveDrab;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(484, 760);
            btnLogin.Margin = new Padding(6);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 90);
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
            lblLoginWrongCredentials.Location = new Point(334, 660);
            lblLoginWrongCredentials.Margin = new Padding(6, 0, 6, 0);
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
            txtBoxLoginPassword.Location = new Point(334, 560);
            txtBoxLoginPassword.Margin = new Padding(6);
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
            txtBoxLoginUsername.Location = new Point(334, 400);
            txtBoxLoginUsername.Margin = new Padding(6);
            txtBoxLoginUsername.Name = "txtBoxLoginUsername";
            txtBoxLoginUsername.PlaceholderText = " Enter username";
            txtBoxLoginUsername.Size = new Size(598, 50);
            txtBoxLoginUsername.TabIndex = 1;
            // 
            // lblLoginPassword
            // 
            lblLoginPassword.AutoSize = true;
            lblLoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPassword.Location = new Point(334, 500);
            lblLoginPassword.Margin = new Padding(6, 0, 6, 0);
            lblLoginPassword.Name = "lblLoginPassword";
            lblLoginPassword.Size = new Size(160, 45);
            lblLoginPassword.TabIndex = 0;
            lblLoginPassword.Text = "Password:";
            // 
            // lblLoginUsername
            // 
            lblLoginUsername.AutoSize = true;
            lblLoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginUsername.Location = new Point(334, 340);
            lblLoginUsername.Margin = new Padding(6, 0, 6, 0);
            lblLoginUsername.Name = "lblLoginUsername";
            lblLoginUsername.Size = new Size(170, 45);
            lblLoginUsername.TabIndex = 0;
            lblLoginUsername.Text = "Username:";
            // 
            // lblLoginPrompt
            // 
            lblLoginPrompt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoginPrompt.Location = new Point(300, 140);
            lblLoginPrompt.Margin = new Padding(6, 0, 6, 0);
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
            lblLoginGardenDesk.Margin = new Padding(6, 0, 6, 0);
            lblLoginGardenDesk.Name = "lblLoginGardenDesk";
            lblLoginGardenDesk.Size = new Size(1268, 74);
            lblLoginGardenDesk.TabIndex = 0;
            lblLoginGardenDesk.Text = "GardenDesk: TGG";
            lblLoginGardenDesk.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(btnShowList);
            pnlDashboard.Controls.Add(chartClosed);
            pnlDashboard.Controls.Add(chartOpen);
            pnlDashboard.Controls.Add(chartResolved);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitterDashboard);
            pnlDashboard.Location = new Point(0, 224);
            pnlDashboard.Margin = new Padding(6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(1268, 1198);
            pnlDashboard.TabIndex = 5;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblDashboard.Location = new Point(456, 34);
            lblDashboard.Margin = new Padding(6, 0, 6, 0);
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
            splitterDashboard.Margin = new Padding(6);
            splitterDashboard.Name = "splitterDashboard";
            splitterDashboard.Size = new Size(1268, 2);
            splitterDashboard.TabIndex = 0;
            splitterDashboard.TabStop = false;
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(splitterTicketsOverview);
            pnlTicketsOverview.Location = new Point(0, 224);
            pnlTicketsOverview.Margin = new Padding(6);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(1268, 1198);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(456, 26);
            lblTicketsOverview.Margin = new Padding(6, 0, 6, 0);
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
            splitterTicketsOverview.Margin = new Padding(6);
            splitterTicketsOverview.Name = "splitterTicketsOverview";
            splitterTicketsOverview.Size = new Size(1268, 2);
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
            pnlUsers.Margin = new Padding(6);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(1268, 1198);
            pnlUsers.TabIndex = 7;
            // 
            // usersList
            // 
            usersList.Columns.AddRange(new ColumnHeader[] { leftColumn, userId, userEmail, userFirstName, userLastName, userTicketCount });
            listViewItem1.Tag = "ID";
            usersList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            usersList.Location = new Point(24, 188);
            usersList.Margin = new Padding(6);
            usersList.Name = "usersList";
            usersList.Size = new Size(1216, 982);
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
            lblUsers.Location = new Point(24, 74);
            lblUsers.Margin = new Padding(6, 0, 6, 0);
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
            splitterUsers.Margin = new Padding(6);
            splitterUsers.Name = "splitterUsers";
            splitterUsers.Size = new Size(1268, 2);
            splitterUsers.TabIndex = 0;
            splitterUsers.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitterAddEditTicket);
            pnlAddEditTicket.Location = new Point(0, 224);
            pnlAddEditTicket.Margin = new Padding(6);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(1268, 1198);
            pnlAddEditTicket.TabIndex = 8;
            // 
            // lblAddEditTicket
            // 
            lblAddEditTicket.AutoSize = true;
            lblAddEditTicket.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditTicket.Location = new Point(456, 34);
            lblAddEditTicket.Margin = new Padding(6, 0, 6, 0);
            lblAddEditTicket.Name = "lblAddEditTicket";
            lblAddEditTicket.Size = new Size(351, 65);
            lblAddEditTicket.TabIndex = 1;
            lblAddEditTicket.Text = "Add/Edit Ticket";
            // 
            // splitterAddEditTicket
            // 
            splitterAddEditTicket.BackColor = Color.Black;
            splitterAddEditTicket.Dock = DockStyle.Top;
            splitterAddEditTicket.Location = new Point(0, 0);
            splitterAddEditTicket.Margin = new Padding(6);
            splitterAddEditTicket.Name = "splitterAddEditTicket";
            splitterAddEditTicket.Size = new Size(1268, 2);
            splitterAddEditTicket.TabIndex = 0;
            splitterAddEditTicket.TabStop = false;
            // 
            // menuStripBackground
            // 
            menuStripBackground.BackColor = Color.White;
            menuStripBackground.Location = new Point(0, 160);
            menuStripBackground.Margin = new Padding(6);
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
            pnlAddEditUser.Margin = new Padding(6);
            pnlAddEditUser.Name = "pnlAddEditUser";
            pnlAddEditUser.Size = new Size(1268, 1198);
            pnlAddEditUser.TabIndex = 10;
            // 
            // lblAddEditUser
            // 
            lblAddEditUser.AutoSize = true;
            lblAddEditUser.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEditUser.Location = new Point(456, 34);
            lblAddEditUser.Margin = new Padding(6, 0, 6, 0);
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
            splitterAddEditUser.Margin = new Padding(6);
            splitterAddEditUser.Name = "splitterAddEditUser";
            splitterAddEditUser.Size = new Size(1268, 2);
            splitterAddEditUser.TabIndex = 0;
            splitterAddEditUser.TabStop = false;
            // 
            // chartResolved
            // 
            chartArea3.Name = "ChartArea1";
            chartResolved.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartResolved.Legends.Add(legend3);
            chartResolved.Location = new Point(36, 159);
            chartResolved.Name = "chartResolved";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartResolved.Series.Add(series3);
            chartResolved.Size = new Size(363, 460);
            chartResolved.TabIndex = 2;
            chartResolved.Text = "Resolved";
            // 
            // chartOpen
            // 
            chartArea2.Name = "ChartArea1";
            chartOpen.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartOpen.Legends.Add(legend2);
            chartOpen.Location = new Point(413, 140);
            chartOpen.Name = "chartOpen";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartOpen.Series.Add(series2);
            chartOpen.Size = new Size(363, 460);
            chartOpen.TabIndex = 3;
            chartOpen.Text = "Open";
            // 
            // chartClosed
            // 
            chartArea1.Name = "ChartArea1";
            chartClosed.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartClosed.Legends.Add(legend1);
            chartClosed.Location = new Point(782, 140);
            chartClosed.Name = "chartClosed";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartClosed.Series.Add(series1);
            chartClosed.Size = new Size(363, 460);
            chartClosed.TabIndex = 4;
            chartClosed.Text = "Open";
            // 
            // btnShowList
            // 
            btnShowList.BackColor = Color.DarkTurquoise;
            btnShowList.ForeColor = Color.White;
            btnShowList.Location = new Point(990, 34);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(211, 65);
            btnShowList.TabIndex = 5;
            btnShowList.Text = "SHOW LIST";
            btnShowList.UseVisualStyleBackColor = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(1268, 1174);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlLogin);
            Controls.Add(pnlUsers);
            Controls.Add(pnlAddEditUser);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
            Controls.Add(menuStripBackground);
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
            ((System.ComponentModel.ISupportInitialize)chartResolved).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOpen).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartClosed).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartClosed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResolved;
        private Button btnShowList;
    }
}
