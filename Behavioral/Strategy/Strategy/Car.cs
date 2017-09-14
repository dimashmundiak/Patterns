namespace Strategy
{
    public class Car
    {
        protected int Passengers;
        protected string Model;
        public IMovable Movable { get; set; }

        public Car(int passengers, string model, IMovable movable)
        {
            this.Passengers = passengers;
            this.Model = model;
            Movable = movable;
        }

        public void Move()
        {
            Movable.Move();
        }

    }
}
