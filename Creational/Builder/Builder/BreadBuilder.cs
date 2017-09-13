namespace Builder
{
    public abstract class BreadBuilder
    {
        public Bread Bread { get; private set; }
        public void CreateBread()
        {
            Bread = new Bread();
        }
        public abstract void SetWheatFlour();
        public abstract void SetRyeFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
