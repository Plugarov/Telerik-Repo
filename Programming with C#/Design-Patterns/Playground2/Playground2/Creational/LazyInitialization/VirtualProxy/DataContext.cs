namespace Playground2.Creational.LazyInitialization.VirtualProxy
{
    public class DataContext
    {
        public User GetUserById(int id)
        {
            return new UserProxy
            {
                Id = id,
            };
        }
    }
}
