#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

using FriskyMouse.Drawing.Helpers;

namespace FriskyMouse.Drawing.Ripples
{
    internal class SpotlightProfile : BaseRippleProfile
    {        
        private SolidBrush _innerBrush;
        public SpotlightProfile()
        {
            CreateProfileEntries();
        }
        private void CreateProfileEntries()
        {
            _innerBrush = new SolidBrush(Color.Crimson);            
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = false,
                    Bounds = DrawingHelper.CreateRectangle(Width, Height, 15),
                    ShapeType = ShapeType.Ellipse,
                    InitialRadius = 15,
                    RadiusMultiplier = 3,
                    FillBrush = _innerBrush,
                    IsFilled = true,
                    IsFade = true,
                    IsStyleable = true
                });
        }
    }
}
