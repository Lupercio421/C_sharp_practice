using GoFDesign;
using GoFDesign.test;
using static GoFDesign.ThirdPartyBillingSystem;

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
    #region ProtoTypeDesign
    //static void Main(string[] args)
    //{
    //    Developer dev = new Developer();
    //    dev.Name = "Raul";
    //    dev.Role = "Team Leader";
    //    dev.PreferredLanguage = "Spanish"; ;

    //    Developer devCopy = (Developer) dev.Clone();
    //    devCopy.Name = "Victor"; //Do not mention Role and PreferredLanguage, it will copy above
    //    Console.WriteLine(dev.GetDetails());
    //    Console.WriteLine(devCopy.GetDetails());

    //    Typist typist = new Typist();
    //    typist.Name = "Monu";
    //    typist.Role = "Typist";
    //    typist.WordsPerMinute = 120;

    //    Typist typistCopy = (Typist)typist.Clone();
    //    typistCopy.Name = "Sahil";
    //    typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

    //    Console.WriteLine(typist.GetDetails());
    //    Console.WriteLine(typistCopy.GetDetails());

    //    Console.ReadKey();
    //}
    #endregion
    #region Adapter Design Demo
    //static void Main(string[] args)
    //{
    //    ITarget ITarget = new EmployeeAdapter();
    //    ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(ITarget);
    //    client.ShowEmployeeList();
    //    Console.ReadKey();
    //}
    #endregion

    #region Singleton Design
    //static void Main(string[] args)
    //{
    //    Singleton.Instance.Show();
    //    Singleton.Instance.Show();
    //    Console.ReadKey();
    //}
    #endregion

    #region Async Example
    //static async Main()
    //{
    //    var asyncmethod = new AsyncLesson();

    //    asyncmethod.GetUrlContentLengthAsync();
    //}
    #endregion

    #region Strategy Deisgn
    static void Main()
    {
        StrategyClient client = new StrategyClient();
        ConcreteStrategyA concreteStrategyA = new ConcreteStrategyA();
        //client.CallAlgorithm();
        concreteStrategyA.Algorithm();
    }
    #endregion
}