using VkiPetterns.config;
using VkiPetterns.tasks.factory_method;

internal class AppVki{
    public static void Main(string[] args){
        LoggerConfig.configure();

        Runnable task = new AppFactoryMethod();
        task.run();
    }
}