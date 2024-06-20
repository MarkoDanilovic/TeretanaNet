using Core.Enums;

namespace Core.Entities;

public class Grupa : BaseEntity
{
    public int MaxBrojClanova { get; set; }

    public StarosnaGrupa StarosnaGrupa { get; set; }
    
    public virtual ICollection<ClanGrupa> ClanGrupe { get; set; }
}