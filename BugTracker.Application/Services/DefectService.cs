using BugTracker.Domain.Entities;
using BugTracker.Domain.Enums;
using BugTracker.Infrastructure.Repositories;
using BugTracker.Infrastructure.Data;

namespace BugTracker.Application.Services;

public class DefectService
{
    private readonly DefectRepository _repo;
    private readonly AppDbContext _context;

    public DefectService(DefectRepository repo, AppDbContext context)
    {
        _repo = repo;
        _context = context;
    }

    public async Task<List<Defect>> GetAll()
        => await _repo.GetAll();

    public async Task Create(string title, string desc, string severity)
    {
        var defect = new Defect
        {
            Title = title,
            Description = desc,
            Severity = severity
        };

        await _repo.Add(defect);

        _context.AuditLogs.Add(new AuditLog
        {
            DefectId = defect.Id,
            Action = "Created"
        });

        await _context.SaveChangesAsync();
    }

    public async Task ChangeStatus(int id, DefectStatus status)
    {
        var defect = await _repo.Get(id);
        if (defect == null) return;

        defect.Status = status;
        defect.UpdatedAt = DateTime.UtcNow;

        await _repo.Update(defect);

        _context.AuditLogs.Add(new AuditLog
        {
            DefectId = id,
            Action = $"Status Changed to {status}"
        });

        await _context.SaveChangesAsync();
    }

    public async Task<object> GetReport()
    {
        var report = _context.Defects
            .GroupBy(x => x.Severity)
            .Select(g => new
            {
                Severity = g.Key,
                Count = g.Count()
            });

        return await Task.FromResult(report);
    }
}