using System;
namespace Hrm.ApplicationCore.Model.Response
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }

        public UserResponseModel()
        {
        }
    }
}

