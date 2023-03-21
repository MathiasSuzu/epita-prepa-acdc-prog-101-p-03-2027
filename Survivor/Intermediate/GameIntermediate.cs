using System;

namespace Survivor
{
    public class GameIntermediate: Game
    {
        protected God[] Gods;

        public GameIntermediate(Random random, int spawnRate, int daysLeft, int boardWidth, int boardHeight)
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }

        public GameIntermediate()
        {
            throw new NotImplementedException("Delete This Constructor When Game Hard Is Implemented");
        }

        public void SetSpawnRate(int newSpawnRate)
        {
            throw new NotImplementedException();
        }
        
        public int GetSpawnRate()
        {
            throw new NotImplementedException();
        }
        
        public Player GetPlayer()
        {
            throw new NotImplementedException();
        }

        public void IncreaseDaysLeft(int days)
        {
            throw new NotImplementedException();
        }
        
        protected void MakeOffering()
        {
            throw new NotImplementedException();
        }
        
        protected override void SpawnItem(int x, int y)
        {
            throw new NotImplementedException();
        }
        
        protected override bool NextDay()
        {
            throw new NotImplementedException();
        }
        
        protected override bool GetAction() 
        {
            throw new NotImplementedException();
        }    
        
        protected void PrintGods()
        {
            throw new NotImplementedException();
        }

        protected void PrintInventory()
        {
            throw new NotImplementedException();
        }

        protected override void PrintAll()
        {
            throw new NotImplementedException();
        }
    }
}
