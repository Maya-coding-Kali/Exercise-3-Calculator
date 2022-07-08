Public Class Form1
    Dim temp1 As Double
    Dim sign As String = ""
    Dim Memory As Double = 0
    Dim WhatWasPressedBefore As String = "digit"
    Dim firstTime As Integer = 0
    Private Sub Equals()
        If TextBox1.Text <> "0" And sign = "+" Then
            Dim sum As Double = temp1 + Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = Math.Round(sum, 2)
        End If
        If TextBox1.Text <> "0" And sign = "-" Then
            Dim sum As Double = temp1 - Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = Math.Round(sum, 2)
        End If
        If TextBox1.Text <> "0" And sign = "*" Then
            Dim sum As Double = temp1 * Convert.ToDouble(TextBox1.Text)
            TextBox1.Text = Math.Round(sum, 2)
        End If
        If TextBox1.Text <> "0" And sign = "/" Then
            If temp1 = 0 Or TextBox1.Text = "0" Then
                TextBox1.Text = "Errrrrr"
            Else
                Dim sum As Double = temp1 / Convert.ToDouble(TextBox1.Text)
                TextBox1.Text = Math.Round(sum, 2)
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "1"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        End If
        WhatWasPressedBefore = "digit"
        'Do the same for buttons 0-9
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "2"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "3"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "4"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "5"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "6"
        ElseIf WhatWasPressedBefore = "digit" And TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "7"
        ElseIf WhatWasPressedBefore = "digit" And TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "8"
        ElseIf WhatWasPressedBefore = "digit" And TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If TextBox1.Text = "0" Or WhatWasPressedBefore = "operator" Then
            TextBox1.Text = "9"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        ElseIf TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
        WhatWasPressedBefore = "digit"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = "0"
        temp1 = 0
        WhatWasPressedBefore = "digit"
        firstTime = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Add.Click
        If firstTime >= 1 Then
            Equals()
        End If
        temp1 = TextBox1.Text
        sign = "+"
        WhatWasPressedBefore = "operator"
        firstTime += 1
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Subtract.Click
        If firstTime >= 1 Then
            Equals()
        End If
        temp1 = TextBox1.Text
        sign = "-"
        WhatWasPressedBefore = "operator"
        firstTime += 1
    End Sub

    Private Sub Multiplication_Click(sender As Object, e As EventArgs) Handles Multiplication.Click
        If firstTime >= 1 Then
            Equals()
        End If
        temp1 = TextBox1.Text
        sign = "*"
        WhatWasPressedBefore = "operator"
        firstTime += 1

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If firstTime >= 1 Then
            Equals()
        End If
        temp1 = TextBox1.Text
        sign = "/"
        WhatWasPressedBefore = "operator"
        firstTime += 1

    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Equal.Click
        Equals()
        firstTime = 0
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text += "."
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If Memory = 0 Then
            TextBox2.Text = TextBox1.Text
            Memory = TextBox1.Text
        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = Memory
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Text = "Mem"
    End Sub
End Class
