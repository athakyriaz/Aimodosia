namespace Ptuxiaki
{
    partial class FormAimodosiaFullView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAimodosiaFullView));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.fialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fialesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.fialesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fialesBindingSource
            // 
            this.fialesBindingSource.DataMember = "Fiales";
            this.fialesBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // fialesTableAdapter
            // 
            this.fialesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = this.fialesTableAdapter;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // fialesDataGridView
            // 
            this.fialesDataGridView.AllowUserToAddRows = false;
            this.fialesDataGridView.AllowUserToDeleteRows = false;
            this.fialesDataGridView.AutoGenerateColumns = false;
            this.fialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fialesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.fialesDataGridView.DataSource = this.fialesBindingSource;
            this.fialesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fialesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fialesDataGridView.Name = "fialesDataGridView";
            this.fialesDataGridView.ReadOnly = true;
            this.fialesDataGridView.Size = new System.Drawing.Size(843, 404);
            this.fialesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDFialis";
            this.dataGridViewTextBoxColumn1.HeaderText = "Κωδικός Φιάλης";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDaimodoti";
            this.dataGridViewTextBoxColumn2.HeaderText = "Κωδικός Αιμοδότη";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IDSyllogou";
            this.dataGridViewTextBoxColumn3.HeaderText = "Κωδικός Συλλόγου";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Asthenis";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ασθενής";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nosokomeio_Astheni";
            this.dataGridViewTextBoxColumn5.HeaderText = "Νοσοκομείο Ασθενή";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Katastasi";
            this.dataGridViewTextBoxColumn6.HeaderText = "Κατάσταση";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IDistorikou";
            this.dataGridViewTextBoxColumn7.HeaderText = "Κωδικός Ιστορικού";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ημερομηνία";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // FormAimodosiaFullView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 404);
            this.Controls.Add(this.fialesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAimodosiaFullView";
            this.Text = "Προβολή Αιμοδοσιών  © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormAimodosiaFullView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource fialesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fialesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}