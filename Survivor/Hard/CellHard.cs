using System;

namespace Survivor
{
    public class CellHard : Cell
    {
        private int _ulysses;
        public CellHard()
        {        
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }
        
        public int GetUlysses()
        {
            throw new NotImplementedException();

        }
        
        public void SetUlysses(int ulysses)
        {
            throw new NotImplementedException();

        }
        
        public override void Update()
        {
            throw new NotImplementedException();

        }

        public override string ToString()
        {
            return _ulysses > 0 ? "U" : " ";
        }
    }
}