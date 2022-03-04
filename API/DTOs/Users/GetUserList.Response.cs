using System;

namespace API.DTOs.Users
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        

        public string FullName { get; set; }
        
        public string Address { get; set; }

        public string BirthDate { get; set; }

        public string RegistrationDate { get; set; }

        public int? Active { get; set; }
    }
}