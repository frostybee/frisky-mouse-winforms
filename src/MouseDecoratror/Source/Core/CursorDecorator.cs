using Bee.GlobalHooks;
using Bee.GlobalHooks.NativeApi;
using Bee.MouseDecorator.Helpers;
using Bee.MouseDecorator.UI;
using System;
using System.Drawing;

namespace Bee.MouseDecorator.Core
{
    internal class CursorDecorator : IDisposable
    {        
        private Bitmap highlightBitmap;
        private LayeredWindow highlightWindow;
        private bool disposed = false;

        internal CursorDecorator()
        {
            highlightWindow = new LayeredWindow();
        }

        internal void SetupCursorDecorator(BitmapStyleInfo decorationStyle)
        {
            StyleInfo = decorationStyle;            
            highlightBitmap = DrawingHelper.DrawEllipseBitmap(StyleInfo);
            highlightWindow.SetBitmap(highlightBitmap, StyleInfo.Opacity);
            highlightWindow.Show();
        }

        internal void DecorateMouseMove(POINT point)
        {           
            highlightWindow.LeftCoordinate = point.X - highlightBitmap.Width / 2;
            highlightWindow.TopCoordinate = point.Y - highlightBitmap.Height / 2;
            highlightWindow.Move((point.X - highlightBitmap.Width / 2), (point.Y - highlightBitmap.Height / 2));
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
                    highlightWindow = null;

                }
                disposed = true;
            }
        }       
        
        public BitmapStyleInfo StyleInfo { get; set; }

        
    }
}
