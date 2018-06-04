using Xunit;
using Should;
using CleaningRobot.Domain;

namespace CleaningRobot.Tests
{
    public class CleaningRobotTests
    {
		[Fact]
		public void CleaningRobot_faces_west_and_remains_same_position_when_turn_left_from_north()
		{
			var sut = CreateRobot(orientation: OrientationEnum.North);
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.CurrentState.ShouldEqual(new CleaningRobotState(0,0, OrientationEnum.West));
		}

		[Fact]
		public void CleaningRobot_faces_south_and_remains_same_position_when_turn_left_from_west()
		{
			var sut = CreateRobot(orientation: OrientationEnum.West);
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.CurrentState.ShouldEqual(new CleaningRobotState(0, 0, OrientationEnum.South));
		}

		[Fact]
		public void CleaningRobot_faces_east_and_remains_same_position_when_turn_left_from_south()
		{
			var sut = CreateRobot(orientation: OrientationEnum.South);
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.CurrentState.ShouldEqual(new CleaningRobotState(0, 0, OrientationEnum.East));
		}

		[Fact]
		public void CleaningRobot_faces_north_and_remains_same_position_when_turn_left_from_east()
		{
			var sut = CreateRobot(orientation: OrientationEnum.East);
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.CurrentState.ShouldEqual(new CleaningRobotState(0, 0, OrientationEnum.North));
		}

		[Theory]
		[InlineData(OrientationEnum.North)]
		[InlineData(OrientationEnum.West)]
		[InlineData(OrientationEnum.South)]
		[InlineData(OrientationEnum.East)]
		public void CleaningRobot_battery_reduced_by_turn_left_battery_cost(OrientationEnum orientation)
		{
			var sut = CreateRobot(orientation:orientation);
			var expectedBattery = sut.Battery - Instruction.TurnLeft.BatteryCost;
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.Battery.ShouldEqual(expectedBattery);
		}

		[Fact]
		public void CleaningRobot_does_nothing_if_running_out_of_battery()
		{
			var sut = CreateRobot(battery:0);
			var previousState = sut.CurrentState;
			sut.ExecuteInstruction(Instruction.TurnLeft);
			sut.Battery.ShouldEqual(0);
			sut.CurrentState.ShouldEqual(previousState);
		}

		private Robot CreateRobot(int battery = 100, OrientationEnum orientation = OrientationEnum.North)
		{
			return new Robot(battery, 0, 0, orientation);
		}
	}
}
