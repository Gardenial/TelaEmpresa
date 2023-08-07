using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TelaEmpresa
{
    public partial class Cadastrar : Form
    {

        DAO conectar;

        public Cadastrar()
        {
            InitializeComponent();
            conectar = new DAO();

        }//Fim do Construtor

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }//Tela 

        private void label2_Click(object sender, EventArgs e)
        {

        }//Texto "CPF"

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Caixa de texto CPF

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }// caixa de texto Nome

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
            string result = conectar.inserir(Convert.ToInt64(maskedTextBox1.Text), textBox1.Text, telefone.Text, textBox2.Text, uf.Text, "Pessoa");
            MessageBox.Show(result);
            }catch(Exception erro) 
            {
            
                 MessageBox.Show("Algo deu errado!!\n\n" + erro.Message);
                
            }//Fim do Try...Catch
        }//Fim do botão Cadastrar

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }// Caixa de texto Cidade

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Caixa de texto Telefone

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// Caixa de texto UF
    }//Fim da classe
}//Fim do Projeto
