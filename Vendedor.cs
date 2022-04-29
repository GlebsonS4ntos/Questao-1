using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questão1
{
    public class Vendedor
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Comissao { get; private set; }

        public Vendedor()
        {
        }

        public Vendedor(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void ValorComissao(double valorProduto, int quantidadeProduto)
        {
            double comissaoVenda = 0;
            if (quantidadeProduto > 0 && quantidadeProduto <= 5)
                comissaoVenda = (quantidadeProduto * valorProduto) * 0.004;
            else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
                comissaoVenda = (quantidadeProduto * valorProduto) * 0.013;
            else if (quantidadeProduto > 10 && quantidadeProduto <= 15)
                comissaoVenda = (quantidadeProduto * valorProduto) * 0.03;
            else
                comissaoVenda = (quantidadeProduto * valorProduto) * 0.05;

            Comissao += comissaoVenda;
        }

        public override string ToString()
        {
            return $"O vendedor de nome {Name} e id: {Id}, teve comissão de R$ {Comissao}.";
        }
    }

    public class VendedorRepository
    {
        public static List<Vendedor> InicializarVendedor()
        {
            List<Vendedor> vendedores = new List<Vendedor>();
            vendedores.Add(new Vendedor(1, "João"));
            vendedores.Add(new Vendedor(2, "Jonathan"));
            vendedores.Add(new Vendedor(3, "Daniela"));
            vendedores.Add(new Vendedor(4, "Fabio"));
            vendedores.Add(new Vendedor(5, "Davyd"));
            vendedores.Add(new Vendedor(6, "Guilherme"));
            vendedores.Add(new Vendedor(7, "Glebson"));
            vendedores.Add(new Vendedor(8, "Marcela"));
            vendedores.Add(new Vendedor(9, "Andre"));
            vendedores.Add(new Vendedor(10, "Silene"));

            return vendedores;
        }

        public Vendedor BuscarVendedor(int idVendedor)
        {
            foreach (Vendedor v in InicializarVendedor())
            {
                if (v.Id == idVendedor)
                {
                    return v;
                }
            }
            return null;
        }
    }

}
