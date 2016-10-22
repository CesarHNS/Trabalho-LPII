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
    public partial class CatalogacaoBibliografica : Form
    {
        public CatalogacaoBibliografica()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            linkLabel1.Text = "[?]";
            linkLabel1.Links.Add(0, 0, "http://www.loc.gov/marc/bibliographic/bd245.html");
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void labelEmprestimo_Click(object sender, EventArgs e)
        {
            new CatalogacaoAutoridades().ShowDialog(this);
            this.Hide();
            CatalogacaoAutoridades cta = new CatalogacaoAutoridades();
            cta.Show();
        }

        private void labelReserva_Click(object sender, EventArgs e)
        {
            new CatalogacaoVocabulario().ShowDialog(this);
            this.Hide();
            CatalogacaoVocabulario ctv = new CatalogacaoVocabulario();
            ctv.Show();
        }

        private void labelAcesso_Click(object sender, EventArgs e)
        {
            new CatalogacaoImportacao().ShowDialog(this);
            this.Hide();
            CatalogacaoImportacao cti = new CatalogacaoImportacao();
            cti.Show();
        }

        private void labelCarteirinhas_Click(object sender, EventArgs e)
        {
            new CatalogacaoEtiquetas().ShowDialog(this);
            this.Hide();
            CatalogacaoEtiquetas cte = new CatalogacaoEtiquetas();
            cte.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new CatalogacaoMoverRegistros().ShowDialog(this);
            this.Hide();
            CatalogacaoMoverRegistros ctmr = new CatalogacaoMoverRegistros();
            ctmr.Show();
        }
    }
}
