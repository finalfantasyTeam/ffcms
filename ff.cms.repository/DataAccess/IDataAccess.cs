namespace ff.cms.repository.DataAccess
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    public interface IDataAccess<T>
    {
        SqlConnection ConnectData { get; }
        Task<IEnumerable<T>> GetAllAsync();
        T GetById(int id);
        Task<int> InsertDataAsync(T entity);
        Task<int> UpdateDataAsync(T entity);
        Task<int> DeleteDataAsync(T entity);
        Task<bool> DataExistedAsync(int id);
    }
}
