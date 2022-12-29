using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Eterna.Models
{
    public class Portfolio
    {

        public int Id { get; set; }
        
        public int CategoryId { get; set; }

        [StringLength( maximumLength:50)]
        public string Desc { get; set; }
        [StringLength(maximumLength: 20)]

        public string Title { get; set; }
        [StringLength(maximumLength: 20)]

        public string Client { get; set; }
        [StringLength(maximumLength: 120)]

        public string ProjectUrl { get; set; }
        public DateTime Date { get; set; }

        public Category Category { get; set; }

        public List<PortfolioImage> PortfolioImages { get; set; }
    }
}
