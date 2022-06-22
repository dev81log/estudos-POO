namespace EventEstudos
{
    class Program
    {
        static void Main(string[] args)
        {
            var seats = new Room(3);
            seats.RoomSoldOutEvent += OnRoomSoldOut;
            seats.ReserveSeat();
            seats.ReserveSeat();
            seats.ReserveSeat();
            seats.ReserveSeat();
            seats.ReserveSeat();
            seats.ReserveSeat();

        }

        static void OnRoomSoldOut(object sender, EventArgs e)
        {
            Console.WriteLine("Sala lotada");
        }
    }

    public class Room
    {
        public Room(int seats)
        {
            Seats = seats;
            seatsInUse = 0;

        }

        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado");
            }
        }

        public event EventHandler RoomSoldOutEvent; // apenas uma assinatura

        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e); // ? porque o evento pode vir null
        }

    }
}
