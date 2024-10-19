using System.Numerics;

internal class Employee
{
    private string name;
    private string dob; 
    private string phone;
    private string email;
    private string post;
    private string[] responsibilities;

    public Employee()
    {
        name = "NULL";
        dob = "NULL";
        phone = "NULL";
        email = "NULL";
        post = "NULL";
        responsibilities = new string[] { };
    }

    public Employee(string name, string dob, string phone, string email, string post, string[] responsibilities)
    {
        this.name = name;
        this.dob = dob;
        this.phone = phone;
        this.email = email;
        this.post = post;
        this.responsibilities = responsibilities;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string DOB
    {
        get { return dob; } 
        set { dob = value; } 
    }

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Post
    {
        get { return post; }
        set { post = value; }
    }

    public string[] Responsibilities
    {
        get { return responsibilities; }
        set { responsibilities = value; }
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
        string responsibilitiesInput = Console.ReadLine();
        Responsibilities = responsibilitiesInput.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries); 
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
    private string name;
    private string manufacture;
    private int year;
    private string type;
    public Plane()
    {
        name = "NULL";
        manufacture = "NULL";
        year = 0;
        type = "NULL";
    }
    public Plane(string name, string manufacture, int year, string type)
    {
        this.name = name;
        this.manufacture = manufacture;
        this.year = year;
        this.type = type;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Manufacture
    {
        get { return manufacture; }
        set { manufacture = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public string Type
    {
        get { return type; }
        set { type = value; }
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