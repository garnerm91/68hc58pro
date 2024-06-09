Imports System.IO.Ports

Public Class Form1

    Private WithEvents serialPort As New SerialPort()
    Private frameBuffer As New List(Of String) ' Buffer to store frame bytes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure the serial port
        serialPort.BaudRate = 115200
        serialPort.Parity = Parity.None
        serialPort.StopBits = StopBits.One
        serialPort.DataBits = 8
        serialPort.Handshake = Handshake.None
        serialPort.NewLine = vbLf ' Use Line Feed as the newline character
        serialPort.DtrEnable = True ' Enable the DTR pin

        ' Disable the Read button initially
        btnRead.Enabled = False
        disconnectBTN.Enabled = False
        btnstandby.Enabled = False
        ' Populate COM ports in the combo box
        RefreshComPorts()
    End Sub

    Private Sub RefreshComPorts()
        cmbPorts.Items.Clear()
        For Each port As String In SerialPort.GetPortNames()
            cmbPorts.Items.Add(port)
        Next
        If cmbPorts.Items.Count > 0 Then
            cmbPorts.SelectedIndex = 0
        End If
    End Sub

    Private Sub cmbPorts_Click(sender As Object, e As EventArgs) Handles cmbPorts.Click
        ' Refresh COM ports each time the combo box is clicked
        RefreshComPorts()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Open the serial port
        If Not serialPort.IsOpen Then
            Try
                If cmbPorts.SelectedItem IsNot Nothing Then
                    serialPort.PortName = cmbPorts.SelectedItem.ToString()
                    serialPort.Open()
                    txtOutput.AppendText("Connected to " & serialPort.PortName & Environment.NewLine)

                    ' Send the IDN command
                    serialPort.WriteLine("idn")
                    disconnectBTN.Enabled = True
                    btnConnect.Enabled = False
                    cmbPorts.Enabled = False
                Else
                    txtOutput.AppendText("Please select a COM port" & Environment.NewLine)
                End If
            Catch ex As Exception
                txtOutput.AppendText("Error: " & ex.Message & Environment.NewLine)
            End Try
        End If
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' Send the RX command
        If serialPort.IsOpen Then
            serialPort.WriteLine("rx")
            txtOutput.AppendText("Device set to RX mode" & Environment.NewLine)
        End If
    End Sub

    Private Sub serialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles serialPort.DataReceived
        ' Handle data received from the serial port
        Dim data As String = serialPort.ReadLine()

        ' Use Invoke to update the UI from the serial port thread
        Me.Invoke(Sub()
                      ProcessReceivedData(data)
                  End Sub)
    End Sub

    Private Sub ProcessReceivedData(data As String)
        ' Check if the data starts with "RX:"
        If data.StartsWith("RX:") Then
            ' Remove "RX:" and split the received data into status byte and data byte
            Dim parts As String() = data.Substring(3).Trim().Split(" "c)
            If parts.Length >= 2 Then
                Dim statusByte As String = parts(0)
                Dim dataByte As String = parts(1)

                ' Add the data byte to the frame buffer
                frameBuffer.Add(dataByte)

                ' Check if the status byte indicates the end of the frame
                If statusByte = "D0" OrElse statusByte = "F0" Then
                    ' Join the frame buffer into a single string
                    Dim frame As String = String.Join(" ", frameBuffer)
                    txtOutput.AppendText("Complete Frame: " & frame & Environment.NewLine)

                    ' Clear the frame buffer for the next frame
                    frameBuffer.Clear()
                End If
            End If
        Else
            ' Handle other responses, e.g., IDN response
            If data.Contains("68hc58-PRO") Then
                txtOutput.AppendText("Device identified successfully." & Environment.NewLine)
                btnRead.Enabled = True
                btnstandby.Enabled = True
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close the serial port when the form is closing
        If serialPort.IsOpen Then
            serialPort.WriteLine("standby")
            serialPort.Close()
        End If
    End Sub

    Private Sub disconnectBTN_Click(sender As Object, e As EventArgs) Handles disconnectBTN.Click
        If serialPort.IsOpen Then
            serialPort.WriteLine("standby")
            serialPort.Close()
            txtOutput.AppendText("Closing Serial Port" & Environment.NewLine)
        End If
        disconnectBTN.Enabled = False
        btnConnect.Enabled = True
        btnstandby.Enabled = False
        btnRead.Enabled = False
        cmbPorts.Enabled = True
    End Sub

    Private Sub btnstandby_Click(sender As Object, e As EventArgs) Handles btnstandby.Click
        If serialPort.IsOpen Then
            serialPort.WriteLine("standby")
            txtOutput.AppendText("Standby Command Sent" & Environment.NewLine)
        End If
    End Sub
End Class