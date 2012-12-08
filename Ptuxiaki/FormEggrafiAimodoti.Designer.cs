namespace Ptuxiaki
{
    partial class FormEggrafiAimodoti
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
            System.Windows.Forms.Label omadaAimatosLabel;
            System.Windows.Forms.Label rhesusLabel;
            System.Windows.Forms.Label birthYearLabel;
            System.Windows.Forms.Label jobLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumber1Label;
            System.Windows.Forms.Label phoneNumber2Label;
            System.Windows.Forms.Label fylloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEggrafiAimodoti));
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.πλήρηςΠροβολήToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterSwitcher = new System.Windows.Forms.ToolStripMenuItem();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumber1TextBox = new System.Windows.Forms.TextBox();
            this.phoneNumber2TextBox = new System.Windows.Forms.TextBox();
            this.BirthDay_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.aimodotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aimodotesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.Omada_Aimatos_comboBox = new System.Windows.Forms.ComboBox();
            this.Rhesus_comboBox1 = new System.Windows.Forms.ComboBox();
            this.fylloComboBox = new System.Windows.Forms.ComboBox();
            this.TelError2 = new System.Windows.Forms.Label();
            this.TelError1 = new System.Windows.Forms.Label();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            omadaAimatosLabel = new System.Windows.Forms.Label();
            rhesusLabel = new System.Windows.Forms.Label();
            birthYearLabel = new System.Windows.Forms.Label();
            jobLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumber1Label = new System.Windows.Forms.Label();
            phoneNumber2Label = new System.Windows.Forms.Label();
            fylloLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            nameLabel.Location = new System.Drawing.Point(16, 72);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(54, 14);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Όνομα:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            lastNameLabel.Location = new System.Drawing.Point(16, 98);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(68, 14);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Επώνυμο:";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            fatherNameLabel.Location = new System.Drawing.Point(16, 126);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new System.Drawing.Size(104, 14);
            fatherNameLabel.TabIndex = 7;
            fatherNameLabel.Text = "Όνομα Πατρός:";
            // 
            // omadaAimatosLabel
            // 
            omadaAimatosLabel.AutoSize = true;
            omadaAimatosLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            omadaAimatosLabel.Location = new System.Drawing.Point(16, 184);
            omadaAimatosLabel.Name = "omadaAimatosLabel";
            omadaAimatosLabel.Size = new System.Drawing.Size(104, 14);
            omadaAimatosLabel.TabIndex = 9;
            omadaAimatosLabel.Text = "Ομάδα Αίματος:";
            // 
            // rhesusLabel
            // 
            rhesusLabel.AutoSize = true;
            rhesusLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            rhesusLabel.Location = new System.Drawing.Point(16, 210);
            rhesusLabel.Name = "rhesusLabel";
            rhesusLabel.Size = new System.Drawing.Size(55, 14);
            rhesusLabel.TabIndex = 11;
            rhesusLabel.Text = "Rhesus:";
            // 
            // birthYearLabel
            // 
            birthYearLabel.AutoSize = true;
            birthYearLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            birthYearLabel.Location = new System.Drawing.Point(16, 236);
            birthYearLabel.Name = "birthYearLabel";
            birthYearLabel.Size = new System.Drawing.Size(103, 14);
            birthYearLabel.TabIndex = 13;
            birthYearLabel.Text = "Έτος Γέννησης:";
            // 
            // jobLabel
            // 
            jobLabel.AutoSize = true;
            jobLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            jobLabel.Location = new System.Drawing.Point(16, 262);
            jobLabel.Name = "jobLabel";
            jobLabel.Size = new System.Drawing.Size(77, 14);
            jobLabel.TabIndex = 15;
            jobLabel.Text = "Επάγγελμα:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            addressLabel.Location = new System.Drawing.Point(16, 288);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(76, 14);
            addressLabel.TabIndex = 17;
            addressLabel.Text = "Διεύθυνση:";
            // 
            // phoneNumber1Label
            // 
            phoneNumber1Label.AutoSize = true;
            phoneNumber1Label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            phoneNumber1Label.Location = new System.Drawing.Point(16, 314);
            phoneNumber1Label.Name = "phoneNumber1Label";
            phoneNumber1Label.Size = new System.Drawing.Size(88, 14);
            phoneNumber1Label.TabIndex = 19;
            phoneNumber1Label.Text = "Τηλέφωνο 1:";
            // 
            // phoneNumber2Label
            // 
            phoneNumber2Label.AutoSize = true;
            phoneNumber2Label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            phoneNumber2Label.Location = new System.Drawing.Point(16, 340);
            phoneNumber2Label.Name = "phoneNumber2Label";
            phoneNumber2Label.Size = new System.Drawing.Size(88, 14);
            phoneNumber2Label.TabIndex = 21;
            phoneNumber2Label.Text = "Τηλέφωνο 2:";
            // 
            // fylloLabel
            // 
            fylloLabel.AutoSize = true;
            fylloLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            fylloLabel.Location = new System.Drawing.Point(16, 155);
            fylloLabel.Name = "fylloLabel";
            fylloLabel.Size = new System.Drawing.Size(49, 14);
            fylloLabel.TabIndex = 36;
            fylloLabel.Text = "Φύλο :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = global::Ptuxiaki.Properties.Resources._1300790450_3floppy_unmount;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(139, 398);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 40);
            this.btnSave.TabIndex = 11;
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
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 24;
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
            this.πλήρηςΠροβολήToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.πλήρηςΠροβολήToolStripMenuItem.Text = "Πλήρης προβολή";
            this.πλήρηςΠροβολήToolStripMenuItem.Click += new System.EventHandler(this.πλήρηςΠροβολήToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FilterSwitcher});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionsToolStripMenuItem.Text = "Ιδιότητες";
            // 
            // FilterSwitcher
            // 
            this.FilterSwitcher.Checked = true;
            this.FilterSwitcher.CheckOnClick = true;
            this.FilterSwitcher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterSwitcher.Name = "FilterSwitcher";
            this.FilterSwitcher.Size = new System.Drawing.Size(169, 22);
            this.FilterSwitcher.Text = "Φίλτρο Εγγραφής";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(139, 72);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(176, 21);
            this.nameTextBox.TabIndex = 25;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(139, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(176, 21);
            this.lastNameTextBox.TabIndex = 26;
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fatherNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.fatherNameTextBox.Location = new System.Drawing.Point(139, 126);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(176, 21);
            this.fatherNameTextBox.TabIndex = 27;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.jobTextBox.ForeColor = System.Drawing.Color.Black;
            this.jobTextBox.Location = new System.Drawing.Point(139, 262);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(176, 21);
            this.jobTextBox.TabIndex = 31;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.addressTextBox.ForeColor = System.Drawing.Color.Black;
            this.addressTextBox.Location = new System.Drawing.Point(139, 288);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(176, 21);
            this.addressTextBox.TabIndex = 32;
            // 
            // phoneNumber1TextBox
            // 
            this.phoneNumber1TextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumber1TextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumber1TextBox.Location = new System.Drawing.Point(139, 314);
            this.phoneNumber1TextBox.Name = "phoneNumber1TextBox";
            this.phoneNumber1TextBox.Size = new System.Drawing.Size(176, 21);
            this.phoneNumber1TextBox.TabIndex = 33;
            this.phoneNumber1TextBox.TextChanged += new System.EventHandler(this.phoneNumber1TextBox_TextChanged);
            this.phoneNumber1TextBox.Leave += new System.EventHandler(this.phoneNumber1TextBox_Leave);
            // 
            // phoneNumber2TextBox
            // 
            this.phoneNumber2TextBox.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.phoneNumber2TextBox.ForeColor = System.Drawing.Color.Maroon;
            this.phoneNumber2TextBox.Location = new System.Drawing.Point(139, 340);
            this.phoneNumber2TextBox.Name = "phoneNumber2TextBox";
            this.phoneNumber2TextBox.Size = new System.Drawing.Size(176, 21);
            this.phoneNumber2TextBox.TabIndex = 34;
            this.phoneNumber2TextBox.TextChanged += new System.EventHandler(this.phoneNumber2TextBox_TextChanged);
            this.phoneNumber2TextBox.Leave += new System.EventHandler(this.phoneNumber2TextBox_Leave);
            // 
            // BirthDay_dateTimePicker1
            // 
            this.BirthDay_dateTimePicker1.Location = new System.Drawing.Point(139, 235);
            this.BirthDay_dateTimePicker1.Name = "BirthDay_dateTimePicker1";
            this.BirthDay_dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.BirthDay_dateTimePicker1.TabIndex = 39;
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
            // Omada_Aimatos_comboBox
            // 
            this.Omada_Aimatos_comboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "OmadaAimatos", true));
            this.Omada_Aimatos_comboBox.FormattingEnabled = true;
            this.Omada_Aimatos_comboBox.Items.AddRange(new object[] {
            "Α",
            "Β",
            "ΑΒ",
            "Ο"});
            this.Omada_Aimatos_comboBox.Location = new System.Drawing.Point(139, 182);
            this.Omada_Aimatos_comboBox.Name = "Omada_Aimatos_comboBox";
            this.Omada_Aimatos_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Omada_Aimatos_comboBox.TabIndex = 41;
            this.Omada_Aimatos_comboBox.Leave += new System.EventHandler(this.Omada_Aimatos_comboBox_Leave);
            // 
            // Rhesus_comboBox1
            // 
            this.Rhesus_comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "Rhesus", true));
            this.Rhesus_comboBox1.FormattingEnabled = true;
            this.Rhesus_comboBox1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.Rhesus_comboBox1.Location = new System.Drawing.Point(139, 208);
            this.Rhesus_comboBox1.Name = "Rhesus_comboBox1";
            this.Rhesus_comboBox1.Size = new System.Drawing.Size(121, 21);
            this.Rhesus_comboBox1.TabIndex = 42;
            this.Rhesus_comboBox1.Leave += new System.EventHandler(this.Rhesus_comboBox1_Leave);
            // 
            // fylloComboBox
            // 
            this.fylloComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "Fyllo", true));
            this.fylloComboBox.FormattingEnabled = true;
            this.fylloComboBox.Items.AddRange(new object[] {
            "Άνδρας",
            "Γυναίκα"});
            this.fylloComboBox.Location = new System.Drawing.Point(139, 153);
            this.fylloComboBox.Name = "fylloComboBox";
            this.fylloComboBox.Size = new System.Drawing.Size(121, 21);
            this.fylloComboBox.TabIndex = 43;
            this.fylloComboBox.Leave += new System.EventHandler(this.fylloComboBox_Leave);
            // 
            // TelError2
            // 
            this.TelError2.AutoSize = true;
            this.TelError2.ForeColor = System.Drawing.Color.Red;
            this.TelError2.Location = new System.Drawing.Point(321, 343);
            this.TelError2.Name = "TelError2";
            this.TelError2.Size = new System.Drawing.Size(108, 13);
            this.TelError2.TabIndex = 44;
            this.TelError2.Text = "Μη έγκυρος Αριθμός";
            this.TelError2.Visible = false;
            // 
            // TelError1
            // 
            this.TelError1.AutoSize = true;
            this.TelError1.ForeColor = System.Drawing.Color.Red;
            this.TelError1.Location = new System.Drawing.Point(321, 317);
            this.TelError1.Name = "TelError1";
            this.TelError1.Size = new System.Drawing.Size(108, 13);
            this.TelError1.TabIndex = 45;
            this.TelError1.Text = "Μη έγκυρος Αριθμός";
            this.TelError1.Visible = false;
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(433, 420);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(40, 32);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 46;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
            // 
            // FormEggrafiAimodoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 464);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.TelError1);
            this.Controls.Add(this.TelError2);
            this.Controls.Add(this.fylloComboBox);
            this.Controls.Add(this.Rhesus_comboBox1);
            this.Controls.Add(this.Omada_Aimatos_comboBox);
            this.Controls.Add(this.BirthDay_dateTimePicker1);
            this.Controls.Add(fylloLabel);
            this.Controls.Add(this.phoneNumber2TextBox);
            this.Controls.Add(this.phoneNumber1TextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.fatherNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.btnSave);
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
            this.Name = "FormEggrafiAimodoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή Αιμοδότη © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormEggrafiAimodoti_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πλήρηςΠροβολήToolStripMenuItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.TextBox jobTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumber1TextBox;
        private System.Windows.Forms.TextBox phoneNumber2TextBox;
        private System.Windows.Forms.DateTimePicker BirthDay_dateTimePicker1;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource aimodotesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox Omada_Aimatos_comboBox;
        private System.Windows.Forms.ComboBox Rhesus_comboBox1;
        private System.Windows.Forms.ComboBox fylloComboBox;
        private System.Windows.Forms.Label TelError2;
        private System.Windows.Forms.Label TelError1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FilterSwitcher;
        private System.Windows.Forms.PictureBox picboxClose;
    }
}