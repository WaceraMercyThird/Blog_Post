﻿using System;
namespace BlogPost.Data.Models.Domain
{
	public class Tag
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public Guid BlogpostId { get; set; }
	}
}

