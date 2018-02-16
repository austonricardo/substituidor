using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration; 
namespace substituidor
{
    public partial class frmSubstituir : Form
    {
        public frmSubstituir()
        {
            InitializeComponent();
        }

        private void btnSelecao_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog(this);
            if (fbd.SelectedPath != "")
            {
                txtOrigem.Text = fbd.SelectedPath;
            }
        }

        private int contaArquivos(DirectoryInfo aPastaTeplate, String asFiltro)
        {
            //Percorrer as subpastas
            DirectoryInfo[] oSubPastas = aPastaTeplate.GetDirectories();
            int liConta = 0;
            foreach (DirectoryInfo oSub in oSubPastas)
            {
                liConta = liConta + contaArquivos(oSub, asFiltro);
            }

            FileInfo[] rgFiles = aPastaTeplate.GetFiles(asFiltro);
            return liConta + rgFiles.Length;
        }

        private void substituirEmArquivos(DirectoryInfo aPastaTeplate, DirectoryInfo aPastaSaida)
        {
            //Percorrer as subpastas
            DirectoryInfo[] oSubPastas = aPastaTeplate.GetDirectories();

            foreach (DirectoryInfo oSub in oSubPastas)
            {
                DirectoryInfo oSubDestino = aPastaSaida.CreateSubdirectory(oSub.Name);
                substituirEmArquivos(oSub, oSubDestino);
                oSubDestino = null;
            }

            FileInfo[] rgFiles = aPastaTeplate.GetFiles(txtFiltro.Text);
            foreach (FileInfo fi in rgFiles)
            {
                System.Console.WriteLine(aPastaTeplate.FullName + "\\" + fi.Name, System.IO.FileAccess.ReadWrite);
                //Processamento de substituição no Arquivo

                StreamReader oTemplate = new StreamReader(aPastaTeplate.FullName + "\\" + fi.Name, Encoding.Default);

                //percorre cada entidade e gera um arquivo para cada uma
                String sTemplateLinha;
                StringBuilder sbTexto = new StringBuilder(), sbCaminho = new StringBuilder();
                while(!oTemplate.EndOfStream) 
                {
                    sTemplateLinha = oTemplate.ReadLine();
                    if(!((sTemplateLinha.Length >= txtLinha.Text.Length) && (sTemplateLinha.Substring(0,txtLinha.Text.Length).Equals(txtLinha.Text) )))
                        sbTexto.AppendLine(sTemplateLinha);
                }
                sbCaminho.Append(aPastaSaida.FullName + "\\" + fi.Name);                
                oTemplate.Close();

                StreamWriter oArquivo = new StreamWriter(sbCaminho.ToString(), false, Encoding.Default);
                oArquivo.Write(sbTexto.ToString());
                oArquivo.Close();
                pgbResultado.PerformStep();
            }
        }

        String Chr(int i)
        {
            //Return the character of the given character value
            return Convert.ToChar(i).ToString();
        }

        private void btnSelecaoDestino_Click(object sender, EventArgs e)
        {
            fbd.ShowDialog(this);
            if (fbd.SelectedPath != "")
            {
                txtDestino.Text = fbd.SelectedPath;
            }
        }

        private void btnGeracao_Click(object sender, EventArgs e)
        {
            DirectoryInfo diTemplate = new DirectoryInfo(txtOrigem.Text);
            DirectoryInfo diDestino = new DirectoryInfo(txtDestino.Text);
            pgbResultado.Maximum = contaArquivos(diTemplate, txtFiltro.Text); 
            substituirEmArquivos(diTemplate, diDestino);
            MessageBox.Show("Substituição concluída", "Substituição", MessageBoxButtons.OK, MessageBoxIcon.Information);  

        }

        private void frmSubstituir_Load(object sender, EventArgs e)
        {
            String lsOrigem = ConfigurationManager.AppSettings["defaultInput"];
            txtOrigem.Text = (lsOrigem.IndexOf(":\\") > 0) ? lsOrigem : AppDomain.CurrentDomain.BaseDirectory + lsOrigem;
            String lsDestino = ConfigurationManager.AppSettings["defaultOutput"];
            txtDestino.Text = (lsDestino.IndexOf(":\\") > 0) ? lsDestino : AppDomain.CurrentDomain.BaseDirectory + lsDestino;

        }
    }
}