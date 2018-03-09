namespace Banco.Relatorios
{
    partial class FormRelatorios
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
            this.listaResultado = new System.Windows.Forms.ListBox();
            this.botaoFiltroSaldo = new System.Windows.Forms.Button();
            this.botaoContasAntigas = new System.Windows.Forms.Button();
            this.Resumo = new System.Windows.Forms.GroupBox();
            this.labelMaiorSaldo = new System.Windows.Forms.Label();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.maiorSaldo = new System.Windows.Forms.Label();
            this.saldoTotal = new System.Windows.Forms.Label();
            this.Resumo.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaResultado
            // 
            this.listaResultado.FormattingEnabled = true;
            this.listaResultado.Location = new System.Drawing.Point(12, 11);
            this.listaResultado.Name = "listaResultado";
            this.listaResultado.Size = new System.Drawing.Size(283, 108);
            this.listaResultado.TabIndex = 0;
            // 
            // botaoFiltroSaldo
            // 
            this.botaoFiltroSaldo.Location = new System.Drawing.Point(12, 221);
            this.botaoFiltroSaldo.Name = "botaoFiltroSaldo";
            this.botaoFiltroSaldo.Size = new System.Drawing.Size(136, 23);
            this.botaoFiltroSaldo.TabIndex = 1;
            this.botaoFiltroSaldo.Text = "Saldo maior que 500";
            this.botaoFiltroSaldo.UseVisualStyleBackColor = true;
            this.botaoFiltroSaldo.Click += new System.EventHandler(this.botaoFiltroSaldo_Click);
            // 
            // botaoContasAntigas
            // 
            this.botaoContasAntigas.Location = new System.Drawing.Point(166, 221);
            this.botaoContasAntigas.Name = "botaoContasAntigas";
            this.botaoContasAntigas.Size = new System.Drawing.Size(129, 23);
            this.botaoContasAntigas.TabIndex = 2;
            this.botaoContasAntigas.Text = "Contas Antigas";
            this.botaoContasAntigas.UseVisualStyleBackColor = true;
            this.botaoContasAntigas.Click += new System.EventHandler(this.botaoContasAntigas_Click);
            // 
            // Resumo
            // 
            this.Resumo.Controls.Add(this.labelMaiorSaldo);
            this.Resumo.Controls.Add(this.labelSaldoTotal);
            this.Resumo.Controls.Add(this.maiorSaldo);
            this.Resumo.Controls.Add(this.saldoTotal);
            this.Resumo.Location = new System.Drawing.Point(12, 130);
            this.Resumo.Name = "Resumo";
            this.Resumo.Size = new System.Drawing.Size(283, 85);
            this.Resumo.TabIndex = 3;
            this.Resumo.TabStop = false;
            this.Resumo.Text = "Resumo";
            // 
            // labelMaiorSaldo
            // 
            this.labelMaiorSaldo.AutoSize = true;
            this.labelMaiorSaldo.Location = new System.Drawing.Point(186, 55);
            this.labelMaiorSaldo.Name = "labelMaiorSaldo";
            this.labelMaiorSaldo.Size = new System.Drawing.Size(82, 13);
            this.labelMaiorSaldo.TabIndex = 3;
            this.labelMaiorSaldo.Text = "labelMaiorSaldo";
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Location = new System.Drawing.Point(186, 27);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(80, 13);
            this.labelSaldoTotal.TabIndex = 2;
            this.labelSaldoTotal.Text = "labelSaldoTotal";
            // 
            // maiorSaldo
            // 
            this.maiorSaldo.AutoSize = true;
            this.maiorSaldo.Location = new System.Drawing.Point(6, 55);
            this.maiorSaldo.Name = "maiorSaldo";
            this.maiorSaldo.Size = new System.Drawing.Size(63, 13);
            this.maiorSaldo.TabIndex = 1;
            this.maiorSaldo.Text = "Maior Saldo";
            // 
            // saldoTotal
            // 
            this.saldoTotal.AutoSize = true;
            this.saldoTotal.Location = new System.Drawing.Point(6, 27);
            this.saldoTotal.Name = "saldoTotal";
            this.saldoTotal.Size = new System.Drawing.Size(61, 13);
            this.saldoTotal.TabIndex = 0;
            this.saldoTotal.Text = "Saldo Total";
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 256);
            this.Controls.Add(this.botaoContasAntigas);
            this.Controls.Add(this.botaoFiltroSaldo);
            this.Controls.Add(this.listaResultado);
            this.Controls.Add(this.Resumo);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.Resumo.ResumeLayout(false);
            this.Resumo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listaResultado;
        private System.Windows.Forms.Button botaoFiltroSaldo;
        private System.Windows.Forms.Button botaoContasAntigas;
        private System.Windows.Forms.GroupBox Resumo;
        private System.Windows.Forms.Label labelMaiorSaldo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label maiorSaldo;
        private System.Windows.Forms.Label saldoTotal;
    }
}