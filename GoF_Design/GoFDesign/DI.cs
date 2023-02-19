using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    //The principle says that high-level modules should depend on abstraction, not on the details, of low-level modules. In simple words, the principle says that there should not be a tight coupling among components of software and to avoid that, the components should depend on abstraction.
    public interface IAutomobile
    {
        void Ignition();
        void Stop();
    }

    public class Jeep : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("Jeep start");
        }

        public void Stop()
        {
            Console.WriteLine("Jeep stopped.");
        }
        #endregion
    }

    public class SUV : IAutomobile
    {
        #region IAutomobile Members
        public void Ignition()
        {
            Console.WriteLine("SUV start");
        }

        public void Stop()
        {
            Console.WriteLine("SUV stopped.");
        }
        #endregion
    }
    public class AutomobileController
    {
        IAutomobile m_Automobile;
        public AutomobileController(IAutomobile automobile)
        {
            this.m_Automobile = automobile;
        }
        public void Ignition()
        {
            m_Automobile.Ignition();
        }
        public void Stop()
        { m_Automobile.Stop(); }
    }
}
