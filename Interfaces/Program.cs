using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Payment : IPaymentManager // Herança do contrato a ser seguido
        {
            public DateTime GetDateTime { get; set; }
            public string GetZipcode { get; set; }

            public void GetPaymentDetails()
            {

            }
        }


        public interface IPaymentManager // 'I' para implementar interface ( Apenas regras de contratos, sem logica  )
        {
            DateTime GetDateTime { get; set; }

            String GetZipcode { get; set; }

            void GetPaymentDetails();

        }
    }
}
