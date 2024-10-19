

internal class Employee
{
 
    public string Name { get; set; } = "NULL";
    public string DOB { get; set; } = "NULL";
    public string Phone { get; set; } = "NULL";
    public string Email { get; set; } = "NULL";
    public string Post { get; set; } = "NULL";
    public string[] Responsibilities { get; set; } = Array.Empty<string>();

    public Employee() { }

    public Employee(string name, string dob, string phone, string email, string post, string[] responsibilities)
    {
        Name = name;
        DOB = dob;
        Phone = phone;
        Email = email;
        Post = post;
        Responsibilities = responsibilities;
    }
    public void CreateEmployee()
    {
        Console.Write("Enter Employee Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Employee DOB (yyyy-mm-dd): ");
        DOB = Console.ReadLine();

        Console.Write("Enter Employee Phone: ");
        Phone = Console.ReadLine();

        Console.Write("Enter Employee Email: ");
        Email = Console.ReadLine();

        Console.Write("Enter Employee Post: ");
        Post = Console.ReadLine();

        Console.Write("Enter Employee Responsibilities (comma separated): ");
        string input = Console.ReadLine();
        Responsibilities = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date of Birth: {DOB}");
        Console.WriteLine($"Phone: {Phone}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Post: {Post}");
        Console.WriteLine("Responsibilities: " + string.Join(", ", Responsibilities));
    }
}


internal class Plane
{

    public string Name { get; set; } = "NULL";
    public string Manufacture { get; set; } = "NULL";
    public int Year { get; set; } = 0;
    public string Type { get; set; } = "NULL";

    public Plane() { }

    public Plane(string name, string manufacture, int year, string type)
    {
        Name = name;
        Manufacture = manufacture;
        Year = year;
        Type = type;
    }
    public void CreatePlane()
    {
        Console.Write("Enter plane's name: ");
        Name = Console.ReadLine();

        Console.Write("Enter plane's manufacture: ");
        Manufacture = Console.ReadLine();

        Console.Write("Enter plane's year: ");
        Year = int.Parse(Console.ReadLine());

        Console.Write("Enter plane's type: ");
        Type = Console.ReadLine();
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Manufacture: {Manufacture}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Type: {Type}");
    }
}
