﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace RTDDE.ModelViewer
{
    /// <summary>
    /// Represents a Framework element which is acting as a border for a window.
    /// </summary>
    public class WindowBorder
    {
        /// <summary>
        /// The element which is acting as the border.
        /// </summary>
        public FrameworkElement Element { get; private set; }

        /// <summary>
        /// The position of the border.
        /// </summary>
        public BorderPosition Position { get; private set; }

        /// <summary>
        /// Creates a new window border using the specified element and position.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="element"></param>
        public WindowBorder(BorderPosition position, FrameworkElement element)
        {
            if (element == null)
            {
                throw new ArgumentNullException("element");
            }

            Position = position;
            Element = element;
        }
    }
    public enum BorderPosition
    {
        Left = 61441,
        Right = 61442,
        Top = 61443,
        TopLeft = 61444,
        TopRight = 61445,
        Bottom = 61446,
        BottomLeft = 61447,
        BottomRight = 61448
    }
}
