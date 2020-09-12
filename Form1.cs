﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class Form1 : Form {
        

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            General.Albums = new Album[General.MaxSize];
            General.AlbumsSize = 0;
            General.Artistas = new Artista[General.MaxSize];
            General.ArtistasSize = 0;
            General.Cancoes = new Cancao[General.MaxSize];
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
        }

        private void dataGridViewMusicas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == dataGridViewMusicas.Columns["Editar"].Index) {
                new CancaoForm(e.RowIndex).Show();
            }
            else if (e.ColumnIndex == dataGridViewMusicas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover esta música?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewMusicas.Rows.RemoveAt(e.RowIndex);
                    // TODO: Remover do vetor
                    General.CancoesSize--;
                }
            }
        }

        private void dataGridViewAlbuns_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == dataGridViewAlbuns.Columns["Editar"].Index) {
                MessageBox.Show("Oi");
            }
            else if (e.ColumnIndex == dataGridViewAlbuns.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este álbum?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewAlbuns.Rows.RemoveAt(e.RowIndex);
                    // TODO: Remover do vetor
                    General.AlbumsSize--;
                }
            }
        }

        private void dataGridViewArtistas_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == dataGridViewArtistas.Columns["Editar"].Index) {
                MessageBox.Show("Oi");
            }
            else if (e.ColumnIndex == dataGridViewArtistas.Columns["Remover"].Index) {
                if (MessageBox.Show("Tem certeza que deseja remover este artista?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    dataGridViewArtistas.Rows.RemoveAt(e.RowIndex);
                    // TODO: Remover do vetor
                    General.ArtistasSize--;
                }
            }
        }

        private void SongAdd_Click(object sender, EventArgs e) {
            new CancaoForm().Show();
        }

        private void AlbumAdd_Click(object sender, EventArgs e) {
            if (General.AlbumsSize >= General.MaxSize) { // TODO: Mover para dentro do form
                MessageBox.Show("O limite de espaço para álbuns foi atingido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            new AlbumForm().Show();
        }

        private void ArtistAdd_Click(object sender, EventArgs e) {
            new ArtistaForm().Show();
        }

        public void UpdateRows(DataGrid dataGrid) {
            switch (dataGrid) {
                case DataGrid.Musicas:
                    dataGridViewMusicas.Rows.Clear();
                    for (int i = 0; i < General.CancoesSize; i++) {
                        Cancao cancaoTemp = General.Cancoes[i];
                        dataGridViewMusicas.Rows.Add(cancaoTemp.Codigo, cancaoTemp.Titulo, "Editar", "Remover");
                    }
                    break;
                case DataGrid.Albuns:
                    dataGridViewAlbuns.Rows.Clear();
                    for (int i = 0; i < General.AlbumsSize; i++) {
                        Album albumTemp = General.Albums[i];
                        dataGridViewAlbuns.Rows.Add(albumTemp.Codigo, albumTemp.Titulo, albumTemp.DataLancamento.ToString("d"), albumTemp.NumeroCopiasVendidas.ToString(), "Editar", "Remover");
                    }
                    break;
                case DataGrid.Artistas:
                    dataGridViewArtistas.Rows.Clear();
                    for (int i = 0; i < General.ArtistasSize; i++) {
                        Artista artistaTemp = General.Artistas[i];
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

        }
    }
}
