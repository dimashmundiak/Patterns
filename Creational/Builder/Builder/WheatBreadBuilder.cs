namespace Builder
{
    public class WheatBreadBuilder : BreadBuilder
    {
        public override void SetWheatFlour()
        {
            Bread.WheatFlour = new Flour { Sort = "высший сорт" };
        }

        public override void SetRyeFlour()
        {
        }

        public override void SetSalt()
        {
            Bread.Salt = new Salt();
        }

        public override void SetAdditives()
        {
            Bread.Additives = new Additives { Name = "улучшитель хлебопекарный" };
        }
    }
}
