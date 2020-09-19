namespace data_structure_project_record_company {
    partial class ArtistaForm {
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArtistaForm));
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.Codigo = new System.Windows.Forms.TextBox();
			this.NomeVerdadeiro = new System.Windows.Forms.TextBox();
			this.NomeArtistico = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.DataAniversario = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BandaSN = new System.Windows.Forms.CheckBox();
			this.Banda = new System.Windows.Forms.TextBox();
			this.Email = new System.Windows.Forms.TextBox();
			this.Telefone = new System.Windows.Forms.TextBox();
			this.NomeEmpresario = new System.Windows.Forms.TextBox();
			this.EmailEmpresario = new System.Windows.Forms.TextBox();
			this.NAlbunsLancados = new System.Windows.Forms.TextBox();
			this.NComposicoes = new System.Windows.Forms.TextBox();
			this.CacheMinimo = new System.Windows.Forms.TextBox();
			this.TipoTrabalho = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.Salvar = new System.Windows.Forms.Button();
			this.Remover = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Codigo
			// 
			this.Codigo.Location = new System.Drawing.Point(12, 34);
			this.Codigo.Name = "Codigo";
			this.Codigo.PlaceholderText = "Insira o código";
			this.Codigo.Size = new System.Drawing.Size(188, 23);
			this.Codigo.TabIndex = 0;
			// 
			// NomeVerdadeiro
			// 
			this.NomeVerdadeiro.Location = new System.Drawing.Point(242, 34);
			this.NomeVerdadeiro.Name = "NomeVerdadeiro";
			this.NomeVerdadeiro.PlaceholderText = "Insira o nome completo";
			this.NomeVerdadeiro.Size = new System.Drawing.Size(237, 23);
			this.NomeVerdadeiro.TabIndex = 1;
			// 
			// NomeArtistico
			// 
			this.NomeArtistico.Location = new System.Drawing.Point(518, 34);
			this.NomeArtistico.Name = "NomeArtistico";
			this.NomeArtistico.PlaceholderText = "Insira o nome artistico";
			this.NomeArtistico.Size = new System.Drawing.Size(270, 23);
			this.NomeArtistico.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Código";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(99, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nome Verdadeiro";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(518, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nome Artístico";
			// 
			// DataAniversario
			// 
			this.DataAniversario.Location = new System.Drawing.Point(12, 100);
			this.DataAniversario.Name = "DataAniversario";
			this.DataAniversario.PlaceholderText = "dd/mm/YYYY";
			this.DataAniversario.Size = new System.Drawing.Size(188, 23);
			this.DataAniversario.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Data de Aniversário";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(518, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Banda";
			// 
			// BandaSN
			// 
			this.BandaSN.AutoSize = true;
			this.BandaSN.Location = new System.Drawing.Point(242, 100);
			this.BandaSN.Name = "BandaSN";
			this.BandaSN.Size = new System.Drawing.Size(156, 19);
			this.BandaSN.TabIndex = 9;
			this.BandaSN.Text = "Participa de uma banda?";
			this.BandaSN.UseVisualStyleBackColor = true;
			this.BandaSN.CheckedChanged += new System.EventHandler(this.BandaSN_CheckedChanged);
			// 
			// Banda
			// 
			this.Banda.Enabled = false;
			this.Banda.Location = new System.Drawing.Point(518, 98);
			this.Banda.Name = "Banda";
			this.Banda.PlaceholderText = "Insira o nome da banda";
			this.Banda.Size = new System.Drawing.Size(270, 23);
			this.Banda.TabIndex = 10;
			// 
			// Email
			// 
			this.Email.Location = new System.Drawing.Point(12, 165);
			this.Email.Name = "Email";
			this.Email.PlaceholderText = "artista@exemplo.com";
			this.Email.Size = new System.Drawing.Size(188, 23);
			this.Email.TabIndex = 11;
			// 
			// Telefone
			// 
			this.Telefone.Location = new System.Drawing.Point(241, 165);
			this.Telefone.Name = "Telefone";
			this.Telefone.PlaceholderText = "(00) 90000-0000";
			this.Telefone.Size = new System.Drawing.Size(238, 23);
			this.Telefone.TabIndex = 12;
			// 
			// NomeEmpresario
			// 
			this.NomeEmpresario.Location = new System.Drawing.Point(12, 223);
			this.NomeEmpresario.Name = "NomeEmpresario";
			this.NomeEmpresario.PlaceholderText = "Insira o nome do empresário";
			this.NomeEmpresario.Size = new System.Drawing.Size(188, 23);
			this.NomeEmpresario.TabIndex = 13;
			// 
			// EmailEmpresario
			// 
			this.EmailEmpresario.Location = new System.Drawing.Point(241, 223);
			this.EmailEmpresario.Name = "EmailEmpresario";
			this.EmailEmpresario.PlaceholderText = "empresario@exemplo.com";
			this.EmailEmpresario.Size = new System.Drawing.Size(238, 23);
			this.EmailEmpresario.TabIndex = 14;
			// 
			// NAlbunsLancados
			// 
			this.NAlbunsLancados.Location = new System.Drawing.Point(12, 286);
			this.NAlbunsLancados.Name = "NAlbunsLancados";
			this.NAlbunsLancados.PlaceholderText = "Insira o número de álbuns";
			this.NAlbunsLancados.Size = new System.Drawing.Size(188, 23);
			this.NAlbunsLancados.TabIndex = 16;
			// 
			// NComposicoes
			// 
			this.NComposicoes.Location = new System.Drawing.Point(242, 286);
			this.NComposicoes.Name = "NComposicoes";
			this.NComposicoes.PlaceholderText = "Insira o número de composições";
			this.NComposicoes.Size = new System.Drawing.Size(237, 23);
			this.NComposicoes.TabIndex = 17;
			// 
			// CacheMinimo
			// 
			this.CacheMinimo.Location = new System.Drawing.Point(518, 286);
			this.CacheMinimo.Name = "CacheMinimo";
			this.CacheMinimo.PlaceholderText = "Insira o cache mínimo";
			this.CacheMinimo.Size = new System.Drawing.Size(270, 23);
			this.CacheMinimo.TabIndex = 18;
			// 
			// TipoTrabalho
			// 
			this.TipoTrabalho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TipoTrabalho.FormattingEnabled = true;
			this.TipoTrabalho.Items.AddRange(new object[] {
            "Cantor",
            "Compositor",
            "Ambos"});
			this.TipoTrabalho.Location = new System.Drawing.Point(518, 223);
			this.TipoTrabalho.Name = "TipoTrabalho";
			this.TipoTrabalho.Size = new System.Drawing.Size(270, 23);
			this.TipoTrabalho.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(241, 147);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 15);
			this.label7.TabIndex = 20;
			this.label7.Text = "Telefone";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 205);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(119, 15);
			this.label8.TabIndex = 21;
			this.label8.Text = "Nome do Empresário";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(242, 205);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(115, 15);
			this.label9.TabIndex = 22;
			this.label9.Text = "Email do Empresário";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(518, 205);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(94, 15);
			this.label10.TabIndex = 23;
			this.label10.Text = "Tipo de Trabalho";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(12, 268);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(160, 15);
			this.label11.TabIndex = 24;
			this.label11.Text = "Número de Álbuns Lançados";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(241, 268);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(142, 15);
			this.label12.TabIndex = 25;
			this.label12.Text = "Número de Composições";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(518, 268);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(85, 15);
			this.label13.TabIndex = 26;
			this.label13.Text = "Cache Mínimo";
			// 
			// Salvar
			// 
			this.Salvar.Location = new System.Drawing.Point(331, 351);
			this.Salvar.Name = "Salvar";
			this.Salvar.Size = new System.Drawing.Size(75, 23);
			this.Salvar.TabIndex = 27;
			this.Salvar.Text = "Salvar";
			this.Salvar.UseVisualStyleBackColor = true;
			this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
			// 
			// Remover
			// 
			this.Remover.Location = new System.Drawing.Point(413, 351);
			this.Remover.Name = "Remover";
			this.Remover.Size = new System.Drawing.Size(75, 23);
			this.Remover.TabIndex = 28;
			this.Remover.Text = "Remover";
			this.Remover.UseVisualStyleBackColor = true;
			this.Remover.Click += new System.EventHandler(this.Remover_Click);
			// 
			// ArtistaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(810, 390);
			this.Controls.Add(this.Remover);
			this.Controls.Add(this.Salvar);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TipoTrabalho);
			this.Controls.Add(this.CacheMinimo);
			this.Controls.Add(this.NComposicoes);
			this.Controls.Add(this.NAlbunsLancados);
			this.Controls.Add(this.EmailEmpresario);
			this.Controls.Add(this.NomeEmpresario);
			this.Controls.Add(this.Telefone);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.Banda);
			this.Controls.Add(this.BandaSN);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.DataAniversario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NomeArtistico);
			this.Controls.Add(this.NomeVerdadeiro);
			this.Controls.Add(this.Codigo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ArtistaForm";
			this.Text = "Adicionar Artista";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox NomeVerdadeiro;
        private System.Windows.Forms.TextBox NomeArtistico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DataAniversario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox BandaSN;
        private System.Windows.Forms.TextBox Banda;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.TextBox NomeEmpresario;
        private System.Windows.Forms.TextBox EmailEmpresario;
        private System.Windows.Forms.TextBox NAlbunsLancados;
        private System.Windows.Forms.TextBox NComposicoes;
        private System.Windows.Forms.TextBox CacheMinimo;
        private System.Windows.Forms.ComboBox TipoTrabalho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Remover;
    }
}