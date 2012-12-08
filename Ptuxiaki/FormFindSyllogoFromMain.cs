using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFindSyllogoFromMain : Form
    {
        public FormFindSyllogoFromMain()
        {
            InitializeComponent();
        }

        public DataRow SullogosAnazitisis;

        private void FormFindSyllogoFromMain_Load(object sender, EventArgs e)
        {
            labelIdSyllogoy.Text = SullogosAnazitisis[0].ToString();
            labelNameSyllogou.Text = SullogosAnazitisis[1].ToString();
            labelNameProedrou.Text = SullogosAnazitisis[2].ToString();
            labelLastNameProedrou.Text = SullogosAnazitisis[3].ToString();
            labelNumFuales.Text = SullogosAnazitisis[4].ToString();
            labelDateIdrisis.Text = SullogosAnazitisis[5].ToString();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FullViewSullogoi_Click(object sender, EventArgs e)
        {
            FullSyllogoiView ViewSullogoi = new FullSyllogoiView();
            ViewSullogoi.Show();
        }

        private void EditSullogoi_Click(object sender, EventArgs e)
        {
            FormDiorthwsiSullogou SullogosDiorthwsi = new FormDiorthwsiSullogou();
            SullogosDiorthwsi.Show();
        }



    }
}
