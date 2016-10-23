namespace Login
{
    partial class BuscaAutor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlBusca = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.buttonBuscarBibliografica = new System.Windows.Forms.Button();
            this.buttonListarTodos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelContendoTexto = new System.Windows.Forms.Label();
            this.tabPageFicha = new System.Windows.Forms.TabPage();
            this.tabPageMarc = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlBusca.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlBusca
            // 
            this.tabControlBusca.Controls.Add(this.tabPageBusca);
            this.tabControlBusca.Controls.Add(this.tabPageFicha);
            this.tabControlBusca.Controls.Add(this.tabPageMarc);
            this.tabControlBusca.Location = new System.Drawing.Point(183, 109);
            this.tabControlBusca.Name = "tabControlBusca";
            this.tabControlBusca.SelectedIndex = 0;
            this.tabControlBusca.Size = new System.Drawing.Size(633, 141);
            this.tabControlBusca.TabIndex = 7;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.buttonBuscarBibliografica);
            this.tabPageBusca.Controls.Add(this.buttonListarTodos);
            this.tabPageBusca.Controls.Add(this.textBox1);
            this.tabPageBusca.Controls.Add(this.labelContendoTexto);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(625, 115);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarBibliografica
            // 
            this.buttonBuscarBibliografica.AllowDrop = true;
            this.buttonBuscarBibliografica.Location = new System.Drawing.Point(481, 59);
            this.buttonBuscarBibliografica.Name = "buttonBuscarBibliografica";
            this.buttonBuscarBibliografica.Size = new System.Drawing.Size(101, 25);
            this.buttonBuscarBibliografica.TabIndex = 8;
            this.buttonBuscarBibliografica.Text = "Buscar";
            this.buttonBuscarBibliografica.UseVisualStyleBackColor = true;
            // 
            // buttonListarTodos
            // 
            this.buttonListarTodos.Location = new System.Drawing.Point(37, 59);
            this.buttonListarTodos.Name = "buttonListarTodos";
            this.buttonListarTodos.Size = new System.Drawing.Size(118, 25);
            this.buttonListarTodos.TabIndex = 6;
            this.buttonListarTodos.Text = "Listar Todos";
            this.buttonListarTodos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 20);
            this.textBox1.TabIndex = 5;
            // 
            // labelContendoTexto
            // 
            this.labelContendoTexto.AutoSize = true;
            this.labelContendoTexto.Location = new System.Drawing.Point(34, 25);
            this.labelContendoTexto.Name = "labelContendoTexto";
            this.labelContendoTexto.Size = new System.Drawing.Size(88, 13);
            this.labelContendoTexto.TabIndex = 0;
            this.labelContendoTexto.Text = "Contendo o texto";
            // 
            // tabPageFicha
            // 
            this.tabPageFicha.Location = new System.Drawing.Point(4, 22);
            this.tabPageFicha.Name = "tabPageFicha";
            this.tabPageFicha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFicha.Size = new System.Drawing.Size(625, 115);
            this.tabPageFicha.TabIndex = 1;
            this.tabPageFicha.Text = "Ficha";
            this.tabPageFicha.UseVisualStyleBackColor = true;
            // 
            // tabPageMarc
            // 
            this.tabPageMarc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarc.Name = "tabPageMarc";
            this.tabPageMarc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarc.Size = new System.Drawing.Size(625, 115);
            this.tabPageMarc.TabIndex = 2;
            this.tabPageMarc.Text = "MARC";
            this.tabPageMarc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-14, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 38);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(439, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busca Autor";
            // 
            // BuscaAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControlBusca);
            this.Name = "BuscaAutor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControlBusca.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlBusca;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.Button buttonBuscarBibliografica;
        private System.Windows.Forms.Button buttonListarTodos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelContendoTexto;
        private System.Windows.Forms.TabPage tabPageFicha;
        private System.Windows.Forms.TabPage tabPageMarc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}