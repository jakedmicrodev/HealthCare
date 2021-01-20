using System.ComponentModel.DataAnnotations;

namespace Business.Entities
{
    public class Service
    {
        public int Id { get; set; }

        [Display (Name = "Service Provided")]
        [Required (ErrorMessage = "You must enter a service name")]
        public string Name { get; set; }
    }
}