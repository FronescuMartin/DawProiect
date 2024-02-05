using Backend.Entities;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class PostPersoanaDTO
    {
        public string Nume { get; set; }
        public DateTime Data_nasterii { get; set; }
        public int TaraId { get; set; }
    }
}
