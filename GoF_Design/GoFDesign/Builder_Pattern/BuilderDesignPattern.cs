using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign.Builder_Pattern
{
    //Builder Pattern falls under Creational Pattern. It is used to build a complex object using a step by step approach
    //It provides an interface for creating parts of a product

    //Builder interface defines the steps to build the final object. This builder is independent of the objects creation process
    //A "Director" class controls the object creation process. 
    public class BuilderDesignPattern
    {
    }

    //public interface IBuilder
    //{
    //    void BuildPart1();
    //    void BuildPart2();
    //    void BuildPart3();
    //    Product GetProduct();
    //}

    //public class ConcreteBuilder : IBuilder
    //{
    //    private Product _product = new Product();

    //    public void BuildPart1()
    //    {
    //        _product.Part1 = "Part 1";
    //    }

    //    public void BuildPart2()
    //    {
    //        _product.Part2 = "Part 2";
    //    }

    //    public void BuildPart3()
    //    {
    //        _product.Part3 = "Part 3";
    //    }

    //    public Product GetProduct()
    //    {
    //        return _product;
    //    }
    //}

    //public class Product
    //{
    //    public string Part1 { get; set; }
    //    public string Part2 { get; set; }
    //    public string Part3 { get; set; }
    //}

    //public class Director
    //{
    //    public void Construct(IBuilder IBuilder)
    //    {
    //        IBuilder.BuildPart1();
    //        IBuilder.BuildPart2();
    //        IBuilder.BuildPart3();
    //    }
    //}
    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    /// 
    public interface IVehicleBuilder
    {
        Vehicle GetVehicle();
        void SetAccessories();
        void SetBody();
        void SetEngine();
        void SetModel();
        void SetTransmission();
    }
    /// <summary>
    /// The 'ConcreteBuilder1' class
    /// </summary>
    /// 
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Hero";
        }
        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }
        public void SetTransmission()
        {
            objVehicle.Transmission = "120 km/hr";
        }
        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }
        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    /// 
    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();

        public void SetModel()
        {
            objVehicle.Model = "Honda";
        }
        public void SetEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }
        public void SetTransmission()
        {
            objVehicle.Transmission = "125 km/hr";
        }
        public void SetBody()
        {
            objVehicle.Body = "Plastic";
        }
        public void SetAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        public string Body { get; set; }
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Transmission { get; set; }
        public List<string> Accessories { get; set; }

        //Object reference not set to an instance of an object.
        public Vehicle()
        {
            Accessories = new List<string>();
        }
        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Enginer: {0}", Engine);
            Console.WriteLine("Body: {0}", Body);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("Accessories");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
    ///<summary>
    ///The 'Director' class
    ///</summary>
    ///
    public class VehicleCreator
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
            objBuilder.SetBody();
            objBuilder.SetTransmission();
            objBuilder.SetAccessories();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}

///<summary>
///Use the builder pattern when you need to create an object in several steps
///The creation of objects should be independent of the way the object's parts are assembled.
///</summary>