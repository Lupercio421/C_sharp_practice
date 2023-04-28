using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    internal class StrategyDesignPattern
    {
    }

    public class StrategyClient
    {
        public IStrategy Strategy { get; set; }
        
        public void CallAlgorithm()
        {
            Console.WriteLine(Strategy.Algorithm());
        }
    }

    public interface IStrategy
    {
        string Algorithm();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy A";
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public string Algorithm()
        {
            return "Concrete Strategy B";
        }
    }
}
