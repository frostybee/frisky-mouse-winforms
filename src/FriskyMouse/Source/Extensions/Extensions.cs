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

using FriskyMouse.NativeApi;
using MaterialSkin.Controls;
using System.ComponentModel;
using System.Globalization;

namespace FriskyMouse.Extensions;

public static class Extensions
{
    public static void ApplyDefaultPropertyValues(this object self)
    {
        foreach (PropertyDescriptor prop in TypeDescriptor.GetProperties(self))
        {
            if (prop.Attributes[typeof(DefaultValueAttribute)] is DefaultValueAttribute attr)
            {
                prop.SetValue(self, attr.Value);
            }
        }
    }
    public static Version Normalize(this Version version)
    {
        return new Version(Math.Max(version.Major, 0), Math.Max(version.Minor, 0), Math.Max(version.Build, 0), Math.Max(version.Revision, 0));
    }
    public static int WeekOfYear(this DateTime dateTime)
    {
        return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
    }

    public static void UpdateSwitchText(this MaterialSwitch materialSwitch)
    {
        materialSwitch.Text = (materialSwitch.Checked) ? "On" : "Off";
    }

    public static void DisableAutoScaleMode(this UserControl control, int width, int height)
    {
        // Make the GUI ignore the DPI setting
        control.Font = new Font(control.Font.Name, 8.25f * 96f / control.CreateGraphics().DpiX,control.Font.Style,control.Font.Unit, control.Font.GdiCharSet, control.Font.GdiVerticalFont);
        //control.AutoScaleDimensions = new SizeF(96F, 96F);
        control.AutoScaleMode = AutoScaleMode.None;
        control.Size = new System.Drawing.Size(width, height);
    }
    public static void ForceActivate(this Form form)
    {
        if (!form.IsDisposed)
        {
            if (!form.Visible)
            {
                form.Show();
            }

            if (form.WindowState == FormWindowState.Minimized)
            {
                NativeMethods.ShowWindow(form.Handle, (int)WindowShowStyle.Restore);
            }

            form.Activate();
            form.BringToFront();
        }
    }

}