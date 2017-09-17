namespace Decorator
{
    public class ExtraOnion : Decorator
    {
        public ExtraOnion(AbstractBurger @base) : base(@base)
        {
            MName = "Extra Onion";
            MPrice = 1.0;
        }
    }
}
