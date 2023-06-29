#region License Information (MIT)
// This code is distributed under the MIT license. 
// Copyright (c) 2021-2023 FrostyBee
// See license.txt or https://mit-license.org/
#endregion

namespace FriskyMouse.Drawing.Animation
{
    /// <summary>
    /// Base class for all Easing classes.
    /// </summary>    
    public abstract partial class Easing : IConstructable
    {
        /// <inheritdoc/>
        public abstract double Ease(double progress);        
    }
}
