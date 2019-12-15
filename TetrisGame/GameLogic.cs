using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TetrisGame.Block;

namespace TetrisGame
{
    public class GameLogic
    {
        List<I_Block> abandonedBlocks = new List<I_Block>();
        I_Block currentBlock;
        Grid gameGrid;
        public GameLogic(Grid gameGrid)
        {
            this.gameGrid = gameGrid;
        }
        public void Iterate()
        {
            //Block randomizer
            if (currentBlock == null)
            {
                Random random = new Random();
                int whichBlock = random.Next(0, 6);
                currentBlock = new I_Block();
                //currentBlock = TetrisBlock.CreateBlock(whichBlock);
            }
            /*            if ()
                        {
                        }*/
            List<int[]> nextPosition = currentBlock.GetFallPosition();
            if(IsColiding(nextPosition))
            {
                abandonedBlocks.Add(currentBlock);
                currentBlock = null;
            }
            else
                currentBlock.coordinates = nextPosition;

            //Render

            //Clearing children from grid
            gameGrid.Children.Clear();

            foreach (var abandonedBlock in abandonedBlocks)
                abandonedBlock.Render(gameGrid);

            if(!abandonedBlocks.Contains(currentBlock))
                currentBlock.Render(gameGrid);

        }

        bool IsColiding(List<int[]> coordinates)
        {
            foreach (I_Block abandonedBlock in abandonedBlocks)
            {
                foreach (int[] coord in abandonedBlock.coordinates)
                {
                    foreach (int[] colisionCoord in coordinates)
                    {
                        if (colisionCoord[0] == coord[0] && colisionCoord[1] == coord[1])
                            return true;
                    }
                }
            }
            return false;
        }
    }
}
