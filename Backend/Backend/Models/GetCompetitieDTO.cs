using Backend.Entities;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class GetCompetitieDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Oras { get; set; }
        public DateTime Data { get; set; }
        public List<GetRezultatDTO> Rezultate { get; set; }
    }
}
