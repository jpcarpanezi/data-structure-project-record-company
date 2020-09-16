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
            this.tipoBusca = new System.Windows.Forms.ComboBox();
            this.codeField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchDefine = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridLabel1 = new System.Windows.Forms.Label();
            this.dataGridLabel2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoBusca
            // 
            this.tipoBusca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoBusca.FormattingEnabled = true;
            this.tipoBusca.Items.AddRange(new object[] {
            "Artista",
            "Album",
            "Canção"});
            this.tipoBusca.Location = new System.Drawing.Point(12, 12);
            this.tipoBusca.Name = "tipoBusca";
            this.tipoBusca.Size = new System.Drawing.Size(121, 23);
            this.tipoBusca.TabIndex = 0;
            // 
            // codeField
            // 
            this.codeField.Location = new System.Drawing.Point(139, 12);
            this.codeField.Name = "codeField";
            this.codeField.PlaceholderText = "Digite o código";
            this.codeField.Size = new System.Drawing.Size(568, 23);
            this.codeField.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(713, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchDefine
            // 
            this.searchDefine.AutoSize = true;
            this.searchDefine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDefine.Location = new System.Drawing.Point(12, 55);
            this.searchDefine.Name = "searchDefine";
            this.searchDefine.Size = new System.Drawing.Size(75, 21);
            this.searchDefine.TabIndex = 3;
            this.searchDefine.Text = "Null: Null";
            this.searchDefine.Visible = false;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(595, 55);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(193, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Visualizar todas as informações";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 365);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.Text = "dataGridView2";
            this.dataGridView2.Visible = false;
            // 
            // dataGridLabel1
            // 
            this.dataGridLabel1.AutoSize = true;
            this.dataGridLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridLabel1.Location = new System.Drawing.Point(12, 114);
            this.dataGridLabel1.Name = "dataGridLabel1";
            this.dataGridLabel1.Size = new System.Drawing.Size(49, 21);
            this.dataGridLabel1.TabIndex = 7;
            this.dataGridLabel1.Text = "NULL";
            this.dataGridLabel1.Visible = false;
            // 
            // dataGridLabel2
            // 
            this.dataGridLabel2.AutoSize = true;
            this.dataGridLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridLabel2.Location = new System.Drawing.Point(12, 341);
            this.dataGridLabel2.Name = "dataGridLabel2";
            this.dataGridLabel2.Size = new System.Drawing.Size(49, 21);
            this.dataGridLabel2.TabIndex = 8;
            this.dataGridLabel2.Text = "NULL";
            this.dataGridLabel2.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.Visible = false;
            // 
            // Pesquisar
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.dataGridLabel2);
            this.Controls.Add(this.dataGridLabel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.searchDefine);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.codeField);
            this.Controls.Add(this.tipoBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pesquisar";
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox tipoBusca;
		private System.Windows.Forms.TextBox codeField;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Label searchDefine;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label dataGridLabel1;
		private System.Windows.Forms.Label dataGridLabel2;
	}
}