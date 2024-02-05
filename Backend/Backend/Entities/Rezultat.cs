namespace Backend.Entities
{
    public class Rezultat
    {
        public string Proba { get; set; }
        public int Pozitie { get; set; }
        public double Timp1 { get; set; }
        public double Timp2 { get; set; }
        public double Timp3 { get; set; }
        public double Timp4 { get; set; }
        public double Timp5 { get; set; }
        public double Single { get; set; } 
        public double Average { get; set; }
        public Competitie? Competitie { get; set; }
        public int CompetitieId { get; set; }
        public Persoana? Persoana { get; set; }
        public int PersoanaId { get; set; }
    }
}
