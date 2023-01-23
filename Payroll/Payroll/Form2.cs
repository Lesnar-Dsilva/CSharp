using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Boolean login = false;

        private void txtE_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void txtPayroll_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void txtUsers_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
        private void txtLogin_Click_1(object sender, EventArgs e)
        {
            if(txtLogin.Text == "Login") {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }
            // The difference Show and ShowDialog is that Show just display the form while allowing the user to interact the other window, while ShowDialog doesn't allow the user to interact the other window, until a result is returned.
            if (login)
            {
                txtUsers.Enabled = true;
                txtPayroll.Enabled = true;
                txtE.Enabled = true;
                txtLogin.Text = "Logout";
            }
            txtLogin.Click += TxtLogin_Click;

        }

        private void TxtLogin_Click(object? sender, EventArgs e)
        {
            txtUsers.Enabled = false;
            txtPayroll.Enabled = false;
            txtE.Enabled = false;
            txtLogin.Text = "Login";
        }
    }
}
