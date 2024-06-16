namespace FlavorVerse.Application.Dtos.Rating;

public class NewRatingDto : BaseDto
{
    public int RatingValue { get; set; }
    public string Comment { get; set; } = string.Empty;
    public Guid RecipeId { get; set; }
}