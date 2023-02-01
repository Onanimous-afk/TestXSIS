using System.ComponentModel.DataAnnotations;

namespace TestXSIS.Data
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string title { get; set; }
        [MaxLength(4000)]
        public string description { get; set; }
        public float? rating { get; set; }
        [MaxLength(4000)]
        public string? image { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

    }
}
