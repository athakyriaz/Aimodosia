using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormDiorthwsiSullogou : Form
    {
        public FormDiorthwsiSullogou()
        {
            InitializeComponent();
        }

        private void syllogoiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
       {
           this.Validate();
           this.syllogoiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

       }
        private void clear_labels()
        {
            string a = "                 ";
            onoma_SyllogouLabel1.Text = a;
            onoma_ProedrouLabel1.Text = a;
            eponumo_ProedrouLabel1.Text = a;
            num_FialesLabel1.Text = a;
            date_IdrisisLabel1.Text = a;
            iD_SyllogouLabel1.Text = a;
        }
        private void complete_labels()
        {
            if (onoma_ProedrouLabel1.Text == "") { onoma_ProedrouLabel1.Text = "Άγνωστο"; }
            if (onoma_SyllogouLabel1.Text == "") { onoma_SyllogouLabel1.Text = "Άγνωστο"; }
            if (eponumo_ProedrouLabel1.Text == "") { eponumo_ProedrouLabel1.Text = "Άγνωστο"; }
            if (num_FialesLabel1.Text == "") { num_FialesLabel1.Text = "Άγνωστο"; }
        }

        private void FormDiorthwsiSullogou_Load(object sender, EventArgs e)
        {
            clear_labels();
            txtBoxSearchSyllogo.Focus();
            NewDateIdrusisTxTBox.Visible = false;
        }
        private void btnSearchSyllogo_Click(object sender, EventArgs e)
        {
            dothesearch();
        }

        public static DataRow SullogosAnazitisis;
        public static string stoixeio;
        private void dothesearch()
        {
            if (txtBoxSearchSyllogo.Text != "")
            {
                SullogosAnazitisis = null;
                this.syllogoiTableAdapter.Fill(ptuxiakiDatabaseDataSet1.Syllogoi);
                DataRow[] grammes;
                int count_results;
                int idSullogou;
                bool is_int = int.TryParse(txtBoxSearchSyllogo.Text, out idSullogou);
                if (is_int)
                {
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Select("ID_Syllogou ='" + txtBoxSearchSyllogo.Text + "'");
                }
                else
                {
                    txtBoxSearchSyllogo.Text = txtBoxSearchSyllogo.Text.Replace('*', '%');
                    grammes = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Select("Onoma_Syllogou LIKE '" + txtBoxSearchSyllogo.Text + "' or Eponumo_Proedrou LIKE '" + txtBoxSearchSyllogo.Text + "'");
                }
                count_results = grammes.Length;
                if (count_results > 1)
                {
                    stoixeio = txtBoxSearchSyllogo.Text;
                   FormEpilogiSyllogou SyllogosEpilogi_Show_A = new FormEpilogiSyllogou();
                   SyllogosEpilogi_Show_A.stoixeio = stoixeio;
                    if (SyllogosEpilogi_Show_A.ShowDialog() == DialogResult.OK)
                    {
                        SullogosAnazitisis = SyllogosEpilogi_Show_A.SullogosAnazitisis;
                        iD_SyllogouLabel1.Text = SullogosAnazitisis[0].ToString();
                        onoma_SyllogouLabel1.Text = SullogosAnazitisis[1].ToString();
                        onoma_ProedrouLabel1.Text = SullogosAnazitisis[2].ToString();
                        eponumo_ProedrouLabel1.Text = SullogosAnazitisis[3].ToString();
                        num_FialesLabel1.Text = SullogosAnazitisis[4].ToString();
                        date_IdrisisLabel1.Text = SullogosAnazitisis[5].ToString();
                        
                    }
                    
                }
                if (count_results == 1)
                {
                    SullogosAnazitisis = grammes[0];
                    iD_SyllogouLabel1.Text = SullogosAnazitisis[0].ToString();
                    onoma_SyllogouLabel1.Text = SullogosAnazitisis[1].ToString();
                    onoma_ProedrouLabel1.Text = SullogosAnazitisis[2].ToString();
                    eponumo_ProedrouLabel1.Text = SullogosAnazitisis[3].ToString();
                    num_FialesLabel1.Text = SullogosAnazitisis[4].ToString();
                    date_IdrisisLabel1.Text = SullogosAnazitisis[5].ToString();
                }
                if (count_results == 0)
                {
                    MessageBox.Show("Δεν βρέθηκε η εγγραφή!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     txtBoxSearchSyllogo.Focus();
                     txtBoxSearchSyllogo.SelectAll();
                }
            
            }

        }

        private void FullView_Click(object sender, EventArgs e)
        {
            FullSyllogoiView syllogoiview = new FullSyllogoiView();
            syllogoiview.ShowDialog();
        }

        private void btnSearchSyllogo_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearch();
            }
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void EditNameSullogouPicture_Click(object sender, EventArgs e)
        {
            NewNameSullogouTxTBox.Visible = true;
            EditNameSullogouDonePicture.Visible = true;
        }

        private void EditNameProedrouPicture_Click(object sender, EventArgs e)
        {
            NewNameProedrouTxTBox.Visible = true;
            EditNameProedrouDonePicture.Visible = true;
        }

        private void EditEponumoProedrouPicture_Click(object sender, EventArgs e)
        {
            NewEponumoProedrouTxTBox.Visible = true;
            EditEponumoProedrouDonePicture.Visible = true;
        }

        private void EditNumFialesPicture_Click(object sender, EventArgs e)
        {
            NewNumFialesTxTBox.Visible = true;
            EditNumFialesDonePicture.Visible = true;
        }

        private void EditDateIdrusisPicture_Click(object sender, EventArgs e)
        {
            NewDateIdrusisTxTBox.Visible = true;
            EditDateIdrusisDonePicture.Visible = true;
        }

        private void EditNameSullogouDonePicture_Click(object sender, EventArgs e)
        {
            NewNameSullogouTxTBox.Visible = false;
            EditNameSullogouDonePicture.Visible = false;
        }

        private void EditNameProedrouDonePicture_Click(object sender, EventArgs e)
        {
            NewNameProedrouTxTBox.Visible = false;
            EditNameProedrouDonePicture.Visible = false;
        }

        private void EditEponumoProedrouDonePicture_Click(object sender, EventArgs e)
        {
            NewEponumoProedrouTxTBox.Visible = false;
            EditEponumoProedrouDonePicture.Visible = false;
        }

        private void EditNumFialesDonePicture_Click(object sender, EventArgs e)
        {
            NewNumFialesTxTBox.Visible = false;
            EditNumFialesDonePicture.Visible = false;
        }

        private void EditDateIdrusisDonePicture_Click(object sender, EventArgs e)
        {
            NewDateIdrusisTxTBox.Visible = false;
            EditNumFialesDonePicture.Visible = false;
        }

        private void NewNameSyllogouTxtBox_Leave(object sender, EventArgs e)
        {
            NewNameSullogouTxTBox.Text = NewNameSullogouTxTBox.Text.Trim();
            if (NewNameSullogouTxTBox.Text == "")
            { NewNameSullogouTxTBox.Text = onoma_SyllogouLabel1.Text; }
            else
            { NewNameSullogouTxTBox.Text = NewNameSullogouTxTBox.Text.ToUpper(); }
        }

        private void NewNameProedrouTxtBox_Leave(object sender, EventArgs e)
        {
            NewNameProedrouTxTBox.Text = NewNameProedrouTxTBox.Text.Trim();
            if (NewNameProedrouTxTBox.Text == "")
            { NewNameProedrouTxTBox.Text = onoma_ProedrouLabel1.Text; }
            else
            { NewNameProedrouTxTBox.Text = NewNameProedrouTxTBox.Text.ToUpper(); }
        }

        private void NewEponimoProedrouTxtBox_Leave(object sender, EventArgs e)
        {
            NewEponumoProedrouTxTBox.Text = NewEponumoProedrouTxTBox.Text.Trim();
            if (NewEponumoProedrouTxTBox.Text == "")
            { NewEponumoProedrouTxTBox.Text = eponumo_ProedrouLabel1.Text; }
            else
            { NewEponumoProedrouTxTBox.Text = NewEponumoProedrouTxTBox.Text.ToUpper(); }
        }

        private void NewNumFuallesTxtBox_Leave(object sender, EventArgs e)
        {
            bool is_Numb = true;
            int fialles;
            for (int i = 0; i < NewNumFialesTxTBox.TextLength; i++)
            {
                is_Numb = int.TryParse(NewNumFialesTxTBox.Text.Substring(i, 1), out fialles);
                if (!is_Numb)
                {
                    NewNumFialesTxTBox.ForeColor = Color.Maroon;
                    i = NewNumFialesTxTBox.TextLength + 999;
                }
                else
                {
                    NewNumFialesTxTBox.ForeColor=Color.Black;
                }
            }
        }

       // private void NewDateIdrisisTxtBox_Leave(object sender, EventArgs e)
     //   {
    //        NewDateIdrusisTxTBox.Text = NewDateIdrusisTxTBox.Text.Trim();
    //        if (NewDateIdrusisTxTBox.Text == "")
    //        { NewDateIdrusisTxTBox.Text = date_IdrisisLabel1.Text; }
    //       else
   //         { NewDateIdrusisTxTBox.Text = NewDateIdrusisTxTBox.Text.ToUpper(); }
  //   }

        private void btn_edit_Sullogo_Click_1(object sender, EventArgs e)
        {
            if (SullogosAnazitisis != null)
            {
                if (btn_edit_Sullogo.Text == "Επεξεργασία Συλλόγου")
                {

                    btnDeleteSyllogo.Enabled = false;
                    btnSearchSyllogo.Enabled = false;
                    txtBoxSearchSyllogo.Enabled = false;
                    btn_edit_Sullogo.ForeColor = Color.Maroon;
                    btn_edit_Sullogo.Text = " Τέλος Επεξεργασίας ";
                    EditNameSullogouPicture.Visible = true;

                    EditNameSullogouPicture.Visible = true;
                    EditNameSullogouPicture.Location = new Point(onoma_SyllogouLabel1.Location.X + onoma_SyllogouLabel1.Size.Width + 5, onoma_SyllogouLabel1.Location.Y);
                    NewNameSullogouTxTBox.Location = new Point(EditNameSullogouPicture.Location.X + EditNameSullogouPicture.Size.Width + 5, EditNameSullogouPicture.Location.Y);
                    NewNameSullogouTxTBox.Text = onoma_SyllogouLabel1.Text;
                    EditNameSullogouDonePicture.Location = new Point(NewNameSullogouTxTBox.Location.X + NewNameSullogouTxTBox.Size.Width + 5, NewNameSullogouTxTBox.Location.Y);

                    EditNameProedrouPicture.Visible = true;
                    EditNameProedrouPicture.Location = new Point(onoma_ProedrouLabel1.Location.X + onoma_ProedrouLabel1.Size.Width + 5, onoma_ProedrouLabel1.Location.Y);
                    NewNameProedrouTxTBox.Location = new Point(EditNameProedrouPicture.Location.X + EditNameProedrouPicture.Size.Width + 5, EditNameProedrouPicture.Location.Y);
                    NewNameProedrouTxTBox.Text = onoma_ProedrouLabel1.Text;
                    EditNameProedrouDonePicture.Location = new Point(NewNameProedrouTxTBox.Location.X + NewNameProedrouTxTBox.Size.Width + 5, NewNameProedrouTxTBox.Location.Y);

                    EditEponumoProedrouPicture.Visible = true;
                    EditEponumoProedrouPicture.Location = new Point(eponumo_ProedrouLabel1.Location.X + eponumo_ProedrouLabel1.Size.Width + 5, eponumo_ProedrouLabel1.Location.Y);
                    NewEponumoProedrouTxTBox.Location = new Point(EditEponumoProedrouPicture.Location.X + EditEponumoProedrouPicture.Size.Width + 5, EditEponumoProedrouPicture.Location.Y);
                    NewEponumoProedrouTxTBox.Text = eponumo_ProedrouLabel1.Text;
                    EditEponumoProedrouDonePicture.Location = new Point(NewEponumoProedrouTxTBox.Location.X + NewEponumoProedrouTxTBox.Size.Width + 5, NewEponumoProedrouTxTBox.Location.Y);

                    EditNumFialesPicture.Visible = true;
                    EditNumFialesPicture.Location = new Point(num_FialesLabel1.Location.X + num_FialesLabel1.Size.Width + 5, num_FialesLabel1.Location.Y);
                    NewNumFialesTxTBox.Location = new Point(EditNumFialesPicture.Location.X + EditNumFialesPicture.Size.Width + 5, EditNumFialesPicture.Location.Y);
                    NewNumFialesTxTBox.Text = num_FialesLabel1.Text;
                    EditNumFialesDonePicture.Location = new Point(NewNumFialesTxTBox.Location.X + NewNumFialesTxTBox.Size.Width + 5, NewNumFialesTxTBox.Location.Y);

                    EditDateIdrusisPicture.Visible = true;
                    EditDateIdrusisPicture.Location = new Point(date_IdrisisLabel1.Location.X + date_IdrisisLabel1.Size.Width + 5, date_IdrisisLabel1.Location.Y);
                    NewDateIdrusisTxTBox.Location = new Point(EditDateIdrusisPicture.Location.X + EditDateIdrusisPicture.Size.Width + 5, EditDateIdrusisPicture.Location.Y);
                    NewDateIdrusisTxTBox.Text = date_IdrisisLabel1.Text;
                    EditDateIdrusisDonePicture.Location = new Point(NewDateIdrusisTxTBox.Location.X + NewDateIdrusisTxTBox.Size.Width + 5, NewDateIdrusisTxTBox.Location.Y);

                }
                else
                {
                    btnSearchSyllogo.Enabled = true;
                    btnDeleteSyllogo.Enabled = true;
                    txtBoxSearchSyllogo.Enabled = true;
                    btn_edit_Sullogo.ForeColor = Color.Black;
                    btn_edit_Sullogo.Text = "Επεξεργασία Συλλόγου";
                    EditNameProedrouPicture.Visible = false;
                    NewNameProedrouTxTBox.Visible = false;
                    EditNameProedrouDonePicture.Visible = false;

                    EditNameSullogouPicture.Visible = false;
                    NewNameSullogouTxTBox.Visible = false;
                    EditNameSullogouDonePicture.Visible = false;

                    EditEponumoProedrouDonePicture.Visible = false;
                    NewEponumoProedrouTxTBox.Visible = false;
                    EditEponumoProedrouPicture.Visible = false;

                    EditNumFialesPicture.Visible = false;
                    NewNumFialesTxTBox.Visible = false;
                    EditNumFialesDonePicture.Visible = false;

                    EditDateIdrusisDonePicture.Visible = false;
                    NewDateIdrusisTxTBox.Visible = false;
                    EditDateIdrusisPicture.Visible = false;

                    bool error = false;
                    string errors = "";
                    if (NewNameProedrouTxTBox.Text == "")
                    {
                        error = true;
                        errors += "\n* Eισαγώγή ονόματος προέδρου";
                    }
                    if (NewNameSullogouTxTBox.Text == "")
                    {
                        error = true;
                        errors += "\n* Eισαγώγή ονόματος Συλλόγου";
                    }
                    if (NewEponumoProedrouTxTBox.Text == "")
                    {
                        error = true;
                        errors += "\n* Eισαγώγή Επίθετο προέδρου";
                    }
                    if (error) { MessageBox.Show("Σφάλμα κατα την : \n" + errors + "\n\nΑδύνατη διαμόρφωση", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    if (!error)
                    {
                        PtuxiakiDatabaseDataSet1.SyllogoiRow syllogos ;
                        syllogos = ptuxiakiDatabaseDataSet1.Syllogoi.FindByID_Syllogou(int.Parse(iD_SyllogouLabel1.Text));
                        string old_id = iD_SyllogouLabel1.Text;
                        syllogos.Onoma_Syllogou = NewNameSullogouTxTBox.Text;
                        syllogos.Onoma_Proedrou = NewNameProedrouTxTBox.Text;
                        syllogos.Eponumo_Proedrou = NewEponumoProedrouTxTBox.Text;
                        syllogos.Num_Fiales = Convert.ToInt32(NewNumFialesTxTBox.Text);
                        syllogos.Date_Idrisis = Convert.ToDateTime(NewDateIdrusisTxTBox.Text);
                        try
                        {
                            this.syllogoiTableAdapter.Update(syllogos);
                            this.syllogoiTableAdapter.FillByID_Syllogou(ptuxiakiDatabaseDataSet1.Syllogoi, int.Parse(iD_SyllogouLabel1.Text));
                            complete_labels();
                        }
                        catch (Exception ex)
                        {
                          // this.syllogoiTableAdapter.FillByID_Syllogou(ptuxiakiDatabaseDataSet1.Syllogoi, int.Parse(iD_SyllogouLabel1.Text));
                            complete_labels();
                            MessageBox.Show("Σφάλμα κατα την διαμόρφωση του συλλόγου.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Δεν υπάρχει σύλλογος πρός διαμόρφωση", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteSyllogo_Click(object sender, EventArgs e)
        {
            if (SullogosAnazitisis != null)
            {
                if (MessageBox.Show("Είστε σίγουροι ότι θέλετε να διαγραφεί ο Σύλλογος ? ?\n\n" + "Όνομα Συλλόγου : " + onoma_SyllogouLabel1.Text + "\n\n" + "Όν/νυμο προέδρου :" + onoma_ProedrouLabel1.Text + " " + eponumo_ProedrouLabel1.Text, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PtuxiakiDatabaseDataSet1.SyllogoiRow syllogos = ptuxiakiDatabaseDataSet1.Syllogoi.FindByID_Syllogou(int.Parse(iD_SyllogouLabel1.Text));
                    syllogos.Delete();
                    this.syllogoiTableAdapter.Update(ptuxiakiDatabaseDataSet1.Syllogoi);
                    clear_labels();
                    MessageBox.Show("Η διαγραφή του Συλλόγου έγινε με επιτυχία", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Δεν υπάρχει σύλλογος προς διαγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        


        


        
                  

      
    }
}
