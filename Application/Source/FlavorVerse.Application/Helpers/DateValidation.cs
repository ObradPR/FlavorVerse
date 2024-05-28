namespace FlavorVerse.Application.Helpers;

public static class DateValidation
{
    public static bool BeInThePast(DateOnly? date)
    {
        if (!date.HasValue)
        {
            return false;
        }

        return date < DateOnly.FromDateTime(DateTime.Now.Date);
    }

    public static bool BeAValidAge(DateOnly? date)
    {
        if (!date.HasValue)
        {
            return false;
        }

        return date > DateOnly.FromDateTime(DateTime.Now.AddYears(-100)) && date < DateOnly.FromDateTime(DateTime.Now.Date.AddYears(-12));
    }
}