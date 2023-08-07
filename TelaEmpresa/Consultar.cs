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
    public partial class Consultar : Form
    {

        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            ConfigurarDataGrid();
            nomeColunas(); //Nomear os titulos das colunas
            AdicionarDados(); //Preenchendo o dataGridView1
            

        }//Fim do Construtor

        public void nomeColunas()
        {

            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";


        }//Fim do Método nome Colunas

        public void ConfigurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            
            dataGridView1.ColumnCount = 5;

        }//Fim do método Configurar Data Grid

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }//Fim do Datagrid

        public void AdicionarDados()
        {
            consul.PreencherVetor(); //Preencher os Vetores
            for (int i = 0; i < consul.quantidadeDados(); i++)
            {
                
                dataGridView1.Rows.Add(consul.CPF[i], consul.nome[i], consul.telefone[i], consul.cidade[i], consul.uf[i]);

            }//Adicionando dados no dataGridView1

        }//Fim do Método
    }//Fim da classe
}//Fim do Projeto
