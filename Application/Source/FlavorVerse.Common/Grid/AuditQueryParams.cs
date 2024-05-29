using FlavorVerse.Common.Grid._BaseGridParams;

namespace FlavorVerse.Common.Grid;

public class AuditQueryParams : BaseGridParams
{
    public string? UserFullName { get; set; }
    public string? ActionName { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
}