using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class CancaoForm : Form {
        private int Index { get; set; }
        private List<int> RefCodes = new List<int>();

        public CancaoForm() {
            InitializeComponent();

            Index = -1;
        }

        public CancaoForm(int index) {
            InitializeComponent();
            Codigo.Enabled = false;

            Index = index;
        }

        private void CancaoForm_Load(object sender, EventArgs e) {

            if (General.CancoesSize >= General.MaxSize) {
                MessageBox.Show("O limite de espaço para canções foi atingido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (General.ArtistasSize == 0) {
                MessageBox.Show("É necessário cadastrar ao menos um artista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            // Adicionar items na lista aqui
            //RefCodes.Add(1);
            //Compositor.Items.Add("Minha joaninha");
            //Artista.Items.Add("Minha joaninha");

            for (int i = 0; i < General.ArtistasSize; i++) {
                RefCodes.Add(General.Artistas[i].Codigo);
                Compositor.Items.Add(General.Artistas[i].NomeArtistico);
                Artista.Items.Add(General.Artistas[i].NomeArtistico);
            }

            if (Index != -1) {
                General.Cancao cancaoTemp = General.Cancoes[Index];
                Codigo.Text = cancaoTemp.Codigo.ToString();
                Titulo.Text = cancaoTemp.Titulo;
                Letra.Text = cancaoTemp.Letra;
                Melodia.Text = cancaoTemp.Melodia;
                Compositor.SelectedIndex = cancaoTemp.CodigoCompositor;
                Artista.SelectedIndex = cancaoTemp.CodigoArtistaPrimeiraGravacao;
            }
        }

        private void Salvar_Click(object sender, EventArgs e) {
            string erro = "";

            if (!int.TryParse(Codigo.Text, out int codigo) && Codigo.Text != "")
                erro += "- O código precisa ser um número\n";

            if (Titulo.Text == "" || Letra.Text == "" || Melodia.Text == "" || Compositor.SelectedIndex == -1 || Artista.SelectedIndex == -1)
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Gerar codigo
            // TODO: Verificar se o codigo nao esta usado

            if (Index == -1) {
                General.Cancoes[General.CancoesSize++] = new General.Cancao() {
                    Codigo = codigo,
                    Titulo = Titulo.Text,
                    Letra = Letra.Text,
                    Melodia = Melodia.Text,
                    CodigoCompositor = RefCodes[Compositor.SelectedIndex],
                    CodigoArtistaPrimeiraGravacao = RefCodes[Artista.SelectedIndex]
                };
                // Sort
            }
            else {
                General.Cancoes[Index] = new General.Cancao() {
                    Codigo = General.Cancoes[Index].Codigo, // Codigo nao pode ser alterado
                    Titulo = Titulo.Text,
                    Letra = Letra.Text,
                    Melodia = Melodia.Text,
                    CodigoCompositor = RefCodes[Compositor.SelectedIndex],
                    CodigoArtistaPrimeiraGravacao = RefCodes[Artista.SelectedIndex]
                };
            }

            Program.globalForm.UpdateRows(Main.DataGrid.Musicas);
            Close();
        }
    }

}
