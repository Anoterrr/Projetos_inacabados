
namespace AplWFAcadastro
{
    partial class menus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.cliid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrsenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clicpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidtnascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.txtDtNascimento = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrar});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(82, 24);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // MenuCadastrar
            // 
            this.MenuCadastrar.Name = "MenuCadastrar";
            this.MenuCadastrar.Size = new System.Drawing.Size(155, 26);
            this.MenuCadastrar.Text = "Cadastrar";
            this.MenuCadastrar.Click += new System.EventHandler(this.MenuCadastrar_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSairSistema});
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(48, 24);
            this.MenuSair.Text = "Sair";
            // 
            // MenuSairSistema
            // 
            this.MenuSairSistema.Name = "MenuSairSistema";
            this.MenuSairSistema.Size = new System.Drawing.Size(173, 26);
            this.MenuSairSistema.Text = "Sair Sistema";
            this.MenuSairSistema.Click += new System.EventHandler(this.MenuSairSistema_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliid,
            this.usrnome,
            this.usrsenha,
            this.usrstatus,
            this.clinome,
            this.clicpf,
            this.clidtnascimento});
            this.dgvDados.Location = new System.Drawing.Point(12, 31);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowHeadersWidth = 51;
            this.dgvDados.RowTemplate.Height = 24;
            this.dgvDados.Size = new System.Drawing.Size(776, 213);
            this.dgvDados.TabIndex = 2;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellClick);
            // 
            // cliid
            // 
            this.cliid.HeaderText = "id";
            this.cliid.MinimumWidth = 6;
            this.cliid.Name = "cliid";
            this.cliid.Width = 125;
            // 
            // usrnome
            // 
            this.usrnome.HeaderText = "nome";
            this.usrnome.MinimumWidth = 6;
            this.usrnome.Name = "usrnome";
            this.usrnome.Width = 125;
            // 
            // usrsenha
            // 
            this.usrsenha.HeaderText = "senha";
            this.usrsenha.MinimumWidth = 6;
            this.usrsenha.Name = "usrsenha";
            this.usrsenha.Width = 125;
            // 
            // usrstatus
            // 
            this.usrstatus.HeaderText = "status";
            this.usrstatus.MinimumWidth = 6;
            this.usrstatus.Name = "usrstatus";
            this.usrstatus.Width = 125;
            // 
            // clinome
            // 
            this.clinome.HeaderText = "Cnome";
            this.clinome.MinimumWidth = 6;
            this.clinome.Name = "clinome";
            this.clinome.Width = 125;
            // 
            // clicpf
            // 
            this.clicpf.HeaderText = "cpf";
            this.clicpf.MinimumWidth = 6;
            this.clicpf.Name = "clicpf";
            this.clicpf.Width = 125;
            // 
            // clidtnascimento
            // 
            this.clidtnascimento.HeaderText = "dtNascimento";
            this.clidtnascimento.MinimumWidth = 6;
            this.clidtnascimento.Name = "clidtnascimento";
            this.clidtnascimento.Width = 125;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(550, 364);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(238, 74);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 74);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(369, 364);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(175, 74);
            this.btnAlter.TabIndex = 5;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // txtDtNascimento
            // 
            this.txtDtNascimento.Location = new System.Drawing.Point(538, 277);
            this.txtDtNascimento.Name = "txtDtNascimento";
            this.txtDtNascimento.Size = new System.Drawing.Size(168, 22);
            this.txtDtNascimento.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(376, 277);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(156, 22);
            this.txtCpf.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(118, 277);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(252, 22);
            this.txtNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "cpf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 277);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(550, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtDtNascimento);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menus";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.menus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrar;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem MenuSairSistema;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrsenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clicpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidtnascimento;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.TextBox txtDtNascimento;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
    }
}

