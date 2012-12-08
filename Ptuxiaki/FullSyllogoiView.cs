using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FullSyllogoiView : Form
    {
        public FullSyllogoiView()
        {
            InitializeComponent();
        }

        private void syllogoiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.syllogoiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FullSyllogoiView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Syllogoi' table. You can move, or remove it, as needed.
            this.syllogoiTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Syllogoi);

        }
    }
}
