namespace Ptuxiaki
{
    partial class FormFindFialiFromMain
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label labelKatigoria;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindFialiFromMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewFiales = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewAimodotes = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelKathgoriaAimodosias = new System.Windows.Forms.Label();
            this.comboBoxKatastasi = new System.Windows.Forms.ComboBox();
            this.labelDateAimodosias = new System.Windows.Forms.Label();
            this.labelLastNameAimodoti = new System.Windows.Forms.Label();
            this.labelNameAimodoti = new System.Windows.Forms.Label();
            this.LabelIdFialis = new System.Windows.Forms.Label();
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.aimodotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aimodotesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.fialesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            this.btnEditFialiSave = new System.Windows.Forms.Button();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.fialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            labelKatigoria = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label2.Location = new System.Drawing.Point(36, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(137, 18);
            label2.TabIndex = 111;
            label2.Text = "Κωδικός Φιάλης :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label1.Location = new System.Drawing.Point(36, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(140, 18);
            label1.TabIndex = 112;
            label1.Text = "Όνομα Αιμοδότη :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label3.Location = new System.Drawing.Point(36, 120);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(157, 18);
            label3.TabIndex = 113;
            label3.Text = "Επώνυμο Αιμοδότη :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label4.Location = new System.Drawing.Point(36, 163);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(158, 18);
            label4.TabIndex = 114;
            label4.Text = "Κατάσταση Φιάλης :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label5.Location = new System.Drawing.Point(36, 252);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(155, 18);
            label5.TabIndex = 115;
            label5.Text = "Ημ/νία Χορήγησης :";
            // 
            // labelKatigoria
            // 
            labelKatigoria.AutoSize = true;
            labelKatigoria.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            labelKatigoria.Location = new System.Drawing.Point(36, 210);
            labelKatigoria.Name = "labelKatigoria";
            labelKatigoria.Size = new System.Drawing.Size(95, 18);
            labelKatigoria.TabIndex = 121;
            labelKatigoria.Text = "Χορήγηση  :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.fileToolStripMenuItem.Text = "Αρχείο";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Ptuxiaki.Properties.Resources._1301512519_fileclose1;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Κλείσιμο";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewFiales,
            this.ViewAimodotes});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // ViewFiales
            // 
            this.ViewFiales.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.ViewFiales.Name = "ViewFiales";
            this.ViewFiales.Size = new System.Drawing.Size(189, 22);
            this.ViewFiales.Text = "Προβολή Φιαλών";
            this.ViewFiales.Click += new System.EventHandler(this.ViewFiales_Click);
            // 
            // ViewAimodotes
            // 
            this.ViewAimodotes.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.ViewAimodotes.Name = "ViewAimodotes";
            this.ViewAimodotes.Size = new System.Drawing.Size(189, 22);
            this.ViewAimodotes.Text = "Προβολή Αιμοδοτών";
            this.ViewAimodotes.Click += new System.EventHandler(this.ViewAimodotes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelKathgoriaAimodosias);
            this.groupBox1.Controls.Add(labelKatigoria);
            this.groupBox1.Controls.Add(this.comboBoxKatastasi);
            this.groupBox1.Controls.Add(this.labelDateAimodosias);
            this.groupBox1.Controls.Add(this.labelLastNameAimodoti);
            this.groupBox1.Controls.Add(this.labelNameAimodoti);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(this.LabelIdFialis);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 320);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Στοιχεία Φιάλης";
            // 
            // labelKathgoriaAimodosias
            // 
            this.labelKathgoriaAimodosias.AutoSize = true;
            this.labelKathgoriaAimodosias.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelKathgoriaAimodosias.ForeColor = System.Drawing.Color.Maroon;
            this.labelKathgoriaAimodosias.Location = new System.Drawing.Point(203, 212);
            this.labelKathgoriaAimodosias.Name = "labelKathgoriaAimodosias";
            this.labelKathgoriaAimodosias.Size = new System.Drawing.Size(46, 16);
            this.labelKathgoriaAimodosias.TabIndex = 122;
            this.labelKathgoriaAimodosias.Text = "label2";
            // 
            // comboBoxKatastasi
            // 
            this.comboBoxKatastasi.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxKatastasi.ForeColor = System.Drawing.Color.Maroon;
            this.comboBoxKatastasi.FormattingEnabled = true;
            this.comboBoxKatastasi.Items.AddRange(new object[] {
            "Ελεγμένο",
            "Απορρίφθηκε"});
            this.comboBoxKatastasi.Location = new System.Drawing.Point(206, 163);
            this.comboBoxKatastasi.Name = "comboBoxKatastasi";
            this.comboBoxKatastasi.Size = new System.Drawing.Size(121, 24);
            this.comboBoxKatastasi.TabIndex = 120;
            this.comboBoxKatastasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxKatastasi_KeyPress);
            // 
            // labelDateAimodosias
            // 
            this.labelDateAimodosias.AutoSize = true;
            this.labelDateAimodosias.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelDateAimodosias.ForeColor = System.Drawing.Color.Maroon;
            this.labelDateAimodosias.Location = new System.Drawing.Point(203, 254);
            this.labelDateAimodosias.Name = "labelDateAimodosias";
            this.labelDateAimodosias.Size = new System.Drawing.Size(46, 16);
            this.labelDateAimodosias.TabIndex = 119;
            this.labelDateAimodosias.Text = "label2";
            // 
            // labelLastNameAimodoti
            // 
            this.labelLastNameAimodoti.AutoSize = true;
            this.labelLastNameAimodoti.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelLastNameAimodoti.ForeColor = System.Drawing.Color.Maroon;
            this.labelLastNameAimodoti.Location = new System.Drawing.Point(203, 122);
            this.labelLastNameAimodoti.Name = "labelLastNameAimodoti";
            this.labelLastNameAimodoti.Size = new System.Drawing.Size(46, 16);
            this.labelLastNameAimodoti.TabIndex = 117;
            this.labelLastNameAimodoti.Text = "label2";
            // 
            // labelNameAimodoti
            // 
            this.labelNameAimodoti.AutoSize = true;
            this.labelNameAimodoti.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelNameAimodoti.ForeColor = System.Drawing.Color.Maroon;
            this.labelNameAimodoti.Location = new System.Drawing.Point(203, 82);
            this.labelNameAimodoti.Name = "labelNameAimodoti";
            this.labelNameAimodoti.Size = new System.Drawing.Size(46, 16);
            this.labelNameAimodoti.TabIndex = 116;
            this.labelNameAimodoti.Text = "label2";
            // 
            // LabelIdFialis
            // 
            this.LabelIdFialis.AutoSize = true;
            this.LabelIdFialis.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LabelIdFialis.ForeColor = System.Drawing.Color.Maroon;
            this.LabelIdFialis.Location = new System.Drawing.Point(203, 43);
            this.LabelIdFialis.Name = "LabelIdFialis";
            this.LabelIdFialis.Size = new System.Drawing.Size(46, 16);
            this.LabelIdFialis.TabIndex = 110;
            this.LabelIdFialis.Text = "label2";
            // 
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aimodotesBindingSource
            // 
            this.aimodotesBindingSource.DataMember = "Aimodotes";
            this.aimodotesBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // aimodotesTableAdapter
            // 
            this.aimodotesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = this.aimodotesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = this.fialesTableAdapter1;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // fialesTableAdapter1
            // 
            this.fialesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnEditFialiSave
            // 
            this.btnEditFialiSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditFialiSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFialiSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEditFialiSave.Image = global::Ptuxiaki.Properties.Resources._1300790450_3floppy_unmount;
            this.btnEditFialiSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFialiSave.Location = new System.Drawing.Point(166, 393);
            this.btnEditFialiSave.Name = "btnEditFialiSave";
            this.btnEditFialiSave.Size = new System.Drawing.Size(173, 39);
            this.btnEditFialiSave.TabIndex = 61;
            this.btnEditFialiSave.Text = "Αποθήκευση";
            this.btnEditFialiSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditFialiSave.UseVisualStyleBackColor = true;
            this.btnEditFialiSave.Click += new System.EventHandler(this.btnEditFialiSave_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(480, 405);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(33, 27);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 62;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // fialesBindingSource
            // 
            this.fialesBindingSource.DataMember = "Fiales";
            this.fialesBindingSource.DataSource = this.ptuxiakiDatabaseDataSet1;
            // 
            // FormFindFialiFromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 452);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.btnEditFialiSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFindFialiFromMain";
            this.Text = "Επεξεργασία Φιάλης © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormFindFialiFromMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewFiales;
        private System.Windows.Forms.ToolStripMenuItem ViewAimodotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxKatastasi;
        private System.Windows.Forms.Label labelDateAimodosias;
        private System.Windows.Forms.Label labelLastNameAimodoti;
        private System.Windows.Forms.Label labelNameAimodoti;
        private System.Windows.Forms.Label LabelIdFialis;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource aimodotesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter1;
        private System.Windows.Forms.Label labelKathgoriaAimodosias;
        private System.Windows.Forms.Button btnEditFialiSave;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.BindingSource fialesBindingSource;
    }
}