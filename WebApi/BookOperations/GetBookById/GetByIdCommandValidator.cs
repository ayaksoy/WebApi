using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBookById
{
    public class GetBookByIdCommandValidator : AbstractValidator<GetByIdCommand>
    {
        public GetBookByIdCommandValidator()
        {
            RuleFor(command => command.bookId).GreaterThan(0);
          
        }

    }
}