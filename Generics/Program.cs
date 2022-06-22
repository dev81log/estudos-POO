namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var payment = new Payment();
            var person = new Person();
            var subscription = new Subscription();
            var context = new DataContext<Payment, Person, Subscription>();
            context.Save(payment);
            context.Save(person);
            context.Save(subscription);
        }
    }

    public class DataContext<P, PP, S>
        where P : Payment
        where PP : Person
        where S : Subscription
        // antes da chave
    {

        public void Save(P entity)
        {

        }

        public void Save(PP entity)
        {

        }

        public void Save(S entity)
        {

        }
    }

    public class Payment { }

    public class Person { }

    public class Subscription { }
}
