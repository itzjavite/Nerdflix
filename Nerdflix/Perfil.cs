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
    public partial class Perfil : Form
    {

        public void AtualizarDgv()
        {
            dgvPerfil.DataSource = usuario.Listar();
        }

        //Objetos globais:
        LibNerdFlix.Usuario usuario = new LibNerdFlix.Usuario();

        int idSelecionado = 0; //armanezar o id do usuário selecionado p/ apagar ou editar
        public Perfil()
        {
            InitializeComponent();

            //Mostrar as infoemações do bd no datagriview:
            dgvPerfil.DataSource = usuario.Listar();

        }
        private void dgvPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar a linha selecionada:
            int ls = dgvPerfil.SelectedCells[0].RowIndex;
            //Adicionar os valores das células nos txbs de edição:

            txbNomeEditar.Text = dgvPerfil.Rows[ls].Cells[1].Value.ToString();
            txbEmailEditar.Text = dgvPerfil.Rows[ls].Cells[2].Value.ToString();

            //Armazenar o ID de quem foi selecionado:
            idSelecionado = (int)dgvPerfil.Rows[ls].Cells[0].Value;

            //Ativar o grbEditar:
            grbEditarPerfil.Enabled = true;

            //Ativar o grbApagar:
            grbApagarPerfil.Enabled = true;
        }
        private void btnApagar_Click(object sender, EventArgs e)
        {
            //Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show("Tem certeza que deseja apagar esse usuário?",
                "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                //Prosseguir com exclusão...
                LibNerdFlix.Usuario usuarioApagar = new LibNerdFlix.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }
        public void ResetarCampos()
        {
            //Atualizar o dgv:
            AtualizarDgv();

            //Limpar campos de edição:
            txbEmailEditar.Clear();
            txbSenhaEditar.Clear();
            txbNomeEditar.Clear();

            //Retornar o IdSelecionado para 0
            idSelecionado = 0;

            //desabilitar os grbs:
            grbApagarPerfil.Enabled = false;
            grbEditarPerfil.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 5)
            {
                MessageBox.Show("O nome deve ter no mínimo 5 caracteres.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEmailEditar.Text.Length < 7) // a@a.co
            {
                MessageBox.Show("O email deve ter no mínimo 7 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenhaEditar.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter no mínimo 6 caracteres", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Prosseguir com a edição:
                LibNerdFlix.Usuario usuarioEditar = new LibNerdFlix.Usuario();
                usuarioEditar.Id = idSelecionado;
                usuarioEditar.NomeCompleto = txbNomeEditar.Text;
                usuarioEditar.Email = txbEmailEditar.Text;
                usuarioEditar.Senha = txbSenhaEditar.Text;

                if (usuarioEditar.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetarCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao modificar usuário!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
    }
}
