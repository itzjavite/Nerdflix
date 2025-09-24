using LibNerdFlix;
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
    public partial class Jogos : Form
    {
        LibNerdFlix.Produto produto = new LibNerdFlix.Produto();
        int idSelecionado = 0;

        public Jogos()
        {
            InitializeComponent();
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvJogos.DataSource = produto.Listar1();

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbTituloCadastrar.Text.Length < 2)
            {
                MessageBox.Show("O título deve ter no mínimo 2 caracteres.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbNotaCadastrar.SelectedIndex == 0)
            {
                MessageBox.Show("Selecione uma nota!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                produto.Titulo = txbTituloCadastrar.Text;
                produto.Nota = cmbNotaCadastrar.SelectedIndex + 1;
                produto.IdCategoria = 1;


                if (produto.Cadastrar())
                {
                    MessageBox.Show("Jogo cadastrado com sucesso!", "Show",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar Jogo!", "Erro",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }
        private void dgvJogos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ls = dgvJogos.SelectedCells[0].RowIndex;

            idSelecionado = (int)dgvJogos.Rows[ls].Cells[0].Value;
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
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse jogo?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                produto.Titulo = txbTituloApagar.Text;
                produto.Nota = double.Parse(cmbNotaApagar.Text);


                produto.Id = idSelecionado;
                if (produto.Apagar())
                {
                    MessageBox.Show("Jogo apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o jogo.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
    }
}
