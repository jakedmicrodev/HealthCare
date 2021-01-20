using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Title
    {
        public int Id { get; set; }

        [Display (Name = "Title")]
        [Required (ErrorMessage = "You must enter a title")]
        public string Name { get; set; }
    }
}