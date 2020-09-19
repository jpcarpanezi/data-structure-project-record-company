namespace data_structure_project_record_company {
    partial class Relatorios {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorios));
			this.MesDesejado = new System.Windows.Forms.TextBox();
			this.PesquisarMes = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.LabelMes = new System.Windows.Forms.Label();
			this.LabelGridView = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// MesDesejado
			// 
			this.MesDesejado.Location = new System.Drawing.Point(13, 30);
			this.MesDesejado.Name = "MesDesejado";
			this.MesDesejado.Size = new System.Drawing.Size(195, 23);
			this.MesDesejado.TabIndex = 0;
			// 
			// PesquisarMes
			// 
			this.PesquisarMes.Location = new System.Drawing.Point(214, 30);
			this.PesquisarMes.Name = "PesquisarMes";
			this.PesquisarMes.Size = new System.Drawing.Size(75, 23);
			this.PesquisarMes.TabIndex = 1;
			this.PesquisarMes.Text = "Pesquisar";
			this.PesquisarMes.UseVisualStyleBackColor = true;
			this.PesquisarMes.Click += new System.EventHandler(this.PesquisarMes_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(13, 107);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(775, 331);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.Text = "dataGridView1";
			// 
			// LabelMes
			// 
			this.LabelMes.AutoSize = true;
			this.LabelMes.Location = new System.Drawing.Point(13, 12);
			this.LabelMes.Name = "LabelMes";
			this.LabelMes.Size = new System.Drawing.Size(79, 15);
			this.LabelMes.TabIndex = 3;
			this.LabelMes.Text = "Mês desejado";
			// 
			// LabelGridView
			// 
			this.LabelGridView.AutoSize = true;
			this.LabelGridView.Location = new System.Drawing.Point(13, 89);
			this.LabelGridView.Name = "LabelGridView";
			this.LabelGridView.Size = new System.Drawing.Size(77, 15);
			this.LabelGridView.TabIndex = 4;
			this.LabelGridView.Text = "dataGridView";
			// 
			// Relatorios
			// 
			this.AcceptButton = this.PesquisarMes;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LabelGridView);
			this.Controls.Add(this.LabelMes);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.PesquisarMes);
			this.Controls.Add(this.MesDesejado);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Relatorios";
			this.Text = "Relatorios";
			this.Load += new System.EventHandler(this.Relatorios_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MesDesejado;
        private System.Windows.Forms.Button PesquisarMes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LabelMes;
        private System.Windows.Forms.Label LabelGridView;
    }
}