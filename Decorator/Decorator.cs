namespace Decorator
{
    public abstract class Decorator : AbstractBurger
    {
        private readonly AbstractBurger _burgerBase;

        protected string MName = "Undefined Decorator";
        protected double MPrice = 0.0;

        protected Decorator(AbstractBurger @base)
        {
            _burgerBase = @base;
        }

        public override string GetName()
        {
            return $"{_burgerBase.GetName()}, {MName}";
        }

        public override double GetPrice()
        {
            return MPrice + _burgerBase.GetPrice();
        }
    }
}
