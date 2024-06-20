namespace Core.Entities;

public class Clan : BaseEntity
{
    public string ImePrezime { get; set; }

    public string BrojTelefona { get; set; }

    public DateTimeOffset DatumRodjenja { get; set; }
    
    public virtual ICollection<IndividualniTrening> IndividualniTreninzi { get; set; }
    public virtual ICollection<ClanGrupa> ClanGrupe { get; set; }
}