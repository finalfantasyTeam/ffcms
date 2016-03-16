namespace ff.cms.repository.DataEntities
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    public class Option
    {
        public int Id { get; set; }
        public string StrKey { get; set; }
        public string StrValue { get; set; }
        public bool IsApplied { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateCreate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateUpdate { get; set; }
        public string UserModified { get; set; }
    }
}
