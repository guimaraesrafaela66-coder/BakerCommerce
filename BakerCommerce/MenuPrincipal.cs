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
    public partial class MenuPrincipal : Form
    {
        // Variaveis globais:
        Model.Usuario usuario = new Model.Usuario();

        public MenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblDescrição.Text = $"Ollá {usuario.NomeCompleto},\nEscolha u7ma opção abaixo:";

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnComandas_Click(object sender, EventArgs e)
        {

        }
    }
}
