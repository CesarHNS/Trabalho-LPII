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
    public partial class Circulacao : Form
    {
        public Circulacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            new CirculacaoEmprestimo().ShowDialog(this);
            this.Hide();
            CirculacaoEmprestimo ce = new CirculacaoEmprestimo();
            ce.Show();
        }

        private void labelReserva_Click(object sender, EventArgs e)
        {
            new CirculacaoReserva().ShowDialog(this);
            this.Hide();
            CirculacaoReserva cr = new CirculacaoReserva();
            cr.Show();
        }

        private void labelAcesso_Click(object sender, EventArgs e)
        {
            new CirculacaoAcesso().ShowDialog(this);
            this.Hide();
            CirculacaoAcesso ca = new CirculacaoAcesso();
            ca.Show();
        }

        private void labelCarteirinhas_Click(object sender, EventArgs e)
        {
            new CirculacaoCarteirinha().ShowDialog(this);
            this.Hide();
           CirculacaoCarteirinha cct = new CirculacaoCarteirinha();
            cct.Show();
        }
    }
}
