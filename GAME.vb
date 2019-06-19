Public Class Form1

End Class

Dim contador As Integer

Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    Randomize()
    TextBox1.Text = Int(Rnd() * 10)
    If Val(TextBox1.Text) = Val(TextBox2.Text) Then
        MsgBox("You Win")
        Timer1.Enabled = False
    Else
        contador = contador + 1
        TextBox3.Text = contador
        TextBox2.Text = ""
        TextBox2.Focus()
    End If
End Sub

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Timer1.Enabled = True
End Sub