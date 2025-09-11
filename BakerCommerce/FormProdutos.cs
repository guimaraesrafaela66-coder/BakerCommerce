using BakerCommerce.Model;
using EasyEncryption;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCategoria { get; set; }
        public int IdRespCadastro { get; set; }
        public double Preco { get; set; }

        Model.Usuario usuario;
        public FormProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            ListarCategoriasCmb();
        }

        private void grbCadastrar_Enter(object sender, EventArgs e)
        {

        }
        public void ListarCategoriasCmb()
        {
            Model.Categoria categoria = new Model.Categoria();
            // Tabela p/ receber o resultado do SELECT:
            DataTable tabela = categoria.Listar();

            foreach (DataRow dr in tabela.Rows)
            {
                // 1- Salgados
                // 2- Refrigerantes
                cmbCategoriaCadastro.Items.Add($"{dr["id"]} - {dr["nome"]}");
                cmbCategoriaEditar.Items.Add($"{dr["id"]} - {dr["nome"]}");
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbNomeEditar.Text.Length < 3) // Uva
            {
                MessageBox.Show("O produto deve ter no mínimo 3 caracteres.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbPrecoEditar.Text.Length < 1) // 1$
            {
                MessageBox.Show("O preço do produto deve ser no mínimo 1$.",
                    "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Fazer a edição...
                Model.Produto produtoEditar = new Model.Produto();

                // Salvar os valores dos campos nos atributos do obj:
                produtoEditar.Nome = txbNomeEditar.Text;
                produtoEditar.Preco = double.Parse(txbPrecoEditar.Text);
                produtoEditar.IdRespCadastro = usuario.Id;
                produtoEditar.Id = idSelecionado;
                produtoEditar.IdCategoria = int.Parse(cmbCategoriaCadastrar.Text.Split('-')[0]);

                // Executar o INSERT:
                if (produtoEditar.Modificar())
                {
                    MessageBox.Show("Editado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Atualizar o dvg:
                    AtualizarDgv();

                    // Apagar os campos de cadastro:
                    txbNomeEditar.Clear();
                    txbPrecoEditar.Clear();
                    cmdCategoriaEditar.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Não foi possível editar este produto!", "Erro!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = usuario.Listar();
        }



        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Perguntar se realmente quer apagar:
            DialogResult r = MessageBox.Show($"Tem certeza que deseja apgar este usuário?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                // Prosseguir com a exclusão...
                Model.Usuario usuarioApagar = new Model.Usuario();

                usuarioApagar.Id = idSelecionado;
                if (usuarioApagar.Apagar())
                {
                    MessageBox.Show("Usuário apagado com sucesso!", "Show!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ResetarCampos();

                }
                else
                {
                    MessageBox.Show("Falha ao apagar o usuário.",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             // Atualizar o dgv:
     AtualizarDgv();
 
     // Limpar campos de edição:
     txbNomeEditar.Clear();
     txbPrecoCadastrar.Clear();
     cmdCategoriaEditar.Items.Clear();
 
     // Retornar o idSelecionado para 0:
     idSelecionado = 0;
 
     // Retornar o texto padrão do "apagar":
     lblDescriçãoApagar.Text = "Selecione um produto para apagar.";
 
     // Desabilitar os grbs:
     grbCadastrar.Enabled = false;
     grbEditar.Enabled = false;
}
 
private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
     // Garante que não vai dar erro se clicar no cabeçalho
     if (e.RowIndex >= 0)
     {
         // Seleciona a linha inteira
         dgvProdutos.Rows[e.RowIndex].Selected = true;
         // Pegar a linha selecionada:
         int ls = dgvProdutos.SelectedCells[0].RowIndex;
 
         // Colocar os valores das células no txbs de edição:
         txbNomeEditar.Text = dgvProdutos.Rows[ls].Cells[1].Value.ToString();
         txbPrecoEditar.Text = dgvProdutos.Rows[ls].Cells[2].Value.ToString();
         cmdCategoriaEditar.Text = dgvProdutos.Rows[ls].Cells[3].Value.ToString();
 
         // Armazenar o ID de quem foi selecionado:
         idSelecionado = (int)dgvProdutos.Rows[ls].Cells[0].Value;
 
         // Ativar o grbEditarCadastro:
         grbEditar.Enabled = true;
 
         // Ajustes no grbApagarCadastro:
         lblDescriçãoApagar.Text = $"Apagar: {dgvProdutos.Rows[ls].Cells[1].Value.ToString()}";
 
         // Ativar o grbApagarCadastro:
         grbApagar.Enabled = true;
   

                }
            }
        }
    }

