namespace ShipDomain
{
	public class Ship : IShipIdentity
	{
		private string? wikiLink;

		public virtual Guid? ID { get; set; }
		public string? WikiLink { get => wikiLink; set => wikiLink = value?.Replace(@"\/", "/"); }
		public int? ShiplistKey { get; set; }


		public string? Nation { get; set; }

		public string? ClassName { get; set; }

		public string? ClassType { get; set; }

		public int? LengthFt { get; set; }
		public int? BeamFt { get; set; }
		public int? StandardWeight { get; set; }
		public int? FullWeight { get; set; }
		public int? Launched { get; set; }
		public int? LastYearBuilt { get; set; }
		public int? NumberInClass { get; set; }


		public int? Guns { get; set; }
		public double? GunDiameter { get; set; }
		public double? Armor { get; set; }

		public int? Rudders { get; set; }
		public string? RudderType { get; set; }
		public string? RudderStyle { get; set; }
		public int? Shafts { get; set; }


		public double? SpeedKnots { get; set; }
		public int? SpeedIrcwcc { get; set; }

		public int? ShipClass { get; set; }
		public double? Units { get; set; }


		public string? Comment { get; set; }
		public string? Notes { get; set; }
	}
}
