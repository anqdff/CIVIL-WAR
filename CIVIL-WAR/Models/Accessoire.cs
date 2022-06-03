namespace CIVIL_WAR.Models
{
    public class Accessoire
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Nom { get; set; }
        public string Fabriquant { get; set; }
        public string Description { get; set; }
        public int? CapaciteChargeur { get; set; }
        public string BallesChargeur { get; set; }
        public string TypeViseur { get;set; }
        public string Prix { get; set; }
        public string? Image1 { get; set; }
        public string? Image2 { get; set; }
    }
}
