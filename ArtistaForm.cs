using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class ArtistaForm : Form {
        private int Index { get; set; }

        public ArtistaForm() {
            InitializeComponent();
            Index = -1;
            Banda.Enabled = false;
        }

        public ArtistaForm(int index) {
            InitializeComponent();
            Index = index;
            Banda.Enabled = false;

            Codigo.Enabled = false;
            General.Artista artistaTemp = General.Artistas[index];
            Codigo.Text = artistaTemp.Codigo.ToString();
            NomeVerdadeiro.Text = artistaTemp.NomeVerdadeiro;
            NomeArtistico.Text = artistaTemp.NomeArtistico;
            DataAniversario.Text = artistaTemp.Aniversario.ToString("d");
            BandaSN.Checked = artistaTemp.BandaBool;
            if (BandaSN.Checked)
                Banda.Enabled = true;
            Banda.Text = artistaTemp.NomeBanda;
            Email.Text = artistaTemp.Email;
            Telefone.Text = artistaTemp.Telefone;
            NomeEmpresario.Text = artistaTemp.NomeEmpresario;
            EmailEmpresario.Text = artistaTemp.EmailEmpresario;
            TipoTrabalho.SelectedIndex = Convert.ToInt32(artistaTemp.TipoDeTrabalho) - 1;
            NAlbunsLancados.Text = artistaTemp.NumeroAlbunsLancados.ToString();
            NComposicoes.Text = artistaTemp.NumeroComposicoes.ToString();
            CacheMinimo.Text = artistaTemp.CacheMinimo.ToString();
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
            string erro = "";
            if (!int.TryParse(Codigo.Text, out int codigo) && Codigo.Text != "") 
                erro += "- O código precisa ser um número\n";

            if (codigo <= 0)
                erro += "- O código precisa ser maior que zero";

            if (NomeVerdadeiro.Text == "" || NomeArtistico.Text == "" || DataAniversario.Text == "" || (BandaSN.Checked && Banda.Text == "") || Email.Text == "" || Telefone.Text == "" || NomeEmpresario.Text == "" || EmailEmpresario.Text == "" || TipoTrabalho.SelectedIndex == -1 || NAlbunsLancados.Text == "" || NComposicoes.Text == "") 
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (!DateTime.TryParse(DataAniversario.Text, out DateTime aniversario)) 
                erro += "- O campo Data de Aniversário não está em um formato válido, utilize o formato dia/mês/ano\n";

            if (!int.TryParse(NAlbunsLancados.Text, out int nAlbunsLancados)) 
                erro += "- O número de álbuns lançados precisa ser um número\n";
            
            if (!int.TryParse(NComposicoes.Text, out int nComposicoes)) 
                erro += "- O número de composições precisa ser um número\n";

            if (!decimal.TryParse(CacheMinimo.Text, out decimal cacheMinimo)) 
                erro += "- O campo Cache Mínimo não está em um formato válido, utilize o formato #.##\n";

            if (Index == -1 && BinarySearch.BinarySearchDisplay(Array.ConvertAll(General.Artistas, a => a.Codigo).Where(a => a > 0).ToArray(), codigo) != -1)
                erro += "- Este código já está sendo utilizado\n";
            
            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            General.Artista.TipoTrabalho tipoTrabalho = TipoTrabalho.SelectedIndex switch
            {
                0 => General.Artista.TipoTrabalho.Cantor,
                1 => General.Artista.TipoTrabalho.Compositor,
                2 => General.Artista.TipoTrabalho.Ambos,
                _ => throw new IndexOutOfRangeException(),
            };

            // TODO: Gerar codigo

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

                MergeSort.MainMergeSort(Array.ConvertAll(General.Artistas, a => a.Codigo).Where(a => a > 0).ToArray(), 0, Array.ConvertAll(General.Artistas, a => a.Codigo).Where(a => a > 0).ToArray().Length - 1);
            }
            else {
                General.Artistas[Index] = new General.Artista() {
                    Codigo = General.Artistas[Index].Codigo,
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
