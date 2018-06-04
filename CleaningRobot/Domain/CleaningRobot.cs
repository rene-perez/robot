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
		public CleaningRobotState CurrentState { get; private set; }

		public Robot(int battery, int x, int y, OrientationEnum orientation)
		{
			Battery = battery;
			CurrentState = new CleaningRobotState(x, y, orientation);
		}

		public void ExecuteInstruction(Instruction instruction)
		{
			if (Battery < instruction.BatteryCost)
				return;

			switch (instruction.Type)
			{
				case InstructionType.TL:
					TurnLeft();
					break;
				default:
					throw new InvalidOperationException();
			}

			Battery -= instruction.BatteryCost;
		}

		private void TurnLeft()
		{
			switch (CurrentState.Orientation)
			{
				case OrientationEnum.North:
					CurrentState = CurrentState.ChangeOrientation(OrientationEnum.West);
					break;
				case OrientationEnum.West:
					CurrentState = CurrentState.ChangeOrientation(OrientationEnum.South);
					break;
				case OrientationEnum.South:
					CurrentState = CurrentState.ChangeOrientation(OrientationEnum.East);
					break;
				case OrientationEnum.East:
					CurrentState = CurrentState.ChangeOrientation(OrientationEnum.North);
					break;
				default:
					throw new InvalidOperationException();
			}
		}
	}	
}
