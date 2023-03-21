using System;

namespace Survivor
{
    public class Tyche : God
    {
        public Tyche(Item favourite, Item hated, int maxPatience)
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }

        public override void Miracle(Game game)
        {
            throw new NotImplementedException();
        }
        
        public override void Disaster(Game game)
        {
            throw new NotImplementedException();
        }
        
        public override string ToString()
        {
            return $"{GetType().Name} : {Patience}";
        }
    }
}

