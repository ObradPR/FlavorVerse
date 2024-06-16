using FlavorVerse.Application.Dtos.Nutrition;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class NutritionMapper : BaseAutoMapperProfile
{
    public NutritionMapper()
    {
        CreateMap<Nutrition, NutritionDto>();
    }
}
