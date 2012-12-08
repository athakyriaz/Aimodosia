using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFindFialiFromMain : Form
    {
        public FormFindFialiFromMain()
        {
            InitializeComponent();
        }

        public DataRow FialiAnazitisis;
        public DataRow aimodotisFialis;

        private void FormFindFialiFromMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet11.Aimodotes' table. You can move, or remove it, as needed.
            this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);
            LabelIdFialis.Text = FialiAnazitisis[0].ToString();
            comboBoxKatastasi.Text = FialiAnazitisis[5].ToString();
            labelDateAimodosias.Text = FialiAnazitisis[7].ToString();
            long idaimodoti = long.Parse(FialiAnazitisis[1].ToString());            
            PtuxiakiDatabaseDataSet1.AimodotesRow aimodotis;
            aimodotis = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(idaimodoti);
            labelNameAimodoti.Text = aimodotis.Name.ToString();
            labelLastNameAimodoti.Text = aimodotis.LastName.ToString();
            if (FialiAnazitisis[2].ToString() != "")
            {
                labelKathgoriaAimodosias.Text = "Για Σύλλογο με κωδικό :"+FialiAnazitisis[2].ToString();
            }
            else if (FialiAnazitisis[3].ToString() != "")
            {
                labelKathgoriaAimodosias.Text = "Για τον Ασθενή " + FialiAnazitisis[3].ToString();
            }
            else
            {
                labelKathgoriaAimodosias.Text = "Εθελοντικά";
            }
            
        }

        private void aimodotesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aimodotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void ViewFiales_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView FullViewFiales = new FormAimodosiaFullView();
            FullViewFiales.Show();
        }

        private void ViewAimodotes_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView aimodotesViewFull = new FormAimodosiaFullView();
            aimodotesViewFull.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditFialiSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.fialesTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Fiales);
                long idFialis = long.Parse(FialiAnazitisis[0].ToString());
                PtuxiakiDatabaseDataSet1.FialesRow fiali;
                fiali = ptuxiakiDatabaseDataSet1.Fiales.FindByIDFialis(idFialis);                
                fiali.Katastasi  = comboBoxKatastasi.Text;
                fialesTableAdapter1.Update(fiali);
                MessageBox.Show("H Φιάλη με κωδικό  " + FialiAnazitisis[0].ToString() + " ενημερώθηκε : " + comboBoxKatastasi.Text + " .", "", MessageBoxButtons.OK);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Η εγγραφή απέτυχε", "", MessageBoxButtons.OK);
            }
        }

        private void comboBoxKatastasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
              comboBoxKatastasi.Text = "";
            
        }

      


       

      
    }
}
