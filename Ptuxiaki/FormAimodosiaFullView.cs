using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormAimodosiaFullView : Form
    {
        public FormAimodosiaFullView()
        {
            InitializeComponent();
        }

        private void fialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FormAimodosiaFullView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Fiales' table. You can move, or remove it, as needed.
            this.fialesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Fiales);

        }
    }
}
