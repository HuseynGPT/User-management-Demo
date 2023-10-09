namespace Practice_sidebar_and_listview
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            IDTxtBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nameTxtBox = new TextBox();
            label4 = new Label();
            surnameTxtBox = new TextBox();
            label5 = new Label();
            ageTxtBox = new TextBox();
            SaveUserBtn = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(23, 24, 29);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(640, 77);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(184, 29);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 1;
            label1.Text = "Adding New User";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Add_Male_User_Group_32px;
            pictureBox1.Location = new Point(68, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // IDTxtBox
            // 
            IDTxtBox.Location = new Point(90, 157);
            IDTxtBox.Name = "IDTxtBox";
            IDTxtBox.Size = new Size(168, 23);
            IDTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 155);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 2;
            label2.Text = "User's ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 184);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(90, 186);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(168, 23);
            nameTxtBox.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 213);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Surname";
            // 
            // surnameTxtBox
            // 
            surnameTxtBox.Location = new Point(90, 215);
            surnameTxtBox.Name = "surnameTxtBox";
            surnameTxtBox.Size = new Size(168, 23);
            surnameTxtBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 8;
            label5.Text = "Age";
            // 
            // ageTxtBox
            // 
            ageTxtBox.Location = new Point(90, 244);
            ageTxtBox.Name = "ageTxtBox";
            ageTxtBox.Size = new Size(168, 23);
            ageTxtBox.TabIndex = 7;
            // 
            // SaveUserBtn
            // 
            SaveUserBtn.BackColor = Color.FromArgb(23, 24, 29);
            SaveUserBtn.FlatStyle = FlatStyle.Popup;
            SaveUserBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SaveUserBtn.ForeColor = Color.White;
            SaveUserBtn.Location = new Point(12, 314);
            SaveUserBtn.Name = "SaveUserBtn";
            SaveUserBtn.Size = new Size(246, 35);
            SaveUserBtn.TabIndex = 9;
            SaveUserBtn.Text = "SAVE";
            SaveUserBtn.UseVisualStyleBackColor = false;
            SaveUserBtn.Click += SaveUserBtn_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Silver;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(271, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(331, 254);
            listView1.TabIndex = 10;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Number";
            columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surname";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Age";
            columnHeader4.Width = 100;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 455);
            Controls.Add(listView1);
            Controls.Add(SaveUserBtn);
            Controls.Add(label5);
            Controls.Add(ageTxtBox);
            Controls.Add(label4);
            Controls.Add(surnameTxtBox);
            Controls.Add(label3);
            Controls.Add(nameTxtBox);
            Controls.Add(label2);
            Controls.Add(IDTxtBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddUserForm";
            Text = "AddUserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox IDTxtBox;
        private Label label2;
        private Label label3;
        private TextBox nameTxtBox;
        private Label label4;
        private TextBox surnameTxtBox;
        private Label label5;
        private TextBox ageTxtBox;
        private Button SaveUserBtn;
        public ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}