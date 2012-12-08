using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormEggrafiAimodoti : Form
    {
        public FormEggrafiAimodoti()
        {
            InitializeComponent();
        }

        private void FormEggrafiAimodoti_Load(object sender, EventArgs e)
        {
            nameTextBox.Focus();
         //  aimodotesTableAdapter.Insert("Θανάσης", "Κυριαζόπουλος", "Φώτιος", "Α", "+", DateTime.Parse("17-09-1989"), "Φοιτητής", "Μουτούδη 13", "1234567890", "0987654321", "Άνδρας", 0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            bool sfalma = false;
            bool hlikiaerror = false;


            if (!FilterSwitcher.Checked) goto jumpChecks;


            string sfalmata = "";
            if (nameTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος "; }
            if (lastNameTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Επίθετου "; }
            if (fatherNameTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Πατρώνυμο"; }
            if (Omada_Aimatos_comboBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ομάδα Αίματος"; }
            if (Rhesus_comboBox1.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Rhesus"; }
            if (fylloComboBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Φύλου"; }
            if (jobTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Επαγγέλματος"; }
            if (addressTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Διεύθυνσης"; }
            if (phoneNumber1TextBox.ForeColor == Color.IndianRed || (phoneNumber1TextBox.Text.Length >= 1 && phoneNumber1TextBox.Text.Length < 10)  ) { sfalma = true; sfalmata += "\n* Eισαγώγή Τηλεφώνου 1"; }
            if (phoneNumber2TextBox.ForeColor == Color.IndianRed || (phoneNumber2TextBox.Text.Length >= 1 && phoneNumber2TextBox.Text.Length < 10)) { sfalma = true; sfalmata += "\n* Eισαγώγή Τηλεφώνου 2"; }
            if (sfalma) MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


           

            if (DateTime.Now.Year - BirthDay_dateTimePicker1.Value.Year < 18)
            {
                hlikiaerror = true;
                MessageBox.Show("Αδύνατη η Εγγραφή ! \n Η Ηλικία του Αιμοδότη είναι μικρότερη του 18", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            jumpChecks:
            if (!sfalma && !hlikiaerror)
            {
                try
                {
                    aimodotesTableAdapter.Insert(nameTextBox.Text, lastNameTextBox.Text, fatherNameTextBox.Text, Omada_Aimatos_comboBox.Text, Rhesus_comboBox1.Text, BirthDay_dateTimePicker1.Value.Date, jobTextBox.Text, addressTextBox.Text, phoneNumber1TextBox.Text, phoneNumber2TextBox.Text, fylloComboBox.Text,0);
                    MessageBox.Show("Έγινε η εγγραφή του Αιμοδότη " + nameTextBox.Text + " " + lastNameTextBox.Text, "", MessageBoxButtons.OK);
                    nameTextBox.Focus();
                    Clear_Save_Textboxes();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed", "", MessageBoxButtons.OK);
                }
            }

        }

        private void Clear_Save_Textboxes()
        {
            nameTextBox.Clear(); 
            lastNameTextBox.Clear();
            fatherNameTextBox.Clear();
            jobTextBox.Clear(); 
            addressTextBox.Clear();
            phoneNumber1TextBox.Clear();
            phoneNumber2TextBox.Clear();
            Rhesus_comboBox1.Text = "";
            Omada_Aimatos_comboBox.Text = "";
            fylloComboBox.Text = "";
            BirthDay_dateTimePicker1.Value = DateTime.Today;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void πλήρηςΠροβολήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFull_aimodotes_view FullaimodotesViewForm = new FormFull_aimodotes_view();
            FullaimodotesViewForm.ShowDialog();
        }

        private void fylloComboBox_Leave(object sender, EventArgs e)
        {
            if (fylloComboBox.Text != "Γυναίκα" && fylloComboBox.Text != "Άνδρας")
            {
                fylloComboBox.Text = "";
                
            }
        }

        private void Omada_Aimatos_comboBox_Leave(object sender, EventArgs e)
        {
            if (Omada_Aimatos_comboBox.Text != "Α" && Omada_Aimatos_comboBox.Text != "Β" && Omada_Aimatos_comboBox.Text != "ΑΒ" && Omada_Aimatos_comboBox.Text != "Ο")
            {
                Omada_Aimatos_comboBox.Text = "";

            }
        }

        private void Rhesus_comboBox1_Leave(object sender, EventArgs e)
        {
            if (Rhesus_comboBox1.Text != "+" && Rhesus_comboBox1.Text != "-")
            {
                Rhesus_comboBox1.Text = "";

            }
        }

        private void phoneNumber1TextBox_TextChanged(object sender, EventArgs e)
        {
            if (phoneNumber1TextBox.Text.Length != 0)
            {
                Int64 number;
                bool itsok = Int64.TryParse(phoneNumber1TextBox.Text, out number);
                if (!itsok)
                {
                    phoneNumber1TextBox.ForeColor = Color.IndianRed;
                    TelError1.Visible = true;
                }
                else
                {
                    if (phoneNumber1TextBox.Text.Length <= 10)
                    {
                        phoneNumber1TextBox.ForeColor = Color.Black;
                        TelError1.Visible = false;
                    }
                    else
                    {
                        phoneNumber1TextBox.ForeColor = Color.IndianRed;
                        TelError1.Visible = true;
                    }
                }
            }
            else
            {
                phoneNumber1TextBox.ForeColor = Color.Black;
                TelError1.Visible = false;
            }
        }

        private void phoneNumber2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (phoneNumber2TextBox.Text.Length != 0)
            {
                Int64 number;
                bool itsok = Int64.TryParse(phoneNumber2TextBox.Text, out number);
                if (!itsok)
                {
                    phoneNumber2TextBox.ForeColor = Color.IndianRed;
                    TelError2.Visible = true;
                }
                else
                {
                    if (phoneNumber2TextBox.Text.Length <= 10)
                    {
                        phoneNumber2TextBox.ForeColor = Color.Black;
                        TelError2.Visible = false;
                    }
                    else
                    {
                        phoneNumber2TextBox.ForeColor = Color.IndianRed;
                        TelError2.Visible = true;
                    }
                }
            }
            else
            {
                phoneNumber2TextBox.ForeColor = Color.Black;
                TelError2.Visible = false;
            }
        }

        private void phoneNumber1TextBox_Leave(object sender, EventArgs e)
        {
            if (!(phoneNumber1TextBox.Text.Length == 10 || phoneNumber1TextBox.Text.Length == 0))
            {
                phoneNumber1TextBox.ForeColor = Color.IndianRed;
                TelError1.Visible = true;
            }
        }

        private void phoneNumber2TextBox_Leave(object sender, EventArgs e)
        {
            if (!(phoneNumber2TextBox.Text.Length == 10 || phoneNumber2TextBox.Text.Length == 0))
            {
                phoneNumber2TextBox.ForeColor = Color.IndianRed;
                TelError2.Visible = true;
            }
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
