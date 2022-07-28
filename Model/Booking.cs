using System;

namespace HoPro.net.Model
{
    public class Booking
    {
      public int ID { get; set; }
      public DateTime booking_date { get; set; }
      public DateTime departure_date { get; set; }
      public DateTime entry_date { get; set; }
      public  Room room { get; set; }
      public  Client client { get; set; }

    }

    
}
