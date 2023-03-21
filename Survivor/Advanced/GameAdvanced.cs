using System;

namespace Survivor
{
    public class GameAdvanced : GameIntermediate
    {
        protected int ViewRange;
        public GameAdvanced(Random random, int spawnRate, int daysLeft, int boardWidth, int boardHeight)
        {   
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }

        public GameAdvanced()
        {
            throw new NotImplementedException("Delete This Constructor When Game Hard Is Implemented");
        }

        public int GetViewRange()
        {
            throw new NotImplementedException();

        }
        public void SetViewRange(int viewRange)
        {
            throw new NotImplementedException();

        }
        
        protected override bool GetAction()
        {
            throw new NotImplementedException();

        }
        
        protected override void UpdateBoard()
        {
            throw new NotImplementedException();
        }
        
        private bool IsInRange(int x, int y)
        {
            throw new NotImplementedException();
        }

        protected override void PrintBoard()
        {
            throw new NotImplementedException();
        }
    }
}