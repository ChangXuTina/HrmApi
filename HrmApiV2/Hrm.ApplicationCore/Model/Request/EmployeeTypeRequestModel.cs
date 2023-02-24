using System;
namespace Hrm.ApplicationCore.Model.Request
{
    public class EmployeeTypeRequestModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public EmployeeTypeRequestModel()
        {
        }
    }
}

