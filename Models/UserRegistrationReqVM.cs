using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationForm.Models
{
    public class UserRegistrationReqVM
    {


        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [Required]
      
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
