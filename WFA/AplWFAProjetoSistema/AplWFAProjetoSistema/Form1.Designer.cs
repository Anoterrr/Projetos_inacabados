
namespace AplWFAProjetoSistema
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
            this.components = new System.ComponentModel.Container();
            this.trmTempo = new System.Windows.Forms.Timer(this.components);
            this.pgrbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // trmTempo
            // 
            this.trmTempo.Enabled = true;
            this.trmTempo.Interval = 350;
            this.trmTempo.Tick += new System.EventHandler(this.trmTempo_Tick);
            // 
            // pgrbProgress
            // 
            this.pgrbProgress.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pgrbProgress.Location = new System.Drawing.Point(12, 415);
            this.pgrbProgress.Name = "pgrbProgress";
            this.pgrbProgress.Size = new System.Drawing.Size(776, 23);
            this.pgrbProgress.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgrbProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer trmTempo;
        private System.Windows.Forms.ProgressBar pgrbProgress;
    }
}

