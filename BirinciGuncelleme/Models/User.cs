using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class User
    {
        [Key] 
        public string Id { get; set; }
        public string Email { get; set; }

        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserAdress { get; set; }
        public ICollection<Game>? Games { get; set; }

    }
}
