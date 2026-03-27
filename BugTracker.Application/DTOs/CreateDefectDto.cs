namespace BugTracker.Application.DTOs;

public class CreateDefectDto
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public string Severity { get; set; } = string.Empty;
}