using projeto_controles_de_vendas.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace projeto__controles_de_venda.br.com.projeto.view
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string senha = txtsenha.Text;

            FuncionarioDAO dao = new FuncionarioDAO();
            if(dao.efetutarlogin(email, senha))
            { 
                this.Hide();
            }
        }
    }
}
