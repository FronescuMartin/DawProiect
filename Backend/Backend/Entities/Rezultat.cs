namespace Backend.Entities
{
    public class Rezultat
    {
        public int Id { get; set; }
        public string Proba { get; set; }
        public string Name { get; set; }
        public int Pozitie { get; set; }
        public double Timp1 { get; set; }
        public double Timp2 { get; set; }
        public double Timp3 { get; set; }
        public double Timp4 { get; set; }
        public double Timp5 { get; set; }
        public double Single { get; set; } 
        public double Average { get; set; }
        public Competitie? Competitie { get; set; }
        public int Id_competitie { get; set; }
        public Persoana? Persoana { get; set; }
        public int Id_persoana { get; set; }
    }
}
