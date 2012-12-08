namespace Ptuxiaki
{
    partial class FormDiorthwsiSullogou
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
            System.Windows.Forms.Label onoma_ProedrouLabel;
            System.Windows.Forms.Label eponumo_ProedrouLabel;
            System.Windows.Forms.Label num_FialesLabel;
            System.Windows.Forms.Label date_IdrisisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiorthwsiSullogou));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.syllogoiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.syllogoiTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.iD_SyllogouLabel1 = new System.Windows.Forms.Label();
            this.onoma_SyllogouLabel1 = new System.Windows.Forms.Label();
            this.onoma_ProedrouLabel1 = new System.Windows.Forms.Label();
            this.eponumo_ProedrouLabel1 = new System.Windows.Forms.Label();
            this.num_FialesLabel1 = new System.Windows.Forms.Label();
            this.date_IdrisisLabel1 = new System.Windows.Forms.Label();
            this.btnSearchSyllogo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FullView = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxSearchSyllogo = new System.Windows.Forms.TextBox();
            this.btnDeleteSyllogo = new System.Windows.Forms.Button();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.btn_edit_Sullogo = new System.Windows.Forms.Button();
            this.EditNameSullogouPicture = new System.Windows.Forms.PictureBox();
            this.EditNameProedrouPicture = new System.Windows.Forms.PictureBox();
            this.EditEponumoProedrouPicture = new System.Windows.Forms.PictureBox();
            this.EditNumFialesPicture = new System.Windows.Forms.PictureBox();
            this.EditDateIdrusisPicture = new System.Windows.Forms.PictureBox();
            this.NewNameSullogouTxTBox = new System.Windows.Forms.TextBox();
            this.NewNameProedrouTxTBox = new System.Windows.Forms.TextBox();
            this.NewNumFialesTxTBox = new System.Windows.Forms.TextBox();
            this.NewEponumoProedrouTxTBox = new System.Windows.Forms.TextBox();
            this.EditNameSullogouDonePicture = new System.Windows.Forms.PictureBox();
            this.EditNumFialesDonePicture = new System.Windows.Forms.PictureBox();
            this.EditEponumoProedrouDonePicture = new System.Windows.Forms.PictureBox();
            this.EditNameProedrouDonePicture = new System.Windows.Forms.PictureBox();
            this.EditDateIdrusisDonePicture = new System.Windows.Forms.PictureBox();
            this.NewDateIdrusisTxTBox = new System.Windows.Forms.DateTimePicker();
            iD_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_SyllogouLabel = new System.Windows.Forms.Label();
            onoma_ProedrouLabel = new System.Windows.Forms.Label();
            eponumo_ProedrouLabel = new System.Windows.Forms.Label();
            num_FialesLabel = new System.Windows.Forms.Label();
            date_IdrisisLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameSullogouPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameProedrouPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditEponumoProedrouPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNumFialesPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDateIdrusisPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameSullogouDonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNumFialesDonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditEponumoProedrouDonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameProedrouDonePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDateIdrusisDonePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_SyllogouLabel
            // 
            iD_SyllogouLabel.AutoSize = true;
            iD_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            iD_SyllogouLabel.Location = new System.Drawing.Point(12, 50);
            iD_SyllogouLabel.Name = "iD_SyllogouLabel";
            iD_SyllogouLabel.Size = new System.Drawing.Size(100, 16);
            iD_SyllogouLabel.TabIndex = 0;
            iD_SyllogouLabel.Text = "ID Συλλόγου :";
            // 
            // onoma_SyllogouLabel
            // 
            onoma_SyllogouLabel.AutoSize = true;
            onoma_SyllogouLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            onoma_SyllogouLabel.Location = new System.Drawing.Point(12, 83);
            onoma_SyllogouLabel.Name = "onoma_SyllogouLabel";
            onoma_SyllogouLabel.Size = new System.Drawing.Size(130, 16);
            onoma_SyllogouLabel.TabIndex = 2;
            onoma_SyllogouLabel.Text = "Όνομα Συλλόγου :";
            // 
            // onoma_ProedrouLabel
            // 
            onoma_ProedrouLabel.AutoSize = true;
            onoma_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            onoma_ProedrouLabel.Location = new System.Drawing.Point(12, 114);
            onoma_ProedrouLabel.Name = "onoma_ProedrouLabel";
            onoma_ProedrouLabel.Size = new System.Drawing.Size(130, 16);
            onoma_ProedrouLabel.TabIndex = 4;
            onoma_ProedrouLabel.Text = "Όνομα Προέδρου :";
            // 
            // eponumo_ProedrouLabel
            // 
            eponumo_ProedrouLabel.AutoSize = true;
            eponumo_ProedrouLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            eponumo_ProedrouLabel.Location = new System.Drawing.Point(12, 148);
            eponumo_ProedrouLabel.Name = "eponumo_ProedrouLabel";
            eponumo_ProedrouLabel.Size = new System.Drawing.Size(144, 16);
            eponumo_ProedrouLabel.TabIndex = 6;
            eponumo_ProedrouLabel.Text = "Επώνυμο Συλλόγου :";
            // 
            // num_FialesLabel
            // 
            num_FialesLabel.AutoSize = true;
            num_FialesLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            num_FialesLabel.Location = new System.Drawing.Point(12, 184);
            num_FialesLabel.Name = "num_FialesLabel";
            num_FialesLabel.Size = new System.Drawing.Size(122, 16);
            num_FialesLabel.TabIndex = 8;
            num_FialesLabel.Text = "Αριθμός Φιάλων :";
            // 
            // date_IdrisisLabel
            // 
            date_IdrisisLabel.AutoSize = true;
            date_IdrisisLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            date_IdrisisLabel.Location = new System.Drawing.Point(12, 221);
            date_IdrisisLabel.Name = "date_IdrisisLabel";
            date_IdrisisLabel.Size = new System.Drawing.Size(157, 16);
            date_IdrisisLabel.TabIndex = 10;
            date_IdrisisLabel.Text = "Ημερομηνία Ίδρυσης : ";
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
            // iD_SyllogouLabel1
            // 
            this.iD_SyllogouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "ID_Syllogou", true));
            this.iD_SyllogouLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iD_SyllogouLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iD_SyllogouLabel1.Location = new System.Drawing.Point(118, 51);
            this.iD_SyllogouLabel1.Name = "iD_SyllogouLabel1";
            this.iD_SyllogouLabel1.Size = new System.Drawing.Size(100, 23);
            this.iD_SyllogouLabel1.TabIndex = 1;
            this.iD_SyllogouLabel1.Text = "label1";
            // 
            // onoma_SyllogouLabel1
            // 
            this.onoma_SyllogouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Syllogou", true));
            this.onoma_SyllogouLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.onoma_SyllogouLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.onoma_SyllogouLabel1.Location = new System.Drawing.Point(154, 84);
            this.onoma_SyllogouLabel1.Name = "onoma_SyllogouLabel1";
            this.onoma_SyllogouLabel1.Size = new System.Drawing.Size(100, 23);
            this.onoma_SyllogouLabel1.TabIndex = 3;
            this.onoma_SyllogouLabel1.Text = "label1";
            // 
            // onoma_ProedrouLabel1
            // 
            this.onoma_ProedrouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Onoma_Proedrou", true));
            this.onoma_ProedrouLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.onoma_ProedrouLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.onoma_ProedrouLabel1.Location = new System.Drawing.Point(154, 115);
            this.onoma_ProedrouLabel1.Name = "onoma_ProedrouLabel1";
            this.onoma_ProedrouLabel1.Size = new System.Drawing.Size(100, 23);
            this.onoma_ProedrouLabel1.TabIndex = 5;
            this.onoma_ProedrouLabel1.Text = "label1";
            // 
            // eponumo_ProedrouLabel1
            // 
            this.eponumo_ProedrouLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Eponumo_Proedrou", true));
            this.eponumo_ProedrouLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.eponumo_ProedrouLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.eponumo_ProedrouLabel1.Location = new System.Drawing.Point(162, 149);
            this.eponumo_ProedrouLabel1.Name = "eponumo_ProedrouLabel1";
            this.eponumo_ProedrouLabel1.Size = new System.Drawing.Size(100, 23);
            this.eponumo_ProedrouLabel1.TabIndex = 7;
            this.eponumo_ProedrouLabel1.Text = "label1";
            // 
            // num_FialesLabel1
            // 
            this.num_FialesLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Num_Fiales", true));
            this.num_FialesLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.num_FialesLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.num_FialesLabel1.Location = new System.Drawing.Point(154, 185);
            this.num_FialesLabel1.Name = "num_FialesLabel1";
            this.num_FialesLabel1.Size = new System.Drawing.Size(100, 23);
            this.num_FialesLabel1.TabIndex = 9;
            this.num_FialesLabel1.Text = "label1";
            // 
            // date_IdrisisLabel1
            // 
            this.date_IdrisisLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.syllogoiBindingSource, "Date_Idrisis", true));
            this.date_IdrisisLabel1.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.date_IdrisisLabel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.date_IdrisisLabel1.Location = new System.Drawing.Point(175, 222);
            this.date_IdrisisLabel1.Name = "date_IdrisisLabel1";
            this.date_IdrisisLabel1.Size = new System.Drawing.Size(100, 23);
            this.date_IdrisisLabel1.TabIndex = 11;
            this.date_IdrisisLabel1.Text = "label1";
            // 
            // btnSearchSyllogo
            // 
            this.btnSearchSyllogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchSyllogo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSearchSyllogo.Image = global::Ptuxiaki.Properties.Resources._1301407111_kde_folder_saved_search;
            this.btnSearchSyllogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchSyllogo.Location = new System.Drawing.Point(15, 255);
            this.btnSearchSyllogo.Name = "btnSearchSyllogo";
            this.btnSearchSyllogo.Size = new System.Drawing.Size(136, 53);
            this.btnSearchSyllogo.TabIndex = 24;
            this.btnSearchSyllogo.Text = "Αναζήτηση ->";
            this.btnSearchSyllogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchSyllogo.UseVisualStyleBackColor = true;
            this.btnSearchSyllogo.Click += new System.EventHandler(this.btnSearchSyllogo_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 24);
            this.menuStrip1.TabIndex = 25;
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
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.closeToolStripMenuItem.Text = "Κλείσιμο";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullView});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // FullView
            // 
            this.FullView.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.FullView.Name = "FullView";
            this.FullView.Size = new System.Drawing.Size(169, 22);
            this.FullView.Text = "Πλήρης Προβολή";
            this.FullView.Click += new System.EventHandler(this.FullView_Click);
            // 
            // txtBoxSearchSyllogo
            // 
            this.txtBoxSearchSyllogo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtBoxSearchSyllogo.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxSearchSyllogo.Location = new System.Drawing.Point(157, 270);
            this.txtBoxSearchSyllogo.Name = "txtBoxSearchSyllogo";
            this.txtBoxSearchSyllogo.Size = new System.Drawing.Size(230, 23);
            this.txtBoxSearchSyllogo.TabIndex = 0;
            this.txtBoxSearchSyllogo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearchSyllogo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSearchSyllogo_Click);
            // 
            // btnDeleteSyllogo
            // 
            this.btnDeleteSyllogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSyllogo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeleteSyllogo.Image = global::Ptuxiaki.Properties.Resources._1301407902_Delete;
            this.btnDeleteSyllogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteSyllogo.Location = new System.Drawing.Point(255, 333);
            this.btnDeleteSyllogo.Name = "btnDeleteSyllogo";
            this.btnDeleteSyllogo.Size = new System.Drawing.Size(123, 46);
            this.btnDeleteSyllogo.TabIndex = 28;
            this.btnDeleteSyllogo.Text = "Διαγραφή";
            this.btnDeleteSyllogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSyllogo.UseVisualStyleBackColor = true;
            this.btnDeleteSyllogo.Click += new System.EventHandler(this.btnDeleteSyllogo_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(513, 347);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(40, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 41;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // btn_edit_Sullogo
            // 
            this.btn_edit_Sullogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_Sullogo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_edit_Sullogo.Image = global::Ptuxiaki.Properties.Resources._1301407580_interact;
            this.btn_edit_Sullogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit_Sullogo.Location = new System.Drawing.Point(15, 333);
            this.btn_edit_Sullogo.Name = "btn_edit_Sullogo";
            this.btn_edit_Sullogo.Size = new System.Drawing.Size(193, 46);
            this.btn_edit_Sullogo.TabIndex = 42;
            this.btn_edit_Sullogo.Text = "Επεξεργασία Συλλόγου";
            this.btn_edit_Sullogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit_Sullogo.UseVisualStyleBackColor = true;
            this.btn_edit_Sullogo.Click += new System.EventHandler(this.btn_edit_Sullogo_Click_1);
            // 
            // EditNameSullogouPicture
            // 
            this.EditNameSullogouPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNameSullogouPicture.Image = global::Ptuxiaki.Properties.Resources._1304615470_edit;
            this.EditNameSullogouPicture.Location = new System.Drawing.Point(255, 79);
            this.EditNameSullogouPicture.Name = "EditNameSullogouPicture";
            this.EditNameSullogouPicture.Size = new System.Drawing.Size(20, 20);
            this.EditNameSullogouPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNameSullogouPicture.TabIndex = 43;
            this.EditNameSullogouPicture.TabStop = false;
            this.EditNameSullogouPicture.Visible = false;
            this.EditNameSullogouPicture.Click += new System.EventHandler(this.EditNameSullogouPicture_Click);
            // 
            // EditNameProedrouPicture
            // 
            this.EditNameProedrouPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNameProedrouPicture.Image = global::Ptuxiaki.Properties.Resources._1304615470_edit;
            this.EditNameProedrouPicture.Location = new System.Drawing.Point(255, 110);
            this.EditNameProedrouPicture.Name = "EditNameProedrouPicture";
            this.EditNameProedrouPicture.Size = new System.Drawing.Size(20, 20);
            this.EditNameProedrouPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNameProedrouPicture.TabIndex = 44;
            this.EditNameProedrouPicture.TabStop = false;
            this.EditNameProedrouPicture.Visible = false;
            this.EditNameProedrouPicture.Click += new System.EventHandler(this.EditNameProedrouPicture_Click);
            // 
            // EditEponumoProedrouPicture
            // 
            this.EditEponumoProedrouPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEponumoProedrouPicture.Image = global::Ptuxiaki.Properties.Resources._1304615470_edit;
            this.EditEponumoProedrouPicture.Location = new System.Drawing.Point(255, 144);
            this.EditEponumoProedrouPicture.Name = "EditEponumoProedrouPicture";
            this.EditEponumoProedrouPicture.Size = new System.Drawing.Size(20, 20);
            this.EditEponumoProedrouPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditEponumoProedrouPicture.TabIndex = 45;
            this.EditEponumoProedrouPicture.TabStop = false;
            this.EditEponumoProedrouPicture.Visible = false;
            this.EditEponumoProedrouPicture.Click += new System.EventHandler(this.EditEponumoProedrouPicture_Click);
            // 
            // EditNumFialesPicture
            // 
            this.EditNumFialesPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNumFialesPicture.Image = global::Ptuxiaki.Properties.Resources._1304615470_edit;
            this.EditNumFialesPicture.Location = new System.Drawing.Point(255, 180);
            this.EditNumFialesPicture.Name = "EditNumFialesPicture";
            this.EditNumFialesPicture.Size = new System.Drawing.Size(20, 20);
            this.EditNumFialesPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNumFialesPicture.TabIndex = 46;
            this.EditNumFialesPicture.TabStop = false;
            this.EditNumFialesPicture.Visible = false;
            this.EditNumFialesPicture.Click += new System.EventHandler(this.EditNumFialesPicture_Click);
            // 
            // EditDateIdrusisPicture
            // 
            this.EditDateIdrusisPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditDateIdrusisPicture.Image = global::Ptuxiaki.Properties.Resources._1304615470_edit;
            this.EditDateIdrusisPicture.Location = new System.Drawing.Point(255, 217);
            this.EditDateIdrusisPicture.Name = "EditDateIdrusisPicture";
            this.EditDateIdrusisPicture.Size = new System.Drawing.Size(20, 20);
            this.EditDateIdrusisPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditDateIdrusisPicture.TabIndex = 47;
            this.EditDateIdrusisPicture.TabStop = false;
            this.EditDateIdrusisPicture.Visible = false;
            this.EditDateIdrusisPicture.Click += new System.EventHandler(this.EditDateIdrusisPicture_Click);
            // 
            // NewNameSullogouTxTBox
            // 
            this.NewNameSullogouTxTBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NewNameSullogouTxTBox.Location = new System.Drawing.Point(314, 80);
            this.NewNameSullogouTxTBox.Name = "NewNameSullogouTxTBox";
            this.NewNameSullogouTxTBox.Size = new System.Drawing.Size(186, 22);
            this.NewNameSullogouTxTBox.TabIndex = 48;
            this.NewNameSullogouTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewNameSullogouTxTBox.Visible = false;
            this.NewNameSullogouTxTBox.Leave += new System.EventHandler(this.NewNameSyllogouTxtBox_Leave);
            // 
            // NewNameProedrouTxTBox
            // 
            this.NewNameProedrouTxTBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NewNameProedrouTxTBox.Location = new System.Drawing.Point(314, 111);
            this.NewNameProedrouTxTBox.Name = "NewNameProedrouTxTBox";
            this.NewNameProedrouTxTBox.Size = new System.Drawing.Size(186, 22);
            this.NewNameProedrouTxTBox.TabIndex = 49;
            this.NewNameProedrouTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewNameProedrouTxTBox.Visible = false;
            this.NewNameProedrouTxTBox.Leave += new System.EventHandler(this.NewNameProedrouTxtBox_Leave);
            // 
            // NewNumFialesTxTBox
            // 
            this.NewNumFialesTxTBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NewNumFialesTxTBox.Location = new System.Drawing.Point(314, 181);
            this.NewNumFialesTxTBox.Name = "NewNumFialesTxTBox";
            this.NewNumFialesTxTBox.Size = new System.Drawing.Size(186, 22);
            this.NewNumFialesTxTBox.TabIndex = 50;
            this.NewNumFialesTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewNumFialesTxTBox.Visible = false;
            this.NewNumFialesTxTBox.Leave += new System.EventHandler(this.NewNumFuallesTxtBox_Leave);
            // 
            // NewEponumoProedrouTxTBox
            // 
            this.NewEponumoProedrouTxTBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.NewEponumoProedrouTxTBox.Location = new System.Drawing.Point(314, 145);
            this.NewEponumoProedrouTxTBox.Name = "NewEponumoProedrouTxTBox";
            this.NewEponumoProedrouTxTBox.Size = new System.Drawing.Size(186, 22);
            this.NewEponumoProedrouTxTBox.TabIndex = 51;
            this.NewEponumoProedrouTxTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewEponumoProedrouTxTBox.Visible = false;
            this.NewEponumoProedrouTxTBox.Leave += new System.EventHandler(this.NewEponimoProedrouTxtBox_Leave);
            // 
            // EditNameSullogouDonePicture
            // 
            this.EditNameSullogouDonePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNameSullogouDonePicture.Image = global::Ptuxiaki.Properties.Resources._1304616548_ok;
            this.EditNameSullogouDonePicture.Location = new System.Drawing.Point(506, 82);
            this.EditNameSullogouDonePicture.Name = "EditNameSullogouDonePicture";
            this.EditNameSullogouDonePicture.Size = new System.Drawing.Size(20, 20);
            this.EditNameSullogouDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNameSullogouDonePicture.TabIndex = 53;
            this.EditNameSullogouDonePicture.TabStop = false;
            this.EditNameSullogouDonePicture.Visible = false;
            this.EditNameSullogouDonePicture.Click += new System.EventHandler(this.EditNameSullogouDonePicture_Click);
            // 
            // EditNumFialesDonePicture
            // 
            this.EditNumFialesDonePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNumFialesDonePicture.Image = global::Ptuxiaki.Properties.Resources._1304616548_ok;
            this.EditNumFialesDonePicture.Location = new System.Drawing.Point(506, 183);
            this.EditNumFialesDonePicture.Name = "EditNumFialesDonePicture";
            this.EditNumFialesDonePicture.Size = new System.Drawing.Size(20, 20);
            this.EditNumFialesDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNumFialesDonePicture.TabIndex = 54;
            this.EditNumFialesDonePicture.TabStop = false;
            this.EditNumFialesDonePicture.Visible = false;
            this.EditNumFialesDonePicture.Click += new System.EventHandler(this.EditNumFialesDonePicture_Click);
            // 
            // EditEponumoProedrouDonePicture
            // 
            this.EditEponumoProedrouDonePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditEponumoProedrouDonePicture.Image = global::Ptuxiaki.Properties.Resources._1304616548_ok;
            this.EditEponumoProedrouDonePicture.Location = new System.Drawing.Point(506, 147);
            this.EditEponumoProedrouDonePicture.Name = "EditEponumoProedrouDonePicture";
            this.EditEponumoProedrouDonePicture.Size = new System.Drawing.Size(20, 20);
            this.EditEponumoProedrouDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditEponumoProedrouDonePicture.TabIndex = 55;
            this.EditEponumoProedrouDonePicture.TabStop = false;
            this.EditEponumoProedrouDonePicture.Visible = false;
            this.EditEponumoProedrouDonePicture.Click += new System.EventHandler(this.EditEponumoProedrouDonePicture_Click);
            // 
            // EditNameProedrouDonePicture
            // 
            this.EditNameProedrouDonePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditNameProedrouDonePicture.Image = global::Ptuxiaki.Properties.Resources._1304616548_ok;
            this.EditNameProedrouDonePicture.Location = new System.Drawing.Point(506, 113);
            this.EditNameProedrouDonePicture.Name = "EditNameProedrouDonePicture";
            this.EditNameProedrouDonePicture.Size = new System.Drawing.Size(20, 20);
            this.EditNameProedrouDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditNameProedrouDonePicture.TabIndex = 56;
            this.EditNameProedrouDonePicture.TabStop = false;
            this.EditNameProedrouDonePicture.Visible = false;
            this.EditNameProedrouDonePicture.Click += new System.EventHandler(this.EditNameProedrouDonePicture_Click);
            // 
            // EditDateIdrusisDonePicture
            // 
            this.EditDateIdrusisDonePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditDateIdrusisDonePicture.Image = global::Ptuxiaki.Properties.Resources._1304616548_ok;
            this.EditDateIdrusisDonePicture.Location = new System.Drawing.Point(506, 220);
            this.EditDateIdrusisDonePicture.Name = "EditDateIdrusisDonePicture";
            this.EditDateIdrusisDonePicture.Size = new System.Drawing.Size(20, 20);
            this.EditDateIdrusisDonePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditDateIdrusisDonePicture.TabIndex = 57;
            this.EditDateIdrusisDonePicture.TabStop = false;
            this.EditDateIdrusisDonePicture.Visible = false;
            this.EditDateIdrusisDonePicture.Click += new System.EventHandler(this.EditDateIdrusisDonePicture_Click);
            // 
            // NewDateIdrusisTxTBox
            // 
            this.NewDateIdrusisTxTBox.Location = new System.Drawing.Point(314, 220);
            this.NewDateIdrusisTxTBox.Name = "NewDateIdrusisTxTBox";
            this.NewDateIdrusisTxTBox.Size = new System.Drawing.Size(186, 20);
            this.NewDateIdrusisTxTBox.TabIndex = 58;
            // 
            // FormDiorthwsiSullogou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 391);
            this.Controls.Add(this.NewDateIdrusisTxTBox);
            this.Controls.Add(this.EditDateIdrusisDonePicture);
            this.Controls.Add(this.EditNameProedrouDonePicture);
            this.Controls.Add(this.EditEponumoProedrouDonePicture);
            this.Controls.Add(this.EditNumFialesDonePicture);
            this.Controls.Add(this.EditNameSullogouDonePicture);
            this.Controls.Add(this.NewEponumoProedrouTxTBox);
            this.Controls.Add(this.NewNumFialesTxTBox);
            this.Controls.Add(this.NewNameProedrouTxTBox);
            this.Controls.Add(this.NewNameSullogouTxTBox);
            this.Controls.Add(this.EditDateIdrusisPicture);
            this.Controls.Add(this.EditNumFialesPicture);
            this.Controls.Add(this.EditEponumoProedrouPicture);
            this.Controls.Add(this.EditNameProedrouPicture);
            this.Controls.Add(this.EditNameSullogouPicture);
            this.Controls.Add(this.btn_edit_Sullogo);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.btnDeleteSyllogo);
            this.Controls.Add(this.txtBoxSearchSyllogo);
            this.Controls.Add(this.btnSearchSyllogo);
            this.Controls.Add(iD_SyllogouLabel);
            this.Controls.Add(this.iD_SyllogouLabel1);
            this.Controls.Add(onoma_SyllogouLabel);
            this.Controls.Add(this.onoma_SyllogouLabel1);
            this.Controls.Add(onoma_ProedrouLabel);
            this.Controls.Add(this.onoma_ProedrouLabel1);
            this.Controls.Add(eponumo_ProedrouLabel);
            this.Controls.Add(this.eponumo_ProedrouLabel1);
            this.Controls.Add(num_FialesLabel);
            this.Controls.Add(this.num_FialesLabel1);
            this.Controls.Add(date_IdrisisLabel);
            this.Controls.Add(this.date_IdrisisLabel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormDiorthwsiSullogou";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Διόρθωση Στοιχείων Συλλόγου © Κυριαζόπουλος Αθανάσιος ";
            this.Load += new System.EventHandler(this.FormDiorthwsiSullogou_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.syllogoiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameSullogouPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameProedrouPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditEponumoProedrouPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNumFialesPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDateIdrusisPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameSullogouDonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNumFialesDonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditEponumoProedrouDonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditNameProedrouDonePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditDateIdrusisDonePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource syllogoiBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label iD_SyllogouLabel1;
        private System.Windows.Forms.Label onoma_SyllogouLabel1;
        private System.Windows.Forms.Label onoma_ProedrouLabel1;
        private System.Windows.Forms.Label eponumo_ProedrouLabel1;
        private System.Windows.Forms.Label num_FialesLabel1;
        private System.Windows.Forms.Label date_IdrisisLabel1;
        private System.Windows.Forms.Button btnSearchSyllogo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FullView;
        private System.Windows.Forms.TextBox txtBoxSearchSyllogo;
        private System.Windows.Forms.Button btnDeleteSyllogo;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Button btn_edit_Sullogo;
        private System.Windows.Forms.PictureBox EditNameSullogouPicture;
        private System.Windows.Forms.PictureBox EditNameProedrouPicture;
        private System.Windows.Forms.PictureBox EditEponumoProedrouPicture;
        private System.Windows.Forms.PictureBox EditNumFialesPicture;
        private System.Windows.Forms.PictureBox EditDateIdrusisPicture;
        private System.Windows.Forms.TextBox NewNameSullogouTxTBox;
        private System.Windows.Forms.TextBox NewNameProedrouTxTBox;
        private System.Windows.Forms.TextBox NewNumFialesTxTBox;
        private System.Windows.Forms.TextBox NewEponumoProedrouTxTBox;
        private System.Windows.Forms.PictureBox EditNameSullogouDonePicture;
        private System.Windows.Forms.PictureBox EditNumFialesDonePicture;
        private System.Windows.Forms.PictureBox EditEponumoProedrouDonePicture;
        private System.Windows.Forms.PictureBox EditNameProedrouDonePicture;
        private System.Windows.Forms.PictureBox EditDateIdrusisDonePicture;
        private System.Windows.Forms.DateTimePicker NewDateIdrusisTxTBox;
    }
}