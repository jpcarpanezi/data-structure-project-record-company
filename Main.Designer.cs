namespace data_structure_project_record_company {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.AlbumAdd = new System.Windows.Forms.Button();
			this.ArtistAdd = new System.Windows.Forms.Button();
			this.SongAdd = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridViewArtistas = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeVerdadeiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeArtistico = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Aniversario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BandaBool = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewAlbuns = new System.Windows.Forms.DataGridView();
			this.CodigoAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TituloAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NumeroCopias = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.Musicas = new System.Windows.Forms.Label();
			this.dataGridViewMusicas = new System.Windows.Forms.DataGridView();
			this.SongCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SongTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.Search = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbuns)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicas)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "music.png");
			this.imageList1.Images.SetKeyName(1, "record-vinyl.png");
			this.imageList1.Images.SetKeyName(2, "search.png");
			this.imageList1.Images.SetKeyName(3, "user-plus.png");
			// 
			// AlbumAdd
			// 
			this.AlbumAdd.ImageIndex = 1;
			this.AlbumAdd.ImageList = this.imageList1;
			this.AlbumAdd.Location = new System.Drawing.Point(130, 12);
			this.AlbumAdd.Name = "AlbumAdd";
			this.AlbumAdd.Size = new System.Drawing.Size(53, 53);
			this.AlbumAdd.TabIndex = 0;
			this.AlbumAdd.UseVisualStyleBackColor = true;
			this.AlbumAdd.Click += new System.EventHandler(this.AlbumAdd_Click);
			// 
			// ArtistAdd
			// 
			this.ArtistAdd.ImageIndex = 3;
			this.ArtistAdd.ImageList = this.imageList1;
			this.ArtistAdd.Location = new System.Drawing.Point(12, 12);
			this.ArtistAdd.Name = "ArtistAdd";
			this.ArtistAdd.Size = new System.Drawing.Size(53, 53);
			this.ArtistAdd.TabIndex = 0;
			this.ArtistAdd.UseVisualStyleBackColor = true;
			this.ArtistAdd.Click += new System.EventHandler(this.ArtistAdd_Click);
			// 
			// SongAdd
			// 
			this.SongAdd.ImageIndex = 0;
			this.SongAdd.ImageList = this.imageList1;
			this.SongAdd.Location = new System.Drawing.Point(71, 12);
			this.SongAdd.Name = "SongAdd";
			this.SongAdd.Size = new System.Drawing.Size(53, 53);
			this.SongAdd.TabIndex = 1;
			this.SongAdd.UseVisualStyleBackColor = true;
			this.SongAdd.Click += new System.EventHandler(this.SongAdd_Click);
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.dataGridViewArtistas);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dataGridViewAlbuns);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Musicas);
			this.panel1.Controls.Add(this.dataGridViewMusicas);
			this.panel1.Location = new System.Drawing.Point(12, 86);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(789, 890);
			this.panel1.TabIndex = 2;
			// 
			// dataGridViewArtistas
			// 
			this.dataGridViewArtistas.AllowUserToAddRows = false;
			this.dataGridViewArtistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewArtistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NomeVerdadeiro,
            this.NomeArtistico,
            this.Aniversario,
            this.BandaBool});
			this.dataGridViewArtistas.Location = new System.Drawing.Point(0, 636);
			this.dataGridViewArtistas.Name = "dataGridViewArtistas";
			this.dataGridViewArtistas.Size = new System.Drawing.Size(760, 251);
			this.dataGridViewArtistas.TabIndex = 0;
			this.dataGridViewArtistas.Text = "dataGridView3";
			this.dataGridViewArtistas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArtistas_CellContentClick);
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			// 
			// NomeVerdadeiro
			// 
			this.NomeVerdadeiro.HeaderText = "Nome Verdadeiro";
			this.NomeVerdadeiro.Name = "NomeVerdadeiro";
			// 
			// NomeArtistico
			// 
			this.NomeArtistico.HeaderText = "Nome Artístico";
			this.NomeArtistico.Name = "NomeArtistico";
			// 
			// Aniversario
			// 
			this.Aniversario.HeaderText = "Data de Aniversário";
			this.Aniversario.Name = "Aniversario";
			// 
			// BandaBool
			// 
			this.BandaBool.HeaderText = "Faz parte de uma banda?";
			this.BandaBool.Name = "BandaBool";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(3, 609);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Artistas";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// dataGridViewAlbuns
			// 
			this.dataGridViewAlbuns.AllowUserToAddRows = false;
			this.dataGridViewAlbuns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAlbuns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoAlbum,
            this.TituloAlbum,
            this.DataLancamento,
            this.NumeroCopias});
			this.dataGridViewAlbuns.Location = new System.Drawing.Point(1, 330);
			this.dataGridViewAlbuns.Name = "dataGridViewAlbuns";
			this.dataGridViewAlbuns.Size = new System.Drawing.Size(760, 251);
			this.dataGridViewAlbuns.TabIndex = 0;
			this.dataGridViewAlbuns.Text = "dataGridView2";
			// 
			// CodigoAlbum
			// 
			this.CodigoAlbum.HeaderText = "Código";
			this.CodigoAlbum.Name = "CodigoAlbum";
			// 
			// TituloAlbum
			// 
			this.TituloAlbum.HeaderText = "Título";
			this.TituloAlbum.Name = "TituloAlbum";
			this.TituloAlbum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// DataLancamento
			// 
			this.DataLancamento.HeaderText = "Data de Lançamento";
			this.DataLancamento.Name = "DataLancamento";
			// 
			// NumeroCopias
			// 
			this.NumeroCopias.HeaderText = "Número de Cópias Vendidas";
			this.NumeroCopias.Name = "NumeroCopias";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(4, 303);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(58, 21);
			this.label1.TabIndex = 1;
			this.label1.Text = "Álbuns";
			// 
			// Musicas
			// 
			this.Musicas.AutoSize = true;
			this.Musicas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Musicas.Location = new System.Drawing.Point(3, 4);
			this.Musicas.Name = "Musicas";
			this.Musicas.Size = new System.Drawing.Size(66, 21);
			this.Musicas.TabIndex = 1;
			this.Musicas.Text = "Músicas";
			// 
			// dataGridViewMusicas
			// 
			this.dataGridViewMusicas.AllowUserToAddRows = false;
			this.dataGridViewMusicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMusicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongCodigo,
            this.SongTitulo});
			this.dataGridViewMusicas.Location = new System.Drawing.Point(0, 31);
			this.dataGridViewMusicas.Name = "dataGridViewMusicas";
			this.dataGridViewMusicas.Size = new System.Drawing.Size(760, 251);
			this.dataGridViewMusicas.TabIndex = 0;
			this.dataGridViewMusicas.Text = "dataGridView1";
			// 
			// SongCodigo
			// 
			this.SongCodigo.HeaderText = "Código";
			this.SongCodigo.Name = "SongCodigo";
			this.SongCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// SongTitulo
			// 
			this.SongTitulo.HeaderText = "Título";
			this.SongTitulo.Name = "SongTitulo";
			this.SongTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// Search
			// 
			this.Search.ImageIndex = 2;
			this.Search.ImageList = this.imageList1;
			this.Search.Location = new System.Drawing.Point(189, 12);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(53, 53);
			this.Search.TabIndex = 0;
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 961);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.SongAdd);
			this.Controls.Add(this.ArtistAdd);
			this.Controls.Add(this.AlbumAdd);
			this.Name = "Main";
			this.Text = "Recorder";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Main_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtistas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbuns)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusicas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button AlbumAdd;
        private System.Windows.Forms.Button ArtistAdd;
        private System.Windows.Forms.Button SongAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMusicas;
        private System.Windows.Forms.DataGridView dataGridViewArtistas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAlbuns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Musicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCopias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeVerdadeiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeArtistico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aniversario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaBool;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button Search;
    }
}