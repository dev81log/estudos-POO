using System;

namespace UsingDispose
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // var pagamento = new Pagamento(); // instanciando pagamento
            // pagamento.Dispose(); // metodo irá destruir pagamento

            using (var pagamento = new Pagamento()) // certifica de criar a destruir pagamento
            {
                Console.WriteLine("Processando pagamento");
            }
        }

        private class Pagamento : IDisposable // chama herança IDisposable para criar um metodo dispose()
        {
            public Pagamento()
            {
                Console.WriteLine("Iniciando pagamento");
            }

            public void Dispose() // metodo dispose ira certificar de finalizar a classe Pagamento
            {
                Console.WriteLine("Finalizando pagamento");
            }
        }
    }
}