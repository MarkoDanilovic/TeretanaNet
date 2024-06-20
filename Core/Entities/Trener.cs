namespace Core.Entities;

public class Trener : BaseEntity
{
    public string ImePrezime { get; set; }

    public string BrojTelefona { get; set; }
    
    public virtual ICollection<Trening> Treninzi { get; set; }
}