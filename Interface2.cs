using System;

interface IEmployee
{
    string Name
    {
        get;
        set;
    }

    int Counter
    {
        get;
    }
}

public class Employee : IEmployee
{
    //public static int numberOfEmployees;

    private string _name = "Pranav";
    public string Name  // read-write instance property
    {
        get => _name;
        set => _name = value;
    }

    private int _counter = 11;
    public int Counter  // read-only instance property
    {
        get => _counter;
    }

    // constructor
    //public Employee() => _counter = ++numberOfEmployees;
}

class MainClass
{
    public static void Main(string[] args)
    {
        Employee obj = new Employee();
        
        Console.WriteLine(obj.Counter);
        Console.WriteLine(obj.Name);
    }
}