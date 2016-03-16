namespace ff.cms.repository.DataAccess
{
    using System.Collections.Generic;
    using System.Linq;
    using Dapper;
    using System.Threading.Tasks;
    using DataEntities;

    public class PostDataAccess : BaseDataAccess<Post>
    {
        public PostDataAccess() : base()
        { }

        public override async Task<IEnumerable<Post>> GetAllAsync()
        {
            string sql = @"SELECT * FROM Post";
            IEnumerable<Post> data = await ConnectData.QueryAsync<Post>(sql);

            return data;
        }

        public override Post GetById(int id)
        {
            string sql = @"SELECT * FROM Post WHERE Id = @postId";
            Post data = ConnectData.Query<Post>(sql, id).Single();

            return data;
        }

        public override async Task<int> InsertDataAsync(Post entity)
        {
            string sql = @"INSER INTO Post
                            (Title,
                            Excerpt,
                            Content,
                            AuthorId,
                            ImageUrl,
                            DateCreate,
                            IsAvailable) 
                            VALUES (@title, @excrept, @content, @author, @image, @createDate, @isAvailable)";

            int result = await ConnectData.ExecuteAsync(sql, new { entity.Title, entity.Excerpt, entity.Content, entity.AuthorId, entity.ImageUrl, entity.DateCreate, entity.IsAvailable });

            return result;
        }

        public override async Task<int> UpdateDataAsync(Post entity)
        {
            string sql = @"UPDATE Post SET 
                            Title = @title,
                            Excerpt = @excrept,
                            Content = @content,
                            AuthorId =  @author,
                            ImageUrl =  @image,
                            DateCreate = @createDate,
                            DateUpdate = @createUpdate,
                            IsAvailable = @available
                            WHERE Id = @id";

            int result = await ConnectData.ExecuteAsync(sql, new { entity.Title, entity.Excerpt, entity.Content, entity.AuthorId, entity.ImageUrl, entity.DateCreate, entity.DateUpdate, entity.IsAvailable, entity.Id });

            return result;
        }

        public override async Task<int> DeleteDataAsync(Post entity)
        {
            string sql = @"DELETE FROM Post WHERE Id = @id";
            int result = await ConnectData.ExecuteAsync(sql, entity.Id);

            return result;
        }

        public override async Task<bool> DataExistedAsync(int id)
        {
            string sql = @"SELECT count(*) FROM Post WHERE Id = @id";
            int result = await ConnectData.ExecuteScalarAsync<int>(sql, id);

            return result > 0;
        }
    }
}
