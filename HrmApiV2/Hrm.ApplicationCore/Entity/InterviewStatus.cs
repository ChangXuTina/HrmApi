using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.ApplicationCore.Entity
{
	public class InterviewStatus
	{
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Title { get; set; }
        public bool IsActive { get; set; }

        public InterviewStatus()
		{
		}
	}
}

