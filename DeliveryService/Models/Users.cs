using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models
{
    public class Users
    {
        [Key]
        public int userId { get; set; }
        public string? userName { get; set; }
        public string? googleId { get; set; }
        public string? password { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime? dateOfBirth { get; set; }
        public string? address { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public bool verify { get; set; }
        public int roleId { get; set; }

        /*[ForeignKey("roleId")]
        public ICollection<Roles> roles { get; set; }*/
    }
}
