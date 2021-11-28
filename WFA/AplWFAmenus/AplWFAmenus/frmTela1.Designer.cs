
namespace AplWFAmenus
{
    partial class frmTela1
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
            this.ComeBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComeBack
            // 
            this.ComeBack.Location = new System.Drawing.Point(558, 330);
            this.ComeBack.Name = "ComeBack";
            this.ComeBack.Size = new System.Drawing.Size(230, 108);
            this.ComeBack.TabIndex = 0;
            this.ComeBack.Text = "ComeBack";
            this.ComeBack.UseVisualStyleBackColor = true;
            this.ComeBack.Click += new System.EventHandler(this.ComeBack_Click);
            // 
            // frmTela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComeBack);
            this.Name = "frmTela1";
            this.Text = "frmTela1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComeBack;
    }
}