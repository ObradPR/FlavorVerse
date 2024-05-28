using AutoMapper;
using FlavorVerse.Application.Abstractions.Messaging;
using FlavorVerse.Application.Dtos.User;
using FlavorVerse.Application.Utilities;
using FlavorVerse.Domain.Entities.Application;
using FlavorVerse.Domain.Repositories;

namespace FlavorVerse.Application.BusinessLogic.Users.Queries;

public class GetUserQuery : IQuery<UserProfileDto>
{
    public Guid Id { get; set; }

    public GetUserQuery(Guid id) => Id = id;

    // Handler
    public class GetUserHandler : BaseHandler, IQueryHandler<GetUserQuery, UserProfileDto>
    {
        public GetUserHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<UserProfileDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await UnitOfWork.UserRepository.GetUserByIdAsync(request.Id, cancellationToken);

            if (user is null)
            {
                return Result.Failure<UserProfileDto>(Error<User>.NotFound);
            }

            var userMapped = Mapper.Map<UserProfileDto>(user);

            return Result.Success(userMapped);
        }
    }
}