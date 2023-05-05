namespace Application.Context
{
    public interface IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}