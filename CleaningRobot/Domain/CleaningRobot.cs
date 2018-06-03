using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningRobot.Domain
{
	public class Robot
	{
		public int Battery { get; private set; }

		public Position CurrentPosition { get; private set; }

		public Orientation CurrentOrientation { get; private set; }

		public Robot(int initialBattery, Position currentPosition, Orientation currentOrientation)
		{
			Battery = initialBattery;
			CurrentPosition = currentPosition;
			CurrentOrientation = currentOrientation;
		}

		public void ExecuteInstruction(InstructionEnum instruction)
		{
			
		}
	}

	public enum InstructionEnum
	{
		TurnLeft,
		TurnRight,
		Advance,
		Clean,
		Back
	}

	public struct Position
	{
		public Position(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int X { get; private set; }

		public int Y { get; private set; }
	}

	public enum OrientationEnum
	{
		North,
		South,
		East,
		West
	}

	public struct Orientation
	{
		public OrientationEnum CurrentOrientation { get; private set; }

		public Orientation(OrientationEnum currentOrientation)
		{
			CurrentOrientation = currentOrientation;
		}

		public Orientation TurnLeft()
		{
			switch (CurrentOrientation)
			{
				case OrientationEnum.North:
					return new Orientation(OrientationEnum.West);
				case OrientationEnum.West:
					return new Orientation(OrientationEnum.South);
				case OrientationEnum.South:
					return new Orientation(OrientationEnum.East);
				case OrientationEnum.East:
					return new Orientation(OrientationEnum.North);
				default:
					throw new InvalidOperationException();
			}
		}

	}

}
