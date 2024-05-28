using FlavorVerse.Application.Dtos.Audit;
using FlavorVerse.Application.Mappers._BaseAutoMapper;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;

namespace FlavorVerse.Application.Mappers;

public class AuditMapper : BaseAutoMapperProfile
{
    public AuditMapper()
    {
        CreateMap<Audit, AuditDto>()
            .ForMember(dest => dest.EntityType, opt => opt.MapFrom(src => src.EntityType.Name))
            .ForMember(dest => dest.ActionType, opt => opt.MapFrom(src => src.ActionType.Name))
            .ForMember(dest => dest.ExecutedBy, opt => opt.MapFrom(src => src.User.DisplayName));

        CreateMap<PaginatedList<Audit>, PaginatedList<AuditDto>>();
    }
}