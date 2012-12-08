using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void btnEnter_password_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                bool username_accept, password_accept; username_accept = password_accept = false;
                if (textBoxUsername.Text == "aimodosia" || textBoxUsername.Text == "admin")
                {
                    username_accept = true;
                }
                if (textBoxPassword.Text == "giannitsa" || textBoxPassword.Text == "admin")
                {
                    password_accept = true;
                }
                if (username_accept && password_accept)
                    this.DialogResult = DialogResult.OK;
                else
                {
                    MessageBox.Show("Λαθος usernamer ή password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
            textBoxUsername.Focus();
            textBoxPassword.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
                {
                    bool username_accept, password_accept; username_accept = password_accept = false;
                    if (textBoxUsername.Text == "aimodosia" || textBoxUsername.Text == "admin")
                    {
                        username_accept = true;
                    }
                    if (textBoxPassword.Text == "giannitsa" || textBoxPassword.Text == "admin")
                    {
                        password_accept = true;
                    }
                    if (username_accept && password_accept)
                        this.DialogResult = DialogResult.OK;
                    else
                    {
                        MessageBox.Show("Λαθος usernamer ή password...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.SelectAll();
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.SelectAll();
        }
    }
}
