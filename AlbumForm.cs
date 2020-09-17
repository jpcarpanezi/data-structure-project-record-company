using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class AlbumForm : Form {
        private int Index { get; set; }
        private readonly List<int> RefCodesArtistas = new List<int>();
        private readonly List<int> RefCodesMusicas = new List<int>();

        public AlbumForm() {
            InitializeComponent();
            Remover.Visible = false;
            Salvar.Location = new Point(371, 415);

            Index = -1;
        }

        public AlbumForm(int index) {
            InitializeComponent();
            Codigo.Enabled = false;
            Text = "Editar Álbum";
            Index = index;
        }

        private void AlbumForm_Load(object sender, EventArgs e) {
            toolTip1.SetToolTip(label7, "Digite o código da música e pressione Enter para selecionar a música");
            toolTip1.SetToolTip(label8, "Digite o código do artista e pressione Enter para selecionar o artista");

            if (General.AlbumsSize >= General.MaxSize) {
                MessageBox.Show("O limite de espaço para canções foi atingido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (General.ArtistasSize == 0) {
                MessageBox.Show("É necessário cadastrar ao menos um artista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (General.CancoesSize == 0) {
                MessageBox.Show("É necessário cadastrar ao menos uma música.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            for (int i = 0; i < General.ArtistasSize; i++) {
                General.Artista artistaTemp = General.Artistas[i];
                ArtistasParticipantes.Items.Add("(" + artistaTemp.Codigo + ") " + artistaTemp.NomeArtistico);
                RefCodesArtistas.Add(artistaTemp.Codigo);
            }

            for (int i = 0; i < General.CancoesSize; i++) {
                General.Cancao cancaoTemp = General.Cancoes[i];
                ListaMusicas.Items.Add("(" + cancaoTemp.Codigo + ") " + cancaoTemp.Titulo);
                RefCodesMusicas.Add(cancaoTemp.Codigo);
            }

            if (Index != -1) {
                General.Album albumTemp = General.Albums[Index];
                Codigo.Text = albumTemp.Codigo.ToString();
                Titulo.Text = albumTemp.Titulo;
                DataLancamento.Text = albumTemp.DataLancamento.ToString("d");
                NCopiasVendidas.Text = albumTemp.NumeroCopiasVendidas.ToString();
                for (int i = 0; i < albumTemp.CodigosMusicas.Length; i++) {
                    ListaMusicas.SetItemChecked(BinarySearch.BinarySearchDisplay(RefCodesMusicas, albumTemp.CodigosMusicas[i]), true);
                }
                for (int i = 0; i < albumTemp.ArtistasParticipantes.Length; i++) {
                    ArtistasParticipantes.SetItemChecked(BinarySearch.BinarySearchDisplay(RefCodesArtistas, albumTemp.ArtistasParticipantes[i]), true);
                }
            }
        }

        private void Salvar_Click(object sender, EventArgs e) {
            string erro = "";

            int codigo = 0;
            if (Codigo.Text != "" && (!int.TryParse(Codigo.Text, out codigo) || codigo <= 0))
                erro += "- O código precisa ser um número maior que zero\n";

            if (Titulo.Text == "" || DataLancamento.Text == "" || NCopiasVendidas.Text == "" || ListaMusicas.CheckedItems.Count == 0 || ArtistasParticipantes.CheckedItems.Count == 0)
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (Index == -1 && BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Albums, a => a.Codigo).Where(a => a > 0).ToArray(), codigo) != -1)
                erro += "- Este código já está sendo utilizado\n";

            if (!DateTime.TryParse(DataLancamento.Text, out DateTime dataLancamento))
                erro += "- Data de Lançamento inválida\n";

            if (!long.TryParse(NCopiasVendidas.Text, out long nCopiasVendidas))
                erro += "- Número de cópias inválido\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Codigo.Text == "") {
                codigo = General.AlbumsSize != 0 ? General.Albums[General.AlbumsSize - 1].Codigo + 1 : 1;
            }

            int[] indicesMusicas = ListaMusicas.CheckedIndices.Cast<int>().ToArray();
            List<int> codigosMusicas = new List<int>();
            for (int i = 0; i < indicesMusicas.Length; i++) {
                codigosMusicas.Add(RefCodesMusicas[indicesMusicas[i]]);
            }

            int[] indicesArtistas = ArtistasParticipantes.CheckedIndices.Cast<int>().ToArray();
            List<int> codigosArtistas = new List<int>();
            for (int i = 0; i < indicesArtistas.Length; i++) {
                codigosArtistas.Add(RefCodesArtistas[indicesArtistas[i]]);
            }

            if (Index == -1) {
                General.Albums[General.AlbumsSize++] = new General.Album() {
                    Codigo = codigo,
                    Titulo = Titulo.Text,
                    DataLancamento = dataLancamento,
                    NumeroCopiasVendidas = nCopiasVendidas,
                    CodigosMusicas = codigosMusicas.ToArray(),
                    ArtistasParticipantes = codigosArtistas.ToArray()
                };

                // A função Array.ConvertAll pega o vetor da struct Album e retorna um vetor de inteiros com os códigos de cada uma
                // A função Where remove todos os índices de código 0 pois nestes casos o vetor não está preenchido e não deve ser ordenado
                MergeSort.Sort(General.Albums, Array.ConvertAll(General.Albums, a => a.Codigo).Where(a => a > 0).ToArray());
            }
            else {
                General.Albums[Index] = new General.Album() {
                    Codigo = General.Albums[Index].Codigo,
                    Titulo = Titulo.Text,
                    DataLancamento = dataLancamento,
                    NumeroCopiasVendidas = nCopiasVendidas,
                    CodigosMusicas = codigosMusicas.ToArray(),
                    ArtistasParticipantes = codigosArtistas.ToArray()
                };
            }

            Program.globalForm.UpdateRows(Main.DataGrid.Albuns);
            Close();
        }

        private void PesquisaMusicas_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (!int.TryParse(PesquisaMusicas.Text, out int codigo) || codigo <= 0) {
                    MessageBox.Show("O código precisa ser um número maior que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultado = BinarySearch.BinarySearchDisplay(RefCodesMusicas, codigo);

                if (resultado != -1) {
                    ListaMusicas.SetItemChecked(resultado, true);
                    PesquisaMusicas.Text = "";
                    MessageBox.Show("A música \"" + General.Cancoes[resultado].Titulo + "\" foi selecionada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Nenhum resultado encontrado para este código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void PesquisarArtistas_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                if (!int.TryParse(PesquisarArtistas.Text, out int codigo) || codigo <= 0) {
                    MessageBox.Show("O código precisa ser um número maior que 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultado = BinarySearch.BinarySearchDisplay(RefCodesArtistas, codigo);

                if (resultado != -1) {
                    ArtistasParticipantes.SetItemChecked(resultado, true);
                    PesquisarArtistas.Text = "";
                    MessageBox.Show("O artista \"" + General.Artistas[resultado].NomeArtistico + "\" foi selecionado.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Nenhum resultado encontrado para este código", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Remover_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Tem certeza que deseja remover este álbum?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                General.Album.RemoveAt(Index);
                Program.globalForm.UpdateRows(Main.DataGrid.Albuns);

                Close();
            }
        }
    }
}
