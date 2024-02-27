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
    public partial class CadastrarFarmacia : Form
    {
        DAO bd;
        public CadastrarFarmacia()
        {
            InitializeComponent();
            bd = new DAO();
        }//metodo contrutor

        private void CadastrarFarmacia_Load(object sender, EventArgs e)
        {

        }//abre o formulario

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//caixa de texto nome da farmacia

        private void confFarmacia_Click(object sender, EventArgs e)
        {
            int cFarmacia = Convert.ToInt32(codFarmacia.Text);
            string nFarmacia = textBox1.Text;

            bd.CadFarmacia(cFarmacia, nFarmacia);//inserindo no bd

            //limpando os dados da tela do formulario

            codFarmacia.Text = "";
            textBox1.Text = "";

        }//botao confirmar farmacia

        private void codFarmacia_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo farmacia
    }//fim da classe
}//fim do projeto
