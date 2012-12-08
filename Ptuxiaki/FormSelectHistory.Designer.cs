namespace Ptuxiaki
{
    partial class FormSelectHistory
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
            System.Windows.Forms.Label iDistorikouLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iDaimodotiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectHistory));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.istorikoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istorikoTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.IstorikoTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.istorikoDataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.picBoxTick = new System.Windows.Forms.PictureBox();
            this.iDaimodotiLabel1 = new System.Windows.Forms.Label();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.iDistorikouLabel1 = new System.Windows.Forms.Label();
            iDistorikouLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iDaimodotiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istorikoBindingSource)).BeginInit();
            this.istorikoDataRepeater.ItemTemplate.SuspendLayout();
            this.istorikoDataRepeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).BeginInit();
            this.SuspendLayout();
            // 
            // iDistorikouLabel
            // 
            iDistorikouLabel.AutoSize = true;
            iDistorikouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            iDistorikouLabel.Location = new System.Drawing.Point(3, 57);
            iDistorikouLabel.Name = "iDistorikouLabel";
            iDistorikouLabel.Size = new System.Drawing.Size(134, 18);
            iDistorikouLabel.TabIndex = 0;
            iDistorikouLabel.Text = "Κωδ. Ιστορικού :";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            dateLabel.Location = new System.Drawing.Point(69, 94);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(67, 18);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Ημ/νία :";
            // 
            // iDaimodotiLabel
            // 
            iDaimodotiLabel.AutoSize = true;
            iDaimodotiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            iDaimodotiLabel.Location = new System.Drawing.Point(6, 14);
            iDaimodotiLabel.Name = "iDaimodotiLabel";
            iDaimodotiLabel.Size = new System.Drawing.Size(130, 18);
            iDaimodotiLabel.TabIndex = 4;
            iDaimodotiLabel.Text = "Κωδ. Αιμοδότη :";
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // istorikoBindingSource
            // 
            this.istorikoBindingSource.DataMember = "Istoriko";
            this.istorikoBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // istorikoTableAdapter
            // 
            this.istorikoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = null;
            this.tableAdapterManager.IstorikoTableAdapter = this.istorikoTableAdapter;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XorigiseisTableAdapter = null;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // istorikoDataRepeater
            // 
            this.istorikoDataRepeater.AllowUserToAddItems = false;
            this.istorikoDataRepeater.AllowUserToDeleteItems = false;
            this.istorikoDataRepeater.DataSource = this.istorikoBindingSource;
            this.istorikoDataRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.istorikoDataRepeater.ItemHeaderVisible = false;
            // 
            // istorikoDataRepeater.ItemTemplate
            // 
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(this.picBoxTick);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(iDaimodotiLabel);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(this.iDaimodotiLabel1);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(dateLabel);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(this.dateLabel1);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(iDistorikouLabel);
            this.istorikoDataRepeater.ItemTemplate.Controls.Add(this.iDistorikouLabel1);
            this.istorikoDataRepeater.ItemTemplate.Size = new System.Drawing.Size(411, 129);
            this.istorikoDataRepeater.Location = new System.Drawing.Point(0, 0);
            this.istorikoDataRepeater.Name = "istorikoDataRepeater";
            this.istorikoDataRepeater.Size = new System.Drawing.Size(419, 497);
            this.istorikoDataRepeater.TabIndex = 0;
            this.istorikoDataRepeater.Text = "dataRepeater1";
            // 
            // picBoxTick
            // 
            this.picBoxTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTick.Image = global::Ptuxiaki.Properties.Resources._1301510751_success;
            this.picBoxTick.Location = new System.Drawing.Point(337, 30);
            this.picBoxTick.Name = "picBoxTick";
            this.picBoxTick.Size = new System.Drawing.Size(45, 45);
            this.picBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTick.TabIndex = 18;
            this.picBoxTick.TabStop = false;
            this.picBoxTick.Click += new System.EventHandler(this.picBoxTick_Click);
            // 
            // iDaimodotiLabel1
            // 
            this.iDaimodotiLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istorikoBindingSource, "IDaimodoti", true));
            this.iDaimodotiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iDaimodotiLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.iDaimodotiLabel1.Location = new System.Drawing.Point(142, 16);
            this.iDaimodotiLabel1.Name = "iDaimodotiLabel1";
            this.iDaimodotiLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDaimodotiLabel1.TabIndex = 5;
            this.iDaimodotiLabel1.Text = "label1";
            // 
            // dateLabel1
            // 
            this.dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istorikoBindingSource, "date", true));
            this.dateLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.dateLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.dateLabel1.Location = new System.Drawing.Point(142, 96);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.dateLabel1.TabIndex = 3;
            this.dateLabel1.Text = "label1";
            // 
            // iDistorikouLabel1
            // 
            this.iDistorikouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.istorikoBindingSource, "IDistorikou", true));
            this.iDistorikouLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iDistorikouLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.iDistorikouLabel1.Location = new System.Drawing.Point(142, 59);
            this.iDistorikouLabel1.Name = "iDistorikouLabel1";
            this.iDistorikouLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDistorikouLabel1.TabIndex = 1;
            this.iDistorikouLabel1.Text = "label1";
            // 
            // FormSelectHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 497);
            this.Controls.Add(this.istorikoDataRepeater);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSelectHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Επιλογή Ιστορικού © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormSelectHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istorikoBindingSource)).EndInit();
            this.istorikoDataRepeater.ItemTemplate.ResumeLayout(false);
            this.istorikoDataRepeater.ItemTemplate.PerformLayout();
            this.istorikoDataRepeater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource istorikoBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.IstorikoTableAdapter istorikoTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater istorikoDataRepeater;
        private System.Windows.Forms.Label iDaimodotiLabel1;
        private System.Windows.Forms.Label iDistorikouLabel1;
        private System.Windows.Forms.PictureBox picBoxTick;
        private System.Windows.Forms.Label dateLabel1;
    }
}