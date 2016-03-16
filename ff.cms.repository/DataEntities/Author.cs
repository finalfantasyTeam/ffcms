namespace ff.cms.repository.DataEntities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateJoin { get; set; }
        public bool IsAvailable { get; set; }
    }
}
