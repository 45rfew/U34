'random string generator v0.1.0 *beta* 
'author - frankie lin 
'date of creation - 12/8/2022
'changelog: 
'- nothing yet 
'
'-full screen app for best experience 
Public Class Form1
    Dim interval As Integer = 3, tick = interval, init = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'System.Diagnostics.Process.Start("shutdown", "-r -t 00") 
        lblTimer.Text = tick
        timer.Interval = 1000 ' start timer and set interval to 1 second when form loads 
        If init = 0 Then ' executes once then changes init value to 1 
            lblCharacters.Text = (randstr(CInt(txtStrLen.Text)))
            init = 1
        End If ' display list of all possible random character 
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        If tick <= 0 Then
            tick = interval + 1
            lblRandText.Text &= vbCrLf & randstr(CInt(txtStrLen.Text))
        End If ' when timer hits 0 display string 
        tick -= 1
        lblTimer.Text = tick
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        timer.Start() 'start timer when the button is clicked 
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStrLen.TextChanged
        If txtStrLen.Text = "" Then txtStrLen.Text = 0 ' if textbox value is blank adds a 0 
        If IsNumeric(txtStrLen.Text) = 0 Then txtStrLen.Text = 0 ' if textbox value is not an integer 
        If txtStrLen.Text.Contains("-") Then txtStrLen.Text *= -1 ' if value is negative makes positive
        txtStrLen.Text = Math.Floor(CInt(txtStrLen.Text)) ' removes any decimal points 
    End Sub
    Public Function randstr(length As Integer) As String 'function 
        Dim random = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"},
            str = "", initStr = "current random characters: "
        If length > random.Length - 1 Then length = random.Length - 1 ' 
        If init Then
            Try
                For i = 0 To length - 1
                    Dim rand = Math.Floor(VBMath.Rnd() * (random.Length - 1))
                    lstOutput.Items.Add(random(i))
                    str &= random(rand)
                    Console.WriteLine(i)
                Next i
                Return str
            Catch ex As Exception
                Console.WriteLine(ex)
                Return "an error occured"
            End Try
        Else
            For Each i In random
                initStr &= i & ", "
            Next
            Return initStr
        End If
    End Function
End Class
