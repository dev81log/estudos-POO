using System;

namespace Pagamentos
{
    class Program
    {
        static void Main()
        {
            var PagamentoBoleto = new PagamentoBoleto();
            PagamentoBoleto.vencimento = DateTime.Now;
            PagamentoBoleto.numeroBoleto = "22334455";

            Console.Clear();
            PagamentoBoleto.Pagar();
            Console.WriteLine("Pagamento Boleto: " + PagamentoBoleto.vencimento.ToString());
            Console.WriteLine("Numero Boleto: " + PagamentoBoleto.numeroBoleto);
        }
    }

    class Pagamento
    {
        // propriedades
        public DateTime vencimento;
        public Endereco endereco;

        // metodos
        public void Pagar()
        {
            Console.WriteLine("Pagamento Efetuado");
        }

    }

    class PagamentoBoleto : Pagamento
    {
        public string numeroBoleto;
    }

    class PagamentoCartao : Pagamento
    {
        public string numeroCartao;
    }

    public class Endereco
    {
        string cep;
    }
}


