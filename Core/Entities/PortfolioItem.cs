using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class PortfolioItem : EntityBase
    {
        [MaxLength(100)]
        public string ProjectName { get; set; }

        [MaxLength(300)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
