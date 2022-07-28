namespace HoPro.net.Model
{
    public class User
    {

        public int Id { get; set; }

        public string userName { get; set; }

        public string password { get; set; }

        public Access_area access_area { get; set; }

        public Employee employee { get; set; }
    }
}
