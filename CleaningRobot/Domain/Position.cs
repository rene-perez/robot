using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningRobot.Domain
{
	public struct Position
	{
		public int X { get; }
		public int Y { get; }

		public Position(int x, int y)
		{
			if (x < 0)
				throw new ArgumentOutOfRangeException("x needs to be positive.");
			if (y < 0)
				throw new ArgumentOutOfRangeException("y needs to be positive.");

			X = x;
			Y = y;
		}
	}
}
