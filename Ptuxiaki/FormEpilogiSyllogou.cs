using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormEpilogiSyllogou : Form
    {
        public FormEpilogiSyllogou()
        {
            InitializeComponent();
        }

        private void FormEpilogiSyllogou_Load(object sender, EventArgs e)
        {
            syllogoiTableAdapter.FillByX_Syllogo(ptuxiakiDatabaseDataSet1.Syllogoi, stoixeio);
        }
        public DataRow SullogosAnazitisis;
        public string stoixeio;
        private void picBoxTick_Click(object sender, EventArgs e)
        {
            SullogosAnazitisis = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Rows[syllogoiDataRepeater.CurrentItemIndex];
            this.DialogResult = DialogResult.OK;
        }

       

      
    }
}
