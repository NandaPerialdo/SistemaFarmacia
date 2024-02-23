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
    public partial class registrarCompra : Form
    {
        DAO bd;
        public registrarCompra()
        {
            InitializeComponent();
            bd = new DAO();//conectar essa tela com a classe DAO
        }//metodo construtor

        private void codCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo cliente

        private void codProduto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo produto

        private void codFarmacia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo farmacia

        private void confRegistro_Click(object sender, EventArgs e)
        {
            int cCliente = Convert.ToInt32(codCliente.Text);
            int cProduto = Convert.ToInt32(codProduto.Text);
            int cFarmacia = Convert.ToInt32(codFarmacia.Text);

            bd.RegistCompra(cCliente, cProduto, cFarmacia);//inserindo no bd

            //limpar os campos apos a insercao dos dados

            codCliente.Text = "";
            codProduto.Text = "";
            codFarmacia.Text = "";
        }//botao confirmar registro
    }//fim da classe
}//fim do projeto
