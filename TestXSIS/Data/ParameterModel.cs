using System.ComponentModel.DataAnnotations;

namespace TestXSIS.Data
{
    public class ParamMovie
    {
        public string title { get; set; }
        public string description { get; set; }
        public float? rating { get; set; }
        public string? image { get; set; }
    }
}
