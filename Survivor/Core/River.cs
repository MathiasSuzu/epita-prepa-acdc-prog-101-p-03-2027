using System;

namespace Survivor
{
    public class River : Cell
    {
        public River(int moveCost, int spawnRange) : base(moveCost, spawnRange)
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
        }

        public override string ToString()
        {
            return (Content != null ? Content.ToString() : " ");
        }

    }
}