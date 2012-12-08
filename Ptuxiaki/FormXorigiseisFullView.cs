using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormXorigiseisFullView : Form
    {
        public FormXorigiseisFullView()
        {
            InitializeComponent();
        }

        private void xorigiseisBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.xorigiseisBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FormXorigiseisFullView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Xorigiseis' table. You can move, or remove it, as needed.
            this.xorigiseisTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Xorigiseis);

        }
    }
}
