using Proj_Treino_REST_ASPNET.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj_Treino_REST_ASPNET.Data.VO
{
    public class BookVO
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public DateTime LaunchDate { get; set; }
    }
}
