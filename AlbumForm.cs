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
        private List<int> RefCodesArtistas = new List<int>();
        private List<int> RefCodesMusicas = new List<int>();

        public AlbumForm() {
            InitializeComponent();
            Index = -1;
        }

        public AlbumForm(int index) {
            InitializeComponent();
            Codigo.Enabled = false;
            Text = "Editar Álbum";
            Index = index;
        }

        private void AlbumForm_Load(object sender, EventArgs e) {
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
                ArtistasParticipantes.Items.Add(General.Artistas[i].NomeArtistico);
                RefCodesArtistas.Add(General.Artistas[i].Codigo);
            }

            for (int i = 0; i < General.CancoesSize; i++) {
                ListaMusicas.Items.Add(General.Cancoes[i].Titulo);
                RefCodesMusicas.Add(General.Cancoes[i].Codigo);
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

            if (!int.TryParse(Codigo.Text, out int codigo) && Codigo.Text != "")
                erro += "- O código precisa ser um número\n";

            if (codigo <= 0 && Codigo.Text != "")
                erro += "- O código precisa ser maior que zero\n";

            if (Titulo.Text == "" || DataLancamento.Text == "" || NCopiasVendidas.Text == "" || ListaMusicas.CheckedItems.Count == 0 || ArtistasParticipantes.CheckedItems.Count == 0)
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (!DateTime.TryParse(DataLancamento.Text, out DateTime dataLancamento))
                erro += "- Data de Lançamento inválida\n";

            if (!long.TryParse(NCopiasVendidas.Text, out long nCopiasVendidas))
                erro += "- Número de cópias inválido\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Codigo.Text == "") {
                if (General.AlbumsSize == 0)
                    codigo = 1;
                else
                    codigo = General.Albums[General.AlbumsSize - 1].Codigo + 1;
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

    }
}
