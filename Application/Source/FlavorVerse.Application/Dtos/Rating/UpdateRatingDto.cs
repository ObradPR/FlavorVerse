namespace FlavorVerse.Application.Dtos.Rating;

public class UpdateRatingDto : BaseDto
{
    public int? RatingValue { get; set; }
    public string? Comment { get; set; }
    public bool? IsActive { get; set; }
}