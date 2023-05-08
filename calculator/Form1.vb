Public Class Form1
    Dim num1 As Double
    Dim num2 As Double
    Dim op As String

    Private Sub btnNum_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click, btn0.Click
        Dim btn As Button = CType(sender, Button)
        txtDisplay.Text = txtDisplay.Text & btn.Text
    End Sub

    Private Sub btnOp_Click(sender As Object, e As EventArgs) Handles btnPlus.Click, btnMinus.Click, btnMultiply.Click, btnDivide.Click
        Dim btn As Button = CType(sender, Button)
        op = btn.Text
        num1 = Val(txtDisplay.Text)
        txtDisplay.Clear()
    End Sub


    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        num2 = Val(txtDisplay.Text)
        Dim result As Double
        Select Case op
            Case "+"
                result = num1 + num2
            Case "-"
                result = num1 - num2
            Case "*"
                result = num1 * num2
            Case "/"
                If num2 = 0 Then
                    MsgBox("Деление на ноль невозможно!")
                Else
                    result = num1 / num2
                End If
        End Select
        txtDisplay.Text = num1 & " " & op & " " & num2 & " = " & result
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Clear()
    End Sub


End Class
