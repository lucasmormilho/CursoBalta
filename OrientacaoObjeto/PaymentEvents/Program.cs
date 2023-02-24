namespace PaymentEvents;
class Program
{
    static void Main(string[] args)
    {
        var room = new Room(3);
        //delegate do evento
        room.RoomSoldOutEvent += OnRoomSoldOut;
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
        room.ReserveSeat();
    }

    static void OnRoomSoldOut(object sender, EventArgs e)
    {
        System.Console.WriteLine("Sala lotada");
    }
}

public class Room
{
    //ctor
    public Room(int seats)
    {
        Seats = seats;
        SeatsInUse = 0;
    }

    //privada pois ningume precisa saber
    private int SeatsInUse = 0;

    public int Seats { get; set; }

    public void ReserveSeat()
    {
        SeatsInUse++;
        if (SeatsInUse >= Seats)
        {
            OnRoomSoldOut(EventArgs.Empty);
        }
        else
        {
            System.Console.WriteLine("Reserved Seats");
        }
    }


    //definição do evento
    public event EventHandler RoomSoldOutEvent;
    //implementaçao base do evento
    protected virtual void OnRoomSoldOut(EventArgs e)
    {
        EventHandler handler = RoomSoldOutEvent;
        handler?.Invoke(this, e);
    }

}
