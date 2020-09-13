using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace data_structure_project_record_company {
    public partial class CancaoForm : Form {
        private int Index { get; set; }
        private List<int> RefCodes = new List<int>();

        public CancaoForm() {
            InitializeComponent();

            Index = -1;
        }

        public CancaoForm(int index) {
            InitializeComponent();
            Codigo.Enabled = false;

            Index = index;
        }

        private void CancaoForm_Load(object sender, EventArgs e) {

            if (General.CancoesSize >= General.MaxSize) {
                MessageBox.Show("O limite de espaço para canções foi atingido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (General.ArtistasSize == 0) {
                MessageBox.Show("É necessário cadastrar ao menos um artista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            for (int i = 0; i < General.ArtistasSize; i++) {
                RefCodes.Add(General.Artistas[i].Codigo);
                Compositor.Items.Add(General.Artistas[i].NomeArtistico);
                Artista.Items.Add(General.Artistas[i].NomeArtistico);
            }

            if (Index != -1) {
                General.Cancao cancaoTemp = General.Cancoes[Index];
                Codigo.Text = cancaoTemp.Codigo.ToString();
                Titulo.Text = cancaoTemp.Titulo;
                Letra.Text = cancaoTemp.Letra;
                Melodia.Text = cancaoTemp.Melodia;
                Compositor.SelectedIndex = BinarySearch.BinarySearchDisplay(RefCodes, cancaoTemp.CodigoCompositor);
                Artista.SelectedIndex = BinarySearch.BinarySearchDisplay(RefCodes, cancaoTemp.CodigoArtistaPrimeiraGravacao);
            }
        }

        private void Salvar_Click(object sender, EventArgs e) {
            string erro = "";

            if (!int.TryParse(Codigo.Text, out int codigo) && Codigo.Text != "")
                erro += "- O código precisa ser um número\n";

            if(codigo <= 0 && Codigo.Text != "")
                erro += "- O código precisa ser maior que zero\n";

            if (Titulo.Text == "" || Letra.Text == "" || Melodia.Text == "" || Compositor.SelectedIndex == -1 || Artista.SelectedIndex == -1)
                erro += "- Todos os campos precisam ser prenchidos com excessão do código\n";

            if (erro != "") {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Codigo.Text == "") {
                if (General.CancoesSize == 0)
                    codigo = 1;
                else
                    codigo = General.Cancoes[General.CancoesSize - 1].Codigo + 1;
            }

            if (Index == -1) {
                General.Cancoes[General.CancoesSize++] = new General.Cancao() {
                    Codigo = codigo,
                    Titulo = Titulo.Text,
                    Letra = Letra.Text,
                    Melodia = Melodia.Text,
                    CodigoCompositor = RefCodes[Compositor.SelectedIndex],
                    CodigoArtistaPrimeiraGravacao = RefCodes[Artista.SelectedIndex]
                };

                MergeSort.Sort(General.Cancoes, Array.ConvertAll(General.Cancoes, a => a.Codigo).Where(a => a > 0).ToArray());
            }
            else {
                General.Cancoes[Index] = new General.Cancao() {
                    Codigo = General.Cancoes[Index].Codigo, // Codigo nao pode ser alterado
                    Titulo = Titulo.Text,
                    Letra = Letra.Text,
                    Melodia = Melodia.Text,
                    CodigoCompositor = RefCodes[Compositor.SelectedIndex],
                    CodigoArtistaPrimeiraGravacao = RefCodes[Artista.SelectedIndex]
                };
            }

            Program.globalForm.UpdateRows(Main.DataGrid.Musicas);
            Close();
        }
    }

}
