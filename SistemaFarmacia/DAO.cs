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
        public int contador;
        public int[] cCliente;
        public int[] cProduto;
        public int[] cFarmacia;
        int i;
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

        public int ConsultarTamanhoBD()
        {
            return contador;
        }//fim do selecionar

        public void PreencherVetor()
        {
            string query = "select * from compra";//Coletar os dados do BD

            //Instanciar
            this.cCliente = new int[100];
            this.cProduto = new int[100];
            this.cFarmacia = new int[100];

            //Preencher com valores iniciais
            for (i = 0; i < 100; i++)
            {
                cCliente[i] = 0;
                cProduto[i] = 0;
                cFarmacia[i] = 0;
            }//fim do for

            //Criando o comando para consultar no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do banco
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read())
            {
                cCliente[i] = Convert.ToInt32(leitura["codigo"]);
                cProduto[i] = Convert.ToInt32(leitura["nome"]);
                cFarmacia[i] = Convert.ToInt32(leitura["telefone"]);
                i++;
                contador++;

            }//Fim do while

            //Fechar a leitura de dados no banco
            leitura.Close();
        }//fim do método preencher

        public int RetornarContagem()
        {
            return contador;
        }//fim do metodo

        public int[] ConsultarCodCliente()
        {
            PreencherVetor();
            return cCliente;
        }//fim do método

        public int[] ConsultarCodProduto()
        {
            PreencherVetor();
            return cProduto;
        }//fim do método

        public int[] ConsultarCodFarmacia()
        {
            PreencherVetor();
            return cFarmacia;
        }//fim do método

    }//fim da classe
}//fim do projeto
