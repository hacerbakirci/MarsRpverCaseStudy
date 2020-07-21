using MarsRoverCaseStudy.BLL;
using NUnit.Framework;
using System.Collections.Generic;

namespace MarsRoverCaseStudy.Test
{
    [TestFixture]
    public class RotationTest
    {
        [Test]
        public void Test_12N_LMLMLMLMM()
        {
            Rotation rotation = new Rotation()
            {
                X = 1,
                Y = 2,
                Position = Direction.N
            };


            var startPoints = new List<int>() { 5, 5 };
            var instruction = "LMLMLMLMM";

            rotation.MoveByInstruction(startPoints, instruction);

            var actualOutput = $"{rotation.X} {rotation.Y} {rotation.Position.ToString()}";
            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, actualOutput);

        }

        [Test]
        public void Test_33E_MMRMMRMRRM()
        {
            Rotation rotation = new Rotation()
            {
                X = 3,
                Y = 3,
                Position = Direction.E
            };


            var startPoints = new List<int>() { 5, 5 };
            var instruction = "MMRMMRMRRM";

            rotation.MoveByInstruction(startPoints, instruction);

            var actualOutput = $"{rotation.X} {rotation.Y} {rotation.Position.ToString()}";
            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}
