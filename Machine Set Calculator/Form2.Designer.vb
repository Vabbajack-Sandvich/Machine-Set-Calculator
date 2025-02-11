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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        lbAbout = New Label()
        SuspendLayout()
        ' 
        ' lbAbout
        ' 
        lbAbout.AutoSize = True
        lbAbout.ForeColor = Color.DarkGray
        lbAbout.Location = New Point(12, 9)
        lbAbout.Name = "lbAbout"
        lbAbout.Size = New Size(1060, 390)
        lbAbout.TabIndex = 0
        lbAbout.Text = resources.GetString("lbAbout.Text")
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(1202, 428)
        Controls.Add(lbAbout)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Machine Set Calculator by Vabbajack Sandvich - About"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbAbout As Label
End Class
