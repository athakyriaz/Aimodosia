using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class HistoryForm : Form
    {
       // public long IDHistory;
  

        public long IDaimodoti;
        string q1ans = "";
        string q2ans = "";
        string q3ans = "";
        string q4ans = "";
        string q5ans = "";
        string q7ans = "";
        string q8ans = "";
        string q9ans = "";
        string q10ans = "";
        string q11ans = "";
        string q12ans = "";
        string q13ans = "";
        string q14ans = "";
        string q15ans = "";
        string q16ans = "";
        string q17ans = "";
        string q18ans = "";
        string q19ans = "";
        string q20ans = "";
        string q21ans = "";
        string q22ans = "";

        public string katigoriaAim;




        public HistoryForm()
        {
            InitializeComponent();
         

        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxQ1_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ1_1.Checked)
            {
                checkBoxQ1_2.Checked = false;
                DateTimePicker_Q6.Visible = true;
                label36.Visible = true;
            }
        }

        private void checkBoxQ1_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ1_2.Checked)
                checkBoxQ1_1.Checked = false;
            DateTimePicker_Q6.Visible = false;
            label36.Visible = false;
        }

        private void checkBoxQ2_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ2_1.Checked)
                checkBoxQ2_2.Checked = false;
        }

        private void checkBoxQ2_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ2_2.Checked)
                checkBoxQ2_1.Checked = false;
        }

        private void checkBoxQ3_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ3_1.Checked)
                checkBoxQ3_2.Checked = false;
        }

        private void checkBoxQ3_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ3_2.Checked)
                checkBoxQ3_1.Checked = false;
        }

        private void checkBoxQ4_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ4_1.Checked)
                checkBoxQ4_2.Checked = false;
        }

        private void checkBoxQ4_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ4_2.Checked)
                checkBoxQ4_1.Checked = false;
        }

        private void checkBoxQ7_1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxQ7_1.Checked)
                checkBoxQ7_2.Checked = false;
        }

        private void checkBoxQ7_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ7_2.Checked)
                checkBoxQ7_1.Checked = false;
        }

        private void checkBoxQ8_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ8_1.Checked)
                checkBoxQ8_2.Checked = false;
        }

        private void checkBoxQ8_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ8_2.Checked)
                checkBoxQ8_1.Checked = false;
        }

        private void checkBoxQ9_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ9_1.Checked)
                checkBoxQ9_2.Checked = false;
        }

        private void checkBoxQ9_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ9_2.Checked)
                checkBoxQ9_1.Checked = false;
        }

        private void checkBoxQ10_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ10_1.Checked)
                checkBoxQ10_2.Checked = false;
        }

        private void checkBoxQ10_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ10_2.Checked)
                checkBoxQ10_1.Checked = false;
        }

        private void checkBoxQ11_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ11_1.Checked)
                checkBoxQ11_2.Checked = false;
        }

        private void checkBoxQ11_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ11_2.Checked)
                checkBoxQ11_1.Checked = false;
        }

        private void checkBoxQ12_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ12_1.Checked)
                checkBoxQ12_2.Checked = false;
        }

        private void checkBoxQ12_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ12_2.Checked)
                checkBoxQ12_1.Checked = false;
        }

        private void checkBoxQ13_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ13_1.Checked)
                checkBoxQ13_2.Checked = false;
        }

        private void checkBoxQ13_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ13_2.Checked)
                checkBoxQ13_1.Checked = false;
        }

        private void checkBoxQ14_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ14_1.Checked)
                checkBoxQ14_2.Checked = false;
        }

        private void checkBoxQ14_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ14_2.Checked)
                checkBoxQ14_1.Checked = false;
        }

        private void checkBoxQ15_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ15_1.Checked)
                checkBoxQ15_2.Checked = false;
        }

        private void checkBoxQ15_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ15_2.Checked)
                checkBoxQ15_1.Checked = false;
        }

        private void checkBoxQ16_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ16_1.Checked)
                checkBoxQ16_2.Checked = false;
        }

        private void checkBoxQ16_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ16_2.Checked)
                checkBoxQ16_1.Checked = false;
        }

        private void checkBoxQ17_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ17_1.Checked)
                checkBoxQ17_2.Checked = false;
        }

        private void checkBoxQ17_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ17_2.Checked)
                checkBoxQ17_1.Checked = false;
        }

        private void checkBoxQ18_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ18_1.Checked)
                checkBoxQ18_2.Checked = false;
        }

        private void checkBoxQ18_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ18_2.Checked)
                checkBoxQ18_1.Checked = false;
        }

        private void checkBoxQ19_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ19_1.Checked)
                checkBoxQ19_2.Checked = false;
        }

        private void checkBoxQ19_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ19_2.Checked)
                checkBoxQ19_1.Checked = false;
        }

        private void checkBoxQ20_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ20_1.Checked)
                checkBoxQ20_2.Checked = false;
        }

        private void checkBoxQ20_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ20_2.Checked)
                checkBoxQ20_1.Checked = false;
        }

        private void checkBoxQ21_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ21_1.Checked)
                checkBoxQ21_2.Checked = false;
        }

        private void checkBoxQ21_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ21_2.Checked)
                checkBoxQ21_1.Checked = false;
        }

        private void checkBoxQ22_1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ22_1.Checked)
                checkBoxQ22_2.Checked = false;
        }

        private void checkBoxQ22_2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQ22_2.Checked)
                checkBoxQ22_1.Checked = false;
        }


        public void ShowData()
        {
            PtuxiakiDatabaseDataSet1.IstorikoRow IstorikoRow = ptuxiakiDatabaseDataSet1.Istoriko.FindByIDistorikou(Idistorikou);
            long IdAimod = IstorikoRow.IDaimodoti;
            btnSave.Visible = false;
            txtbox_Aimatokritis.ReadOnly = txtbox_aimosferini.ReadOnly = txtbox_genika.ReadOnly = txtbox_Ipsos.ReadOnly = txtbox_piesh.ReadOnly = txtbox_sfikseis.ReadOnly = txtbox_thermokrasia.ReadOnly = txtbox_varos.ReadOnly = true;
            dateTimePickerHistory.Value = IstorikoRow.date;
            txtbox_piesh.Text = IstorikoRow.piesh.ToString();
            txtbox_sfikseis.Text = IstorikoRow.sfikeis.ToString();
            txtbox_thermokrasia.Text = IstorikoRow.thermokrasia.ToString();
            txtbox_varos.Text = IstorikoRow.varos.ToString();
            txtbox_Aimatokritis.Text = IstorikoRow.aimatokriths.ToString();
            txtbox_aimosferini.Text = IstorikoRow.aimosferini.ToString();         
            txtbox_Ipsos.Text = IstorikoRow.ipsos.ToString();
            txtbox_genika.Text = IstorikoRow.genika.ToString();
            if (IstorikoRow.Q1.ToString() == "ΝΑΙ")
            {
                checkBoxQ1_1.Checked = true;
                checkBoxQ1_2.Visible = false;
            }
            else if (IstorikoRow.Q1.ToString() == "OXI")
            {
                checkBoxQ1_2.Checked = true;
                checkBoxQ1_1.Visible = false;
            }
            if (IstorikoRow.Q2.ToString() == "ΝΑΙ")
            {
                checkBoxQ2_1.Checked = true;
                checkBoxQ2_2.Visible = false;
            }
            else if (IstorikoRow.Q2.ToString() == "OXI")
            {
                checkBoxQ2_2.Checked = true;
                checkBoxQ2_1.Visible = false;
            }
            if (IstorikoRow.Q3.ToString() == "ΝΑΙ")
            {
                checkBoxQ3_1.Checked = true;
                checkBoxQ3_2.Visible = false;
            }
            else if (IstorikoRow.Q3.ToString() == "OXI")
            {
                checkBoxQ3_2.Checked = true;
                checkBoxQ3_1.Visible = false;
            }
            if (IstorikoRow.Q4.ToString() == "ΝΑΙ")
            {
                checkBoxQ4_1.Checked = true;
                checkBoxQ4_2.Visible = false;
            }
            else if (IstorikoRow.Q4.ToString() == "OXI")
            {
                checkBoxQ4_2.Checked = true;
                checkBoxQ4_1.Visible = false;
            }
            if (IstorikoRow.Q7.ToString() == "ΝΑΙ")
            {
                checkBoxQ7_1.Checked = true;
                checkBoxQ7_2.Visible = false;
            }
            else if (IstorikoRow.Q7.ToString() == "OXI")
            {
                checkBoxQ7_2.Checked = true;
                checkBoxQ7_1.Visible = false;
            }
            DateTimePicker_Q6.Value = IstorikoRow.Q6;  
            if (IstorikoRow.Q8.ToString() == "ΝΑΙ")
            {
                checkBoxQ8_1.Checked = true;
                checkBoxQ8_2.Visible = false;
            }
            else if (IstorikoRow.Q8.ToString() == "OXI")
            {
                checkBoxQ8_2.Checked = true;
                checkBoxQ8_1.Visible = false;
            }
            if (IstorikoRow.Q9.ToString() == "ΝΑΙ")
            {
                checkBoxQ9_1.Checked = true;
                checkBoxQ9_2.Visible = false;
            }
            else if (IstorikoRow.Q9.ToString() == "OXI")
            {
                checkBoxQ9_2.Checked = true;
                checkBoxQ9_1.Visible = false;
            }
            if (IstorikoRow.Q10.ToString() == "ΝΑΙ")
            {
                checkBoxQ10_1.Checked = true;
                checkBoxQ10_2.Visible = false;
            }
            else if (IstorikoRow.Q10.ToString() == "OXI")
            {
                checkBoxQ10_2.Checked = true;
                checkBoxQ10_1.Visible = false;
            }
            if (IstorikoRow.Q11.ToString() == "ΝΑΙ")
            {
                checkBoxQ11_1.Checked = true;
                checkBoxQ11_2.Visible = false;
            }
            else if (IstorikoRow.Q11.ToString() == "OXI")
            {
                checkBoxQ11_2.Checked = true;
                checkBoxQ11_1.Visible = false;
            }
            if (IstorikoRow.Q12.ToString() == "ΝΑΙ")
            {
                checkBoxQ12_1.Checked = true;
                checkBoxQ12_2.Visible = false;
            }
            else if (IstorikoRow.Q12.ToString() == "OXI")
            {
                checkBoxQ12_2.Checked = true;
                checkBoxQ12_1.Visible = false;
            }
            if (IstorikoRow.Q13.ToString() == "ΝΑΙ")
            {
                checkBoxQ13_1.Checked = true;
                checkBoxQ13_2.Visible = false;
            }
            else if (IstorikoRow.Q13.ToString() == "OXI")
            {
                checkBoxQ13_2.Checked = true;
                checkBoxQ13_1.Visible = false;
            }
            if (IstorikoRow.Q14.ToString() == "ΝΑΙ")
            {
                checkBoxQ14_1.Checked = true;
                checkBoxQ14_2.Visible = false;
            }
            else if (IstorikoRow.Q14.ToString() == "OXI")
            {
                checkBoxQ14_2.Checked = true;
                checkBoxQ14_1.Visible = false;
            }
            if (IstorikoRow.Q15.ToString() == "ΝΑΙ")
            {
                checkBoxQ15_1.Checked = true;
                checkBoxQ15_2.Visible = false;
            }
            else if (IstorikoRow.Q15.ToString() == "OXI")
            {
                checkBoxQ15_2.Checked = true;
                checkBoxQ15_1.Visible = false;
            }
            if (IstorikoRow.Q16.ToString() == "ΝΑΙ")
            {
                checkBoxQ16_1.Checked = true;
                checkBoxQ16_2.Visible = false;
            }
            else if (IstorikoRow.Q16.ToString() == "OXI")
            {
                checkBoxQ16_2.Checked = true;
                checkBoxQ16_1.Visible = false;
            }
            if (IstorikoRow.Q17.ToString() == "ΝΑΙ")
            {
                checkBoxQ17_1.Checked = true;
                checkBoxQ17_2.Visible = false;
            }
            else if (IstorikoRow.Q17.ToString() == "OXI")
            {
                checkBoxQ17_2.Checked = true;
                checkBoxQ17_1.Visible = false;
            }
            if (IstorikoRow.Q18.ToString() == "ΝΑΙ")
            {
                checkBoxQ18_1.Checked = true;
                checkBoxQ18_2.Visible = false;
            }
            else if (IstorikoRow.Q18.ToString() == "OXI")
            {
                checkBoxQ18_2.Checked = true;
                checkBoxQ18_1.Visible = false;
            }
            if (IstorikoRow.Q19.ToString() == "ΝΑΙ")
            {
                checkBoxQ19_1.Checked = true;
                checkBoxQ19_2.Visible = false;
            }
            else if (IstorikoRow.Q19.ToString() == "OXI")
            {
                checkBoxQ19_2.Checked = true;
                checkBoxQ19_1.Visible = false;
            }
            if (IstorikoRow.Q20.ToString() == "ΝΑΙ")
            {
                checkBoxQ20_1.Checked = true;
                checkBoxQ20_2.Visible = false;
            }
            else if (IstorikoRow.Q20.ToString() == "OXI")
            {
                checkBoxQ20_2.Checked = true;
                checkBoxQ20_1.Visible = false;
            }
            if (IstorikoRow.Q21.ToString() == "ΝΑΙ")
            {
                checkBoxQ21_1.Checked = true;
                checkBoxQ21_2.Visible = false;
            }
            else if (IstorikoRow.Q21.ToString() == "OXI")
            {
                checkBoxQ21_2.Checked = true;
                checkBoxQ21_1.Visible = false;
            }
            if (IstorikoRow.Q22.ToString() == "ΝΑΙ")
            {
                checkBoxQ22_1.Checked = true;
                checkBoxQ22_2.Visible = false;
            }
            else if (IstorikoRow.Q22.ToString() == "OXI")
            {
                checkBoxQ22_2.Checked = true;
                checkBoxQ22_1.Visible = false;
            }

            CheckBox[] boxes = new CheckBox[18];

            boxes[0] = checkBoxQ5_1;
            boxes[1] = checkBoxQ5_2;
            boxes[2] = checkBoxQ5_3;
            boxes[3] = checkBoxQ5_4;
            boxes[4] = checkBoxQ5_5;
            boxes[5] = checkBoxQ5_6;
            boxes[6] = checkBoxQ5_7;      
            boxes[7] = checkBoxQ5_8;
            boxes[8] = checkBoxQ5_9;
            boxes[9] = checkBoxQ5_10;
            boxes[10] = checkBoxQ5_11;
            boxes[11] = checkBoxQ5_12;
            boxes[12] = checkBoxQ5_13;
            boxes[13] = checkBoxQ5_14;
            boxes[14] = checkBoxQ5_15;
            boxes[15] = checkBoxQ5_16;
            boxes[16] = checkBoxQ5_17;
            boxes[17] = checkBoxQ5_18;


            string[] asthenies = IstorikoRow.Q5.Split(',');         


            for (int i = 0; i < asthenies.Length; i++)
            {
                for (int j = 0; j < 18; j++)
                {
                    if (asthenies[i] == boxes[j].Text)
                    {
                        boxes[j].Checked = true;
                    }
                }
            }


            PtuxiakiDatabaseDataSet1.AimodotesRow AimodotisRow = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(IdAimod);
            label11.Text = AimodotisRow.OmadaAimatos;
            label12.Text = AimodotisRow.Rhesus;
        }

        public bool ShowOnly = false;
        public long Idistorikou;
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            this.istorikoTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Istoriko);
            this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);
            if (ShowOnly)
            {
                ShowData();
            }
            else
            {
                this.aimodotesTableAdapter.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);
                PtuxiakiDatabaseDataSet1.AimodotesRow stoixeia = ptuxiakiDatabaseDataSet1.Aimodotes.FindByID(IDaimodoti);
                label11.Text = stoixeia[4].ToString();
                label12.Text = stoixeia[5].ToString();
                DateTimePicker_Q6.Visible = false;
                label36.Visible = false;
            }
        }

        public long IDHistory;
        private void btnSave_Click(object sender, EventArgs e)
        {

            bool sfalma = false;
            bool lastdate=false;
            if (checkBoxQ1_1.Checked) { q1ans = "ΝΑΙ"; } else { q1ans = "OXI"; }
            if (checkBoxQ2_1.Checked) { q2ans = "ΝΑΙ"; } else { q2ans = "OXI"; }
            if (checkBoxQ3_1.Checked) { q3ans = "ΝΑΙ"; } else { q3ans = "OXI"; }
            if (checkBoxQ4_1.Checked) { q4ans = "ΝΑΙ"; } else { q4ans = "OXI"; }
            if (checkBoxQ7_1.Checked) { q7ans = "ΝΑΙ"; } else { q7ans = "OXI"; }
            if (checkBoxQ8_1.Checked) { q8ans = "ΝΑΙ"; } else { q8ans = "OXI"; }
            if (checkBoxQ9_1.Checked) { q9ans = "ΝΑΙ"; } else { q9ans = "OXI"; }
            if (checkBoxQ10_1.Checked) { q10ans = "ΝΑΙ"; } else { q10ans = "OXI"; }
            if (checkBoxQ11_1.Checked) { q11ans = "ΝΑΙ"; } else { q11ans = "OXI"; }
            if (checkBoxQ12_1.Checked) { q12ans = "ΝΑΙ"; } else { q12ans = "OXI"; }
            if (checkBoxQ13_1.Checked) { q13ans = "ΝΑΙ"; } else { q13ans = "OXI"; }
            if (checkBoxQ14_1.Checked) { q14ans = "ΝΑΙ"; } else { q14ans = "OXI"; }
            if (checkBoxQ15_1.Checked) { q15ans = "ΝΑΙ"; } else { q15ans = "OXI"; }
            if (checkBoxQ16_1.Checked) { q16ans = "ΝΑΙ"; } else { q16ans = "OXI"; }
            if (checkBoxQ17_1.Checked) { q17ans = "ΝΑΙ"; } else { q17ans = "OXI"; }
            if (checkBoxQ18_1.Checked) { q18ans = "ΝΑΙ"; } else { q18ans = "OXI"; }
            if (checkBoxQ19_1.Checked) { q19ans = "ΝΑΙ"; } else { q19ans = "OXI"; }
            if (checkBoxQ20_1.Checked) { q20ans = "ΝΑΙ"; } else { q20ans = "OXI"; }
            if (checkBoxQ21_1.Checked) { q21ans = "ΝΑΙ"; } else { q21ans = "OXI"; }
            if (checkBoxQ22_1.Checked) { q22ans = "ΝΑΙ"; } else { q22ans = "OXI"; }
            if (checkBoxQ5_1.Checked) { q5ans += checkBoxQ5_1.Text + ","; }
            if (checkBoxQ5_2.Checked) { q5ans += checkBoxQ5_2.Text + ","; }
            if (checkBoxQ5_3.Checked) { q5ans += checkBoxQ5_3.Text + ","; }
            if (checkBoxQ5_4.Checked) { q5ans += checkBoxQ5_4.Text + ","; }
            if (checkBoxQ5_5.Checked) { q5ans += checkBoxQ5_5.Text + ","; }
            if (checkBoxQ5_6.Checked) { q5ans += checkBoxQ5_6.Text + ","; }
            if (checkBoxQ5_7.Checked) { q5ans += checkBoxQ5_7.Text + ","; }
            if (checkBoxQ5_8.Checked) { q5ans += checkBoxQ5_8.Text + ","; }
            if (checkBoxQ5_9.Checked) { q5ans += checkBoxQ5_9.Text + ","; }
            if (checkBoxQ5_10.Checked) { q5ans += checkBoxQ5_10.Text + ","; }
            if (checkBoxQ5_11.Checked) { q5ans += checkBoxQ5_11.Text + ","; }
            if (checkBoxQ5_12.Checked) { q5ans += checkBoxQ5_12.Text + ","; }
            if (checkBoxQ5_13.Checked) { q5ans += checkBoxQ5_13.Text + ","; }
            if (checkBoxQ5_14.Checked) { q5ans += checkBoxQ5_14.Text + ","; }
            if (checkBoxQ5_15.Checked) { q5ans += checkBoxQ5_15.Text + ","; }
            if (checkBoxQ5_16.Checked) { q5ans += checkBoxQ5_16.Text + ","; }
            if (checkBoxQ5_17.Checked) { q5ans += checkBoxQ5_17.Text + ","; }
            if (checkBoxQ5_18.Checked) { q5ans += checkBoxQ5_18.Text; }



            string sfalmata = "";
            if (txtbox_piesh.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή της Πίεσης "; }
            if (txtbox_sfikseis.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή των Σφύξεων "; }
            if (txtbox_thermokrasia.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή της Θερμοκρασίας "; }
            if (txtbox_varos.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή του Βάρους "; }
            if (txtbox_Aimatokritis.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή του Αιματοκρίτη "; }
            if (txtbox_aimosferini.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή της Αιμοσφαιρίνης "; }
            if (txtbox_Ipsos.Text == "") { sfalma = true; sfalmata += "\n* Εισαγωγή του Ύψους "; }
            if (sfalma)
            {                
                MessageBox.Show("Σφάλμα κατα την : \n" + sfalmata + "\n\nΑδύνατη η Εγγραφή", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                q5ans = "";
            }
            TimeSpan DiffDays = DateTime.Today - DateTimePicker_Q6.Value;

            
            if (DiffDays.Days <90 )
            {
                if (DateTime.Today.Date != DateTimePicker_Q6.Value.Date)
                {
                    lastdate = true;
                    MessageBox.Show("Αδύνατη η Αιμοδοσία ! \n Έδωσε πολύ πρόσφατα αίμα και δεν μπορεί να δώσει ακόμη (λιγότερο απο 3 μήνες)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!sfalma && !lastdate)
            {
                try
                {
                  
                
                    var Id =istorikoTableAdapter.MyInsertQuery(IDaimodoti, double.Parse(txtbox_piesh.Text), int.Parse(txtbox_sfikseis.Text), double.Parse(txtbox_thermokrasia.Text), double.Parse(txtbox_varos.Text), double.Parse(txtbox_Aimatokritis.Text), double.Parse(txtbox_aimosferini.Text), double.Parse(txtbox_Ipsos.Text), txtbox_genika.Text, katigoriaAim, q1ans, q2ans, q3ans, q4ans, q5ans, DateTimePicker_Q6.Value, q7ans, q8ans, q9ans, q10ans, q11ans, q12ans, q13ans, q14ans, q15ans, q16ans, q17ans, q18ans, q19ans, q20ans, q21ans, q22ans, dateTimePickerHistory.Value.Date);
                    IDHistory = long.Parse((Id).ToString());
                  //  MessageBox.Show(IDHistory.ToString());
                    MessageBox.Show("Έγινε η εγγραφή του Ιστορικού ", "", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Insert Failed", ex.ToString(), MessageBoxButtons.OK);
                }
            }        
        }
    }
}
