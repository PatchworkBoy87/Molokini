namespace Molokini.Shared.Contracts.DTOs;

public class WasteJobEntryDto
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Category { get; set; }
    public string SubCategory { get; set; }
    public string Location { get; set; }
    public string Status { get; set; }
    public List<WasteEntryDto> WasteEntries { get; set; }
}