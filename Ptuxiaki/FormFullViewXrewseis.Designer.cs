namespace Ptuxiaki
{
    partial class FormFullViewXrewseis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFullViewXrewseis));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.xrewshBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xrewshTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.xrewshDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumFialesXr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrewshBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrewshDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xrewshBindingSource
            // 
            this.xrewshBindingSource.DataMember = "Xrewsh";
            this.xrewshBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // xrewshTableAdapter
            // 
            this.xrewshTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = null;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XrewshTableAdapter = this.xrewshTableAdapter;
            // 
            // xrewshDataGridView
            // 
            this.xrewshDataGridView.AllowUserToAddRows = false;
            this.xrewshDataGridView.AllowUserToDeleteRows = false;
            this.xrewshDataGridView.AutoGenerateColumns = false;
            this.xrewshDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xrewshDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.NumFialesXr,
            this.dataGridViewTextBoxColumn6});
            this.xrewshDataGridView.DataSource = this.xrewshBindingSource;
            this.xrewshDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrewshDataGridView.Location = new System.Drawing.Point(0, 0);
            this.xrewshDataGridView.Name = "xrewshDataGridView";
            this.xrewshDataGridView.ReadOnly = true;
            this.xrewshDataGridView.Size = new System.Drawing.Size(843, 400);
            this.xrewshDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdXrewshs";
            this.dataGridViewTextBoxColumn1.HeaderText = "Κωδικός Χρέωσης";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAimodoti";
            this.dataGridViewTextBoxColumn2.HeaderText = "Κωδικός Αιμοδότη";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdSyllogou";
            this.dataGridViewTextBoxColumn3.HeaderText = "Κωδικός Συλλόγου";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "AstheniName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Όνομα Ασθενή";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AstheniLastName";
            this.dataGridViewTextBoxColumn5.HeaderText = "Επώνυμο Ασθενή";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "NosokomeioAstheni";
            this.dataGridViewTextBoxColumn7.HeaderText = "Νοσοκομείο Ασθενή";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // NumFialesXr
            // 
            this.NumFialesXr.DataPropertyName = "NumFialesXr";
            this.NumFialesXr.HeaderText = "Αριθμός Φιαλών";
            this.NumFialesXr.Name = "NumFialesXr";
            this.NumFialesXr.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateXrewshs";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ημ/νία Χρέωσης";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // FormFullViewXrewseis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 400);
            this.Controls.Add(this.xrewshDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFullViewXrewseis";
            this.Text = "Προβολή Χρεώσεων Φιαλών © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormFullViewXrewseis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrewshBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrewshDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource xrewshBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter xrewshTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView xrewshDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumFialesXr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}