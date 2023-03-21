using System;

namespace Survivor
{
    public class Animal: Item
    {
        private bool _isDead;
        
        public Animal(int energyAmount)
        { 
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }

        public void Kill()
        {
            throw new NotImplementedException();
        }
        
        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return _isDead ? "D" : "A";
        }
    }
}