using System;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // getWorld("Yicheng, ");
            await call();
        }

        public static string getWorld(string name) => getHello(name);
        public static string getHello(string name)
        {
            string nameStr = name + " hahaha!!!";
            Console.WriteLine("getHello: " + nameStr);
            return nameStr;
        }

        public static async Task<string> call()
        {
            Console.WriteLine("----------->1");
            int s = await foo();
            Console.WriteLine("----------->2");
            return "1";
        }

        public static async Task<int> foo()
        {
            Console.WriteLine("----------->3");
            await Task.Delay(500);
            Console.WriteLine("----------->4");
            return 1;
        }
    }
}
