namespace Backend.Entities
{
    public class ContWCA
    {
        public int Id { get; set; }
        public string Wca_id { get; set; }
        public DateTime Data_crearii { get; set; }
        public Persoana Persoana { get; set; }
        public int Id_persoana { get; set; }
    }
}
