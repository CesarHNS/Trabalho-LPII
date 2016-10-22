using System;
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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void labelSair_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }

            finally
            {
                LoginBiblioteca mostraLogin = new LoginBiblioteca();
                mostraLogin.Show();
            }
        }
        
        private void labelBusca_Click(object sender, EventArgs e)
        {
            fmBusca mostraBusca = new fmBusca();
            mostraBusca.Show();
        }

        //mudando as cores de fundo dos labels
        private void labelBusca_MouseEnter(object sender, EventArgs e)
        {
            labelBusca.BackColor = Color.Gray;
        }

        private void labelBusca_MouseLeave(object sender, EventArgs e)
        {
            labelBusca.BackColor = Color.RoyalBlue;
        }

        private void labelCirculacao_MouseEnter(object sender, EventArgs e)
        {
            labelCirculacao.BackColor = Color.Gray;
        }

        private void labelCirculacao_MouseLeave(object sender, EventArgs e)
        {
            labelCirculacao.BackColor = Color.RoyalBlue;
        }

        private void lbCataloga_MouseEnter(object sender, EventArgs e)
        {
            lbCataloga.BackColor = Color.Gray;
        }

        private void lbCataloga_MouseLeave(object sender, EventArgs e)
        {
            lbCataloga.BackColor = Color.RoyalBlue;
        }

        private void labelAquisicao_MouseEnter(object sender, EventArgs e)
        {
            labelAquisicao.BackColor = Color.Gray;
        }

        private void labelAquisicao_MouseLeave(object sender, EventArgs e)
        {
            labelAquisicao.BackColor = Color.RoyalBlue;
        }

        private void labelAdm_MouseEnter(object sender, EventArgs e)
        {
            labelAdm.BackColor = Color.Gray;
        }

        private void labelAdm_MouseLeave(object sender, EventArgs e)
        {
            labelAdm.BackColor = Color.RoyalBlue;
        }

        private void labelAjuda_MouseEnter(object sender, EventArgs e)
        {
            labelAjuda.BackColor = Color.Gray;
        }

        private void labelAjuda_MouseLeave(object sender, EventArgs e)
        {
            labelAjuda.BackColor = Color.RoyalBlue;
        }

        private void labelSair_MouseEnter(object sender, EventArgs e)
        {
            labelSair.BackColor = Color.Gray;
        }

        private void labelSair_MouseLeave(object sender, EventArgs e)
        {
            labelSair.BackColor = Color.RoyalBlue;
        }

      
    }
}
