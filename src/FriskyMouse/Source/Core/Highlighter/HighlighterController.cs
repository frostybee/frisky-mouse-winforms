using FriskyMouse.NativeApi;
using FriskyMouse.MouseDecorator.Helpers;
using FriskyMouse.UI;
using System;
using System.Drawing;

namespace FriskyMouse.Core
{
    internal class HighlighterController : IDisposable
    {
        /// <summary>
        /// The bitmap on which the mouse highlighter is drawn.
        /// </summary>
        private Bitmap _spotlightBitmap;
        /// <summary>
        /// The transparent, click-through window used 
        /// to show the mouse highlighter. 
        /// </summary>
        private LayeredWindow _layeredWindow;
        private bool disposed = false;
        private readonly SettingsManager _settingsManager;
        internal HighlighterController(SettingsManager pSettingsManager)
        {
            //TODO: need to refactor this messy code. We could inherit from LayeredWindow.
            _layeredWindow = new LayeredWindow();
            _settingsManager = pSettingsManager;
        }

        internal void SetupHighlighter(HighlighterInfo highlighterSettings)
        {
            highlighterSettings.IsForPreview = false;
            // Clean up any previously generated bitmap.
            _spotlightBitmap?.Dispose();
            _spotlightBitmap = DrawingHelper.DrawEllipseBitmap(highlighterSettings);
            _layeredWindow.SetBitmap(_spotlightBitmap, highlighterSettings.Opacity);
            // Set the highlighter's initial position after launching the application or
            // applying new settings. 
            MoveSpotlight(_layeredWindow.GetCursorPosition());
            _layeredWindow.Show();
        }

        /// <summary>
        /// Moves the highlighter to the specified coordinates.
        /// </summary>
        /// <param name="inPoint">A point containing the current X and Y coordinates of the mouse cursor.</param>
        internal void MoveSpotlight(POINT inPoint)
        {
            if (_settingsManager.HighlighterSettings.Enabled)
            {
                if (_spotlightBitmap != null)
                {
                    SetLayeredWindowCoordinates(inPoint);
                    _layeredWindow.Move();
                }
            }
        }
        /// <summary>
        /// Brings the highlighter to the top just in case it got hidden by another application's context/popup menu.
        /// </summary>
        /// <param name="inPoint"></param>
        internal void BringToFront(POINT inPoint)
        {

            if (_settingsManager.HighlighterSettings.Enabled)
            {
                // Adjust the coordinates of the layered window based on the spotlight's bitmap size.
                SetLayeredWindowCoordinates(inPoint);
                _layeredWindow.SetTopMost();
            }
        }
        /// <summary>
        /// Repositions the layered window where the cursor is currently pointing on the screen.
        /// </summary>
        /// <param name="inPoint">A point containing the X and Y coordinates of the mouse cursor. </param>
        private void SetLayeredWindowCoordinates(POINT inPoint)
        {
            _layeredWindow.PositionX = (inPoint.X + 1) - _spotlightBitmap.Width / 2;
            _layeredWindow.PositionY = (inPoint.Y + 1) - _spotlightBitmap.Height / 2;
        }
        internal void HideSpotlight()
        {
            _layeredWindow?.Hide();
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

    }
}
