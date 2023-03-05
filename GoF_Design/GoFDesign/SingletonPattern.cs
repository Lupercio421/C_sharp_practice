using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign
{
    //This pattern ensures that a class has only one instance and provides a global point of access to it
    public class Singleton
    {
        //The Singleton is a class that is responsible for creating and maintaining its own unique instance
        // .NET guarantees thread safety for static initialization
        private static Singleton instance = null;
        private static string Name { get; set; }
        private string IP { get; set; }
        private Singleton() 
        {
            //Console.WriteLine("Singleton Instance");
            Name = "Server 1";
            IP = "192.168.1.23";
        }
        // Lock synchronization object
        private static object syncLock = new object();
        public static Singleton Instance
        {
            get 
            {
                // Support multithreaded applications through
                // 'Double checked locking' pattern which (once
                // the instance exists) avoids locking each
                // time the method is invoked
                lock (syncLock)
                {
                    if (Singleton.instance == null)
                    {
                        Singleton.instance = new Singleton();
                    }
                    return Singleton.instance;
                }
            }
        }
        public void Show()
        {
            Console.WriteLine("Server Information is : Name = {0} & IP = {1}", IP, Name);
        }
    }
}
