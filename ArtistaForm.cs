using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class ArtistaForm : Form {
        private int Index { get; set; }

        public ArtistaForm() {
            InitializeComponent();
            Index = -1;
        }

        public ArtistaForm(int index) {
            InitializeComponent();
            Index = index;
        }

        private void BandaSN_CheckedChanged(object sender, EventArgs e) {
            if (BandaSN.Checked)
                Banda.Enabled = true;
            else {
                Banda.Enabled = false;
                Banda.Text = "";
            }
        }

        private void Salvar_Click(object sender, EventArgs e) {
            if (!int.TryParse(Codigo.Text, out int codigo) && Codigo.Text != "") {
                MessageBox.Show("O código precisa ser um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NomeVerdadeiro.Text == "" || NomeArtistico.Text == "" || DataAniversario.Text == "" || (BandaSN.Checked && Banda.Text == "") || Email.Text == "" || Telefone.Text == "" || NomeEmpresario.Text == "" || EmailEmpresario.Text == "" || TipoTrabalho.SelectedIndex == -1 || NAlbunsLancados.Text == "" || NComposicoes.Text == "") {
                MessageBox.Show("Todos os campos precisam ser prenchidos com excessão do código", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParse(DataAniversario.Text, out DateTime aniversario)) {
                MessageBox.Show("O campo Data de Aniversário não está em um formato válido, utilize o formato dia/mês/ano", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(NAlbunsLancados.Text, out int nAlbunsLancados)) {
                MessageBox.Show("", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(NComposicoes.Text, out int nComposicoes)) {
                MessageBox.Show("", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(CacheMinimo.Text, out decimal cacheMinimo)) {
                MessageBox.Show("O campo Cache Mínimo não está em um formato válido, utilize o formato #.##", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            General.Artista.TipoTrabalho tipoTrabalho = TipoTrabalho.SelectedIndex switch
            {
                0 => General.Artista.TipoTrabalho.Cantor,
                1 => General.Artista.TipoTrabalho.Compositor,
                2 => General.Artista.TipoTrabalho.Ambos,
                _ => throw new IndexOutOfRangeException(),
            };

            if (Index == -1) {
                General.Artistas[General.ArtistasSize++] = new General.Artista() {
                    Codigo = codigo,
                    NomeVerdadeiro = NomeVerdadeiro.Text,
                    NomeArtistico = NomeArtistico.Text,
                    Aniversario = aniversario,
                    BandaBool = BandaSN.Checked,
                    NomeBanda = Banda.Text,
                    Email = Email.Text,
                    Telefone = Telefone.Text,
                    NomeEmpresario = NomeEmpresario.Text,
                    EmailEmpresario = EmailEmpresario.Text,
                    TipoDeTrabalho = tipoTrabalho,
                    NumeroAlbunsLancados = nAlbunsLancados,
                    NumeroComposicoes = nComposicoes, 
                    CacheMinimo = cacheMinimo
                };
                // Sort
            }
            else {
                General.Artistas[Index] = new General.Artista() {
                    Codigo = codigo,
                    NomeVerdadeiro = NomeVerdadeiro.Text,
                    NomeArtistico = NomeArtistico.Text,
                    Aniversario = aniversario,
                    BandaBool = BandaSN.Checked,
                    NomeBanda = Banda.Text,
                    Email = Email.Text,
                    Telefone = Telefone.Text,
                    NomeEmpresario = NomeEmpresario.Text,
                    EmailEmpresario = EmailEmpresario.Text,
                    TipoDeTrabalho = tipoTrabalho,
                    NumeroAlbunsLancados = nAlbunsLancados,
                    NumeroComposicoes = nComposicoes,
                    CacheMinimo = cacheMinimo
                };
            }

            Program.globalForm.UpdateRows(Main.DataGrid.Artistas);
            Close();
        }
    }
}
