using Xunit;
using Should;
using CleaningRobot.Domain;

namespace CleaningRobot.Tests
{
	public class OrientationTests
	{
		[Fact]
		public void Test1()
		{
			var sut = new Orientation(OrientationEnum.North);
			var result = sut.TurnLeft();
			result.CurrentOrientation.ShouldEqual(OrientationEnum.West);
		}
	}
}
