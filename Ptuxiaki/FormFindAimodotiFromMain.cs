using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ptuxiaki
{
    public partial class FormFindAimodotiFromMain : Form
        
    {
        public FormFindAimodotiFromMain()
        {
            InitializeComponent();
        }

        public DataRow AimodotisAnazitisis;

        private void FormFindAimodotiFromMain_Load(object sender, EventArgs e)
        {
            labelName.Text = AimodotisAnazitisis[0].ToString();
            labelLastName.Text = AimodotisAnazitisis[1].ToString();
            labelFatherName.Text = AimodotisAnazitisis[3].ToString();
            labelOmadaAimatos.Text = AimodotisAnazitisis[4].ToString();
            labelRhesus.Text = AimodotisAnazitisis[5].ToString();
            labelBirthDay.Text = AimodotisAnazitisis[6].ToString();
            labelJob.Text = AimodotisAnazitisis[7].ToString();
            labelAddress.Text = AimodotisAnazitisis[8].ToString();
            labelPhone1.Text = AimodotisAnazitisis[9].ToString();
            labelPhone2.Text = AimodotisAnazitisis[10].ToString();
            labelFyllo.Text = AimodotisAnazitisis[11].ToString();
            labelId.Text = AimodotisAnazitisis[2].ToString();
            
        }

        private void FullView_Click(object sender, EventArgs e)
        {
            FormFull_aimodotes_view FullaimodotesViewForm = new FormFull_aimodotes_view();
            FullaimodotesViewForm.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditAimodoti_Click(object sender, EventArgs e)
        {
            FormUpdateAimodoti AimodotiUpdate = new FormUpdateAimodoti();
            AimodotiUpdate.Show();
        }

    }
}
