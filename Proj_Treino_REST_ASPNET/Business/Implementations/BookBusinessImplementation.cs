﻿using Proj_Treino_REST_ASPNET.Model;
using Proj_Treino_REST_ASPNET.Repository;
using System.Collections.Generic;
using Proj_Treino_REST_ASPNET.Data.VO;
using Proj_Treino_REST_ASPNET.Data.Converter.Implementations;
using Proj_Treino_REST_ASPNET.Business;

namespace Proj_Treino_REST_ASPNET.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {

        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }
        public BookVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        public BookVO Create(BookVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }
        public BookVO Update(BookVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}