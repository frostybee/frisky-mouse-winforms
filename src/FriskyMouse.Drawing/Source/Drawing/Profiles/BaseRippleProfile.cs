namespace FriskyMouse.Drawing.Ripples
{
    /// <summary>
    /// Each profile maintains its list of ripples. 
    /// </summary>
    public abstract class BaseRippleProfile : IDisposable, IConstructable
    {
        private bool disposedValue;
        private readonly List<RippleEntry> _ripples = new List<RippleEntry>();


        #region Properties
        public int Width { get; set; } = 200;
        public int Height { get; set; } = 200;
        public int BaseRadius { get; set; } = 10;
        #endregion

        /// <summary>
        /// Prepares and renders the ripples that are defined in a given profile.
        /// </summary>
        /// <param name="inRippleProfile">The profile to be rendered.</param>
        /// <param name="progress">The interpolated value that indicates the progress of the currently running animation. </param>
        public void RenderRipples(Graphics _graphics, RippleProfileOptions options, double progress)
        {
            // We adjust the ripple properties according to the provided settings.  
            _ripples.ForEach(ripple =>
            {
                if (options.CanFadeColor)
                {
                    // We fade the color of the ripple based on the current animation's progress value.
                    ripple.AdjustColorOpacity(progress, options.OpacityMultiplier);
                }                
                ripple.ExpandRadius(progress, options.RadiusMultiplier);
                ripple.Draw(_graphics);
            });
        }
        internal void AddRipple(RippleEntry newRipple)
        {
            _ripples.Add(newRipple);
        }

        public void ResetColorOpacity()
        {
            // Reset the opacity of the color upon disabling color transition.
            _ripples.ForEach(ripple =>
            {
                ripple.ResetColorOpacity(255);
            });
        }

        public void UpdateRipplesStyle(RippleProfileOptions options)
        {
            _ripples.ForEach(ripple =>
                {
                    ripple.ChangeColor(options);
                });
        }

        private void DisposeDrawingTools()
        {
            _ripples.ForEach(ripple =>
            {
                // Dispose of the allocated drawing tools.
                ripple.FillBrush?.Dispose();
                ripple.OutlinePen?.Dispose();
            });
            _ripples?.Clear();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // Dispose of the drawing tools such as brushes, pens, etc.
                    DisposeDrawingTools();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}