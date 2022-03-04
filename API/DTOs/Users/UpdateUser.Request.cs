using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Users
{
    public class UpdateUserRequest
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        
        [Required]
        public DateTime? BirthDate { get; set; }
        
        [Required]
        public DateTime? RegistrationDate { get; set; }

        [Required]
        public int? ActiveCustomer { get; set; }
    }
}