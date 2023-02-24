using System;
namespace Hrm.ApplicationCore.Model.Response
{
    public class JobRequirementResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public JobRequirementResponseModel()
        {
        }
    }
}

