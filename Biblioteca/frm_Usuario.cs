﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class frm_Usuario : Form
    {
        public frm_Usuario()
        {
            InitializeComponent();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            this.lbl_aviso.Visible = true;
           frm_MenuADM frm_MenuADM = new frm_MenuADM();
            frm_MenuADM.ShowDialog();
            Close();
        }

        private void lbl_senha_Click(object sender, EventArgs e)
        {

        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frm_Usuario_Load(object sender, EventArgs e)
        {

        }

        private void lbl_aviso_Click(object sender, EventArgs e)
        {

        }
    }
}
