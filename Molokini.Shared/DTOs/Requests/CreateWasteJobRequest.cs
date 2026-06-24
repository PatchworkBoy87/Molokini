using Molokini.Shared.Enums;

namespace Molokini.Shared.DTOs.Requests;

public class CreateWasteJobRequest
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public WasteJobType Type { get; set; }
}
