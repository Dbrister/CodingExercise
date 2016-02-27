using System;

namespace MindOverMachinesProject.Models
{
    [Flags]
    public enum DirectionOfCalculation
    {
        NONE = 0,
        UP = 1,
        RIGHT = 2,
        DOWN = 4,
        LEFT = 8,
        UPANDRIGHT = UP | RIGHT,
        UPANDLEFT = UP |LEFT,
        DOWNANDRIGHT = DOWN | RIGHT,
        DOWNANDLEFT = DOWN | LEFT
    }
}
