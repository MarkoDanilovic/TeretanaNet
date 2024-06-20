namespace Core.Entities;

public class ClanGrupa//nisam dodao : BaseEntity, jer je slozeni kljuc
{
    public int ClanId { get; set; }
    
    public int GrupaId { get; set; }

    public virtual Clan Clan { get; set; }
    public virtual Grupa Grupa { get; set; }
}