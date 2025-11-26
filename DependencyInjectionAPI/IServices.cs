namespace DependencyInjectionAPI;

public interface IServices
{
    public interface ITransientService
    {
        Guid Id { get; }
    }

    public interface IScopedService
    {
        Guid Id { get; }
    }

    public interface ISingletonService
    {
        Guid Id { get; }
    }
}