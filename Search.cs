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

        private void searchButton_Click(object sender, EventArgs e) {
            string erro = "";

            if (!int.TryParse(codeField.Text, out int codigo))
                erro += "- O código precisa ser um número\n";

            if (codigo <= 0)
                erro += "- O código precisa ser maior que 0\n";

            if (tipoBusca.SelectedIndex == -1) {
                erro += "- Você precisa selecionar o tipo de busca\n";
            }

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Garante que as funções só sejam chamadas uma vez
            editButton.Click -= editArtista;
            editButton.Click -= editAlbum;
            editButton.Click -= editCancao;

            switch (tipoBusca.SelectedIndex) {
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
                editButton.Click += editArtista;
                searchDefine.Text = "Nome do Artista: " + General.Artistas[binarySearchResult].NomeArtistico + " (" + General.Artistas[binarySearchResult].NomeVerdadeiro + ")";
                dataGridLabel1.Text = "Músicas";
                dataGridLabel2.Text = "Álbuns";

                searchDefine.Visible = true;
                editButton.Visible = true;
                dataGridLabel1.Visible = true;
                dataGridLabel2.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Código";
                dataGridView1.Columns[1].Name = "Título";
                dataGridView1.Rows.Clear();
                for (int i = 0; i < General.CancoesSize; i++) {
                    if (General.Cancoes[i].CodigoCompositor == codigo && General.Cancoes[i].CodigoArtistaPrimeiraGravacao == codigo) {
                        General.Cancao cancaoTemp = General.Cancoes[i];
                        dataGridView1.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo);
                    }
                }

                dataGridView2.ColumnCount = 4;
                dataGridView2.Columns[0].Name = "Código";
                dataGridView2.Columns[1].Name = "Título";
                dataGridView2.Columns[2].Name = "Data de Lançamento";
                dataGridView2.Columns[3].Name = "Número de Cópias Vendidas";
                dataGridView2.Rows.Clear();
                for (int i = 0; i < General.AlbumsSize; i++) {
                    for (int j = 0; j < General.Albums[i].ArtistasParticipantes.Length; j++) {
                        if (General.Albums[i].ArtistasParticipantes[j] == codigo) {
                            General.Album albumTemp = General.Albums[i];
                            dataGridView2.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString());
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Nenhum artista encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorAlbum(int codigo) {
            binarySearchResult = BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Albums, a => a.Codigo).Where(a => a > 0).ToArray(), codigo);

            if (binarySearchResult != -1) {
                editButton.Click += editAlbum;
                searchDefine.Text = "Título do Album: " + General.Albums[binarySearchResult].Titulo;
                dataGridLabel1.Text = "Músicas";
                dataGridLabel2.Text = "Artistas";

                searchDefine.Visible = true;
                editButton.Visible = true;
                dataGridLabel1.Visible = true;
                dataGridLabel2.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;

                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].Name = "Código";
                dataGridView1.Columns[1].Name = "Título";
                dataGridView1.Rows.Clear();
                for (int i = 0; i < General.Albums[binarySearchResult].CodigosMusicas.Length; i++) {
                    General.Cancao cancaoTemp = General.Cancoes[General.Albums[binarySearchResult].CodigosMusicas[i] - 1];
                    dataGridView1.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo);
                }

                dataGridView2.ColumnCount = 5;
                dataGridView2.Columns[0].Name = "Código";
                dataGridView2.Columns[1].Name = "Nome Verdadeiro";
                dataGridView2.Columns[2].Name = "Nome Artístico";
                dataGridView2.Columns[3].Name = "Data de Aniversário";
                dataGridView2.Columns[4].Name = "Faz parte de uma banda?";
                dataGridView2.Rows.Clear();
                for (int i = 0; i < General.Albums[binarySearchResult].ArtistasParticipantes.Length; i++) {
                    General.Artista artistaTemp = General.Artistas[General.Albums[binarySearchResult].ArtistasParticipantes[i] - 1];
                    string banda;
                    if (artistaTemp.BandaBool)
                        banda = "Sim";
                    else
                        banda = "Não";
                    dataGridView2.Rows.Add(artistaTemp.Codigo, artistaTemp.NomeVerdadeiro, artistaTemp.NomeArtistico, artistaTemp.Aniversario.ToString("d"), banda, "Editar", "Remover");
                }
            }
            else {
                MessageBox.Show("Nenhum álbum encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorCancao(int codigo) {
            binarySearchResult = BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Cancoes, a => a.Codigo).Where(a => a > 0).ToArray(), codigo);

            if (binarySearchResult != -1) {
                editButton.Click += editCancao;
                searchDefine.Text = "Título da Canção: " + General.Cancoes[binarySearchResult].Titulo;
                dataGridLabel1.Text = "Artistas";
                dataGridLabel2.Text = "Álbuns";

                searchDefine.Visible = true;
                editButton.Visible = true;
                dataGridLabel1.Visible = true;
                dataGridLabel2.Visible = true;
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;

                dataGridView1.ColumnCount = 6;
                dataGridView1.Columns[0].Name = "Código";
                dataGridView1.Columns[1].Name = "Nome Verdadeiro";
                dataGridView1.Columns[2].Name = "Nome Artístico";
                dataGridView1.Columns[3].Name = "Data de Aniversário";
                dataGridView1.Columns[4].Name = "Faz parte de uma banda?";
                dataGridView1.Columns[5].Name = "Tipo";
                dataGridView1.Rows.Clear();

                General.Artista artistaTemp1 = General.Artistas[General.Cancoes[binarySearchResult].CodigoCompositor - 1];
                dataGridView1.Rows.Add(artistaTemp1.Codigo, artistaTemp1.NomeVerdadeiro, artistaTemp1.NomeArtistico, artistaTemp1.Aniversario.ToString("d"), artistaTemp1.BandaBool ? "Sim" : "Não", "Compositor");

                General.Artista artistaTemp2 = General.Artistas[General.Cancoes[binarySearchResult].CodigoArtistaPrimeiraGravacao - 1];
                dataGridView1.Rows.Add(artistaTemp2.Codigo, artistaTemp2.NomeVerdadeiro, artistaTemp2.NomeArtistico, artistaTemp2.Aniversario.ToString("d"), artistaTemp2.BandaBool ? "Sim" : "Não", "Musicista");

                dataGridView2.ColumnCount = 4;
                dataGridView2.Columns[0].Name = "Código";
                dataGridView2.Columns[1].Name = "Título";
                dataGridView2.Columns[2].Name = "Data de Lançamento";
                dataGridView2.Columns[3].Name = "Número de Cópias Vendidas";
                dataGridView2.Rows.Clear();
                for (int i = 0; i < General.AlbumsSize; i++) {
                    for (int j = 0; j < General.Albums[i].CodigosMusicas.Length; j++) {
                        if (General.Albums[i].CodigosMusicas[j] == codigo) {
                            General.Album albumTemp = General.Albums[i];
                            dataGridView2.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString());
                        }
                    }
                }
            }
            else {
                MessageBox.Show("Nenhuma canção encontrada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void editArtista(object Sender, EventArgs e) {
            new ArtistaForm(binarySearchResult).ShowDialog();
        }

        public void editAlbum(object Sender, EventArgs e) {
            new AlbumForm(binarySearchResult).ShowDialog();
        }

        public void editCancao(object Sender, EventArgs e) {
            new CancaoForm(binarySearchResult).ShowDialog();
        }
    }
}
