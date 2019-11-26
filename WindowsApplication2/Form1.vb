
Imports System
Imports System.Threading
Imports System.IO.Ports
Imports System.ComponentModel
Imports System.Diagnostics



Public Class Form1
    Public watchfolder As New IO.FileSystemWatcher()
    Public link As String
    Public com As String
    Public name As String
    Public machine As String
    Public day, dai, rong As String
    Dim day1, dai1, rong1, send As String
    Public flag As Boolean

    Delegate Sub SetTextCallback(ByVal [text] As String)
    'Dim WithEvents ADRport As SerialPort = New System.IO.Ports.SerialPort("COM1", 9600, Parity.Even, 8, StopBits.One)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim setupReader As String
        Dim tam As Int16
        setupReader = My.Computer.FileSystem.ReadAllText("C:\Setup\setup.txt")

        com = Mid(setupReader, 1, 4)
        link = Mid(setupReader, 7)


        For i = (Len(setupReader) - 1) To 0 Step -1
            If setupReader(i) = "\" Then
                tam = i
                Exit For
            End If
        Next
        name = Mid(setupReader, (tam + 1))
        machine = Mid(name, 2, 2)



        If My.Computer.FileSystem.FileExists(link) Then
            My.Computer.FileSystem.DeleteFile(link)
        End If
        SerialPort1.PortName = com
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        If My.Computer.Network.IsAvailable Then
            Try
                SerialPort1.Open()
                Button2.Enabled = False
                Button3.Enabled = True

                Me.Invoke(Sub()
                              oklb.Visible = False
                              same.Visible = False
                          End Sub)

                watchfolder = New System.IO.FileSystemWatcher()
                watchfolder.Path = Replace(link, name, "")  'xoa ten file lay folder Replace(setup, "\test.ini", "")  "C:\Setup" '"




                AddHandler watchfolder.Created, AddressOf logchange
                watchfolder.EnableRaisingEvents = True

            Catch ex As IO.IOException
                MsgBox("Hãy kiểm tra lại đã đúng cổng COM chưa, nếu chưa vào file C:\Setup\setup.txt để sửa cho đúng, nếu đúng kiểm tra dây từ máy tính đến PLC")
            End Try
        Else
            MsgBox("Không có kết nối mạng, Hãy iểm tra lại kết nối mạng")
        End If
        
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SerialPort1.Close()
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim a As String
        a = SerialPort1.ReadExisting

        If a = "1" Then
            If My.Computer.FileSystem.FileExists(link) Then

                My.Computer.FileSystem.DeleteFile(link)
                Me.Invoke(Sub()
                              oklb.Visible = True
                              same.Visible = False
                          End Sub)
            End If

        End If




    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SerialPort1.Close()
        Button2.Enabled = True
        Button3.Enabled = False
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Button3.Enabled = False
        Button2.Enabled = True
    End Sub
    Private Sub logchange(ByVal source As Object, ByVal e As System.IO.FileSystemEventArgs)
        Dim fileReader As String

        Dim tam1 As String



        Try
            Me.Invoke(Sub()
                          oklb.Visible = False
                          same.Visible = False
                      End Sub)
           
            If My.Computer.FileSystem.FileExists(link) Then
                fileReader = My.Computer.FileSystem.ReadAllText(link)
                fileReader = fileReader.Replace(fileReader(1), "")


                dai = Mid(fileReader, 8, 4)
                rong = Mid(fileReader, 13, 4)
                day = Mid(fileReader, 4, 2)
                If Convert.ToInt16(rong) > Convert.ToInt16(dai) Then
                    tam1 = rong
                    rong = dai
                    dai = tam1
                End If

                SerialPort1.Write("AA" & day & dai & rong)

                If My.Computer.FileSystem.FileExists(link) Then
                    My.Computer.FileSystem.DeleteFile(link)
                End If

                If dai <> dailb.Text Or rong <> ronglb.Text Or day <> daylb.Text Then

                    Me.Invoke(Sub()
                                  ronglb.Text = rong
                                  dailb.Text = dai
                                  daylb.Text = day
                                  oklb.Visible = True
                                  same.Visible = False
                              End Sub)
                Else
                    Me.Invoke(Sub()
                                  same.Visible = True
                                  oklb.Visible = False

                              End Sub)

                End If
            End If
        Catch ex As IO.IOException
            MsgBox("Có lẽ kết nối máy chủ có vấn đề, phiền bạn kiểm tra kết nối với máy chủ")

        End Try
    End Sub

   

    Private Sub same_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles same.Click

    End Sub

    Private Sub ronglb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ronglb.Click

    End Sub




End Class