#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Core
{
    internal class BitmapStyleInfo
    {
        public enum ShapeTypes
        {
            Circle,
            Rectangle,
            Triangle
        }
      
        public bool IsFilled { get; set; }
        public int Size { get; set; }
        public int PenSize { get; set; }
        public byte Opacity { get; set; }
        public Color Color { get; set; }
        public ShapeTypes Shape { get; set; }
    }
}
