using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Owner : EntityBase
    {
        [MaxLength(200)]
        public string FullName { get; set; }

        [MaxLength(100)]
        public string Profile { get; set; }
        public string Avatar { get; set; }

        public Address Address { get; set; }
    }
}
