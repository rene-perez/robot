using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningRobot.Domain
{
	public struct CleaningRobotState
	{
		public Position Position { get; }
		public OrientationEnum Orientation { get; }

		public CleaningRobotState(int x, int y, OrientationEnum orientation)
		{
			Position = new Position(x, y);
			Orientation = orientation;
		}

		public CleaningRobotState ChangeOrientation(OrientationEnum orientation)
		{
			return new CleaningRobotState(Position.X, Position.Y, orientation);
		}
	}

	public enum OrientationEnum
	{
		North,
		South,
		East,
		West
	}
}
