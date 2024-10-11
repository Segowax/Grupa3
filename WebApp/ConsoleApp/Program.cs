using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(String[] args)
    {
        var a = new User();
        var b = new User();

        a.Name = "Jacek";
        
        b.Name = "Ania";

        b.Password = a.Password;

        a = new User()
        {  
            Password = b.Password
        };

        Console.WriteLine($"Name {a.Name} Password: {a.Password}");
        Console.WriteLine($"Name {b.Name} Pasword: {b.Password}");



    }
    internal class User
    {
        public string Name { get; set; } = string.Empty;
        public string Password { get; set; } = Random.Shared.Next(1000, 10000).ToString();
    }
}