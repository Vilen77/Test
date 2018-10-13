using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTO
{
    public class RegisterModel
    {
        [Required]        
        public string  UserName { get; set; }             

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 50 characters.")]
        public string Password { get; set; }  
    }
}