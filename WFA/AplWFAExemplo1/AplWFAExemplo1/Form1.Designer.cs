
namespace AplWFAExemplo1
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
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.imagemOnOff = new System.Windows.Forms.CheckBox();
            this.sair = new System.Windows.Forms.Button();
            this.gpBordas = new System.Windows.Forms.GroupBox();
            this.gpTypesImagens = new System.Windows.Forms.GroupBox();
            this.rdWithoutBordas = new System.Windows.Forms.RadioButton();
            this.rdFixaS = new System.Windows.Forms.RadioButton();
            this.rd3d = new System.Windows.Forms.RadioButton();
            this.rdImage2 = new System.Windows.Forms.RadioButton();
            this.rdImage1 = new System.Windows.Forms.RadioButton();
            this.rdWthoutImage = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.gpBordas.SuspendLayout();
            this.gpTypesImagens.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbFoto
            // 
            this.pcbFoto.InitialImage = global::AplWFAExemplo1.Properties.Resources.Forza_Horizon_4__4_;
            this.pcbFoto.Location = new System.Drawing.Point(12, 12);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(594, 320);
            this.pcbFoto.TabIndex = 0;
            this.pcbFoto.TabStop = false;
            // 
            // imagemOnOff
            // 
            this.imagemOnOff.AutoSize = true;
            this.imagemOnOff.Location = new System.Drawing.Point(424, 338);
            this.imagemOnOff.Name = "imagemOnOff";
            this.imagemOnOff.Size = new System.Drawing.Size(176, 21);
            this.imagemOnOff.TabIndex = 1;
            this.imagemOnOff.Text = "Imagem Visível/Invisível";
            this.imagemOnOff.UseVisualStyleBackColor = true;
            this.imagemOnOff.CheckedChanged += new System.EventHandler(this.imagemOnOff_CheckedChanged);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(424, 365);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(182, 73);
            this.sair.TabIndex = 2;
            this.sair.Text = "&Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // gpBordas
            // 
            this.gpBordas.Controls.Add(this.rd3d);
            this.gpBordas.Controls.Add(this.rdFixaS);
            this.gpBordas.Controls.Add(this.rdWithoutBordas);
            this.gpBordas.Location = new System.Drawing.Point(218, 338);
            this.gpBordas.Name = "gpBordas";
            this.gpBordas.Size = new System.Drawing.Size(200, 100);
            this.gpBordas.TabIndex = 3;
            this.gpBordas.TabStop = false;
            this.gpBordas.Text = "Bordas";
            // 
            // gpTypesImagens
            // 
            this.gpTypesImagens.Controls.Add(this.rdWthoutImage);
            this.gpTypesImagens.Controls.Add(this.rdImage2);
            this.gpTypesImagens.Controls.Add(this.rdImage1);
            this.gpTypesImagens.Location = new System.Drawing.Point(12, 338);
            this.gpTypesImagens.Name = "gpTypesImagens";
            this.gpTypesImagens.Size = new System.Drawing.Size(200, 100);
            this.gpTypesImagens.TabIndex = 0;
            this.gpTypesImagens.TabStop = false;
            this.gpTypesImagens.Text = "Tipos de Imagens";
            // 
            // rdWithoutBordas
            // 
            this.rdWithoutBordas.AutoSize = true;
            this.rdWithoutBordas.Location = new System.Drawing.Point(6, 21);
            this.rdWithoutBordas.Name = "rdWithoutBordas";
            this.rdWithoutBordas.Size = new System.Drawing.Size(106, 21);
            this.rdWithoutBordas.TabIndex = 0;
            this.rdWithoutBordas.TabStop = true;
            this.rdWithoutBordas.Text = "Sem Bordas";
            this.rdWithoutBordas.UseVisualStyleBackColor = true;
            this.rdWithoutBordas.CheckedChanged += new System.EventHandler(this.rdWithoutBordas_CheckedChanged);
            // 
            // rdFixaS
            // 
            this.rdFixaS.AutoSize = true;
            this.rdFixaS.Location = new System.Drawing.Point(6, 48);
            this.rdFixaS.Name = "rdFixaS";
            this.rdFixaS.Size = new System.Drawing.Size(107, 21);
            this.rdFixaS.TabIndex = 4;
            this.rdFixaS.TabStop = true;
            this.rdFixaS.Text = "Fixa Simples";
            this.rdFixaS.UseVisualStyleBackColor = true;
            this.rdFixaS.CheckedChanged += new System.EventHandler(this.rdFixaS_CheckedChanged);
            // 
            // rd3d
            // 
            this.rd3d.AutoSize = true;
            this.rd3d.Location = new System.Drawing.Point(6, 75);
            this.rd3d.Name = "rd3d";
            this.rd3d.Size = new System.Drawing.Size(47, 21);
            this.rd3d.TabIndex = 5;
            this.rd3d.TabStop = true;
            this.rd3d.Text = "3D";
            this.rd3d.UseVisualStyleBackColor = true;
            this.rd3d.CheckedChanged += new System.EventHandler(this.rd3d_CheckedChanged);
            // 
            // rdImage2
            // 
            this.rdImage2.AutoSize = true;
            this.rdImage2.Location = new System.Drawing.Point(6, 48);
            this.rdImage2.Name = "rdImage2";
            this.rdImage2.Size = new System.Drawing.Size(90, 21);
            this.rdImage2.TabIndex = 6;
            this.rdImage2.TabStop = true;
            this.rdImage2.Text = "Imagem 2";
            this.rdImage2.UseVisualStyleBackColor = true;
            this.rdImage2.CheckedChanged += new System.EventHandler(this.rdImage2_CheckedChanged);
            // 
            // rdImage1
            // 
            this.rdImage1.AutoSize = true;
            this.rdImage1.Location = new System.Drawing.Point(6, 21);
            this.rdImage1.Name = "rdImage1";
            this.rdImage1.Size = new System.Drawing.Size(90, 21);
            this.rdImage1.TabIndex = 7;
            this.rdImage1.TabStop = true;
            this.rdImage1.Text = "Imagem 1";
            this.rdImage1.UseVisualStyleBackColor = true;
            this.rdImage1.CheckedChanged += new System.EventHandler(this.rdImage1_CheckedChanged);
            // 
            // rdWthoutImage
            // 
            this.rdWthoutImage.AutoSize = true;
            this.rdWthoutImage.Location = new System.Drawing.Point(6, 75);
            this.rdWthoutImage.Name = "rdWthoutImage";
            this.rdWthoutImage.Size = new System.Drawing.Size(110, 21);
            this.rdWthoutImage.TabIndex = 8;
            this.rdWthoutImage.TabStop = true;
            this.rdWthoutImage.Text = "Sem imagem";
            this.rdWthoutImage.UseVisualStyleBackColor = true;
            this.rdWthoutImage.CheckedChanged += new System.EventHandler(this.rdWthoutImage_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.gpTypesImagens);
            this.Controls.Add(this.gpBordas);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.imagemOnOff);
            this.Controls.Add(this.pcbFoto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.gpBordas.ResumeLayout(false);
            this.gpBordas.PerformLayout();
            this.gpTypesImagens.ResumeLayout(false);
            this.gpTypesImagens.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbFoto;
        private System.Windows.Forms.CheckBox imagemOnOff;
        private System.Windows.Forms.Button sair;
        private System.Windows.Forms.GroupBox gpBordas;
        private System.Windows.Forms.RadioButton rd3d;
        private System.Windows.Forms.RadioButton rdFixaS;
        private System.Windows.Forms.RadioButton rdWithoutBordas;
        private System.Windows.Forms.GroupBox gpTypesImagens;
        private System.Windows.Forms.RadioButton rdWthoutImage;
        private System.Windows.Forms.RadioButton rdImage2;
        private System.Windows.Forms.RadioButton rdImage1;
    }
}

