using System.ComponentModel.DataAnnotations;
// Required to turn off validation for Genre property
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace LordsOfTheFallenCharacterCreation.Models
{
    public class Character
    {
        
        //Auto incrementing id
        public int CharacterId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Please enter a last name")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Class")]
        public int? ClassId { get; set; }

        [ValidateNever]
        public Class Class { get; set; } = null!;

        [Required(ErrorMessage = "Please enter an Ancestry")]
        public int? AncestryId { get; set; }

        [ValidateNever]
        public Ancestry Ancestry { get; set; } = null!;

        [Required(ErrorMessage = "Please enter a level")]
        [Range(1, 100, ErrorMessage = "A Character's level must be between 1 and 100")]
        public int? Level { get; set; }

        [Required(ErrorMessage = "Please enter a Strength stat")]
        [Range(1, 100, ErrorMessage = "Strength must be between 1 and 100")]
        public int? Strength { get; set; }

        [Required(ErrorMessage = "Please enter an Agility stat")]
        [Range(1, 100, ErrorMessage = "Agility must be between 1 and 100")]
        public int? Agility { get; set; }

        [Required(ErrorMessage = "Please enter an Endurance stat")]
        [Range(1, 100, ErrorMessage = "Endurance must be between 1 and 100")]
        public int? Endurance { get; set; }

        [Required(ErrorMessage = "Please enter a Vitality stat")]
        [Range(1, 100, ErrorMessage = "Vitality must be between 1 and 100")]
        public int? Vitality { get; set; }

        [Required(ErrorMessage = "Please enter a Radiance stat")]
        [Range(1, 100, ErrorMessage = "Radiance must be between 1 and 100")]
        public int? Radiance { get; set; }

        [Required(ErrorMessage = "Please enter an Inferno stat")]
        [Range(1, 100, ErrorMessage = "Inferno must be between 1 and 100")]
        public int? Inferno { get; set; }

    }
}
