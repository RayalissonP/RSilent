using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace RSilent
{
    public partial class Form1 : Form
    {
        private List<AppItem> apps = new List<AppItem>();
        private string saveFile = "apps.json";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CarregarApps();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Instaladores e Scripts (*.exe;*.msi;*.bat;*.cmd)|*.exe;*.msi;*.bat;*.cmd";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var app = new AppItem
                    {
                        Nome = Path.GetFileNameWithoutExtension(ofd.FileName),
                        Caminho = ofd.FileName
                    };
                    apps.Add(app);
                    AtualizarLista();
                    SalvarApps();
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex >= 0)
            {
                apps.RemoveAt(checkedListBox1.SelectedIndex);
                AtualizarLista();
                SalvarApps();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem is AppItem app)
            {
                using (var frm = new FormEditar(app))
                {
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        AtualizarLista();
                        SalvarApps();
                    }
                }
            }
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            var selecionados = new List<AppItem>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                if (item is AppItem app)
                    selecionados.Add(app);
            }

            if (selecionados.Count == 0)
            {
                MessageBox.Show("Nenhum aplicativo selecionado.");
                return;
            }

            // Configura a barra de progresso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = selecionados.Count;
            progressBar1.Value = 0;

            foreach (var app in selecionados)
            {
                labelStatus.Text = $"Executando {progressBar1.Value + 1} de {progressBar1.Maximum}: {app.Nome}";
                await Task.Yield();

                var psi = new ProcessStartInfo
                {
                    FileName = app.Caminho,
                    Arguments = app.ChaveSilenciosa,
                    UseShellExecute = false
                };

                using (var proc = Process.Start(psi))
                {
                    await proc.WaitForExitAsync();
                }

                // Atualiza a barra após concluir cada app
                progressBar1.Value++;
            }

            labelStatus.Text = "Todos os aplicativos foram executados!";
            MessageBox.Show("Execução concluída!");
        }


        private void AtualizarLista()
        {
            checkedListBox1.Items.Clear();
            foreach (var app in apps)
            {
                checkedListBox1.Items.Add(app);
            }
        }

        private void SalvarApps()
        {
            try
            {
                var json = JsonSerializer.Serialize(apps, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(saveFile, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar apps: {ex.Message}");
            }
        }

        private void CarregarApps()
        {
            try
            {
                if (File.Exists(saveFile))
                {
                    var json = File.ReadAllText(saveFile);
                    apps = JsonSerializer.Deserialize<List<AppItem>>(json) ?? new List<AppItem>();
                    AtualizarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar apps: {ex.Message}");
                apps = new List<AppItem>();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

        }

        private void btnSelecionarTudo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void fecharApp_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}