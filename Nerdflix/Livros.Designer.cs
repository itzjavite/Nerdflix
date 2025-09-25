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
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbNotaApagar = new System.Windows.Forms.ComboBox();
            this.lblNotaApagarL = new System.Windows.Forms.Label();
            this.txbTituloApagar = new System.Windows.Forms.TextBox();
            this.lblTituloApagarL = new System.Windows.Forms.Label();
            this.grbCadastrarLivros = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbNotaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblNotaCadastrarL = new System.Windows.Forms.Label();
            this.txbTituloCadastrar = new System.Windows.Forms.TextBox();
            this.lblTituloCadastrarL = new System.Windows.Forms.Label();
            this.lblTituloLivros = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.grbApagar.SuspendLayout();
            this.grbCadastrarLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.cmbNotaApagar);
            this.grbApagar.Controls.Add(this.lblNotaApagarL);
            this.grbApagar.Controls.Add(this.txbTituloApagar);
            this.grbApagar.Controls.Add(this.lblTituloApagarL);
            this.grbApagar.ForeColor = System.Drawing.Color.White;
            this.grbApagar.Location = new System.Drawing.Point(647, 367);
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
            this.cmbNotaApagar.Location = new System.Drawing.Point(112, 111);
            this.cmbNotaApagar.Name = "cmbNotaApagar";
            this.cmbNotaApagar.Size = new System.Drawing.Size(244, 50);
            this.cmbNotaApagar.TabIndex = 5;
            // 
            // lblNotaApagarL
            // 
            this.lblNotaApagarL.AutoSize = true;
            this.lblNotaApagarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaApagarL.Location = new System.Drawing.Point(35, 129);
            this.lblNotaApagarL.Name = "lblNotaApagarL";
            this.lblNotaApagarL.Size = new System.Drawing.Size(63, 25);
            this.lblNotaApagarL.TabIndex = 4;
            this.lblNotaApagarL.Text = "Nota:";
            // 
            // txbTituloApagar
            // 
            this.txbTituloApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloApagar.Location = new System.Drawing.Point(112, 43);
            this.txbTituloApagar.Name = "txbTituloApagar";
            this.txbTituloApagar.Size = new System.Drawing.Size(244, 26);
            this.txbTituloApagar.TabIndex = 1;
            // 
            // lblTituloApagarL
            // 
            this.lblTituloApagarL.AutoSize = true;
            this.lblTituloApagarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApagarL.Location = new System.Drawing.Point(35, 44);
            this.lblTituloApagarL.Name = "lblTituloApagarL";
            this.lblTituloApagarL.Size = new System.Drawing.Size(71, 25);
            this.lblTituloApagarL.TabIndex = 0;
            this.lblTituloApagarL.Text = "Título:";
            // 
            // grbCadastrarLivros
            // 
            this.grbCadastrarLivros.Controls.Add(this.btnCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.cmbNotaCadastrar);
            this.grbCadastrarLivros.Controls.Add(this.lblNotaCadastrarL);
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
            this.cmbNotaCadastrar.Location = new System.Drawing.Point(112, 111);
            this.cmbNotaCadastrar.Name = "cmbNotaCadastrar";
            this.cmbNotaCadastrar.Size = new System.Drawing.Size(244, 50);
            this.cmbNotaCadastrar.TabIndex = 5;
            // 
            // lblNotaCadastrarL
            // 
            this.lblNotaCadastrarL.AutoSize = true;
            this.lblNotaCadastrarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCadastrarL.Location = new System.Drawing.Point(35, 129);
            this.lblNotaCadastrarL.Name = "lblNotaCadastrarL";
            this.lblNotaCadastrarL.Size = new System.Drawing.Size(63, 25);
            this.lblNotaCadastrarL.TabIndex = 4;
            this.lblNotaCadastrarL.Text = "Nota:";
            // 
            // txbTituloCadastrar
            // 
            this.txbTituloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloCadastrar.Location = new System.Drawing.Point(112, 42);
            this.txbTituloCadastrar.Name = "txbTituloCadastrar";
            this.txbTituloCadastrar.Size = new System.Drawing.Size(244, 26);
            this.txbTituloCadastrar.TabIndex = 1;
            // 
            // lblTituloCadastrarL
            // 
            this.lblTituloCadastrarL.AutoSize = true;
            this.lblTituloCadastrarL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarL.Location = new System.Drawing.Point(35, 43);
            this.lblTituloCadastrarL.Name = "lblTituloCadastrarL";
            this.lblTituloCadastrarL.Size = new System.Drawing.Size(71, 25);
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
            this.dgvLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogos_CellClick);
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 641);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastrarLivros);
            this.Controls.Add(this.lblTituloLivros);
            this.Controls.Add(this.dgvLivros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Livros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.grbCadastrarLivros.ResumeLayout(false);
            this.grbCadastrarLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbNotaApagar;
        private System.Windows.Forms.Label lblNotaApagarL;
        private System.Windows.Forms.TextBox txbTituloApagar;
        private System.Windows.Forms.Label lblTituloApagarL;
        private System.Windows.Forms.GroupBox grbCadastrarLivros;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cmbNotaCadastrar;
        private System.Windows.Forms.Label lblNotaCadastrarL;
        private System.Windows.Forms.TextBox txbTituloCadastrar;
        private System.Windows.Forms.Label lblTituloCadastrarL;
        private System.Windows.Forms.Label lblTituloLivros;
        private System.Windows.Forms.DataGridView dgvLivros;
    }
}