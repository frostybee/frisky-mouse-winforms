#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-2023 FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

namespace FriskyMouse.Drawing.Ripples
{
    internal class CrosshairProfile : BaseRippleProfile
    {
        private SolidBrush _verticalBrush;
        private SolidBrush _horizontalBrush;
        public CrosshairProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {            
            int width = 40;
            int height = 8;            
            _verticalBrush = new SolidBrush(Color.DarkBlue);
            _horizontalBrush = new SolidBrush(Color.Crimson);            
            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = new Rectangle((200/ 2) - 4, (200 / 2) - 20, height, width),
                    ShapeType = ShapeType.Crosshair,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    FillBrush = _verticalBrush,
                    IsFilled = true,
                });
            AddRipple(
             new RippleEntry()
             {
                 IsExpandable = false,
                 Bounds = new Rectangle((200 / 2) - 20, (200 / 2) - 4, width, height),
                 ShapeType = ShapeType.Crosshair,
                 InitialRadius = 10,
                 RadiusMultiplier = 2,
                 FillBrush = _horizontalBrush,
                 IsFilled = true,
             });
        }       
    }
}
