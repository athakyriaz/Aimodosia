using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormNewXorigisi : Form
    {
        public FormNewXorigisi()
        {
            InitializeComponent();
        }

        private void xorigiseisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xorigiseisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet11);

        }

        private void FormNewXorigisi_Load(object sender, EventArgs e)
        {
            textBoxKwdikosFialis.Focus();
            textBoxSymbatotita.ReadOnly = true;
        }

        private void btnXorigisiFialis_Click(object sender, EventArgs e)
        {
            bool sfalma = false;
            string sfalmata = "";
            if (textBoxKwdikosFialis.Text == "")  { sfalma = true; sfalmata += "\n* Eισαγώγή Κωδικού Φιάλης "; }
            if (textBoxKliniki.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Κλινικής Ασθενή"; }
            if (textBoxFNameAstheni.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονομάτος Ασθενή "; }
            if (textBoxLNameAstheni.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Επώνυμου Ασθενή "; }
            if (textBoxFNameDoctor.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος Ιατρού "; }
            if (textBoxLNameDoctor.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Επώνυμου Ιατρού "; }
            if (sfalma) MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (!sfalma)
            {
                try
                {
                    xorigiseisTableAdapter.Insert(long.Parse(textBoxKwdikosFialis.Text), textBoxKliniki.Text, textBoxFNameAstheni.Text, textBoxLNameAstheni.Text, textBoxSymbatotita.Text, textBoxFNameDoctor.Text, textBoxLNameDoctor.Text, dateXorigisis.Value);
                    MessageBox.Show("Έγινε η εγγραφή της Χορήγησης για τον Ασθενή " + textBoxLNameAstheni.Text + " από τον Ιατρό " + textBoxLNameDoctor.Text, "", MessageBoxButtons.OK);
                    textBoxKwdikosFialis.Focus();
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
            textBoxKwdikosFialis.Clear();
            textBoxKliniki.Clear();
            textBoxFNameAstheni.Clear();
            textBoxLNameAstheni.Clear();
            textBoxFNameDoctor.Clear();
            textBoxLNameDoctor.Clear();
            dateXorigisis.Value = DateTime.Today;

        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseMenuStrip_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewXorigiseisFull_Click(object sender, EventArgs e)
        {
            FormXorigiseisFullView XorigiseisView = new FormXorigiseisFullView();
            XorigiseisView.Show();
        }

        private void ViewFialesFUll_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView FullViewFiales = new FormAimodosiaFullView();
            FullViewFiales.Show();
        }


    }
}
