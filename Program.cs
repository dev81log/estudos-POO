using System;
using System.Globalization;

namespace Pagamentos
{
    class Program
    {
        static void Main()
        {
            Console.Clear();

            var Pagamento = new Pagamento(); // instanciando a classe de Pagamento
            Pagamento.DataPagamento = DateTime.Now; // atribuindo propriedade
            var Endereco = new Endereco(); // instanciando a classe de Endereco
            var PagamentoBoleto = new PagamentoBoleto(); // instanciando a classe de PagamentoBoleto (recebendo herança de Pagamento)
            PagamentoBoleto.Pagar(); // chamando metodo da classe de PagamentoBoleto (recebendo metodo Pagar)
            PagamentoBoleto.vencimento = DateTime.Now; // atribuindo propriedade 
            PagamentoBoleto.numeroBoleto = "22334455"; // atribuindo propriedade 

            Console.WriteLine("Endereco: " + Endereco.cep + " " + Endereco.cidade);
            Console.WriteLine("Pagamento Boleto: " + PagamentoBoleto.vencimento.ToString());
            Console.WriteLine("Numero Boleto: " + PagamentoBoleto.numeroBoleto);

        }
    }

    // classe
    class Pagamento
    {
        // prop simples
        public DateTime Vencimento { get; set; }

        // prop full
        private DateTime _dataPagamento; // _ propriedade privado

        public DateTime DataPagamento
        {
            get
            {
                return _dataPagamento;
                Console.WriteLine("Lendo Pagamento");
            }
            set
            {
                _dataPagamento = value;
                Console.WriteLine("Atribuindo Pagamento");
            }
        }


        // propriedades
        public DateTime vencimento;

        // metodos
        public void Pagar()
        {
            Console.WriteLine("Pagamento Efetuado");
        }

    }

    // herança
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
        public string cep = "89022-0222";
        public string cidade = "nova cidade";
    }
}


