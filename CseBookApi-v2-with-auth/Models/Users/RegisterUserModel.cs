using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterUserModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string GradeLevel { get; set; }

        [Required]
        public string Course { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}