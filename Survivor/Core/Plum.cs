using System;

namespace Survivor
{
    public class Plum : Item
    {
        public Plum(int expiry, int energyAmount) : base(expiry, energyAmount, true)
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
        }

        public override void Update()
        {
            Expiry -= 1;
        }
        
        public override string ToString()
        {
            return "P";
        }
    }
}