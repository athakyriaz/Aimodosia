namespace Ptuxiaki
{
    partial class FormNewXorigisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewXorigisi));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.αρχείοToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.προβολήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewXorigiseisFull = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewFialesFUll = new System.Windows.Forms.ToolStripMenuItem();
            this.ptuxiakiDatabaseDataSet11 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.xorigiseisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xorigiseisTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.XorigiseisTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.btnXorigisiFialis = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateXorigisis = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLNameDoctor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFNameDoctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSymbatotita = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLNameAstheni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFNameAstheni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKliniki = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKwdikosFialis = new System.Windows.Forms.TextBox();
            this.LabelAstheniName = new System.Windows.Forms.Label();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xorigiseisBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.αρχείοToolStripMenuItem,
            this.προβολήToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 86;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // αρχείοToolStripMenuItem
            // 
            this.αρχείοToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseMenuStrip});
            this.αρχείοToolStripMenuItem.Name = "αρχείοToolStripMenuItem";
            this.αρχείοToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.αρχείοToolStripMenuItem.Text = "Αρχείο";
            // 
            // CloseMenuStrip
            // 
            this.CloseMenuStrip.Image = global::Ptuxiaki.Properties.Resources._1301512519_fileclose1;
            this.CloseMenuStrip.Name = "CloseMenuStrip";
            this.CloseMenuStrip.Size = new System.Drawing.Size(119, 22);
            this.CloseMenuStrip.Text = "Κλείσιμο";
            this.CloseMenuStrip.Click += new System.EventHandler(this.CloseMenuStrip_Click);
            // 
            // προβολήToolStripMenuItem
            // 
            this.προβολήToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewXorigiseisFull,
            this.ViewFialesFUll});
            this.προβολήToolStripMenuItem.Name = "προβολήToolStripMenuItem";
            this.προβολήToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.προβολήToolStripMenuItem.Text = "Προβολή";
            // 
            // ViewXorigiseisFull
            // 
            this.ViewXorigiseisFull.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.ViewXorigiseisFull.Name = "ViewXorigiseisFull";
            this.ViewXorigiseisFull.Size = new System.Drawing.Size(197, 22);
            this.ViewXorigiseisFull.Text = "Προβολή Χορηγήσεων";
            this.ViewXorigiseisFull.Click += new System.EventHandler(this.ViewXorigiseisFull_Click);
            // 
            // ViewFialesFUll
            // 
            this.ViewFialesFUll.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.ViewFialesFUll.Name = "ViewFialesFUll";
            this.ViewFialesFUll.Size = new System.Drawing.Size(197, 22);
            this.ViewFialesFUll.Text = "Προβολή Φιαλών";
            this.ViewFialesFUll.Click += new System.EventHandler(this.ViewFialesFUll_Click);
            // 
            // ptuxiakiDatabaseDataSet11
            // 
            this.ptuxiakiDatabaseDataSet11.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // xorigiseisBindingSource
            // 
            this.xorigiseisBindingSource.DataMember = "Xorigiseis";
            this.xorigiseisBindingSource.DataSource = this.ptuxiakiDatabaseDataSet11;
            // 
            // xorigiseisTableAdapter
            // 
            this.xorigiseisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AimodotesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FialesTableAdapter = null;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XorigiseisTableAdapter = this.xorigiseisTableAdapter;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // btnXorigisiFialis
            // 
            this.btnXorigisiFialis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXorigisiFialis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXorigisiFialis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnXorigisiFialis.Image = global::Ptuxiaki.Properties.Resources._1317237432_old_edit_undo;
            this.btnXorigisiFialis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXorigisiFialis.Location = new System.Drawing.Point(145, 460);
            this.btnXorigisiFialis.Name = "btnXorigisiFialis";
            this.btnXorigisiFialis.Size = new System.Drawing.Size(136, 39);
            this.btnXorigisiFialis.TabIndex = 89;
            this.btnXorigisiFialis.Text = "Χορήγηση";
            this.btnXorigisiFialis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXorigisiFialis.UseVisualStyleBackColor = true;
            this.btnXorigisiFialis.Click += new System.EventHandler(this.btnXorigisiFialis_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateXorigisis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxLNameDoctor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxFNameDoctor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxSymbatotita);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLNameAstheni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxFNameAstheni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKliniki);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxKwdikosFialis);
            this.groupBox1.Controls.Add(this.LabelAstheniName);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 403);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Διασταύρωση Φιάλης";
            // 
            // dateXorigisis
            // 
            this.dateXorigisis.Location = new System.Drawing.Point(199, 355);
            this.dateXorigisis.Name = "dateXorigisis";
            this.dateXorigisis.Size = new System.Drawing.Size(200, 22);
            this.dateXorigisis.TabIndex = 104;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(32, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 103;
            this.label7.Text = "Ημ/νία Χορήγησης :";
            // 
            // textBoxLNameDoctor
            // 
            this.textBoxLNameDoctor.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxLNameDoctor.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxLNameDoctor.Location = new System.Drawing.Point(199, 301);
            this.textBoxLNameDoctor.Name = "textBoxLNameDoctor";
            this.textBoxLNameDoctor.Size = new System.Drawing.Size(185, 23);
            this.textBoxLNameDoctor.TabIndex = 102;
            this.textBoxLNameDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(50, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 18);
            this.label6.TabIndex = 101;
            this.label6.Text = "Επώνυμο Ιατρού :";
            // 
            // textBoxFNameDoctor
            // 
            this.textBoxFNameDoctor.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxFNameDoctor.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxFNameDoctor.Location = new System.Drawing.Point(199, 257);
            this.textBoxFNameDoctor.Name = "textBoxFNameDoctor";
            this.textBoxFNameDoctor.Size = new System.Drawing.Size(185, 23);
            this.textBoxFNameDoctor.TabIndex = 100;
            this.textBoxFNameDoctor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(50, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 99;
            this.label5.Text = "Όνομα Ιατρού :";
            // 
            // textBoxSymbatotita
            // 
            this.textBoxSymbatotita.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxSymbatotita.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxSymbatotita.Location = new System.Drawing.Point(199, 213);
            this.textBoxSymbatotita.Name = "textBoxSymbatotita";
            this.textBoxSymbatotita.Size = new System.Drawing.Size(185, 23);
            this.textBoxSymbatotita.TabIndex = 98;
            this.textBoxSymbatotita.Text = "Συμβατή";
            this.textBoxSymbatotita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(50, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 97;
            this.label4.Text = "Συμβατότητα :";
            // 
            // textBoxLNameAstheni
            // 
            this.textBoxLNameAstheni.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxLNameAstheni.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxLNameAstheni.Location = new System.Drawing.Point(199, 167);
            this.textBoxLNameAstheni.Name = "textBoxLNameAstheni";
            this.textBoxLNameAstheni.Size = new System.Drawing.Size(185, 23);
            this.textBoxLNameAstheni.TabIndex = 96;
            this.textBoxLNameAstheni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 95;
            this.label3.Text = "Επώνυμο Ασθενή :";
            // 
            // textBoxFNameAstheni
            // 
            this.textBoxFNameAstheni.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxFNameAstheni.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxFNameAstheni.Location = new System.Drawing.Point(199, 123);
            this.textBoxFNameAstheni.Name = "textBoxFNameAstheni";
            this.textBoxFNameAstheni.Size = new System.Drawing.Size(185, 23);
            this.textBoxFNameAstheni.TabIndex = 94;
            this.textBoxFNameAstheni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(50, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 93;
            this.label2.Text = "Όνομα Ασθενή :";
            // 
            // textBoxKliniki
            // 
            this.textBoxKliniki.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxKliniki.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxKliniki.Location = new System.Drawing.Point(199, 75);
            this.textBoxKliniki.Name = "textBoxKliniki";
            this.textBoxKliniki.Size = new System.Drawing.Size(185, 23);
            this.textBoxKliniki.TabIndex = 92;
            this.textBoxKliniki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 91;
            this.label1.Text = "Κλινική :";
            // 
            // textBoxKwdikosFialis
            // 
            this.textBoxKwdikosFialis.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxKwdikosFialis.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxKwdikosFialis.Location = new System.Drawing.Point(199, 27);
            this.textBoxKwdikosFialis.Name = "textBoxKwdikosFialis";
            this.textBoxKwdikosFialis.Size = new System.Drawing.Size(185, 23);
            this.textBoxKwdikosFialis.TabIndex = 90;
            this.textBoxKwdikosFialis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAstheniName
            // 
            this.LabelAstheniName.AutoSize = true;
            this.LabelAstheniName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LabelAstheniName.Location = new System.Drawing.Point(50, 28);
            this.LabelAstheniName.Name = "LabelAstheniName";
            this.LabelAstheniName.Size = new System.Drawing.Size(137, 18);
            this.LabelAstheniName.TabIndex = 89;
            this.LabelAstheniName.Text = "Κωδικός Φιάλης :";
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(416, 479);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(29, 25);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 91;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // FormNewXorigisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 511);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnXorigisiFialis);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormNewXorigisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Διασταύρωση - Χορήγηση Φιάλης © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormNewXorigisi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xorigiseisBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem αρχείοToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuStrip;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet11;
        private System.Windows.Forms.BindingSource xorigiseisBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.XorigiseisTableAdapter xorigiseisTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnXorigisiFialis;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateXorigisis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLNameDoctor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFNameDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSymbatotita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLNameAstheni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFNameAstheni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKliniki;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKwdikosFialis;
        private System.Windows.Forms.Label LabelAstheniName;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.ToolStripMenuItem προβολήToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewXorigiseisFull;
        private System.Windows.Forms.ToolStripMenuItem ViewFialesFUll;
    }
}