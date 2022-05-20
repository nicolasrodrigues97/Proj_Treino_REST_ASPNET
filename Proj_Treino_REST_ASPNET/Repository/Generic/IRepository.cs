using Proj_Treino_REST_ASPNET.Model;
using Proj_Treino_REST_ASPNET.Model.Base;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Repository
{
    public interface IRepository <T> where T : BaseEntity
    {
        T Create(T person);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T person);
        void Delete(long id);

        bool Exists (long id);
    }
}
