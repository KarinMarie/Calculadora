
namespace Calculadora
{
    partial class Calculadora
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
            this.txtPainel = new System.Windows.Forms.TextBox();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnPonto = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnApagarDigito = new System.Windows.Forms.Button();
            this.btnApagarTudo = new System.Windows.Forms.Button();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnApagarN2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPainel
            // 
            this.txtPainel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPainel.Location = new System.Drawing.Point(3, 12);
            this.txtPainel.Multiline = true;
            this.txtPainel.Name = "txtPainel";
            this.txtPainel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPainel.Size = new System.Drawing.Size(246, 75);
            this.txtPainel.TabIndex = 0;
            this.txtPainel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPainel.TextChanged += new System.EventHandler(this.txtPainel_TextChanged);
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnQuadrado.Location = new System.Drawing.Point(3, 332);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(57, 47);
            this.btnQuadrado.TabIndex = 1;
            this.btnQuadrado.Text = "x²";
            this.btnQuadrado.UseVisualStyleBackColor = false;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(66, 332);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 47);
            this.btn0.TabIndex = 2;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnPonto
            // 
            this.btnPonto.Location = new System.Drawing.Point(129, 332);
            this.btnPonto.Name = "btnPonto";
            this.btnPonto.Size = new System.Drawing.Size(57, 47);
            this.btnPonto.TabIndex = 3;
            this.btnPonto.Text = ",";
            this.btnPonto.UseVisualStyleBackColor = true;
            this.btnPonto.Click += new System.EventHandler(this.btnPonto_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.LightCoral;
            this.btnResult.Location = new System.Drawing.Point(192, 332);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(57, 47);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "=";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnAdicao
            // 
            this.btnAdicao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAdicao.Location = new System.Drawing.Point(192, 279);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(57, 47);
            this.btnAdicao.TabIndex = 8;
            this.btnAdicao.Text = "+";
            this.btnAdicao.UseVisualStyleBackColor = false;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 279);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 47);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(66, 279);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 47);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(3, 279);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 47);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubtracao.Location = new System.Drawing.Point(192, 226);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(57, 47);
            this.btnSubtracao.TabIndex = 12;
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(129, 226);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 47);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(66, 226);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 47);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(3, 226);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 47);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMultiplicacao.Location = new System.Drawing.Point(192, 173);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(57, 47);
            this.btnMultiplicacao.TabIndex = 16;
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(129, 173);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 47);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(66, 173);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 47);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 173);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 47);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDivisao.Location = new System.Drawing.Point(192, 120);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(57, 47);
            this.btnDivisao.TabIndex = 17;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnApagarDigito
            // 
            this.btnApagarDigito.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnApagarDigito.Location = new System.Drawing.Point(129, 120);
            this.btnApagarDigito.Name = "btnApagarDigito";
            this.btnApagarDigito.Size = new System.Drawing.Size(57, 47);
            this.btnApagarDigito.TabIndex = 18;
            this.btnApagarDigito.Text = "<-";
            this.btnApagarDigito.UseVisualStyleBackColor = false;
            this.btnApagarDigito.Click += new System.EventHandler(this.btnApagarDigito_Click);
            // 
            // btnApagarTudo
            // 
            this.btnApagarTudo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnApagarTudo.Location = new System.Drawing.Point(66, 120);
            this.btnApagarTudo.Name = "btnApagarTudo";
            this.btnApagarTudo.Size = new System.Drawing.Size(57, 47);
            this.btnApagarTudo.TabIndex = 19;
            this.btnApagarTudo.Text = "C";
            this.btnApagarTudo.UseVisualStyleBackColor = false;
            this.btnApagarTudo.Click += new System.EventHandler(this.btnApagarTudo_Click);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOperacao.Location = new System.Drawing.Point(4, 16);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 20);
            this.lblOperacao.TabIndex = 20;
            // 
            // btnApagarN2
            // 
            this.btnApagarN2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnApagarN2.Location = new System.Drawing.Point(3, 120);
            this.btnApagarN2.Name = "btnApagarN2";
            this.btnApagarN2.Size = new System.Drawing.Size(57, 47);
            this.btnApagarN2.TabIndex = 21;
            this.btnApagarN2.Text = "CE";
            this.btnApagarN2.UseVisualStyleBackColor = false;
            this.btnApagarN2.Click += new System.EventHandler(this.btnApagarN2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "© Karin Marie, 2022.";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagarN2);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.btnApagarTudo);
            this.Controls.Add(this.btnApagarDigito);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnPonto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.txtPainel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPainel;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnPonto;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnApagarDigito;
        private System.Windows.Forms.Button btnApagarTudo;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btnApagarN2;
        private System.Windows.Forms.Label label1;
    }
}

