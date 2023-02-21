interface IMyCarInterface
{
    string License { get; set; }
    string Name { get; set; }
    string Car { get; set; }
}

public class MyCar : IMyCarInterface
{
    public string license = "#S52GL2M";
    public string name = "Deland Chen";
    public string car = "";
    public readonly string[] tickets = new string[8];

    public string this[int i]
    {
        get { return tickets[i]; }
        set { tickets[i] = value; }
    }


    public string License
    {
        get { return license; }
        set { license = value; }
    }

    public string Name
    {
        get { return name.ToUpper(); }
        set
        {
            if (value != name)
                name = value;
        }
    }
    public string Car
    {
        get { return car.ToUpper(); }
        set { car = value; }
    }

}

class Program
{
    static void Main()
    {
        var myCar = new MyCar { car = "Toyota Prius" };
        Console.WriteLine(myCar.car);
    }
}