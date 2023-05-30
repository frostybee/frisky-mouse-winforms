using System.Drawing;

namespace FriskyMouse.HelpersLib.Drawing
{
    internal class CrosshairProfile : BaseProfile
    {
        SolidBrush _verticalBrush;
        SolidBrush _horizontalBrush;
        public CrosshairProfile()
        {
            InitProfileEntries();
        }

        private void InitProfileEntries()
        {            
            int width = 40;
            int height = 8;
            // TODO: Set the initial opacity here. 
            //_verticalBrush = new SolidBrush(Color.CornflowerBlue);
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
