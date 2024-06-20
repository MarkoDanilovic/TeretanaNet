namespace Core.Entities;

public class GrupniTrening : BaseEntity
{
    public string TipTreninga { get; set; }
    
    public int GrupaId { get; set; }
    public virtual Grupa Grupa { get; set; }
}