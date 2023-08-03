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
    public partial class Empresa : Form
    {

        Cadastrar   cad;
        Consultar   con;
        Atualizar   atu;
        Excluir     exc;
        public Empresa()
        {
            InitializeComponent();
            cad = new Cadastrar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
        }//Fim do construtor

        private void Empresa_Load(object sender, EventArgs e)
        {

        }//Fim da Tela Empresa

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog(); //Abre a tela

        }//Fim do Botão Cadastrar

        private void Atualizar_Click(object sender, EventArgs e)
        {

            atu.ShowDialog();

        }//Fim do Botão Atualizar

        private void Consultar_Click(object sender, EventArgs e)
        {

            con.ShowDialog();

        }//Fim do Botão Consultar

        private void Excluir_Click(object sender, EventArgs e)
        {

            exc.ShowDialog();

        }//Fim do Botão Excluir
    }//Fim da classe
}//Fim do projeto
