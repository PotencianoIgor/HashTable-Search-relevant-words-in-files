namespace TabelaHash
{
    partial class FrmTabelaHash
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
            this.ui_txtDiretorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ui_btnCarregar = new System.Windows.Forms.Button();
            this.ui_txtResultado = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ui_lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ui_txtPalavra = new System.Windows.Forms.TextBox();
            this.ui_btnPesquisar = new System.Windows.Forms.Button();
            this.ui_rdbtnApenasUma = new System.Windows.Forms.RadioButton();
            this.ui_rdbtnPeloMenosUma = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ui_txtDiretorio
            // 
            this.ui_txtDiretorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ui_txtDiretorio.CausesValidation = false;
            this.ui_txtDiretorio.Location = new System.Drawing.Point(12, 23);
            this.ui_txtDiretorio.Name = "ui_txtDiretorio";
            this.ui_txtDiretorio.ReadOnly = true;
            this.ui_txtDiretorio.Size = new System.Drawing.Size(370, 20);
            this.ui_txtDiretorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Diretório Base";
            // 
            // ui_btnCarregar
            // 
            this.ui_btnCarregar.CausesValidation = false;
            this.ui_btnCarregar.Location = new System.Drawing.Point(388, 21);
            this.ui_btnCarregar.Name = "ui_btnCarregar";
            this.ui_btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.ui_btnCarregar.TabIndex = 1;
            this.ui_btnCarregar.Text = "Carregar";
            this.ui_btnCarregar.UseVisualStyleBackColor = true;
            this.ui_btnCarregar.Click += new System.EventHandler(this.ui_btnCarregar_Click);
            // 
            // ui_txtResultado
            // 
            this.ui_txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_txtResultado.Location = new System.Drawing.Point(12, 132);
            this.ui_txtResultado.Multiline = true;
            this.ui_txtResultado.Name = "ui_txtResultado";
            this.ui_txtResultado.ReadOnly = true;
            this.ui_txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ui_txtResultado.Size = new System.Drawing.Size(451, 196);
            this.ui_txtResultado.TabIndex = 7;
            // 
            // ui_lblStatus
            // 
            this.ui_lblStatus.AutoSize = true;
            this.ui_lblStatus.Location = new System.Drawing.Point(12, 249);
            this.ui_lblStatus.Name = "ui_lblStatus";
            this.ui_lblStatus.Size = new System.Drawing.Size(0, 13);
            this.ui_lblStatus.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Palavra";
            // 
            // ui_txtPalavra
            // 
            this.ui_txtPalavra.CausesValidation = false;
            this.ui_txtPalavra.Location = new System.Drawing.Point(12, 97);
            this.ui_txtPalavra.Name = "ui_txtPalavra";
            this.ui_txtPalavra.Size = new System.Drawing.Size(370, 20);
            this.ui_txtPalavra.TabIndex = 9;
            this.ui_txtPalavra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ui_txtPalavra_KeyDown);
            // 
            // ui_btnPesquisar
            // 
            this.ui_btnPesquisar.CausesValidation = false;
            this.ui_btnPesquisar.Location = new System.Drawing.Point(388, 94);
            this.ui_btnPesquisar.Name = "ui_btnPesquisar";
            this.ui_btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.ui_btnPesquisar.TabIndex = 11;
            this.ui_btnPesquisar.Text = "Pesquisar";
            this.ui_btnPesquisar.UseVisualStyleBackColor = true;
            this.ui_btnPesquisar.Click += new System.EventHandler(this.ui_btnPesquisar_Click);
            // 
            // ui_rdbtnApenasUma
            // 
            this.ui_rdbtnApenasUma.AutoSize = true;
            this.ui_rdbtnApenasUma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ui_rdbtnApenasUma.CausesValidation = false;
            this.ui_rdbtnApenasUma.Checked = true;
            this.ui_rdbtnApenasUma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ui_rdbtnApenasUma.Location = new System.Drawing.Point(12, 59);
            this.ui_rdbtnApenasUma.Name = "ui_rdbtnApenasUma";
            this.ui_rdbtnApenasUma.Size = new System.Drawing.Size(86, 17);
            this.ui_rdbtnApenasUma.TabIndex = 12;
            this.ui_rdbtnApenasUma.TabStop = true;
            this.ui_rdbtnApenasUma.Text = "Apenas Uma";
            this.ui_rdbtnApenasUma.UseVisualStyleBackColor = false;
            // 
            // ui_rdbtnPeloMenosUma
            // 
            this.ui_rdbtnPeloMenosUma.AutoSize = true;
            this.ui_rdbtnPeloMenosUma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ui_rdbtnPeloMenosUma.CausesValidation = false;
            this.ui_rdbtnPeloMenosUma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ui_rdbtnPeloMenosUma.Location = new System.Drawing.Point(149, 59);
            this.ui_rdbtnPeloMenosUma.Name = "ui_rdbtnPeloMenosUma";
            this.ui_rdbtnPeloMenosUma.Size = new System.Drawing.Size(106, 17);
            this.ui_rdbtnPeloMenosUma.TabIndex = 13;
            this.ui_rdbtnPeloMenosUma.Text = "Pelo Menos Uma";
            this.ui_rdbtnPeloMenosUma.UseVisualStyleBackColor = false;
            // 
            // FrmTabelaHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(475, 340);
            this.Controls.Add(this.ui_rdbtnPeloMenosUma);
            this.Controls.Add(this.ui_rdbtnApenasUma);
            this.Controls.Add(this.ui_btnPesquisar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ui_txtPalavra);
            this.Controls.Add(this.ui_lblStatus);
            this.Controls.Add(this.ui_txtResultado);
            this.Controls.Add(this.ui_btnCarregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ui_txtDiretorio);
            this.Name = "FrmTabelaHash";
            this.ShowIcon = false;
            this.Text = "TabelaHash";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ui_txtDiretorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ui_btnCarregar;
        private System.Windows.Forms.TextBox ui_txtResultado;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label ui_lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ui_txtPalavra;
        private System.Windows.Forms.Button ui_btnPesquisar;
        private System.Windows.Forms.RadioButton ui_rdbtnApenasUma;
        private System.Windows.Forms.RadioButton ui_rdbtnPeloMenosUma;
    }
}

