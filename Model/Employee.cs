using System;

namespace HoPro.net.Model
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string Social_Security { get; set; }

        public DateTime Contract_date { get; set; }

        public string employee_type { get; set; }

        public decimal  Salary { get; set; }
    }
}
