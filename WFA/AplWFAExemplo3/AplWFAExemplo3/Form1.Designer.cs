
namespace AplWFAExemplo3
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.lblTextSelcted = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(549, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(549, 299);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(98, 23);
            this.btnFresh.TabIndex = 1;
            this.btnFresh.Text = "Eliminar";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Limpar todos \r\nos itens\r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(549, 386);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(98, 23);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(549, 415);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(98, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(169, 12);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(374, 22);
            this.txtText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Posição na lista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto selecionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total de itens:";
            // 
            // lblPosicao
            // 
            this.lblPosicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosicao.Location = new System.Drawing.Point(196, 363);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(347, 17);
            this.lblPosicao.TabIndex = 9;
            this.lblPosicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextSelcted
            // 
            this.lblTextSelcted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTextSelcted.Location = new System.Drawing.Point(196, 392);
            this.lblTextSelcted.Name = "lblTextSelcted";
            this.lblTextSelcted.Size = new System.Drawing.Size(347, 17);
            this.lblTextSelcted.TabIndex = 10;
            this.lblTextSelcted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(196, 424);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(347, 17);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 15);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(110, 17);
            this.lblText.TabIndex = 12;
            this.lblText.Text = "Digite um Texto:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 292);
            this.listBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTextSelcted);
            this.Controls.Add(this.lblPosicao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Label lblTextSelcted;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.ListBox listBox1;
    }
}

