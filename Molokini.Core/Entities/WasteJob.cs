using Molokini.Shared.Enums;

namespace Molokini.Core.Entities;

public class WasteJob
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public WasteJobCategory Category { get; set; }
    public string Location { get; set; }
    public WasteJobStatus Status { get; set; }
    public List<WasteEntry>? WasteEntries { get; set; }
}