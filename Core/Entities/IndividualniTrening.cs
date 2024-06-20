using Core.Enums;

namespace Core.Entities;

public class IndividualniTrening : BaseEntity
{
    public TezinaTreninga TezinaTreninga { get; set; }
    
    public int ClanId { get; set; }
    public virtual Clan Clan { get; set; }
}