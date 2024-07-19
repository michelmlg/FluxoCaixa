namespace prjFluxoCaixa
{
    partial class frmLivroCaixa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.txData = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.rbDebito = new System.Windows.Forms.RadioButton();
            this.cbResponsavel = new System.Windows.Forms.ComboBox();
            this.lbResponsavel = new System.Windows.Forms.Label();
            this.txValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.txRelatorio = new System.Windows.Forms.TextBox();
            this.lbFamilia = new System.Windows.Forms.Label();
            this.cbFamilia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.ForeColor = System.Drawing.Color.Brown;
            this.lbTitulo.Location = new System.Drawing.Point(298, 25);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(234, 42);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Livro Caixa";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(37, 93);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(31, 15);
            this.lbData.TabIndex = 1;
            this.lbData.Text = "Data";
            // 
            // txData
            // 
            this.txData.Location = new System.Drawing.Point(37, 111);
            this.txData.Name = "txData";
            this.txData.Size = new System.Drawing.Size(86, 23);
            this.txData.TabIndex = 2;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(129, 93);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 15);
            this.lbDescricao.TabIndex = 3;
            this.lbDescricao.Text = "Descrição";
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(129, 111);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(288, 23);
            this.txDescricao.TabIndex = 4;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(676, 94);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(64, 19);
            this.rbCredito.TabIndex = 5;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Crédito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            this.rbDebito.AutoSize = true;
            this.rbDebito.Location = new System.Drawing.Point(676, 117);
            this.rbDebito.Name = "rbDebito";
            this.rbDebito.Size = new System.Drawing.Size(60, 19);
            this.rbDebito.TabIndex = 6;
            this.rbDebito.TabStop = true;
            this.rbDebito.Text = "Débito";
            this.rbDebito.UseVisualStyleBackColor = true;
            // 
            // cbResponsavel
            // 
            this.cbResponsavel.FormattingEnabled = true;
            this.cbResponsavel.Location = new System.Drawing.Point(422, 111);
            this.cbResponsavel.Name = "cbResponsavel";
            this.cbResponsavel.Size = new System.Drawing.Size(121, 23);
            this.cbResponsavel.TabIndex = 7;
            // 
            // lbResponsavel
            // 
            this.lbResponsavel.AutoSize = true;
            this.lbResponsavel.Location = new System.Drawing.Point(422, 93);
            this.lbResponsavel.Name = "lbResponsavel";
            this.lbResponsavel.Size = new System.Drawing.Size(72, 15);
            this.lbResponsavel.TabIndex = 8;
            this.lbResponsavel.Text = "Responsável";
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(755, 112);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(86, 23);
            this.txValor.TabIndex = 10;
            this.txValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(755, 94);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(33, 15);
            this.lbValor.TabIndex = 9;
            this.lbValor.Text = "Valor";
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(847, 112);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(60, 23);
            this.btOK.TabIndex = 11;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // txRelatorio
            // 
            this.txRelatorio.Location = new System.Drawing.Point(37, 156);
            this.txRelatorio.Multiline = true;
            this.txRelatorio.Name = "txRelatorio";
            this.txRelatorio.ReadOnly = true;
            this.txRelatorio.Size = new System.Drawing.Size(887, 269);
            this.txRelatorio.TabIndex = 12;
            // 
            // lbFamilia
            // 
            this.lbFamilia.AutoSize = true;
            this.lbFamilia.Location = new System.Drawing.Point(549, 93);
            this.lbFamilia.Name = "lbFamilia";
            this.lbFamilia.Size = new System.Drawing.Size(45, 15);
            this.lbFamilia.TabIndex = 13;
            this.lbFamilia.Text = "Família";
            // 
            // cbFamilia
            // 
            this.cbFamilia.FormattingEnabled = true;
            this.cbFamilia.Location = new System.Drawing.Point(549, 111);
            this.cbFamilia.Name = "cbFamilia";
            this.cbFamilia.Size = new System.Drawing.Size(121, 23);
            this.cbFamilia.TabIndex = 14;
            // 
            // frmLivroCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.cbFamilia);
            this.Controls.Add(this.lbFamilia);
            this.Controls.Add(this.txRelatorio);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.lbResponsavel);
            this.Controls.Add(this.cbResponsavel);
            this.Controls.Add(this.rbDebito);
            this.Controls.Add(this.rbCredito);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.txData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmLivroCaixa";
            this.Text = "Livro Caixa Santa Cecilia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbTitulo;
        private Label lbData;
        private TextBox txData;
        private Label lbDescricao;
        private TextBox txDescricao;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private ComboBox cbResponsavel;
        private Label lbResponsavel;
        private TextBox txValor;
        private Label lbValor;
        private Button btOK;
        private TextBox txRelatorio;
        private Label lbFamilia;
        private ComboBox cbFamilia;
    }
}