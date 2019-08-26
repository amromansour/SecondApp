using System.ComponentModel.DataAnnotations;

namespace SecondApp.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="Must be not more than 8 and not less than 8 characters")]
        public string Password { get; set; }
    }
}