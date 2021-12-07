using System;
using System.Threading.Tasks;

namespace train12306
{
    internal class Program
    {
        public static async Task Main()
        {
            var train = new Train();
            await train.StartAsync();
            Console.ReadKey();
        }
    }
}
