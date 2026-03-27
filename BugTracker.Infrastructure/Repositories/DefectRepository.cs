using BugTracker.Domain.Entities;
using BugTracker.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Infrastructure.Repositories;

public class DefectRepository
{
    private readonly AppDbContext _context;

    public DefectRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Defect>> GetAll()
        => await _context.Defects.ToListAsync();

    public async Task<Defect?> Get(int id)
        => await _context.Defects.FindAsync(id);

    public async Task Add(Defect defect)
    {
        _context.Defects.Add(defect);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Defect defect)
    {
        _context.Defects.Update(defect);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        var defect = await _context.Defects.FindAsync(id);
        if (defect != null)
        {
            _context.Defects.Remove(defect);
            await _context.SaveChangesAsync();
        }
    }
}