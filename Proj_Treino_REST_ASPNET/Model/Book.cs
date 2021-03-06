using Proj_Treino_REST_ASPNET.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj_Treino_REST_ASPNET.Model
{
    [Table("books")]
    public class Book : BaseEntity
    {
        // herda id de BaseEntity
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }

}