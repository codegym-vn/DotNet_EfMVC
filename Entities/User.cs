using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? UserRole { get; set; }
        public int? Age { get; set; }
        public ulong? Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
