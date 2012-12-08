using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormSelectHistory : Form
    {
        public FormSelectHistory()
        {
            InitializeComponent();
        }


        public long IDaimodoti;
        public long IDistorikou;

        private void FormSelectHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Fiales' table. You can move, or remove it, as needed.
          
            this.istorikoTableAdapter.FillByIDaimodoti(ptuxiakiDatabaseDataSet1.Istoriko, IDaimodoti);
            if (istorikoDataRepeater.CurrentItemIndex == -1)
            {
                this.DialogResult = DialogResult.Abort;
                MessageBox.Show("Δεν υπάρχουν Ιστορικά με τον Κωδικό Αιμοδότη : " + IDaimodoti.ToString(), "Error");

            }
        }

        private void picBoxTick_Click(object sender, EventArgs e)
        {
            DataRow Istoriko;
            Istoriko = ptuxiakiDatabaseDataSet1.Tables["Istoriko"].Rows[istorikoDataRepeater.CurrentItemIndex];
            IDistorikou = long.Parse(Istoriko[0].ToString());
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
