using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerCommerce.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdCategoria { get; set; }
        public int IdRespCadastro { get; set; }

        public DataTable Listar()
        {
            string comando = "SELECT * FROM categorias";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            DataTable tabela = new DataTable();
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
    }
}
