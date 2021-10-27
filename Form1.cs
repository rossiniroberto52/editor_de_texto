using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace editor_de_texto
{
    public partial class Form1 : Form
    {//functions
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }
        private void Salvar()
        {
            try
            {
                if(this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter Rossi_streamWriter = new StreamWriter(arquivo);
                    Rossi_streamWriter.Flush();
                    Rossi_streamWriter.BaseStream.Seek(0,SeekOrigin.Begin);
                    Rossi_streamWriter.Write(this.richTextBox1.Text);
                    Rossi_streamWriter.Flush();
                    Rossi_streamWriter.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error to create " + ex.Message, "Error to save",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Abrir()
        {
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "open archive";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "(*.rossi)|*.rossi";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                    StreamReader Rossi_streamReader = new StreamReader(arquivo);
                    Rossi_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string linha = Rossi_streamReader.ReadLine();
                    while(linha != null)
                    {
                        this.richTextBox1.Text += linha + "\n";
                        linha = Rossi_streamReader.ReadLine();
                    }
                    Rossi_streamReader.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error to read " + ex.Message, "Error to read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }
        private void Negrito()
        {
            string nome_da_fonte = null;
            float tamanho_da_Fonte = 0;
            bool n,i,s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Regular);
            
            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold);
                }
            }
            else
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic);
                }
            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_Fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Regular);

            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic);
                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold);
                }
            }
        }
        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_Fonte = 0;
            bool n, i, s = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;
            richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Regular);

            if (s == false)
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == false & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Underline);
                }
            }
            else
            {
                if (i == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic | FontStyle.Italic);
                }
                else if (i == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic);
                }
                else if (i == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold);
                }
            }
        }
        private void AlinhaEsquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }
        private void AlinhaDireita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }
        private void AlinhaCentro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }
        

        //objs
        private void btn_Novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void italicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            AlinhaEsquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaEsquerda();
        }

        private void btn_Centro_Click(object sender, EventArgs e)
        {
            AlinhaCentro();
        }

        private void centralixarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaCentro();
        }

        private void btn_Direita_Click(object sender, EventArgs e)
        {
            AlinhaDireita();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlinhaDireita();
        }
        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int count = 0;
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;
            if(MargemEsquerda < 5)
            {
                MargemEsquerda = 20;
            }
            if(MargemSuperior < 5)
            {
                MargemSuperior = 20;
            }
            string linha = null;
            Font Fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);
            linhasPagina = e.MarginBounds.Height / Fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while(count < linhasPagina)
            {
                PosY = (MargemSuperior + (count * Fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, Fonte, pincel,MargemEsquerda, PosY, new StringFormat());
                count+=1;
                linha = leitura.ReadLine();
            }
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }

        
    }
}
