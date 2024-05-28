using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Common.Grid;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Users.Queries;

public class GetAllUsersQuery : IQuery<PaginatedList<UserProfileDto>>
{
    public QueryParams QueryParameters { get; set; }

    public GetAllUsersQuery(QueryParams queryParams) => QueryParameters = queryParams;

    // Handler
    public class GetAllUsersHandler : BaseHandler, IQueryHandler<GetAllUsersQuery, PaginatedList<UserProfileDto>>
    {
        public GetAllUsersHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PaginatedList<UserProfileDto>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var paginatedUsers = await UnitOfWork.UserRepository.GetAllAsync(request.QueryParameters);

            if (paginatedUsers is null || paginatedUsers.TotalCount < 1)
            {
                return Result.Failure<PaginatedList<UserProfileDto>>(Error<User>.NotFound);
            }

            var usersMapped = Mapper.Map<PaginatedList<UserProfileDto>>(paginatedUsers);

            return Result.Success(usersMapped);
        }
    }
}