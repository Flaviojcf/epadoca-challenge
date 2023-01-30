using System.ComponentModel.DataAnnotations;

namespace epadoca_challenge.Models
{
    public class BakeryModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome da padaria")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite a descrição da padaria")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Digite o estado da padaria")]
        public string State { get; set; }

        [Required(ErrorMessage = "Digite a cidade da padaria")]
        public string City { get; set; }

        [Required(ErrorMessage = "Digite a rua da padaria")]
        public string Street { get; set; }
    }
}
