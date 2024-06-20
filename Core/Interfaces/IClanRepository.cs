using Core.Entities;

namespace Core.Interfaces;

public interface IClanRepository
{
    Task<Clan> CreateClanAsync(string imePrezime, string brojTelefona, DateTimeOffset datumRodjenja);
    Task<IReadOnlyList<Clan>> GetClanByNameAsync(string imePrezime);
    Task<Clan> GetClanByIdAsync(int id);
    Task<IReadOnlyList<Clan>> GetClanovi();//?
}