using System;

namespace Questão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a Quantidade de vendas que serão feita: ");
            int quantidadeVendas = int.Parse(Console.ReadLine());

            VendasRepository vendas = new VendasRepository();
            ProdutoRepository produtos = new ProdutoRepository();
            VendedorRepository vendedores = new VendedorRepository();

            for (int i = 0; i < quantidadeVendas; i++)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Digite o Id do Vendedor: ");
                int idVendedor = int.Parse(Console.ReadLine());
                Console.Write("Digite o Id do Produto: ");
                int idProduto = int.Parse(Console.ReadLine());
                Console.Write("Digite a quantidade dos produtos: ");
                int quantidade = int.Parse(Console.ReadLine());
                Vendedor v = vendedores.BuscarVendedor(idVendedor);
                Produto p = produtos.BuscarProduto(idProduto);
                if (p != null && v != null)
                {
                    Vendas venda = new Vendas(v, p, quantidade);
                    bool vendaValidada = venda.ValidassaoVenda();
                    if (vendaValidada)
                    {
                        vendas.addVendas(venda);
                        Console.WriteLine("Compra realizada com sucesso !!");
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou algum dado referente ao Id do vendedor e/ou do Produto, invalido");
                }
            }



            Console.WriteLine("-------------------------------------------------------------");
            int j = 0;
            foreach (Vendas v in vendas.todasVendas)
            {
                Console.WriteLine(v.Vendedor.ToString() + $" Referente a venda de numero {j+1}");
                j++;
            }

        }
    }
}
