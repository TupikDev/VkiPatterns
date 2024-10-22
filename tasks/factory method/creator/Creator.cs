using Serilog;

namespace VkiPetterns.tasks.factory_method.creator
{
    internal abstract class Creator
    {
        public abstract Product factoryMethod(string info);

        public string anOperation(string info)
        {

            Product product = factoryMethod(info);
            Log.Information("Вызов фабричного метода для продукта "+product.GetType().FullName);

            product.transform();
            
            return product.getInfo();
        }
    }
}
