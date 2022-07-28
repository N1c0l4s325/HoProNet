namespace HoPro.net.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

        public string email { get; set; }

        public Country country { get; set; }
    }
}
