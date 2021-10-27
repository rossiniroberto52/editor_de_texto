
namespace editor_de_texto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralixarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.btn_salvar = new System.Windows.Forms.ToolStripButton();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.btn_sublinhado = new System.Windows.Forms.ToolStripButton();
            this.btn_Fonte = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_Centro = new System.Windows.Forms.ToolStripButton();
            this.btn_Direita = new System.Windows.Forms.ToolStripButton();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(597, 397);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(597, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.arquivoToolStripMenuItem.Text = "arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novoToolStripMenuItem.Text = "novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salvarToolStripMenuItem.Text = "salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimirToolStripMenuItem.Text = "imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sairToolStripMenuItem.Text = "sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.copiarToolStripMenuItem.Text = "copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.colarToolStripMenuItem.Text = "colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.desfazerToolStripMenuItem.Text = "desfazer";
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.refazerToolStripMenuItem.Text = "refazer";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.italicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fonteToolStripMenuItem.Text = "Fonte";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negritoToolStripMenuItem.Text = "negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // italicoToolStripMenuItem
            // 
            this.italicoToolStripMenuItem.Name = "italicoToolStripMenuItem";
            this.italicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.italicoToolStripMenuItem.Text = "italico";
            this.italicoToolStripMenuItem.Click += new System.EventHandler(this.italicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sublinhadoToolStripMenuItem.Text = "sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralixarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralixarToolStripMenuItem
            // 
            this.centralixarToolStripMenuItem.Name = "centralixarToolStripMenuItem";
            this.centralixarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centralixarToolStripMenuItem.Text = "centralizar";
            this.centralixarToolStripMenuItem.Click += new System.EventHandler(this.centralixarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.esquerdaToolStripMenuItem.Text = "esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.direitaToolStripMenuItem.Text = "direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.btn_Abrir,
            this.btn_salvar,
            this.btn_Copiar,
            this.btn_Colar,
            this.btn_Negrito,
            this.btn_Italico,
            this.btn_sublinhado,
            this.btn_Fonte,
            this.toolStripSeparator1,
            this.btn_Esquerda,
            this.btn_Centro,
            this.btn_Direita});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(597, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Novo
            // 
            this.btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novo.Image = global::editor_de_texto.Properties.Resources.novo;
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(23, 22);
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Abrir.Image = global::editor_de_texto.Properties.Resources.abrir;
            this.btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(23, 22);
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_salvar.Image = global::editor_de_texto.Properties.Resources.salvar;
            this.btn_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_salvar.Text = "salvar";
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = global::editor_de_texto.Properties.Resources.copiar;
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_Copiar.Text = "copiar";
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Colar
            // 
            this.btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Colar.Image = global::editor_de_texto.Properties.Resources.colar;
            this.btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Colar.Name = "btn_Colar";
            this.btn_Colar.Size = new System.Drawing.Size(23, 22);
            this.btn_Colar.Text = "colar";
            this.btn_Colar.Click += new System.EventHandler(this.btn_Colar_Click);
            // 
            // btn_Negrito
            // 
            this.btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Negrito.Image = global::editor_de_texto.Properties.Resources.negrito;
            this.btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Negrito.Name = "btn_Negrito";
            this.btn_Negrito.Size = new System.Drawing.Size(23, 22);
            this.btn_Negrito.Text = "negrito";
            this.btn_Negrito.Click += new System.EventHandler(this.btn_Negrito_Click);
            // 
            // btn_Italico
            // 
            this.btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italico.Image = global::editor_de_texto.Properties.Resources.italico;
            this.btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italico.Name = "btn_Italico";
            this.btn_Italico.Size = new System.Drawing.Size(23, 22);
            this.btn_Italico.Text = "italico";
            this.btn_Italico.Click += new System.EventHandler(this.btn_Italico_Click);
            // 
            // btn_sublinhado
            // 
            this.btn_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_sublinhado.Image = global::editor_de_texto.Properties.Resources.sublinhado;
            this.btn_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_sublinhado.Name = "btn_sublinhado";
            this.btn_sublinhado.Size = new System.Drawing.Size(23, 22);
            this.btn_sublinhado.Text = "sublinhado";
            this.btn_sublinhado.Click += new System.EventHandler(this.btn_sublinhado_Click);
            // 
            // btn_Fonte
            // 
            this.btn_Fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Fonte.Image = global::editor_de_texto.Properties.Resources.fonte;
            this.btn_Fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Fonte.Name = "btn_Fonte";
            this.btn_Fonte.Size = new System.Drawing.Size(23, 22);
            this.btn_Fonte.Text = "fonte";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Esquerda.Image = global::editor_de_texto.Properties.Resources.esquerda;
            this.btn_Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(23, 22);
            this.btn_Esquerda.Text = "esquerda";
            this.btn_Esquerda.Click += new System.EventHandler(this.btn_Esquerda_Click);
            // 
            // btn_Centro
            // 
            this.btn_Centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Centro.Image = global::editor_de_texto.Properties.Resources.centralizar;
            this.btn_Centro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Centro.Name = "btn_Centro";
            this.btn_Centro.Size = new System.Drawing.Size(23, 22);
            this.btn_Centro.Text = "centro";
            this.btn_Centro.Click += new System.EventHandler(this.btn_Centro_Click);
            // 
            // btn_Direita
            // 
            this.btn_Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Direita.Image = global::editor_de_texto.Properties.Resources.direita;
            this.btn_Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(23, 22);
            this.btn_Direita.Text = "direita";
            this.btn_Direita.Click += new System.EventHandler(this.btn_Direita_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "rossi";
            this.saveFileDialog1.Filter = "(*.ROSSI)|*.ROSSI";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 449);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editor de texto - Rossini Roberto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralixarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Abrir;
        private System.Windows.Forms.ToolStripButton btn_salvar;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripButton btn_Colar;
        private System.Windows.Forms.ToolStripButton btn_Negrito;
        private System.Windows.Forms.ToolStripButton btn_Italico;
        private System.Windows.Forms.ToolStripButton btn_sublinhado;
        private System.Windows.Forms.ToolStripButton btn_Fonte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Esquerda;
        private System.Windows.Forms.ToolStripButton btn_Centro;
        private System.Windows.Forms.ToolStripButton btn_Direita;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

