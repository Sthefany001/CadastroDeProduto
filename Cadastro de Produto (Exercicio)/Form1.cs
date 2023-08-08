using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Produto__Exercicio_
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Produto x = new Produto();
                x.Codigo = tb_Codigo.Text;
                x.Descricao = tb_Descricao.Text;
                x.Preco = Convert.ToDouble(tb_PrecoDeAquisicao.Text);
                x.Lucro = Convert.ToDouble(tb_Lucro.Text);

                double porcentagem = (x.Preco * x.Lucro) / 100;
                double valorVenda = x.Preco + porcentagem;

                x.ValorDeVenda = valorVenda;

                tb_ValorDeVenda.Text = valorVenda.ToString();

                produtos.Add(x);

                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = produtos;
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Formato inválido!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado!");
            }
            finally
            {
                
            }

        }
        private void buttonNovo_Click(object sender, EventArgs e)
        {
            tb_Codigo.Clear(); //limpando
            tb_Descricao.Clear();
            tb_PrecoDeAquisicao.Clear();
            tb_Lucro.Clear();
            tb_ValorDeVenda.Clear();
        }

        private void tb_ValorDeVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex; //linha que o usuario escolher
            produtos.RemoveAt(index); //removendo

            //zerando a tabela e atualizando
            dataGridView1.DataSource = null; //deixar sem nenhum elemento
            dataGridView1.Refresh(); //atualizar a tabela
            dataGridView1.DataSource = produtos;
        }
    }
}
