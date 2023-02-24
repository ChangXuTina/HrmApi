using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.ApplicationCore.Entity
{
	public class EmployeeType
	{
        public int Id { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Title { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public EmployeeType()
		{
		}
	}
}

