using Microsoft.EntityFrameworkCore;
using RecepcionMercancia;
using System.Linq.Expressions;

namespace AccesDataBase.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;

    public async Task<T> ObtenerPorId(Expression<Func<T, bool>> condicion)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(condicion);
    }
    public async Task<List<Producto>> ObtenerListado()
    {
        return await _context.Set<Producto>().ToListAsync(); 
    }
    public async Task<List<T>> ObtenerListaPorCondicion(Expression<Func<T, bool>> condicion)
    {
        return await _context.Set<T>().Where(condicion).ToListAsync();
    }
    public async Task Insertar(T entidad)
    {
        await _context.Set<T>().AddAsync(entidad);
        await _context.SaveChangesAsync();
    }

    public async Task EliminarEntidad(T entidad)
    {
        _context.Set<T>().Remove(entidad);
        await _context.SaveChangesAsync();
    }
    public async Task EliminarPorId<TKey>(TKey id)
    {
        var entidad = await _context.Set<T>().FindAsync(id);
        if (entidad != null)
        {
            _context.Set<T>().Remove(entidad);
            await _context.SaveChangesAsync();
        }
    }
    public async Task Actualizar(T entidad)
    {
        _context.Set<T>().Update(entidad);
        await _context.SaveChangesAsync();
    }
}
