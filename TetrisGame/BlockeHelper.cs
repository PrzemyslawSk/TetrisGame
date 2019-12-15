using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TetrisGame
{
    public static class BlockeHelper
    {
        public static void InsertBlock(Grid grid, UIElement element, int x, int y, int width, int height)
        {
            grid.Children.Add(element);
            Grid.SetColumn(element, x);
            Grid.SetRow(element, y);
            Grid.SetColumnSpan(element, width);
            Grid.SetRowSpan(element, height);
        }
    }
}
