using Proj_Treino_REST_ASPNET.Model;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Business
{
    public interface IBookBusiness
    {
        Book Create(Book book);
        Book FindByID(long id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete(long id);
    }
}
