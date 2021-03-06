﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
            toolTip.SetToolTip(GerarRelatorio, "Gerar Relatório");

            #region DataGridView Musicas
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            DataGridViewMusicas.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            DataGridViewMusicas.Columns.Add(buttonColumn);
            DataGridViewMusicas.CellClick += DataGridViewMusicas_CellClick;

            foreach (DataGridViewColumn column in DataGridViewMusicas.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            #region DataGridView Albuns
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            DataGridViewAlbuns.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            DataGridViewAlbuns.Columns.Add(buttonColumn);
            DataGridViewAlbuns.CellClick += DataGridViewAlbuns_CellClick;

            foreach (DataGridViewColumn column in DataGridViewAlbuns.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            #region DataGridView Artistas
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Editar"
            };
            DataGridViewArtistas.Columns.Add(buttonColumn);
            buttonColumn = new DataGridViewButtonColumn() {
                Name = "Remover"
            };
            DataGridViewArtistas.Columns.Add(buttonColumn);
            DataGridViewArtistas.CellClick += DataGridViewArtistas_CellClick;

            foreach (DataGridViewColumn column in DataGridViewArtistas.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

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
                EmailEmpresarioTabelaHash = HashTable.QuadraticHashInsert("empresario@slash.com"),
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 1,
                NumeroComposicoes = 1,
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
                EmailEmpresarioTabelaHash = HashTable.QuadraticHashInsert("empresario@pedro.com"),
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 2,
                NumeroComposicoes = 2,
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
                EmailEmpresarioTabelaHash = HashTable.QuadraticHashInsert("empresario@adriano.com"),
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 3,
                NumeroComposicoes = 3,
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
                EmailEmpresarioTabelaHash = HashTable.QuadraticHashInsert("empresario@edvaldo.com"),
                TipoDeTrabalho = General.Artista.TipoTrabalho.Compositor,
                NumeroAlbunsLancados = 4,
                NumeroComposicoes = 4,
                CacheMinimo = 100000
            };
            General.ArtistasSize++;

            UpdateRows(DataGrid.Artistas);
            #endregion

            #region Musicas
            #region CancoesSlash
            General.Cancoes[0] = new General.Cancao() {
                Codigo = 1,
                Titulo = "World on Fire",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[1] = new General.Cancao() {
                Codigo = 2,
                Titulo = "Shadow Life",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[2] = new General.Cancao() {
                Codigo = 3,
                Titulo = "Automatic Overdrive",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[3] = new General.Cancao() {
                Codigo = 4,
                Titulo = "Wicked Stone",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;

            General.Cancoes[4] = new General.Cancao() {
                Codigo = 5,
                Titulo = "30 Years to Life",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 1,
                CodigoArtistaPrimeiraGravacao = 1
            };
            General.CancoesSize++;
            #endregion

            #region CancoesKiko
            General.Cancoes[5] = new General.Cancao() {
                Codigo = 6,
                Titulo = "OVERFLOW",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[6] = new General.Cancao() {
                Codigo = 7,
                Titulo = "EDM (E-DEPENDENT MIND)",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[7] = new General.Cancao() {
                Codigo = 8,
                Titulo = "IMMINENT THREAT",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[8] = new General.Cancao() {
                Codigo = 9,
                Titulo = "LIQUID TIMES",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;

            General.Cancoes[9] = new General.Cancao() {
                Codigo = 10,
                Titulo = "SERTAO",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 2,
                CodigoArtistaPrimeiraGravacao = 2
            };
            General.CancoesSize++;
            #endregion

            #region CancoesAdrian
            General.Cancoes[10] = new General.Cancao() {
                Codigo = 11,
                Titulo = "Somewhere in Time",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[11] = new General.Cancao() {
                Codigo = 12,
                Titulo = "The Old Woman",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[12] = new General.Cancao() {
                Codigo = 13,
                Titulo = "The Journey Back in Time",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[13] = new General.Cancao() {
                Codigo = 14,
                Titulo = "A Day Together",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;

            General.Cancoes[14] = new General.Cancao() {
                Codigo = 15,
                Titulo = "Rhapsody on a Theme of Paganini",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 3,
                CodigoArtistaPrimeiraGravacao = 3
            };
            General.CancoesSize++;
            #endregion

            #region CancoesEddie
            General.Cancoes[15] = new General.Cancao() {
                Codigo = 16,
                Titulo = "Setting Forth",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[16] = new General.Cancao() {
                Codigo = 17,
                Titulo = "No Ceiling",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[17] = new General.Cancao() {
                Codigo = 18,
                Titulo = "Far Behind",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[18] = new General.Cancao() {
                Codigo = 19,
                Titulo = "Rise",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;

            General.Cancoes[19] = new General.Cancao() {
                Codigo = 20,
                Titulo = "Long Nights",
                Letra = "Letra",
                Melodia = "Melodia",
                CodigoCompositor = 4,
                CodigoArtistaPrimeiraGravacao = 4
            };
            General.CancoesSize++;
            #endregion

            UpdateRows(DataGrid.Musicas);
            #endregion

            #region Albums
            General.Albums[0] = new General.Album() {
                Codigo = 1,
                Titulo = "World on Fire",
                CodigosMusicas = new int[5] { 1, 2, 3, 4, 5 },
                DataLancamento = Convert.ToDateTime("15/07/2014"),
                NumeroCopiasVendidas = 10000,
                ArtistasParticipantes = new int[1] { 1 }
            };
            General.AlbumsSize++;

            General.Albums[1] = new General.Album() {
                Codigo = 2,
                Titulo = "OPEN SOURCE",
                CodigosMusicas = new int[5] { 6, 7, 8, 9, 10 },
                DataLancamento = Convert.ToDateTime("10/07/2020"),
                NumeroCopiasVendidas = 10000,
                ArtistasParticipantes = new int[1] { 2 }
            };
            General.AlbumsSize++;

            General.Albums[2] = new General.Album() {
                Codigo = 3,
                Titulo = "Somewhere in Time",
                CodigosMusicas = new int[5] { 11, 12, 13, 14, 15 },
                DataLancamento = Convert.ToDateTime("29/09/1986"),
                NumeroCopiasVendidas = 10000,
                ArtistasParticipantes = new int[1] { 3 }
            };
            General.AlbumsSize++;

            General.Albums[3] = new General.Album() {
                Codigo = 4,
                Titulo = "Into the Wild",
                CodigosMusicas = new int[5] { 16, 17, 18, 19, 20 },
                DataLancamento = Convert.ToDateTime("18/09/2007"),
                NumeroCopiasVendidas = 10000,
                ArtistasParticipantes = new int[1] { 4 }
            };
            General.AlbumsSize++;

            UpdateRows(DataGrid.Albuns);
            #endregion
        }

        private void DataGridViewMusicas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == DataGridViewMusicas.Columns["Editar"].Index) {
                if (IsFormOpen("CancaoForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new CancaoForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == DataGridViewMusicas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover esta música? Todos os álbuns que contém esta música também serão excluídos.", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    // Remove os álbuns que contém a música a ser removida para evitar problemas
                    General.Album.RemoverMusica(General.Cancoes[e.RowIndex].Codigo);

                    // Remove a música
                    General.Cancao.RemoveAt(e.RowIndex);

                    UpdateRows(DataGrid.Albuns);
                    UpdateRows(DataGrid.Musicas);
                }
            }
        }

        private void DataGridViewAlbuns_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == DataGridViewAlbuns.Columns["Editar"].Index) {
                if (IsFormOpen("AlbumForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new AlbumForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == DataGridViewAlbuns.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este álbum?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    // Remove o álbum
                    General.Album.RemoveAt(e.RowIndex);

                    UpdateRows(DataGrid.Albuns);
                }
            }
        }

        private void DataGridViewArtistas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == DataGridViewArtistas.Columns["Editar"].Index) {
                if (IsFormOpen("ArtistaForm"))
                    MessageBox.Show("Não é possível abrir outro formulário do mesmo tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    new ArtistaForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == DataGridViewArtistas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este artista? Todos as músicas e álbuns que contém este artista também serão excluídos.", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    // Remove as músicas que contém o artista a ser removido para evitar problemas
                    General.Cancao.RemoverArtista(General.Artistas[e.RowIndex].Codigo);

                    // Remove os álbuns que contém o artista a ser removido para evitar problemas
                    General.Album.RemoverArtista(General.Artistas[e.RowIndex].Codigo);

                    // Remove o email do empresário da tabela hash
                    HashTable.Remove(General.Artistas[e.RowIndex].EmailEmpresarioTabelaHash);

                    // Remove o artista
                    General.Artista.RemoveAt(e.RowIndex);

                    UpdateRows(DataGrid.Albuns);
                    UpdateRows(DataGrid.Musicas);
                    UpdateRows(DataGrid.Artistas);
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
                    DataGridViewMusicas.Rows.Clear();
                    for (int i = 0; i < General.CancoesSize; i++) {
                        General.Cancao cancaoTemp = General.Cancoes[i];
                        DataGridViewMusicas.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo, "Editar", "Remover");
                    }
                    break;
                case DataGrid.Albuns:
                    DataGridViewAlbuns.Rows.Clear();
                    for (int i = 0; i < General.AlbumsSize; i++) {
                        General.Album albumTemp = General.Albums[i];
                        DataGridViewAlbuns.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString(), "Editar", "Remover");
                    }
                    break;
                case DataGrid.Artistas:
                    DataGridViewArtistas.Rows.Clear();
                    for (int i = 0; i < General.ArtistasSize; i++) {
                        General.Artista artistaTemp = General.Artistas[i];
                        DataGridViewArtistas.Rows.Add(artistaTemp.Codigo, artistaTemp.NomeVerdadeiro, artistaTemp.NomeArtistico, artistaTemp.Aniversario.ToString("d"), artistaTemp.BandaBool ? "Sim" : "Não", "Editar", "Remover");
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
                new Pesquisar().Show();
        }

        private bool IsFormOpen(string name) {
            foreach (Form form in Application.OpenForms) {
                if (form.Name == name)
                    return true;
            }

            return false;
        }

        private void GerarRelatorio_Click(object sender, EventArgs e) {
            // Previne que as funções disparem mais de uma vez, funciona mesmo que a função não tenho sido atribuída ainda
            MenuRelatorio.Items[0].Click -= RelatorioAniversariantes_Click;
            MenuRelatorio.Items[1].Click -= RelatorioAlbuns_Click;
            MenuRelatorio.Items[2].Click -= RelatorioEmails_Click;

            MenuRelatorio.Items[0].Click += RelatorioAniversariantes_Click;
            MenuRelatorio.Items[1].Click += RelatorioAlbuns_Click;
            MenuRelatorio.Items[2].Click += RelatorioEmails_Click;
            MenuRelatorio.Show(Cursor.Position);
        }

        private void RelatorioAniversariantes_Click(object sender, EventArgs e) {
            new Relatorios(Relatorios.TipoRelatorio.Aniversario).Show();
        }

        private void RelatorioAlbuns_Click(object sender, EventArgs e) {
            new Relatorios(Relatorios.TipoRelatorio.Album).Show();
        }

        private void RelatorioEmails_Click(object sender, EventArgs e) {
            new Relatorios(Relatorios.TipoRelatorio.Emails).Show();
        }
    }
}