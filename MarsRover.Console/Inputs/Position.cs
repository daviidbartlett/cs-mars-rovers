using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Console.Inputs
{
    internal class Position(int x, int y)
    {
        int X { get; set; } = x;
        int Y { get; set; } = y;
        CompassDirection facing;
    }
}
