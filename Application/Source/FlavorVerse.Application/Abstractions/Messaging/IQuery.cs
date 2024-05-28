using FlavorVerse.Application.Utilities;
using MediatR;

namespace FlavorVerse.Application.Abstractions.Messaging
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
