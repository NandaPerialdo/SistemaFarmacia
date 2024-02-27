using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    public partial class CadastrarProduto : Form
    {
        DAO bd;
        public CadastrarProduto()
        {
            InitializeComponent();
            bd = new DAO();// conectar com a DAO
        }//fim do metodo construtor

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }//carregar tela

        private void nomeProduto_TextChanged(object sender, EventArgs e)
        {

        }//caixa de texto nome do produto

        private void valorProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto valor do produto

        private void confProduto_Click(object sender, EventArgs e)
        {
            int cProduto = Convert.ToInt32(codProduto.Text);
            string nProduto = nomeProduto.Text;
            double vProduto = Convert.ToDouble(valorProduto.Text);

            bd.CadProduto(cProduto, nProduto, vProduto);// inserindo no bd

            //limpar dos dados apos inserçao

            codProduto.Text = "";
            nomeProduto.Text = "";
            valorProduto.Text = "";
        }//botao confirmar produto

        private void codProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo do produto
    }//fim da classe
}//fim do projeto
