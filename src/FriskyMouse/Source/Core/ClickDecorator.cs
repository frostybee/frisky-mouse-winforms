using FriskyMouse.GlobalHooks;
using FriskyMouse.MouseDecorator.Helpers;
using FriskyMouse.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace FriskyMouse.Core
{
    internal class ClickDecorator : IDisposable
    {
        private BitmapStyleInfo bitmapInfo;
        // Counter for click timer.
        private const int CLICK_TIMER_DURATION = 1500;
        private const int CLICK_TIMER_INTERVAL = 250;
        private int elapsedTime = 0;
        //TODO move this to settings.
        private int stylingDuration = 60;
        private bool isClickStyleEnabled = true;
        private bool isDrawing = false;
        private int rightButtonRingSize = 3;
        private int currentFrame = 0;
        private bool disposedValue = false;
        int dx = 3;
        private readonly IList<Bitmap> framesCache;
        private readonly System.Timers.Timer clickAnimationTimer = new System.Timers.Timer();
        private readonly LayeredWindow clickStylingWindow;

        internal ClickDecorator()
        {
            clickStylingWindow = new LayeredWindow();
            framesCache = new List<Bitmap>();
            // Initialize the click timer.             
            clickAnimationTimer.Interval = stylingDuration;
            clickAnimationTimer.Elapsed += TimerClickAnimation_Update;
            clickAnimationTimer.AutoReset = true;         
        }
        internal void LoadAnimationFrames()
        {
            framesCache.Clear();
            // Draw multiple frames.
            for (int i = 0; i < 15; i++)
            {
                //Bitmap ringBitmap = DrawingHelper.DrawEllipseBitmap(bitmapInfo);
                //framesCache.Add(ringBitmap);
                bitmapInfo.Size += dx;
            }
        }
        internal void SetClickStyle(BitmapStyleInfo clickStyle)
        {
            bitmapInfo = clickStyle;
            LoadAnimationFrames();
            /* _spotlightBitmap = DrawingHelper.DrawEllipseBitmap(BitmapInfo);
             layeredWindow.SetBitmap(_spotlightBitmap, BitmapInfo.OpacityPercentage);
             layeredWindow.Show();*/
        }

        internal void DecorateLeftSingleClick(RawMouseEvents e)
        {
            try
            {
                Debug.WriteLine("Here.... ");
                isClickStyleEnabled = true;
                if (!isClickStyleEnabled)
                    return;
                //TODO: optimize this.
                if (!isDrawing)
                {
                    clickStylingWindow.PositionX = e.Point.X - (bitmapInfo.Size / 2);
                    clickStylingWindow.PositionY = e.Point.Y - (bitmapInfo.Size / 2);
                    //clickStylingWindow.Move((e.Point.X - bitmapInfo.Size / 2), (e.Point.Y - bitmapInfo.Size / 2));
                    //mouseStylingForm.Show();
                    clickAnimationTimer.Start();
                }
            }
            catch (Exception ex)
            {
            }
        }

        internal void SetDoubleClickStyle(BitmapStyleInfo clickStyle)
        {
            bitmapInfo = clickStyle;
        }

        internal void DecorateDoubleClick(RawMouseEvents e)
        {
            BitmapStyleInfo doubleClickStyle = new BitmapStyleInfo { Size = 100, Color = Color.Green, Opacity = 250, PenSize = 6, Shape = BitmapStyleInfo.ShapeTypes.Circle, IsFilled = false };
            bitmapInfo = doubleClickStyle;
            try
            {
                if (!isClickStyleEnabled)
                    return;
                //TODO: optimize this.
                if (!isDrawing)
                {
                    clickStylingWindow.PositionX = e.Point.X - bitmapInfo.Size / 2;
                    clickStylingWindow.PositionY = e.Point.Y - bitmapInfo.Size / 2;
                    //clickStylingWindow.Move((e.Point.X - bitmapInfo.Size / 2), (e.Point.Y - bitmapInfo.Size / 2));
                    //mouseStylingForm.Show();
                    clickAnimationTimer.Start();
                }
            }
            catch (Exception ex)
            {
            }
        }
        private void TimerClickAnimation_Update(object sender, EventArgs e)
        {
            //this.mClickHighlightForm.Hide();
            this.clickAnimationTimer.Stop();
            try
            {
                Console.WriteLine("TimerTrackbar_Update");
                if (elapsedTime > CLICK_TIMER_DURATION)
                {
                    clickStylingWindow.Hide();
                    bitmapInfo.Size = rightButtonRingSize;
                    elapsedTime = 0;
                    isDrawing = false;
                    currentFrame = 0;
                }
                else
                {
                    // TODO: cache the generated bitmaps in a data structure.
                    // Draw multiple circles.                    
                    //-- Get a frame. 
                    if (currentFrame >= framesCache.Count)
                    {
                        currentFrame = 0;
                    }
                    Bitmap ringBitmap = framesCache[currentFrame];
                    clickStylingWindow.SetBitmap(ringBitmap, bitmapInfo.Opacity);
                    clickStylingWindow.Show();
                    clickAnimationTimer.Start();
                    isDrawing = true;
                    currentFrame++;                    
                }
                elapsedTime += CLICK_TIMER_INTERVAL;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    clickAnimationTimer.Elapsed -= TimerClickAnimation_Update;
                    clickAnimationTimer.Dispose();
                    // Dispose the cached frames.                    
                    // TODO: move to 
                    if (framesCache != null)
                    {
                        foreach (var frame in framesCache)
                        {
                            frame.Dispose();                            
                        }
                        // Clear all the previously generated bitmaps.
                        framesCache.Clear();
                    }
                }
                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ClickDecorator()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
