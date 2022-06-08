using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var sobrecargaExemplo = new MetodosSobrecargaDois(DateTime.Now);
            sobrecargaExemplo.Sobrecarga("string");
        }
    }

    public class MetodosSobrecarga
    {
        public DateTime HoraSobrecarga { get; set; }

        public MetodosSobrecarga(DateTime horaSobrecarga)
        {
            horaSobrecarga = DateTime.Now;
            Console.WriteLine("Inicando Metodo Construtor");
        }

        public virtual void Sobrecarga(string argument)
        {
            Console.WriteLine("sobrecarga 1 efetuado");
        }
    }

    public class MetodosSobrecargaDois : MetodosSobrecarga
    {
        public MetodosSobrecargaDois(DateTime horaSobrecarga) : base(horaSobrecarga) { }

        public override void Sobrecarga(string argument)
        {
            base.Sobrecarga(argument);
            Console.WriteLine("sobrecarga 2 efetuado");
        }
    }
}
