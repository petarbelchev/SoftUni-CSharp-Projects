﻿namespace Homies.Models
{
	public class EventViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Start { get; set; } = null!;

		public string Type { get; set; } = null!;

		public string Organizer { get; set; } = null!;
	}
}
