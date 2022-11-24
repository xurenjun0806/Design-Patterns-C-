// 工場クラス

namespace Design_Patterns_C_.CreationalPatterns.SimpleFactoryPattern
{
    class SimpleFactory
    {
        public static IProduct? GetProduct(string productType)
        {
            switch(productType)
            {
                case "A":
                    var productA = new ConcreteProductA();
                    return productA;
                
                case "B":
                    var productB = new ConcreteProductB();
                    return productB;
            }

            return null;
        }
    }
}