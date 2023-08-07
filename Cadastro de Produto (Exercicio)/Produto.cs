using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Produto__Exercicio_
{
    internal class Produto
    {
        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        public double Lucro { get; set; }   

        public double ValorDeVenda { get; set; }

        public Produto()
        {

        }

        public Produto(string codigo, string descricao, double preco, double lucro, double valorDeVenda)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
            this.Lucro = lucro;
            this.ValorDeVenda = valorDeVenda;
        }
    }
}
