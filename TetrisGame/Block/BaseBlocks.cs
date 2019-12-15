using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace TetrisGame.Block
{
    public enum RotateDirection { Left, Right };
    public abstract class BaseBlocks
    {
        public List<int[]> coordinates;

        protected BaseBlocks()
        {
            coordinates = new List<int[]>();
        }

        public abstract void Render(Grid grid);

        public abstract void Rotate(RotateDirection rotateDirection);
    }
}
