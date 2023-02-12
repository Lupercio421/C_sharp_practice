using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos_DB_Bulk
{
    public class MIDField
    {
        public static async Task<string> MIDGenerator()
        {
            Random ran = new Random();
            String b = "!@#$%^&*~abcdefghijklmnopqrstuvwxyz0123456789";
            int length = 8;
            String random = "";
            for (int i = 0; i < length; i++)
            {
                int a = ran.Next(b.Length);
                random = random + b.ElementAt(a);
            }
            Console.WriteLine("The random alphabet generated is: {0}", random);
            return random;
        }

    }
}
