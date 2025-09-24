namespace Nerdflix
{
    partial class Livros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Livros));
            this.grbApagarLivros = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbNotaApagar = new System.Windows.Forms.ComboBox();
            this.lblNotaApagarL = new System.Windows.Forms.Label();
            this.cmbCategoriaApagar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaApagarL = new System.Windows.Forms.Label();
            this.txbTituloApagar = new System.Windows.Forms.TextBox();
            this.lblTituloApagarL = new System.Windows.Forms.Label();
            this.grbCadastrarLivros = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbNotaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblNotaCadastrarL = new System.Windows.Forms.Label();
            this.cmbCategoriaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblCategoriaCadastrarL = new System.Windows.Forms.Label();
            this.txbTituloCadastrar = new System.Windows.Forms.TextBox();
            this.lblTituloCadastrarL = new System.Windows.Forms.Label();
            this.lblTituloLivros = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.grbApagarLivros.SuspendLayout();
            this.grbCadastrarLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagarLivros
            // 
            this.grbApagarLivros.Controls.Add(this.btnApagar);
            this.grbApagarLivros.Controls.Add(this.cmbNotaApagar);
            this.grbApagarLivros.Controls.Add(this.lblNotaApagarL);
            this.grbApagarLivros.Controls.Add(this.cmbCategoriaApagar);
            this.grbApagarLivros.Controls.Add(this.lblCategoriaApagarL);
            this.grbApagarLivros.Controls.Add(this.txbTituloApagar);
            this.grbApagarLivros.Controls.Add(this.lblTituloApagarL);
            this.grbApagarLivros.ForeColor = System.Drawing.Color.White;
            this.grbApagarLivros.Location = new System.Drawing.Point(647, 367);
            this.grbApagarLivros.Name = "grbApagarLivros";
            this.grbApagarLivros.Size = new System.Drawing.Size(404, 249);
            this.grbApagarLivros.TabIndex = 7;
            this.grbApagarLivros.TabStop = false;
            this.grbApagarLivros.Text = "Apagar";
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
            // 
            // cmbNotaApagar
            // 
            this.cmbNotaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotaApagar.FormattingEnabled = true;
            this.cmbNotaApagar.Location = new System.Drawing.Point(124, 131);
            this.cmbNotaApagar.Name = "cmbNotaApagar";
            this.cmbNotaApagar.Size = new System.Drawing.Size(232, 28);
            this.cmbNotaApagar.TabIndex = 5;
            // 
            // lblNotaApagarL
            // 
            this.lblNotaApagarL.AutoSize = true;
            this.lblNotaApagarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaApagarL.Location = new System.Drawing.Point(67, 134);
            this.lblNotaApagarL.Name = "lblNotaApagarL";
            this.lblNotaApagarL.Size = new System.Drawing.Size(47, 20);
            this.lblNotaApagarL.TabIndex = 4;
            this.lblNotaApagarL.Text = "Nota:";
            // 
            // cmbCategoriaApagar
            // 
            this.cmbCategoriaApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaApagar.FormattingEnabled = true;
            this.cmbCategoriaApagar.Location = new System.Drawing.Point(124, 77);
            this.cmbCategoriaApagar.Name = "cmbCategoriaApagar";
            this.cmbCategoriaApagar.Size = new System.Drawing.Size(232, 28);
            this.cmbCategoriaApagar.TabIndex = 3;
            // 
            // lblCategoriaApagarL
            // 
            this.lblCategoriaApagarL.AutoSize = true;
            this.lblCategoriaApagarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaApagarL.Location = new System.Drawing.Point(36, 80);
            this.lblCategoriaApagarL.Name = "lblCategoriaApagarL";
            this.lblCategoriaApagarL.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaApagarL.TabIndex = 2;
            this.lblCategoriaApagarL.Text = "Categoria:";
            // 
            // txbTituloApagar
            // 
            this.txbTituloApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloApagar.Location = new System.Drawing.Point(124, 30);
            this.txbTituloApagar.Name = "txbTituloApagar";
            this.txbTituloApagar.Size = new System.Drawing.Size(232, 26);
            this.txbTituloApagar.TabIndex = 1;
            // 
            // lblTituloApagarL
            // 
            this.lblTituloApagarL.AutoSize = true;
            this.lblTituloApagarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApagarL.Location = new System.Drawing.Point(67, 33);
            this.lblTituloApagarL.Name = "lblTituloApagarL";
            this.lblTituloApagarL.Size = new System.Drawing.Size(51, 20);
            this.lblTituloApagarL.TabIndex = 0;
            this.lblTituloApagarL.Text = "Título:";
            // 
            // grbCadastrarLivros
            // 
            this.grbCadastrarLivros.Controls.Add(this.btnCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.cmbNotaCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.lblNotaCadastrarL);
            this.grbCadastrarLivros.Controls.Add(this.cmbCategoriaCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.lblCategoriaCadastrarL);
            this.grbCadastrarLivros.Controls.Add(this.txbTituloCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.lblTituloCadastrarL);
            this.grbCadastrarLivros.ForeColor = System.Drawing.Color.White;
            this.grbCadastrarLivros.Location = new System.Drawing.Point(82, 367);
            this.grbCadastrarLivros.Name = "grbCadastrarLivros";
            this.grbCadastrarLivros.Size = new System.Drawing.Size(404, 249);
            this.grbCadastrarLivros.TabIndex = 6;
            this.grbCadastrarLivros.TabStop = false;
            this.grbCadastrarLivros.Text = "Cadastrar";
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
            // 
            // cmbNotaCadastrar
            // 
            this.cmbNotaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNotaCadastrar.FormattingEnabled = true;
            this.cmbNotaCadastrar.Location = new System.Drawing.Point(124, 131);
            this.cmbNotaCadastrar.Name = "cmbNotaCadastrar";
            this.cmbNotaCadastrar.Size = new System.Drawing.Size(232, 28);
            this.cmbNotaCadastrar.TabIndex = 5;
            // 
            // lblNotaCadastrarL
            // 
            this.lblNotaCadastrarL.AutoSize = true;
            this.lblNotaCadastrarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCadastrarL.Location = new System.Drawing.Point(67, 134);
            this.lblNotaCadastrarL.Name = "lblNotaCadastrarL";
            this.lblNotaCadastrarL.Size = new System.Drawing.Size(47, 20);
            this.lblNotaCadastrarL.TabIndex = 4;
            this.lblNotaCadastrarL.Text = "Nota:";
            // 
            // cmbCategoriaCadastrar
            // 
            this.cmbCategoriaCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoriaCadastrar.FormattingEnabled = true;
            this.cmbCategoriaCadastrar.Location = new System.Drawing.Point(124, 77);
            this.cmbCategoriaCadastrar.Name = "cmbCategoriaCadastrar";
            this.cmbCategoriaCadastrar.Size = new System.Drawing.Size(232, 28);
            this.cmbCategoriaCadastrar.TabIndex = 3;
            // 
            // lblCategoriaCadastrarL
            // 
            this.lblCategoriaCadastrarL.AutoSize = true;
            this.lblCategoriaCadastrarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaCadastrarL.Location = new System.Drawing.Point(36, 80);
            this.lblCategoriaCadastrarL.Name = "lblCategoriaCadastrarL";
            this.lblCategoriaCadastrarL.Size = new System.Drawing.Size(82, 20);
            this.lblCategoriaCadastrarL.TabIndex = 2;
            this.lblCategoriaCadastrarL.Text = "Categoria:";
            // 
            // txbTituloCadastrar
            // 
            this.txbTituloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloCadastrar.Location = new System.Drawing.Point(124, 30);
            this.txbTituloCadastrar.Name = "txbTituloCadastrar";
            this.txbTituloCadastrar.Size = new System.Drawing.Size(232, 26);
            this.txbTituloCadastrar.TabIndex = 1;
            // 
            // lblTituloCadastrarL
            // 
            this.lblTituloCadastrarL.AutoSize = true;
            this.lblTituloCadastrarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarL.Location = new System.Drawing.Point(67, 33);
            this.lblTituloCadastrarL.Name = "lblTituloCadastrarL";
            this.lblTituloCadastrarL.Size = new System.Drawing.Size(51, 20);
            this.lblTituloCadastrarL.TabIndex = 0;
            this.lblTituloCadastrarL.Text = "Título:";
            // 
            // lblTituloLivros
            // 
            this.lblTituloLivros.AutoSize = true;
            this.lblTituloLivros.BackColor = System.Drawing.Color.Black;
            this.lblTituloLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLivros.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTituloLivros.Location = new System.Drawing.Point(489, 25);
            this.lblTituloLivros.Name = "lblTituloLivros";
            this.lblTituloLivros.Size = new System.Drawing.Size(154, 42);
            this.lblTituloLivros.TabIndex = 5;
            this.lblTituloLivros.Text = "LIVROS";
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Location = new System.Drawing.Point(12, 86);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.Size = new System.Drawing.Size(1107, 263);
            this.dgvLivros.TabIndex = 4;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 641);
            this.Controls.Add(this.grbApagarLivros);
            this.Controls.Add(this.grbCadastrarLivros);
            this.Controls.Add(this.lblTituloLivros);
            this.Controls.Add(this.dgvLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Livros";
            this.Text = "Livros";
            this.grbApagarLivros.ResumeLayout(false);
            this.grbApagarLivros.PerformLayout();
            this.grbCadastrarLivros.ResumeLayout(false);
            this.grbCadastrarLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagarLivros;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbNotaApagar;
        private System.Windows.Forms.Label lblNotaApagarL;
        private System.Windows.Forms.ComboBox cmbCategoriaApagar;
        private System.Windows.Forms.Label lblCategoriaApagarL;
        private System.Windows.Forms.TextBox txbTituloApagar;
        private System.Windows.Forms.Label lblTituloApagarL;
        private System.Windows.Forms.GroupBox grbCadastrarLivros;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbNotaCadastrar;
        private System.Windows.Forms.Label lblNotaCadastrarL;
        private System.Windows.Forms.ComboBox cmbCategoriaCadastrar;
        private System.Windows.Forms.Label lblCategoriaCadastrarL;
        private System.Windows.Forms.TextBox txbTituloCadastrar;
        private System.Windows.Forms.Label lblTituloCadastrarL;
        private System.Windows.Forms.Label lblTituloLivros;
        private System.Windows.Forms.DataGridView dgvLivros;
    }
}