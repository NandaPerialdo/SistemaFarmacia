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
    public partial class Ranking : Form
    {
        DAO conectar;
        public Ranking()
        {
            InitializeComponent();
            conectar= new DAO();

            ConfigurarGrid();
            NomeColunas();
            conectar.PreencherVetor();
            AdicionarDados();
        }//metodo construtor

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        public void NomeColunas()
        {
            dataGridView1.Columns[0].Name = "Codigo Cliente";
            dataGridView1.Columns[1].Name = "Codigo Produto";
            dataGridView1.Columns[2].Name = "Codigo Farmacia";
        }//fim do metodo

        public void AdicionarDados()
        {
            for (int i = 0; i < conectar.RetornarContagem(); i++)
            {
                dataGridView1.Rows.Add(conectar.cCliente[i], conectar.cProduto[i], conectar.cFarmacia[i]);
            }//fim do for
        }//fim do metodo

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnCount = 3;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do datagrid
    }//fim da classe
}//fim do projeto
