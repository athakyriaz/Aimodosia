using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{

    public partial class Form_Main_menu : Form
        
    {

        public Form_Main_menu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Main_menu_Load(object sender, EventArgs e)
        {
            FormPassword passwordForm = new FormPassword();
            while (passwordForm.ShowDialog() == DialogResult.Cancel)
            {
                passwordForm.ShowDialog();
            }
            
            
            timer1.Enabled = true;
            //FormEggrafiAimodoti eggrafi_g = new FormEggrafiAimodoti();
           // eggrafi_g.Show(); eggrafi_g.Close();
            this.aimodotesTableAdapter1.Fill(this.ptuxiakiDatabaseDataSet11.Aimodotes);
            
        }

        private void btnEggrafi_Click(object sender, EventArgs e)
        {
            FormEggrafiAimodoti EggrafiAimodotiForm = new FormEggrafiAimodoti();            
            EggrafiAimodotiForm.Show();

        }

        private void btnNeosAimodotis_Click(object sender, EventArgs e)
        {
            if (btnEggrafi.Visible == false)
            {
                pictureAddAimodoti.Visible = true;
                btnEggrafi.Visible = true;
            }
                else 
                {
                    pictureAddAimodoti.Visible = false;
                    btnEggrafi.Visible = false;           
                }

            }


        


        private void pictureAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lbl_Time.Text = DateTime.Now.ToLongTimeString() + "  " + DateTime.Now.ToShortDateString();
        }

        private void btnAimodotesPalioi_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Visible == false)
            {
                
                btnProsthikiAimodosias.Visible = true;
                btnUpdate.Visible = true;
                pictureAddAimodosias.Visible=true;
                pictureUpdateAimodoti.Visible = true;

            }
            else
            {
                btnProsthikiAimodosias.Visible = false;
                btnUpdate.Visible = false;
                pictureAddAimodosias.Visible = false;
                pictureUpdateAimodoti.Visible = false;
            }
        }

        private void btnSullogoi_Click(object sender, EventArgs e)
        {
            if (btnAddSullogo.Visible == false)
            {
                btnAddSullogo.Visible = true;
                btnDiorthosiSullogou.Visible = true;
                pictureAddSyllogou.Visible = true;
                pictureDiorthwshSyllogou.Visible = true;
            }
            else
            {
                btnAddSullogo.Visible = false;
                btnDiorthosiSullogou.Visible = false;
                pictureAddSyllogou.Visible = false;
                pictureDiorthwshSyllogou.Visible = false;
            }
        }



        private void btnAddSullogo_Click(object sender, EventArgs e)
        {
            FormAddSyllogo AddSyllogoForm = new FormAddSyllogo();
            AddSyllogoForm.Show();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormUpdateAimodoti UpdateAimodotiForm=new FormUpdateAimodoti();
            UpdateAimodotiForm.Show();
        }


        private void pictureAddSyllogou_Click(object sender, EventArgs e)
        {
            FormAddSyllogo AddSyllogoForm = new FormAddSyllogo();
            AddSyllogoForm.Show();
        }

        private void btnDiorthosiSullogou_Click(object sender, EventArgs e)
        {
            FormDiorthwsiSullogou DiorthwsiSyllogouForm = new FormDiorthwsiSullogou();
            DiorthwsiSyllogouForm.Show();
        }


        private void προβολήΑιμοδοτώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFull_aimodotes_view FullaimodotesViewForm = new FormFull_aimodotes_view();
            FullaimodotesViewForm.ShowDialog();
        }

        private void προβολήΣυλλογώνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FullSyllogoiView SyllogoiFullViewForm = new FullSyllogoiView();
            SyllogoiFullViewForm.ShowDialog();
        }

        private void btnProsthikiAimodosias_Click(object sender, EventArgs e)
        {
            FormAddAimodosia aimodosiaForm = new FormAddAimodosia();
            aimodosiaForm.Show();
        }

        private void TextBoxSearchAimodoti_Click(object sender, EventArgs e)
        {
            TextBoxSearchAimodoti.Clear();
        }

        private void textBoxSearchSyllogo_Click(object sender, EventArgs e)
        {
            textBoxSearchSyllogo.Clear();
        }

        private void TextBoxSearchAimodoti_Leave(object sender, EventArgs e)
        {
            TextBoxSearchAimodoti.Text = "Αναζήτηση Αιμοδότη";
        }

        private void textBoxSearchSyllogo_Leave(object sender, EventArgs e)
        {
            textBoxSearchSyllogo.Text = "Αναζήτηση Συλλόγου";
        }


        public static DataRow SullogosAnazitisis;
        public static string stoixeioSyllogou;
        private void dothesearchSyllogou()
        {
            if (textBoxSearchSyllogo.Text != "")
            {
                int results = 0;
                DataRow[] grammesSyllogou;
                this.syllogoiTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Syllogoi);
                int idSyllogou;
                bool is_int = int.TryParse(textBoxSearchSyllogo.Text, out idSyllogou);
                if (is_int)
                {
                    grammesSyllogou = ptuxiakiDatabaseDataSet11.Tables["Syllogoi"].Select("ID_Syllogou= '" + textBoxSearchSyllogo.Text + "'");
                }
                else
                {
                    textBoxSearchSyllogo.Text = textBoxSearchSyllogo.Text.Replace('*', '%');
                    grammesSyllogou = ptuxiakiDatabaseDataSet11.Tables["Syllogoi"].Select("Onoma_Syllogou LIKE '" + textBoxSearchSyllogo.Text + "'or Eponumo_Proedrou LIKE '" + textBoxSearchSyllogo.Text + "'");
                }
                results = grammesSyllogou.Length;
                if (results > 1)
                {
                    stoixeioSyllogou = textBoxSearchSyllogo.Text;
                    FormEpilogiSyllogou SyllogosEpilogi = new FormEpilogiSyllogou();
                    SyllogosEpilogi.stoixeio = stoixeioSyllogou;
                    if (SyllogosEpilogi.ShowDialog() == DialogResult.OK)
                    {
                        SullogosAnazitisis = SyllogosEpilogi.SullogosAnazitisis;
                        FormFindSyllogoFromMain SullogosEpilogi_Show_A = new FormFindSyllogoFromMain();
                        SullogosEpilogi_Show_A.SullogosAnazitisis = SullogosAnazitisis;
                        SullogosEpilogi_Show_A.Show();
                    }
                }

                if (results == 1)
                {
                    MessageBox.Show("Ο Σύλλογος βρέθηκε", "Found !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormFindSyllogoFromMain findSullogos = new FormFindSyllogoFromMain();
                    findSullogos.SullogosAnazitisis = grammesSyllogou[0];
                    findSullogos.Show();
                }

                if (results == 0)
                {
                    MessageBox.Show("Δεν βρέθηκε ο Σύλλογος!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            
        }


        public static DataRow AimodotisAnazitisis;
        public static string stoixeio;
        private void dothesearch()
        {
            if (TextBoxSearchAimodoti.Text != "")
            {
                int count_results = 0;
                DataRow[] grammes;
                this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Aimodotes); 
                int idAimodoti;
                bool is_int = int.TryParse(TextBoxSearchAimodoti.Text, out idAimodoti);
                if (is_int)
                {
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Aimodotes"].Select("ID = '" + TextBoxSearchAimodoti.Text + "'");
                }
                else
                {
                    TextBoxSearchAimodoti.Text = TextBoxSearchAimodoti.Text.Replace('*', '%');
                    grammes = ptuxiakiDatabaseDataSet11.Tables["Aimodotes"].Select("LastName LIKE '" + TextBoxSearchAimodoti.Text + "' or Name LIKE '" + TextBoxSearchAimodoti.Text + "'");
                }

                count_results = grammes.Length;
                if (count_results > 1)
                {

                    stoixeio = TextBoxSearchAimodoti.Text;
                    FormEpilogiAimodoti_Edit epilogiAimodoti=new FormEpilogiAimodoti_Edit();
                    epilogiAimodoti.stoixeio = stoixeio;
                    if (epilogiAimodoti.ShowDialog() == DialogResult.OK)
                    {
                        AimodotisAnazitisis = epilogiAimodoti.AimodotisAnazitishs;
                        FormFindAimodotiFromMain AimodotiEpilogi_Show_A = new FormFindAimodotiFromMain();
                        AimodotiEpilogi_Show_A.AimodotisAnazitisis = AimodotisAnazitisis;
                        AimodotiEpilogi_Show_A.Show();
                    }
                
                }
                if (count_results == 1)
                {
                    MessageBox.Show("Ο Αιμοδότης βρέθηκε", "Found !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormFindAimodotiFromMain findaimodotis = new FormFindAimodotiFromMain();
                    findaimodotis.AimodotisAnazitisis=grammes[0];
                    findaimodotis.Show();
                }
                if (count_results == 0)
                {
                    MessageBox.Show("Δεν βρέθηκε ο Αιμοδότης!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void pictureBoxSearchAimodoti_Click(object sender, EventArgs e)
        {
            dothesearch();
           
           
        }

        private void TextBoxSearchAimodoti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearch();
            }
        }

        private void AddAimodoti_Click(object sender, EventArgs e)
        {
            FormEggrafiAimodoti EggrafiAimodoti = new FormEggrafiAimodoti();
            EggrafiAimodoti.Show();
        }

        private void AddSyllogo_Click(object sender, EventArgs e)
        {
            FormAddSyllogo SyllogoAdd = new FormAddSyllogo();
            SyllogoAdd.Show();
        }

        private void pictureBoxSearchSyllogo_Click(object sender, EventArgs e)
        {
            dothesearchSyllogou();
        }

        private void textBoxSearchSyllogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearchSyllogou();
            }
        }

        

        private void btnXrewshFialis_Click_1(object sender, EventArgs e)
        {
            FormXrewshFuallis fualixrewsh = new FormXrewshFuallis();
            fualixrewsh.Show();
        }

        private void textBoxSearchFiali_Leave(object sender, EventArgs e)
        {
            textBoxSearchFiali.Text = "Κωδικός Φιάλης";
        }

        private void textBoxSearchFiali_Click(object sender, EventArgs e)
        {
            textBoxSearchFiali.Clear();
        }

        private void textBoxSearchFiali_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearchFialis();
            }
        }


       
        private void picboxSearchFiali_Click(object sender, EventArgs e)
        {
            dothesearchFialis();
        }

        public static DataRow FialiAnazitisis;
        public static string stoix;
        private void dothesearchFialis()
        {
            int IdFialisSearch;
            bool is_int = int.TryParse(textBoxSearchFiali.Text, out IdFialisSearch);
            if (is_int)
            {
                if (textBoxSearchFiali.Text != "")
                {
                    int count_results = 0;
                    DataRow[] grammes;
                    this.fialesTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Fiales);

                    grammes = ptuxiakiDatabaseDataSet11.Tables["Fiales"].Select("IDFialis = '" + textBoxSearchFiali.Text + "'");

                    count_results = grammes.Length;

                    if (count_results == 1)
                    {
                        MessageBox.Show("Η Φιάλη Βρέθηκε", "Found !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormFindFialiFromMain FindFiali = new FormFindFialiFromMain();
                        FindFiali.FialiAnazitisis = grammes[0];
                        FindFiali.Show();
                    }
                    if (count_results == 0)
                    {
                        MessageBox.Show("Δεν βρέθηκε η Φιάλη , Ελέγξτε πάλι τον Κωδικό της!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Δώστε Κωδικό Φιάλης για Αναζήτηση", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void FullViewFiales_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView FullViewFiales = new FormAimodosiaFullView();
            FullViewFiales.Show();
        }

        private void FullViewXrewseis_Click(object sender, EventArgs e)
        {
            FormFullViewXrewseis ViewXrewseisFull = new FormFullViewXrewseis();
            ViewXrewseisFull.Show();
        }

        private void AddAimodosia_Click(object sender, EventArgs e)
        {
            FormAddAimodosia AddAimodosia = new FormAddAimodosia();
            AddAimodosia.Show();
        }

        private void AddXrewsh_Click(object sender, EventArgs e)
        {
            FormXrewshFuallis XrewshFialis = new FormXrewshFuallis();
            XrewshFialis.Show();
        }

        private void EditAimodoti_Click(object sender, EventArgs e)
        {
            FormUpdateAimodoti EditAimodoti = new FormUpdateAimodoti();
            EditAimodoti.Show();
        }

        private void EditSyllogo_Click(object sender, EventArgs e)
        {
            FormDiorthwsiSullogou EditSyllogo = new FormDiorthwsiSullogou();
            EditSyllogo.Show();
        }
        

        private void textBoxHistoryFound_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dothesearchHistory();
            }
        }


        
        
        private void dothesearchHistory()
        {
            int IdAimodotiSearch;
            bool is_int = int.TryParse(textBoxHistoryFound.Text, out IdAimodotiSearch);
            if (is_int)
            {
                if (textBoxHistoryFound.Text != "")
                {
                    long Idistorikou;
                    this.aimodotesTableAdapter1.Fill(ptuxiakiDatabaseDataSet11.Aimodotes);
                    PtuxiakiDatabaseDataSet1.AimodotesRow Aimodotis = ptuxiakiDatabaseDataSet11.Aimodotes.FindByID(long.Parse(textBoxHistoryFound.Text));
                    if (Aimodotis != null)
                    {
                        FormSelectHistory SelectHistory = new FormSelectHistory();
                        SelectHistory.IDaimodoti = Aimodotis.ID;

                        if (SelectHistory.ShowDialog() == DialogResult.OK)
                        {
                            Idistorikou = SelectHistory.IDistorikou;
                            HistoryForm HistoryShowForm = new HistoryForm();
                            HistoryShowForm.ShowOnly = true;
                            HistoryShowForm.Idistorikou = Idistorikou;
                            HistoryShowForm.Show();
                        }
                    }
                    if (Aimodotis == null)
                    {
                        MessageBox.Show("Δεν βρέθηκε ο Αιμοδότης!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Δώστε Κωδικό Αιμοδότη για Αναζήτηση", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxHistoryFound_Click(object sender, EventArgs e)
        {
            dothesearchHistory();
        }

        private void textBoxHistoryFound_Leave(object sender, EventArgs e)
        {
            textBoxHistoryFound.Text = "Eύρεση Ιστορικού";
        }

        private void textBoxHistoryFound_Click(object sender, EventArgs e)
        {
            textBoxHistoryFound.Clear();
        }

        private void XrewshFialisMenuStrip_Click(object sender, EventArgs e)
        {
            FormXrewshFuallis XrewshFialis = new FormXrewshFuallis();
            XrewshFialis.Show();
        }

        private void FialiEditFromMenu_Click(object sender, EventArgs e)
        {
            FormFindFialiFromMenu FindFiali = new FormFindFialiFromMenu();
            FindFiali.Show();
        }

        private void HelpBarAddAimodoti_Click(object sender, EventArgs e)
        {
            FormEggrafiAimodoti EggrafiAimodoti = new FormEggrafiAimodoti();
            EggrafiAimodoti.Show();
        }

        private void HelpBarAddAimodosia_Click(object sender, EventArgs e)
        {
            FormAddAimodosia AimodosiaAdd = new FormAddAimodosia();
            AimodosiaAdd.Show();
        }

        private void HelpBarAddSullog_Click(object sender, EventArgs e)
        {
            FormAddSyllogo AddSyllogo = new FormAddSyllogo();
            AddSyllogo.Show();
        }

        private void HelpBarXrewshFialis_Click(object sender, EventArgs e)
        {
            FormXrewshFuallis xreswshFialis = new FormXrewshFuallis();
            xreswshFialis.Show();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            FormStatisticsView ViewStatistics = new FormStatisticsView();
            ViewStatistics.Show();
        }

        private void AddXorigisi_Click(object sender, EventArgs e)
        {
            FormNewXorigisi Xorigisinew = new FormNewXorigisi();
            Xorigisinew.Show();
        }

        private void AimodosiesFullView_Click(object sender, EventArgs e)
        {
            FormAimodosiaFullView ViewAimodosies = new FormAimodosiaFullView();
            ViewAimodosies.Show();
        }

        private void picBoxAddXorigisi_Click(object sender, EventArgs e)
        {
            FormNewXorigisi AddXorigisi = new FormNewXorigisi();
            AddXorigisi.Show();
        }

        private void XorigiseisFullView_Click(object sender, EventArgs e)
        {
            FormXorigiseisFullView ViewXorigiseis = new FormXorigiseisFullView();
            ViewXorigiseis.Show();
        }

        private void ContactForm_Click(object sender, EventArgs e)
        {
            FormContactMe Contact = new FormContactMe();
            Contact.Show();
        }

      
       

       

    








   
    }
}
