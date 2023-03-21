using System;

namespace Survivor
{
    public class Tree : Item 
    {
        private int _growth;
        
        public Tree() 
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();

        }
        
        public int GetGrowth()
        {
            throw new NotImplementedException();

        }
        
        public void SetGrowth(int growth)
        {
            throw new NotImplementedException();

        }
        
        public override void Update()
        {
            throw new NotImplementedException();

        }

        public override string ToString()
        {
            return "T";
        }
    }
}