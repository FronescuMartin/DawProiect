using System.Text.Json.Serialization;

namespace Backend.Entities
{
    public class Persoana
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public DateTime Data_nasterii { get; set; }
        [JsonIgnore]
        public ICollection<Rezultat> Rezultate { get; }
        public Tara? Tara { get; set; }
        public int TaraId { get; set; }
        public ContWCA ContWCA { get; set; }

        
    }
}
