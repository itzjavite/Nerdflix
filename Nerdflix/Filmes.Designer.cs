namespace Nerdflix
{
    partial class Filmes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmes));
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbNotaApagar = new System.Windows.Forms.ComboBox();
            this.lblNotaApagarF = new System.Windows.Forms.Label();
            this.txbTituloApagar = new System.Windows.Forms.TextBox();
            this.lblTituloApagarF = new System.Windows.Forms.Label();
            this.grbCadastrarFilmes = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbNotaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblNotaCadastrarF = new System.Windows.Forms.Label();
            this.txbTituloCadastrar = new System.Windows.Forms.TextBox();
            this.lblTituloCadastrarF = new System.Windows.Forms.Label();
            this.lblTituloFilmes = new System.Windows.Forms.Label();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.grbApagar.SuspendLayout();
            this.grbCadastrarFilmes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.cmbNotaApagar);
            this.grbApagar.Controls.Add(this.lblNotaApagarF);
            this.grbApagar.Controls.Add(this.txbTituloApagar);
            this.grbApagar.Controls.Add(this.lblTituloApagarF);
            this.grbApagar.ForeColor = System.Drawing.Color.White;
            this.grbApagar.Location = new System.Drawing.Point(653, 354);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(404, 249);
            this.grbApagar.TabIndex = 7;
            this.grbApagar.TabStop = false;
            this.grbApagar.Text = "Apagar";
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Firebrick;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(40, 185);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(316, 40);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click_1);
            // 
            // cmbNotaApagar
            // 
            this.cmbNotaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotaApagar.FormattingEnabled = true;
            this.cmbNotaApagar.Location = new System.Drawing.Point(104, 112);
            this.cmbNotaApagar.Name = "cmbNotaApagar";
            this.cmbNotaApagar.Size = new System.Drawing.Size(252, 50);
            this.cmbNotaApagar.TabIndex = 5;
            // 
            // lblNotaApagarF
            // 
            this.lblNotaApagarF.AutoSize = true;
            this.lblNotaApagarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaApagarF.Location = new System.Drawing.Point(35, 130);
            this.lblNotaApagarF.Name = "lblNotaApagarF";
            this.lblNotaApagarF.Size = new System.Drawing.Size(63, 25);
            this.lblNotaApagarF.TabIndex = 4;
            this.lblNotaApagarF.Text = "Nota:";
            // 
            // txbTituloApagar
            // 
            this.txbTituloApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloApagar.Location = new System.Drawing.Point(104, 56);
            this.txbTituloApagar.Name = "txbTituloApagar";
            this.txbTituloApagar.Size = new System.Drawing.Size(252, 26);
            this.txbTituloApagar.TabIndex = 1;
            // 
            // lblTituloApagarF
            // 
            this.lblTituloApagarF.AutoSize = true;
            this.lblTituloApagarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApagarF.Location = new System.Drawing.Point(27, 59);
            this.lblTituloApagarF.Name = "lblTituloApagarF";
            this.lblTituloApagarF.Size = new System.Drawing.Size(71, 25);
            this.lblTituloApagarF.TabIndex = 0;
            this.lblTituloApagarF.Text = "Título:";
            // 
            // grbCadastrarFilmes
            // 
            this.grbCadastrarFilmes.Controls.Add(this.btnCadastrar);
            this.grbCadastrarFilmes.Controls.Add(this.cmbNotaCadastrar);
            this.grbCadastrarFilmes.Controls.Add(this.lblNotaCadastrarF);
            this.grbCadastrarFilmes.Controls.Add(this.txbTituloCadastrar);
            this.grbCadastrarFilmes.Controls.Add(this.lblTituloCadastrarF);
            this.grbCadastrarFilmes.ForeColor = System.Drawing.Color.White;
            this.grbCadastrarFilmes.Location = new System.Drawing.Point(88, 354);
            this.grbCadastrarFilmes.Name = "grbCadastrarFilmes";
            this.grbCadastrarFilmes.Size = new System.Drawing.Size(404, 249);
            this.grbCadastrarFilmes.TabIndex = 6;
            this.grbCadastrarFilmes.TabStop = false;
            this.grbCadastrarFilmes.Text = "Cadastrar";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(40, 185);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(316, 40);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cmbNotaCadastrar
            // 
            this.cmbNotaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotaCadastrar.FormattingEnabled = true;
            this.cmbNotaCadastrar.Items.AddRange(new object[] {
            "⭐",
            "⭐⭐",
            "⭐⭐⭐",
            "⭐⭐⭐⭐",
            "⭐⭐⭐⭐⭐"});
            this.cmbNotaCadastrar.Location = new System.Drawing.Point(112, 112);
            this.cmbNotaCadastrar.Name = "cmbNotaCadastrar";
            this.cmbNotaCadastrar.Size = new System.Drawing.Size(244, 50);
            this.cmbNotaCadastrar.TabIndex = 5;
            // 
            // lblNotaCadastrarF
            // 
            this.lblNotaCadastrarF.AutoSize = true;
            this.lblNotaCadastrarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCadastrarF.Location = new System.Drawing.Point(35, 129);
            this.lblNotaCadastrarF.Name = "lblNotaCadastrarF";
            this.lblNotaCadastrarF.Size = new System.Drawing.Size(63, 25);
            this.lblNotaCadastrarF.TabIndex = 4;
            this.lblNotaCadastrarF.Text = "Nota:";
            // 
            // txbTituloCadastrar
            // 
            this.txbTituloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloCadastrar.Location = new System.Drawing.Point(112, 58);
            this.txbTituloCadastrar.Name = "txbTituloCadastrar";
            this.txbTituloCadastrar.Size = new System.Drawing.Size(244, 26);
            this.txbTituloCadastrar.TabIndex = 1;
            // 
            // lblTituloCadastrarF
            // 
            this.lblTituloCadastrarF.AutoSize = true;
            this.lblTituloCadastrarF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarF.Location = new System.Drawing.Point(35, 59);
            this.lblTituloCadastrarF.Name = "lblTituloCadastrarF";
            this.lblTituloCadastrarF.Size = new System.Drawing.Size(71, 25);
            this.lblTituloCadastrarF.TabIndex = 0;
            this.lblTituloCadastrarF.Text = "Título:";
            // 
            // lblTituloFilmes
            // 
            this.lblTituloFilmes.AutoSize = true;
            this.lblTituloFilmes.BackColor = System.Drawing.Color.Black;
            this.lblTituloFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFilmes.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTituloFilmes.Location = new System.Drawing.Point(485, 19);
            this.lblTituloFilmes.Name = "lblTituloFilmes";
            this.lblTituloFilmes.Size = new System.Drawing.Size(152, 42);
            this.lblTituloFilmes.TabIndex = 5;
            this.lblTituloFilmes.Text = "FILMES";
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(18, 73);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.ReadOnly = true;
            this.dgvFilmes.Size = new System.Drawing.Size(1107, 263);
            this.dgvFilmes.TabIndex = 4;
            // 
            // Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1142, 625);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastrarFilmes);
            this.Controls.Add(this.lblTituloFilmes);
            this.Controls.Add(this.dgvFilmes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Filmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmes";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastrarFilmes.ResumeLayout(false);
            this.grbCadastrarFilmes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbNotaApagar;
        private System.Windows.Forms.Label lblNotaApagarF;
        private System.Windows.Forms.TextBox txbTituloApagar;
        private System.Windows.Forms.Label lblTituloApagarF;
        private System.Windows.Forms.GroupBox grbCadastrarFilmes;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbNotaCadastrar;
        private System.Windows.Forms.Label lblNotaCadastrarF;
        private System.Windows.Forms.TextBox txbTituloCadastrar;
        private System.Windows.Forms.Label lblTituloCadastrarF;
        private System.Windows.Forms.Label lblTituloFilmes;
        private System.Windows.Forms.DataGridView dgvFilmes;
    }
}