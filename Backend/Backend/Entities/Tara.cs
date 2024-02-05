using System.Drawing;
using System.Text.Json.Serialization;

namespace Backend.Entities
{
    public class Tara
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Iso2 { get; set; }
        public string Continent { get; set; }
        [JsonIgnore]
        public ICollection<Persoana> Persoane { get; }

    }
}
