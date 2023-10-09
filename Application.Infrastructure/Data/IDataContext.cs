namespace Application.Infrastructure.Data
{
    public interface IDataContext
    {
        Task InitializeAsync();
    }
}