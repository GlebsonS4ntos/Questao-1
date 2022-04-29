using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    public class Produto
    {
        public int IdProduto { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }
        public int Quantidade { get; set; }

        public Produto()
        {
        }

        public Produto(int idProduto, string nome, double valor, int quantidade)
        {
            IdProduto = idProduto;
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
    public class ProdutoRepository
    {
        public static List<Produto> InicializarProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            produtos.Add(new Produto(1, "Computador", 3000.00, 100));
            produtos.Add(new Produto(2, "Celular", 1500.00, 80));
            produtos.Add(new Produto(3, "Caneca", 20.00, 3000));
            produtos.Add(new Produto(4, "Fone", 250.00, 500));
            produtos.Add(new Produto(5, "Oculos", 900.00, 200));

            return produtos;
        }

        public Produto BuscarProduto(int idProduto)
        {
            foreach (Produto p in InicializarProdutos())
            {
                if (p.IdProduto == idProduto)
                {
                    return p;
                }
            }
            return null;
        }
    }
}


