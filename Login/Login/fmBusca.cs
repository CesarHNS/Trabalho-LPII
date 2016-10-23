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
    public partial class fmBusca : Form
    {
        public fmBusca()
        {
            InitializeComponent();
        }

        private void Bibliografica_Load(object sender, EventArgs e)
        {

        }

        private void labelBibliografica_Click(object sender, EventArgs e)
        {
          
                BuscaBiblio mostraBuscaBiblio = new BuscaBiblio();
                mostraBuscaBiblio.Show();
            
        }

        private void labelSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelSair_MouseEnter(object sender, EventArgs e)
        {
            labelSair.BackColor = Color.Gray;
        }

        private void labelSair_MouseLeave(object sender, EventArgs e)
        {
            labelSair.BackColor = Color.RoyalBlue;
        }

        private void labelDistribuida_MouseEnter(object sender, EventArgs e)
        {
            labelDistribuida.BackColor = Color.Gray;
        }

        private void labelDistribuida_MouseLeave(object sender, EventArgs e)
        {
            labelDistribuida.BackColor = Color.RoyalBlue;
        }

        private void labelVocabulario_MouseEnter(object sender, EventArgs e)
        {
            labelVocabulario.BackColor = Color.Gray;
        }

        private void labelVocabulario_MouseLeave(object sender, EventArgs e)
        {
            labelVocabulario.BackColor = Color.RoyalBlue;
        }

        private void labelAutoridades_MouseEnter(object sender, EventArgs e)
        {
            labelAutoridades.BackColor = Color.Gray;
        }

        private void labelAutoridades_MouseLeave(object sender, EventArgs e)
        {
            labelAutoridades.BackColor = Color.RoyalBlue;
        }

        private void labelBibliografica_MouseEnter(object sender, EventArgs e)
        {
            labelBibliografica.BackColor = Color.Gray;
        }

        private void labelBibliografica_MouseLeave(object sender, EventArgs e)
        {
            labelBibliografica.BackColor = Color.RoyalBlue;
        }

        private void labelAutoridades_Click(object sender, EventArgs e)
        {
            BuscaAutor mostraBuscaAutor = new BuscaAutor();
            mostraBuscaAutor.Show();
        }

        private void labelVocabulario_Click(object sender, EventArgs e)
        {
            BuscaVocabulario mostraBuscaVocabulario = new BuscaVocabulario();
            mostraBuscaVocabulario.Show();
        }

        private void labelDistribuida_Click(object sender, EventArgs e)
        {
            BuscaDistribuida mostraBuscaDistribuida = new BuscaDistribuida();
            mostraBuscaDistribuida.Show();
        }
    }
}
