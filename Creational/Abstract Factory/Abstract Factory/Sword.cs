using System;

namespace Abstract_Factory
{
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
