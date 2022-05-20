using System.Collections.Generic;

namespace Proj_Treino_REST_ASPNET.Data.Converter.Contract
{
    public interface IParser<O, D> // origem, destino
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
