using System.Text.Json.Serialization;

namespace MVCwithSwagger.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        [JsonIgnore]
        public ICollection<BookModel> Books { get; set; }
    }
}
