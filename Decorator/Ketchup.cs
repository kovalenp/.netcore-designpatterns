namespace Decorator
{
    public class Ketchup : Decorator
    {
        public Ketchup(AbstractBurger @base) : base(@base)
        {
            MName = "Ketchup";
            MPrice = 2.0;
        }
    }
}
