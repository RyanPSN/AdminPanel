<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        RichTextBox1 = New RichTextBox()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Button4 = New Button()
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
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(349, 149)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(317, 35)
        RichTextBox1.TabIndex = 3
        RichTextBox1.Text = ""
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(442, 219)
        Button3.Name = "Button3"
        Button3.Size = New Size(144, 23)
        Button3.TabIndex = 4
        Button3.Text = "Check Answer"
        Button3.TextAlign = ContentAlignment.BottomLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(734, 442)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 21)
        Label1.TabIndex = 5
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(467, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 21)
        Label2.TabIndex = 6
        Label2.Text = "0 + 0"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(442, 272)
        Button4.Name = "Button4"
        Button4.Size = New Size(144, 23)
        Button4.TabIndex = 7
        Button4.Text = "Generate"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(806, 472)
        Controls.Add(Button4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(RichTextBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Options)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form2"
        Text = "Admin Panel Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Options As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
End Class
