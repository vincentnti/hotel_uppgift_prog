using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest guest1 = new Guest(
                "Stefan Göran",
                69,
                "07238849393",
                "Skogen",
                69
            );
            Console.WriteLine(guest1.Name);
            guest1.CheckIn();
            guest1.OrderFood();
            guest1.PayBill();
            guest1.CheckOut();
        }
    }
}
