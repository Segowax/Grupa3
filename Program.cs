internal class Program
{
    public static void Main(string[] args)
    {
        var a = new User();
        var b = new User();

        a.Name = "Jacek";
        a.Password = "password21321";

        b.Name = "Ania";
        b.Password = "passwordAni";

        //a = b;

        a.Name = "Ania";
        b.Name = "Jacek";

        a.Password = "paswordAni";
        b.Password = "passwor1212d";

        a = new User()
        {
            Name = b.Name,
            Password = a.Password,
        };
        

        Console.WriteLine($"A Name - {a.Name} Password - {a.Password}");
        Console.WriteLine($"B Name - {b.Name} password - {b.Password}");
       
    }
    internal class User
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
    }

}
