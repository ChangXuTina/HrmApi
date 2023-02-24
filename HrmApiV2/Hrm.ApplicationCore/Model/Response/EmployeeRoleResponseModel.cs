using System;
namespace Hrm.ApplicationCore.Model.Response
{
    public class EmployeeRoleResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public EmployeeRoleResponseModel()
        {
        }
    }
}

