using FlavorVerse.Application.Dtos.DifficultyCooking;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Domain.Entities.Application_lu;

namespace FlavorVerse.Application.Mappers;

public class DifficultyCookingMapper : BaseAutoMapperProfile
{
    public DifficultyCookingMapper()
    {
        CreateMap<DifficultyCooking_lu, DifficultyCookingDto>();
    }
}
