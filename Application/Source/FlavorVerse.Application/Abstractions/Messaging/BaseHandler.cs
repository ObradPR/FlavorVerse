using AutoMapper;
using FlavorVerse.Application.Dtos;
using FlavorVerse.Domain.Repositories;
using FluentValidation;

namespace FlavorVerse.Application.Abstractions.Messaging;

public abstract class BaseHandler
{
    protected IUnitOfWork UnitOfWork { get; set; }
    protected IMapper Mapper { get; set; }
    protected ITransactionService TransactionService { get; set; }

    protected BaseHandler(IUnitOfWork unitOfWork) => UnitOfWork = unitOfWork;

    protected BaseHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        UnitOfWork = unitOfWork;
        Mapper = mapper;
    }

    protected BaseHandler(ITransactionService transactionService, IUnitOfWork unitOfWork)
    {
        TransactionService = transactionService;
        UnitOfWork = unitOfWork;
    }

    protected BaseHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IMapper mapper)
    {
        TransactionService = transactionService;
        UnitOfWork = unitOfWork;
        Mapper = mapper;
    }
}

public abstract class BaseHandler<TRequest> : BaseHandler
    where TRequest : BaseDto
{
    protected IValidator<TRequest> Validator { get; set; }

    public BaseHandler(ITransactionService transactionService, IUnitOfWork unitOfWork) : base(transactionService, unitOfWork)
    {
    }

    public BaseHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IValidator<TRequest> validator)
        : this(transactionService, unitOfWork) => Validator = validator;

    public BaseHandler(ITransactionService transactionService, IUnitOfWork unitOfWork, IMapper mapper, IValidator<TRequest> validator)
        : base(transactionService, unitOfWork, mapper) => Validator = validator;
}