using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class CancaoForm : Form {
        private int Index { get; set; }
        private readonly List<int> RefCodes = new List<int>();

        public CancaoForm() {
            InitializeComponent();
            Remover.Visible = false;
            Salvar.Location = new Point(371, 415);

            Index = -1;
        }

        public CancaoForm(int index) {
            InitializeComponent();
            Codigo.Enabled = false;
            Text = "Editar Música";

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

            for (int i = 0; i < General.ArtistasSize; i++) {
                General.Artista artistaTemp = General.Artistas[i];
                RefCodes.Add(artistaTemp.Codigo);
                Compositor.Items.Add("(" + artistaTemp.Codigo + ") " + artistaTemp.NomeArtistico);
                Artista.Items.Add("(" + artistaTemp.Codigo + ") " + artistaTemp.NomeArtistico);
            }

            if (Index != -1) {
                General.Cancao cancaoTemp = General.Cancoes[Index];
                Codigo.Text = cancaoTemp.Codigo.ToString();
                Titulo.Text = cancaoTemp.Titulo;
                Letra.Text = cancaoTemp.Letra;
                Melodia.Text = cancaoTemp.Melodia;
                Compositor.SelectedIndex = BinarySearch.BinarySearchDisplay(RefCodes, cancaoTemp.CodigoCompositor);
                Artista.SelectedIndex = BinarySearch.BinarySearchDisplay(RefCodes, cancaoTemp.CodigoArtistaPrimeiraGravacao);
            }
        }

        private void Salvar_Click(object sender, EventArgs e) {
            string erro = "";

            int codigo = 0;
            if (Codigo.Text != "" && (!int.TryParse(Codigo.Text, out codigo) || codigo <= 0))
                erro += "- O código precisa ser um número maior que zero\n";

            if (Titulo.Text == "" || Letra.Text == "" || Melodia.Text == "" || Compositor.SelectedIndex == -1 || Artista.SelectedIndex == -1)
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (Index == -1 && BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Cancoes, a => a.Codigo).Where(a => a > 0).ToArray(), codigo) != -1)
                erro += "- Este código já está sendo utilizado\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Codigo.Text == "") {
                codigo = General.CancoesSize != 0 ? General.Cancoes[General.CancoesSize - 1].Codigo + 1 : 1;
            }

            if (Index == -1) {
                General.Cancoes[General.CancoesSize++] = new General.Cancao() {
                    Codigo = codigo,
                    Titulo = Titulo.Text,
                    Letra = Letra.Text,
                    Melodia = Melodia.Text,
                    CodigoCompositor = RefCodes[Compositor.SelectedIndex],
                    CodigoArtistaPrimeiraGravacao = RefCodes[Artista.SelectedIndex]
                };

                // A função Array.ConvertAll pega o vetor da struct Album e retorna um vetor de inteiros com os códigos de cada uma
                // A função Where remove todos os índices de código 0 pois nestes casos o vetor não está preenchido e não deve ser ordenado
                MergeSort.Sort(General.Cancoes, Array.ConvertAll(General.Cancoes, a => a.Codigo).Where(a => a > 0).ToArray());
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

        private void Remover_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Tem certeza que deseja remover esta música? Todos os álbuns que contém esta música também serão excluídos.", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                General.Album.RemoverMusica(General.Cancoes[Index].Codigo);
                General.Cancao.RemoveAt(Index);

                Program.globalForm.UpdateRows(Main.DataGrid.Albuns);
                Program.globalForm.UpdateRows(Main.DataGrid.Musicas);

                Close();
            }
        }
    }

}
