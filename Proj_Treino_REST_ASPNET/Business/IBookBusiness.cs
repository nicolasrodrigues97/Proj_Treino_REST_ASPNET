using Proj_Treino_REST_ASPNET.Data.VO;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}
