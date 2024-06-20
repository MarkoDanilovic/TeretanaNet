using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

//[Authorize]
public class ClanController : BaseApiController
{
    private readonly IGenericRepository<Clan> _clanRepo;
    private readonly IMapper _mapper;
    private readonly StoreContext _context;

    public ClanController(IMapper mapper, IGenericRepository<Clan> clanRepo, StoreContext context)
    {
        _mapper = mapper;
        _clanRepo = clanRepo;
        _context = context;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ClanDto>> GetClanById(int id)
    {
        //var spec = new ClanSpecification(id);
        //var clan = await _clanRepo.GetEntityWithSpec(spec);
        var clan = await _clanRepo.GetByIdAsync(id);

        return _mapper.Map<Clan, ClanDto>(clan);
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Clan>>> GetClanovi()
    {
        var clanovi = await _clanRepo.ListAllAsync();
        var clanoviDto = _mapper.Map<IReadOnlyList<Clan>, IReadOnlyList<ClanDto>>(clanovi);

        return Ok(clanoviDto);
    }
}