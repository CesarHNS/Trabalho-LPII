namespace Login
{
    partial class fmBusca
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
            this.labelBibliografica = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelVocabulario = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelDistribuida = new System.Windows.Forms.Label();
            this.labelSair = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAutoridades = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBibliografica
            // 
            this.labelBibliografica.AutoSize = true;
            this.labelBibliografica.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBibliografica.ForeColor = System.Drawing.Color.White;
            this.labelBibliografica.Location = new System.Drawing.Point(21, 9);
            this.labelBibliografica.Name = "labelBibliografica";
            this.labelBibliografica.Size = new System.Drawing.Size(85, 16);
            this.labelBibliografica.TabIndex = 0;
            this.labelBibliografica.Text = "Bibliográfica";
            this.labelBibliografica.Click += new System.EventHandler(this.labelBibliografica_Click);
            this.labelBibliografica.MouseEnter += new System.EventHandler(this.labelBibliografica_MouseEnter);
            this.labelBibliografica.MouseLeave += new System.EventHandler(this.labelBibliografica_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 42);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.Location = new System.Drawing.Point(113, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 41);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateBlue;
            this.panel4.Location = new System.Drawing.Point(224, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(15, 41);
            this.panel4.TabIndex = 4;
            // 
            // labelVocabulario
            // 
            this.labelVocabulario.AutoSize = true;
            this.labelVocabulario.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVocabulario.ForeColor = System.Drawing.Color.White;
            this.labelVocabulario.Location = new System.Drawing.Point(245, 9);
            this.labelVocabulario.Name = "labelVocabulario";
            this.labelVocabulario.Size = new System.Drawing.Size(82, 16);
            this.labelVocabulario.TabIndex = 5;
            this.labelVocabulario.Text = "Vocabulário";
            this.labelVocabulario.Click += new System.EventHandler(this.labelVocabulario_Click);
            this.labelVocabulario.MouseEnter += new System.EventHandler(this.labelVocabulario_MouseEnter);
            this.labelVocabulario.MouseLeave += new System.EventHandler(this.labelVocabulario_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.Location = new System.Drawing.Point(336, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(15, 41);
            this.panel5.TabIndex = 6;
            // 
            // labelDistribuida
            // 
            this.labelDistribuida.AutoSize = true;
            this.labelDistribuida.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistribuida.ForeColor = System.Drawing.Color.White;
            this.labelDistribuida.Location = new System.Drawing.Point(357, 9);
            this.labelDistribuida.Name = "labelDistribuida";
            this.labelDistribuida.Size = new System.Drawing.Size(76, 16);
            this.labelDistribuida.TabIndex = 7;
            this.labelDistribuida.Text = "Distribuída";
            this.labelDistribuida.Click += new System.EventHandler(this.labelDistribuida_Click);
            this.labelDistribuida.MouseEnter += new System.EventHandler(this.labelDistribuida_MouseEnter);
            this.labelDistribuida.MouseLeave += new System.EventHandler(this.labelDistribuida_MouseLeave);
            // 
            // labelSair
            // 
            this.labelSair.AutoSize = true;
            this.labelSair.Font = new System.Drawing.Font("Arial", 12.3F);
            this.labelSair.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSair.Location = new System.Drawing.Point(848, 7);
            this.labelSair.Name = "labelSair";
            this.labelSair.Size = new System.Drawing.Size(47, 19);
            this.labelSair.TabIndex = 16;
            this.labelSair.Text = "SAIR";
            this.labelSair.Click += new System.EventHandler(this.labelSair_Click);
            this.labelSair.MouseEnter += new System.EventHandler(this.labelSair_MouseEnter);
            this.labelSair.MouseLeave += new System.EventHandler(this.labelSair_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.labelSair);
            this.panel1.Controls.Add(this.labelDistribuida);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.labelVocabulario);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.labelAutoridades);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelBibliografica);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 42);
            this.panel1.TabIndex = 0;
            // 
            // labelAutoridades
            // 
            this.labelAutoridades.AutoSize = true;
            this.labelAutoridades.Font = new System.Drawing.Font("Arial", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutoridades.ForeColor = System.Drawing.Color.White;
            this.labelAutoridades.Location = new System.Drawing.Point(134, 9);
            this.labelAutoridades.Name = "labelAutoridades";
            this.labelAutoridades.Size = new System.Drawing.Size(84, 16);
            this.labelAutoridades.TabIndex = 3;
            this.labelAutoridades.Text = "Autoridades";
            this.labelAutoridades.Click += new System.EventHandler(this.labelAutoridades_Click);
            this.labelAutoridades.MouseEnter += new System.EventHandler(this.labelAutoridades_MouseEnter);
            this.labelAutoridades.MouseLeave += new System.EventHandler(this.labelAutoridades_MouseLeave);
            // 
            // fmBusca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(907, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmBusca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmBusca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Bibliografica_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBibliografica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelVocabulario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelDistribuida;
        private System.Windows.Forms.Label labelSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAutoridades;
    }
}