using System.ComponentModel.DataAnnotations;

namespace FactoryMethodAPI2.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null!;
        [Required]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Adrress { get; set; }
        public string PatientType { get; set; }
        public string bednum { get; set; }
        public string diagnosis { get; set;}
    }
}
