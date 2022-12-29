using System.ComponentModel.DataAnnotations;

namespace Eterna.Models
{
    public class PortfolioImage
    {
        public int Id { get; set; }
        public int PortfolioId { get; set; }
        [StringLength(maximumLength: 220)]

        public string ImageUrl { get; set; }
        public Portfolio Portfolio { get; set; }


    }
}
