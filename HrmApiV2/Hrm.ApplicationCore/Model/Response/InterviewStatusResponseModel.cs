using System;
using System.ComponentModel.DataAnnotations;

namespace Hrm.ApplicationCore.Model.Response
{
    public class InterviewStatusResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public InterviewStatusResponseModel()
        {
        }
    }
}

