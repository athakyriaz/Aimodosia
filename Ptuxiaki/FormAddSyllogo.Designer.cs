namespace Ptuxiaki
{
    partial class FormAddSyllogo
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
            System.Windows.Forms.Label onoma_SyllogouLabel;
            System.Windows.Forms.Label onoma_ProedrouLabel;
            System.Windows.Forms.Label eponumo_ProedrouLabel;
            System.Windows.Forms.Label date_IdrisisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddSyllogo));
            this.onoma_SyllogouTextBox = new System.Windows.Forms.TextBox();
            this.syllogoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.onoma_ProedrouTextBox = new System.Windows.Forms.TextBox();
            this.eponumo_ProedrouTextBox = new System.Windows.Forms.TextBox();
            this.date_IdrisisDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.syllogoiTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullViewSullogoi = new System.Windows.Forms.ToolStripMenuItem();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            onoma_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_ProedrouLabel = new System.Windows.Forms.Label();
            eponumo_ProedrouLabel = new System.Windows.Forms.Label();
            date_IdrisisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // onoma_SyllogouLabel
            // 
            onoma_SyllogouLabel.AutoSize = true;
            onoma_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            onoma_SyllogouLabel.Location = new System.Drawing.Point(37, 87);
            onoma_SyllogouLabel.Name = "onoma_SyllogouLabel";
            onoma_SyllogouLabel.Size = new System.Drawing.Size(122, 14);
            onoma_SyllogouLabel.TabIndex = 4;
            onoma_SyllogouLabel.Text = "Όνομα Συλλόγου :";
            // 
            // onoma_ProedrouLabel
            // 
            onoma_ProedrouLabel.AutoSize = true;
            onoma_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            onoma_ProedrouLabel.Location = new System.Drawing.Point(37, 113);
            onoma_ProedrouLabel.Name = "onoma_ProedrouLabel";
            onoma_ProedrouLabel.Size = new System.Drawing.Size(124, 14);
            onoma_ProedrouLabel.TabIndex = 6;
            onoma_ProedrouLabel.Text = "Όνομα Προέδρου :";
            // 
            // eponumo_ProedrouLabel
            // 
            eponumo_ProedrouLabel.AutoSize = true;
            eponumo_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            eponumo_ProedrouLabel.Location = new System.Drawing.Point(37, 139);
            eponumo_ProedrouLabel.Name = "eponumo_ProedrouLabel";
            eponumo_ProedrouLabel.Size = new System.Drawing.Size(138, 14);
            eponumo_ProedrouLabel.TabIndex = 8;
            eponumo_ProedrouLabel.Text = "Επώνυμο Προέδρου :";
            // 
            // date_IdrisisLabel
            // 
            date_IdrisisLabel.AutoSize = true;
            date_IdrisisLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            date_IdrisisLabel.Location = new System.Drawing.Point(37, 170);
            date_IdrisisLabel.Name = "date_IdrisisLabel";
            date_IdrisisLabel.Size = new System.Drawing.Size(145, 14);
            date_IdrisisLabel.TabIndex = 12;
            date_IdrisisLabel.Text = "Ημερομηνία Ίδρυσης :";
            // 
            // onoma_SyllogouTextBox
            // 
            this.onoma_SyllogouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Syllogou", true));
            this.onoma_SyllogouTextBox.Location = new System.Drawing.Point(187, 85);
            this.onoma_SyllogouTextBox.Name = "onoma_SyllogouTextBox";
            this.onoma_SyllogouTextBox.Size = new System.Drawing.Size(200, 20);
            this.onoma_SyllogouTextBox.TabIndex = 5;
            // 
            // syllogoiBindingSource
            // 
            this.syllogoiBindingSource.DataMember = "Syllogoi";
            this.syllogoiBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // onoma_ProedrouTextBox
            // 
            this.onoma_ProedrouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Proedrou", true));
            this.onoma_ProedrouTextBox.Location = new System.Drawing.Point(187, 111);
            this.onoma_ProedrouTextBox.Name = "onoma_ProedrouTextBox";
            this.onoma_ProedrouTextBox.Size = new System.Drawing.Size(200, 20);
            this.onoma_ProedrouTextBox.TabIndex = 7;
            // 
            // eponumo_ProedrouTextBox
            // 
            this.eponumo_ProedrouTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Eponumo_Proedrou", true));
            this.eponumo_ProedrouTextBox.Location = new System.Drawing.Point(187, 137);
            this.eponumo_ProedrouTextBox.Name = "eponumo_ProedrouTextBox";
            this.eponumo_ProedrouTextBox.Size = new System.Drawing.Size(200, 20);
            this.eponumo_ProedrouTextBox.TabIndex = 9;
            // 
            // date_IdrisisDateTimePicker
            // 
            this.date_IdrisisDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.syllogoiBindingSource, "Date_Idrisis", true));
            this.date_IdrisisDateTimePicker.Location = new System.Drawing.Point(187, 165);
            this.date_IdrisisDateTimePicker.Name = "date_IdrisisDateTimePicker";
            this.date_IdrisisDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_IdrisisDateTimePicker.TabIndex = 13;
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
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSave.Image = global::Ptuxiaki.Properties.Resources._1300790450_3floppy_unmount;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(150, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 41);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Αποθήκευση";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "Αρχείο";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::Ptuxiaki.Properties.Resources._1301512519_fileclose;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Κλείσιμο";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullViewSullogoi});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // FullViewSullogoi
            // 
            this.FullViewSullogoi.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.FullViewSullogoi.Name = "FullViewSullogoi";
            this.FullViewSullogoi.Size = new System.Drawing.Size(169, 22);
            this.FullViewSullogoi.Text = "Πλήρης Προβολή";
            this.FullViewSullogoi.Click += new System.EventHandler(this.FullViewSullogoi_Click_1);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(409, 319);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(40, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 42;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // FormAddSyllogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 363);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(onoma_SyllogouLabel);
            this.Controls.Add(this.onoma_SyllogouTextBox);
            this.Controls.Add(onoma_ProedrouLabel);
            this.Controls.Add(this.onoma_ProedrouTextBox);
            this.Controls.Add(eponumo_ProedrouLabel);
            this.Controls.Add(this.eponumo_ProedrouTextBox);
            this.Controls.Add(date_IdrisisLabel);
            this.Controls.Add(this.date_IdrisisDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddSyllogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή Συλλόγου © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormAddSyllogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource syllogoiBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox onoma_SyllogouTextBox;
        private System.Windows.Forms.TextBox onoma_ProedrouTextBox;
        private System.Windows.Forms.TextBox eponumo_ProedrouTextBox;
        private System.Windows.Forms.DateTimePicker date_IdrisisDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullViewSullogoi;
        private System.Windows.Forms.PictureBox picboxClose;
    }
}