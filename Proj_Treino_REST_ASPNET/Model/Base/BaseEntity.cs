using System.ComponentModel.DataAnnotations.Schema;

namespace Proj_Treino_REST_ASPNET.Model.Base
{
    public class BaseEntity
    {
       [Column("id")]
       public long Id { get; set; }
    }
}
