using GoFDesign;

class Program
{
    //static void Main(string[] args)
    //{
    //    IAutomobile automobile = new Jeep();
    //    AutomobileController automobileController = new AutomobileController(automobile);
    //    automobile.Ignition();
    //    automobile.Stop();
    //    Console.Read();
    //}
    //static void Main(string[] args)
    //{
    //    Shape shape = new Circle();
    //    Console.WriteLine(shape.GetShape());
    //    shape = new Triangle();
    //    Console.WriteLine(shape.GetShape());
    //}
    static void Main(string[] args)
    {
        Developer dev = new Developer();
        dev.Name = "Raul";
        dev.Role = "Team Leader";
        dev.PreferredLanguage = "Spanish"; ;

        Developer devCopy = (Developer) dev.Clone();
        devCopy.Name = "Victor"; //Do not mention Role and PreferredLanguage, it will copy above
        Console.WriteLine(dev.GetDetails());
        Console.WriteLine(devCopy.GetDetails());

        Typist typist = new Typist();
        typist.Name = "Monu";
        typist.Role = "Typist";
        typist.WordsPerMinute = 120;

        Typist typistCopy = (Typist)typist.Clone();
        typistCopy.Name = "Sahil";
        typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

        Console.WriteLine(typist.GetDetails());
        Console.WriteLine(typistCopy.GetDetails());

        Console.ReadKey();
    }
}