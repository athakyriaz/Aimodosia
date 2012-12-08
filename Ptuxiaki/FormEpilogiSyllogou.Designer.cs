namespace Ptuxiaki
{
    partial class FormEpilogiSyllogou
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
            System.Windows.Forms.Label iD_SyllogouLabel;
            System.Windows.Forms.Label onoma_SyllogouLabel;
            System.Windows.Forms.Label eponumo_ProedrouLabel;
            System.Windows.Forms.Label onoma_ProedrouLabel;
            System.Windows.Forms.Label num_FialesLabel;
            System.Windows.Forms.Label date_IdrisisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEpilogiSyllogou));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.syllogoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syllogoiTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.syllogoiDataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.picBoxTick = new System.Windows.Forms.PictureBox();
            this.date_IdrisisLabel1 = new System.Windows.Forms.Label();
            this.num_FialesLabel1 = new System.Windows.Forms.Label();
            this.onoma_ProedrouLabel1 = new System.Windows.Forms.Label();
            this.eponumo_ProedrouLabel1 = new System.Windows.Forms.Label();
            this.onoma_SyllogouLabel1 = new System.Windows.Forms.Label();
            this.iD_SyllogouLabel1 = new System.Windows.Forms.Label();
            iD_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_SyllogouLabel = new System.Windows.Forms.Label();
            eponumo_ProedrouLabel = new System.Windows.Forms.Label();
            onoma_ProedrouLabel = new System.Windows.Forms.Label();
            num_FialesLabel = new System.Windows.Forms.Label();
            date_IdrisisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).BeginInit();
            this.syllogoiDataRepeater.ItemTemplate.SuspendLayout();
            this.syllogoiDataRepeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_SyllogouLabel
            // 
            iD_SyllogouLabel.AutoSize = true;
            iD_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            iD_SyllogouLabel.Location = new System.Drawing.Point(465, 47);
            iD_SyllogouLabel.Name = "iD_SyllogouLabel";
            iD_SyllogouLabel.Size = new System.Drawing.Size(34, 17);
            iD_SyllogouLabel.TabIndex = 0;
            iD_SyllogouLabel.Text = "ID :";
            // 
            // onoma_SyllogouLabel
            // 
            onoma_SyllogouLabel.AutoSize = true;
            onoma_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            onoma_SyllogouLabel.Location = new System.Drawing.Point(3, 15);
            onoma_SyllogouLabel.Name = "onoma_SyllogouLabel";
            onoma_SyllogouLabel.Size = new System.Drawing.Size(135, 17);
            onoma_SyllogouLabel.TabIndex = 2;
            onoma_SyllogouLabel.Text = "Όνομα Συλλόγου:";
            // 
            // eponumo_ProedrouLabel
            // 
            eponumo_ProedrouLabel.AutoSize = true;
            eponumo_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            eponumo_ProedrouLabel.Location = new System.Drawing.Point(3, 42);
            eponumo_ProedrouLabel.Name = "eponumo_ProedrouLabel";
            eponumo_ProedrouLabel.Size = new System.Drawing.Size(153, 17);
            eponumo_ProedrouLabel.TabIndex = 4;
            eponumo_ProedrouLabel.Text = "Επώνυμο Προέδρου:";
            // 
            // onoma_ProedrouLabel
            // 
            onoma_ProedrouLabel.AutoSize = true;
            onoma_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            onoma_ProedrouLabel.Location = new System.Drawing.Point(3, 73);
            onoma_ProedrouLabel.Name = "onoma_ProedrouLabel";
            onoma_ProedrouLabel.Size = new System.Drawing.Size(137, 17);
            onoma_ProedrouLabel.TabIndex = 6;
            onoma_ProedrouLabel.Text = "Όνομα Προέδρου:";
            // 
            // num_FialesLabel
            // 
            num_FialesLabel.AutoSize = true;
            num_FialesLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            num_FialesLabel.Location = new System.Drawing.Point(465, 73);
            num_FialesLabel.Name = "num_FialesLabel";
            num_FialesLabel.Size = new System.Drawing.Size(90, 17);
            num_FialesLabel.TabIndex = 8;
            num_FialesLabel.Text = "Αρ. Φιαλών:";
            // 
            // date_IdrisisLabel
            // 
            date_IdrisisLabel.AutoSize = true;
            date_IdrisisLabel.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            date_IdrisisLabel.Location = new System.Drawing.Point(465, 15);
            date_IdrisisLabel.Name = "date_IdrisisLabel";
            date_IdrisisLabel.Size = new System.Drawing.Size(126, 17);
            date_IdrisisLabel.TabIndex = 10;
            date_IdrisisLabel.Text = "Ημ/νία Ίδρυσης:";
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // syllogoiBindingSource
            // 
            this.syllogoiBindingSource.DataMember = "Syllogoi";
            this.syllogoiBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // syllogoiTableAdapter
            // 
            this.syllogoiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = null;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = this.syllogoiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XorigiseisTableAdapter = null;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // syllogoiDataRepeater
            // 
            this.syllogoiDataRepeater.DataSource = this.syllogoiBindingSource;
            this.syllogoiDataRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // syllogoiDataRepeater.ItemTemplate
            // 
            this.syllogoiDataRepeater.ItemTemplate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.picBoxTick);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(date_IdrisisLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.date_IdrisisLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(num_FialesLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.num_FialesLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(onoma_ProedrouLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.onoma_ProedrouLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(eponumo_ProedrouLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.eponumo_ProedrouLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(onoma_SyllogouLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.onoma_SyllogouLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(iD_SyllogouLabel);
            this.syllogoiDataRepeater.ItemTemplate.Controls.Add(this.iD_SyllogouLabel1);
            this.syllogoiDataRepeater.ItemTemplate.Size = new System.Drawing.Size(860, 110);
            this.syllogoiDataRepeater.Location = new System.Drawing.Point(0, 0);
            this.syllogoiDataRepeater.Name = "syllogoiDataRepeater";
            this.syllogoiDataRepeater.Size = new System.Drawing.Size(868, 403);
            this.syllogoiDataRepeater.TabIndex = 1;
            this.syllogoiDataRepeater.Text = "dataRepeater1";
            // 
            // picBoxTick
            // 
            this.picBoxTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTick.Image = global::Ptuxiaki.Properties.Resources._1301510751_success;
            this.picBoxTick.Location = new System.Drawing.Point(780, 21);
            this.picBoxTick.Name = "picBoxTick";
            this.picBoxTick.Size = new System.Drawing.Size(56, 50);
            this.picBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTick.TabIndex = 17;
            this.picBoxTick.TabStop = false;
            this.picBoxTick.Click += new System.EventHandler(this.picBoxTick_Click);
            // 
            // date_IdrisisLabel1
            // 
            this.date_IdrisisLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Date_Idrisis", true));
            this.date_IdrisisLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.date_IdrisisLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.date_IdrisisLabel1.Location = new System.Drawing.Point(597, 14);
            this.date_IdrisisLabel1.Name = "date_IdrisisLabel1";
            this.date_IdrisisLabel1.Size = new System.Drawing.Size(100, 23);
            this.date_IdrisisLabel1.TabIndex = 11;
            this.date_IdrisisLabel1.Text = "label1";
            // 
            // num_FialesLabel1
            // 
            this.num_FialesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Num_Fiales", true));
            this.num_FialesLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.num_FialesLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.num_FialesLabel1.Location = new System.Drawing.Point(561, 72);
            this.num_FialesLabel1.Name = "num_FialesLabel1";
            this.num_FialesLabel1.Size = new System.Drawing.Size(100, 23);
            this.num_FialesLabel1.TabIndex = 9;
            this.num_FialesLabel1.Text = "label1";
            // 
            // onoma_ProedrouLabel1
            // 
            this.onoma_ProedrouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Proedrou", true));
            this.onoma_ProedrouLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.onoma_ProedrouLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.onoma_ProedrouLabel1.Location = new System.Drawing.Point(141, 72);
            this.onoma_ProedrouLabel1.Name = "onoma_ProedrouLabel1";
            this.onoma_ProedrouLabel1.Size = new System.Drawing.Size(307, 23);
            this.onoma_ProedrouLabel1.TabIndex = 7;
            this.onoma_ProedrouLabel1.Text = "label1";
            // 
            // eponumo_ProedrouLabel1
            // 
            this.eponumo_ProedrouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Eponumo_Proedrou", true));
            this.eponumo_ProedrouLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.eponumo_ProedrouLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.eponumo_ProedrouLabel1.Location = new System.Drawing.Point(158, 41);
            this.eponumo_ProedrouLabel1.Name = "eponumo_ProedrouLabel1";
            this.eponumo_ProedrouLabel1.Size = new System.Drawing.Size(290, 23);
            this.eponumo_ProedrouLabel1.TabIndex = 5;
            this.eponumo_ProedrouLabel1.Text = "label1";
            // 
            // onoma_SyllogouLabel1
            // 
            this.onoma_SyllogouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Syllogou", true));
            this.onoma_SyllogouLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.onoma_SyllogouLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.onoma_SyllogouLabel1.Location = new System.Drawing.Point(144, 14);
            this.onoma_SyllogouLabel1.Name = "onoma_SyllogouLabel1";
            this.onoma_SyllogouLabel1.Size = new System.Drawing.Size(304, 23);
            this.onoma_SyllogouLabel1.TabIndex = 3;
            this.onoma_SyllogouLabel1.Text = "label1";
            // 
            // iD_SyllogouLabel1
            // 
            this.iD_SyllogouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "ID_Syllogou", true));
            this.iD_SyllogouLabel1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.iD_SyllogouLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.iD_SyllogouLabel1.Location = new System.Drawing.Point(505, 46);
            this.iD_SyllogouLabel1.Name = "iD_SyllogouLabel1";
            this.iD_SyllogouLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_SyllogouLabel1.TabIndex = 1;
            this.iD_SyllogouLabel1.Text = "label1";
            // 
            // FormEpilogiSyllogou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 403);
            this.Controls.Add(this.syllogoiDataRepeater);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEpilogiSyllogou";
            this.Text = "Επιλογή Συλλόγου © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormEpilogiSyllogou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).EndInit();
            this.syllogoiDataRepeater.ItemTemplate.ResumeLayout(false);
            this.syllogoiDataRepeater.ItemTemplate.PerformLayout();
            this.syllogoiDataRepeater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource syllogoiBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater syllogoiDataRepeater;
        private System.Windows.Forms.Label iD_SyllogouLabel1;
        private System.Windows.Forms.Label date_IdrisisLabel1;
        private System.Windows.Forms.Label num_FialesLabel1;
        private System.Windows.Forms.Label onoma_ProedrouLabel1;
        private System.Windows.Forms.Label eponumo_ProedrouLabel1;
        private System.Windows.Forms.Label onoma_SyllogouLabel1;
        private System.Windows.Forms.PictureBox picBoxTick;
    }
}