using Proj_Treino_REST_ASPNET.Model;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
