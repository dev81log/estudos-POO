namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var paymentApi = new PaymentApi();
            var payment = new Payment // instancia classes parciais vindo de Payment e PaymentCrediCard
            {
                PaymentA = "Payment Type normal",
                PaymentB = "Payment Type credit card"
            }; 
        }

        public sealed class PaymentApi // sealed garante que a classe Payment não irá sofrer mudanças em heranças
        {
            public PaymentApi()
            {
                var apiUrl = ConfigPayment.API_URL;
            }
        }

        private static class
            ConfigPayment // classe static nunca vai modificar seu estado, ideal para manter a mesma informação para N usuarios
        {
            public static string API_URL { get; set; }
        }
    }
}