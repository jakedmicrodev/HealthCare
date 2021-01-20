using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        [Display (Name = "First Name")]
        [Required (ErrorMessage = "You must enter a first name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public string MI { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a last name")]
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return string.Format("{0} {1} {2}", FirstName, MI, LastName);
            }
        }
    }
}