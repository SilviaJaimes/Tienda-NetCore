using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infraestructura.Data;
using Infraestructura.Repository;

namespace Infraestructura.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly APITiendaContext context;
    private PaisRepository _paises;

    public UnitOfWork(APITiendaContext _context)
    {
        context = _context;
    }

    public IPais Paises
    {
        get{
            if(_paises == null)
            {
                _paises = new PaisRepository(context);
            }
            return _paises;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}