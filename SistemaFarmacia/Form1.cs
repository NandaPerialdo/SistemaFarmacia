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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }// metodo construtor

        private void registrarCompra_Click(object sender, EventArgs e)
        {
            registrarCompra registrar = new registrarCompra();
            registrar.ShowDialog();
        }//fim do botao registrar compra

        private void exibirRanking_Click(object sender, EventArgs e)
        {
            Ranking rank = new Ranking();
            rank.ShowDialog();
        }//fim do botao exibir ranking 

        private void cadastrarProduto_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadProd = new CadastrarProduto();
            cadProd.ShowDialog();
        }//fim do botao cadastrar produto

        private void cadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCliente = new CadastrarCliente();
            cadCliente.ShowDialog();
        }//fim do botao cadastrar cliente

        private void cadastrarFarmacia_Click(object sender, EventArgs e)
        {
            CadastrarFarmacia cadFarm = new CadastrarFarmacia();
            cadFarm.ShowDialog();
        }//fim do botao cadastrar farmacia
    }//fim da classe
}//fim do projeto
