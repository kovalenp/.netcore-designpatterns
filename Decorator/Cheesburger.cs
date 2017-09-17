namespace Decorator
{
    public class Cheesburger : AbstractBurger
    {
        private string _name = "Cheesburger";
        private double _price = 15.0;

        public override string GetName()
        {
            return _name;
        }

        public override double GetPrice()
        {
            return _price;
        }
    }
}
