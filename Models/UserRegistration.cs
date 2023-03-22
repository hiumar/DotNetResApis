using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace UserRegistrationForm.Models
{
    [Table("User")]
    public class UserRegistration
    {
        [Key]
        public int UserId { get; set; }
        [Required]
    
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
 
        public string Email { get; set; }
       
        public string Message { get; set; }

    }
}
