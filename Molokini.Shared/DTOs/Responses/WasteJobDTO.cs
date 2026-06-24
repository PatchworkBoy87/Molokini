namespace Molokini.Shared.DTOs.Responses;

public class WasteJobDTO
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public WasteJobType WasteJobType { get; set; }
    public List<WasteItem> WasteItems { get; set; }
}
