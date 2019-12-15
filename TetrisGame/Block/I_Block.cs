using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace TetrisGame.Block
{
    class I_Block : BaseBlocks
    {
        bool isHorizontal = false;
        public I_Block()
        {
            coordinates.Add(new int[] { 5, 0 });
            coordinates.Add(new int[] { 5, 1 });
            coordinates.Add(new int[] { 5, 2 });
            coordinates.Add(new int[] { 5, 3 });
        }
        public override void Render(Grid grid)
        {
            foreach (var coord in coordinates)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Fill = Brushes.PaleVioletRed;
                BlockeHelper.InsertBlock(grid, rectangle, coord[0], coord[1], 1, 1);
            }
        }
        //private void OnKeyDownHandler(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Down)
        //    {
        //        coordinates[0][1] += 1;
        //    }
        //}

        public override void Rotate(RotateDirection rotateDirection)
        {
            switch (rotateDirection)
            {
                case RotateDirection.Left:
                    if(!isHorizontal)
                    {
                        //coordinates.Add(new int[] { 5, 0 });
                        //coordinates.Add(new int[] { 5, 1 });
                        //coordinates.Add(new int[] { 5, 2 });
                        //coordinates.Add(new int[] { 5, 3 });
                        coordinates[0][0] -= 2;
                        var y = coordinates[0][1] -= 1; //1  { 3, -1 }
                        coordinates[1][0] -= 1;
                        coordinates[1][1] -= y; //2  { 4, -1 }
                        coordinates[2][0] -= 0;
                        coordinates[2][1] -= y; //3  {5, -1 }
                        coordinates[3][0] += 1;
                        coordinates[3][1] -= y; //4  {6, -1 }
                        isHorizontal = true;
                    }
                    else
                    {
                        var x = coordinates[0][0] += 1;
                        coordinates[0][1] -= 1 ; //1  { 5, 0 }
                        coordinates[1][0] -= x;
                        coordinates[1][1] -= 0; //2  { 5, 1 }
                        coordinates[2][0] -= x;
                        coordinates[2][1] += 1; //3  { 5, 2 }
                        coordinates[3][0] += x;
                        coordinates[3][1] += 2; //4  {5, 3 }
                        isHorizontal = false;
                    }

                    break;
                case RotateDirection.Right:
                    break;
            }
        }
    }
}
