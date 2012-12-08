using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormAddAimodosia : Form
    {
        public FormAddAimodosia()
        {
            InitializeComponent();
        }

        private void fialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FormAddAimodosia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Fiales' table. You can move, or remove it, as needed.
            //this.fialesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Fiales);
            TextBoxSearchAimodoti.Visible = pictureBoxSearchAimodoti.Visible = false;
            textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = false;
        }

        private void pictureBoxAddAimodoti_Click(object sender, EventArgs e)
        {
            TextBoxSearchAimodoti.Location = new Point(LabelAimodoti.Location.X + LabelAimodoti.Width + 3, TextBoxSearchAimodoti.Location.Y);
            pictureBoxSearchAimodoti.Location = new Point(TextBoxSearchAimodoti.Location.X +TextBoxSearchAimodoti.Width + 3, pictureBoxSearchAimodoti.Location.Y);
            TextBoxSearchAimodoti.Clear();
            TextBoxSearchAimodoti.Visible = pictureBoxSearchAimodoti.Visible = true;
            TextBoxSearchAimodoti.Focus(); 
        }


        private void pictureBoxSearchAimodoti_Click(object sender, EventArgs e)
        {
            SearchAimodoti();
            if (AimodotisAnazitisis != null)
            {
                LabelAimodoti.Text = AimodotisAnazitisis[0].ToString()+" "+AimodotisAnazitisis[1].ToString();

            }
            pictureBoxSearchAimodoti.Visible = TextBoxSearchAimodoti.Visible = false;
        }

        public DataRow AimodotisAnazitisis;
        public string stoixeio;

        private void SearchAimodoti()
        {
            if (TextBoxSearchAimodoti.Text != "")
            {
                AimodotisAnazitisis = null;
                this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
                DataRow[] grammes;
                int count_results = 0;
                int idAimodoti;
                bool idgiven = int.TryParse(TextBoxSearchAimodoti.Text, out idAimodoti);
                if (idgiven)
                {
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("ID='" + TextBoxSearchAimodoti.Text + "'");
                    count_results = grammes.Length;
                    if (count_results != 0)
                    {
                        AimodotisAnazitisis = grammes[0];
                    }
                    else
                    {
                        MessageBox.Show("Δεν βρέθηκε ο Αιμοδότης!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    TextBoxSearchAimodoti.Text = TextBoxSearchAimodoti.Text.Replace('*', '%');
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("Name LIKE '" + TextBoxSearchAimodoti.Text + "' or LastName LIKE '" + TextBoxSearchAimodoti.Text + "'");
                    count_results = grammes.Length;

                    if (count_results > 1)
                    {
                        stoixeio = TextBoxSearchAimodoti.Text;
                        FormEpilogiAimodoti_Edit epilogiaimodoti = new FormEpilogiAimodoti_Edit();
                        epilogiaimodoti.stoixeio = stoixeio;
                        if (epilogiaimodoti.ShowDialog() == DialogResult.OK)
                        {
                            AimodotisAnazitisis = epilogiaimodoti.AimodotisAnazitishs;
                        }
                    }
                    if (count_results == 1)
                    {
                        AimodotisAnazitisis = grammes[0];
                    }
                    if (count_results == 0)
                    {
                        MessageBox.Show("Δεν βρέθηκε ο Αιμοδότης!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }



            }
        }

        private void TextBoxSearchAimodoti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchAimodoti();
                if (AimodotisAnazitisis != null)
                {
                    LabelAimodoti.Text = AimodotisAnazitisis[0].ToString() + " " + AimodotisAnazitisis[1].ToString();
                }
                pictureBoxSearchAimodoti.Visible = TextBoxSearchAimodoti.Visible = false;
            }
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxAddSyllogo_Click(object sender, EventArgs e)
        {
            textBoxSearchSyllogo.Location = new Point(labelSyllogos.Location.X + labelSyllogos.Width + 3, textBoxSearchSyllogo.Location.Y);
            pictureBoxSearchSyllogo.Location = new Point(textBoxSearchSyllogo.Location.X + textBoxSearchSyllogo.Width + 3, pictureBoxSearchSyllogo.Location.Y);
            textBoxSearchSyllogo.Clear();
            textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = true;
            textBoxSearchSyllogo.Focus(); 
        }


        private void pictureBoxSearchSyllogo_Click(object sender, EventArgs e)
        {
            SearchSyllogo();
            if (SyllogosAnazitisis != null)
            {
                labelSyllogos.Text = SyllogosAnazitisis[1].ToString();
            }
            pictureBoxSearchSyllogo.Visible = textBoxSearchSyllogo.Visible = false;
        }

        public DataRow SyllogosAnazitisis;
        private void SearchSyllogo()
        {
            if (textBoxSearchSyllogo.Text != "")
            {
                SyllogosAnazitisis = null;
                this.syllogoiTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Syllogoi);
                DataRow[] grammes;
                int count_results = 0;
                int idSyllogou;
                bool idgiven = int.TryParse(textBoxSearchSyllogo.Text, out idSyllogou);
                if (idgiven)
                {
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Select("ID_Syllogou='" + textBoxSearchSyllogo.Text + "'");
                    count_results = grammes.Length;
                    if (count_results != 0)
                    {
                        SyllogosAnazitisis = grammes[0];
                    }
                    else
                    {
                        MessageBox.Show("Δεν βρέθηκε ο Σύλλογος!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    textBoxSearchSyllogo.Text = textBoxSearchSyllogo.Text.Replace('*', '%');
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Select("Onoma_Syllogou LIKE '" + textBoxSearchSyllogo.Text + "' or Eponumo_Proedrou LIKE '" + textBoxSearchSyllogo.Text + "'");
                    count_results = grammes.Length;

                    if (count_results > 1)
                    {
                        stoixeio = textBoxSearchSyllogo.Text;
                        FormEpilogiSyllogou epilogisyllogou = new FormEpilogiSyllogou();
                        epilogisyllogou.stoixeio = stoixeio;
                        if (epilogisyllogou.ShowDialog() == DialogResult.OK)
                        {
                            SyllogosAnazitisis = epilogisyllogou.SullogosAnazitisis;
                        }
                    }
                    if (count_results == 1)
                    {
                        SyllogosAnazitisis = grammes[0];
                    }
                    if (count_results == 0)
                    {
                        MessageBox.Show("Δεν βρέθηκε ο Συλλόγος!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }

            }

        }

        private void radioButtonEthelontika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEthelontika.Checked)
            {
                pictureBoxAddSyllogo.Visible = label2.Visible = labelSyllogos.Visible = textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = label1.Visible = textBoxNameAstheni.Visible = label33.Visible = textBoxNosokomeioAstheni.Visible = false;
            }
        }

        private void radioButtonSyllogo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSyllogo.Checked)
            {
                label1.Visible = label33.Visible = textBoxNameAstheni.Visible = textBoxNosokomeioAstheni.Visible = false;
                pictureBoxAddSyllogo.Visible = label2.Visible = labelSyllogos.Visible = true;
            }
        }

        private void radioButtonAstheni_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAstheni.Checked)
            {
                label1.Visible = label33.Visible = textBoxNameAstheni.Visible = textBoxNosokomeioAstheni.Visible = true;
                pictureBoxAddSyllogo.Visible = label2.Visible = labelSyllogos.Visible = textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = false;
            }
        }

        private void textBoxSearchSyllogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchSyllogo();
                if (SyllogosAnazitisis != null)
                {
                    labelSyllogos.Text = SyllogosAnazitisis[1].ToString();
                }
                pictureBoxSearchSyllogo.Visible = textBoxSearchSyllogo.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LabelAimodoti.Text != " - - - ")
            {
                HistoryForm formHistory = new HistoryForm();
                formHistory.IDaimodoti = int.Parse(AimodotisAnazitisis[2].ToString());
                if (radioButtonEthelontika.Checked) formHistory.katigoriaAim = radioButtonEthelontika.Text;
                else if (radioButtonAstheni.Checked) formHistory.katigoriaAim = radioButtonAstheni.Text;
                else formHistory.katigoriaAim = radioButtonSyllogo.Text;
                if (formHistory.ShowDialog() == DialogResult.OK)
                {
                    IDHistory = formHistory.IDHistory;
                }
            }
            else
            {
                MessageBox.Show("Κάντε εύρεση του Αιμοδότη Πρώτα !", "", MessageBoxButtons.OK);
            }
        }

        private void AddHistory_Click(object sender, EventArgs e)
        {
            if (LabelAimodoti.Text != " - - - ")
            {
                HistoryForm formHistory = new HistoryForm();
                formHistory.IDaimodoti = int.Parse(AimodotisAnazitisis[2].ToString());
                if (radioButtonEthelontika.Checked) formHistory.katigoriaAim = radioButtonEthelontika.Text;
                else if (radioButtonAstheni.Checked) formHistory.katigoriaAim = radioButtonAstheni.Text;
                else formHistory.katigoriaAim = radioButtonSyllogo.Text;
                if (formHistory.ShowDialog() == DialogResult.OK)
                {
                    IDHistory = formHistory.IDHistory;
                }
            }
            else
            {
                MessageBox.Show("Κάντε εύρεση του Αιμοδότη Πρώτα !", "", MessageBoxButtons.OK);
            }
        }
        
        private void προβολήΙστορικούToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 HistoryFullView viewhistoryform = new HistoryFullView();
                 viewhistoryform.ShowDialog();
                
        }
        public long IDaimodoti;
        public int IDSyllogou;
        public long IDHistory;
        private void btnSaveAimodosia_Click(object sender, EventArgs e)
        {
            bool sfalma = false;
            string sfalmata = "";
            if (IDHistory != 0)
            {
                if (radioButtonAstheni.Checked)
                {
                    if (textBoxNameAstheni.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος Ασθενή"; }
                    if (textBoxNosokomeioAstheni.Text == "") { sfalma = true; sfalmata += "\n* Eισαγώγή Ονόματος Νοσοκομείου που Νοσηλέυεται ο Ασθενής "; }
                    if (sfalma) MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (radioButtonSyllogo.Checked)
                {
                    if (textBoxSearchSyllogo.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή Συλλόγου"; }
                    if (sfalma) MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Δεν έχει γίνει σωστά η Εισαγωγή του Ιστορικού ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!sfalma)
            {
                try
                {                   
                    if (SyllogosAnazitisis != null)
                    {
                        fialesTableAdapter.Insert(long.Parse(AimodotisAnazitisis[2].ToString()), int.Parse(SyllogosAnazitisis[0].ToString()), textBoxNameAstheni.Text, textBoxNosokomeioAstheni.Text, "Μη Ελεγμένο", IDHistory, dateTimePicker1.Value);
                    }
                    else
                    {
                        fialesTableAdapter.Insert(long.Parse(AimodotisAnazitisis[2].ToString()), null, textBoxNameAstheni.Text, textBoxNosokomeioAstheni.Text, "Μη Ελεγμένο", IDHistory, dateTimePicker1.Value);
                        if (radioButtonAstheni.Checked)
                        {
                            xrewshTableAdapter1.Insert(long.Parse(AimodotisAnazitisis[2].ToString()), null, null, textBoxNameAstheni.Text, DateTime.Today, textBoxNosokomeioAstheni.Text,1);
                        }
                    }
                    if (radioButtonEthelontika.Checked)
                    {
                        PtuxiakiDatabaseDataSet1.AimodotesRow aimodotis = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(long.Parse(AimodotisAnazitisis[2].ToString()));
                        aimodotis.NumFiales += 1;
                        aimodotesTableAdapter1.Update(aimodotis);
                    }
                    if (radioButtonSyllogo.Checked)
                    {
                        PtuxiakiDatabaseDataSet1.SyllogoiRow syllogos = ptuxiakiDatabaseDataSet1.Syllogoi.FindByID_Syllogou(int.Parse(SyllogosAnazitisis[0].ToString()));
                        syllogos.Num_Fiales += 1;
                        syllogoiTableAdapter1.Update(syllogos);
                    }
                    MessageBox.Show("Έγινε η Αιμοδοσία ", "", MessageBoxButtons.OK);
                    ClearAll();

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Η εγγραφή απέτυχε", "", MessageBoxButtons.OK);
                }
            }
        }

        private void FullViewAimodosia_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView AimodosiaView = new FormAimodosiaFullView();
            AimodosiaView.Show();
        }


        private void ClearAll()
        {
            AimodotisAnazitisis = null;
            SyllogosAnazitisis = null;
            textBoxNameAstheni.Clear();
            textBoxNosokomeioAstheni.Clear();
            LabelAimodoti.Text = " - - - ";
            labelSyllogos.Text = " - - - ";


        }

        private void buttonApporipsi_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        

        
    }
}
