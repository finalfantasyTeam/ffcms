namespace ff.cms.repository.DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Threading.Tasks;
    public class BaseDataAccess<T> : IDataAccess<T>
    {
        #pragma warning disable CS0618, CS1998
        public BaseDataAccess() : base()
        {
            string connectionString = ConfigurationSettings.AppSettings["FFCMSContext"].ToString();
            _connectData = new SqlConnection(connectionString);
        }

        protected SqlConnection _connectData;

        public SqlConnection ConnectData
        {
            get { return _connectData; }
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<int> InsertDataAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<int> UpdateDataAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<int> DeleteDataAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<bool> DataExistedAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
