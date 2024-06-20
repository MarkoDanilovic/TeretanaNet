namespace Core.Entities;

public class Trening : BaseEntity
{
    public DateTimeOffset DatumTreninga { get; set; }
    
    public decimal Cena { get; set; }
    
    public int Trajanje { get; set; }
    
    public int TrenerId { get; set; }
    public virtual Trener Trener { get; set; }
    
    public virtual IndividualniTrening IndividualniTrening { get; set; }
    public virtual GrupniTrening GrupniTrening { get; set; }
}