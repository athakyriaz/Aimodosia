using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormUpdateAimodoti : Form
    {
        public FormUpdateAimodoti()
        {
            InitializeComponent();
        }



        private void FormUpdateAimodoti_Load(object sender, EventArgs e)
        {
            txtBoxSearchAimodoti.Focus();
            textboxes_enable(false);
        }

        public static DataRow AimodotisAnazitisis;
        public static string stoixeio;
        private void dothesearch()
        {
            if (txtBoxSearchAimodoti.Text != "")
            {
                AimodotisAnazitisis = null;
                this.aimodotesTableAdapter.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
                DataRow[] grammes;
                int count_results;
                int idAimodoti;
                bool is_int = int.TryParse(txtBoxSearchAimodoti.Text,out idAimodoti);
                if (is_int)
                {
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("ID = '" + txtBoxSearchAimodoti.Text + "'");
                }
                else
                {
                    txtBoxSearchAimodoti.Text = txtBoxSearchAimodoti.Text.Replace('*', '%');
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("Name LIKE '" + txtBoxSearchAimodoti.Text + "' or LastName LIKE '" + txtBoxSearchAimodoti.Text + "'");
                }
                
                count_results = grammes.Length;
                if(count_results>1)
                {
                    textboxes_enable(true);
                    stoixeio = txtBoxSearchAimodoti.Text;
                    FormEpilogiAimodoti_Edit AimodotiEpilogi_Show_A = new FormEpilogiAimodoti_Edit();
                    AimodotiEpilogi_Show_A.stoixeio = stoixeio;
                    if (AimodotiEpilogi_Show_A.ShowDialog() == DialogResult.OK)
                    {
                        AimodotisAnazitisis = AimodotiEpilogi_Show_A.AimodotisAnazitishs;
                        txtBoxName.Text = AimodotisAnazitisis[0].ToString();
                        txtBoxLastName.Text = AimodotisAnazitisis[1].ToString();
                        txtBoxFatherName.Text = AimodotisAnazitisis[3].ToString();
                        Omada_AimatosCombobox.Text = AimodotisAnazitisis[4].ToString();
                        rhesus_Combobox.Text = AimodotisAnazitisis[5].ToString();
                        birthYearDateTimePicker.Value = DateTime.Parse(AimodotisAnazitisis[6].ToString());
                        txtBoxJob.Text = AimodotisAnazitisis[7].ToString();
                        txtBoxAddress.Text = AimodotisAnazitisis[8].ToString();
                        txtBoxPhone1.Text = AimodotisAnazitisis[9].ToString();
                        txtBoxPhone2.Text = AimodotisAnazitisis[10].ToString();
                        Fylo_combobox.Text = AimodotisAnazitisis[11].ToString();
                        labelIdAimodoti.Text = AimodotisAnazitisis[2].ToString();
                    }
                }
                if (count_results == 1)
                {
                    textboxes_enable(true);
                    AimodotisAnazitisis = grammes[0];
                    txtBoxName.Text = AimodotisAnazitisis[0].ToString();
                    txtBoxLastName.Text = AimodotisAnazitisis[1].ToString();
                    txtBoxFatherName.Text = AimodotisAnazitisis[3].ToString();
                    Omada_AimatosCombobox.Text = AimodotisAnazitisis[4].ToString();
                    rhesus_Combobox.Text = AimodotisAnazitisis[5].ToString();
                    birthYearDateTimePicker.Value = DateTime.Parse(AimodotisAnazitisis[6].ToString());
                    txtBoxJob.Text = AimodotisAnazitisis[7].ToString();
                    txtBoxAddress.Text = AimodotisAnazitisis[8].ToString();
                    txtBoxPhone1.Text = AimodotisAnazitisis[9].ToString();
                    txtBoxPhone2.Text = AimodotisAnazitisis[10].ToString();
                    Fylo_combobox.Text = AimodotisAnazitisis[11].ToString();
                    labelIdAimodoti.Text = AimodotisAnazitisis[2].ToString();
                }
                if (count_results == 0)
                {
                    MessageBox.Show("Δεν βρέθηκε η εγγραφή!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBoxSearchAimodoti.Focus();
                    txtBoxSearchAimodoti.SelectAll();
                }
            }
        }

        private void btnSearchAimodoti_Click(object sender, EventArgs e)
        {
            dothesearch();   
        }

        private void πλήρηςΠροβολήToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFull_aimodotes_view fullviewform = new FormFull_aimodotes_view();
            fullviewform.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteAimodoti_Click(object sender, EventArgs e)
        {
            if (AimodotisAnazitisis != null)
            {
                if (MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγραφεί ο Αιμοδότης ? ?\n\n" +  "Όν/νυμο Αιμοδότη :" + txtBoxName.Text + " " + txtBoxLastName.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PtuxiakiDatabaseDataSet1.AimodotesRow aimodotis = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(int.Parse(labelIdAimodoti.Text));
                    aimodotis.Delete();
                    this.aimodotesTableAdapter.Update(ptuxiakiDatabaseDataSet1.Aimodotes);
                    Clear_TextBoxes();
                    MessageBox.Show("Η διαγραφή του Αιμοδότη έγινε με επιτυχία", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Δεν υπάρχει Αιμοδότης προς διαγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            

            /*if (MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγραφεί η εγγραφή ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            try
            {
                textboxes_enable(false);
                PtuxiakiDatabaseDataSet1.AimodotesRow aimodotis_pros_diagrafh;
                aimodotis_pros_diagrafh = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(long.Parse(AimodotisAnazitisis[2].ToString()));
            
                AimodotisAnazitisis.Delete();
                aimodotesTableAdapter.Update(this.ptuxiakiDatabaseDataSet1.Aimodotes);
                Clear_TextBoxes();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η Διαγραφή δεν έγινε ! ","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }
        private void Clear_TextBoxes()
        {
            txtBoxAddress.Clear();
            birthYearDateTimePicker.Value = DateTime.Today;
            txtBoxFatherName.Clear();
            txtBoxJob.Clear();
            txtBoxLastName.Clear();
            txtBoxName.Clear();
            txtBoxPhone1.Clear();
            txtBoxPhone2.Clear();
            txtBoxSearchAimodoti.Clear();
            AimodotisAnazitisis = null;
            Omada_AimatosCombobox.Text = "";
            rhesus_Combobox.Text = "";
            Fylo_combobox.Text = "";
            labelIdAimodoti.Text = "";

        }

        private void txtBoxSearchAimodoti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearch();
            }
        }
        void textboxes_enable(bool lock_em)
        {
            txtBoxAddress.Enabled = rhesus_Combobox.Enabled = Fylo_combobox.Enabled = birthYearDateTimePicker.Enabled = Omada_AimatosCombobox.Enabled =  txtBoxFatherName.Enabled = txtBoxJob.Enabled = txtBoxLastName.Enabled = txtBoxName.Enabled = txtBoxPhone1.Enabled = txtBoxPhone2.Enabled = lock_em;
        }
        private void btnUpdateAimodoti_Click(object sender, EventArgs e)
        {
            if (AimodotisAnazitisis != null)
            {
                AimodotisAnazitisis[0] = txtBoxName.Text;
                AimodotisAnazitisis[1] = txtBoxLastName.Text;
                AimodotisAnazitisis[3] = txtBoxFatherName.Text;
                AimodotisAnazitisis[4] = Omada_AimatosCombobox.Text;
                AimodotisAnazitisis[5] = rhesus_Combobox.Text;
                AimodotisAnazitisis[6] = birthYearDateTimePicker.Value.Date;
                AimodotisAnazitisis[7] = txtBoxJob.Text;
                AimodotisAnazitisis[8] = txtBoxAddress.Text;
                AimodotisAnazitisis[9] = txtBoxPhone1.Text;
                AimodotisAnazitisis[10] = txtBoxPhone2.Text;
                AimodotisAnazitisis[11] = Fylo_combobox.Text;
            }
            try
            {
                aimodotesTableAdapter.Update(AimodotisAnazitisis);
                MessageBox.Show("Αιμοδότης Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                aimodotesTableAdapter.Update(this.ptuxiakiDatabaseDataSet1.Aimodotes);
                this.aimodotesTableAdapter.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            }
            catch (Exception ex) { }
        }
    }
}
