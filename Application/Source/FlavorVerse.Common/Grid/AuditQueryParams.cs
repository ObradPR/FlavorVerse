namespace FlavorVerse.Common.Grid;

public class AuditQueryParams
{
    public string UserFullName { get; set; } = string.Empty;
    public string? ActionName { get; set; }
    public DateTime? DateFrom { get; set; }
    public DateTime? DateTo { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = Constants.DEFAULT_PAGE_SIZE;
}