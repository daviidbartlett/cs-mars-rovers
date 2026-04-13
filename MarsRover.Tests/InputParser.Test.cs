using MarsRover;


namespace MarsRover.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ParseInstruction_AddSingleInstructionToList()
        {
            Instruction parsedInstruction = InputParser.ParseInstruction('L');
            Assert.That(parsedInstruction, Is.EqualTo(Instruction.L));
        }
    }
}