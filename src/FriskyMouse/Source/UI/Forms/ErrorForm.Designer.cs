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

namespace FriskyMouse.UI;

partial class ErrorForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
        txtException = new TextBox();
        btnSendBugReport = new Button();
        btnClose = new Button();
        flpMenu = new FlowLayoutPanel();
        btnContinue = new Button();
        btnOK = new Button();
        lblErrorMessage = new Label();
        flpMenu.SuspendLayout();
        SuspendLayout();
        // 
        // txtException
        // 
        resources.ApplyResources(txtException, "txtException");
        txtException.Name = "txtException";
        txtException.ReadOnly = true;
        // 
        // btnSendBugReport
        // 
        btnSendBugReport.BackColor = Color.Transparent;
        resources.ApplyResources(btnSendBugReport, "btnSendBugReport");
        btnSendBugReport.Name = "btnSendBugReport";
        btnSendBugReport.UseVisualStyleBackColor = false;
        btnSendBugReport.Click += btnSendBugReport_Click;
        // 
        // btnClose
        // 
        resources.ApplyResources(btnClose, "btnClose");
        btnClose.BackColor = Color.Transparent;
        btnClose.Name = "btnClose";
        btnClose.UseVisualStyleBackColor = false;
        btnClose.Click += btnClose_Click;
        // 
        // flpMenu
        // 
        resources.ApplyResources(flpMenu, "flpMenu");
        flpMenu.Controls.Add(btnSendBugReport);
        flpMenu.Controls.Add(btnContinue);
        flpMenu.Controls.Add(btnClose);
        flpMenu.Controls.Add(btnOK);
        flpMenu.Name = "flpMenu";
        // 
        // btnContinue
        // 
        btnContinue.BackColor = Color.Transparent;
        resources.ApplyResources(btnContinue, "btnContinue");
        btnContinue.Name = "btnContinue";
        btnContinue.UseVisualStyleBackColor = false;
        btnContinue.Click += btnContinue_Click;
        // 
        // btnOK
        // 
        resources.ApplyResources(btnOK, "btnOK");
        btnOK.BackColor = Color.Transparent;
        btnOK.Name = "btnOK";
        btnOK.UseVisualStyleBackColor = false;
        btnOK.Click += btnOK_Click;
        // 
        // lblErrorMessage
        // 
        resources.ApplyResources(lblErrorMessage, "lblErrorMessage");
        lblErrorMessage.Name = "lblErrorMessage";
        // 
        // ErrorForm
        // 
        AcceptButton = btnContinue;
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = SystemColors.Window;
        Controls.Add(lblErrorMessage);
        Controls.Add(flpMenu);
        Controls.Add(txtException);
        Name = "ErrorForm";
        TopMost = true;
        Shown += ErrorForm_Shown;
        flpMenu.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion Windows Form Designer generated code

    private TextBox txtException;
    private Button btnSendBugReport;
    private Button btnClose;
    private FlowLayoutPanel flpMenu;
    private Button btnContinue;
    private Label lblErrorMessage;
    private Button btnOK;
}
