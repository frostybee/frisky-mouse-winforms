using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using Bee.MouseDecorator.Helpers;
using Bee.MouseDecorator.UI;
using MouseDecoratror.Core;
using System;
using System.Drawing;
using System.Xml.Linq;

namespace Bee.MouseDecorator.Core
{
    internal class MouseHighlighter : IDisposable
    {        
        private Bitmap highlightBitmap;
        private LayeredWindow _layeredWindow;
        private bool disposed = false;

        internal MouseHighlighter()
        {
            _layeredWindow = new LayeredWindow();
        }

        internal void SetupHighlighter(HighlighterSettings highlighterSettings)
        {            
            highlightBitmap = DrawingHelper.DrawEllipseBitmap(highlighterSettings);
            _layeredWindow.SetBitmap(highlightBitmap, highlighterSettings.Opacity);
            _layeredWindow.Show();
        }

        internal void DecorateMouseMove(POINT point)
        {
            if (highlightBitmap != null)
            {
                _layeredWindow.LeftCoordinate = point.X - highlightBitmap.Width / 2;
                _layeredWindow.TopCoordinate = point.Y - highlightBitmap.Height / 2;
                _layeredWindow.Move((point.X - highlightBitmap.Width / 2), (point.Y - highlightBitmap.Height / 2));
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
                    highlightBitmap?.Dispose();
                    highlightBitmap = null;
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
