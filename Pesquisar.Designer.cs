namespace data_structure_project_record_company {
	partial class Pesquisar {
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
            this.TipoBusca = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.BotaoPesquisar = new System.Windows.Forms.Button();
            this.LabelNome = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.LabelGridView1 = new System.Windows.Forms.Label();
            this.LabelGridView2 = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoBusca
            // 
            this.TipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoBusca.FormattingEnabled = true;
            this.TipoBusca.Items.AddRange(new object[] {
            "Artista",
            "Álbum",
            "Canção"});
            this.TipoBusca.Location = new System.Drawing.Point(12, 12);
            this.TipoBusca.Name = "TipoBusca";
            this.TipoBusca.Size = new System.Drawing.Size(121, 23);
            this.TipoBusca.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(139, 12);
            this.Codigo.Name = "Codigo";
            this.Codigo.PlaceholderText = "Digite o código";
            this.Codigo.Size = new System.Drawing.Size(568, 23);
            this.Codigo.TabIndex = 1;
            // 
            // BotaoPesquisar
            // 
            this.BotaoPesquisar.Location = new System.Drawing.Point(713, 12);
            this.BotaoPesquisar.Name = "BotaoPesquisar";
            this.BotaoPesquisar.Size = new System.Drawing.Size(75, 23);
            this.BotaoPesquisar.TabIndex = 2;
            this.BotaoPesquisar.Text = "Pesquisar";
            this.BotaoPesquisar.UseVisualStyleBackColor = true;
            this.BotaoPesquisar.Click += new System.EventHandler(this.BotaoPesquisar_Click);
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelNome.Location = new System.Drawing.Point(12, 55);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(75, 21);
            this.LabelNome.TabIndex = 3;
            this.LabelNome.Text = "Null: Null";
            this.LabelNome.Visible = false;
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(595, 55);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(193, 23);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "Visualizar todas as informações";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Visible = false;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(12, 365);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.ReadOnly = true;
            this.DataGridView2.Size = new System.Drawing.Size(776, 150);
            this.DataGridView2.TabIndex = 6;
            this.DataGridView2.Text = "dataGridView2";
            this.DataGridView2.Visible = false;
            // 
            // LabelGridView1
            // 
            this.LabelGridView1.AutoSize = true;
            this.LabelGridView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelGridView1.Location = new System.Drawing.Point(12, 114);
            this.LabelGridView1.Name = "LabelGridView1";
            this.LabelGridView1.Size = new System.Drawing.Size(49, 21);
            this.LabelGridView1.TabIndex = 7;
            this.LabelGridView1.Text = "NULL";
            this.LabelGridView1.Visible = false;
            // 
            // LabelGridView2
            // 
            this.LabelGridView2.AutoSize = true;
            this.LabelGridView2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelGridView2.Location = new System.Drawing.Point(12, 341);
            this.LabelGridView2.Name = "LabelGridView2";
            this.LabelGridView2.Size = new System.Drawing.Size(49, 21);
            this.LabelGridView2.TabIndex = 8;
            this.LabelGridView2.Text = "NULL";
            this.LabelGridView2.Visible = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 138);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.Size = new System.Drawing.Size(776, 150);
            this.DataGridView1.TabIndex = 5;
            this.DataGridView1.Text = "dataGridView1";
            this.DataGridView1.Visible = false;
            // 
            // Pesquisar
            // 
            this.AcceptButton = this.BotaoPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.LabelGridView2);
            this.Controls.Add(this.LabelGridView1);
            this.Controls.Add(this.DataGridView2);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.LabelNome);
            this.Controls.Add(this.BotaoPesquisar);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.TipoBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pesquisar";
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox TipoBusca;
		private System.Windows.Forms.TextBox Codigo;
		private System.Windows.Forms.Button BotaoPesquisar;
		private System.Windows.Forms.Label LabelNome;
		private System.Windows.Forms.Button Editar;
		private System.Windows.Forms.DataGridView DataGridView1;
		private System.Windows.Forms.DataGridView DataGridView2;
		private System.Windows.Forms.Label LabelGridView1;
		private System.Windows.Forms.Label LabelGridView2;
	}
}