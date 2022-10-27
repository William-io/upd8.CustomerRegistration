using System.ComponentModel.DataAnnotations;

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
        public string Name { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public string BirthDate { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string State { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
