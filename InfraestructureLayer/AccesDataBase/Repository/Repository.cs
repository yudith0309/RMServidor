﻿using Microsoft.EntityFrameworkCore;

namespace AccesDataBase.Repository;

public class Repository : IRepository
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public T ObtenerPorId<T>(Guid id) where T : class
    {
        var entidad = _context.Set<T>()
            .FindAsync(id)
            .GetAwaiter()
            .GetResult();
        if (entidad == null)
        {
            throw new KeyNotFoundException($"No se encontró una entidad de tipo {typeof(T).Name} con el ID '{id}'");
        }

        return entidad;
    }

    public List<T> ObtenerTodos<T>() where T : class
    {
        return _context.Set<T>()
            .ToListAsync()
            .GetAwaiter()
            .GetResult().ToList();
    }

    public void Agregar<T>(T entidad) where T : class
    {
        _context.Set<T>()
            .AddAsync(entidad)
            .GetAwaiter()
            .GetResult();

        _context.SaveChangesAsync()
            .GetAwaiter()
            .GetResult();
    }

    public void Actualizar<T>(T entidad) where T : class
    {
        _context.Set<T>().Update(entidad);

        _context.SaveChangesAsync()
            .GetAwaiter()
            .GetResult();
    }

    public void Eliminar<T>(T entidad) where T : class
    {
        _context.Set<T>().Remove(entidad);

        _context.SaveChangesAsync()
            .GetAwaiter()
            .GetResult();
    }
}
