using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class HistoryFullView : Form
    {
        public HistoryFullView()
        {
            InitializeComponent();
        }

        private void istorikoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.istorikoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void HistoryFullView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Istoriko' table. You can move, or remove it, as needed.
            this.istorikoTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Istoriko);

        }
    }
}
