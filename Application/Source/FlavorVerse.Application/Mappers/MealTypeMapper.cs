using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Domain.Entities.Application_lu;

namespace FlavorVerse.Application.Mappers;

public class MealTypeMapper : BaseAutoMapperProfile
{
    public MealTypeMapper()
    {
        CreateMap<MealType_lu, MealTypeDto>();
    }
}
