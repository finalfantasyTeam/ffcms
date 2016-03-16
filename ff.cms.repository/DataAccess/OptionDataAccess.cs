namespace ff.cms.repository.DataAccess
{
    using DataEntities;
    using Dapper;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class OptionDataAccess : BaseDataAccess<Option>
    {
        public OptionDataAccess() : base()
        { }

        public override async Task<IEnumerable<Option>> GetAllAsync()
        {
            string sql = @"SELECT * FROM Option";
            IEnumerable<Option> data = await ConnectData.QueryAsync<Option>(sql);

            return data;
        }

        public override Option GetById(int id)
        {
            string sql = @"SELECT * FROM Option WHERE Id = @optionId";
            Option data = ConnectData.Query<Option>(sql, id).Single();

            return data;
        }

        public Option GetBykey(string key)
        {
            string sql = @"SELECT * FROM Option WHERE StrKey = @optionId";
            Option data = ConnectData.Query<Option>(sql, key).Single();

            return data;
        }

        public override async Task<int> InsertDataAsync(Option entity)
        {
            string sql = @"INSER INTO Option
                            (StrKey,
                            StrValue,
                            IsApplied,
                            DateCreate,
                            UserModified) 
                            VALUES (@key, @val, @isApplied, @createDate, @userName)";

            int result = await ConnectData.ExecuteAsync(sql, new { entity.StrKey, entity.StrValue, entity.IsApplied, entity.DateCreate, entity.UserModified });

            return result;
        }

        public override async Task<int> UpdateDataAsync(Option entity)
        {
            string sql = @"UPDATE Option SET 
                            StrKey = @key,
                            StrValue = @val,
                            IsApplied = @isApplied,
                            DateCreate = @createDate,
                            DateUpdate = @createUpdate,
                            UserModified = @userName
                            WHERE Id = @id";

            int result = await ConnectData.ExecuteAsync(sql, new { entity.StrKey, entity.StrValue, entity.IsApplied, entity.DateCreate, entity.DateUpdate, entity.UserModified, entity.Id });

            return result;
        }

        public override async Task<int> DeleteDataAsync(Option entity)
        {
            string sql = @"DELETE FROM Option WHERE Id = @id";
            int result = await ConnectData.ExecuteAsync(sql, entity.Id);

            return result;
        }

        public override async Task<bool> DataExistedAsync(int id)
        {
            string sql = @"SELECT count(*) FROM Option WHERE Id = @id";
            int result = await ConnectData.ExecuteScalarAsync<int>(sql, id);

            return result > 0;
        }
    }
}
