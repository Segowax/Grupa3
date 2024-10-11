namespace ConsoleApp
{
    public class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }

        static void Main(string[] args)
        {
            var a = new User();
            var b = new User();

            a.Name = "Ivan";
            a.Password = "password";

            b.Name = "Oleg";
            b.Password = "password1";

            a = b;

            a = new User()
            {
                Name = b.Name,
                Password = b.Password
            };

            b.Name = "Timur";

            Console.WriteLine($"Name: {a.Name}, Password: {a.Password}");

            Console.WriteLine($"Name: {b.Name}, Password: {b.Password}");
        }
    }
}