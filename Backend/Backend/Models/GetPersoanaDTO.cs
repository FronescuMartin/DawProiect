﻿using Backend.Entities;
using System.Text.Json.Serialization;

namespace Backend.Models
{
    public class GetPersoanaDTO
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public DateTime Data_nasterii { get; set; }
 
        public int TaraId { get; set; }
    }
}
