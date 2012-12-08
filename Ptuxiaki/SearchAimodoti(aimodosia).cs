using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class SearchAimodoti_aimodosia_ : Form
    {
        public SearchAimodoti_aimodosia_()
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
                bool is_int = int.TryParse(txtBoxSearchAimodoti.Text, out idAimodoti);
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
                if (count_results > 1)
                {
                    textboxes_enable(true);
                    stoixeio = txtBoxSearchAimodoti.Text;
                    FormEpilogiAimodoti_Edit AimodotiEpilogi_Show_A = new FormEpilogiAimodoti_Edit();
                    if (AimodotiEpilogi_Show_A.ShowDialog() == DialogResult.OK)
                    {
                        AimodotisAnazitisis = grammes[0];
                        txtBoxName.Text = AimodotisAnazitisis[0].ToString();
                        txtBoxLastName.Text = AimodotisAnazitisis[1].ToString();
                        txtBoxFatherName.Text = AimodotisAnazitisis[3].ToString();
                        txtBoxOmadaAimatos.Text = AimodotisAnazitisis[4].ToString();
                        txtBoxRhesus.Text = AimodotisAnazitisis[5].ToString();
                        txtBoxBirthYear.Text = AimodotisAnazitisis[6].ToString();
                        txtBoxJob.Text = AimodotisAnazitisis[7].ToString();
                        txtBoxAddress.Text = AimodotisAnazitisis[8].ToString();
                        txtBoxPhone1.Text = AimodotisAnazitisis[9].ToString();
                        txtBoxPhone2.Text = AimodotisAnazitisis[10].ToString();
                    }
                }
                if (count_results == 1)
                {
                    textboxes_enable(true);
                    AimodotisAnazitisis = grammes[0];
                    txtBoxName.Text = AimodotisAnazitisis[0].ToString();
                    txtBoxLastName.Text = AimodotisAnazitisis[1].ToString();
                    txtBoxFatherName.Text = AimodotisAnazitisis[3].ToString();
                    txtBoxOmadaAimatos.Text = AimodotisAnazitisis[4].ToString();
                    txtBoxRhesus.Text = AimodotisAnazitisis[5].ToString();
                    txtBoxBirthYear.Text = AimodotisAnazitisis[6].ToString();
                    txtBoxJob.Text = AimodotisAnazitisis[7].ToString();
                    txtBoxAddress.Text = AimodotisAnazitisis[8].ToString();
                    txtBoxPhone1.Text = AimodotisAnazitisis[9].ToString();
                    txtBoxPhone2.Text = AimodotisAnazitisis[10].ToString();
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
            if (MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγραφεί η εγγραφή ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    MessageBox.Show("Η Διαγραφή δεν έγινε ! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        private void Clear_TextBoxes()
        {
            txtBoxAddress.Clear();
            txtBoxBirthYear.Clear();
            txtBoxFatherName.Clear();
            txtBoxJob.Clear();
            txtBoxLastName.Clear();
            txtBoxName.Clear();
            txtBoxOmadaAimatos.Clear();
            txtBoxPhone1.Clear();
            txtBoxPhone2.Clear();
            txtBoxRhesus.Clear();
            txtBoxSearchAimodoti.Clear();
            AimodotisAnazitisis = null;
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
            txtBoxAddress.Enabled = txtBoxBirthYear.Enabled = txtBoxFatherName.Enabled = txtBoxJob.Enabled = txtBoxLastName.Enabled = txtBoxName.Enabled = txtBoxOmadaAimatos.Enabled = txtBoxPhone1.Enabled = txtBoxPhone2.Enabled = txtBoxRhesus.Enabled = lock_em;
        }
        private void btnUpdateAimodoti_Click(object sender, EventArgs e)
        {
            if (AimodotisAnazitisis != null)
            {
                AimodotisAnazitisis[0] = txtBoxName.Text;
                AimodotisAnazitisis[1] = txtBoxLastName.Text;
                AimodotisAnazitisis[3] = txtBoxFatherName.Text;
                AimodotisAnazitisis[4] = txtBoxOmadaAimatos.Text;
                AimodotisAnazitisis[5] = txtBoxRhesus.Text;
                AimodotisAnazitisis[6] = txtBoxBirthYear.Text;
                AimodotisAnazitisis[7] = txtBoxJob.Text;
                AimodotisAnazitisis[8] = txtBoxAddress.Text;
                AimodotisAnazitisis[9] = txtBoxPhone1.Text;
                AimodotisAnazitisis[10] = txtBoxPhone2.Text;
            }
            try
            {
                aimodotesTableAdapter.Update(AimodotisAnazitisis);
                MessageBox.Show("Αιμοδότης Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) { }
        }
    }
}
