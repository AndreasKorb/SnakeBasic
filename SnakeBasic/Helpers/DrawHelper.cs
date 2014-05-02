﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeBasic.Helpers
{
  public class DrawHelper
  {
    public static void Draw(Point position, char renderingChar)
    {
      Draw(position.X, position.Y, renderingChar);
    }

    public static void Draw(int left, int top, char renderingChar)
    {
      Console.SetCursorPosition(left, top);
      Console.Write(renderingChar);
      Console.SetCursorPosition(0, 0); // Set back to first line that the scrollbar is always on top
    }
  }
}