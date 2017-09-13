using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var computer = new Computer();
            computer.Launch("Windows 7");
            Console.WriteLine(computer.Os.Name);

            computer.Os = OS.GetInstance("Windows 10");
            Console.WriteLine(computer.Os.Name);

            Console.ReadLine();
        }
    }
}
