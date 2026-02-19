using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaApi.Data;
using MinhaApi.Entities;

[ApiController]
[Route("api/equipamentos")]
public class EquipamentosController : ControllerBase
{
    private readonly AppDbContext _context;

    public EquipamentosController(AppDbContext context)
    {
        _context = context;
    }

    // POST
    [HttpPost]
    public async Task<IActionResult> Create(CreateEquipamentoDto dto)
    {
        dto.Codigo = dto.Codigo.Trim();

        if (await _context.Equipamentos.AnyAsync(e => e.Codigo == dto.Codigo))
            return Conflict("Código já existe.");

        var equipamento = new Equipamento
        {
            Codigo = dto.Codigo,
            Tipo = dto.Tipo,
            Modelo = dto.Modelo,
            Horimetro = dto.Horimetro,
            StatusOperacional = dto.StatusOperacional,
            DataAquisicao = dto.DataAquisicao,
            LocalizacaoAtual = dto.LocalizacaoAtual
        };

        _context.Add(equipamento);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = equipamento.Id }, equipamento);
    }

    // GET com paginação e filtros
    [HttpGet]
    public async Task<IActionResult> GetAll(
        int page = 1,
        int pageSize = 10,
        string? tipo = null,
        string? status = null,
        string? codigo = null)
    {
        var query = _context.Equipamentos.AsQueryable();

        if (!string.IsNullOrEmpty(tipo))
            query = query.Where(e => e.Tipo.ToString() == tipo);

        if (!string.IsNullOrEmpty(status))
            query = query.Where(e => e.StatusOperacional.ToString() == status);

        if (!string.IsNullOrEmpty(codigo))
            query = query.Where(e => e.Codigo.Contains(codigo));

        var total = await query.CountAsync();

        var data = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return Ok(new { total, page, pageSize, data });
    }

    // GET por id
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var equipamento = await _context.Equipamentos.FindAsync(id);
        if (equipamento == null) return NotFound();

        return Ok(equipamento);
    }

    // PUT
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, CreateEquipamentoDto dto)
    {
        var equipamento = await _context.Equipamentos.FindAsync(id);
        if (equipamento == null) return NotFound();

        equipamento.Modelo = dto.Modelo;
        equipamento.Tipo = dto.Tipo;
        equipamento.Horimetro = dto.Horimetro;
        equipamento.StatusOperacional = dto.StatusOperacional;
        equipamento.DataAquisicao = dto.DataAquisicao;
        equipamento.LocalizacaoAtual = dto.LocalizacaoAtual;

        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var equipamento = await _context.Equipamentos.FindAsync(id);
        if (equipamento == null) return NotFound();

        _context.Remove(equipamento);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}