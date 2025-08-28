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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Verificar se a pessoa digitou o email e a senha:
           
            if(txbEmail.Text.Length < 6)
            {
                MessageBox.Show("Digite um e-mail válido!",
               "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txbSenha.Text.Length < 4) {
                MessageBox.Show("Digite uma senha válida!",
              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Prosseguir...
                Model.Usuario usuario = new Model.Usuario();

                // Colocar os vvalores dos campos nos atributos do usuário:
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
            }
        }
    }
}
