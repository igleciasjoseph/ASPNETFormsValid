using System.ComponentModel.DataAnnotations;
namespace FormValid.Models
{
    public class User {
        [Required(ErrorMessage = "This field is required")]
        [MinLength(4, ErrorMessage="First name must be longer than 4 characters")]
        public string fname{get;set;}
        [Required(ErrorMessage = "This field is required")]
        [MinLength(4, ErrorMessage = "Last name must be longer than 4 characters")]
        public string lname{get;set;}
        [Required(ErrorMessage = "This field is required")]
        [Range(1, 200, ErrorMessage= "Clearly you're not born yet")]
        public int age{get;set;}
        [Required(ErrorMessage = "This field is required")]
        [EmailAddress]
        public string email{get;set;}
        [Required(ErrorMessage = "This field is required")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}