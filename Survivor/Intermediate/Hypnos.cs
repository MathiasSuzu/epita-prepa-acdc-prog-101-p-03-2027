using System;

namespace Survivor
{
    public class Hypnos : God
    {
        public Hypnos(Item favourite, Item hated, int maxPatience)
        { 
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }

        public Hypnos()
        {
            throw new NotImplementedException("Delete This Constructor When HypnosAdvanced Is Implemented");
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

