using System;
using System.Threading.Tasks;
using Company.Name;

namespace GetAwaiterBug
{
    class Program
    {
        static async Task Main()
        {
            Console.WriteLine("using System;");
            await new ProgressToken();
        }
    }
}
