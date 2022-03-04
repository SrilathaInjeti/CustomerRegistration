using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs.Users
{
    public class AddUserRequest
    {
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        public string BirthDate { get; set; }

        [Required]
        public string RegistrationDate { get; set; }

        [Required]
        public int? Active { get; set; }
    }
}