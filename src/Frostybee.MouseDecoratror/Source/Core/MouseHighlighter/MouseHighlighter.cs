using Frostybee.GlobalHooks;
using Frostybee.GlobalHooks.NativeApi;
using Frostybee.MouseDecorator.Helpers;
using Frostybee.MouseDecorator.UI;
using Frostybee.MouseDecorator.Core;
using System;
using System.Drawing;
using System.Xml.Linq;

namespace Frostybee.MouseDecorator.Core
{
    internal class MouseHighlighter : IDisposable
    {        
        private Bitmap _spotlightBitmap;
        private LayeredWindow _layeredWindow;
        private bool disposed = false;

        internal MouseHighlighter()
        {
            _layeredWindow = new LayeredWindow();
        }

        internal void SetupHighlighter(HighlighterSettings highlighterSettings)
        {            
            _spotlightBitmap = DrawingHelper.DrawEllipseBitmap(highlighterSettings);
            _layeredWindow.SetBitmap(_spotlightBitmap, highlighterSettings.Opacity);
            _layeredWindow.Show();
        }

        internal void MoveSpotlight(POINT point)
        {
            if (_spotlightBitmap != null)
            {
                _layeredWindow.LeftCoordinate = point.X - _spotlightBitmap.Width / 2;
                _layeredWindow.TopCoordinate = point.Y - _spotlightBitmap.Height / 2;
                _layeredWindow.Move((point.X - _spotlightBitmap.Width / 2), (point.Y - _spotlightBitmap.Height / 2));
            }                    
        }

       

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {

                if (disposing)
                {
                    // Clean up resources.
                    _spotlightBitmap?.Dispose();
                    _spotlightBitmap = null;
                    _layeredWindow?.Dispose();
                    //TODO: properly termniate the layered window. Need to call a NativeApi method.
                    _layeredWindow = null;

                }
                disposed = true;
            }
        }
        public LayeredWindow LayeredWindow { get => _layeredWindow; }
    }
}
