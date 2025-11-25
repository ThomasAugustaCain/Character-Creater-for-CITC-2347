using System.ComponentModel.DataAnnotations;

namespace LordsOfTheFallenCharacterCreation.Models
{
    public class Ancestry
    {

        public int AncestryId { get; set; }

        [Required(ErrorMessage = "Ancestry must have a name")]
        public string AncestryName { get; set; } = string.Empty;

    }
}
