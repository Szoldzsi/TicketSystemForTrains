using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketSystemForTrains
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void infóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Az alkalmazás készítője:\nKatona Bence(OX5THR)");
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usrname = textBox1.Text;
            string pwd = textBox2.Text;
            if (usrname == "vasarlo" && pwd == "vasarlo1")
            {
                userForm usrForm = new userForm();
                usrForm.Show();
                this.Close();

            }
            else if (usrname == "admin" && pwd == "admin1")
            {

            }
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}
