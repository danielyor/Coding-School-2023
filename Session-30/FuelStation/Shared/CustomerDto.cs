using System.ComponentModel.DataAnnotations;

namespace FuelStation.Shared {
    public class CustomerDto {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [RegularExpression("^A.\\d{0,}$", ErrorMessage = "The Card Number field must begin with A, followed by any number of digits. Ex. 'A12345'.")]
        public string CardNumber { get; set; }
    }
}
