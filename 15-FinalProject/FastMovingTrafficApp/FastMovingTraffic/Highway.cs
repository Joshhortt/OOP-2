using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastMovingTraffic
{
	partial class Highway
	{
		// properties
		public string Name { get; set; }
		public string HighwayType { get; set; } = "NA";
		public char Direction { get; set; }
		public string Surface { get; set; } = "NA";
		public int? NumbLanes { get; set; }
		public bool? Toll { get; set; }
		public string Maintainance { get; set; } = "NA";


		// constructors
		public Highway(string name, string type, char direction, string surface, int numbLanes, bool toll, string maintainance)
		{
			Name = name;
			HighwayType = type;
			Direction = direction;
			Surface = surface;
			NumbLanes = numbLanes;
			Toll = toll;
			Maintainance = maintainance;
		}

		public Highway(string name)
		{
			Name = Name;
		}

		public Highway(string name, bool toll)
		{
			Name = name;
			Toll = toll;
		}

		public Highway(string name, int numbLanes)
		{
			Name = name;
			NumbLanes = numbLanes;
		}

		// method that return enums IsToll
		public IsToll IsHighwayToll()
		{
			switch (Toll)
			{
				case true:
					return IsToll.Yes;
				case false:
					return IsToll.No;
				default:
					return IsToll.NA;
									
			}
		}

		// method that return enums Directions
		public Directions GetDirections()
		{
			switch (Direction)
			{
				case 'N':
					return Directions.North;
				case 'E':
					return Directions.East;
				case 'S':
					return Directions.South;
				case 'W':
					return Directions.West;
				default:
					return Directions.NA;

			}
		}

		// private method if null
		private string HowManyLanes()
		{
			if (NumbLanes == null)
				return "NA";
			else
				return NumbLanes.ToString();
		}

		// Tostring method that return everything
		public override string ToString()
		{
			//return base.ToString();
			return $"Highway Name: {Name}\n" +
				   $"Highway Type: {HighwayType}\n" +
				   $"Direction: {GetDirections()}\n" +   // change property to method call
				   $"Surface: {Surface}\n" +
				   $"Number of Lanes: {HowManyLanes()}\n" + // change property to method call
				   $"Toll: {IsHighwayToll()}\n" +  // change property to method call
				   $"Maintainance: {Maintainance}\n";
		}
	}
}
