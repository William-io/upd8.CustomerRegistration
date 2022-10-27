using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace upd8.CustomerRegistration.Domain.Entities
{
    public class Customer
    {

        public void GenerateNewId()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(11)]
        public string CPF { get; set; } = null!;
        public string BirthDate { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string State { get; set; } = null!;
        public string City { get; set; } = null!;

    }
}
