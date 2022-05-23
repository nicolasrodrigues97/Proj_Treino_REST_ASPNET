using Proj_Treino_REST_ASPNET.Model;
using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        List<Person> FindByName(string firstName, string secondName);
    }
}
