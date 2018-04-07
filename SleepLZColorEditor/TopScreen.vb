Public Class TopScreen

    Private Sub TopBack_Click(sender As Object, e As EventArgs) Handles btnTopBack.Click
        Form1.ColorDialog1.Color = clrTopBack.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopBack.BackColor = c
            Form1.TopBack = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopBackGlow_Click(sender As Object, e As EventArgs) Handles btnTopBackGlow.Click
        Form1.ColorDialog1.Color = clrTopBackGlow.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopBackGlow.BackColor = c
            Form1.TopBackGlow = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub bntTopStripes_Click(sender As Object, e As EventArgs) Handles bntTopStripes.Click
        Form1.ColorDialog1.Color = clrTopStripes.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopStripes.BackColor = c
            Form1.TopStripes = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopHeader_Click(sender As Object, e As EventArgs) Handles btnTopHeader.Click
        Form1.ColorDialog1.Color = clrTopHeader.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopHeader.BackColor = c
            Form1.TopHeader = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopText_Click(sender As Object, e As EventArgs) Handles btnTopText.Click
        Form1.ColorDialog1.Color = clrTopText.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopText.BackColor = c
            Form1.TopText = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopFooter_Click(sender As Object, e As EventArgs) Handles btnTopFooter.Click
        Form1.ColorDialog1.Color = clrTopFooter.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopFooter.BackColor = c
            Form1.TopFooter = Form1.ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopLine_Click(sender As Object, e As EventArgs) Handles btnTopLine.Click
        Form1.ColorDialog1.Color = clrTopLine.BackColor
        If Form1.ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = Form1.ColorDialog1.Color
            clrTopLine.BackColor = c
            Form1.TopLine = Form1.ColorToHex(c)
        End If
    End Sub
End Class