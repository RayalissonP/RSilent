namespace RSilent
{
    partial class Form1
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
            checkedListBox1 = new CheckedListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            btnEditar = new Button();
            btnExecutar = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            btnLimpar = new Button();
            btnSelecionarTudo = new Button();
            progressBar1 = new ProgressBar();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 42);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(400, 310);
            checkedListBox1.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(430, 42);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 30);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(430, 137);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(120, 30);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.Click += btnRemover_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(430, 90);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 30);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(430, 217);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(120, 30);
            btnExecutar.TabIndex = 4;
            btnExecutar.Text = "Executar";
            btnExecutar.Click += btnExecutar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(570, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(61, 20);
            toolStripMenuItem1.Text = "Arquivo";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(93, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += fecharApp_click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sobreToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(104, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(292, 387);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 33);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar Seleção";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSelecionarTudo
            // 
            btnSelecionarTudo.Location = new Point(173, 387);
            btnSelecionarTudo.Name = "btnSelecionarTudo";
            btnSelecionarTudo.Size = new Size(113, 33);
            btnSelecionarTudo.TabIndex = 7;
            btnSelecionarTudo.Text = "Selecionar Tudo";
            btnSelecionarTudo.UseVisualStyleBackColor = true;
            btnSelecionarTudo.Click += btnSelecionarTudo_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 358);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(400, 23);
            progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            ClientSize = new Size(570, 441);
            Controls.Add(progressBar1);
            Controls.Add(btnSelecionarTudo);
            Controls.Add(btnLimpar);
            Controls.Add(checkedListBox1);
            Controls.Add(btnAdicionar);
            Controls.Add(btnRemover);
            Controls.Add(btnEditar);
            Controls.Add(btnExecutar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "RSilent";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExecutar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private Button btnLimpar;
        private Button btnSelecionarTudo;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ProgressBar progressBar1;
    }
}