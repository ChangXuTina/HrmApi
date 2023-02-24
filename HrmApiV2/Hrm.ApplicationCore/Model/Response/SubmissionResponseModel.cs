using System;
namespace Hrm.ApplicationCore.Model.Response
{
    public class SubmissionResponseModel
    {
        public int id { get; set; }
        public int CandidateId { get; set; }
        public int JobRequirementId { get; set; }
        public DateTime AppliedOn { get; set; }

        public SubmissionResponseModel()
        {
        }
    }
}

