using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormXrewshFuallis : Form
    {
        public FormXrewshFuallis()
        {
            InitializeComponent();
        }
        private void FormXrewshFuallis_Load(object sender, EventArgs e)
        {
                        
            this.radioButtonEthelontika.TabStop = false;
            this.radioButtonSyllogo.TabStop = false;
            pictureBoxAddAimodoti.Visible = labelAimodotis.Visible = LabelDefaultAimodotis.Visible = TextBoxSearchAimodoti.Visible = pictureBoxSearchAimodoti.Visible = false;
            pictureBoxAddSyllogo.Visible = labelSyllogos.Visible = labelDefaultSyllogos.Visible = textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = false;
            labelFialesDiathNum.Visible = labelFialesText.Visible = FialesXrewshText.Visible = textBoxNumFialesXrewsh.Visible = false;
            LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = false;
        }

        private void pictureBoxAddAimodoti_Click(object sender, EventArgs e)
        {
            TextBoxSearchAimodoti.Location = new Point(LabelDefaultAimodotis.Location.X + LabelDefaultAimodotis.Width + 3, TextBoxSearchAimodoti.Location.Y);
            pictureBoxSearchAimodoti.Location = new Point(TextBoxSearchAimodoti.Location.X + TextBoxSearchAimodoti.Width + 3, pictureBoxSearchAimodoti.Location.Y);
            TextBoxSearchAimodoti.Clear();
            TextBoxSearchAimodoti.Visible = pictureBoxSearchAimodoti.Visible = true;
            TextBoxSearchAimodoti.Focus(); 
        }

      


        public DataRow AimodotisAnazitisis;
        public string stoixeio;

        private void SearchAimodoti()
        {
            if (TextBoxSearchAimodoti.Text != "")
            {
                AimodotisAnazitisis = null;
                this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Aimodotes);
                DataRow[] grammes;
                int count_results = 0;
                int idAimodoti;
                bool idgiven = int.TryParse(TextBoxSearchAimodoti.Text, out idAimodoti);
                if (idgiven)
                {
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Aimodotes"].Select("ID='" + TextBoxSearchAimodoti.Text + "'");
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
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Aimodotes"].Select("Name LIKE '" + TextBoxSearchAimodoti.Text + "' or LastName LIKE '" + TextBoxSearchAimodoti.Text + "'");
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


        private void radioButtonEthelontika_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEthelontika.Checked)
            {
                pictureBoxAddSyllogo.Visible = labelSyllogos.Visible = labelDefaultSyllogos.Visible = textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = false;
                pictureBoxAddAimodoti.Visible = LabelDefaultAimodotis.Visible = labelAimodotis.Visible = true;
            }
        }

        private void radioButtonSyllogo_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAddAimodoti.Visible = labelAimodotis.Visible = LabelDefaultAimodotis.Visible = TextBoxSearchAimodoti.Visible = pictureBoxSearchAimodoti.Visible = false;
            pictureBoxAddSyllogo.Visible = labelDefaultSyllogos.Visible = labelSyllogos.Visible = true;
        }

        private void TextBoxSearchAimodoti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchAimodoti();
                if (AimodotisAnazitisis != null)
                {
                    LabelDefaultAimodotis.Text = AimodotisAnazitisis[0].ToString() + " " + AimodotisAnazitisis[1].ToString();
                    labelFialesDiathNum.Visible = labelFialesText.Visible = FialesXrewshText.Visible = textBoxNumFialesXrewsh.Visible = true;
                    labelFialesDiathNum.Text = AimodotisAnazitisis[12].ToString();
                    LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = true;

                }
                pictureBoxSearchAimodoti.Visible = TextBoxSearchAimodoti.Visible = false;
            }
        }

        

        private void pictureBoxSearchAimodoti_Click(object sender, EventArgs e)
        {
            SearchAimodoti();
            if (AimodotisAnazitisis != null)
            {
                LabelDefaultAimodotis.Text = AimodotisAnazitisis[0].ToString() + " " + AimodotisAnazitisis[1].ToString();
                labelFialesDiathNum.Visible = labelFialesText.Visible = FialesXrewshText.Visible = textBoxNumFialesXrewsh.Visible = true;
                labelFialesDiathNum.Text = AimodotisAnazitisis[12].ToString();
                LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = true ;
            }
            pictureBoxSearchAimodoti.Visible = TextBoxSearchAimodoti.Visible = false;
        }

        private void pictureBoxSearchSyllogo_Click(object sender, EventArgs e)
        {
            SearchSyllogo();
            if (SyllogosAnazitisis != null)
            {
                labelFialesDiathNum.Visible = labelFialesText.Visible = FialesXrewshText.Visible = textBoxNumFialesXrewsh.Visible = true;
                labelFialesDiathNum.Text = SyllogosAnazitisis[4].ToString();
                labelDefaultSyllogos.Text = SyllogosAnazitisis[1].ToString();
                LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = true;
            }
            pictureBoxSearchSyllogo.Visible = textBoxSearchSyllogo.Visible = false;
        }

        private void textBoxSearchSyllogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchSyllogo();
                if (SyllogosAnazitisis != null)
                {
                    labelFialesDiathNum.Visible = labelFialesText.Visible = FialesXrewshText.Visible = textBoxNumFialesXrewsh.Visible = true;
                    labelFialesDiathNum.Text = SyllogosAnazitisis[4].ToString();
                    labelDefaultSyllogos.Text = SyllogosAnazitisis[1].ToString();
                    LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = true;
                }
                pictureBoxSearchSyllogo.Visible = textBoxSearchSyllogo.Visible = false;
            }
        }

        public DataRow SyllogosAnazitisis;
        private void SearchSyllogo()
        {
            if (textBoxSearchSyllogo.Text != "")
            {
                SyllogosAnazitisis = null;
                this.syllogoiTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Syllogoi);
                DataRow[] grammes;
                int count_results = 0;
                int idSyllogou;
                bool idgiven = int.TryParse(textBoxSearchSyllogo.Text, out idSyllogou);
                if (idgiven)
                {
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Syllogoi"].Select("ID_Syllogou='" + textBoxSearchSyllogo.Text + "'");
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
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Syllogoi"].Select("Onoma_Syllogou LIKE '" + textBoxSearchSyllogo.Text + "' or Eponumo_Proedrou LIKE '" + textBoxSearchSyllogo.Text + "'");
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
             

        private void pictureBoxAddSyllogo_Click(object sender, EventArgs e)
        {
            textBoxSearchSyllogo.Location = new Point(labelDefaultSyllogos.Location.X + labelDefaultSyllogos.Width + 3, textBoxSearchSyllogo.Location.Y);
            pictureBoxSearchSyllogo.Location = new Point(textBoxSearchSyllogo.Location.X + textBoxSearchSyllogo.Width + 3, pictureBoxSearchSyllogo.Location.Y);
            textBoxSearchSyllogo.Clear();
            textBoxSearchSyllogo.Visible = pictureBoxSearchSyllogo.Visible = true;
            textBoxSearchSyllogo.Focus(); 
        }

        private void btnXrewsiFialis_Click(object sender, EventArgs e)
        {
            try
            {
                bool sfalma = false;
                if (AimodotisAnazitisis != null || SyllogosAnazitisis != null)
                {
                    if (int.Parse(textBoxNumFialesXrewsh.Text) > 0)
                    {
                        if (radioButtonEthelontika.Checked)
                        {
                            PtuxiakiDatabaseDataSet1.AimodotesRow aimodotis = ptuxiakiDatabaseDataSet11.Aimodotes.FindByID(long.Parse(AimodotisAnazitisis[2].ToString()));
                            if ((aimodotis.NumFiales - int.Parse(textBoxNumFialesXrewsh.Text)) < 0)
                            {
                                MessageBox.Show("Δεν υπάρχουν " + textBoxNumFialesXrewsh.Text.ToString() + " διαθέσιμες Φιάλες στον αιμοδότη: " + aimodotis.LastName + " " + aimodotis.Name + " για χρέωση!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sfalma = true;
                            }
                            if ((aimodotis.NumFiales - int.Parse(textBoxNumFialesXrewsh.Text)) >= 0)
                            {
                                aimodotis.NumFiales -= int.Parse(textBoxNumFialesXrewsh.Text);
                                aimodotesTableAdapter1.Update(aimodotis);
                                MessageBox.Show("Ο Αιμοδότης  " + aimodotis.LastName + " " + aimodotis.Name + " χρεώθηκε " + textBoxNumFialesXrewsh.Text.ToString() + " Φιάλες !!", "", MessageBoxButtons.OK);
                                labelFialesDiathNum.Text = aimodotis.NumFiales.ToString();

                            }

                        }
                        if (radioButtonSyllogo.Checked)
                        {
                            PtuxiakiDatabaseDataSet1.SyllogoiRow syllogos = ptuxiakiDatabaseDataSet11.Syllogoi.FindByID_Syllogou(int.Parse(SyllogosAnazitisis[0].ToString()));
                            if ((syllogos.Num_Fiales - int.Parse(textBoxNumFialesXrewsh.Text)) < 0)
                            {
                                MessageBox.Show("Δεν υπάρχουν " + textBoxNumFialesXrewsh.Text.ToString() + " διαθέσιμες Φιάλες στον σύλλογο: " + syllogos.Onoma_Syllogou + "για χρέωση!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                sfalma = true;
                            }
                            if ((syllogos.Num_Fiales - int.Parse(textBoxNumFialesXrewsh.Text)) >= 0)
                            {
                                syllogos.Num_Fiales -= int.Parse(textBoxNumFialesXrewsh.Text);
                                syllogoiTableAdapter1.Update(syllogos);
                                MessageBox.Show("Ο Σύλλογος  " + syllogos.Onoma_Syllogou + " χρεώθηκε " + textBoxNumFialesXrewsh.Text.ToString() + " Φιάλες !!", "", MessageBoxButtons.OK);
                                labelFialesDiathNum.Text = syllogos.Num_Fiales.ToString();

                            }
                        }
                        if (!sfalma)
                        {
                            if (SyllogosAnazitisis != null)
                            {
                                xrewshTableAdapter1.Insert(null, int.Parse(SyllogosAnazitisis[0].ToString()), textBoxAstheniName.Text, textBoxAstheniLastName.Text, DateTime.Today, textBoxNosokomeioAstheni.Text, int.Parse(textBoxNumFialesXrewsh.Text.ToString()));
                            }
                            else
                            {
                                xrewshTableAdapter1.Insert(long.Parse(AimodotisAnazitisis[2].ToString()), null, textBoxAstheniName.Text, textBoxAstheniLastName.Text, DateTime.Today, textBoxNosokomeioAstheni.Text, int.Parse(textBoxNumFialesXrewsh.Text.ToString()));
                            }
                        }

                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show("Δώστε ορθό Αριθμό για χρέωση", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (radioButtonEthelontika.Checked && AimodotisAnazitisis == null)
                    {
                        MessageBox.Show("Κάντε εύρεση του Αιμοόδτη πρώτα !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (radioButtonSyllogo.Checked && SyllogosAnazitisis == null)
                    {
                        MessageBox.Show("Κάντε εύρεση του Συλλόγου πρώτα !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η εγγραφή απέτυχε", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullViewAimodotes_Click(object sender, EventArgs e)
        {
            FormFull_aimodotes_view viewAllAimodotes = new FormFull_aimodotes_view();
            viewAllAimodotes.Show();
        }

        private void ClearAll()
        {
            textBoxAstheniLastName.Clear();
            textBoxAstheniName.Clear();
            textBoxNosokomeioAstheni.Clear();
            LabelAstheniLastName.Visible = LabelAstheniName.Visible = LabelAstheniNosokomeio.Visible = textBoxAstheniLastName.Visible = textBoxAstheniName.Visible = textBoxNosokomeioAstheni.Visible = false;
            AimodotisAnazitisis = null;
            SyllogosAnazitisis = null;
            LabelDefaultAimodotis.Text = " - - - ";
            labelDefaultSyllogos.Text = " - - - ";
            textBoxNumFialesXrewsh.Text = "0";

        }

        private void FullViewSullogos_Click(object sender, EventArgs e)
        {
            FullSyllogoiView ViewSyllogoi = new FullSyllogoiView();
            ViewSyllogoi.Show();
        }

        private void ViewXrewseis_Click(object sender, EventArgs e)
        {
            FormFullViewXrewseis ViewXrewseis = new FormFullViewXrewseis();
            ViewXrewseis.Show();
        }

        
        
    }
}
