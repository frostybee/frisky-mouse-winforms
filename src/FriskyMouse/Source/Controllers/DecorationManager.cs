#region License Information (MIT)
/* 
   FriskyMouse - A utility application for Windows OS that lets you highlight your mouse cursor 
   and decorate your mouse clicks. 
   Copyright (c) 2021-present FrostyBee
   
   This program is free software; you can redistribute it and/or
   modify it under the terms of the MIT license
   See license.txt or https://mit-license.org/
*/
#endregion

using FriskyMouse.Settings;
using FriskyMouse.UI;

namespace FriskyMouse.Core;

//TODO: Dispose everything here.
internal class DecorationManager : IDisposable
{
    private static readonly Lazy<DecorationManager> _instance =
        new Lazy<DecorationManager>(() => new DecorationManager());        
    private readonly SettingsWrapper _settings;        
    private readonly HighlighterController _highlighter;
    private readonly ClickEffectController _leftClickDecorator;
    private readonly ClickEffectController _rightClickDecorator;
    private readonly MouseHookController _mouseHookController;
    private readonly object _syncLock = new object();
    private bool _disposed = false;

    private DecorationManager()
    {
        _settings = SettingsManager.Settings;
        _leftClickDecorator = new ClickEffectController(_settings.LeftClickOptions);
        _rightClickDecorator = new ClickEffectController(_settings.RightClickOptions);
        _highlighter = new HighlighterController(_settings.HighlighterOptions);
        _mouseHookController = new MouseHookController(_highlighter, _leftClickDecorator, _rightClickDecorator);
        //_rightClickDecorator.AnimationCompleted += _rightClickDecorator_AnimationCompleted;
    }

    private void _rightClickDecorator_AnimationCompleted()
    {            
        //_highlighter?.BringToFront(FMAppHelpers.GetCursorPosition());
    }

    #region Methods

    internal void EnableHighlighter()
    {            
        _highlighter.SetHighlighterBitmap(_settings.HighlighterOptions);        
    }         
    internal void DisableHighlighter()
    {
        // HideSpotlight the layered window.
        _highlighter.HideSpotlight();
        if (_settings.HighlighterOptions.Enabled)
        {
            
        }            
    }
    public void EnableHook()
    {
        lock (_syncLock)
        {
            _mouseHookController?.Install();
        }
    }
    public void DisableHook()
    {
        lock (_syncLock)
        {
            //TODO: dispose bitmaps
            _mouseHookController?.Uninstall();
            // HideSpotlight the layered window.
            _highlighter?.HideSpotlight();
        }
    }

    internal void ApplyHighlighterSettings()
    {
        // Save the newly edited settings.
        //SettingsManager.SaveSettings();
        if (_settings.HighlighterOptions.Enabled)
        {                
            EnableHighlighter();
        }
    }

    internal void BootstrapApp()
    {
        // TODO: add check ==> Is click decorator enabled as well?
        EnableHook();
        if (_mouseHookController.Started)
        {
            if (_settings.HighlighterOptions.Enabled)
            {
                // Set the initial coordinates of the spotlight upon starting the application.
                _highlighter.SetInitialPosition();
                EnableHighlighter();
            }
        }
        else 
        {
            // TODO: Failed to install the mouse hook... Raise an error.
        }                    
    }        
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {                    
                _highlighter?.Dispose();                    
                _leftClickDecorator?.Dispose();
                _rightClickDecorator?.Dispose();    
            }
            _disposed = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }        

    #endregion

    #region Properties
    /// <summary>
    /// Gets the single instance of the decoration engine.
    /// </summary>
    public static DecorationManager Instance => _instance.Value;        
    public HighlighterController MouseHighlighter => _highlighter;
    public ClickEffectController ClickDecorator => _leftClickDecorator;
    public ClickEffectController RightClickDecorator => _rightClickDecorator;

    public MainForm MainForm { get; internal set; }

    #endregion
}