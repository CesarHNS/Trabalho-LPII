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
    public partial class AquisicaoFornecedor : Form
    {
        public AquisicaoFornecedor()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            new AquisicaoRequisicao().ShowDialog(this);
            this.Hide();
            AquisicaoRequisicao ar = new AquisicaoRequisicao();
            ar.Show();
        }

        private void labelReserva_Click(object sender, EventArgs e)
        {
            new AquisicaoCotacao().ShowDialog(this);
            this.Hide();
            AquisicaoCotacao ac = new AquisicaoCotacao();
            ac.Show();
        }

        private void labelAcesso_Click(object sender, EventArgs e)
        {
            new AquisicaoPedido().ShowDialog(this);
            this.Hide();
            AquisicaoPedido ap = new AquisicaoPedido();
            ap.Show();
        }
    }
}
