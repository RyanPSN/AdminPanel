﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Options = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Options
        ' 
        Options.FormattingEnabled = True
        Options.ItemHeight = 15
        Options.Location = New Point(3, 6)
        Options.Name = "Options"
        Options.Size = New Size(237, 454)
        Options.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(51, 399)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 23)
        Button1.TabIndex = 1
        Button1.Text = "Light"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(51, 352)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 23)
        Button2.TabIndex = 2
        Button2.Text = "Dark"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(806, 472)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Options)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form2"
        Text = "Admin Panel Home"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Options As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
