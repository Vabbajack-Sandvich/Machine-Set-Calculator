<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtPPM = New TextBox()
        txtNumMachines = New TextBox()
        txtNewIO = New TextBox()
        btCalc = New Button()
        txtConverted = New TextBox()
        lbPPM = New Label()
        lbNumberMachinesCube = New Label()
        lbNewValue = New Label()
        lbConvertedValue = New Label()
        txtCalcCubeBase = New TextBox()
        lbCalcCubeBase = New Label()
        btDefault = New Button()
        lbDefault = New Label()
        lbAbout = New Label()
        ckOnTop = New CheckBox()
        btAbout = New Button()
        SuspendLayout()
        ' 
        ' txtPPM
        ' 
        txtPPM.BackColor = Color.Black
        txtPPM.ForeColor = Color.DarkGray
        txtPPM.Location = New Point(12, 209)
        txtPPM.Name = "txtPPM"
        txtPPM.Size = New Size(131, 35)
        txtPPM.TabIndex = 0
        ' 
        ' txtNumMachines
        ' 
        txtNumMachines.BackColor = Color.Black
        txtNumMachines.ForeColor = Color.DarkGray
        txtNumMachines.Location = New Point(12, 287)
        txtNumMachines.Name = "txtNumMachines"
        txtNumMachines.Size = New Size(131, 35)
        txtNumMachines.TabIndex = 1
        ' 
        ' txtNewIO
        ' 
        txtNewIO.BackColor = Color.Black
        txtNewIO.ForeColor = Color.DarkGray
        txtNewIO.Location = New Point(12, 441)
        txtNewIO.Name = "txtNewIO"
        txtNewIO.Size = New Size(131, 35)
        txtNewIO.TabIndex = 3
        ' 
        ' btCalc
        ' 
        btCalc.ForeColor = SystemColors.ActiveCaptionText
        btCalc.Location = New Point(329, 564)
        btCalc.Name = "btCalc"
        btCalc.Size = New Size(145, 40)
        btCalc.TabIndex = 5
        btCalc.Text = "Calculate"
        btCalc.UseVisualStyleBackColor = True
        ' 
        ' txtConverted
        ' 
        txtConverted.BackColor = Color.Black
        txtConverted.ForeColor = Color.DarkGray
        txtConverted.Location = New Point(12, 518)
        txtConverted.Name = "txtConverted"
        txtConverted.Size = New Size(131, 35)
        txtConverted.TabIndex = 4
        ' 
        ' lbPPM
        ' 
        lbPPM.AutoSize = True
        lbPPM.BackColor = Color.Black
        lbPPM.ForeColor = Color.DarkGray
        lbPPM.Location = New Point(12, 172)
        lbPPM.Name = "lbPPM"
        lbPPM.Size = New Size(425, 30)
        lbPPM.TabIndex = 5
        lbPPM.Text = "Input / Output Parts Per Minute x 1 Machine"
        ' 
        ' lbNumberMachinesCube
        ' 
        lbNumberMachinesCube.AutoSize = True
        lbNumberMachinesCube.BackColor = Color.Black
        lbNumberMachinesCube.ForeColor = Color.DarkGray
        lbNumberMachinesCube.Location = New Point(12, 250)
        lbNumberMachinesCube.Name = "lbNumberMachinesCube"
        lbNumberMachinesCube.Size = New Size(272, 30)
        lbNumberMachinesCube.TabIndex = 6
        lbNumberMachinesCube.Text = "Number Of Machines In Set"
        ' 
        ' lbNewValue
        ' 
        lbNewValue.AutoSize = True
        lbNewValue.BackColor = Color.Black
        lbNewValue.ForeColor = Color.DarkGray
        lbNewValue.Location = New Point(12, 404)
        lbNewValue.Name = "lbNewValue"
        lbNewValue.Size = New Size(252, 30)
        lbNewValue.TabIndex = 7
        lbNewValue.Text = "New Input / Output Value"
        ' 
        ' lbConvertedValue
        ' 
        lbConvertedValue.AutoSize = True
        lbConvertedValue.BackColor = Color.Black
        lbConvertedValue.ForeColor = Color.DarkGray
        lbConvertedValue.Location = New Point(12, 481)
        lbConvertedValue.Name = "lbConvertedValue"
        lbConvertedValue.Size = New Size(453, 30)
        lbConvertedValue.TabIndex = 8
        lbConvertedValue.Text = "Converted Percent Value To Set All Machines To"
        ' 
        ' txtCalcCubeBase
        ' 
        txtCalcCubeBase.BackColor = Color.Black
        txtCalcCubeBase.ForeColor = Color.DarkGray
        txtCalcCubeBase.Location = New Point(12, 365)
        txtCalcCubeBase.Name = "txtCalcCubeBase"
        txtCalcCubeBase.Size = New Size(131, 35)
        txtCalcCubeBase.TabIndex = 2
        ' 
        ' lbCalcCubeBase
        ' 
        lbCalcCubeBase.AutoSize = True
        lbCalcCubeBase.BackColor = Color.Black
        lbCalcCubeBase.ForeColor = Color.DarkGray
        lbCalcCubeBase.Location = New Point(12, 328)
        lbCalcCubeBase.Name = "lbCalcCubeBase"
        lbCalcCubeBase.Size = New Size(194, 30)
        lbCalcCubeBase.TabIndex = 10
        lbCalcCubeBase.Text = "Calculated Set Base"
        ' 
        ' btDefault
        ' 
        btDefault.ForeColor = SystemColors.ActiveCaptionText
        btDefault.Location = New Point(182, 564)
        btDefault.Name = "btDefault"
        btDefault.Size = New Size(141, 40)
        btDefault.TabIndex = 6
        btDefault.TabStop = False
        btDefault.Text = "Default"
        btDefault.UseVisualStyleBackColor = True
        ' 
        ' lbDefault
        ' 
        lbDefault.BackColor = Color.Black
        lbDefault.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbDefault.ForeColor = Color.DarkGray
        lbDefault.Location = New Point(12, 113)
        lbDefault.Name = "lbDefault"
        lbDefault.Size = New Size(489, 59)
        lbDefault.TabIndex = 12
        lbDefault.Text = "Default: 15x Steel Beam Constructor set to 540 input" & vbCrLf & "Hitting enter will calculate and copy result" & vbCrLf
        ' 
        ' lbAbout
        ' 
        lbAbout.BackColor = Color.Black
        lbAbout.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbAbout.ForeColor = Color.DarkGray
        lbAbout.Location = New Point(12, 9)
        lbAbout.Name = "lbAbout"
        lbAbout.Size = New Size(489, 85)
        lbAbout.TabIndex = 13
        lbAbout.Text = "By: Vabbajack Sandvich" & vbCrLf & "youtube channel:" & vbCrLf & "https://www.youtube.com/channel/UChdR92IoNqHnvXJ4hTwuwLg" & vbCrLf & "double click to copy link" & vbCrLf
        lbAbout.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ckOnTop
        ' 
        ckOnTop.AutoSize = True
        ckOnTop.Checked = True
        ckOnTop.CheckState = CheckState.Checked
        ckOnTop.ForeColor = Color.DarkGray
        ckOnTop.Location = New Point(393, 9)
        ckOnTop.Name = "ckOnTop"
        ckOnTop.Size = New Size(102, 34)
        ckOnTop.TabIndex = 7
        ckOnTop.Text = "On Top"
        ckOnTop.UseVisualStyleBackColor = True
        ' 
        ' btAbout
        ' 
        btAbout.ForeColor = SystemColors.ActiveCaptionText
        btAbout.Location = New Point(35, 564)
        btAbout.Name = "btAbout"
        btAbout.Size = New Size(141, 40)
        btAbout.TabIndex = 14
        btAbout.TabStop = False
        btAbout.Text = "About"
        btAbout.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(507, 613)
        Controls.Add(btAbout)
        Controls.Add(ckOnTop)
        Controls.Add(lbAbout)
        Controls.Add(btDefault)
        Controls.Add(lbCalcCubeBase)
        Controls.Add(txtCalcCubeBase)
        Controls.Add(lbConvertedValue)
        Controls.Add(lbNewValue)
        Controls.Add(lbNumberMachinesCube)
        Controls.Add(lbPPM)
        Controls.Add(txtConverted)
        Controls.Add(btCalc)
        Controls.Add(txtNewIO)
        Controls.Add(txtNumMachines)
        Controls.Add(txtPPM)
        Controls.Add(lbDefault)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Machine Set Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPPM As TextBox
    Friend WithEvents txtNumMachines As TextBox
    Friend WithEvents txtNewIO As TextBox
    Friend WithEvents btCalc As Button
    Friend WithEvents txtConverted As TextBox
    Friend WithEvents lbPPM As Label
    Friend WithEvents lbNumberMachinesCube As Label
    Friend WithEvents lbNewValue As Label
    Friend WithEvents lbConvertedValue As Label
    Friend WithEvents txtCalcCubeBase As TextBox
    Friend WithEvents lbCalcCubeBase As Label
    Friend WithEvents btDefault As Button
    Friend WithEvents lbDefault As Label
    Friend WithEvents lbAbout As Label
    Friend WithEvents ckOnTop As CheckBox
    Friend WithEvents btAbout As Button

End Class
