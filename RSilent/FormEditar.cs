using System;
using System.Windows.Forms;

namespace RSilent
{
    public partial class FormEditar : Form
    {
        private AppItem app;

        public FormEditar(AppItem app)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.app = app;
            txtNome.Text = app.Nome;
            txtVersao.Text = app.Versao;
            txtCaminho.Text = app.Caminho;
            txtChave.Text = app.ChaveSilenciosa;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            app.Nome = txtNome.Text;
            app.Versao = txtVersao.Text;
            app.Caminho = txtCaminho.Text;
            app.ChaveSilenciosa = txtChave.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}