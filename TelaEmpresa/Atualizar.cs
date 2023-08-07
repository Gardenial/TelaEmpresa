using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TelaEmpresa
{
    public partial class Atualizar : Form
    {

        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Caixa de texto UF

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Caixa de texto Telefone

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de texto Cidade

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Caixa de texto Nome

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// Caixa texto CPF

        private void label5_Click(object sender, EventArgs e)
        {

        }// texto UF

        private void label6_Click(object sender, EventArgs e)
        {

        }//Texto telefone

        private void label4_Click(object sender, EventArgs e)
        {

        }//Texto cidade

        private void label3_Click(object sender, EventArgs e)
        {

        }//Texto Nome

        private void label2_Click(object sender, EventArgs e)
        {

        }//Texto CPF

        private void button1_Click(object sender, EventArgs e)
        {

            atu.Atualizar(Convert.ToInt64(maskedTextBox1.Text), "pessoa", "nome",  nome.Text);
            atu.Atualizar(Convert.ToInt64(maskedTextBox1.Text), "pessoa", "Telefone", telefone.Text);
            atu.Atualizar(Convert.ToInt64(maskedTextBox1.Text), "pessoa", "Cidade",  cidade.Text);
            atu.Atualizar(Convert.ToInt64(maskedTextBox1.Text), "pessoa", "UF",  uf.Text);
            MessageBox.Show("Dados atualizados com Sucesso!");
           
        }//Botão atualizar

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
