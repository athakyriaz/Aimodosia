using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFullViewXrewseis : Form
    {
        public FormFullViewXrewseis()
        {
            InitializeComponent();
        }

        private void xrewshBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xrewshBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FormFullViewXrewseis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Xrewsh' table. You can move, or remove it, as needed.
            this.xrewshTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Xrewsh);

        }
    }
}
