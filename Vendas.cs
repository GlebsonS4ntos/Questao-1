using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    public class Vendas
    {
        public Vendedor Vendedor { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Vendas()
        {
        }

        public Vendas(Vendedor vendedor, Produto produto, int quantidade)
        {
            Vendedor = vendedor;
            Produto = produto;
            Quantidade = quantidade;
        }

        public Vendas(Vendas venda)
        {
            Vendedor = venda.Vendedor;
            Produto = venda.Produto;
            Quantidade = venda.Quantidade;
        }

        public bool ValidassaoVenda()
        {
            if(Quantidade <= Produto.Quantidade)
            {
                Vendedor.ValorComissao(Produto.Valor, Quantidade); //Gera comissao do vendedor
                Produto.Quantidade -= Quantidade; //Diminui o estoque
                return true;
            }
            else
            {
                Console.WriteLine("A compra não pode ser Efetuada por falta de Estoque");
                return false;
            }
        }
    }
    public class VendasRepository
    {
        public List<Vendas> todasVendas = new List<Vendas>();

        public void addVendas(Vendas venda)
        {
            todasVendas.Add(venda);
        }
    }
}
