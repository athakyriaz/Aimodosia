namespace Ptuxiaki
{
    partial class FormStatisticsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatisticsView));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelSuxnoteriOmada = new System.Windows.Forms.Label();
            this.labelMOFialwnAimodotwn = new System.Windows.Forms.Label();
            this.labelEggramenoiAimodotes = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelOMinus = new System.Windows.Forms.Label();
            this.labelOPlus = new System.Windows.Forms.Label();
            this.labelABMinus = new System.Windows.Forms.Label();
            this.labelABPlus = new System.Windows.Forms.Label();
            this.labelBMinus = new System.Windows.Forms.Label();
            this.labelBPlus = new System.Windows.Forms.Label();
            this.labelAMinus = new System.Windows.Forms.Label();
            this.labelAPlus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelArithmosFialwn = new System.Windows.Forms.Label();
            this.labelFialesElegmenes = new System.Windows.Forms.Label();
            this.labelFialesAporifthikan = new System.Windows.Forms.Label();
            this.labelFialesLastMonth = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelPalaioterosSullogos = new System.Windows.Forms.Label();
            this.labelNumSullogoi = new System.Windows.Forms.Label();
            this.labelSyllogosMax = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picboxClose = new System.Windows.Forms.PictureBox();
            this.aimodotesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter();
            this.fialesTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter();
            this.syllogoiTableAdapter1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter();
            this.tableAdapterManager1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager();
            this.aimodotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ptuxiakiDatabaseDataSet1 = new Ptuxiaki.PtuxiakiDatabaseDataSet1();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(486, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.labelSuxnoteriOmada);
            this.tabPage1.Controls.Add(this.labelMOFialwnAimodotwn);
            this.tabPage1.Controls.Add(this.labelEggramenoiAimodotes);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(478, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Αιμοδότες";
            // 
            // labelSuxnoteriOmada
            // 
            this.labelSuxnoteriOmada.AutoSize = true;
            this.labelSuxnoteriOmada.ForeColor = System.Drawing.Color.Maroon;
            this.labelSuxnoteriOmada.Location = new System.Drawing.Point(204, 121);
            this.labelSuxnoteriOmada.Name = "labelSuxnoteriOmada";
            this.labelSuxnoteriOmada.Size = new System.Drawing.Size(51, 14);
            this.labelSuxnoteriOmada.TabIndex = 6;
            this.labelSuxnoteriOmada.Text = "label14";
            // 
            // labelMOFialwnAimodotwn
            // 
            this.labelMOFialwnAimodotwn.AutoSize = true;
            this.labelMOFialwnAimodotwn.ForeColor = System.Drawing.Color.Maroon;
            this.labelMOFialwnAimodotwn.Location = new System.Drawing.Point(204, 72);
            this.labelMOFialwnAimodotwn.Name = "labelMOFialwnAimodotwn";
            this.labelMOFialwnAimodotwn.Size = new System.Drawing.Size(51, 14);
            this.labelMOFialwnAimodotwn.TabIndex = 5;
            this.labelMOFialwnAimodotwn.Text = "label13";
            // 
            // labelEggramenoiAimodotes
            // 
            this.labelEggramenoiAimodotes.AutoSize = true;
            this.labelEggramenoiAimodotes.ForeColor = System.Drawing.Color.Maroon;
            this.labelEggramenoiAimodotes.Location = new System.Drawing.Point(204, 30);
            this.labelEggramenoiAimodotes.Name = "labelEggramenoiAimodotes";
            this.labelEggramenoiAimodotes.Size = new System.Drawing.Size(51, 14);
            this.labelEggramenoiAimodotes.TabIndex = 4;
            this.labelEggramenoiAimodotes.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label11.Location = new System.Drawing.Point(6, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Συχνότερη Ομάδα Αίματος :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelOMinus);
            this.groupBox1.Controls.Add(this.labelOPlus);
            this.groupBox1.Controls.Add(this.labelABMinus);
            this.groupBox1.Controls.Add(this.labelABPlus);
            this.groupBox1.Controls.Add(this.labelBMinus);
            this.groupBox1.Controls.Add(this.labelBPlus);
            this.groupBox1.Controls.Add(this.labelAMinus);
            this.groupBox1.Controls.Add(this.labelAPlus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.groupBox1.Location = new System.Drawing.Point(9, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Στατιστικά Ομάδων Αίματος";
            // 
            // labelOMinus
            // 
            this.labelOMinus.AutoSize = true;
            this.labelOMinus.ForeColor = System.Drawing.Color.Maroon;
            this.labelOMinus.Location = new System.Drawing.Point(311, 146);
            this.labelOMinus.Name = "labelOMinus";
            this.labelOMinus.Size = new System.Drawing.Size(54, 16);
            this.labelOMinus.TabIndex = 14;
            this.labelOMinus.Text = "label14";
            // 
            // labelOPlus
            // 
            this.labelOPlus.AutoSize = true;
            this.labelOPlus.ForeColor = System.Drawing.Color.Maroon;
            this.labelOPlus.Location = new System.Drawing.Point(311, 110);
            this.labelOPlus.Name = "labelOPlus";
            this.labelOPlus.Size = new System.Drawing.Size(54, 16);
            this.labelOPlus.TabIndex = 13;
            this.labelOPlus.Text = "label14";
            // 
            // labelABMinus
            // 
            this.labelABMinus.AutoSize = true;
            this.labelABMinus.ForeColor = System.Drawing.Color.Maroon;
            this.labelABMinus.Location = new System.Drawing.Point(311, 73);
            this.labelABMinus.Name = "labelABMinus";
            this.labelABMinus.Size = new System.Drawing.Size(54, 16);
            this.labelABMinus.TabIndex = 12;
            this.labelABMinus.Text = "label14";
            // 
            // labelABPlus
            // 
            this.labelABPlus.AutoSize = true;
            this.labelABPlus.ForeColor = System.Drawing.Color.Maroon;
            this.labelABPlus.Location = new System.Drawing.Point(311, 35);
            this.labelABPlus.Name = "labelABPlus";
            this.labelABPlus.Size = new System.Drawing.Size(54, 16);
            this.labelABPlus.TabIndex = 11;
            this.labelABPlus.Text = "label14";
            // 
            // labelBMinus
            // 
            this.labelBMinus.AutoSize = true;
            this.labelBMinus.ForeColor = System.Drawing.Color.Maroon;
            this.labelBMinus.Location = new System.Drawing.Point(67, 146);
            this.labelBMinus.Name = "labelBMinus";
            this.labelBMinus.Size = new System.Drawing.Size(54, 16);
            this.labelBMinus.TabIndex = 10;
            this.labelBMinus.Text = "label14";
            // 
            // labelBPlus
            // 
            this.labelBPlus.AutoSize = true;
            this.labelBPlus.ForeColor = System.Drawing.Color.Maroon;
            this.labelBPlus.Location = new System.Drawing.Point(67, 110);
            this.labelBPlus.Name = "labelBPlus";
            this.labelBPlus.Size = new System.Drawing.Size(54, 16);
            this.labelBPlus.TabIndex = 9;
            this.labelBPlus.Text = "label14";
            // 
            // labelAMinus
            // 
            this.labelAMinus.AutoSize = true;
            this.labelAMinus.ForeColor = System.Drawing.Color.Maroon;
            this.labelAMinus.Location = new System.Drawing.Point(67, 73);
            this.labelAMinus.Name = "labelAMinus";
            this.labelAMinus.Size = new System.Drawing.Size(54, 16);
            this.labelAMinus.TabIndex = 8;
            this.labelAMinus.Text = "label14";
            // 
            // labelAPlus
            // 
            this.labelAPlus.AutoSize = true;
            this.labelAPlus.ForeColor = System.Drawing.Color.Maroon;
            this.labelAPlus.Location = new System.Drawing.Point(68, 35);
            this.labelAPlus.Name = "labelAPlus";
            this.labelAPlus.Size = new System.Drawing.Size(54, 16);
            this.labelAPlus.TabIndex = 7;
            this.labelAPlus.Text = "label14";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(260, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Ο-  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(260, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Ο+ :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(260, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "ΑΒ-  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(260, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "ΑΒ+ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(26, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Β-  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(26, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Β+ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Α-  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Α+ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Μ.Ο. Φιαλών Ανα Αιμοδότη :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Εγγεγραμμένοι Αιμοδότες :";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.labelArithmosFialwn);
            this.tabPage2.Controls.Add(this.labelFialesElegmenes);
            this.tabPage2.Controls.Add(this.labelFialesAporifthikan);
            this.tabPage2.Controls.Add(this.labelFialesLastMonth);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(478, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Φιάλες";
            // 
            // labelArithmosFialwn
            // 
            this.labelArithmosFialwn.AutoSize = true;
            this.labelArithmosFialwn.ForeColor = System.Drawing.Color.Maroon;
            this.labelArithmosFialwn.Location = new System.Drawing.Point(233, 28);
            this.labelArithmosFialwn.Name = "labelArithmosFialwn";
            this.labelArithmosFialwn.Size = new System.Drawing.Size(51, 14);
            this.labelArithmosFialwn.TabIndex = 8;
            this.labelArithmosFialwn.Text = "label12";
            // 
            // labelFialesElegmenes
            // 
            this.labelFialesElegmenes.AutoSize = true;
            this.labelFialesElegmenes.ForeColor = System.Drawing.Color.Maroon;
            this.labelFialesElegmenes.Location = new System.Drawing.Point(233, 86);
            this.labelFialesElegmenes.Name = "labelFialesElegmenes";
            this.labelFialesElegmenes.Size = new System.Drawing.Size(51, 14);
            this.labelFialesElegmenes.TabIndex = 7;
            this.labelFialesElegmenes.Text = "label12";
            // 
            // labelFialesAporifthikan
            // 
            this.labelFialesAporifthikan.AutoSize = true;
            this.labelFialesAporifthikan.ForeColor = System.Drawing.Color.Maroon;
            this.labelFialesAporifthikan.Location = new System.Drawing.Point(233, 144);
            this.labelFialesAporifthikan.Name = "labelFialesAporifthikan";
            this.labelFialesAporifthikan.Size = new System.Drawing.Size(51, 14);
            this.labelFialesAporifthikan.TabIndex = 6;
            this.labelFialesAporifthikan.Text = "label12";
            // 
            // labelFialesLastMonth
            // 
            this.labelFialesLastMonth.AutoSize = true;
            this.labelFialesLastMonth.ForeColor = System.Drawing.Color.Maroon;
            this.labelFialesLastMonth.Location = new System.Drawing.Point(233, 210);
            this.labelFialesLastMonth.Name = "labelFialesLastMonth";
            this.labelFialesLastMonth.Size = new System.Drawing.Size(51, 14);
            this.labelFialesLastMonth.TabIndex = 5;
            this.labelFialesLastMonth.Text = "label12";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 210);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 14);
            this.label16.TabIndex = 4;
            this.label16.Text = "Φιάλες του Τελευταίου Μήνα :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(181, 14);
            this.label15.TabIndex = 3;
            this.label15.Text = "Φιάλες που Απορρίφθηκαν :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ελεγμένες Φιάλες :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(221, 14);
            this.label13.TabIndex = 1;
            this.label13.Text = "Πλήθος Φιάλων που έχουν Δωθεί :";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.tabPage3.Controls.Add(this.labelPalaioterosSullogos);
            this.tabPage3.Controls.Add(this.labelNumSullogoi);
            this.tabPage3.Controls.Add(this.labelSyllogosMax);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(478, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Σύλλογοι";
            // 
            // labelPalaioterosSullogos
            // 
            this.labelPalaioterosSullogos.AutoSize = true;
            this.labelPalaioterosSullogos.ForeColor = System.Drawing.Color.Maroon;
            this.labelPalaioterosSullogos.Location = new System.Drawing.Point(167, 188);
            this.labelPalaioterosSullogos.Name = "labelPalaioterosSullogos";
            this.labelPalaioterosSullogos.Size = new System.Drawing.Size(51, 14);
            this.labelPalaioterosSullogos.TabIndex = 11;
            this.labelPalaioterosSullogos.Text = "label12";
            // 
            // labelNumSullogoi
            // 
            this.labelNumSullogoi.AutoSize = true;
            this.labelNumSullogoi.ForeColor = System.Drawing.Color.Maroon;
            this.labelNumSullogoi.Location = new System.Drawing.Point(176, 28);
            this.labelNumSullogoi.Name = "labelNumSullogoi";
            this.labelNumSullogoi.Size = new System.Drawing.Size(51, 14);
            this.labelNumSullogoi.TabIndex = 10;
            this.labelNumSullogoi.Text = "label12";
            // 
            // labelSyllogosMax
            // 
            this.labelSyllogosMax.AutoSize = true;
            this.labelSyllogosMax.ForeColor = System.Drawing.Color.Maroon;
            this.labelSyllogosMax.Location = new System.Drawing.Point(255, 108);
            this.labelSyllogosMax.Name = "labelSyllogosMax";
            this.labelSyllogosMax.Size = new System.Drawing.Size(51, 14);
            this.labelSyllogosMax.TabIndex = 9;
            this.labelSyllogosMax.Text = "label12";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 188);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 14);
            this.label18.TabIndex = 3;
            this.label18.Text = "Παλαιότερος Σύλλογος :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(243, 14);
            this.label17.TabIndex = 2;
            this.label17.Text = "Σύλλογος με τις Περισσότερες Φιάλες :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 14);
            this.label12.TabIndex = 1;
            this.label12.Text = "Εγγεγραμμένοι Σύλλογοι :";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnClose.Location = new System.Drawing.Point(196, 427);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "ΚΛΕΙΣΙΜΟ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picboxClose
            // 
            this.picboxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxClose.Image = global::Ptuxiaki.Properties.Resources._1301507896_Windows_Turn_Off;
            this.picboxClose.Location = new System.Drawing.Point(472, 445);
            this.picboxClose.Name = "picboxClose";
            this.picboxClose.Size = new System.Drawing.Size(26, 21);
            this.picboxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxClose.TabIndex = 44;
            this.picboxClose.TabStop = false;
            this.picboxClose.Click += new System.EventHandler(this.picboxClose_Click);
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
            // ptuxiakiDatabaseDataSet1
            // 
            this.ptuxiakiDatabaseDataSet1.DataSetName = "PtuxiakiDatabaseDataSet1";
            this.ptuxiakiDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormStatisticsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(518, 476);
            this.Controls.Add(this.picboxClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormStatisticsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Στατιστικά Στοιχεία © Κυριαζόπουλος Αθανάσιος";
            this.Load += new System.EventHandler(this.FormStatisticsView_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimodotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptuxiakiDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label labelSuxnoteriOmada;
        private System.Windows.Forms.Label labelMOFialwnAimodotwn;
        private System.Windows.Forms.Label labelEggramenoiAimodotes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelOMinus;
        private System.Windows.Forms.Label labelOPlus;
        private System.Windows.Forms.Label labelABMinus;
        private System.Windows.Forms.Label labelABPlus;
        private System.Windows.Forms.Label labelBMinus;
        private System.Windows.Forms.Label labelBPlus;
        private System.Windows.Forms.Label labelAMinus;
        private System.Windows.Forms.Label labelAPlus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picboxClose;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelArithmosFialwn;
        private System.Windows.Forms.Label labelFialesElegmenes;
        private System.Windows.Forms.Label labelFialesAporifthikan;
        private System.Windows.Forms.Label labelFialesLastMonth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelSyllogosMax;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelPalaioterosSullogos;
        private System.Windows.Forms.Label labelNumSullogoi;
        private PtuxiakiDatabaseDataSet1TableAdapters.AimodotesTableAdapter aimodotesTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.FialesTableAdapter fialesTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.SyllogoiTableAdapter syllogoiTableAdapter1;
        private PtuxiakiDatabaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource aimodotesBindingSource;
        private PtuxiakiDatabaseDataSet1 ptuxiakiDatabaseDataSet1;
    }
}