using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakerCommerce
{
    public partial class FormProdutos : Form
    {
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
    }
}
