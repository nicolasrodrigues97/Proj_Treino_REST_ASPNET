﻿using Proj_Treino_REST_ASPNET.Model;
using Proj_Treino_REST_ASPNET.Repository;
using System.Collections.Generic;


namespace Proj_Treino_REST_ASPNET.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IBookRepository _repository;

        public BookBusinessImplementation(IBookRepository repository){
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Book> FindAll()
        {
            return _repository.FindAll();
        }

        public Book FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }

    }
}
