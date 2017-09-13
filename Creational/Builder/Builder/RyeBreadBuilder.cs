namespace Builder
{
    public class RyeBreadBuilder : BreadBuilder
    {
        public override void SetWheatFlour()
        {
        }

        public override void SetRyeFlour()
        {
            Bread.RyeFlour = new Flour { Sort = "1 сорт" };
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
        }
    }
}
