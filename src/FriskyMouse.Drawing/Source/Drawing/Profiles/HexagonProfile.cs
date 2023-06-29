#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Ripples
{
    internal class HexagonProfile : BaseRippleProfile
    {
        private Pen _outlinePen;        
        public HexagonProfile()
        {
            CreateProfileEntries();
        }

        private void CreateProfileEntries()
        {
            _outlinePen = new Pen(Color.Crimson, 4);
            // 1) Make the outer most ripple.
            AddRipple(
                new RippleEntry()
                {
                    IsExpandable = true,                    
                    ShapeType = ShapeType.Polygon,
                    InitialRadius = 10,
                    RadiusMultiplier = 2,
                    OutlinePen = _outlinePen,
                    IsFilled = false,
                    PolygonType = PolygonType.Hexagon,
                    IsStyleable = true,                    
                });
        }
    }
}
