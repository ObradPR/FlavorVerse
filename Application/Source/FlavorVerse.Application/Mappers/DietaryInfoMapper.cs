using FlavorVerse.Application.Dtos.Recipe;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class DietaryInfoMapper : BaseAutoMapperProfile
{
    public DietaryInfoMapper()
    {
        CreateMap<DietaryInfo, DietaryInfoDto>();
    }
}
