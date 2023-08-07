using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaEmpresa
{
    public partial class Excluir : Form
    {

        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();

        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }//Tela

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Caixa de texto CPF

        private void button1_Click(object sender, EventArgs e)
        {

            string result = exc.Excluir(Convert.ToInt64(cpf.Text), "Pessoa");
            MessageBox.Show(result);
        }//Botão excluir

    }//Fim da classe
}//Fim do projeto
