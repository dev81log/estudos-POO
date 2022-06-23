namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            // var payment = new List<Payment>(); // simples
            // IEnumerable<Payment> paymentCrediCard = new List<Payment>(); // complexos

            IList<Payment> payment = new List<Payment>(); // Ilist mais completo
            payment.Add(new Payment(1));
            payment.Add(new Payment(2));
            payment.Add(new Payment(3));
            payment.Add(new Payment(4));
            payment.Add(new Payment(5));

            foreach (var index in payment)
            {
                Console.WriteLine(index.Id);
            }

            foreach (var index in payment.Skip(2).Take(6)) // interagindo do segundo da lista ate o sexto
            {
                Console.WriteLine(index.Id);

            }

            var paymentCredicard = payment.First(x => x.Id == 3);
            var paymentApplePay = payment.Count(x => x.Id == 2);
            var paymentHubPay = payment.Remove(paymentCredicard);

            Console.WriteLine(paymentApplePay);

            payment.AsEnumerable(); // conversão da lista
            Console.WriteLine(payment.GetType().Name);
        }
    }

    public class Payment
    {
        public int Id { get; set; }

        public Payment(int id)
        {
            Id = id;
        }
    }
}


