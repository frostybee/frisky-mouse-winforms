using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using Bee.MouseDecorator.Helpers;
using Bee.MouseDecorator.UI;
using MouseDecoratror.Core;
using System;
using System.Drawing;

namespace Bee.MouseDecorator.Core
{
    internal class MouseHighlighter : IDisposable
    {        
        private Bitmap highlightBitmap;
        private LayeredWindow highlightWindow;
        private bool disposed = false;

        internal MouseHighlighter()
        {
            highlightWindow = new LayeredWindow();
        }

        internal void SetupHighlighter(HighlighterSettings highlighterSettings)
        {            
            highlightBitmap = DrawingHelper.DrawEllipseBitmap(highlighterSettings);
            highlightWindow.SetBitmap(highlightBitmap, highlighterSettings.Opacity);
            highlightWindow.Show();
        }

        internal void DecorateMouseMove(POINT point)
        {
            if (highlightBitmap != null)
            {
                highlightWindow.LeftCoordinate = point.X - highlightBitmap.Width / 2;
                highlightWindow.TopCoordinate = point.Y - highlightBitmap.Height / 2;
                highlightWindow.Move((point.X - highlightBitmap.Width / 2), (point.Y - highlightBitmap.Height / 2));
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
                    highlightWindow?.Dispose();
                    //TODO: properly termniate the layered window. Need to call a NativeApi method.
                    highlightWindow = null;

                }
                disposed = true;
            }
        }                    
        
    }
}
