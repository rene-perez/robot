using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleaningRobot.Domain
{
	public struct Instruction
	{
		public static readonly Instruction TurnLeft = new Instruction(InstructionType.TL, 1);
		public static readonly Instruction TurnRight = new Instruction(InstructionType.TR, 1);
		public static readonly Instruction Advance = new Instruction(InstructionType.A, 2);
		public static readonly Instruction Clean = new Instruction(InstructionType.C, 5);
		public static readonly Instruction Back = new Instruction(InstructionType.B, 3);

		public InstructionType Type { get; private set; }
		public int BatteryCost { get; private set; }

		private Instruction(InstructionType type, int batteryCost)
		{
			Type = type;
			BatteryCost = batteryCost;
		}

		public override string ToString()
		{
			return Type.ToString();
		}
	}

	public enum InstructionType
	{
		TL,
		TR,
		A,
		C,
		B
	}
}
