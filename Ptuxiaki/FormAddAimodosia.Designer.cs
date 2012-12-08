namespace Ptuxiaki
{
    partial class FormAddAimodosia
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
            System.Windows.Forms.Label iDaimodotiLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddAimodosia));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.fialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fialesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.pictureBoxAddAimodoti = new System.Windows.Forms.PictureBox();
            this.TextBoxSearchAimodoti = new System.Windows.Forms.TextBox();
            this.pictureBoxSearchAimodoti = new System.Windows.Forms.PictureBox();
            this.LabelAimodoti = new System.Windows.Forms.Label();
            this.aimodotesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.radioButtonEthelontika = new System.Windows.Forms.RadioButton();
            this.radioButtonSyllogo = new System.Windows.Forms.RadioButton();
            this.radioButtonAstheni = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.προβολήΙστορικούToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullViewAimodosia = new System.Windows.Forms.ToolStripMenuItem();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.labelSyllogos = new System.Windows.Forms.Label();
            this.pictureBoxSearchSyllogo = new System.Windows.Forms.PictureBox();
            this.textBoxSearchSyllogo = new System.Windows.Forms.TextBox();
            this.pictureBoxAddSyllogo = new System.Windows.Forms.PictureBox();
            this.syllogoiTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.textBoxNameAstheni = new System.Windows.Forms.TextBox();
            this.textBoxNosokomeioAstheni = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.istorikoTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.IstorikoTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddHistory = new System.Windows.Forms.PictureBox();
            this.btnSaveAimodosia = new System.Windows.Forms.Button();
            this.xrewshTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter();
            this.buttonApporipsi = new System.Windows.Forms.Button();
            iDaimodotiLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAimodoti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchAimodoti)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSyllogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSyllogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // iDaimodotiLabel
            // 
            iDaimodotiLabel.AutoSize = true;
            iDaimodotiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDaimodotiLabel.Location = new System.Drawing.Point(68, 52);
            iDaimodotiLabel.Name = "iDaimodotiLabel";
            iDaimodotiLabel.Size = new System.Drawing.Size(125, 24);
            iDaimodotiLabel.TabIndex = 1;
            iDaimodotiLabel.Text = "Αιμοδότης :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(23, 305);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(185, 22);
            label4.TabIndex = 54;
            label4.Text = "Ημ/νία Αιμοδοσίας :";
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
            this.tableAdapterManager.XorigiseisTableAdapter = null;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // pictureBoxAddAimodoti
            // 
            this.pictureBoxAddAimodoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddAimodoti.Image = global::Ptuxiaki.Properties.Resources._1313244897_1;
            this.pictureBoxAddAimodoti.Location = new System.Drawing.Point(27, 46);
            this.pictureBoxAddAimodoti.Name = "pictureBoxAddAimodoti";
            this.pictureBoxAddAimodoti.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxAddAimodoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddAimodoti.TabIndex = 3;
            this.pictureBoxAddAimodoti.TabStop = false;
            this.pictureBoxAddAimodoti.Click += new System.EventHandler(this.pictureBoxAddAimodoti_Click);
            // 
            // TextBoxSearchAimodoti
            // 
            this.TextBoxSearchAimodoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSearchAimodoti.Location = new System.Drawing.Point(241, 53);
            this.TextBoxSearchAimodoti.Name = "TextBoxSearchAimodoti";
            this.TextBoxSearchAimodoti.Size = new System.Drawing.Size(156, 24);
            this.TextBoxSearchAimodoti.TabIndex = 4;
            this.TextBoxSearchAimodoti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxSearchAimodoti_KeyPress);
            // 
            // pictureBoxSearchAimodoti
            // 
            this.pictureBoxSearchAimodoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearchAimodoti.Image = global::Ptuxiaki.Properties.Resources.search;
            this.pictureBoxSearchAimodoti.Location = new System.Drawing.Point(403, 46);
            this.pictureBoxSearchAimodoti.Name = "pictureBoxSearchAimodoti";
            this.pictureBoxSearchAimodoti.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSearchAimodoti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchAimodoti.TabIndex = 5;
            this.pictureBoxSearchAimodoti.TabStop = false;
            this.pictureBoxSearchAimodoti.Click += new System.EventHandler(this.pictureBoxSearchAimodoti_Click);
            // 
            // LabelAimodoti
            // 
            this.LabelAimodoti.AutoSize = true;
            this.LabelAimodoti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAimodoti.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelAimodoti.Location = new System.Drawing.Point(196, 56);
            this.LabelAimodoti.Name = "LabelAimodoti";
            this.LabelAimodoti.Size = new System.Drawing.Size(46, 18);
            this.LabelAimodoti.TabIndex = 6;
            this.LabelAimodoti.Text = " - - - ";
            // 
            // aimodotesTableAdapter1
            // 
            this.aimodotesTableAdapter1.ClearBeforeFill = true;
            // 
            // radioButtonEthelontika
            // 
            this.radioButtonEthelontika.AutoSize = true;
            this.radioButtonEthelontika.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonEthelontika.Location = new System.Drawing.Point(24, 35);
            this.radioButtonEthelontika.Name = "radioButtonEthelontika";
            this.radioButtonEthelontika.Size = new System.Drawing.Size(103, 22);
            this.radioButtonEthelontika.TabIndex = 7;
            this.radioButtonEthelontika.TabStop = true;
            this.radioButtonEthelontika.Text = "Εθελοντικά";
            this.radioButtonEthelontika.UseVisualStyleBackColor = true;
            this.radioButtonEthelontika.CheckedChanged += new System.EventHandler(this.radioButtonEthelontika_CheckedChanged);
            // 
            // radioButtonSyllogo
            // 
            this.radioButtonSyllogo.AutoSize = true;
            this.radioButtonSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonSyllogo.Location = new System.Drawing.Point(174, 35);
            this.radioButtonSyllogo.Name = "radioButtonSyllogo";
            this.radioButtonSyllogo.Size = new System.Drawing.Size(108, 22);
            this.radioButtonSyllogo.TabIndex = 8;
            this.radioButtonSyllogo.TabStop = true;
            this.radioButtonSyllogo.Text = "Για Σύλλογο";
            this.radioButtonSyllogo.UseVisualStyleBackColor = true;
            this.radioButtonSyllogo.CheckedChanged += new System.EventHandler(this.radioButtonSyllogo_CheckedChanged);
            // 
            // radioButtonAstheni
            // 
            this.radioButtonAstheni.AutoSize = true;
            this.radioButtonAstheni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonAstheni.Location = new System.Drawing.Point(341, 35);
            this.radioButtonAstheni.Name = "radioButtonAstheni";
            this.radioButtonAstheni.Size = new System.Drawing.Size(100, 22);
            this.radioButtonAstheni.TabIndex = 9;
            this.radioButtonAstheni.TabStop = true;
            this.radioButtonAstheni.Text = "Για Ασθενή";
            this.radioButtonAstheni.UseVisualStyleBackColor = true;
            this.radioButtonAstheni.CheckedChanged += new System.EventHandler(this.radioButtonAstheni_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonEthelontika);
            this.groupBox1.Controls.Add(this.radioButtonAstheni);
            this.groupBox1.Controls.Add(this.radioButtonSyllogo);
            this.groupBox1.Font = new System.Drawing.Font("Constantia", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(27, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Κατηγορία Αιμοδότη";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 11;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Κλείσιμο";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.προβολήΙστορικούToolStripMenuItem,
            this.FullViewAimodosia});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // προβολήΙστορικούToolStripMenuItem
            // 
            this.προβολήΙστορικούToolStripMenuItem.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.προβολήΙστορικούToolStripMenuItem.Name = "προβολήΙστορικούToolStripMenuItem";
            this.προβολήΙστορικούToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.προβολήΙστορικούToolStripMenuItem.Text = "Προβολή Ιστορικού";
            this.προβολήΙστορικούToolStripMenuItem.Click += new System.EventHandler(this.προβολήΙστορικούToolStripMenuItem_Click);
            // 
            // FullViewAimodosia
            // 
            this.FullViewAimodosia.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.FullViewAimodosia.Name = "FullViewAimodosia";
            this.FullViewAimodosia.Size = new System.Drawing.Size(189, 22);
            this.FullViewAimodosia.Text = "Προβολή Αιμοδοσίας";
            this.FullViewAimodosia.Click += new System.EventHandler(this.FullViewAimodosia_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(643, 515);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(40, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 43;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // labelSyllogos
            // 
            this.labelSyllogos.AutoSize = true;
            this.labelSyllogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSyllogos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelSyllogos.Location = new System.Drawing.Point(196, 366);
            this.labelSyllogos.Name = "labelSyllogos";
            this.labelSyllogos.Size = new System.Drawing.Size(46, 18);
            this.labelSyllogos.TabIndex = 48;
            this.labelSyllogos.Text = " - - - ";
            // 
            // pictureBoxSearchSyllogo
            // 
            this.pictureBoxSearchSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSearchSyllogo.Image = global::Ptuxiaki.Properties.Resources.search;
            this.pictureBoxSearchSyllogo.Location = new System.Drawing.Point(403, 362);
            this.pictureBoxSearchSyllogo.Name = "pictureBoxSearchSyllogo";
            this.pictureBoxSearchSyllogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxSearchSyllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSearchSyllogo.TabIndex = 47;
            this.pictureBoxSearchSyllogo.TabStop = false;
            this.pictureBoxSearchSyllogo.Click += new System.EventHandler(this.pictureBoxSearchSyllogo_Click);
            // 
            // textBoxSearchSyllogo
            // 
            this.textBoxSearchSyllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSyllogo.Location = new System.Drawing.Point(241, 363);
            this.textBoxSearchSyllogo.Name = "textBoxSearchSyllogo";
            this.textBoxSearchSyllogo.Size = new System.Drawing.Size(156, 24);
            this.textBoxSearchSyllogo.TabIndex = 46;
            this.textBoxSearchSyllogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchSyllogo_KeyPress);
            // 
            // pictureBoxAddSyllogo
            // 
            this.pictureBoxAddSyllogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddSyllogo.Image = global::Ptuxiaki.Properties.Resources._1313244897_1;
            this.pictureBoxAddSyllogo.Location = new System.Drawing.Point(27, 356);
            this.pictureBoxAddSyllogo.Name = "pictureBoxAddSyllogo";
            this.pictureBoxAddSyllogo.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxAddSyllogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAddSyllogo.TabIndex = 45;
            this.pictureBoxAddSyllogo.TabStop = false;
            this.pictureBoxAddSyllogo.Click += new System.EventHandler(this.pictureBoxAddSyllogo_Click);
            // 
            // syllogoiTableAdapter1
            // 
            this.syllogoiTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxNameAstheni
            // 
            this.textBoxNameAstheni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameAstheni.Location = new System.Drawing.Point(177, 354);
            this.textBoxNameAstheni.Name = "textBoxNameAstheni";
            this.textBoxNameAstheni.Size = new System.Drawing.Size(156, 24);
            this.textBoxNameAstheni.TabIndex = 50;
            // 
            // textBoxNosokomeioAstheni
            // 
            this.textBoxNosokomeioAstheni.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNosokomeioAstheni.Location = new System.Drawing.Point(223, 401);
            this.textBoxNosokomeioAstheni.Name = "textBoxNosokomeioAstheni";
            this.textBoxNosokomeioAstheni.Size = new System.Drawing.Size(156, 24);
            this.textBoxNosokomeioAstheni.TabIndex = 52;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 308);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // istorikoTableAdapter1
            // 
            this.istorikoTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(78, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Σύλλογος :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 56;
            this.label1.Text = "Όνομα Ασθενή :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(23, 403);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(199, 22);
            this.label33.TabIndex = 57;
            this.label33.Text = "Νοσοκομείο Ασθενή :";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(68, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 39);
            this.button1.TabIndex = 58;
            this.button1.Text = "Προσθήκη Ιστορικού";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddHistory
            // 
            this.AddHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHistory.Image = global::Ptuxiaki.Properties.Resources._1313244897_1;
            this.AddHistory.Location = new System.Drawing.Point(27, 227);
            this.AddHistory.Name = "AddHistory";
            this.AddHistory.Size = new System.Drawing.Size(35, 35);
            this.AddHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddHistory.TabIndex = 59;
            this.AddHistory.TabStop = false;
            this.AddHistory.Click += new System.EventHandler(this.AddHistory_Click);
            // 
            // btnSaveAimodosia
            // 
            this.btnSaveAimodosia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAimodosia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAimodosia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveAimodosia.Image = global::Ptuxiaki.Properties.Resources._1300790450_3floppy_unmount;
            this.btnSaveAimodosia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveAimodosia.Location = new System.Drawing.Point(104, 508);
            this.btnSaveAimodosia.Name = "btnSaveAimodosia";
            this.btnSaveAimodosia.Size = new System.Drawing.Size(173, 39);
            this.btnSaveAimodosia.TabIndex = 60;
            this.btnSaveAimodosia.Text = "Αποθήκευση";
            this.btnSaveAimodosia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveAimodosia.UseVisualStyleBackColor = true;
            this.btnSaveAimodosia.Click += new System.EventHandler(this.btnSaveAimodosia_Click);
            // 
            // xrewshTableAdapter1
            // 
            this.xrewshTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonApporipsi
            // 
            this.buttonApporipsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApporipsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApporipsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonApporipsi.Image = global::Ptuxiaki.Properties.Resources._1317561048_stop;
            this.buttonApporipsi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonApporipsi.Location = new System.Drawing.Point(349, 508);
            this.buttonApporipsi.Name = "buttonApporipsi";
            this.buttonApporipsi.Size = new System.Drawing.Size(187, 39);
            this.buttonApporipsi.TabIndex = 61;
            this.buttonApporipsi.Text = "Απορρίπτεται";
            this.buttonApporipsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApporipsi.UseVisualStyleBackColor = true;
            this.buttonApporipsi.Click += new System.EventHandler(this.buttonApporipsi_Click);
            // 
            // FormAddAimodosia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 559);
            this.Controls.Add(this.buttonApporipsi);
            this.Controls.Add(this.btnSaveAimodosia);
            this.Controls.Add(this.AddHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxNosokomeioAstheni);
            this.Controls.Add(this.textBoxNameAstheni);
            this.Controls.Add(this.labelSyllogos);
            this.Controls.Add(this.pictureBoxSearchSyllogo);
            this.Controls.Add(this.textBoxSearchSyllogo);
            this.Controls.Add(this.pictureBoxAddSyllogo);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LabelAimodoti);
            this.Controls.Add(this.pictureBoxSearchAimodoti);
            this.Controls.Add(this.TextBoxSearchAimodoti);
            this.Controls.Add(this.pictureBoxAddAimodoti);
            this.Controls.Add(iDaimodotiLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormAddAimodosia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Προσθήκης Αιμοδοσίας  © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormAddAimodosia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAimodoti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchAimodoti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchSyllogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddSyllogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource fialesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBoxAddAimodoti;
        private System.Windows.Forms.TextBox TextBoxSearchAimodoti;
        private System.Windows.Forms.PictureBox pictureBoxSearchAimodoti;
        private System.Windows.Forms.Label LabelAimodoti;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter1;
        private System.Windows.Forms.RadioButton radioButtonEthelontika;
        private System.Windows.Forms.RadioButton radioButtonSyllogo;
        private System.Windows.Forms.RadioButton radioButtonAstheni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label labelSyllogos;
        private System.Windows.Forms.PictureBox pictureBoxSearchSyllogo;
        private System.Windows.Forms.TextBox textBoxSearchSyllogo;
        private System.Windows.Forms.PictureBox pictureBoxAddSyllogo;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter1;
        private System.Windows.Forms.TextBox textBoxNameAstheni;
        private System.Windows.Forms.TextBox textBoxNosokomeioAstheni;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private PtuxiakiDatabaseDataSet1TableAdapters.IstorikoTableAdapter istorikoTableAdapter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox AddHistory;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem προβολήΙστορικούToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveAimodosia;
        private System.Windows.Forms.ToolStripMenuItem FullViewAimodosia;
        private PtuxiakiDatabaseDataSet1TableAdapters.XrewshTableAdapter xrewshTableAdapter1;
        private System.Windows.Forms.Button buttonApporipsi;
    }
}