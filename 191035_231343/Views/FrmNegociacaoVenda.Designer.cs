namespace _191035_231343.Views
{
    partial class FrmNegociacaoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNegociacaoVenda));
            this.grbVenda = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtIdVenda = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.grbParcelas = new System.Windows.Forms.GroupBox();
            this.lblVlrParcela = new System.Windows.Forms.Label();
            this.dtpVencto = new System.Windows.Forms.DateTimePicker();
            this.nudQtdeParcela = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.grbVenda.SuspendLayout();
            this.grbEntrada.SuspendLayout();
            this.grbParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeParcela)).BeginInit();
            this.SuspendLayout();
            // 
            // grbVenda
            // 
            this.grbVenda.Controls.Add(this.txtNome);
            this.grbVenda.Controls.Add(this.txtTotal);
            this.grbVenda.Controls.Add(this.txtData);
            this.grbVenda.Controls.Add(this.txtIdVenda);
            this.grbVenda.Controls.Add(this.txtIdCliente);
            this.grbVenda.Controls.Add(this.label4);
            this.grbVenda.Controls.Add(this.label3);
            this.grbVenda.Controls.Add(this.label2);
            this.grbVenda.Controls.Add(this.label1);
            this.grbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVenda.Location = new System.Drawing.Point(33, 31);
            this.grbVenda.Name = "grbVenda";
            this.grbVenda.Size = new System.Drawing.Size(726, 121);
            this.grbVenda.TabIndex = 0;
            this.grbVenda.TabStop = false;
            this.grbVenda.Text = "Venda";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(179, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(520, 22);
            this.txtNome.TabIndex = 8;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(550, 28);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(149, 22);
            this.txtTotal.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(298, 25);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(78, 22);
            this.txtData.TabIndex = 6;
            // 
            // txtIdVenda
            // 
            this.txtIdVenda.Location = new System.Drawing.Point(84, 28);
            this.txtIdVenda.Name = "txtIdVenda";
            this.txtIdVenda.Size = new System.Drawing.Size(78, 22);
            this.txtIdVenda.TabIndex = 5;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(84, 76);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(78, 22);
            this.txtIdCliente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // grbEntrada
            // 
            this.grbEntrada.Controls.Add(this.txtEntrada);
            this.grbEntrada.Controls.Add(this.label5);
            this.grbEntrada.Controls.Add(this.label6);
            this.grbEntrada.Controls.Add(this.lblSaldo);
            this.grbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEntrada.Location = new System.Drawing.Point(33, 158);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Size = new System.Drawing.Size(356, 121);
            this.grbEntrada.TabIndex = 1;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(142, 39);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(178, 22);
            this.txtEntrada.TabIndex = 9;
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entrada:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saldo a Pagar:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Red;
            this.lblSaldo.Location = new System.Drawing.Point(138, 81);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(72, 20);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "R$ 0,00";
            // 
            // grbParcelas
            // 
            this.grbParcelas.Controls.Add(this.lblVlrParcela);
            this.grbParcelas.Controls.Add(this.dtpVencto);
            this.grbParcelas.Controls.Add(this.nudQtdeParcela);
            this.grbParcelas.Controls.Add(this.label11);
            this.grbParcelas.Controls.Add(this.label8);
            this.grbParcelas.Controls.Add(this.label9);
            this.grbParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbParcelas.Location = new System.Drawing.Point(395, 158);
            this.grbParcelas.Name = "grbParcelas";
            this.grbParcelas.Size = new System.Drawing.Size(364, 121);
            this.grbParcelas.TabIndex = 1;
            this.grbParcelas.TabStop = false;
            this.grbParcelas.Text = "Parcelas";
            // 
            // lblVlrParcela
            // 
            this.lblVlrParcela.AutoSize = true;
            this.lblVlrParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVlrParcela.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblVlrParcela.Location = new System.Drawing.Point(251, 38);
            this.lblVlrParcela.Name = "lblVlrParcela";
            this.lblVlrParcela.Size = new System.Drawing.Size(72, 20);
            this.lblVlrParcela.TabIndex = 10;
            this.lblVlrParcela.Text = "R$ 0,00";
            // 
            // dtpVencto
            // 
            this.dtpVencto.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencto.Location = new System.Drawing.Point(166, 76);
            this.dtpVencto.Name = "dtpVencto";
            this.dtpVencto.Size = new System.Drawing.Size(171, 22);
            this.dtpVencto.TabIndex = 12;
            // 
            // nudQtdeParcela
            // 
            this.nudQtdeParcela.Location = new System.Drawing.Point(88, 39);
            this.nudQtdeParcela.Name = "nudQtdeParcela";
            this.nudQtdeParcela.Size = new System.Drawing.Size(72, 22);
            this.nudQtdeParcela.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Pagto. da Primeira:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Qtde:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(185, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Valor:";
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFinanceiro.Image")));
            this.btnFinanceiro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanceiro.Location = new System.Drawing.Point(540, 306);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(219, 63);
            this.btnFinanceiro.TabIndex = 2;
            this.btnFinanceiro.Text = "Gerar Financeiro";
            this.btnFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // FrmNegociacaoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 394);
            this.Controls.Add(this.btnFinanceiro);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.grbParcelas);
            this.Controls.Add(this.grbVenda);
            this.Name = "FrmNegociacaoVenda";
            this.Text = "Negociação de Venda";
            this.grbVenda.ResumeLayout(false);
            this.grbVenda.PerformLayout();
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            this.grbParcelas.ResumeLayout(false);
            this.grbParcelas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdeParcela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.GroupBox grbParcelas;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtIdVenda;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DateTimePicker dtpVencto;
        private System.Windows.Forms.NumericUpDown nudQtdeParcela;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblVlrParcela;
    }
}