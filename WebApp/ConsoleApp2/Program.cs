internal class Program
{
    private static void Main(string[] args)
    {
        User daniel = new User();
        User juzer = new User();

        daniel.Name = "Daniel";
        daniel.Surname = "Harmasz";

        juzer.Name = "bombim";
        juzer.Surname = "bimbom/";

        Console.WriteLine($"old juzer \nName: {juzer.Name} Surname: {juzer.Surname}");

        juzer = new User()
        {
            Name = daniel.Name,
            Surname = daniel.Surname,
        };

        Console.WriteLine($"Name: {juzer.Name} Surname: {juzer.Surname}");
        Console.WriteLine($"new juzer \nName: {juzer.Name} Surname: {juzer.Surname}");
    }
}

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
}