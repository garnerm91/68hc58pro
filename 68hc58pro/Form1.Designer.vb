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
        btnsend = New Button()
        txtsend = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(21, 11)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(90, 23)
        btnConnect.TabIndex = 0
        btnConnect.Text = "Connect"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' btnRead
        ' 
        btnRead.Location = New Point(21, 356)
        btnRead.Name = "btnRead"
        btnRead.Size = New Size(90, 23)
        btnRead.TabIndex = 1
        btnRead.Text = "RX Mode"
        btnRead.UseVisualStyleBackColor = True
        ' 
        ' txtOutput
        ' 
        txtOutput.Location = New Point(117, 12)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.ScrollBars = ScrollBars.Both
        txtOutput.Size = New Size(661, 367)
        txtOutput.TabIndex = 2
        ' 
        ' disconnectBTN
        ' 
        disconnectBTN.Location = New Point(21, 40)
        disconnectBTN.Name = "disconnectBTN"
        disconnectBTN.Size = New Size(90, 23)
        disconnectBTN.TabIndex = 3
        disconnectBTN.Text = "Disconnect"
        disconnectBTN.UseVisualStyleBackColor = True
        ' 
        ' cmbPorts
        ' 
        cmbPorts.FormattingEnabled = True
        cmbPorts.Location = New Point(2, 84)
        cmbPorts.Name = "cmbPorts"
        cmbPorts.Size = New Size(109, 23)
        cmbPorts.TabIndex = 4
        ' 
        ' btnstandby
        ' 
        btnstandby.Location = New Point(21, 327)
        btnstandby.Name = "btnstandby"
        btnstandby.Size = New Size(90, 23)
        btnstandby.TabIndex = 5
        btnstandby.Text = "Standby"
        btnstandby.UseVisualStyleBackColor = True
        ' 
        ' btnsend
        ' 
        btnsend.Location = New Point(686, 385)
        btnsend.Name = "btnsend"
        btnsend.Size = New Size(92, 23)
        btnsend.TabIndex = 6
        btnsend.Text = "Send"
        btnsend.UseVisualStyleBackColor = True
        ' 
        ' txtsend
        ' 
        txtsend.Location = New Point(117, 385)
        txtsend.Name = "txtsend"
        txtsend.Size = New Size(563, 23)
        txtsend.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(48, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 8
        Label1.Text = "Select Port"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 309)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 15)
        Label2.TabIndex = 9
        Label2.Text = "Mode"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(783, 415)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtsend)
        Controls.Add(btnsend)
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
    Friend WithEvents btnsend As Button
    Friend WithEvents txtsend As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
