using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models
{
    public class Roles
    {
        [Key]
        public int roleId { get; set; }
        public string roleName { get; set; }
    }
}
