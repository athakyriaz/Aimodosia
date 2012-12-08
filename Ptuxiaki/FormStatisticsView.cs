using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormStatisticsView : Form
    {
        public FormStatisticsView()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public int aimodotesEggegramenoi = 0;
        public void CountAimodotes()
        {
            this.aimodotesTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Aimodotes);           
            aimodotesEggegramenoi = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Rows.Count;
            labelEggramenoiAimodotes.Text = aimodotesEggegramenoi.ToString();
        }
       public int SyllogoiEggegramenoi = 0;
        public void CountSyllogous()
        {
            this.syllogoiTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Syllogoi);           
            SyllogoiEggegramenoi = ptuxiakiDatabaseDataSet1.Tables["Syllogoi"].Rows.Count;
            labelNumSullogoi.Text = SyllogoiEggegramenoi.ToString();
        }

       public int FialesAllCount = 0;
        public void CountFiales()
        {
            this.fialesTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Fiales);           
            FialesAllCount = ptuxiakiDatabaseDataSet1.Tables["Fiales"].Rows.Count;
            labelArithmosFialwn.Text = FialesAllCount.ToString();
        }


        public float APlusCount = 0;
        public float CountAPlus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] APlusGrammes;
            APlusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Α' and Rhesus LIKE '+'");
            APlusCount= APlusGrammes.Length;
            APlusCount = (APlusCount / aimodotesEggegramenoi) * 100;
            labelAPlus.Text = APlusCount.ToString("N2") + "%";
            return APlusCount;
        }



        public float AMinusCount = 0;
        public float CountAMinus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] AMinusGrammes;
            AMinusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Α' AND Rhesus LIKE '-'");
            AMinusCount = AMinusGrammes.Length;
            AMinusCount = (AMinusCount / aimodotesEggegramenoi) * 100;
            labelAMinus.Text = AMinusCount.ToString("N2") + "%";
            return AMinusCount;
        }

        public float BPlusCount = 0;
        public float CountBPlus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] BPlusGrammes;          
            BPlusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Β' and Rhesus LIKE '+'");
            BPlusCount = BPlusGrammes.Length;
            BPlusCount = (BPlusCount / aimodotesEggegramenoi) * 100;
            labelBPlus.Text = BPlusCount.ToString("N2") + "%";
            return BPlusCount;
        }
      
        public float BMinusCount = 0;
        public float CountBMinus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] BMinusGrammes;            
            BMinusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Β' AND Rhesus LIKE '-'");
            BMinusCount = BMinusGrammes.Length;
            BMinusCount = (BMinusCount / aimodotesEggegramenoi) * 100;
            labelBMinus.Text = BMinusCount.ToString("N2") + "%";
            return BMinusCount;
        }

        public float ABPlusCount = 0;
        public float CountABPlus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] ABPlusGrammes;           
            ABPlusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'ΑΒ' and Rhesus LIKE '+'");
            ABPlusCount = ABPlusGrammes.Length;
            ABPlusCount = (ABPlusCount / aimodotesEggegramenoi) * 100;
            labelABPlus.Text = ABPlusCount.ToString("N2") + "%";
            return ABPlusCount;
        }

        public float ABMinusCount = 0;
        public float CountABMinus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] ABMinusGrammes;            
            ABMinusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'ΑΒ' AND Rhesus LIKE '-'");
            ABMinusCount = ABMinusGrammes.Length;
            ABMinusCount = (ABMinusCount / aimodotesEggegramenoi) * 100;
            labelABMinus.Text = ABMinusCount.ToString("N2") + "%";
            return ABMinusCount;
        }

        public float OPlusCount = 0;
        public float CountOPlus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] OPlusGrammes;           
            OPlusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Ο' and Rhesus LIKE '+'");
            OPlusCount = OPlusGrammes.Length;
            OPlusCount = (OPlusCount / aimodotesEggegramenoi) * 100;
            labelOPlus.Text = OPlusCount.ToString("N2") + "%";
            return OPlusCount;
        }

        public float OMinusCount = 0;
        public float CountOMinus()
        {
            this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Aimodotes);
            DataRow[] OMinusGrammes;            
            OMinusGrammes = ptuxiakiDatabaseDataSet1.Tables["Aimodotes"].Select("OmadaAimatos LIKE 'Ο' AND Rhesus LIKE '-'");
            OMinusCount = OMinusGrammes.Length;
            OMinusCount = (OMinusCount / aimodotesEggegramenoi) * 100;
            labelOMinus.Text = OMinusCount.ToString("N2") + "%";
            return OMinusCount;
        }

        

        public void CountElegmenesFiales()
        {
            this.fialesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Fiales);
            DataRow[] ElegmenesFiales;
            int countFialesElegmenes = 0;
            ElegmenesFiales = ptuxiakiDatabaseDataSet1.Tables["Fiales"].Select("Katastasi LIKE 'Ελεγμένο'");
            countFialesElegmenes = ElegmenesFiales.Length;
            labelFialesElegmenes.Text = countFialesElegmenes.ToString();
        }
        public void CountApporFiales()
        {
            this.fialesTableAdapter1.Fill(ptuxiakiDatabaseDataSet1.Fiales);
            DataRow[] ApporFiales;
            int countFialesAppor = 0;
            ApporFiales = ptuxiakiDatabaseDataSet1.Tables["Fiales"].Select("Katastasi LIKE 'Απορρίφθηκε'");
            countFialesAppor = ApporFiales.Length;
            labelFialesAporifthikan.Text = countFialesAppor.ToString();
        }
        public void CountFialesLastMonth()
        {
            if (FialesAllCount != 0)
            {
                int FialesLastMonth = 0;

                FialesLastMonth = int.Parse(fialesTableAdapter1.FillByLastMonth().ToString());
               
                labelFialesLastMonth.Text = FialesLastMonth.ToString();
            }
            else
            {
                labelFialesLastMonth.Text = "N/A";
            }
            
        }

        public void MaxSyllogos()
        {
            if (SyllogoiEggegramenoi != 0)
            {
                syllogoiTableAdapter1.FillByOnoma_Fiales(ptuxiakiDatabaseDataSet1.Syllogoi);
                DataTable ResultsTable = syllogoiTableAdapter1.GetDataBy2();
                DataRow[] Results = new DataRow[ResultsTable.Rows.Count];
                ResultsTable.Rows.CopyTo(Results, 0);

                DataRow x = Results[0];
                string MaxSyllogos = x[1].ToString();
                int maxfiales = int.Parse(x[4].ToString());
                for (int i = 1; i < Results.Length; i++)
                {
                    x = Results[i];
                    if (int.Parse(x[4].ToString()) > maxfiales)
                    {
                        MaxSyllogos = x[1].ToString();
                        maxfiales = int.Parse(x[4].ToString());
                    }
                }

                string[] MaxSyllogoi = new string[ResultsTable.Rows.Count];
                MaxSyllogoi[0] = MaxSyllogos;
                int Counter = 1;

                for (int i = 0; i < Results.Length; i++)
                {
                    x = Results[i];
                    if (x[1].ToString() == MaxSyllogos) continue;
                    if (int.Parse(x[4].ToString()) == maxfiales)
                    {                       
                        MaxSyllogoi[Counter] = x[1].ToString();
                        Counter++;
                    }
                }
                labelSyllogosMax.Text = "";
                for (int i = 0; i < MaxSyllogoi.Length && MaxSyllogoi[i] != null; i++)
                {
                    labelSyllogosMax.Text += MaxSyllogoi[i].ToString() + " , ";
                }
                labelSyllogosMax.Text = labelSyllogosMax.Text.Remove(labelSyllogosMax.Text.Length - 3, 3);
            }
            else
            {
                labelSyllogosMax.Text = "N/A";
            }
        }

        public void OldSyllogos()
        {
            if (SyllogoiEggegramenoi != 0)
            {
                syllogoiTableAdapter1.OldSyllogosQuery(ptuxiakiDatabaseDataSet1.Syllogoi);
                DataTable ResultsTable = syllogoiTableAdapter1.GetDataBy3();
                DataRow[] Results = new DataRow[ResultsTable.Rows.Count];
                ResultsTable.Rows.CopyTo(Results, 0);

                DataRow y = Results[0];
                DateTime OlderDate = DateTime.Parse(y[5].ToString());
                string OldSyllogos = y[1].ToString();
                for (int i = 1; i < Results.Length; i++)
                {
                    y=Results[i];
                    if (DateTime.Parse(y[5].ToString()).Date == OlderDate.Date)
                    {
                        OldSyllogos +=" , " + y[1].ToString();
                    }

                }

                labelPalaioterosSullogos.Text = OldSyllogos;
            }
            else
            {
                labelPalaioterosSullogos.Text = "N/A";
            }
                       
        }


        public void MOFialwn()
        {
            labelMOFialwnAimodotwn.Text = ((float)FialesAllCount / (float)aimodotesEggegramenoi).ToString("N2");
        }

        private void FormStatisticsView_Load(object sender, EventArgs e)
        {
            float max;
            string maxOmada;
            CountAimodotes();
            CountFiales();
            CountSyllogous();
            float AplusCount = CountAPlus();
            max = AplusCount;
            maxOmada = "A Rhesus +";
            float AminusCount = CountAMinus();
            if (AminusCount > max)
            {
                max = AminusCount;
                maxOmada = "A Rhesus -";
            }
            float BplusCount = CountBPlus();
            if (BplusCount > max)
            {
                max = BplusCount;
                maxOmada = "B Rhesus +";
            }
            float BminusCount = CountBMinus();
            if (BminusCount > max)
            {
                max = BminusCount;
                maxOmada = "B Rhesus -";
            }
            float ABPlusCount = CountABPlus();
            if (ABPlusCount > max)
            {
                max = ABPlusCount;
                maxOmada = "AB Rhesus +";
            }
            float ABMinusCount = CountABMinus();
            if (ABMinusCount > max)
            {
                max = ABMinusCount;
                maxOmada = "AB Rhesus -";
            }
            float OplusCount = CountOPlus();
            if (OplusCount > max)
            {
                max = OplusCount;
                maxOmada = "O Rhesus +";
            }
            float OminusCount = CountOMinus();
            if (OminusCount > max)
            {
                max = OminusCount;
                maxOmada = "O Rhesus -";
            }
            labelSuxnoteriOmada.Text = maxOmada;
            CountElegmenesFiales();
            CountApporFiales();
            CountFialesLastMonth();
            MaxSyllogos();
            OldSyllogos();
            MOFialwn();

          // this.syllogoiTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Syllogoi);
          // this.fialesTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet1.Fiales);
        //   DataRow[] ElegmenesFiales = ptuxiakiDatabaseDataSet1.Tables["Fiales"].Select("Katastasi LIKE Ελεγμένη'");


        }

        
    }
}
