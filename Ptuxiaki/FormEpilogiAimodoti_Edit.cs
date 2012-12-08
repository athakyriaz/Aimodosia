using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormEpilogiAimodoti_Edit : Form
    {
        public FormEpilogiAimodoti_Edit()
        {
            InitializeComponent();
        }

        private void FormEpilogiAimodoti_Edit_Load(object sender, EventArgs e)
        {
            aimodotesTableAdapter.FillByX(ptuxiakiDatabaseDataSet1.Aimodotes, stoixeio);

        }

        public DataRow AimodotisAnazitishs;

        public string stoixeio;
        private void picBoxTick_Click(object sender, EventArgs e)
        {
            //FormUpdateAimodoti.AimodotisAnazitisis = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Rows[aimodotesDataRepeater.CurrentItemIndex];
            AimodotisAnazitishs = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Rows[aimodotesDataRepeater.CurrentItemIndex];
            this.DialogResult = DialogResult.OK;
        }

     

       

        
    }
}
