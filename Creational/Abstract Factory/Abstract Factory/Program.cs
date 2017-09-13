using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var elfHero = new Hero(new ElfFactory());
            elfHero.Hit();
            elfHero.Run();

            var wariorHero = new Hero(new WariorFactory());
            wariorHero.Hit();
            wariorHero.Run();

            Console.ReadLine();
        }
    }
}
