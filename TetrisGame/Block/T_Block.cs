using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TetrisGame.Block
{
    class T_Block : BaseBlocks
    {
        public T_Block()
        {
            coordinates.Add(new int[] { 4, 0 });
            coordinates.Add(new int[] { 5, 0 });
            coordinates.Add(new int[] { 6, 0 });
            coordinates.Add(new int[] { 5, 1 });
        }
        public override void Render(Grid grid)
        {
            foreach (var coord in coordinates)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Fill = Brushes.Purple;
                BlockeHelper.InsertBlock(grid, rectangle, coord[0], coord[1], 1, 1);
            }
        }
    }
}
