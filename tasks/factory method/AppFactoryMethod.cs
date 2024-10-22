using VkiPetterns.config;
using VkiPetterns.tasks.factory_method.creator;
using VkiPetterns.tasks.factory_method.creator.releases;

namespace VkiPetterns.tasks.factory_method
{
    internal class AppFactoryMethod : Runnable
    {
        public void run()
        {
            Creator firstCreator = new FirstReleaseCreator();
            Console.WriteLine(firstCreator.anOperation("Первая фабрика"));

            Creator secondCreator = new SecondReleaseCreator();
            Console.WriteLine(secondCreator.anOperation("Вторая фабрика"));
        }
    }
}
