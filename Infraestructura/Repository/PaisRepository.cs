using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Infraestructura.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.RepositoryM;
public class PaisRepository : GenericRepository<Pais>, IPais
{
    private readonly APITiendaContext _context;
    public PaisRepository(APITiendaContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<Pais>> GetAllAsync()
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .ToListAsync();
    }

    public override async Task<Pais> GetByIdAsync(int id)
    {
        return await _context.Paises
            .Include(p => p.Estados)
            .FirstOrDefaultAsync(p => p.Id == id);
    }
}