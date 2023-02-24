using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Request
{
    public class UserRequestModel
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string Password { get; set; }

        public UserRequestModel()
        {
        }
    }
}

