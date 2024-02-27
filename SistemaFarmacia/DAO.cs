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

        public void CadProduto(int codProduto, string nomeProduto, double valorProduto)
        {
            dados = "('" + codProduto + "','" + nomeProduto + "','" + valorProduto + ")";
            sql = "insert into produto (cod, nome, valor) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " Dado Inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do try catch
        }//fim do metodo cadastrar produto

        public void CadFarmacia(int codFarmacia, string nomeFarmacia)
        {
            dados = "('" + codFarmacia + "','" + nomeFarmacia + ")";
            sql = "insert into produto (codFarmacia, nomeFarmacia) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " Dado Inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do try catch
        }//fim do metodo cadastrar farmacia

        public void CadCliente(int codCliente, string nomeCliente, double rg, int telefone, string planoSaude, string farmPopular)
        {
            dados = "('" + codCliente + "','" + nomeCliente + "','" + rg + "','" + telefone + "','" + planoSaude + "','" + farmPopular + ")";
            sql = "insert into produto (codCliente, nomeCliente, rg, telefone, planoSaude, farmPopular) values" + dados;

            try
            {
                MySqlCommand conn = new MySqlCommand(sql, conexao);
                MessageBox.Show(conn.ExecuteNonQuery() + " Dado Inserido!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }//fim do try catch
        }//fim do metodo cadastrar cliente

    }//fim da classe
}//fim do projeto
