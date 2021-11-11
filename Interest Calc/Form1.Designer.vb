<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.ItemHeight = 16
        Me.ListBox.Location = New System.Drawing.Point(155, 65)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(449, 212)
        Me.ListBox.TabIndex = 0
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(290, 319)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(154, 37)
        Me.CalculateButton.TabIndex = 1
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ListBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox As ListBox
    Friend WithEvents CalculateButton As Button
End Class
