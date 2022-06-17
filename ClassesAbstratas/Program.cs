using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var paymentCrediCard = new PaymentCrediCard();
            var PaymentApplePayment = new PaymentApplePayment();

        }

        public abstract class Payment : IPaymentManager // Classe abstrata(não pode ser instanciando) Herança do contrato a ser seguido
        {
            public virtual DateTime GetDateTime { get; set; } // variaveis sendo virtual 
            public virtual string GetZipcode { get; set; }
            public virtual void GetPaymentDetails(double value)
            {

            }
        }

        public class PaymentCrediCard : Payment // herança de Payment 
        {
            public override void GetPaymentDetails(double value) // variaveis sobrescrevendo virtual
            {
                base.GetPaymentDetails(value);
            }
        }

        public class PaymentApplePayment : Payment // Herança de Payment
        {
            public override void GetPaymentDetails(double value)
            {
                base.GetPaymentDetails(value);
            }
        }


        public interface IPaymentManager // 'I' para implementar interface ( Apenas regras de contratos, sem logica  )
        {
            DateTime GetDateTime { get; set; }
            String GetZipcode { get; set; }
            void GetPaymentDetails(double value);
        }
    }
}
