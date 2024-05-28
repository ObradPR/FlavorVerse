namespace FlavorVerse.Application.Dtos.User
{
    public class UpdateUserProfileDto : BaseDto
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public DateOnly? DateOfBirth { get; set; }
    }
}