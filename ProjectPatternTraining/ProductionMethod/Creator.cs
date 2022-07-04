namespace ProjectPatternTraining.ProductionMethod
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public void Operation()
        {
            var product = FactoryMethod();
            product.Method();
        }
    }
}