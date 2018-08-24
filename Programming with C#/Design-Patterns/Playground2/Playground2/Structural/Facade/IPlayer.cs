namespace Playground2.Structural.Facade
{
    public interface IPlayer
    {
        void Play();

        void Stop();

        void Load(MediaEntity media);
    }
}
