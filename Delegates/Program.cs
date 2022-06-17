internal class Program
{
    static void Main(string[] args)
    {
        var pagar = new Pagamento.Pagar(RealizarPagamento); // instanciando pagar pelo delegate da class Pagamento
        pagar(44); // apagar agora recebe o double injetar em RealizarPagamento
    }

    static void RealizarPagamento(double value) // Metdodo que realiza o pagamento
    {
        Console.WriteLine($"Pagamento realizado: {value}");
    }

    class Pagamento
    {
        public delegate void Pagar(double value); // Delegate aponta para a metodo que receberá um double
                                                  // Assinaturas iguais
    }
}
