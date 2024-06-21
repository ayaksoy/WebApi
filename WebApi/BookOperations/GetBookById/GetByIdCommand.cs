using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBookById
{
    public class GetByIdCommand
    {
        
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int bookId { get; set; }

        public GetByIdCommand (BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public BookViewModel Handle()
       {
             var book = _dbContext.Books.SingleOrDefault(x=>x.Id == bookId);
            if (book is null)
            {
                throw new InvalidOperationException("Kitap mevcut değil");
            }
            var model = _mapper.Map<BookViewModel>(book);
            return model;


        }
    }
    public class BookViewModel
    {
            public string? Title { get; set; }
            public string Genre { get; set; }
            public int PageCount { get; set; }
            public string PublishDate { get; set; }
    }
    
}