using System.Collections.Generic;

namespace MarsRoverCaseStudy.BLL
{
    public interface IRotation
    {
        void MoveByInstruction(List<int> points, string moves);

        void MoveLeft();

        void MoveRight();

        void MoveForward();
    }
}
