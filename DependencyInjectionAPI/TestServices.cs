using static DependencyInjectionAPI.IServices;

namespace DependencyInjectionAPI;

public class TestServices
{
    public class MyService : ITransientService, IScopedService, ISingletonService
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}