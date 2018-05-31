using System.ComponentModel.DataAnnotations;

namespace Apoteket.UppgiftBE.Web.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }

        public int? NumberOfOrder { get; set; }
    }
}
