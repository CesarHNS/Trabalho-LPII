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
    public partial class AdmTrocaSenha : Form
    {
        public AdmTrocaSenha()
        {
            InitializeComponent();
        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            new AdmManutencao().ShowDialog(this);
            this.Hide();
            AdmManutencao admm = new AdmManutencao();
            admm.Show();

        }

        private void labelReserva_Click(object sender, EventArgs e)
        {
            new AdmRelatorios().ShowDialog(this);
            this.Hide();
            AdmRelatorios admr = new AdmRelatorios();
            admr.Show();

        }

        private void labelAcesso_Click(object sender, EventArgs e)
        {
            new AdmLogin().ShowDialog(this);
            this.Hide();
            AdmLogin adml = new AdmLogin();
            adml.Show();
        }
    }
}
