namespace Ptuxiaki
{
    partial class FormUpdateAimodoti
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label fatherNameLabel;
            System.Windows.Forms.Label birthYearLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumber1Label;
            System.Windows.Forms.Label phoneNumber2Label;
            System.Windows.Forms.Label rhesusLabel;
            System.Windows.Forms.Label omadaAimatosLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateAimodoti));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.aimodotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aimodotesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.btnSearchAimodoti = new System.Windows.Forms.Button();
            this.btnUpdateAimodoti = new System.Windows.Forms.Button();
            this.btnDeleteAimodoti = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πλήρηςΠροβολήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxSearchAimodoti = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxJob = new System.Windows.Forms.TextBox();
            this.txtBoxFatherName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxPhone2 = new System.Windows.Forms.TextBox();
            this.txtBoxPhone1 = new System.Windows.Forms.TextBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.Omada_AimatosCombobox = new System.Windows.Forms.ComboBox();
            this.rhesus_Combobox = new System.Windows.Forms.ComboBox();
            this.Fylo_combobox = new System.Windows.Forms.ComboBox();
            this.birthYearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelIdAimodoti = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            birthYearLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumber1Label = new System.Windows.Forms.Label();
            phoneNumber2Label = new System.Windows.Forms.Label();
            rhesusLabel = new System.Windows.Forms.Label();
            omadaAimatosLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            nameLabel.Location = new System.Drawing.Point(12, 48);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 16);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Όνομα :";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            lastNameLabel.Location = new System.Drawing.Point(12, 74);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(75, 16);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Επώνυμο :";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            fatherNameLabel.Location = new System.Drawing.Point(12, 101);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new System.Drawing.Size(93, 16);
            fatherNameLabel.TabIndex = 7;
            fatherNameLabel.Text = "Πατρώνυμο :";
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            birthYearLabel.Location = new System.Drawing.Point(12, 219);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new System.Drawing.Size(106, 16);
            birthYearLabel.TabIndex = 13;
            birthYearLabel.Text = "Έτος Γέννησης";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            jobLabel.Location = new System.Drawing.Point(12, 245);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(80, 16);
            jobLabel.TabIndex = 15;
            jobLabel.Text = "Επάγγελμα";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            addressLabel.Location = new System.Drawing.Point(12, 271);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(85, 16);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Διεύθυνση :";
            // 
            // phoneNumber1Label
            // 
            phoneNumber1Label.AutoSize = true;
            phoneNumber1Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            phoneNumber1Label.Location = new System.Drawing.Point(12, 297);
            phoneNumber1Label.Name = "phoneNumber1Label";
            phoneNumber1Label.Size = new System.Drawing.Size(97, 16);
            phoneNumber1Label.TabIndex = 19;
            phoneNumber1Label.Text = "Τηλέφωνο 1 :";
            // 
            // phoneNumber2Label
            // 
            phoneNumber2Label.AutoSize = true;
            phoneNumber2Label.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            phoneNumber2Label.Location = new System.Drawing.Point(12, 323);
            phoneNumber2Label.Name = "phoneNumber2Label";
            phoneNumber2Label.Size = new System.Drawing.Size(97, 16);
            phoneNumber2Label.TabIndex = 21;
            phoneNumber2Label.Text = "Τηλέφωνο 2 :";
            // 
            // rhesusLabel
            // 
            rhesusLabel.AutoSize = true;
            rhesusLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            rhesusLabel.Location = new System.Drawing.Point(12, 160);
            rhesusLabel.Name = "rhesusLabel";
            rhesusLabel.Size = new System.Drawing.Size(60, 16);
            rhesusLabel.TabIndex = 11;
            rhesusLabel.Text = "Rhesus:";
            // 
            // omadaAimatosLabel
            // 
            omadaAimatosLabel.AutoSize = true;
            omadaAimatosLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            omadaAimatosLabel.Location = new System.Drawing.Point(13, 185);
            omadaAimatosLabel.Name = "omadaAimatosLabel";
            omadaAimatosLabel.Size = new System.Drawing.Size(113, 16);
            omadaAimatosLabel.TabIndex = 9;
            omadaAimatosLabel.Text = "Ομάδα Αίματος :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            label1.Location = new System.Drawing.Point(12, 130);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 16);
            label1.TabIndex = 41;
            label1.Text = "Φύλο:";
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
            this.tableAdapterManager.FialesTableAdapter = null;
            this.tableAdapterManager.IstorikoTableAdapter = null;
            this.tableAdapterManager.SyllogoiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.XorigiseisTableAdapter = null;
            this.tableAdapterManager.XrewshTableAdapter = null;
            // 
            // btnSearchAimodoti
            // 
            this.btnSearchAimodoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAimodoti.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSearchAimodoti.Image = global::Ptuxiaki.Properties.Resources._1301407111_kde_folder_saved_search;
            this.btnSearchAimodoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAimodoti.Location = new System.Drawing.Point(15, 360);
            this.btnSearchAimodoti.Name = "btnSearchAimodoti";
            this.btnSearchAimodoti.Size = new System.Drawing.Size(126, 41);
            this.btnSearchAimodoti.TabIndex = 23;
            this.btnSearchAimodoti.Text = "Αναζήτηση ->";
            this.btnSearchAimodoti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchAimodoti.UseVisualStyleBackColor = true;
            this.btnSearchAimodoti.Click += new System.EventHandler(this.btnSearchAimodoti_Click);
            // 
            // btnUpdateAimodoti
            // 
            this.btnUpdateAimodoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAimodoti.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnUpdateAimodoti.Image = global::Ptuxiaki.Properties.Resources._1301407580_interact;
            this.btnUpdateAimodoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAimodoti.Location = new System.Drawing.Point(79, 426);
            this.btnUpdateAimodoti.Name = "btnUpdateAimodoti";
            this.btnUpdateAimodoti.Size = new System.Drawing.Size(114, 33);
            this.btnUpdateAimodoti.TabIndex = 24;
            this.btnUpdateAimodoti.Text = "Ανανέωση";
            this.btnUpdateAimodoti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateAimodoti.UseVisualStyleBackColor = true;
            this.btnUpdateAimodoti.Click += new System.EventHandler(this.btnUpdateAimodoti_Click);
            // 
            // btnDeleteAimodoti
            // 
            this.btnDeleteAimodoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAimodoti.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeleteAimodoti.Image = global::Ptuxiaki.Properties.Resources._1301407902_Delete;
            this.btnDeleteAimodoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAimodoti.Location = new System.Drawing.Point(232, 426);
            this.btnDeleteAimodoti.Name = "btnDeleteAimodoti";
            this.btnDeleteAimodoti.Size = new System.Drawing.Size(117, 33);
            this.btnDeleteAimodoti.TabIndex = 25;
            this.btnDeleteAimodoti.Text = "Διαγραφή";
            this.btnDeleteAimodoti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAimodoti.UseVisualStyleBackColor = true;
            this.btnDeleteAimodoti.Click += new System.EventHandler(this.btnDeleteAimodoti_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 26;
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
            this.πλήρηςΠροβολήToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.viewToolStripMenuItem.Text = "Προβολή";
            // 
            // πλήρηςΠροβολήToolStripMenuItem
            // 
            this.πλήρηςΠροβολήToolStripMenuItem.Image = global::Ptuxiaki.Properties.Resources._1301942878_binoculars_128;
            this.πλήρηςΠροβολήToolStripMenuItem.Name = "πλήρηςΠροβολήToolStripMenuItem";
            this.πλήρηςΠροβολήToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.πλήρηςΠροβολήToolStripMenuItem.Text = "Πλήρης Προβολή";
            this.πλήρηςΠροβολήToolStripMenuItem.Click += new System.EventHandler(this.πλήρηςΠροβολήToolStripMenuItem_Click);
            // 
            // txtBoxSearchAimodoti
            // 
            this.txtBoxSearchAimodoti.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxSearchAimodoti.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxSearchAimodoti.Location = new System.Drawing.Point(147, 369);
            this.txtBoxSearchAimodoti.Name = "txtBoxSearchAimodoti";
            this.txtBoxSearchAimodoti.Size = new System.Drawing.Size(167, 23);
            this.txtBoxSearchAimodoti.TabIndex = 0;
            this.txtBoxSearchAimodoti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxSearchAimodoti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxSearchAimodoti_KeyPress);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxName.Location = new System.Drawing.Point(132, 48);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(216, 22);
            this.txtBoxName.TabIndex = 28;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxJob.Location = new System.Drawing.Point(131, 241);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(216, 22);
            this.txtBoxJob.TabIndex = 29;
            this.txtBoxJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxFatherName
            // 
            this.txtBoxFatherName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxFatherName.Location = new System.Drawing.Point(132, 101);
            this.txtBoxFatherName.Name = "txtBoxFatherName";
            this.txtBoxFatherName.Size = new System.Drawing.Size(216, 22);
            this.txtBoxFatherName.TabIndex = 33;
            this.txtBoxFatherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxLastName.Location = new System.Drawing.Point(132, 74);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(216, 22);
            this.txtBoxLastName.TabIndex = 35;
            this.txtBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPhone2
            // 
            this.txtBoxPhone2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxPhone2.Location = new System.Drawing.Point(131, 325);
            this.txtBoxPhone2.Name = "txtBoxPhone2";
            this.txtBoxPhone2.Size = new System.Drawing.Size(216, 22);
            this.txtBoxPhone2.TabIndex = 37;
            this.txtBoxPhone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxPhone1
            // 
            this.txtBoxPhone1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxPhone1.Location = new System.Drawing.Point(131, 297);
            this.txtBoxPhone1.Name = "txtBoxPhone1";
            this.txtBoxPhone1.Size = new System.Drawing.Size(216, 22);
            this.txtBoxPhone1.TabIndex = 38;
            this.txtBoxPhone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBoxAddress.Location = new System.Drawing.Point(131, 269);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(216, 22);
            this.txtBoxAddress.TabIndex = 39;
            this.txtBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(449, 444);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(39, 36);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 40;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // Omada_AimatosCombobox
            // 
            this.Omada_AimatosCombobox.FormattingEnabled = true;
            this.Omada_AimatosCombobox.Items.AddRange(new object[] {
            "Α",
            "Β",
            "ΑΒ",
            "Ο"});
            this.Omada_AimatosCombobox.Location = new System.Drawing.Point(131, 186);
            this.Omada_AimatosCombobox.Name = "Omada_AimatosCombobox";
            this.Omada_AimatosCombobox.Size = new System.Drawing.Size(121, 21);
            this.Omada_AimatosCombobox.TabIndex = 42;
            // 
            // rhesus_Combobox
            // 
            this.rhesus_Combobox.FormattingEnabled = true;
            this.rhesus_Combobox.Items.AddRange(new object[] {
            "+",
            "-"});
            this.rhesus_Combobox.Location = new System.Drawing.Point(131, 159);
            this.rhesus_Combobox.Name = "rhesus_Combobox";
            this.rhesus_Combobox.Size = new System.Drawing.Size(121, 21);
            this.rhesus_Combobox.TabIndex = 43;
            // 
            // Fylo_combobox
            // 
            this.Fylo_combobox.FormattingEnabled = true;
            this.Fylo_combobox.Items.AddRange(new object[] {
            "Άνδρας",
            "Γυναίκα"});
            this.Fylo_combobox.Location = new System.Drawing.Point(132, 129);
            this.Fylo_combobox.Name = "Fylo_combobox";
            this.Fylo_combobox.Size = new System.Drawing.Size(121, 21);
            this.Fylo_combobox.TabIndex = 44;
            // 
            // birthYearDateTimePicker
            // 
            this.birthYearDateTimePicker.Location = new System.Drawing.Point(132, 215);
            this.birthYearDateTimePicker.Name = "birthYearDateTimePicker";
            this.birthYearDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthYearDateTimePicker.TabIndex = 45;
            // 
            // labelIdAimodoti
            // 
            this.labelIdAimodoti.AutoSize = true;
            this.labelIdAimodoti.Font = new System.Drawing.Font("Tahoma", 9F);
            this.labelIdAimodoti.Location = new System.Drawing.Point(461, 33);
            this.labelIdAimodoti.Name = "labelIdAimodoti";
            this.labelIdAimodoti.Size = new System.Drawing.Size(0, 14);
            this.labelIdAimodoti.TabIndex = 46;
            // 
            // FormUpdateAimodoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 500);
            this.Controls.Add(this.labelIdAimodoti);
            this.Controls.Add(this.birthYearDateTimePicker);
            this.Controls.Add(this.Fylo_combobox);
            this.Controls.Add(this.rhesus_Combobox);
            this.Controls.Add(this.Omada_AimatosCombobox);
            this.Controls.Add(label1);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPhone1);
            this.Controls.Add(this.txtBoxPhone2);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFatherName);
            this.Controls.Add(this.txtBoxJob);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxSearchAimodoti);
            this.Controls.Add(this.btnDeleteAimodoti);
            this.Controls.Add(this.btnUpdateAimodoti);
            this.Controls.Add(this.btnSearchAimodoti);
            this.Controls.Add(nameLabel);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(fatherNameLabel);
            this.Controls.Add(omadaAimatosLabel);
            this.Controls.Add(rhesusLabel);
            this.Controls.Add(birthYearLabel);
            this.Controls.Add(jobLabel);
            this.Controls.Add(addressLabel);
            this.Controls.Add(phoneNumber1Label);
            this.Controls.Add(phoneNumber2Label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormUpdateAimodoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Διόρθωση Στοιχείων Αιμοδοτών © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormUpdateAimodoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource aimodotesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnSearchAimodoti;
        private System.Windows.Forms.Button btnUpdateAimodoti;
        private System.Windows.Forms.Button btnDeleteAimodoti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πλήρηςΠροβολήToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxSearchAimodoti;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxJob;
        private System.Windows.Forms.TextBox txtBoxFatherName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxPhone2;
        private System.Windows.Forms.TextBox txtBoxPhone1;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.ComboBox Omada_AimatosCombobox;
        private System.Windows.Forms.ComboBox rhesus_Combobox;
        private System.Windows.Forms.ComboBox Fylo_combobox;
        private System.Windows.Forms.DateTimePicker birthYearDateTimePicker;
        private System.Windows.Forms.Label labelIdAimodoti;
    }
}