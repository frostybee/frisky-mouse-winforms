using FriskyMouse.GlobalHooks;
using FriskyMouse.NativeApi;
using FriskyMouse.MouseDecorator.Helpers;
using FriskyMouse.UI;
using FriskyMouse.Core;
using System;
using System.Drawing;
using System.Xml.Linq;
using System.Reflection;

namespace FriskyMouse.Core
{
    internal class HighlighterController : IDisposable
    {
        private Bitmap _spotlightBitmap;
        private LayeredWindow _layeredWindow;
        private bool disposed = false;

        internal HighlighterController()
        {
            _layeredWindow = new LayeredWindow();
        }

        internal void SetupHighlighter(HighlighterSettings highlighterSettings)
        {
            highlighterSettings.IsForPreview = false;
            // Clean up any previously generated bitmap.
            _spotlightBitmap?.Dispose();
            _spotlightBitmap = DrawingHelper.DrawEllipseBitmap(highlighterSettings);
            _layeredWindow.SetBitmap(_spotlightBitmap, highlighterSettings.Opacity);
            // Set the highlighter's initial position after launching the application or
            // changing the settings. 
            MoveSpotlight(_layeredWindow.GetCursorPosition());
            _layeredWindow.Show();
        }

        internal void MoveSpotlight(POINT inPoint)
        {
            if (_spotlightBitmap != null)
            {
                SetLayeredWindowCoordinates(inPoint);
                _layeredWindow.Move();
            }
        }        

        internal void BringToFront(POINT inPoint)
        {
            if (DecorationController.Instance.SettingsManager.HighlighterSettings.IsEnabled)
            {
                // Adjust the coordinates of the layered window based on the spotlight's bitmap size.
                SetLayeredWindowCoordinates(inPoint);
                _layeredWindow.SetTopMost();
            }
        }
        private void SetLayeredWindowCoordinates(POINT inPoint)
        {
            int pointX = inPoint.X - _spotlightBitmap.Width / 2;
            int pointY = inPoint.Y - _spotlightBitmap.Height / 2;
            _layeredWindow.PositionX = pointX;
            _layeredWindow.PositionY = pointY;
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
                    //TODO: properly terminate the layered window. Need to call a NativeApi method.
                    _layeredWindow = null;

                }
                disposed = true;
            }
        }

        public LayeredWindow LayeredWindow => _layeredWindow;
    }
}
