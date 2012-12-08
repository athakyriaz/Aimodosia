using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFindFialiFromMenu : Form
    {
        public FormFindFialiFromMenu()
        {
            InitializeComponent();
        }


        public static DataRow FialiAnazitisis;
        public static string stoix;
        private void dothesearchFialis()
        {
            if (textBoxSearchFiali.Text != "")
            {
                int count_results = 0;
                DataRow[] grammes;
                this.fialesTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Fiales);

                grammes = ptuxiakiDatabaseDataSet11.Tables["Fiales"].Select("IDFialis = '" + textBoxSearchFiali.Text + "'");

                count_results = grammes.Length;

                if (count_results == 1)
                {
                    MessageBox.Show("Η Φιάλη Βρέθηκε", "Found !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormFindFialiFromMain FindFiali = new FormFindFialiFromMain();
                    this.Close();
                    FindFiali.FialiAnazitisis = grammes[0];
                    FindFiali.Show();
                }
                if (count_results == 0)
                {
                    MessageBox.Show("Δεν βρέθηκε η Φιάλη , Ελέγξτε πάλι τον Κωδικό της!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

       

        private void textBoxSearchFiali_Click(object sender, EventArgs e)
        {
            textBoxSearchFiali.Clear();
        }

        private void btnFindFiali_Click(object sender, EventArgs e)
        {
            dothesearchFialis();
        }

        private void textBoxSearchFiali_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearchFialis();
            }
        
        }

       
       

    
    
    
    
    
    
    
    }
}
