using Xunit;
using Should;
using CleaningRobot.Domain;

namespace CleaningRobot.Tests
{
    public class CleaningRobotTests
    {
		[Fact]
		public void CleaningRobot_faces_west_when_turn_left_from_north()
		{
			var sut = CreateRobot(OrientationEnum.North);
			sut.ExecuteInstruction(InstructionEnum.TurnLeft);
			sut.CurrentPosition.ShouldEqual(new Position(0, 0));
		}

		[Fact]
		public void CleaningRobot_faces_south_when_turn_left_from_west()
		{
			var sut = CreateRobot(OrientationEnum.West);
			sut.ExecuteInstruction(InstructionEnum.TurnLeft);
			sut.CurrentPosition.ShouldEqual(new Position(0, 0));
		}

		[Fact]
		public void CleaningRobot_faces_east_when_turn_left_from_south()
		{
			var sut = CreateRobot(OrientationEnum.South);
			sut.ExecuteInstruction(InstructionEnum.TurnLeft);
			sut.CurrentPosition.ShouldEqual(new Position(0, 0));
		}

		[Fact]
		public void CleaningRobot_faces_north_when_turn_left_from_east()
		{
			var sut = CreateRobot(OrientationEnum.East);
			sut.ExecuteInstruction(InstructionEnum.TurnLeft);
			sut.CurrentPosition.ShouldEqual(new Position(0, 0));
		}

		private Robot CreateRobot(OrientationEnum orientation)
		{
			return new Robot(100, new Position(0, 0), new Orientation(orientation));
		}
	}
}
