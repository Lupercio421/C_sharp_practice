using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFDesign.test
{
    public class AsyncLesson
    {
        public async Task<int> GetUrlContentLengthAsync()
        {
            var client = new HttpClient();

            Task<string> getStringTask = client.GetStringAsync("https://learn.microsoft.com/dotnet");

            DoIndependentWork();

            string contents = await getStringTask;

            return contents.Length;
        }

        void DoIndependentWork()
        {
            Console.WriteLine("Working");
        }
    }
}
