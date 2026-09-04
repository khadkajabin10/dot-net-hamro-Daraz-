using System.ComponentModel.DataAnnotations;

namespace HamroDaraz.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Username is required") ]
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Password must be 8 character long")]
        public string Password { get; set; }
    }
}
