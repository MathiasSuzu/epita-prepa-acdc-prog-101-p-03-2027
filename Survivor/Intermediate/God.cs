using System;

namespace Survivor
{
    public abstract class God: IUpdate
    {
        protected Item Favourite;
        protected Item Hated;
        protected int Patience;
        protected int MaxPatience;

        protected God(Item favourite, Item hated, int maxPatience)
        {
            throw new NotImplementedException();
        }

        protected God()
        {
            throw new NotImplementedException("Delete This Constructor When All Gods Are Implemented");
        }

        public int GetPatience()
        {
            throw new NotImplementedException();
        }
        
        public abstract void Miracle(Game game);
        public abstract void Disaster(Game game);
        
        public void ReceiveOffering(Game game, Item item)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }


    }
}