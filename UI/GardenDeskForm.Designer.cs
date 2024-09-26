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
            logo = new PictureBox();
            lblGardenDesk = new Label();
            lblLicense = new Label();
            menuStrip = new MenuStrip();
            menuItemDashboard = new ToolStripMenuItem();
            menuItemIncedents = new ToolStripMenuItem();
            menuItemUsers = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            pnlLogin = new Panel();
            splitter1 = new Splitter();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            splitter2 = new Splitter();
            lblLogin = new Label();
            pnlTicketsOverview = new Panel();
            lblTicketsOverview = new Label();
            splitter3 = new Splitter();
            pnlUsers = new Panel();
            lblUsers = new Label();
            splitter4 = new Splitter();
            pnlAddEditTicket = new Panel();
            lblAddEditTicket = new Label();
            splitter5 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            menuStrip.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlTicketsOverview.SuspendLayout();
            pnlUsers.SuspendLayout();
            pnlAddEditTicket.SuspendLayout();
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
            menuStrip.Items.AddRange(new ToolStripItem[] { menuItemDashboard, menuItemIncedents, menuItemUsers, toolStripMenuItem1 });
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
            // 
            // menuItemUsers
            // 
            menuItemUsers.AutoSize = false;
            menuItemUsers.Name = "menuItemUsers";
            menuItemUsers.Size = new Size(210, 30);
            menuItemUsers.Text = "User Managment";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 30);
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblLogin);
            pnlLogin.Controls.Add(splitter1);
            pnlLogin.Location = new Point(0, 112);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(634, 699);
            pnlLogin.TabIndex = 4;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.Black;
            splitter1.Dock = DockStyle.Top;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(634, 1);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.White;
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Controls.Add(splitter2);
            pnlDashboard.Location = new Point(0, 112);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(634, 699);
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
            // splitter2
            // 
            splitter2.BackColor = Color.Black;
            splitter2.Dock = DockStyle.Top;
            splitter2.Location = new Point(0, 0);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(634, 1);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(263, 17);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(95, 37);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "LOGIN";
            // 
            // pnlTicketsOverview
            // 
            pnlTicketsOverview.BackColor = Color.White;
            pnlTicketsOverview.Controls.Add(lblTicketsOverview);
            pnlTicketsOverview.Controls.Add(splitter3);
            pnlTicketsOverview.Location = new Point(0, 112);
            pnlTicketsOverview.Name = "pnlTicketsOverview";
            pnlTicketsOverview.Size = new Size(634, 699);
            pnlTicketsOverview.TabIndex = 6;
            // 
            // lblTicketsOverview
            // 
            lblTicketsOverview.AutoSize = true;
            lblTicketsOverview.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketsOverview.Location = new Point(228, 13);
            lblTicketsOverview.Name = "lblTicketsOverview";
            lblTicketsOverview.Size = new Size(214, 37);
            lblTicketsOverview.TabIndex = 1;
            lblTicketsOverview.Text = "Tickets Overview";
            // 
            // splitter3
            // 
            splitter3.BackColor = Color.Black;
            splitter3.Dock = DockStyle.Top;
            splitter3.Location = new Point(0, 0);
            splitter3.Name = "splitter3";
            splitter3.Size = new Size(634, 1);
            splitter3.TabIndex = 0;
            splitter3.TabStop = false;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = Color.White;
            pnlUsers.Controls.Add(lblUsers);
            pnlUsers.Controls.Add(splitter4);
            pnlUsers.Location = new Point(0, 112);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(634, 699);
            pnlUsers.TabIndex = 7;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsers.Location = new Point(228, 17);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(82, 32);
            lblUsers.TabIndex = 1;
            lblUsers.Text = "USERS";
            // 
            // splitter4
            // 
            splitter4.BackColor = Color.Black;
            splitter4.Dock = DockStyle.Top;
            splitter4.Location = new Point(0, 0);
            splitter4.Name = "splitter4";
            splitter4.Size = new Size(634, 1);
            splitter4.TabIndex = 0;
            splitter4.TabStop = false;
            // 
            // pnlAddEditTicket
            // 
            pnlAddEditTicket.BackColor = Color.White;
            pnlAddEditTicket.Controls.Add(lblAddEditTicket);
            pnlAddEditTicket.Controls.Add(splitter5);
            pnlAddEditTicket.Location = new Point(0, 112);
            pnlAddEditTicket.Name = "pnlAddEditTicket";
            pnlAddEditTicket.Size = new Size(634, 699);
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
            // splitter5
            // 
            splitter5.BackColor = Color.Black;
            splitter5.Dock = DockStyle.Top;
            splitter5.Location = new Point(0, 0);
            splitter5.Name = "splitter5";
            splitter5.Size = new Size(634, 1);
            splitter5.TabIndex = 0;
            splitter5.TabStop = false;
            // 
            // GardenDeskForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(226, 227, 211);
            ClientSize = new Size(634, 711);
            Controls.Add(pnlAddEditTicket);
            Controls.Add(pnlUsers);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlLogin);
            Controls.Add(pnlTicketsOverview);
            Controls.Add(lblLicense);
            Controls.Add(lblGardenDesk);
            Controls.Add(logo);
            Controls.Add(menuStrip);
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
        private Splitter splitter1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Panel pnlDashboard;
        private Splitter splitter2;
        private Label lblDashboard;
        private Label lblLogin;
        private Panel pnlTicketsOverview;
        private Label lblTicketsOverview;
        private Splitter splitter3;
        private Panel pnlUsers;
        private Label lblUsers;
        private Splitter splitter4;
        private Panel pnlAddEditTicket;
        private Label lblAddEditTicket;
        private Splitter splitter5;
    }
}
