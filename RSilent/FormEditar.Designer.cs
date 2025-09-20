namespace RSilent
{
    partial class FormEditar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNome = new System.Windows.Forms.TextBox();
            txtVersao = new System.Windows.Forms.TextBox();
            txtCaminho = new System.Windows.Forms.TextBox();
            txtChave = new System.Windows.Forms.TextBox();
            btnSalvar = new System.Windows.Forms.Button();
            Nome = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new System.Drawing.Point(20, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new System.Drawing.Size(300, 23);
            txtNome.TabIndex = 0;
            // 
            // txtVersao
            // 
            txtVersao.Location = new System.Drawing.Point(20, 105);
            txtVersao.Name = "txtVersao";
            txtVersao.Size = new System.Drawing.Size(300, 23);
            txtVersao.TabIndex = 1;
            // 
            // txtCaminho
            // 
            txtCaminho.Location = new System.Drawing.Point(20, 168);
            txtCaminho.Name = "txtCaminho";
            txtCaminho.Size = new System.Drawing.Size(300, 23);
            txtCaminho.TabIndex = 2;
            // 
            // txtChave
            // 
            txtChave.Location = new System.Drawing.Point(20, 228);
            txtChave.Name = "txtChave";
            txtChave.Size = new System.Drawing.Size(300, 23);
            txtChave.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new System.Drawing.Point(20, 267);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new System.Drawing.Size(100, 30);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Nome.Location = new System.Drawing.Point(20, 22);
            Nome.Name = "Nome";
            Nome.Size = new System.Drawing.Size(41, 15);
            Nome.TabIndex = 5;
            Nome.Text = "Nome";
            Nome.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(20, 87);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Versão";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(21, 150);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 15);
            label2.TabIndex = 7;
            label2.Text = "Caminho do arquivo";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(21, 210);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(98, 15);
            label3.TabIndex = 8;
            label3.Text = "Chave Silenciosa";
            // 
            // FormEditar
            // 
            ClientSize = new System.Drawing.Size(350, 318);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nome);
            Controls.Add(txtNome);
            Controls.Add(txtVersao);
            Controls.Add(txtCaminho);
            Controls.Add(txtChave);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            Name = "FormEditar";
            Text = "Editar Aplicativo";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtVersao;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}