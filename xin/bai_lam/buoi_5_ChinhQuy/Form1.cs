using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChinhQuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                txtName.Focus();
                errorProvider1.SetError(txtName, "Name can not be empty");

            }
            //else if (Regex.IsMatch(txtAge.Text, "\\d{2}"))
            //{
            //    txtAge.Focus();
            //    errorProvider1.SetError(txtAge, "Age must be 2 digits.");
            //}
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }

        }

        private void checkAge(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Age can not be empty");

            }
            else 
            if (!Regex.IsMatch(txtAge.Text, @"\d{2}" ))
            {
                txtAge.Focus();
                errorProvider1.SetError(txtAge, "Age must be 2 digits.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAge, "");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
