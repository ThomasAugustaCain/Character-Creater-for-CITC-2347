using System.ComponentModel.DataAnnotations;

namespace LordsOfTheFallenCharacterCreation.Models
{
    public class Class
    {
        public int ClassId { get; set; }

        [Required(ErrorMessage = "A class must have a name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a level")]
        [Range(1, 100, ErrorMessage = "A Character's level must be between 1 and 100")]
        public int? InitalLevel { get; set; }

        [Required(ErrorMessage = "Please enter a Strength stat")]
        [Range(1, 100, ErrorMessage = "Strength must be between 1 and 100")]
        public int? InitalStrength { get; set; }

        [Required(ErrorMessage = "Please enter an Agility stat")]
        [Range(1, 100, ErrorMessage = "Agility must be between 1 and 100")]
        public int? InitalAgility { get; set; }

        [Required(ErrorMessage = "Please enter an Endurance stat")]
        [Range(1, 100, ErrorMessage = "Endurance must be between 1 and 100")]
        public int? InitalEndurance { get; set; }

        [Required(ErrorMessage = "Please enter a Vitality stat")]
        [Range(1, 100, ErrorMessage = "Vitality must be between 1 and 100")]
        public int? InitalVitality { get; set; }

        [Required(ErrorMessage = "Please enter a Radiance stat")]
        [Range(1, 100, ErrorMessage = "Radiance must be between 1 and 100")]
        public int? InitalRadiance { get; set; }

        [Required(ErrorMessage = "Please enter an Inferno stat")]
        [Range(1, 100, ErrorMessage = "Inferno must be between 1 and 100")]
        public int? InitalInferno { get; set; }

    }
}
