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
        btnConnect = New Button()
        btnRead = New Button()
        txtOutput = New TextBox()
        disconnectBTN = New Button()
        cmbPorts = New ComboBox()
        btnstandby = New Button()
        SuspendLayout()
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(31, 12)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(90, 23)
        btnConnect.TabIndex = 0
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(31, 357)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(90, 23)
        btnRead.TabIndex = 1
        btnRead.Text = "RX Mode"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(127, 13)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.ScrollBars = ScrollBars.Both
        txtOutput.Size = New Size(661, 367)
        txtOutput.TabIndex = 2
        ' 
        ' disconnectBTN
        ' 
        disconnectBTN.Location = New Point(31, 41)
        disconnectBTN.Name = "disconnectBTN"
        disconnectBTN.Size = New Size(90, 23)
        disconnectBTN.TabIndex = 3
        disconnectBTN.Text = "Disconnect"
        disconnectBTN.UseVisualStyleBackColor = True
        ' 
        ' cmbPorts
        ' 
        cmbPorts.FormattingEnabled = True
        cmbPorts.Location = New Point(12, 70)
        cmbPorts.Name = "cmbPorts"
        cmbPorts.Size = New Size(109, 23)
        cmbPorts.TabIndex = 4
        ' 
        ' btnstandby
        ' 
        btnstandby.Location = New Point(31, 328)
        btnstandby.Name = "btnstandby"
        btnstandby.Size = New Size(90, 23)
        btnstandby.TabIndex = 5
        btnstandby.Text = "Standby"
        btnstandby.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnstandby)
        Controls.Add(cmbPorts)
        Controls.Add(disconnectBTN)
        Controls.Add(txtOutput)
        Controls.Add(btnRead)
        Controls.Add(btnConnect)
        Name = "Form1"
        Text = "J1850VPW"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConnect As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents disconnectBTN As Button
    Friend WithEvents cmbPorts As ComboBox
    Friend WithEvents btnstandby As Button

End Class
