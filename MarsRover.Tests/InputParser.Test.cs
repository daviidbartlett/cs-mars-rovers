using MarsRover.Console;
using MarsRover.Console.Inputs;

namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [TestCase("L", new[] { Instruction.L })]
        public void ParseInstruction_AddSingleInstructionToList(string input, Instruction[] expected)
        {
            Instruction parsedInstruction = InputParser.ParseInstruction('L');
            Assert.That(parsedInstruction, Is.EqualTo(Instruction.L));

        }
    }