namespace Ptuxiaki
{
    partial class FormFindFialiFromMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindFialiFromMenu));
            this.textBoxSearchFiali = new System.Windows.Forms.TextBox();
            this.btnFindFiali = new System.Windows.Forms.Button();
            this.ptuxiakiDatabaseDataSet11 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.fialesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSearchFiali
            // 
            this.textBoxSearchFiali.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.textBoxSearchFiali.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxSearchFiali.Location = new System.Drawing.Point(64, 36);
            this.textBoxSearchFiali.Name = "textBoxSearchFiali";
            this.textBoxSearchFiali.Size = new System.Drawing.Size(219, 27);
            this.textBoxSearchFiali.TabIndex = 0;
            this.textBoxSearchFiali.Text = "Κωδικός Φιάλης";
            this.textBoxSearchFiali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSearchFiali.Click += new System.EventHandler(this.textBoxSearchFiali_Click);
            this.textBoxSearchFiali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchFiali_KeyPress);
            // 
            // btnFindFiali
            // 
            this.btnFindFiali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindFiali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindFiali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnFindFiali.Image = global::Ptuxiaki.Properties.Resources.search_2_;
            this.btnFindFiali.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindFiali.Location = new System.Drawing.Point(102, 91);
            this.btnFindFiali.Name = "btnFindFiali";
            this.btnFindFiali.Size = new System.Drawing.Size(140, 44);
            this.btnFindFiali.TabIndex = 61;
            this.btnFindFiali.Text = "Εύρεση";
            this.btnFindFiali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindFiali.UseVisualStyleBackColor = true;
            this.btnFindFiali.Click += new System.EventHandler(this.btnFindFiali_Click);
            // 
            // ptuxiakiDatabaseDataSet11
            // 
            this.ptuxiakiDatabaseDataSet11.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fialesTableAdapter1
            // 
            this.fialesTableAdapter1.ClearBeforeFill = true;
            // 
            // FormFindFialiFromMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 162);
            this.Controls.Add(this.btnFindFiali);
            this.Controls.Add(this.textBoxSearchFiali);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFindFialiFromMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εύρεση Φιάλης © Κυριαζόπουλος Αθανάσιος";
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSearchFiali;
        private System.Windows.Forms.Button btnFindFiali;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet11;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter1;
    }
}