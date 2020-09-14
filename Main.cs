using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e) {
            General.Albums = new General.Album[General.MaxSize];
            General.AlbumsSize = 0;
            General.Artistas = new General.Artista[General.MaxSize];
            General.ArtistasSize = 0;
            General.Cancoes = new General.Cancao[General.MaxSize];
            General.CancoesSize = 0;

            toolTip.SetToolTip(SongAdd, "Adicionar música");
            toolTip.SetToolTip(AlbumAdd, "Adicionar álbum");
            toolTip.SetToolTip(ArtistAdd, "Adicionar artista");
            toolTip.SetToolTip(Search, "Pesquisar");

            // DataGridView Musicas
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            dataGridViewMusicas.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            dataGridViewMusicas.Columns.Add(buttonColumn);
            dataGridViewMusicas.CellClick += dataGridViewMusicas_CellClick;

            // DataGridView Albuns
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            dataGridViewAlbuns.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            dataGridViewAlbuns.Columns.Add(buttonColumn);
            dataGridViewAlbuns.CellClick += dataGridViewAlbuns_CellClick;

            // DataGridView Artistas
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            dataGridViewArtistas.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            dataGridViewArtistas.Columns.Add(buttonColumn);
            dataGridViewArtistas.CellClick += dataGridViewArtistas_CellClick;
            
            InserirDadosIniciais();
        }

        private void InserirDadosIniciais() {
            #region Artistas
            General.Artistas[0] = new General.Artista() {
                Codigo = 1,
                NomeVerdadeiro = "Saul Hudson",
                NomeArtistico = "Slash",
                Aniversario = Convert.ToDateTime("23/07/1965"),
                BandaBool = true,
                NomeBanda = "Guns N'Roses",
                Email = "slash@armaserosas.com",
                Telefone = "+5511987654321",
                NomeEmpresario = "Empresário do Slash",
                EmailEmpresario = "empresario@slash.com",
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 0,
                NumeroComposicoes = 0,
                CacheMinimo = 100000
            };
            General.ArtistasSize++;

            General.Artistas[1] = new General.Artista() {
                Codigo = 2,
                NomeVerdadeiro = "Pedro Henrique Loureiro",
                NomeArtistico = "Kiko Loureiro",
                Aniversario = Convert.ToDateTime("16/06/1972"),
                BandaBool = true,
                NomeBanda = "Megadeth",
                Email = "pedrinho123@megadeth.com",
                Telefone = "+5511987654321",
                NomeEmpresario = "Empresário do pedro",
                EmailEmpresario = "empresario@pedro.com",
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 0,
                NumeroComposicoes = 0,
                CacheMinimo = 100000
            };
            General.ArtistasSize++;

            General.Artistas[2] = new General.Artista() {
                Codigo = 3,
                NomeVerdadeiro = "Adrian Frederick Smith",
                NomeArtistico = "Adrian Smith",
                Aniversario = Convert.ToDateTime("27/02/1957"),
                BandaBool = true,
                NomeBanda = "Iron Maiden",
                Email = "adriano@homemdeferro.com",
                Telefone = "+5511987654321",
                NomeEmpresario = "Empresário do adriano",
                EmailEmpresario = "empresario@adriano.com",
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 0,
                NumeroComposicoes = 0,
                CacheMinimo = 100000
            };
            General.ArtistasSize++;

            General.Artistas[3] = new General.Artista() {
                Codigo = 4,
                NomeVerdadeiro = "Edward Louis Severson III",
                NomeArtistico = "Eddie Vedder",
                Aniversario = Convert.ToDateTime("23/12/1964"),
                BandaBool = true,
                NomeBanda = "Pearl Jam",
                Email = "edvaldo@geleiadeperola.com",
                Telefone = "+5511987654321",
                NomeEmpresario = "Empresário do edvaldo",
                EmailEmpresario = "empresario@edvaldo.com",
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 0,
                NumeroComposicoes = 0,
                CacheMinimo = 100000
            };
            General.ArtistasSize++;

            UpdateRows(DataGrid.Artistas);
            #endregion

            #region CancoesSlash
            General.Cancoes[0] = new General.Cancao() {
                Codigo = 1,
                Titulo = "World on Fire",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[1] = new General.Cancao() {
                Codigo = 2,
                Titulo = "Shadow Life",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[2] = new General.Cancao() {
                Codigo = 3,
                Titulo = "Automatic Overdrive",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[3] = new General.Cancao() {
                Codigo = 4,
                Titulo = "Wicked Stone",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[4] = new General.Cancao() {
                Codigo = 5,
                Titulo = "30 Years to Life",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;
            #endregion

            #region CancoesKiko
            General.Cancoes[5] = new General.Cancao() {
                Codigo = 6,
                Titulo = "OVERFLOW",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[6] = new General.Cancao() {
                Codigo = 7,
                Titulo = "EDM (E-DEPENDENT MIND)",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[7] = new General.Cancao() {
                Codigo = 8,
                Titulo = "IMMINENT THREAT",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[8] = new General.Cancao() {
                Codigo = 9,
                Titulo = "LIQUID TIMES",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[9] = new General.Cancao() {
                Codigo = 10,
                Titulo = "SERTAO",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;
            #endregion

            #region CancoesAdrian
            General.Cancoes[10] = new General.Cancao() {
                Codigo = 11,
                Titulo = "Somewhere in Time",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[11] = new General.Cancao() {
                Codigo = 12,
                Titulo = "The Old Woman",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[12] = new General.Cancao() {
                Codigo = 13,
                Titulo = "The Journey Back in Time",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[13] = new General.Cancao() {
                Codigo = 14,
                Titulo = "A Day Together",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[14] = new General.Cancao() {
                Codigo = 15,
                Titulo = "Rhapsody on a Theme of Paganini",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;
            #endregion

            #region CancoesEddie
            General.Cancoes[15] = new General.Cancao() {
                Codigo = 16,
                Titulo = "Setting Forth",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[16] = new General.Cancao() {
                Codigo = 17,
                Titulo = "No Ceiling",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[17] = new General.Cancao() {
                Codigo = 18,
                Titulo = "Far Behind",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[18] = new General.Cancao() {
                Codigo = 19,
                Titulo = "Rise",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[19] = new General.Cancao() {
                Codigo = 20,
                Titulo = "Long Nights",
                Letra = "",
                Melodia = "",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;
            #endregion

            UpdateRows(DataGrid.Musicas);
        }

        private void dataGridViewMusicas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridViewMusicas.Columns["Editar"].Index) {
                if (IsFormOpen("CancaoForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new CancaoForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == dataGridViewMusicas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover esta música?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewMusicas.Rows.RemoveAt(e.RowIndex);
                    General.Cancao.RemoveAt(e.RowIndex);
                    General.CancoesSize--;
                }
            }
        }

        private void dataGridViewAlbuns_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridViewAlbuns.Columns["Editar"].Index) {
                if (IsFormOpen("AlbumForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new AlbumForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == dataGridViewAlbuns.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este álbum?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewAlbuns.Rows.RemoveAt(e.RowIndex);
                    General.Album.RemoveAt(e.RowIndex);
                    General.AlbumsSize--;
                }
            }
        }

        private void dataGridViewArtistas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dataGridViewArtistas.Columns["Editar"].Index) {
                if (IsFormOpen("ArtistaForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new ArtistaForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == dataGridViewArtistas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este artista?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewArtistas.Rows.RemoveAt(e.RowIndex);
                    General.Artista.RemoveAt(e.RowIndex);
                    General.ArtistasSize--;
                }
            }
        }

        private void SongAdd_Click(object sender, EventArgs e) {
            if (IsFormOpen("CancaoForm"))
                MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                new CancaoForm().Show();
        }

        private void AlbumAdd_Click(object sender, EventArgs e) {
            if (IsFormOpen("AlbumForm"))
                MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                new AlbumForm().Show();
        }

        private void ArtistAdd_Click(object sender, EventArgs e) {
            if (IsFormOpen("ArtistaForm"))
                MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                new ArtistaForm().Show();
        }

        public void UpdateRows(DataGrid dataGrid) {
            switch (dataGrid) {
                case DataGrid.Musicas:
                    dataGridViewMusicas.Rows.Clear();
                    for (int i = 0; i < General.CancoesSize; i++) {
                        General.Cancao cancaoTemp = General.Cancoes[i];
                        dataGridViewMusicas.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo, "Editar", "Remover");
                    }
                    break;
                case DataGrid.Albuns:
                    dataGridViewAlbuns.Rows.Clear();
                    for (int i = 0; i < General.AlbumsSize; i++) {
                        General.Album albumTemp = General.Albums[i];
                        dataGridViewAlbuns.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString(), "Editar", "Remover");
                    }
                    break;
                case DataGrid.Artistas:
                    dataGridViewArtistas.Rows.Clear();
                    for (int i = 0; i < General.ArtistasSize; i++) {
                        General.Artista artistaTemp = General.Artistas[i];
                        string banda;
                        if (artistaTemp.BandaBool)
                            banda = "Sim";
                        else
                            banda = "Não";
                        dataGridViewArtistas.Rows.Add(artistaTemp.Codigo, artistaTemp.NomeVerdadeiro, artistaTemp.NomeArtistico, artistaTemp.Aniversario.ToString("d"), banda, "Editar", "Remover");
                    }
                    break;
            }
        }

        public enum DataGrid {
            Musicas,
            Albuns,
            Artistas
        }

        private void Search_Click(object sender, EventArgs e) {
            if (IsFormOpen("Search"))
                MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                new Search().Show();
        }

        private bool IsFormOpen(string name) {
            foreach (Form form in Application.OpenForms) {
                if (form.Name == name)
                    return true;
            }

            return false;
        }

        private void GerarRelatorio_Click(object sender, EventArgs e) {

        }
    }
}
