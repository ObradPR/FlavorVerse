using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlavorVerse.WebApi.Controllers._BaseApiController;

[Route("api/[controller]")]
[ApiController]
public abstract class BaseApiController : ControllerBase
{
    protected IMediator Mediator { get; set; }

    protected BaseApiController(IMediator mediator) => Mediator = mediator;
}