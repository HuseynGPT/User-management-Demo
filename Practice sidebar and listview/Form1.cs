namespace Practice_sidebar_and_listview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void load_form(object? sender)
        {

            if (this.mainpanelv2.Controls.Count > 0)
            {
                this.mainpanelv2.Controls.RemoveAt(0);
            }
            Form fr = sender as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            mainpanelv2.Controls.Add(fr);
            mainpanelv2.Tag = fr;
            fr.Show();


        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool sidebarExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 44)
                {
                    sidebarExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= 181)
                {
                    sidebarExpand = true;
                    menuTransition.Stop();
                }
            }
        }

        private void sidebarBtn_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void AddNewUserBtn_Click(object sender, EventArgs e)
        {
            load_form(new AddUserForm());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void FindUserBtn_Click(object sender, EventArgs e)
        {
            load_form(new FinduserForm());
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
        }
    }
}