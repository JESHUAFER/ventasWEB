using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ventasWEB.Models
{
    public class AppUsuarios : IdentityUser
    {
        [Required(ErrorMessage =" El rol es obligatorio")]
        public string Rol { get; set; }
        
        
    }
}
