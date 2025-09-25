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
    public partial class Filmes : Form
    {
        LibNerdFlix.Produto produto = new LibNerdFlix.Produto();
        int idSelecionado = 0;

        public Filmes()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvFilmes.DataSource = produto.Listar2();

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbTituloCadastrar.Text.Length < 2)
            {
                MessageBox.Show("O título deve ter no mínimo 2 caracteres.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbNotaCadastrar.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma nota!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                produto.Titulo = txbTituloCadastrar.Text;
                produto.Nota = cmbNotaCadastrar.SelectedIndex + 1;
                produto.IdCategoria = 2;


                if (produto.Cadastrar())
                {
                    MessageBox.Show("Filme cadastrado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar Filme!", "Erro",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void dgvJogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvFilmes.SelectedCells[0].RowIndex;

            txbTituloApagar.Text = dgvFilmes.Rows[ls].Cells[1].Value.ToString();

            idSelecionado = int.Parse(dgvFilmes.Rows[ls].Cells[0].Value + "");

            grbApagar.Enabled = true;
        }
        public void ResetarCampos()
        {
            AtualizarDgv();

            txbTituloCadastrar.Clear();
            cmbNotaCadastrar.Items.Clear();

            idSelecionado = 0;

            grbApagar.Enabled = false;

        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse filme?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                produto.Id = idSelecionado;

                if (produto.Apagar())
                {
                    MessageBox.Show("Filme apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o filme.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}
    


