using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Business.Entities
{
    public class Provider
    {
        public int Id { get; set; }

        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Initial")]
        public string MI { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                if (FirstName != null && LastName != null)
                {
                    return string.Format("{0} {1} {2}", FirstName, MI is null ? " " : " " + MI + " ", LastName);
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public string Name { get; set; }

        public int TitleId { get; set; }

        public string Title { get; set; }

        public List<SelectListItem> Titles { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public int CityId { get; set; }

        public string City { get; set; }

        public List<SelectListItem> Cities { get; set; }

        public int StateId { get; set; }

        public string State { get; set; }

        public List<SelectListItem> States { get; set; }

        public string Zip { get; set; }

        public string Phone { get; set; }

        public bool ActiveCd { get; set; }

        [Display(Name = "Active")]
        public string Active
        {
            get
            {
               return ActiveCd == false ? "No" : "Yes";
            }
        }
    }
}