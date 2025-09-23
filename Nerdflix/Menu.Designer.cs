namespace Nerdflix
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnJogos = new System.Windows.Forms.Button();
            this.btnFilmes = new System.Windows.Forms.Button();
            this.btnLivros = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Impact", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTituloMenu.Location = new System.Drawing.Point(337, 34);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(106, 45);
            this.lblTituloMenu.TabIndex = 0;
            this.lblTituloMenu.Text = "MENU";
            // 
            // btnJogos
            // 
            this.btnJogos.BackColor = System.Drawing.Color.Firebrick;
            this.btnJogos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJogos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogos.ForeColor = System.Drawing.Color.White;
            this.btnJogos.Location = new System.Drawing.Point(297, 112);
            this.btnJogos.Name = "btnJogos";
            this.btnJogos.Size = new System.Drawing.Size(188, 72);
            this.btnJogos.TabIndex = 1;
            this.btnJogos.Text = "JOGOS";
            this.btnJogos.UseVisualStyleBackColor = false;
            // 
            // btnFilmes
            // 
            this.btnFilmes.BackColor = System.Drawing.Color.Firebrick;
            this.btnFilmes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFilmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilmes.ForeColor = System.Drawing.Color.White;
            this.btnFilmes.Location = new System.Drawing.Point(297, 190);
            this.btnFilmes.Name = "btnFilmes";
            this.btnFilmes.Size = new System.Drawing.Size(188, 72);
            this.btnFilmes.TabIndex = 2;
            this.btnFilmes.Text = "FILMES";
            this.btnFilmes.UseVisualStyleBackColor = false;
            // 
            // btnLivros
            // 
            this.btnLivros.BackColor = System.Drawing.Color.Firebrick;
            this.btnLivros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivros.ForeColor = System.Drawing.Color.White;
            this.btnLivros.Location = new System.Drawing.Point(297, 268);
            this.btnLivros.Name = "btnLivros";
            this.btnLivros.Size = new System.Drawing.Size(188, 72);
            this.btnLivros.TabIndex = 3;
            this.btnLivros.Text = "LIVROS";
            this.btnLivros.UseVisualStyleBackColor = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.Black;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Firebrick;
            this.btnPerfil.Location = new System.Drawing.Point(297, 346);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(188, 72);
            this.btnPerfil.TabIndex = 4;
            this.btnPerfil.Text = "PERFIL";
            this.btnPerfil.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.btnLivros);
            this.Controls.Add(this.btnFilmes);
            this.Controls.Add(this.btnJogos);
            this.Controls.Add(this.lblTituloMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnJogos;
        private System.Windows.Forms.Button btnFilmes;
        private System.Windows.Forms.Button btnLivros;
        private System.Windows.Forms.Button btnPerfil;
    }
}