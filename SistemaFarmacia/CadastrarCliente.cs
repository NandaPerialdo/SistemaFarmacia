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
    public partial class CadastrarCliente : Form
    {
        DAO bd;
        public CadastrarCliente()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void codCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//caixa de texto codigo do cliente

        private void nomeCliente_TextChanged(object sender, EventArgs e)
        {

        }//cx de texto nome cliente

        private void RG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cx de texto RG

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//cx de texto telefone

        private void planoSaude_TextChanged(object sender, EventArgs e)
        {

        }//cx de texto plano de saude

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {

        }//cx de texto farmacia popular

        private void confCliente_Click(object sender, EventArgs e)
        {
            int cCliente = Convert.ToInt32(codCliente.Text);
            string nCliente = nomeCliente.Text;
            int rgCliente = Convert.ToInt32(RG.Text);
            int tCliente = Convert.ToInt32(telefone.Text);
            string psCliente = planoSaude.Text;
            string fCliente = farmPopular.Text;

            bd.CadCliente(cCliente,nCliente,rgCliente,tCliente,psCliente,fCliente);

            //limpar a tela do formulario

            codCliente.Text = "";
            nomeCliente.Text = "";
            RG.Text= "";
            telefone.Text= "";
            planoSaude.Text = "";
            farmPopular.Text = "";
        }//botao confirmar cliente

        private void farmPopular_TextChanged(object sender, EventArgs e)
        {

        }//cx de texto farm popular
    }//fim da classe
}//fim do projeto
