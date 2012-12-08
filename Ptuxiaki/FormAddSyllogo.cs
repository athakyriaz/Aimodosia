using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormAddSyllogo : Form
    {
        public FormAddSyllogo()
        {
            InitializeComponent();
        }

        private void FormAddSyllogo_Load(object sender, EventArgs e)
        {
            onoma_SyllogouTextBox.Focus();
        }
        void clear_text_boxes()
        {
            onoma_ProedrouTextBox.Clear();
            onoma_SyllogouTextBox.Clear();
            eponumo_ProedrouTextBox.Clear();
            date_IdrisisDateTimePicker.Value = DateTime.Today;


        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool sfalma = false;
            string sfalmata = "";
            if (onoma_SyllogouTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος Συλλόγου "; }
            if (onoma_ProedrouTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος Προέδρου "; }
            if (eponumo_ProedrouTextBox.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Επώνυμου Προέδρου "; }
            if (sfalma) MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!sfalma)
            {
                try
                {
                    syllogoiTableAdapter.Insert(onoma_SyllogouTextBox.Text, onoma_ProedrouTextBox.Text, eponumo_ProedrouTextBox.Text, 0, date_IdrisisDateTimePicker.Value);
                    MessageBox.Show("Έγινε η εγγραφή του Συλλόγου " + onoma_SyllogouTextBox.Text + " με πρόεδρο τον " + eponumo_ProedrouTextBox.Text, "", MessageBoxButtons.OK);
                    clear_text_boxes();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed", "", MessageBoxButtons.OK);
                }
            }
        }

        private void FullViewSullogoi_Click_1(object sender, EventArgs e)
        {
            FullSyllogoiView syllogoiview = new FullSyllogoiView();
            syllogoiview.ShowDialog();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
