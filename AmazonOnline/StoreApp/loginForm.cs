using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Membership;

namespace StoreApp
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void onLogin(object sender, EventArgs e)
        {

            string userName = this.textBox1.Text;
            string password = this.textBox2.Text;
            bool status = false;
            status = AccountManager.Login(userName, password);
            if (status)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User , Please try again");

            }

        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
