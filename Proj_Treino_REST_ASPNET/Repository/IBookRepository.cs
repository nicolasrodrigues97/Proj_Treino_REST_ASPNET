using Proj_Treino_REST_ASPNET.Model;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Repository
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);

        bool Exists (long id);
    }
}
