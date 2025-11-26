namespace DependencyInjectionAPI
{
    public class Services
    {
        public interface IMyService
        {
            Guid Id { get; }
        }

        public class MyService : IMyService
        {
            public Guid Id { get; } = Guid.NewGuid();
        }

    }
}
