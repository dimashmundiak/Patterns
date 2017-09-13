using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new PanelDeveloper("Test name");
            var panelHouse = developer.Create();
            developer = new WoodDeveloper("Test name");
            var woodHouse = developer.Create();
            Console.ReadLine();
        }
    }
}
