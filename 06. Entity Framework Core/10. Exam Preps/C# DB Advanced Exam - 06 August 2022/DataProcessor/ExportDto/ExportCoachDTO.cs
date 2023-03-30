﻿using System.Xml.Serialization;

namespace Footballers.DataProcessor.ExportDto
{
	[XmlType("Coach")]
	public class ExportCoachDTO
	{
		[XmlAttribute("FootballersCount")]
        public int FootballersCount { get; set; }

		[XmlElement("CoachName")]
        public string CoachName { get; set; } = null!;

		[XmlArray("Footballers")]
        public ExportFootballerDTO[] Footballers { get; set; } = null!;
    }
}
