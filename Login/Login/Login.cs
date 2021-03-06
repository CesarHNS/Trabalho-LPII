﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginBiblioteca : Form
    {
        public LoginBiblioteca()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Esconde o formulario atual
                this.Hide();

            }
            finally
            {
                // Crie apenas o segundo form
                TelaInicial mostraTelaInicial = new TelaInicial();
                //Mostre o segundo form
                mostraTelaInicial.Show();
                
            }
        }

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {
            textBoxSenha.ClearUndo();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxUsuario.ClearUndo();
        }
    }
}
