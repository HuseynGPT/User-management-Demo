using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_sidebar_and_listview
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        static public void disableForm()
        {

        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUserGoBackBtn_Click(object sender, EventArgs e)
        {

        }

        private void SaveUserBtn_Click(object sender, EventArgs e)
        {
            string[] newUserDatas = { this.IDTxtBox.Text, this.nameTxtBox.Text, this.surnameTxtBox.Text, ageTxtBox.Text };
            ListViewItem listViewItem = new(newUserDatas);
            listView1.Items.Add(listViewItem);



        }


    }
}
