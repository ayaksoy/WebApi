using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApi.Common;
using WebApi.DbOperations;
using WebApi.Model;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBooksQuery (BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<BooksViewModel> Handle()
        {
            var books =_dbContext.Books.OrderBy(x=>x.Id).ToList<Book>();
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(books);
          
            return vm;
        }
    }
    public class BooksViewModel
    {
            public string? Title { get; set; }
            public string Genre { get; set; }
            public int PageCount { get; set; }
            public string PublishDate { get; set; }
    }
    
}