using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using TetrisGame.Block;

namespace TetrisGame
{
    public class TetrisBlock
    {
        MainWindow mainWindow;
        public TetrisBlock(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;

            CreateBlock(1);
        }

        public static BaseBlocks CreateBlock(int blockNumber)
        {
            if (blockNumber == 0)
            {
                return new Z_Block();
            }
            else if(blockNumber == 1)
            {
                return new S_Block();
            }
            else if (blockNumber == 2)
            {
                return new LeftL_Block();
            }
            else if (blockNumber == 3)
            {
                return new L_Block();
            }
            else if (blockNumber == 4)
            {
                return new Square_Block();
            }
            else if (blockNumber == 5)
            {
                return new T_Block();
            }
            else if (blockNumber == 6)
            {
                return new I_Block();
            }
            return null;
        }

    }
}
