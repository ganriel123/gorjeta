
namespace CalculoGorjeta
{
    partial class CalculoGorjeta
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
            this.btnCalcularGorjeta = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblValorConta = new System.Windows.Forms.Label();
            this.lblQualidade = new System.Windows.Forms.Label();
            this.lblValorGorjeta = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularGorjeta
            // 
            this.btnCalcularGorjeta.BackColor = System.Drawing.Color.LawnGreen;
            this.btnCalcularGorjeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularGorjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularGorjeta.Location = new System.Drawing.Point(9, 252);
            this.btnCalcularGorjeta.Name = "btnCalcularGorjeta";
            this.btnCalcularGorjeta.Size = new System.Drawing.Size(507, 48);
            this.btnCalcularGorjeta.TabIndex = 0;
            this.btnCalcularGorjeta.Text = "Calcular Gorjeta";
            this.btnCalcularGorjeta.UseVisualStyleBackColor = false;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(9, 74);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(510, 20);
            this.txtConta.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 197);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(510, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 365);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(507, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 441);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(507, 20);
            this.textBox4.TabIndex = 4;
            // 
            // lblValorConta
            // 
            this.lblValorConta.AutoSize = true;
            this.lblValorConta.Location = new System.Drawing.Point(12, 42);
            this.lblValorConta.Name = "lblValorConta";
            this.lblValorConta.Size = new System.Drawing.Size(77, 13);
            this.lblValorConta.TabIndex = 5;
            this.lblValorConta.Text = "Valor da Conta";
            this.lblValorConta.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQualidade
            // 
            this.lblQualidade.AutoSize = true;
            this.lblQualidade.Location = new System.Drawing.Point(9, 169);
            this.lblQualidade.Name = "lblQualidade";
            this.lblQualidade.Size = new System.Drawing.Size(107, 13);
            this.lblQualidade.TabIndex = 6;
            this.lblQualidade.Text = "Qualidade do serviço";
            // 
            // lblValorGorjeta
            // 
            this.lblValorGorjeta.AutoSize = true;
            this.lblValorGorjeta.Location = new System.Drawing.Point(9, 330);
            this.lblValorGorjeta.Name = "lblValorGorjeta";
            this.lblValorGorjeta.Size = new System.Drawing.Size(85, 13);
            this.lblValorGorjeta.TabIndex = 7;
            this.lblValorGorjeta.Text = "Valor Da Gorjeta";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(9, 408);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 8;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(9, 107);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lblFuncionario.TabIndex = 10;
            this.lblFuncionario.Text = "Nome Funcionario";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(9, 139);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(507, 20);
            this.txtFuncionario.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(9, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(507, 48);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cadastrar Gorjeta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CalculoGorjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 565);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblValorGorjeta);
            this.Controls.Add(this.lblQualidade);
            this.Controls.Add(this.lblValorConta);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.btnCalcularGorjeta);
            this.Name = "CalculoGorjeta";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularGorjeta;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblValorConta;
        private System.Windows.Forms.Label lblQualidade;
        private System.Windows.Forms.Label lblValorGorjeta;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Button button1;
    }
}

