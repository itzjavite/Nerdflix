using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nerdflix
{
    public partial class Menu : Form
    {
        LibNerdFlix.Produto produto = new LibNerdFlix.Produto();
        public Menu()
        {
            InitializeComponent();

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            Jogos jogos = new Jogos();
            jogos.ShowDialog();
        }

        private void btnFilmes_Click(object sender, EventArgs e)
        {
            Filmes filmes = new Filmes();
            filmes.ShowDialog();
        }

        private void btnLivros_Click(object sender, EventArgs e)
        {
            Livros livros = new Livros();
            livros.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            perfil.ShowDialog();
        }
    }
}
