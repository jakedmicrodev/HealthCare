using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Medication
    {
        public int Id { get; set; }
        [Display (Name="Medication")]
        [Required (ErrorMessage = "You must enter a medication name")]
        public string Name { get; set; }
    }
}