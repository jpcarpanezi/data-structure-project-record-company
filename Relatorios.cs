using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class Relatorios : Form {
        public enum TipoRelatorio {
            Aniversario,
            Album,
            Emails
        }

        private readonly TipoRelatorio Tipo;

        public Relatorios(TipoRelatorio tipoRelatorio) {
            InitializeComponent();

            Tipo = tipoRelatorio;
        }
        private void Relatorios_Load(object sender, EventArgs e) {
            switch (Tipo) {
                case TipoRelatorio.Aniversario:
                    Text = "Relatório de aniversários mensais";

                    LabelGridView.Visible = false;
                    dataGridView1.Visible = false;

                    break;
                case TipoRelatorio.Album:
                    GerarRelatorioAlbum();
                    break;
                case TipoRelatorio.Emails:
                    GerarRelatorioEmails();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void GerarRelatorioEmails() {
            Text = "Relatório de emails";

            LabelGridView.Text = "Emails de todos os empresários";
            LabelGridView.Location = new Point(13, 12);

            dataGridView1.Size = new Size(775, 408);
            dataGridView1.Location = new Point(13, 30);

            LabelMes.Visible = false;
            MesDesejado.Visible = false;
            PesquisarMes.Visible = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Email", "Email");

            string[] emails = HashTable.GetAllValues();
            for (int i = 0; i < emails.Length; i++) {
                dataGridView1.Rows.Add(emails[i]);
            }

            RemoverSort();
        }

        private void GerarRelatorioAlbum() {
            Text = "Relatório de álbuns";

            LabelGridView.Text = "Álbuns a serem lançados ainda este ano";
            LabelGridView.Location = new Point(13, 12);

            dataGridView1.Size = new Size(775, 408);
            dataGridView1.Location = new Point(13, 30);

            LabelMes.Visible = false;
            MesDesejado.Visible = false;
            PesquisarMes.Visible = false;

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Codigo", "Código");
            dataGridView1.Columns.Add("Titulo", "Título");
            dataGridView1.Columns.Add("DataLancamento", "Data de Lançamento");
            RemoverSort();

            List<General.Album> albums = new List<General.Album>();
            for (int i = 0; i < General.AlbumsSize; i++) {
                if (General.Albums[i].DataLancamento > DateTime.Today && General.Albums[i].DataLancamento.Year == DateTime.Today.Year)
                    albums.Add(General.Albums[i]);
            }

            General.Album[] albumsArr = albums.ToArray();
            MergeSort.Sort(albumsArr, Array.ConvertAll(albumsArr, a => a.DataLancamento));

            if (albums.Count != 0) {
                for (int i = 0; i < albumsArr.Length; i++) {
                    dataGridView1.Rows.Add(albumsArr[i].Codigo, albumsArr[i].Titulo, albumsArr[i].DataLancamento.ToString("d"));
                }
            }
            else {
                MessageBox.Show("Não existem álbuns a serem lançados ainda este ano.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }

        private void PesquisarMes_Click(object sender, EventArgs e) {
            if (!int.TryParse(MesDesejado.Text, out int mes) || mes < 1 || mes > 12) {
                MessageBox.Show("O mês precisa ser um número entre 1 e 12", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.Rows.Clear();

            List<General.Artista> artistas = new List<General.Artista>();
            for (int i = 0; i < General.ArtistasSize; i++) {
                if (General.Artistas[i].Aniversario.Month == mes)
                    artistas.Add(General.Artistas[i]);
            }

            if (artistas.Count != 0) {
                dataGridView1.Visible = true;
                LabelGridView.Visible = true;
                LabelGridView.Text = "Aniversariantes no mês " + MesDesejado.Text;

                dataGridView1.Columns.Clear(); ;
                dataGridView1.Columns.Add("Codigo", "Código");
                dataGridView1.Columns.Add("DataAniversario", "Data de Aniversário");
                dataGridView1.Columns.Add("CacheMinimo", "Cache Mínimo");
                dataGridView1.Columns.Add("CacheMinimo1.2", "Cache Mínimo + 20%");
                RemoverSort();

                for (int i = 0; i < artistas.Count; i++) {
                    dataGridView1.Rows.Add(artistas[i].Codigo, artistas[i].Aniversario.ToString("d"), artistas[i].CacheMinimo.ToString("C"), (artistas[i].CacheMinimo * 1.2m).ToString("C"));
                }
            }
            else {
                dataGridView1.Rows.Clear();
                LabelGridView.Text = "";
                MessageBox.Show("Não existem aniversariantes para este mês.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RemoverSort() {
            foreach (DataGridViewColumn column in dataGridView1.Columns) {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }

}
