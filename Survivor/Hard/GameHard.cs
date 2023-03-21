using System;

namespace Survivor
{
    public class GameHard : GameAdvanced
    {
        private (int x, int y) _ulyssescoordinates;
        public GameHard(Random random, int spawnRate, int daysLeft, int boardWidth, int boardHeight)
        {
            // FIXME: this constructor should call parent constructor with multiple parameters using base(a, b, ...)
            throw new NotImplementedException();
        }
        
        private void SpawnUlysses()
        {
            throw new NotImplementedException();

        }
        
        protected override bool NextDay()
        {
            throw new NotImplementedException();

        }

        private void PrintPathToUlysses()
        {
            throw new NotImplementedException();
        }

        protected override void PrintAll()
        {
            throw new NotImplementedException();
        }
        
        protected override Cell[,] CreateBoard(int width, int height)
        {
            throw new NotImplementedException();
        }
    }
}