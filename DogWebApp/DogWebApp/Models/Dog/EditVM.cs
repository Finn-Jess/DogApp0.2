using Azure.Identity;

using DogWebApp.Models.Breed;

using System.ComponentModel.DataAnnotations;

namespace DogWebApp.Models.Dog
{
    public class EditVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Display(Name = "Dog Name")]

        public string Name { get; set; } = null!;

        [Range(0,30, ErrorMessage = "Age must be between 0 and 30")]

        public int Age { get; set; }

        [Display (Name = "Breed")]
        public int BreedId { get; set; }
        public virtual List<BreedPairViewModel> Breeds { get; set; } = new List<BreedPairViewModel>();

        [Display(Name = "Dog Picture")]
        public string Picture { get; set; } = null!;
    }
}
