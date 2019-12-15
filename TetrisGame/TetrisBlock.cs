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

        void CreateBlock(int blockNumber)
        {
            if (blockNumber == 0)
            {
                Z_Block z_Block = new Z_Block();
                z_Block.Render(mainWindow.PlayBoard);
            }
            else if(blockNumber == 1)
            {
                S_Block s_Block = new S_Block();
                s_Block.Render(mainWindow.PlayBoard);
            }
            else if (blockNumber == 2)
            {
                LeftL_Block leftL_Block = new LeftL_Block();
                leftL_Block.Render(mainWindow.PlayBoard);
            }
            else if (blockNumber == 3)
            {
                L_Block l_Block = new L_Block();
                l_Block.Render(mainWindow.PlayBoard);
            }
            else if (blockNumber == 4)
            {
                Square_Block square_Block = new Square_Block();
                square_Block.Render(mainWindow.PlayBoard);
            }
            else if (blockNumber == 5)
            {
                T_Block t_Block = new T_Block();
                t_Block.Render(mainWindow.PlayBoard);
            }
            else if (blockNumber == 6)
            {
                I_Block i_Block = new I_Block();
                i_Block.Render(mainWindow.PlayBoard);
            }
        }

    }
}
