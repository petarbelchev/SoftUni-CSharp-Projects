﻿using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
	[XmlType("Boardgame")]
	public class ExportBoardgameDTO
	{
		[XmlElement("BoardgameName")]
        public string BoardgameName { get; set; } = null!;

		[XmlElement("BoardgameYearPublished")]
        public int BoardgameYearPublished { get; set; }
    }
}
