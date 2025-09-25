namespace Nerdflix
{
    partial class Jogos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogos));
            this.dgvJogos = new System.Windows.Forms.DataGridView();
            this.lblTituloJogos = new System.Windows.Forms.Label();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cmbNotaCadastrar = new System.Windows.Forms.ComboBox();
            this.lblNotaCadastrarJ = new System.Windows.Forms.Label();
            this.txbTituloCadastrar = new System.Windows.Forms.TextBox();
            this.lblTituloCadastrarJ = new System.Windows.Forms.Label();
            this.grbApagar = new System.Windows.Forms.GroupBox();
            this.btnApagar = new System.Windows.Forms.Button();
            this.cmbNotaApagar = new System.Windows.Forms.ComboBox();
            this.lblNotaApagarJ = new System.Windows.Forms.Label();
            this.txbTituloApagar = new System.Windows.Forms.TextBox();
            this.lblTituloApagarJ = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).BeginInit();
            this.grbCadastrar.SuspendLayout();
            this.grbApagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvJogos
            // 
            this.dgvJogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJogos.Location = new System.Drawing.Point(12, 84);
            this.dgvJogos.Name = "dgvJogos";
            this.dgvJogos.ReadOnly = true;
            this.dgvJogos.Size = new System.Drawing.Size(1107, 263);
            this.dgvJogos.TabIndex = 0;
            this.dgvJogos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJogos_CellClick);
            // 
            // lblTituloJogos
            // 
            this.lblTituloJogos.AutoSize = true;
            this.lblTituloJogos.BackColor = System.Drawing.Color.Black;
            this.lblTituloJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloJogos.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTituloJogos.Location = new System.Drawing.Point(489, 23);
            this.lblTituloJogos.Name = "lblTituloJogos";
            this.lblTituloJogos.Size = new System.Drawing.Size(149, 42);
            this.lblTituloJogos.TabIndex = 1;
            this.lblTituloJogos.Text = "JOGOS";
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Controls.Add(this.cmbNotaCadastrar);
            this.grbCadastrar.Controls.Add(this.lblNotaCadastrarJ);
            this.grbCadastrar.Controls.Add(this.txbTituloCadastrar);
            this.grbCadastrar.Controls.Add(this.lblTituloCadastrarJ);
            this.grbCadastrar.ForeColor = System.Drawing.Color.White;
            this.grbCadastrar.Location = new System.Drawing.Point(82, 365);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(404, 249);
            this.grbCadastrar.TabIndex = 2;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar";
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
            this.cmbNotaCadastrar.Location = new System.Drawing.Point(113, 113);
            this.cmbNotaCadastrar.Name = "cmbNotaCadastrar";
            this.cmbNotaCadastrar.Size = new System.Drawing.Size(243, 50);
            this.cmbNotaCadastrar.TabIndex = 5;
            // 
            // lblNotaCadastrarJ
            // 
            this.lblNotaCadastrarJ.AutoSize = true;
            this.lblNotaCadastrarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaCadastrarJ.Location = new System.Drawing.Point(35, 131);
            this.lblNotaCadastrarJ.Name = "lblNotaCadastrarJ";
            this.lblNotaCadastrarJ.Size = new System.Drawing.Size(63, 25);
            this.lblNotaCadastrarJ.TabIndex = 4;
            this.lblNotaCadastrarJ.Text = "Nota:";
            // 
            // txbTituloCadastrar
            // 
            this.txbTituloCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloCadastrar.Location = new System.Drawing.Point(113, 54);
            this.txbTituloCadastrar.Name = "txbTituloCadastrar";
            this.txbTituloCadastrar.Size = new System.Drawing.Size(243, 26);
            this.txbTituloCadastrar.TabIndex = 1;
            // 
            // lblTituloCadastrarJ
            // 
            this.lblTituloCadastrarJ.AutoSize = true;
            this.lblTituloCadastrarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCadastrarJ.Location = new System.Drawing.Point(35, 54);
            this.lblTituloCadastrarJ.Name = "lblTituloCadastrarJ";
            this.lblTituloCadastrarJ.Size = new System.Drawing.Size(71, 25);
            this.lblTituloCadastrarJ.TabIndex = 0;
            this.lblTituloCadastrarJ.Text = "Título:";
            // 
            // grbApagar
            // 
            this.grbApagar.Controls.Add(this.btnApagar);
            this.grbApagar.Controls.Add(this.cmbNotaApagar);
            this.grbApagar.Controls.Add(this.lblNotaApagarJ);
            this.grbApagar.Controls.Add(this.txbTituloApagar);
            this.grbApagar.Controls.Add(this.lblTituloApagarJ);
            this.grbApagar.ForeColor = System.Drawing.Color.White;
            this.grbApagar.Location = new System.Drawing.Point(647, 365);
            this.grbApagar.Name = "grbApagar";
            this.grbApagar.Size = new System.Drawing.Size(404, 249);
            this.grbApagar.TabIndex = 3;
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
            this.cmbNotaApagar.Location = new System.Drawing.Point(112, 106);
            this.cmbNotaApagar.Name = "cmbNotaApagar";
            this.cmbNotaApagar.Size = new System.Drawing.Size(244, 50);
            this.cmbNotaApagar.TabIndex = 5;
            // 
            // lblNotaApagarJ
            // 
            this.lblNotaApagarJ.AutoSize = true;
            this.lblNotaApagarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotaApagarJ.Location = new System.Drawing.Point(35, 124);
            this.lblNotaApagarJ.Name = "lblNotaApagarJ";
            this.lblNotaApagarJ.Size = new System.Drawing.Size(63, 25);
            this.lblNotaApagarJ.TabIndex = 4;
            this.lblNotaApagarJ.Text = "Nota:";
            // 
            // txbTituloApagar
            // 
            this.txbTituloApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloApagar.Location = new System.Drawing.Point(112, 53);
            this.txbTituloApagar.Name = "txbTituloApagar";
            this.txbTituloApagar.Size = new System.Drawing.Size(244, 26);
            this.txbTituloApagar.TabIndex = 1;
            // 
            // lblTituloApagarJ
            // 
            this.lblTituloApagarJ.AutoSize = true;
            this.lblTituloApagarJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloApagarJ.Location = new System.Drawing.Point(35, 54);
            this.lblTituloApagarJ.Name = "lblTituloApagarJ";
            this.lblTituloApagarJ.Size = new System.Drawing.Size(71, 25);
            this.lblTituloApagarJ.TabIndex = 0;
            this.lblTituloApagarJ.Text = "Título:";
            // 
            // Jogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1131, 637);
            this.Controls.Add(this.grbApagar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.lblTituloJogos);
            this.Controls.Add(this.dgvJogos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Jogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvJogos)).EndInit();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbApagar.ResumeLayout(false);
            this.grbApagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvJogos;
        private System.Windows.Forms.Label lblTituloJogos;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.TextBox txbTituloCadastrar;
        private System.Windows.Forms.Label lblTituloCadastrarJ;
        private System.Windows.Forms.ComboBox cmbNotaCadastrar;
        private System.Windows.Forms.Label lblNotaCadastrarJ;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbApagar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.ComboBox cmbNotaApagar;
        private System.Windows.Forms.Label lblNotaApagarJ;
        private System.Windows.Forms.TextBox txbTituloApagar;
        private System.Windows.Forms.Label lblTituloApagarJ;
    }
}