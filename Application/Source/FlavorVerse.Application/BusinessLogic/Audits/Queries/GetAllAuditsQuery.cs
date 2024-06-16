using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.Audit;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Audits.Queries;

public class GetAllAuditsQuery : IQuery<PaginatedList<AuditDto>>
{
    public AuditQueryParams AuditQueryParams { get; set; }

    public GetAllAuditsQuery(AuditQueryParams auditQueryParams) => AuditQueryParams = auditQueryParams;

    // Handler
    public class GetAllAuditsHandler : BaseHandler, IQueryHandler<GetAllAuditsQuery, PaginatedList<AuditDto>>
    {
        public GetAllAuditsHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<AuditDto>>> Handle(GetAllAuditsQuery request, CancellationToken cancellationToken)
        {
            var paginatedAudits = await UnitOfWork.AuditRepository.GetAllAsync(request.AuditQueryParams, cancellationToken);

            if (paginatedAudits is null || paginatedAudits.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<AuditDto>>(Error<Audit>.NotFound);
            }
            var auditsMapped = new PaginatedList<AuditDto>();
            try
            {
            auditsMapped = Mapper.Map<PaginatedList<AuditDto>>(paginatedAudits);

            }
            catch(Exception ex)
            {

            }

            return Result.Success(auditsMapped);
        }
    }
}