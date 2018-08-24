
namespace Playground2.Structural.Facade
{
    public static class FacadeMain
    {
        public static void Run()
        {
            var homeTheaterPro = HomeTheaterPro.CreateInstance();
            homeTheaterPro.InitHomeSystem();
            homeTheaterPro.DisplayAvailableMedia();
            homeTheaterPro.Next();
            homeTheaterPro.Next();
            homeTheaterPro.Previous();
            homeTheaterPro.Stop();
        }
    }
}