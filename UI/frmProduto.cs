using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI {
    public partial class frmProduto : Form {
        public frmProduto() {
            InitializeComponent();
        }

        private void frmProduto_Load(object sender, EventArgs e) {
            CarregarGridProdutos();
            btnExcluir.Enabled = false;
        }



        private void CarregarGridProdutos() {
            try {
                List<Produto> lista = ProdutoDAL.ListarTodos();

                dgvProdutos.DataSource = lista;
            } catch (Exception ex) {
                MessageBox.Show("Erro ao carregar lista de produtos: \n" + ex.Message);
            }
        }

        private void LimparCampos() {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            dtpDataHora.Value = DateTime.Now;
            numQuantidade.Value = 0;
            btnExcluir.Enabled = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                //Confere se nenhuma linha foi selecionada (RowIndex = -1)
                if (e.RowIndex < 0) {
                    btnExcluir.Enabled = false;
                    return;
                }

                //Se tem, pega a linha na  posicao RowIndex
                DataGridViewRow linhaSelecionada = dgvProdutos.Rows[e.RowIndex];

                //Aqui acontecem 2 coisas:
                //1. Verifica se o item atrelado a essa linha eh um Produto (DataBoundItem is Produto)
                //2. Se for, nomeia esse item como produto, para usarmos no codigo.
                if (linhaSelecionada.DataBoundItem is Produto produto) {
                    txtId.Text = produto.Id.ToString();
                    txtNome.Text = produto.Nome;
                    numQuantidade.Value = produto.Quantidade;
                    dtpDataHora.Value = produto.DataHora;
                    btnExcluir.Enabled = true;
                }
            } catch (Exception ex) {
                MessageBox.Show("Erro ao selecionar o produto: " + ex.Message);
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e) {
            //Criar um produto
            Produto produto = new Produto();

            //Preencher o produto com os dados da tela
            if (txtId.Text != string.Empty) {
                produto.Id = Convert.ToInt32(txtId.Text);
            }
            produto.Nome = txtNome.Text;
            produto.Quantidade = Convert.ToInt32(numQuantidade.Value);

            //Enviar o produto para o DAL salvar ou atualizar
            if (produto.Id > 0) {
                int atualizado = ProdutoDAL.Atualizar(produto);
                if (atualizado > 0) {
                    MessageBox.Show("Produto atualizado com êxito.");

                }
            } else {
                int IdInserido = ProdutoDAL.Inserir(produto);
                if (IdInserido != 0) {
                    MessageBox.Show("Produto inserido com êxito. Id: " + IdInserido);
                }
            }
            CarregarGridProdutos();
            LimparCampos();

        }

        private void btnNovo_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
               "Tem certeza que deseja excluir o produto selecionado?",
               "Confirmação de Exclusão",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
            );
            if (resultado == DialogResult.Yes) { 
                //Criar um produto
                Produto produto = new Produto();

                //Preencher o produto com o id
                if (txtId.Text != string.Empty) {
                    produto.Id = Convert.ToInt32(txtId.Text);
                }

                int excluido = ProdutoDAL.Excluir(produto);
                if (excluido > 0) {
                    MessageBox.Show("Produto excluído com êxito.");
                }
                CarregarGridProdutos();
                LimparCampos();
            }
        }
    }
}
