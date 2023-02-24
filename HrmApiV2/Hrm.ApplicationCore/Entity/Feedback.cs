﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hrm.ApplicationCore.Entity
{
	public class Feedback
	{
        public int Id { get; set; }
        public int InterviewId { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ABBR { get; set; }

        public Interview Interview { get; set; }

        public Feedback()
		{
		}
	}
}

