namespace WIZfestival
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating a DI container
            var container = new DIContainer();

            // Registering services
            container.Register

            <IPerformanceService, MusicPerformanceService>();

            // Registering Festival class
            container.Register<Festival, Festival>();

            // Resolving dependencies
            Festival festival = container.Resolve<Festival>();

            // Starting the festival
            festival.Start();
        }
    }
}
