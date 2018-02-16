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
    public partial class CopyFolderStruct : Form
    {
        public CopyFolderStruct()
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

        private int contaPastas(DirectoryInfo aPastaTeplate)
        {
            //Percorrer as subpastas
            DirectoryInfo[] oSubPastas = aPastaTeplate.GetDirectories();
            int liConta = 0;
            foreach (DirectoryInfo oSub in oSubPastas)
            {
                liConta = liConta + contaPastas(oSub);
            }
            return liConta + 1;
        }

        private void copiarPastas(DirectoryInfo aPastaTeplate, DirectoryInfo aPastaSaida)
        {
            //Percorrer as subpastas
            DirectoryInfo[] oSubPastas = aPastaTeplate.GetDirectories();
            
            foreach (DirectoryInfo oSub in oSubPastas)
            {
                DirectoryInfo oSubDestino = aPastaSaida.CreateSubdirectory(oSub.Name);
                copiarPastas(oSub, oSubDestino);
                oSubDestino = null;
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
            pgbResultado.Maximum = contaPastas(diTemplate); 
            copiarPastas(diTemplate, diDestino);
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