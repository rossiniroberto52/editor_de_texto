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
            bool negr = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            negr = richTextBox1.Font.Bold;
            
            if (negr == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Regular);
            }
        }
        private void Italico()
        {
            string nome_da_fonte = null;
            float tamanho_da_Fonte = 0;
            bool ita = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            ita = richTextBox1.Font.Italic;

            if (ita == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Italic);
            }
        }
        private void Sublinhado()
        {
            string nome_da_fonte = null;
            float tamanho_da_Fonte = 0;
            bool sub = false;

            nome_da_fonte = richTextBox1.Font.Name;
            tamanho_da_Fonte = richTextBox1.Font.Size;
            sub = richTextBox1.Font.Bold;

            if (sub == false)
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(nome_da_fonte, tamanho_da_Fonte, FontStyle.Underline);
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
    }
}
