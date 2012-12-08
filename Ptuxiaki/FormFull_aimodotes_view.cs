using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFull_aimodotes_view : Form
    {
        public FormFull_aimodotes_view()
        {
            InitializeComponent();
        }

        private void aimodotesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aimodotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void FormFull_aimodotes_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Aimodotes' table. You can move, or remove it, as needed.
            this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Aimodotes' table. You can move, or remove it, as needed.
            this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);
            // TODO: This line of code loads data into the 'ptuxiakiDatabaseDataSet1.Aimodotes' table. You can move, or remove it, as needed.
            this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);

        }

        private void aimodotesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.aimodotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        private void aimodotesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.aimodotesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ptuxiakiDatabaseDataSet1);

        }

        
    }
}
