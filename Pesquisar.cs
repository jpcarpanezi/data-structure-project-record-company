using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class Pesquisar : Form {
        public Pesquisar() {
            InitializeComponent();
        }

        private int binarySearchResult;

        private void BotaoPesquisar_Click(object sender, EventArgs e) {
            string erro = "";

            if (!int.TryParse(Codigo.Text, out int codigo) || codigo <= 0)
                erro += "- O código precisa ser um número maior que 0\n";

            if (TipoBusca.SelectedIndex == -1)
                erro += "- Você precisa selecionar o tipo de busca\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Garante que as funções só sejam chamadas uma vez
            Editar.Click -= EditarArtista;
            Editar.Click -= EditarAlbum;
            Editar.Click -= EditarCancao;

            switch (TipoBusca.SelectedIndex) {
                case 0:
                    // Procurar pelo artista
                    BuscarPorArtista(codigo);
                    break;

                case 1:
                    // Procurar pelo album
                    BuscarPorAlbum(codigo);
                    break;

                case 2:
                    // Procurar pela canção
                    BuscarPorCancao(codigo);
                    break;
            }
        }

        private void BuscarPorArtista(int codigo) {
            binarySearchResult = BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Artistas, a => a.Codigo).Where(a => a > 0).ToArray(), codigo);

            if (binarySearchResult != -1) {
                Editar.Click += EditarArtista;
                LabelNome.Text = "Nome do Artista: " + General.Artistas[binarySearchResult].NomeArtistico + " (" + General.Artistas[binarySearchResult].NomeVerdadeiro + ")";
                LabelGridView1.Text = "Músicas";
                LabelGridView2.Text = "Álbuns";

                LabelNome.Visible = true;
                Editar.Visible = true;
                LabelGridView1.Visible = true;
                LabelGridView2.Visible = true;
                DataGridView1.Visible = true;
                DataGridView2.Visible = true;

                DataGridView1.Columns.Clear();
                DataGridView1.Columns.Add("Codigo", "Código");
                DataGridView1.Columns.Add("Titulo", "Título");
                DataGridView1.Rows.Clear();
                for (int i = 0; i < General.CancoesSize; i++) {
                    if (General.Cancoes[i].CodigoCompositor == codigo && General.Cancoes[i].CodigoArtistaPrimeiraGravacao == codigo) {
                        General.Cancao cancaoTemp = General.Cancoes[i];
                        DataGridView1.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo);
                    }
                }

                DataGridView2.Columns.Clear();
                DataGridView2.Columns.Add("Codigo", "Código");
                DataGridView2.Columns.Add("Titulo", "Título");
                DataGridView2.Columns.Add("DataLancamento", "Data de Lançamento");
                DataGridView2.Columns.Add("CopiasVendidas", "Número de Cópias Vendidas");

                DataGridView2.Rows.Clear();
                for (int i = 0; i < General.AlbumsSize; i++) {
                    for (int j = 0; j < General.Albums[i].ArtistasParticipantes.Length; j++) {
                        if (General.Albums[i].ArtistasParticipantes[j] == codigo) {
                            General.Album albumTemp = General.Albums[i];
                            DataGridView2.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString());
                        }
                    }
                }

                RemoverSort();
            }
            else {
                MessageBox.Show("Nenhum artista encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BuscarPorAlbum(int codigo) {
            binarySearchResult = BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Albums, a => a.Codigo).Where(a => a > 0).ToArray(), codigo);

            if (binarySearchResult != -1) {
                Editar.Click += EditarAlbum;
                LabelNome.Text = "Título do Album: " + General.Albums[binarySearchResult].Titulo;
                LabelGridView1.Text = "Músicas";
                LabelGridView2.Text = "Artistas";

                LabelNome.Visible = true;
                Editar.Visible = true;
                LabelGridView1.Visible = true;
                LabelGridView2.Visible = true;
                DataGridView1.Visible = true;
                DataGridView2.Visible = true;

                DataGridView1.Columns.Clear();
                DataGridView1.Columns.Add("Codigo", "Código");
                DataGridView1.Columns.Add("Titulo", "Título");
                DataGridView1.Rows.Clear();
                for (int i = 0; i < General.Albums[binarySearchResult].CodigosMusicas.Length; i++) {
                    General.Cancao cancaoTemp = General.Cancoes[General.Albums[binarySearchResult].CodigosMusicas[i] - 1];
                    DataGridView1.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo);
                }

                DataGridView2.Columns.Clear();
                DataGridView2.Columns.Add("Codigo", "Código");
                DataGridView2.Columns.Add("NomeVerdadeiro", "Nome Verdadeiro");
                DataGridView2.Columns.Add("NomeArtistico", "Nome Artístico");
                DataGridView2.Columns.Add("DataAniversario", "Data de Aniversário");
                DataGridView2.Columns.Add("BandaSN", "Faz parte de uma banda?");
                DataGridView2.Rows.Clear();
                for (int i = 0; i < General.Albums[binarySearchResult].ArtistasParticipantes.Length; i++) {
                    General.Artista artistaTemp = General.Artistas[General.Albums[binarySearchResult].ArtistasParticipantes[i] - 1];
                    DataGridView2.Rows.Add(artistaTemp.Codigo, artistaTemp.NomeVerdadeiro, artistaTemp.NomeArtistico, artistaTemp.Aniversario.ToString("d"), artistaTemp.BandaBool ? "Sim" : "Não", "Editar", "Remover");
                }

                RemoverSort();
            }
            else {
                MessageBox.Show("Nenhum álbum encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BuscarPorCancao(int codigo) {
            binarySearchResult = BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Cancoes, a => a.Codigo).Where(a => a > 0).ToArray(), codigo);

            if (binarySearchResult != -1) {
                Editar.Click += EditarCancao;
                LabelNome.Text = "Título da Canção: " + General.Cancoes[binarySearchResult].Titulo;
                LabelGridView1.Text = "Artistas";
                LabelGridView2.Text = "Álbuns";

                LabelNome.Visible = true;
                Editar.Visible = true;
                LabelGridView1.Visible = true;
                LabelGridView2.Visible = true;
                DataGridView1.Visible = true;
                DataGridView2.Visible = true;

                DataGridView1.Columns.Clear();
                DataGridView1.Columns.Add("Codigo", "Código");
                DataGridView1.Columns.Add("NomeVerdadeiro", "Nome Verdadeiro");
                DataGridView1.Columns.Add("NomeArtistico", "Nome Artístico");
                DataGridView1.Columns.Add("DataAniversario", "Data de Aniversário");
                DataGridView1.Columns.Add("BandaSN", "Faz parte de uma banda?");
                DataGridView1.Columns.Add("Tipo", "Tipo");
                DataGridView1.Rows.Clear();

                General.Artista artistaTemp1 = General.Artistas[General.Cancoes[binarySearchResult].CodigoCompositor - 1];
                DataGridView1.Rows.Add(artistaTemp1.Codigo, artistaTemp1.NomeVerdadeiro, artistaTemp1.NomeArtistico, artistaTemp1.Aniversario.ToString("d"), artistaTemp1.BandaBool ? "Sim" : "Não", "Compositor");

                General.Artista artistaTemp2 = General.Artistas[General.Cancoes[binarySearchResult].CodigoArtistaPrimeiraGravacao - 1];
                DataGridView1.Rows.Add(artistaTemp2.Codigo, artistaTemp2.NomeVerdadeiro, artistaTemp2.NomeArtistico, artistaTemp2.Aniversario.ToString("d"), artistaTemp2.BandaBool ? "Sim" : "Não", "Musicista");

                DataGridView2.Columns.Clear();
                DataGridView2.Columns.Add("Codigo", "Código");
                DataGridView2.Columns.Add("Titulo", "Título");
                DataGridView2.Columns.Add("DataLancamento", "Data de Lançamento");
                DataGridView2.Columns.Add("CopiasVendidas", "Número de Cópias Vendidas");
                DataGridView2.Rows.Clear();
                for (int i = 0; i < General.AlbumsSize; i++) {
                    for (int j = 0; j < General.Albums[i].CodigosMusicas.Length; j++) {
                        if (General.Albums[i].CodigosMusicas[j] == codigo) {
                            General.Album albumTemp = General.Albums[i];
                            DataGridView2.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString());
                        }
                    }
                }

                RemoverSort();
            }
            else {
                MessageBox.Show("Nenhuma canção encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void EditarArtista(object Sender, EventArgs e) {
            new ArtistaForm(binarySearchResult).ShowDialog();
        }

        public void EditarAlbum(object Sender, EventArgs e) {
            new AlbumForm(binarySearchResult).ShowDialog();
        }

        public void EditarCancao(object Sender, EventArgs e) {
            new CancaoForm(binarySearchResult).ShowDialog();
        }

        public void RemoverSort() {
            foreach (DataGridViewColumn column in DataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn column in DataGridView2.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
