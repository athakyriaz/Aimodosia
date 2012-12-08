namespace Ptuxiaki
{
    partial class FormXrewshFuallis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXrewshFuallis));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonEthelontika = new System.Windows.Forms.RadioButton();
            this.radioButtonSyllogo = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullViewAimodotes = new System.Windows.Forms.ToolStripMenuItem();
            this.FullViewSullogos = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewXrewseis = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelDefaultAimodotis = new System.Windows.Forms.Label();
            this.pictureBoxSearchAimodoti = new System.Windows.Forms.PictureBox();
            this.TextBoxSearchAimodoti = new System.Windows.Forms.TextBox();
            this.pictureBoxAddAimodoti = new System.Windows.Forms.PictureBox();
            this.labelSyllogos = new System.Windows.Forms.Label();
            this.pictureBoxSearchSyllogo = new System.Windows.Forms.PictureBox();
            this.textBoxSearchSyllogo = new System.Windows.Forms.TextBox();
            this.pictureBoxAddSyllogo = new System.Windows.Forms.PictureBox();
            this.labelDefaultSyllogos = new System.Windows.Forms.Label();
            this.ptuxiakiDatabaseDataSet11 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.aimodotesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.fialesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            this.syllogoiTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.tableAdapterManager1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.labelAimodotis = new System.Windows.Forms.Label();
            this.btnXrewsiFialis = new System.Windows.Forms.Button();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.labelFialesText = new System.Windows.Forms.Label();
            this.labelFialesDiathNum = new System.Windows.Forms.Label();
            this.FialesXrewshText = new System.Windows.Forms.Label();
            this.textBoxNumFialesXrewsh = new System.Windows.Forms.TextBox();
            this.LabelAstheniName = new System.Windows.Forms.Label();
            this.LabelAstheniLastName = new System.Windows.Forms.Label();
            this.LabelAstheniNosokomeio = new System.Windows.Forms.Label();
            this.textBoxAstheniName = new System.Windows.Forms.TextBox();
            this.textBoxAstheniLastName = new System.Windows.Forms.TextBox();
            this.textBoxNosokomeioAstheni = new System.Windows.Forms.TextBox();
            this.xrewshTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchAimodoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAimodoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSyllogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSyllogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEthelontika);
            this.groupBox1.Controls.Add(this.radioButtonSyllogo);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(63, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 75);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Κατηγορία Χρέωσης";
            // 
            // radioButtonEthelontika
            // 
            this.radioButtonEthelontika.AutoSize = true;
            this.radioButtonEthelontika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEthelontika.Location = new System.Drawing.Point(57, 35);
            this.radioButtonEthelontika.Name = "radioButtonEthelontika";
            this.radioButtonEthelontika.Size = new System.Drawing.Size(121, 22);
            this.radioButtonEthelontika.TabIndex = 7;
            this.radioButtonEthelontika.TabStop = true;
            this.radioButtonEthelontika.Text = "Από Εθελοντή";
            this.radioButtonEthelontika.UseVisualStyleBackColor = true;
            this.radioButtonEthelontika.CheckedChanged += new System.EventHandler(this.radioButtonEthelontika_CheckedChanged);
            // 
            // radioButtonSyllogo
            // 
            this.radioButtonSyllogo.AutoSize = true;
            this.radioButtonSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSyllogo.Location = new System.Drawing.Point(281, 35);
            this.radioButtonSyllogo.Name = "radioButtonSyllogo";
            this.radioButtonSyllogo.Size = new System.Drawing.Size(115, 22);
            this.radioButtonSyllogo.TabIndex = 8;
            this.radioButtonSyllogo.TabStop = true;
            this.radioButtonSyllogo.Text = "Από Σύλλογο";
            this.radioButtonSyllogo.UseVisualStyleBackColor = true;
            this.radioButtonSyllogo.CheckedChanged += new System.EventHandler(this.radioButtonSyllogo_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 12;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Κλείσιμο";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullViewAimodotes,
            this.FullViewSullogos,
            this.ViewXrewseis});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // FullViewAimodotes
            // 
            this.FullViewAimodotes.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.FullViewAimodotes.Name = "FullViewAimodotes";
            this.FullViewAimodotes.Size = new System.Drawing.Size(189, 22);
            this.FullViewAimodotes.Text = "Προβολή Αιμοδοτών";
            this.FullViewAimodotes.Click += new System.EventHandler(this.FullViewAimodotes_Click);
            // 
            // FullViewSullogos
            // 
            this.FullViewSullogos.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.FullViewSullogos.Name = "FullViewSullogos";
            this.FullViewSullogos.Size = new System.Drawing.Size(189, 22);
            this.FullViewSullogos.Text = "Προβολή Συλλόγων";
            this.FullViewSullogos.Click += new System.EventHandler(this.FullViewSullogos_Click);
            // 
            // ViewXrewseis
            // 
            this.ViewXrewseis.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.ViewXrewseis.Name = "ViewXrewseis";
            this.ViewXrewseis.Size = new System.Drawing.Size(189, 22);
            this.ViewXrewseis.Text = "Προβολή Χρεώσεων";
            this.ViewXrewseis.Click += new System.EventHandler(this.ViewXrewseis_Click);
            // 
            // LabelDefaultAimodotis
            // 
            this.LabelDefaultAimodotis.AutoSize = true;
            this.LabelDefaultAimodotis.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDefaultAimodotis.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelDefaultAimodotis.Location = new System.Drawing.Point(196, 152);
            this.LabelDefaultAimodotis.Name = "LabelDefaultAimodotis";
            this.LabelDefaultAimodotis.Size = new System.Drawing.Size(46, 18);
            this.LabelDefaultAimodotis.TabIndex = 17;
            this.LabelDefaultAimodotis.Text = " - - - ";
            // 
            // pictureBoxSearchAimodoti
            // 
            this.pictureBoxSearchAimodoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearchAimodoti.Image = global::Ptuxiaki.Properties.Resources.search;
            this.pictureBoxSearchAimodoti.Location = new System.Drawing.Point(403, 142);
            this.pictureBoxSearchAimodoti.Name = "pictureBoxSearchAimodoti";
            this.pictureBoxSearchAimodoti.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSearchAimodoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchAimodoti.TabIndex = 16;
            this.pictureBoxSearchAimodoti.TabStop = false;
            this.pictureBoxSearchAimodoti.Click += new System.EventHandler(this.pictureBoxSearchAimodoti_Click);
            // 
            // TextBoxSearchAimodoti
            // 
            this.TextBoxSearchAimodoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchAimodoti.Location = new System.Drawing.Point(241, 149);
            this.TextBoxSearchAimodoti.Name = "TextBoxSearchAimodoti";
            this.TextBoxSearchAimodoti.Size = new System.Drawing.Size(156, 24);
            this.TextBoxSearchAimodoti.TabIndex = 15;
            this.TextBoxSearchAimodoti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchAimodoti_KeyPress);
            // 
            // pictureBoxAddAimodoti
            // 
            this.pictureBoxAddAimodoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddAimodoti.Image = global::Ptuxiaki.Properties.Resources._1313244897_1;
            this.pictureBoxAddAimodoti.Location = new System.Drawing.Point(27, 142);
            this.pictureBoxAddAimodoti.Name = "pictureBoxAddAimodoti";
            this.pictureBoxAddAimodoti.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxAddAimodoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddAimodoti.TabIndex = 14;
            this.pictureBoxAddAimodoti.TabStop = false;
            this.pictureBoxAddAimodoti.Click += new System.EventHandler(this.pictureBoxAddAimodoti_Click);
            // 
            // labelSyllogos
            // 
            this.labelSyllogos.AutoSize = true;
            this.labelSyllogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelSyllogos.Location = new System.Drawing.Point(75, 148);
            this.labelSyllogos.Name = "labelSyllogos";
            this.labelSyllogos.Size = new System.Drawing.Size(115, 24);
            this.labelSyllogos.TabIndex = 59;
            this.labelSyllogos.Text = "Σύλλογος :";
            // 
            // pictureBoxSearchSyllogo
            // 
            this.pictureBoxSearchSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearchSyllogo.Image = global::Ptuxiaki.Properties.Resources.search;
            this.pictureBoxSearchSyllogo.Location = new System.Drawing.Point(403, 142);
            this.pictureBoxSearchSyllogo.Name = "pictureBoxSearchSyllogo";
            this.pictureBoxSearchSyllogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSearchSyllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchSyllogo.TabIndex = 58;
            this.pictureBoxSearchSyllogo.TabStop = false;
            this.pictureBoxSearchSyllogo.Click += new System.EventHandler(this.pictureBoxSearchSyllogo_Click);
            // 
            // textBoxSearchSyllogo
            // 
            this.textBoxSearchSyllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSyllogo.Location = new System.Drawing.Point(241, 148);
            this.textBoxSearchSyllogo.Name = "textBoxSearchSyllogo";
            this.textBoxSearchSyllogo.Size = new System.Drawing.Size(156, 24);
            this.textBoxSearchSyllogo.TabIndex = 57;
            this.textBoxSearchSyllogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchSyllogo_KeyPress);
            // 
            // pictureBoxAddSyllogo
            // 
            this.pictureBoxAddSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddSyllogo.Image = global::Ptuxiaki.Properties.Resources._1313244897_1;
            this.pictureBoxAddSyllogo.Location = new System.Drawing.Point(27, 142);
            this.pictureBoxAddSyllogo.Name = "pictureBoxAddSyllogo";
            this.pictureBoxAddSyllogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxAddSyllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddSyllogo.TabIndex = 56;
            this.pictureBoxAddSyllogo.TabStop = false;
            this.pictureBoxAddSyllogo.Click += new System.EventHandler(this.pictureBoxAddSyllogo_Click);
            // 
            // labelDefaultSyllogos
            // 
            this.labelDefaultSyllogos.AutoSize = true;
            this.labelDefaultSyllogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDefaultSyllogos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelDefaultSyllogos.Location = new System.Drawing.Point(196, 152);
            this.labelDefaultSyllogos.Name = "labelDefaultSyllogos";
            this.labelDefaultSyllogos.Size = new System.Drawing.Size(46, 18);
            this.labelDefaultSyllogos.TabIndex = 60;
            this.labelDefaultSyllogos.Text = " - - - ";
            // 
            // ptuxiakiDatabaseDataSet11
            // 
            this.ptuxiakiDatabaseDataSet11.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aimodotesTableAdapter1
            // 
            this.aimodotesTableAdapter1.ClearBeforeFill = true;
            // 
            // fialesTableAdapter1
            // 
            this.fialesTableAdapter1.ClearBeforeFill = true;
            // 
            // syllogoiTableAdapter1
            // 
            this.syllogoiTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AimodotesTableAdapter = this.aimodotesTableAdapter1;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.FialesTableAdapter = this.fialesTableAdapter1;
            this.tableAdapterManager1.IstorikoTableAdapter = null;
            this.tableAdapterManager1.SyllogoiTableAdapter = this.syllogoiTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.XorigiseisTableAdapter = null;
            this.tableAdapterManager1.XrewshTableAdapter = null;
            // 
            // labelAimodotis
            // 
            this.labelAimodotis.AutoSize = true;
            this.labelAimodotis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAimodotis.Location = new System.Drawing.Point(75, 148);
            this.labelAimodotis.Name = "labelAimodotis";
            this.labelAimodotis.Size = new System.Drawing.Size(125, 24);
            this.labelAimodotis.TabIndex = 61;
            this.labelAimodotis.Text = "Αιμοδότης :";
            // 
            // btnXrewsiFialis
            // 
            this.btnXrewsiFialis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXrewsiFialis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXrewsiFialis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXrewsiFialis.Image = global::Ptuxiaki.Properties.Resources._1316450423_Orb_minus;
            this.btnXrewsiFialis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXrewsiFialis.Location = new System.Drawing.Point(235, 476);
            this.btnXrewsiFialis.Name = "btnXrewsiFialis";
            this.btnXrewsiFialis.Size = new System.Drawing.Size(136, 39);
            this.btnXrewsiFialis.TabIndex = 62;
            this.btnXrewsiFialis.Text = "Χρέωση";
            this.btnXrewsiFialis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXrewsiFialis.UseVisualStyleBackColor = true;
            this.btnXrewsiFialis.Click += new System.EventHandler(this.btnXrewsiFialis_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(589, 483);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(40, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 63;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // labelFialesText
            // 
            this.labelFialesText.AutoSize = true;
            this.labelFialesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelFialesText.Location = new System.Drawing.Point(88, 201);
            this.labelFialesText.Name = "labelFialesText";
            this.labelFialesText.Size = new System.Drawing.Size(172, 20);
            this.labelFialesText.TabIndex = 64;
            this.labelFialesText.Text = "Διαθέσιμες Φιάλες :";
            // 
            // labelFialesDiathNum
            // 
            this.labelFialesDiathNum.AutoSize = true;
            this.labelFialesDiathNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelFialesDiathNum.ForeColor = System.Drawing.Color.Maroon;
            this.labelFialesDiathNum.Location = new System.Drawing.Point(266, 202);
            this.labelFialesDiathNum.Name = "labelFialesDiathNum";
            this.labelFialesDiathNum.Size = new System.Drawing.Size(15, 20);
            this.labelFialesDiathNum.TabIndex = 65;
            this.labelFialesDiathNum.Text = "-";
            // 
            // FialesXrewshText
            // 
            this.FialesXrewshText.AutoSize = true;
            this.FialesXrewshText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FialesXrewshText.Location = new System.Drawing.Point(89, 244);
            this.FialesXrewshText.Name = "FialesXrewshText";
            this.FialesXrewshText.Size = new System.Drawing.Size(242, 20);
            this.FialesXrewshText.TabIndex = 66;
            this.FialesXrewshText.Text = "Αριθμός Φιαλών για Χρέωση :";
            // 
            // textBoxNumFialesXrewsh
            // 
            this.textBoxNumFialesXrewsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxNumFialesXrewsh.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxNumFialesXrewsh.Location = new System.Drawing.Point(337, 241);
            this.textBoxNumFialesXrewsh.Name = "textBoxNumFialesXrewsh";
            this.textBoxNumFialesXrewsh.Size = new System.Drawing.Size(58, 26);
            this.textBoxNumFialesXrewsh.TabIndex = 67;
            this.textBoxNumFialesXrewsh.Text = "0";
            this.textBoxNumFialesXrewsh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelAstheniName
            // 
            this.LabelAstheniName.AutoSize = true;
            this.LabelAstheniName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelAstheniName.Location = new System.Drawing.Point(88, 298);
            this.LabelAstheniName.Name = "LabelAstheniName";
            this.LabelAstheniName.Size = new System.Drawing.Size(135, 20);
            this.LabelAstheniName.TabIndex = 68;
            this.LabelAstheniName.Text = "Όνομα Ασθενή :";
            // 
            // LabelAstheniLastName
            // 
            this.LabelAstheniLastName.AutoSize = true;
            this.LabelAstheniLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelAstheniLastName.Location = new System.Drawing.Point(88, 346);
            this.LabelAstheniLastName.Name = "LabelAstheniLastName";
            this.LabelAstheniLastName.Size = new System.Drawing.Size(153, 20);
            this.LabelAstheniLastName.TabIndex = 69;
            this.LabelAstheniLastName.Text = "Επώνυμο Ασθενή :";
            // 
            // LabelAstheniNosokomeio
            // 
            this.LabelAstheniNosokomeio.AutoSize = true;
            this.LabelAstheniNosokomeio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LabelAstheniNosokomeio.Location = new System.Drawing.Point(88, 398);
            this.LabelAstheniNosokomeio.Name = "LabelAstheniNosokomeio";
            this.LabelAstheniNosokomeio.Size = new System.Drawing.Size(178, 20);
            this.LabelAstheniNosokomeio.TabIndex = 70;
            this.LabelAstheniNosokomeio.Text = "Νοσοκομείο Ασθενή :";
            // 
            // textBoxAstheniName
            // 
            this.textBoxAstheniName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxAstheniName.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxAstheniName.Location = new System.Drawing.Point(272, 295);
            this.textBoxAstheniName.Name = "textBoxAstheniName";
            this.textBoxAstheniName.Size = new System.Drawing.Size(203, 22);
            this.textBoxAstheniName.TabIndex = 71;
            this.textBoxAstheniName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAstheniLastName
            // 
            this.textBoxAstheniLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxAstheniLastName.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxAstheniLastName.Location = new System.Drawing.Point(272, 343);
            this.textBoxAstheniLastName.Name = "textBoxAstheniLastName";
            this.textBoxAstheniLastName.Size = new System.Drawing.Size(203, 22);
            this.textBoxAstheniLastName.TabIndex = 72;
            this.textBoxAstheniLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNosokomeioAstheni
            // 
            this.textBoxNosokomeioAstheni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxNosokomeioAstheni.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxNosokomeioAstheni.Location = new System.Drawing.Point(272, 395);
            this.textBoxNosokomeioAstheni.Name = "textBoxNosokomeioAstheni";
            this.textBoxNosokomeioAstheni.Size = new System.Drawing.Size(203, 22);
            this.textBoxNosokomeioAstheni.TabIndex = 73;
            this.textBoxNosokomeioAstheni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xrewshTableAdapter1
            // 
            this.xrewshTableAdapter1.ClearBeforeFill = true;
            // 
            // FormXrewshFuallis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 527);
            this.Controls.Add(this.textBoxNosokomeioAstheni);
            this.Controls.Add(this.textBoxAstheniLastName);
            this.Controls.Add(this.textBoxAstheniName);
            this.Controls.Add(this.LabelAstheniNosokomeio);
            this.Controls.Add(this.LabelAstheniLastName);
            this.Controls.Add(this.LabelAstheniName);
            this.Controls.Add(this.textBoxNumFialesXrewsh);
            this.Controls.Add(this.FialesXrewshText);
            this.Controls.Add(this.labelFialesDiathNum);
            this.Controls.Add(this.labelFialesText);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.btnXrewsiFialis);
            this.Controls.Add(this.labelAimodotis);
            this.Controls.Add(this.labelDefaultSyllogos);
            this.Controls.Add(this.labelSyllogos);
            this.Controls.Add(this.pictureBoxSearchSyllogo);
            this.Controls.Add(this.textBoxSearchSyllogo);
            this.Controls.Add(this.pictureBoxAddSyllogo);
            this.Controls.Add(this.LabelDefaultAimodotis);
            this.Controls.Add(this.pictureBoxSearchAimodoti);
            this.Controls.Add(this.TextBoxSearchAimodoti);
            this.Controls.Add(this.pictureBoxAddAimodoti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormXrewshFuallis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Χρέωση Φιάλης © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormXrewshFuallis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchAimodoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAimodoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSyllogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSyllogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonEthelontika;
        private System.Windows.Forms.RadioButton radioButtonSyllogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullViewAimodotes;
        private System.Windows.Forms.ToolStripMenuItem FullViewSullogos;
        private System.Windows.Forms.Label LabelDefaultAimodotis;
        private System.Windows.Forms.PictureBox pictureBoxSearchAimodoti;
        private System.Windows.Forms.TextBox TextBoxSearchAimodoti;
        private System.Windows.Forms.PictureBox pictureBoxAddAimodoti;
        private System.Windows.Forms.Label labelSyllogos;
        private System.Windows.Forms.PictureBox pictureBoxSearchSyllogo;
        private System.Windows.Forms.TextBox textBoxSearchSyllogo;
        private System.Windows.Forms.PictureBox pictureBoxAddSyllogo;
        private System.Windows.Forms.Label labelDefaultSyllogos;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet11;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label labelAimodotis;
        private System.Windows.Forms.Button btnXrewsiFialis;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label labelFialesText;
        private System.Windows.Forms.Label labelFialesDiathNum;
        private System.Windows.Forms.Label FialesXrewshText;
        private System.Windows.Forms.TextBox textBoxNumFialesXrewsh;
        private System.Windows.Forms.Label LabelAstheniName;
        private System.Windows.Forms.Label LabelAstheniLastName;
        private System.Windows.Forms.Label LabelAstheniNosokomeio;
        private System.Windows.Forms.TextBox textBoxAstheniName;
        private System.Windows.Forms.TextBox textBoxAstheniLastName;
        private System.Windows.Forms.TextBox textBoxNosokomeioAstheni;
        private PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter xrewshTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem ViewXrewseis;
    }
}