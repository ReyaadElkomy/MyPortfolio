using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Address : EntityBase
    {
        [MaxLength(100)]
        public string Street { get; set; }

        [MaxLength(100)]
        public string City { get; set; }
        public int Number { get; set; }
    }
}
