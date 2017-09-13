using System;

namespace Abstract_Factory
{
    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
