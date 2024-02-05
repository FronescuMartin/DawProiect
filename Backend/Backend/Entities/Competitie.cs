using System.Drawing;
using System.Text.Json.Serialization;

namespace Backend.Entities
{
    public class Competitie
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Oras { get; set; }
        public DateTime Data {  get; set; }
        [JsonIgnore]
        public ICollection<Rezultat> Rezultate { get; }
    }
}
