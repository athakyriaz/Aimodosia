namespace Ptuxiaki
{
    partial class FormFindSyllogoFromMain
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
            System.Windows.Forms.Label iD_SyllogouLabel;
            System.Windows.Forms.Label onoma_SyllogouLabel;
            System.Windows.Forms.Label onoma_ProedrouLabel;
            System.Windows.Forms.Label eponumo_ProedrouLabel;
            System.Windows.Forms.Label num_FialesLabel;
            System.Windows.Forms.Label date_IdrisisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindSyllogoFromMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNameSyllogou = new System.Windows.Forms.Label();
            this.labelDateIdrisis = new System.Windows.Forms.Label();
            this.labelNumFuales = new System.Windows.Forms.Label();
            this.labelLastNameProedrou = new System.Windows.Forms.Label();
            this.labelNameProedrou = new System.Windows.Forms.Label();
            this.labelIdSyllogoy = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullViewSullogoi = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSullogoi = new System.Windows.Forms.ToolStripMenuItem();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            iD_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_ProedrouLabel = new System.Windows.Forms.Label();
            eponumo_ProedrouLabel = new System.Windows.Forms.Label();
            num_FialesLabel = new System.Windows.Forms.Label();
            date_IdrisisLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_SyllogouLabel
            // 
            iD_SyllogouLabel.AutoSize = true;
            iD_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            iD_SyllogouLabel.Location = new System.Drawing.Point(62, 51);
            iD_SyllogouLabel.Name = "iD_SyllogouLabel";
            iD_SyllogouLabel.Size = new System.Drawing.Size(111, 18);
            iD_SyllogouLabel.TabIndex = 17;
            iD_SyllogouLabel.Text = "ID Συλλόγου :";
            // 
            // onoma_SyllogouLabel
            // 
            onoma_SyllogouLabel.AutoSize = true;
            onoma_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            onoma_SyllogouLabel.Location = new System.Drawing.Point(62, 84);
            onoma_SyllogouLabel.Name = "onoma_SyllogouLabel";
            onoma_SyllogouLabel.Size = new System.Drawing.Size(143, 18);
            onoma_SyllogouLabel.TabIndex = 18;
            onoma_SyllogouLabel.Text = "Όνομα Συλλόγου :";
            // 
            // onoma_ProedrouLabel
            // 
            onoma_ProedrouLabel.AutoSize = true;
            onoma_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            onoma_ProedrouLabel.Location = new System.Drawing.Point(62, 115);
            onoma_ProedrouLabel.Name = "onoma_ProedrouLabel";
            onoma_ProedrouLabel.Size = new System.Drawing.Size(144, 18);
            onoma_ProedrouLabel.TabIndex = 19;
            onoma_ProedrouLabel.Text = "Όνομα Προέδρου :";
            // 
            // eponumo_ProedrouLabel
            // 
            eponumo_ProedrouLabel.AutoSize = true;
            eponumo_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            eponumo_ProedrouLabel.Location = new System.Drawing.Point(62, 149);
            eponumo_ProedrouLabel.Name = "eponumo_ProedrouLabel";
            eponumo_ProedrouLabel.Size = new System.Drawing.Size(160, 18);
            eponumo_ProedrouLabel.TabIndex = 20;
            eponumo_ProedrouLabel.Text = "Επώνυμο Συλλόγου :";
            // 
            // num_FialesLabel
            // 
            num_FialesLabel.AutoSize = true;
            num_FialesLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            num_FialesLabel.Location = new System.Drawing.Point(62, 185);
            num_FialesLabel.Name = "num_FialesLabel";
            num_FialesLabel.Size = new System.Drawing.Size(138, 18);
            num_FialesLabel.TabIndex = 21;
            num_FialesLabel.Text = "Αριθμός Φιάλων :";
            // 
            // date_IdrisisLabel
            // 
            date_IdrisisLabel.AutoSize = true;
            date_IdrisisLabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold);
            date_IdrisisLabel.Location = new System.Drawing.Point(62, 222);
            date_IdrisisLabel.Name = "date_IdrisisLabel";
            date_IdrisisLabel.Size = new System.Drawing.Size(176, 18);
            date_IdrisisLabel.TabIndex = 22;
            date_IdrisisLabel.Text = "Ημερομηνία Ίδρυσης : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNameSyllogou);
            this.groupBox1.Controls.Add(this.labelDateIdrisis);
            this.groupBox1.Controls.Add(this.labelNumFuales);
            this.groupBox1.Controls.Add(this.labelLastNameProedrou);
            this.groupBox1.Controls.Add(this.labelNameProedrou);
            this.groupBox1.Controls.Add(this.labelIdSyllogoy);
            this.groupBox1.Controls.Add(iD_SyllogouLabel);
            this.groupBox1.Controls.Add(onoma_SyllogouLabel);
            this.groupBox1.Controls.Add(onoma_ProedrouLabel);
            this.groupBox1.Controls.Add(eponumo_ProedrouLabel);
            this.groupBox1.Controls.Add(num_FialesLabel);
            this.groupBox1.Controls.Add(date_IdrisisLabel);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Στοιχεία Συλλόγου";
            // 
            // labelNameSyllogou
            // 
            this.labelNameSyllogou.AutoSize = true;
            this.labelNameSyllogou.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameSyllogou.ForeColor = System.Drawing.Color.Maroon;
            this.labelNameSyllogou.Location = new System.Drawing.Point(267, 86);
            this.labelNameSyllogou.Name = "labelNameSyllogou";
            this.labelNameSyllogou.Size = new System.Drawing.Size(46, 16);
            this.labelNameSyllogou.TabIndex = 28;
            this.labelNameSyllogou.Text = "label6";
            // 
            // labelDateIdrisis
            // 
            this.labelDateIdrisis.AutoSize = true;
            this.labelDateIdrisis.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelDateIdrisis.ForeColor = System.Drawing.Color.Maroon;
            this.labelDateIdrisis.Location = new System.Drawing.Point(267, 224);
            this.labelDateIdrisis.Name = "labelDateIdrisis";
            this.labelDateIdrisis.Size = new System.Drawing.Size(46, 16);
            this.labelDateIdrisis.TabIndex = 27;
            this.labelDateIdrisis.Text = "label5";
            // 
            // labelNumFuales
            // 
            this.labelNumFuales.AutoSize = true;
            this.labelNumFuales.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNumFuales.ForeColor = System.Drawing.Color.Maroon;
            this.labelNumFuales.Location = new System.Drawing.Point(267, 187);
            this.labelNumFuales.Name = "labelNumFuales";
            this.labelNumFuales.Size = new System.Drawing.Size(46, 16);
            this.labelNumFuales.TabIndex = 26;
            this.labelNumFuales.Text = "label4";
            // 
            // labelLastNameProedrou
            // 
            this.labelLastNameProedrou.AutoSize = true;
            this.labelLastNameProedrou.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelLastNameProedrou.ForeColor = System.Drawing.Color.Maroon;
            this.labelLastNameProedrou.Location = new System.Drawing.Point(267, 151);
            this.labelLastNameProedrou.Name = "labelLastNameProedrou";
            this.labelLastNameProedrou.Size = new System.Drawing.Size(46, 16);
            this.labelLastNameProedrou.TabIndex = 25;
            this.labelLastNameProedrou.Text = "label3";
            // 
            // labelNameProedrou
            // 
            this.labelNameProedrou.AutoSize = true;
            this.labelNameProedrou.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelNameProedrou.ForeColor = System.Drawing.Color.Maroon;
            this.labelNameProedrou.Location = new System.Drawing.Point(267, 117);
            this.labelNameProedrou.Name = "labelNameProedrou";
            this.labelNameProedrou.Size = new System.Drawing.Size(46, 16);
            this.labelNameProedrou.TabIndex = 24;
            this.labelNameProedrou.Text = "label2";
            // 
            // labelIdSyllogoy
            // 
            this.labelIdSyllogoy.AutoSize = true;
            this.labelIdSyllogoy.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelIdSyllogoy.ForeColor = System.Drawing.Color.Maroon;
            this.labelIdSyllogoy.Location = new System.Drawing.Point(267, 53);
            this.labelIdSyllogoy.Name = "labelIdSyllogoy";
            this.labelIdSyllogoy.Size = new System.Drawing.Size(46, 16);
            this.labelIdSyllogoy.TabIndex = 23;
            this.labelIdSyllogoy.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 1;
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
            this.exitToolStripMenuItem.Image = global::Ptuxiaki.Properties.Resources._1301512519_fileclose;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Κλείσιμο";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.FullViewSullogoi.Size = new System.Drawing.Size(160, 22);
            this.FullViewSullogoi.Text = "Προβολή Όλων";
            this.FullViewSullogoi.Click += new System.EventHandler(this.FullViewSullogoi_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditSullogoi});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.editToolStripMenuItem.Text = "Επεξεργασία";
            // 
            // EditSullogoi
            // 
            this.EditSullogoi.Image = global::Ptuxiaki.Properties.Resources._1301088130_system_software_update;
            this.EditSullogoi.Name = "EditSullogoi";
            this.EditSullogoi.Size = new System.Drawing.Size(189, 22);
            this.EditSullogoi.Text = "Διόρθωση Συλλόγων";
            this.EditSullogoi.Click += new System.EventHandler(this.EditSullogoi_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(476, 348);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(39, 36);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 71;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // FormFindSyllogoFromMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 396);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFindSyllogoFromMain";
            this.Text = "Στοιχεία Συλλόγου © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormFindSyllogoFromMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNameSyllogou;
        private System.Windows.Forms.Label labelDateIdrisis;
        private System.Windows.Forms.Label labelNumFuales;
        private System.Windows.Forms.Label labelLastNameProedrou;
        private System.Windows.Forms.Label labelNameProedrou;
        private System.Windows.Forms.Label labelIdSyllogoy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullViewSullogoi;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditSullogoi;
    }
}