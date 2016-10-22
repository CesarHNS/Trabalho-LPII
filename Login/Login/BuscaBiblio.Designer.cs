namespace Login
{
    partial class BuscaBiblio
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlBusca = new System.Windows.Forms.TabControl();
            this.tabPageBusca = new System.Windows.Forms.TabPage();
            this.buttonRepetir = new System.Windows.Forms.Button();
            this.buttonBuscarBibliografica = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonListarTodos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelNoAtributo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.tabPageFicha = new System.Windows.Forms.TabPage();
            this.tabPageMarc = new System.Windows.Forms.TabPage();
            this.panel6.SuspendLayout();
            this.tabControlBusca.SuspendLayout();
            this.tabPageBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1021, 38);
            this.panel6.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Busca Bibliográfica";
            // 
            // tabControlBusca
            // 
            this.tabControlBusca.Controls.Add(this.tabPageBusca);
            this.tabControlBusca.Controls.Add(this.tabPageFicha);
            this.tabControlBusca.Controls.Add(this.tabPageMarc);
            this.tabControlBusca.Location = new System.Drawing.Point(49, 98);
            this.tabControlBusca.Name = "tabControlBusca";
            this.tabControlBusca.SelectedIndex = 0;
            this.tabControlBusca.Size = new System.Drawing.Size(921, 198);
            this.tabControlBusca.TabIndex = 5;
            // 
            // tabPageBusca
            // 
            this.tabPageBusca.Controls.Add(this.buttonRepetir);
            this.tabPageBusca.Controls.Add(this.buttonBuscarBibliografica);
            this.tabPageBusca.Controls.Add(this.buttonLimpar);
            this.tabPageBusca.Controls.Add(this.buttonListarTodos);
            this.tabPageBusca.Controls.Add(this.textBox1);
            this.tabPageBusca.Controls.Add(this.comboBox2);
            this.tabPageBusca.Controls.Add(this.comboBox1);
            this.tabPageBusca.Controls.Add(this.labelNoAtributo);
            this.tabPageBusca.Controls.Add(this.label2);
            this.tabPageBusca.Controls.Add(this.labelMaterial);
            this.tabPageBusca.Location = new System.Drawing.Point(4, 22);
            this.tabPageBusca.Name = "tabPageBusca";
            this.tabPageBusca.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBusca.Size = new System.Drawing.Size(913, 172);
            this.tabPageBusca.TabIndex = 0;
            this.tabPageBusca.Text = "Busca";
            this.tabPageBusca.UseVisualStyleBackColor = true;
            // 
            // buttonRepetir
            // 
            this.buttonRepetir.AllowDrop = true;
            this.buttonRepetir.Location = new System.Drawing.Point(684, 68);
            this.buttonRepetir.Name = "buttonRepetir";
            this.buttonRepetir.Size = new System.Drawing.Size(71, 25);
            this.buttonRepetir.TabIndex = 9;
            this.buttonRepetir.Text = "Repetir";
            this.buttonRepetir.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarBibliografica
            // 
            this.buttonBuscarBibliografica.AllowDrop = true;
            this.buttonBuscarBibliografica.Location = new System.Drawing.Point(654, 132);
            this.buttonBuscarBibliografica.Name = "buttonBuscarBibliografica";
            this.buttonBuscarBibliografica.Size = new System.Drawing.Size(101, 25);
            this.buttonBuscarBibliografica.TabIndex = 8;
            this.buttonBuscarBibliografica.Text = "Buscar";
            this.buttonBuscarBibliografica.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(436, 132);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(104, 25);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonListarTodos
            // 
            this.buttonListarTodos.Location = new System.Drawing.Point(199, 132);
            this.buttonListarTodos.Name = "buttonListarTodos";
            this.buttonListarTodos.Size = new System.Drawing.Size(99, 25);
            this.buttonListarTodos.TabIndex = 6;
            this.buttonListarTodos.Text = "Listar Todos";
            this.buttonListarTodos.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 5;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(546, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(115, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(325, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // labelNoAtributo
            // 
            this.labelNoAtributo.AutoSize = true;
            this.labelNoAtributo.Location = new System.Drawing.Point(461, 74);
            this.labelNoAtributo.Name = "labelNoAtributo";
            this.labelNoAtributo.Size = new System.Drawing.Size(57, 13);
            this.labelNoAtributo.TabIndex = 2;
            this.labelNoAtributo.Text = "no atributo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contendo o texto";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(240, 30);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(44, 13);
            this.labelMaterial.TabIndex = 0;
            this.labelMaterial.Text = "Material";
            // 
            // tabPageFicha
            // 
            this.tabPageFicha.Location = new System.Drawing.Point(4, 22);
            this.tabPageFicha.Name = "tabPageFicha";
            this.tabPageFicha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFicha.Size = new System.Drawing.Size(998, 172);
            this.tabPageFicha.TabIndex = 1;
            this.tabPageFicha.Text = "Ficha";
            this.tabPageFicha.UseVisualStyleBackColor = true;
            // 
            // tabPageMarc
            // 
            this.tabPageMarc.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarc.Name = "tabPageMarc";
            this.tabPageMarc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarc.Size = new System.Drawing.Size(998, 172);
            this.tabPageMarc.TabIndex = 2;
            this.tabPageMarc.Text = "MARC";
            this.tabPageMarc.UseVisualStyleBackColor = true;
            // 
            // BuscaBiblio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 741);
            this.Controls.Add(this.tabControlBusca);
            this.Controls.Add(this.panel6);
            this.Name = "BuscaBiblio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControlBusca.ResumeLayout(false);
            this.tabPageBusca.ResumeLayout(false);
            this.tabPageBusca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlBusca;
        private System.Windows.Forms.TabPage tabPageBusca;
        private System.Windows.Forms.Button buttonRepetir;
        private System.Windows.Forms.Button buttonBuscarBibliografica;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonListarTodos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelNoAtributo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.TabPage tabPageFicha;
        private System.Windows.Forms.TabPage tabPageMarc;
    }
}