using System;

namespace HoPro.net.Model
{
    public class Consumption
    {
        public int Id { get; set; }
        DateTime date_consuption { get; set; }

        public Product product { get; set;}
        
        public int quantity { get; set; }

        public decimal total { get; set; }


    }
}
