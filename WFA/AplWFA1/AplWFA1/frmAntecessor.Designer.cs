
namespace AplWFA1
{
    partial class frmAntecessor
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
            this.lblDigiteValor = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResultadoCalculo = new System.Windows.Forms.Label();
            this.txtbEntrada = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDigiteValor
            // 
            this.lblDigiteValor.AutoSize = true;
            this.lblDigiteValor.Location = new System.Drawing.Point(21, 39);
            this.lblDigiteValor.Name = "lblDigiteValor";
            this.lblDigiteValor.Size = new System.Drawing.Size(102, 17);
            this.lblDigiteValor.TabIndex = 0;
            this.lblDigiteValor.Text = "Digite um valor";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(21, 153);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 17);
            this.lblResultado.TabIndex = 1;
            this.lblResultado.Text = "Resultado";
            // 
            // lblResultadoCalculo
            // 
            this.lblResultadoCalculo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultadoCalculo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultadoCalculo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCalculo.Location = new System.Drawing.Point(163, 153);
            this.lblResultadoCalculo.Name = "lblResultadoCalculo";
            this.lblResultadoCalculo.Size = new System.Drawing.Size(200, 50);
            this.lblResultadoCalculo.TabIndex = 2;
            this.lblResultadoCalculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbEntrada
            // 
            this.txtbEntrada.Location = new System.Drawing.Point(229, 36);
            this.txtbEntrada.Name = "txtbEntrada";
            this.txtbEntrada.Size = new System.Drawing.Size(100, 22);
            this.txtbEntrada.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(149, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(289, 285);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmAntecessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtbEntrada);
            this.Controls.Add(this.lblResultadoCalculo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblDigiteValor);
            this.Name = "frmAntecessor";
            this.Text = "Calculo do Antecessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDigiteValor;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultadoCalculo;
        private System.Windows.Forms.TextBox txtbEntrada;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

