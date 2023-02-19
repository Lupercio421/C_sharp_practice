using GoFDesign;

class Program
{
    static void Main(string[] args)
    {
        IAutomobile automobile = new Jeep();
        AutomobileController automobileController = new AutomobileController(automobile);
        automobile.Ignition();
        automobile.Stop();
        Console.Read();
    }
    //static void Main(string[] args)
    //{
    //    Shape shape = new Circle();
    //    Console.WriteLine(shape.GetShape());
    //    shape = new Triangle();
    //    Console.WriteLine(shape.GetShape());
    //}
}