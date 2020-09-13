namespace data_structure_project_record_company
{
    partial class CancaoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Salvar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Titulo = new System.Windows.Forms.TextBox();
            this.Letra = new System.Windows.Forms.RichTextBox();
            this.Melodia = new System.Windows.Forms.RichTextBox();
            this.Compositor = new System.Windows.Forms.ComboBox();
            this.Artista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(371, 415);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 0;
            this.Salvar.Text = "Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Codigo
            // 
            this.Codigo.Location = new System.Drawing.Point(12, 31);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(207, 23);
            this.Codigo.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.Location = new System.Drawing.Point(305, 31);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(483, 23);
            this.Titulo.TabIndex = 2;
            // 
            // Letra
            // 
            this.Letra.Location = new System.Drawing.Point(13, 97);
            this.Letra.Name = "Letra";
            this.Letra.Size = new System.Drawing.Size(387, 228);
            this.Letra.TabIndex = 3;
            this.Letra.Text = "";
            // 
            // Melodia
            // 
            this.Melodia.Location = new System.Drawing.Point(406, 97);
            this.Melodia.Name = "Melodia";
            this.Melodia.Size = new System.Drawing.Size(382, 228);
            this.Melodia.TabIndex = 4;
            this.Melodia.Text = "";
            // 
            // Compositor
            // 
            this.Compositor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compositor.FormattingEnabled = true;
            this.Compositor.Location = new System.Drawing.Point(12, 365);
            this.Compositor.Name = "Compositor";
            this.Compositor.Size = new System.Drawing.Size(388, 23);
            this.Compositor.TabIndex = 5;
            // 
            // Artista
            // 
            this.Artista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Artista.FormattingEnabled = true;
            this.Artista.Location = new System.Drawing.Point(406, 365);
            this.Artista.Name = "Artista";
            this.Artista.Size = new System.Drawing.Size(382, 23);
            this.Artista.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Letra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Melodia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Compositor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Artista ";
            // 
            // CancaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Artista);
            this.Controls.Add(this.Compositor);
            this.Controls.Add(this.Melodia);
            this.Controls.Add(this.Letra);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.Salvar);
            this.Name = "CancaoForm";
            this.Text = "Adicionar Música";
            this.Load += new System.EventHandler(this.CancaoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Titulo;
        private System.Windows.Forms.RichTextBox Letra;
        private System.Windows.Forms.RichTextBox Melodia;
        private System.Windows.Forms.ComboBox Compositor;
        private System.Windows.Forms.ComboBox Artista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}