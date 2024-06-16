using Microsoft.AspNetCore.Http;

namespace FlavorVerse.Application.Helpers;

public static class PictureValidation
{
    public static bool BeAValidImage(IFormFile? file)
    {
        if (file is null)
        {
            return false;
        }

        var allowedExtensions = new[] { ".jpg", ".jpeg", ".png" };
        var extension = Path.GetExtension(file.FileName).ToLowerInvariant();

        return allowedExtensions.Contains(extension);
    }

    public static bool BeAReasonableSize(IFormFile? file)
    {
        if (file is null)
        {
            return false;
        }

        return file.Length <= 5 * 1024 * 1024;
    }
}