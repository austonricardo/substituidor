namespace substituidor
{
    partial class frmSubstituir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubstituir));
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGeracao = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelecaoDestino = new System.Windows.Forms.Button();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelecao = new System.Windows.Forms.Button();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTermos = new System.Windows.Forms.DataGridView();
            this.De = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.pgbResultado = new System.Windows.Forms.ProgressBar();
            this.chkNomeArq = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermos)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeracao
            // 
            this.btnGeracao.Location = new System.Drawing.Point(494, 237);
            this.btnGeracao.Name = "btnGeracao";
            this.btnGeracao.Size = new System.Drawing.Size(75, 23);
            this.btnGeracao.TabIndex = 6;
            this.btnGeracao.Text = "Substituir";
            this.btnGeracao.UseVisualStyleBackColor = true;
            this.btnGeracao.Click += new System.EventHandler(this.btnGeracao_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 210);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chkNomeArq);
            this.tabPage1.Controls.Add(this.txtFiltro);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnSelecaoDestino);
            this.tabPage1.Controls.Add(this.txtDestino);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnSelecao);
            this.tabPage1.Controls.Add(this.txtOrigem);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(550, 184);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Opções";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(89, 74);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(185, 20);
            this.txtFiltro.TabIndex = 17;
            this.txtFiltro.Text = "*.cs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Filtro";
            // 
            // btnSelecaoDestino
            // 
            this.btnSelecaoDestino.Location = new System.Drawing.Point(431, 46);
            this.btnSelecaoDestino.Name = "btnSelecaoDestino";
            this.btnSelecaoDestino.Size = new System.Drawing.Size(38, 21);
            this.btnSelecaoDestino.TabIndex = 15;
            this.btnSelecaoDestino.Text = "...";
            this.btnSelecaoDestino.UseVisualStyleBackColor = true;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(89, 47);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(322, 20);
            this.txtDestino.TabIndex = 14;
            this.txtDestino.Text = "C:\\l2divine\\assembly\\L2Divine_Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pasta Destino";
            // 
            // btnSelecao
            // 
            this.btnSelecao.Location = new System.Drawing.Point(431, 20);
            this.btnSelecao.Name = "btnSelecao";
            this.btnSelecao.Size = new System.Drawing.Size(38, 21);
            this.btnSelecao.TabIndex = 12;
            this.btnSelecao.Text = "...";
            this.btnSelecao.UseVisualStyleBackColor = true;
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(89, 21);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(322, 20);
            this.txtOrigem.TabIndex = 11;
            this.txtOrigem.Text = "C:\\l2divine\\assembly\\substOrigem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pasta Origem";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvTermos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(550, 184);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Termos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTermos
            // 
            this.dgvTermos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.De,
            this.Para});
            this.dgvTermos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTermos.Location = new System.Drawing.Point(3, 3);
            this.dgvTermos.Name = "dgvTermos";
            this.dgvTermos.Size = new System.Drawing.Size(544, 178);
            this.dgvTermos.TabIndex = 0;
            // 
            // De
            // 
            this.De.HeaderText = "De";
            this.De.Name = "De";
            this.De.Width = 250;
            // 
            // Para
            // 
            this.Para.HeaderText = "Para";
            this.Para.Name = "Para";
            this.Para.Width = 250;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtResultado);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(550, 184);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resultado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(0, 0);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(550, 184);
            this.txtResultado.TabIndex = 8;
            // 
            // pgbResultado
            // 
            this.pgbResultado.Location = new System.Drawing.Point(16, 237);
            this.pgbResultado.Name = "pgbResultado";
            this.pgbResultado.Size = new System.Drawing.Size(468, 22);
            this.pgbResultado.Step = 100;
            this.pgbResultado.TabIndex = 11;
            // 
            // chkNomeArq
            // 
            this.chkNomeArq.AutoSize = true;
            this.chkNomeArq.Location = new System.Drawing.Point(21, 107);
            this.chkNomeArq.Name = "chkNomeArq";
            this.chkNomeArq.Size = new System.Drawing.Size(149, 17);
            this.chkNomeArq.TabIndex = 18;
            this.chkNomeArq.Text = "Incluir Nome dos Arquivos";
            this.chkNomeArq.UseVisualStyleBackColor = true;
            // 
            // frmSubstituir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 272);
            this.Controls.Add(this.pgbResultado);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGeracao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSubstituir";
            this.Text = "Substituidor em arquivos";
            this.Load += new System.EventHandler(this.frmSubstituir_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnGeracao;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelecaoDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelecao;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.DataGridView dgvTermos;
        private System.Windows.Forms.DataGridViewTextBoxColumn De;
        private System.Windows.Forms.DataGridViewTextBoxColumn Para;
        private System.Windows.Forms.ProgressBar pgbResultado;
        private System.Windows.Forms.CheckBox chkNomeArq;
    }
}

