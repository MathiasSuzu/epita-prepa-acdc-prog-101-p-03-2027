using System;
namespace Survivor
{
    public class PlayerIntermediate : Player
    {
        protected Item[] Inventory; 
        protected readonly int SizeInventory;
        
        public PlayerIntermediate(int maxEnergy, int x, int y)
        { 
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }
        
        public PlayerIntermediate()
        {
            throw new NotImplementedException("Delete This Constructor When Game Hard Is Implemented");
        }
        
        public void SetEnergy(int energy)
        {
            throw new NotImplementedException();
        }

        public Item[] GetInventory()
        {
            throw new NotImplementedException();
        }
 
        private static int SelectItem()
        {
            throw new NotImplementedException();
        }
        
        public void PickUp(Cell[,] board)
        {
            throw new NotImplementedException();
        }

        public void Drop(Cell[,] board)
        {
            throw new NotImplementedException();
        }
        
        public void Sacrifice(Game game, God god)
        {
            throw new NotImplementedException();
        }
       
    }
}
