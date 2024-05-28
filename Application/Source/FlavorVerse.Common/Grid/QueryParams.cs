namespace FlavorVerse.Common.Grid;

public class QueryParams
{
    public string SearchTerm { get; set; } = string.Empty;
    public string? FilterCriteria { get; set; }
    public string? FilterDirection { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = Constants.DEFAULT_PAGE_SIZE;
}