using System;

interface Shape
{
    string type 
    {
        get; 
        set;
    }

    void Draw();
}

class Circle : Shape
{
    private string _name = "Circle";

    public string type  
    {
        get => _name;
        set => _name = value;
    }

    public void Draw()
    {
        Console.WriteLine("Inside Circle...");
    }
}

class Rectangle : Shape
{
    private string _name = "Rectangle";

    public string type
    {
        get => _name;
        set => _name = value;
    }

    public void Draw()
    {
        Console.WriteLine("Inside Rectangle...");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Circle cobj = new Circle();
        Rectangle robj = new Rectangle();

        cobj.Draw();
        robj.Draw();

        Console.WriteLine(cobj.type);
        Console.WriteLine(robj.type);
    }
}