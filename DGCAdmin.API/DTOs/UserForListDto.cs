using System;

namespace DGCAdmin.API.DTOs
{
    public class UserForListDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Voice { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}