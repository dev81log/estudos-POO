using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var sobrecargaExemplo = new MetodosSobrecargaDois();
            sobrecargaExemplo.Sobrecarga("string");
        }
    }

    public class MetodosSobrecarga
    {
        public virtual void Sobrecarga(string argument)
        {
            Console.WriteLine("sobrecarga 1 efetuado");
        }
    }

    public class MetodosSobrecargaDois : MetodosSobrecarga
    {
        public override void Sobrecarga(string argument)
        {
            base.Sobrecarga(argument);
            Console.WriteLine("sobrecarga 2 efetuado");
        }
    }
}
