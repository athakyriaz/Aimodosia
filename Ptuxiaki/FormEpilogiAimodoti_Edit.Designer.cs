namespace Ptuxiaki
{
    partial class FormEpilogiAimodoti_Edit
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label fatherNameLabel;
            System.Windows.Forms.Label omadaAimatosLabel;
            System.Windows.Forms.Label rhesusLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label phoneNumber1Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEpilogiAimodoti_Edit));
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.aimodotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aimodotesTableAdapter = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.tableAdapterManager = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.aimodotesDataRepeater = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.picBoxTick = new System.Windows.Forms.PictureBox();
            this.phoneNumber1Label1 = new System.Windows.Forms.Label();
            this.addressLabel1 = new System.Windows.Forms.Label();
            this.rhesusLabel1 = new System.Windows.Forms.Label();
            this.omadaAimatosLabel1 = new System.Windows.Forms.Label();
            this.fatherNameLabel1 = new System.Windows.Forms.Label();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.lastNameLabel1 = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            fatherNameLabel = new System.Windows.Forms.Label();
            omadaAimatosLabel = new System.Windows.Forms.Label();
            rhesusLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            phoneNumber1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).BeginInit();
            this.aimodotesDataRepeater.ItemTemplate.SuspendLayout();
            this.aimodotesDataRepeater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            nameLabel.Location = new System.Drawing.Point(3, 5);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Όνομα :";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            lastNameLabel.Location = new System.Drawing.Point(3, 57);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(62, 17);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Επίθετο :";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            iDLabel.Location = new System.Drawing.Point(238, 5);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(27, 17);
            iDLabel.TabIndex = 4;
            iDLabel.Text = "ID:";
            // 
            // fatherNameLabel
            // 
            fatherNameLabel.AutoSize = true;
            fatherNameLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            fatherNameLabel.Location = new System.Drawing.Point(203, 57);
            fatherNameLabel.Name = "fatherNameLabel";
            fatherNameLabel.Size = new System.Drawing.Size(85, 17);
            fatherNameLabel.TabIndex = 6;
            fatherNameLabel.Text = "Πατρώνυμο :";
            // 
            // omadaAimatosLabel
            // 
            omadaAimatosLabel.AutoSize = true;
            omadaAimatosLabel.BackColor = System.Drawing.SystemColors.Control;
            omadaAimatosLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            omadaAimatosLabel.Location = new System.Drawing.Point(335, 5);
            omadaAimatosLabel.Name = "omadaAimatosLabel";
            omadaAimatosLabel.Size = new System.Drawing.Size(110, 17);
            omadaAimatosLabel.TabIndex = 8;
            omadaAimatosLabel.Text = "Ομάδα Αίματος :";
            // 
            // rhesusLabel
            // 
            rhesusLabel.AutoSize = true;
            rhesusLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            rhesusLabel.Location = new System.Drawing.Point(379, 57);
            rhesusLabel.Name = "rhesusLabel";
            rhesusLabel.Size = new System.Drawing.Size(54, 17);
            rhesusLabel.TabIndex = 10;
            rhesusLabel.Text = "Rhesus:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            addressLabel.Location = new System.Drawing.Point(509, 5);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(79, 17);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Διεύθυνση :";
            // 
            // phoneNumber1Label
            // 
            phoneNumber1Label.AutoSize = true;
            phoneNumber1Label.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            phoneNumber1Label.Location = new System.Drawing.Point(509, 57);
            phoneNumber1Label.Name = "phoneNumber1Label";
            phoneNumber1Label.Size = new System.Drawing.Size(76, 17);
            phoneNumber1Label.TabIndex = 14;
            phoneNumber1Label.Text = "Τηλέφωνο :";
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
            // 
            // aimodotesDataRepeater
            // 
            this.aimodotesDataRepeater.AllowUserToAddItems = false;
            this.aimodotesDataRepeater.AllowUserToDeleteItems = false;
            this.aimodotesDataRepeater.DataSource = this.aimodotesBindingSource;
            this.aimodotesDataRepeater.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // aimodotesDataRepeater.ItemTemplate
            // 
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.picBoxTick);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(phoneNumber1Label);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.phoneNumber1Label1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(addressLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.addressLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(rhesusLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.rhesusLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(omadaAimatosLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.omadaAimatosLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(fatherNameLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.fatherNameLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(iDLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.iDLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(lastNameLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.lastNameLabel1);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(nameLabel);
            this.aimodotesDataRepeater.ItemTemplate.Controls.Add(this.labelname);
            this.aimodotesDataRepeater.ItemTemplate.Size = new System.Drawing.Size(834, 87);
            this.aimodotesDataRepeater.Location = new System.Drawing.Point(0, 0);
            this.aimodotesDataRepeater.Name = "aimodotesDataRepeater";
            this.aimodotesDataRepeater.Size = new System.Drawing.Size(842, 308);
            this.aimodotesDataRepeater.TabIndex = 1;
            this.aimodotesDataRepeater.Text = "dataRepeater1";
            // 
            // picBoxTick
            // 
            this.picBoxTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxTick.Image = global::Ptuxiaki.Properties.Resources._1301510751_success;
            this.picBoxTick.Location = new System.Drawing.Point(737, 20);
            this.picBoxTick.Name = "picBoxTick";
            this.picBoxTick.Size = new System.Drawing.Size(56, 50);
            this.picBoxTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTick.TabIndex = 16;
            this.picBoxTick.TabStop = false;
            this.picBoxTick.Click += new System.EventHandler(this.picBoxTick_Click);
            // 
            // phoneNumber1Label1
            // 
            this.phoneNumber1Label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "PhoneNumber1", true));
            this.phoneNumber1Label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.phoneNumber1Label1.ForeColor = System.Drawing.Color.Maroon;
            this.phoneNumber1Label1.Location = new System.Drawing.Point(591, 57);
            this.phoneNumber1Label1.Name = "phoneNumber1Label1";
            this.phoneNumber1Label1.Size = new System.Drawing.Size(100, 23);
            this.phoneNumber1Label1.TabIndex = 15;
            this.phoneNumber1Label1.Text = "label1";
            // 
            // addressLabel1
            // 
            this.addressLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "Address", true));
            this.addressLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.addressLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.addressLabel1.Location = new System.Drawing.Point(594, 5);
            this.addressLabel1.Name = "addressLabel1";
            this.addressLabel1.Size = new System.Drawing.Size(100, 23);
            this.addressLabel1.TabIndex = 13;
            this.addressLabel1.Text = "label1";
            // 
            // rhesusLabel1
            // 
            this.rhesusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "Rhesus", true));
            this.rhesusLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.rhesusLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.rhesusLabel1.Location = new System.Drawing.Point(431, 57);
            this.rhesusLabel1.Name = "rhesusLabel1";
            this.rhesusLabel1.Size = new System.Drawing.Size(100, 23);
            this.rhesusLabel1.TabIndex = 11;
            this.rhesusLabel1.Text = "label1";
            // 
            // omadaAimatosLabel1
            // 
            this.omadaAimatosLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "OmadaAimatos", true));
            this.omadaAimatosLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.omadaAimatosLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.omadaAimatosLabel1.Location = new System.Drawing.Point(451, 5);
            this.omadaAimatosLabel1.Name = "omadaAimatosLabel1";
            this.omadaAimatosLabel1.Size = new System.Drawing.Size(100, 23);
            this.omadaAimatosLabel1.TabIndex = 9;
            this.omadaAimatosLabel1.Text = "label1";
            // 
            // fatherNameLabel1
            // 
            this.fatherNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "FatherName", true));
            this.fatherNameLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic);
            this.fatherNameLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.fatherNameLabel1.Location = new System.Drawing.Point(294, 57);
            this.fatherNameLabel1.Name = "fatherNameLabel1";
            this.fatherNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.fatherNameLabel1.TabIndex = 7;
            this.fatherNameLabel1.Text = "label1";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "ID", true));
            this.iDLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.iDLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.iDLabel1.Location = new System.Drawing.Point(265, 5);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 5;
            this.iDLabel1.Text = "label1";
            // 
            // lastNameLabel1
            // 
            this.lastNameLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lastNameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "LastName", true));
            this.lastNameLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lastNameLabel1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lastNameLabel1.ForeColor = System.Drawing.Color.Maroon;
            this.lastNameLabel1.Location = new System.Drawing.Point(71, 57);
            this.lastNameLabel1.Name = "lastNameLabel1";
            this.lastNameLabel1.Size = new System.Drawing.Size(126, 23);
            this.lastNameLabel1.TabIndex = 3;
            this.lastNameLabel1.Text = "label1";
            // 
            // labelname
            // 
            this.labelname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aimodotesBindingSource, "Name", true));
            this.labelname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelname.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelname.ForeColor = System.Drawing.Color.Maroon;
            this.labelname.Location = new System.Drawing.Point(61, 5);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(100, 23);
            this.labelname.TabIndex = 1;
            this.labelname.Text = "label1";
            // 
            // FormEpilogiAimodoti_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 308);
            this.Controls.Add(this.aimodotesDataRepeater);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEpilogiAimodoti_Edit";
            this.Text = "Επιλογή Αιμοδότη © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormEpilogiAimodoti_Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).EndInit();
            this.aimodotesDataRepeater.ItemTemplate.ResumeLayout(false);
            this.aimodotesDataRepeater.ItemTemplate.PerformLayout();
            this.aimodotesDataRepeater.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTick)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
        private System.Windows.Forms.BindingSource aimodotesBindingSource;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Microsoft.VisualBasic.PowerPacks.DataRepeater aimodotesDataRepeater;
        private System.Windows.Forms.Label phoneNumber1Label1;
        private System.Windows.Forms.Label addressLabel1;
        private System.Windows.Forms.Label rhesusLabel1;
        private System.Windows.Forms.Label omadaAimatosLabel1;
        private System.Windows.Forms.Label fatherNameLabel1;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.Label lastNameLabel1;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.PictureBox picBoxTick;
    }
}