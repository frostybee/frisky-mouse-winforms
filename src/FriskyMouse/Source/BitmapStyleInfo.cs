#region License Information (MIT)
/* 
   FriskyMouse - A program that lets you highlight your mouse cursor and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
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
