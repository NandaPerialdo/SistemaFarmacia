using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFarmacia
{
    class DAO
    {
        //criar elemento que representa o mysql
        MySqlConnection conexao;
        public string dados;
        public string sql;

        //metodo contrutor

        public DAO()
        {
            //criar script para acessar o banco de dados
            conexao = new MySqlConnection("server=localhost;DataBase=SistemaFarmacia;Uid=root;password=");//informar a conexao com o servidor local

            try
            {
                conexao.Open();//estabelecer conexao
                MessageBox.Show("Conectado com Sucesso!");
            }catch(Exception erro)
            {
                MessageBox.Show(erro + "Algo deu errado :(");
                conexao.Close();
            }//fim do try catch
        }//fim do metodo contrutor

        public void RegistCompra(int codCliente, int codProduto, int codFarmacia)
        {
            dados = "('" + codCliente + "','" + codProduto + "','" + codFarmacia + "')";
            sql = "insert into compra (codCliente, codProduto, codFarmacia) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " Dado Inserido!");
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do try catch
        }//fim do metodo registrar compra

        public void CadProduto(int cod, string nome, )
        {

        }//fim do metodo cadastrar produto

    }//fim da classe
}//fim do projeto
