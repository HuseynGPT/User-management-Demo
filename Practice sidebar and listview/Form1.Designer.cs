namespace Practice_sidebar_and_listview
{
    public partial class Form1
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
            mainpanel = new Panel();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            sidebarBtn = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel1 = new Panel();
            HomeBtn = new Button();
            panel5 = new Panel();
            AddNewUserBtn = new Button();
            panel2 = new Panel();
            FindUserBtn = new Button();
            panel3 = new Panel();
            ShowAllUsersBtn = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            mainpanelv2 = new Panel();
            mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarBtn).BeginInit();
            sidebar.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.BackColor = Color.White;
            mainpanel.Controls.Add(button2);
            mainpanel.Controls.Add(button1);
            mainpanel.Controls.Add(label1);
            mainpanel.Controls.Add(sidebarBtn);
            mainpanel.Dock = DockStyle.Top;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(816, 33);
            mainpanel.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ControlText;
            button2.Image = Properties.Resources.icons8_close_16;
            button2.Location = new Point(782, 3);
            button2.Name = "button2";
            button2.Size = new Size(31, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseHover += button2_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Image = Properties.Resources.icons8_left_16;
            button1.Location = new Point(745, 2);
            button1.Name = "button1";
            button1.Size = new Size(34, 33);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(35, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "User Management";
            // 
            // sidebarBtn
            // 
            sidebarBtn.Image = Properties.Resources.meuv2_16;
            sidebarBtn.Location = new Point(3, 3);
            sidebarBtn.Name = "sidebarBtn";
            sidebarBtn.Size = new Size(26, 26);
            sidebarBtn.SizeMode = PictureBoxSizeMode.CenterImage;
            sidebarBtn.TabIndex = 1;
            sidebarBtn.TabStop = false;
            sidebarBtn.Click += sidebarBtn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(23, 24, 29);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 33);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(181, 397);
            sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(HomeBtn);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 52);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.FromArgb(23, 24, 29);
            HomeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Image = Properties.Resources.home_32px;
            HomeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            HomeBtn.Location = new Point(-5, -24);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(183, 97);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(AddNewUserBtn);
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(160, 49);
            panel5.TabIndex = 4;
            // 
            // AddNewUserBtn
            // 
            AddNewUserBtn.BackColor = Color.FromArgb(23, 24, 29);
            AddNewUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewUserBtn.ForeColor = SystemColors.Control;
            AddNewUserBtn.Image = Properties.Resources.icons8_add_user_male_161;
            AddNewUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AddNewUserBtn.Location = new Point(-5, -12);
            AddNewUserBtn.Name = "AddNewUserBtn";
            AddNewUserBtn.Padding = new Padding(10, 0, 0, 0);
            AddNewUserBtn.Size = new Size(183, 77);
            AddNewUserBtn.TabIndex = 3;
            AddNewUserBtn.Text = "Add new user";
            AddNewUserBtn.UseVisualStyleBackColor = false;
            AddNewUserBtn.Click += AddNewUserBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(FindUserBtn);
            panel2.Location = new Point(3, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 51);
            panel2.TabIndex = 5;
            // 
            // FindUserBtn
            // 
            FindUserBtn.BackColor = Color.FromArgb(23, 24, 29);
            FindUserBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FindUserBtn.ForeColor = SystemColors.Control;
            FindUserBtn.Image = Properties.Resources.icons8_find_user_male_16;
            FindUserBtn.ImageAlign = ContentAlignment.MiddleLeft;
            FindUserBtn.Location = new Point(-5, -12);
            FindUserBtn.Name = "FindUserBtn";
            FindUserBtn.Padding = new Padding(10, 0, 0, 0);
            FindUserBtn.Size = new Size(183, 77);
            FindUserBtn.TabIndex = 3;
            FindUserBtn.Text = "Find User";
            FindUserBtn.UseVisualStyleBackColor = false;
            FindUserBtn.Click += FindUserBtn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(ShowAllUsersBtn);
            panel3.Location = new Point(3, 173);
            panel3.Name = "panel3";
            panel3.Size = new Size(173, 51);
            panel3.TabIndex = 5;
            // 
            // ShowAllUsersBtn
            // 
            ShowAllUsersBtn.BackColor = Color.FromArgb(23, 24, 29);
            ShowAllUsersBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ShowAllUsersBtn.ForeColor = SystemColors.Control;
            ShowAllUsersBtn.Image = Properties.Resources.icons8_user_account_16;
            ShowAllUsersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ShowAllUsersBtn.Location = new Point(-5, -12);
            ShowAllUsersBtn.Name = "ShowAllUsersBtn";
            ShowAllUsersBtn.Padding = new Padding(10, 0, 0, 0);
            ShowAllUsersBtn.Size = new Size(183, 77);
            ShowAllUsersBtn.TabIndex = 3;
            ShowAllUsersBtn.Text = "Watch All Users";
            ShowAllUsersBtn.UseVisualStyleBackColor = false;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // mainpanelv2
            // 
            mainpanelv2.Location = new Point(182, 33);
            mainpanelv2.Name = "mainpanelv2";
            mainpanelv2.Size = new Size(634, 397);
            mainpanelv2.TabIndex = 2;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 430);
            Controls.Add(sidebar);
            Controls.Add(mainpanel);
            Controls.Add(mainpanelv2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            mainpanel.ResumeLayout(false);
            mainpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarBtn).EndInit();
            sidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Label label1;
        private PictureBox sidebarBtn;
        private Button button1;
        private Button button2;
        private FlowLayoutPanel sidebar;
        private Button addUserButton;
        private Button button3;
        private Panel panel4;
        private Button button4;
        private Panel panel5;
        private Button AddNewUserBtn;
        private Panel panel2;
        private Button FindUserBtn;
        private Panel panel3;
        private Button ShowAllUsersBtn;
        private System.Windows.Forms.Timer menuTransition;
        private Panel mainpanelv2;
        private Panel panel1;
        private Button HomeBtn;
    }
}