namespace ff.cms.repository.DataEntities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public string ImageUrl { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateCreate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateUpdate { get; set; }
        public bool IsAvailable { get; set; }

        public virtual Author _author { get; set; }
    }
}
