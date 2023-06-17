using FriskyMouse.HelpersLib.Helpers;
using FriskyMouse.NativeApi;
using FriskyMouse.UI;

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
        private bool _disposed = false;
        private readonly ApplicationSettings _settingsManager;
        private int _width = 0;
        private int _height = 0;

        internal HighlighterController(ApplicationSettings pSettingsManager)
        {
            _layeredWindow = new LayeredWindow();
            _settingsManager = pSettingsManager;
        }

        internal void InitHighlighter(HighlighterOptions highlighterInfo)
        {
            highlighterInfo.IsForPreview = false;
            // Clean up any previously generated bitmap.
            _spotlightBitmap?.Dispose();
            _spotlightBitmap = DrawingHelper.CreateBitmap(200, 200, Color.Transparent);
            Graphics graphics = Graphics.FromImage(_spotlightBitmap);
            Rectangle rect = DrawingHelper.CreateRectangle(200, 200, highlighterInfo.Radius);
            graphics.DrawSpotlight(rect, highlighterInfo);
            _width = _spotlightBitmap.Width;
            _height = _spotlightBitmap.Height;
            _layeredWindow.SetBitmap(_spotlightBitmap, highlighterInfo.Opacity);
            // Set the highlighter's initial position after launching the application or
            // applying new settings. 
            //MoveSpotlight(_layeredWindow.GetCursorPosition());
            _layeredWindow.Show();
        }

        /// <summary>
        /// Moves the highlighter to the specified coordinates.
        /// </summary>
        /// <param name="inPoint">A point containing the current X and Y coordinates of the mouse cursor.</param>
        internal void MoveSpotlight(POINT inPoint)
        {
            if (_settingsManager.HighlighterOptions.Enabled)
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
            if (_settingsManager.HighlighterOptions.Enabled)
            {
                // Adjust the coordinates of the layered window based on the spotlight's bitmap size.
                SetLayeredWindowCoordinates(inPoint);
                _layeredWindow.SetTopMost();
            }
        }
        /// <summary>
        /// Repositions the layered window where the cursor is currently pointing on the screen.
        /// </summary>
        /// <param name="point">A point containing the X and Y coordinates of the mouse cursor. </param>
        private void SetLayeredWindowCoordinates(POINT point)
        {
            _layeredWindow.PositionX = (point.X) - (_width / 2);
            _layeredWindow.PositionY = (point.Y) - (_height / 2);
        }
        internal void SetInitialPosition()
        {
            POINT coordinates = _layeredWindow.GetCursorPosition();
            if (coordinates != POINT.Empty)
            {
                SetLayeredWindowCoordinates(coordinates);
            }
        }
        internal void HideSpotlight()
        {
            _layeredWindow?.Hide();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
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
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }        
    }
}
