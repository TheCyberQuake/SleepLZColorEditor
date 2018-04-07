Imports System.IO

Public Class Form1
    'Top screen color values
    Public TopBack As String
    Public TopBackGlow As String
    Public TopStripes As String
    Public TopHeader As String
    Public TopText As String
    Public TopFooter As String
    Public TopLine As String

    'Bottom screen color values
    Public ButtonText
    Public ButtonTextMask
    Public ButtonColor
    Public ButtonGlow
    Public BottomBack
    Public BottomBackGlow
    Public BottomStripes
    Public BottomMask
    Public BottomText
    Public BottomFooter
    Public BottomLine

    'sleep_LZ.bin.bin being edited
    Public editfile As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'Set working file
            editfile = OpenFileDialog1.FileName

            'Make backup file
            My.Computer.FileSystem.CopyFile(editfile, editfile & ".bak", True)

            'Read hex colors from file
            '   Top Screen
            TopBack = ReadColor(&H1CD4)
            TopBackGlow = ReadColor(&H1CD8)
            TopStripes = ReadColor(&H1CD0)
            TopHeader = ReadColor(&H1D70)
            TopText = ReadColor(&H1DA4)
            TopFooter = ReadColor(&H1EA8)
            TopLine = ReadColor(&H1E24)
            '   Bottom Screen
            ButtonText = ReadColor(&H14D4)
            ButtonTextMask = ReadColor(&H14A0)
            ButtonColor = ReadColor(&H132C)
            ButtonGlow = ReadColor(&H1330)
            BottomBack = ReadColor(&H1260)
            BottomBackGlow = ReadColor(&H1264)
            BottomStripes = ReadColor(&H125C)
            BottomMask = ReadColor(&H150B)
            BottomText = ReadColor(&H12FC)
            BottomFooter = ReadColor(&H122C)
            BottomLine = ReadColor(&H1554)

            'Change color previews
            '   Top Screen
            clrTopBack.BackColor = StrToClr(TopBack)
            clrTopBackGlow.BackColor = StrToClr(TopBackGlow)
            clrTopStripes.BackColor = StrToClr(TopStripes)
            clrTopHeader.BackColor = StrToClr(TopHeader)
            clrTopText.BackColor = StrToClr(TopText)
            clrTopFooter.BackColor = StrToClr(TopFooter)
            clrTopLine.BackColor = StrToClr(TopLine)
            '   Bottom Screen
            clrButtonText.BackColor = StrToClr(ButtonText)
            clrButtonTextMask.BackColor = StrToClr(ButtonTextMask)
            clrButtonColor.BackColor = StrToClr(ButtonColor)
            clrButtonGlow.BackColor = StrToClr(ButtonGlow)
            clrBottomBack.BackColor = StrToClr(BottomBack)
            clrBottomBackGlow.BackColor = StrToClr(BottomBackGlow)
            clrBottomStripes.BackColor = StrToClr(BottomStripes)
            clrBottomMask.BackColor = StrToClr(BottomMask)
            clrBottomText.BackColor = StrToClr(BottomText)
            clrBottomFooter.BackColor = StrToClr(BottomFooter)
            clrBottomLine.BackColor = StrToClr(BottomLine)
        End If
    End Sub

    Private Sub btnWriteColors_Click(sender As Object, e As EventArgs) Handles btnWriteColors.Click
        If Not editfile = Nothing Then
            'Write colors to file
            '   Top Screen
            WriteColor(&H1CD4, TopBack)
            WriteColor(&H1CD8, TopBackGlow)
            WriteColor(&H1CD0, TopStripes)
            WriteColor(&H1D70, TopHeader)
            WriteColor(&H1DA4, TopText)
            WriteColor(&H1EA8, TopFooter)
            WriteColor(&H1E24, TopLine)
            '   Bottom Screen
            WriteColor(&H14D4, ButtonText)
            WriteColor(&H14A0, ButtonTextMask)
            WriteColor(&H132C, ButtonColor)
            WriteColor(&H13E4, ButtonColor) 'Button color exists in two offsets, need to change both
            WriteColor(&H1330, ButtonGlow)
            WriteColor(&H13E8, ButtonGlow) ' Button Glow exists in two offset, need to change both
            WriteColor(&H1260, BottomBack)
            WriteColor(&H1264, BottomBackGlow)
            WriteColor(&H125C, BottomStripes)
            WriteColor(&H150B, BottomMask)
            WriteColor(&H12FC, BottomText)
            WriteColor(&H122C, BottomFooter)
            WriteColor(&H1554, BottomLine)
        End If
    End Sub



    '----------Color chaniging block----------
    Private Sub btnTopBack_Click(sender As Object, e As EventArgs) Handles btnTopBack.Click
        ColorDialog1.Color = clrTopBack.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopBack.BackColor = c
            TopBack = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopBackGlow_Click(sender As Object, e As EventArgs) Handles btnTopBackGlow.Click
        ColorDialog1.Color = clrTopBackGlow.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopBackGlow.BackColor = c
            TopBackGlow = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopStripes_Click(sender As Object, e As EventArgs) Handles btnTopStripes.Click
        ColorDialog1.Color = clrTopStripes.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopStripes.BackColor = c
            TopStripes = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopHeader_Click(sender As Object, e As EventArgs) Handles btnTopHeader.Click
        ColorDialog1.Color = clrTopHeader.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopHeader.BackColor = c
            TopHeader = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopText_Click(sender As Object, e As EventArgs) Handles btnTopText.Click
        ColorDialog1.Color = clrTopText.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopText.BackColor = c
            TopText = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopFooter_Click(sender As Object, e As EventArgs) Handles btnTopFooter.Click
        ColorDialog1.Color = clrTopFooter.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopFooter.BackColor = c
            TopFooter = ColorToHex(c)
        End If
    End Sub

    Private Sub btnTopLine_Click(sender As Object, e As EventArgs) Handles btnTopLine.Click
        ColorDialog1.Color = clrTopLine.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrTopLine.BackColor = c
            TopLine = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomBack_Click(sender As Object, e As EventArgs) Handles btnBottomBack.Click
        ColorDialog1.Color = clrBottomBack.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomBack.BackColor = c
            BottomBack = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomBackGlow_Click(sender As Object, e As EventArgs) Handles btnBottomBackGlow.Click
        ColorDialog1.Color = clrBottomBackGlow.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomBackGlow.BackColor = c
            BottomBackGlow = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomStripes_Click(sender As Object, e As EventArgs) Handles btnBottomStripes.Click
        ColorDialog1.Color = clrBottomStripes.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomStripes.BackColor = c
            BottomStripes = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomMask_Click(sender As Object, e As EventArgs) Handles btnBottomMask.Click
        ColorDialog1.Color = clrBottomMask.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomMask.BackColor = c
            BottomMask = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomText_Click(sender As Object, e As EventArgs) Handles btnBottomText.Click
        ColorDialog1.Color = clrBottomText.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomText.BackColor = c
            BottomText = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomFooter_Click(sender As Object, e As EventArgs) Handles btnBottomFooter.Click
        ColorDialog1.Color = clrBottomFooter.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomFooter.BackColor = c
            BottomFooter = ColorToHex(c)
        End If
    End Sub

    Private Sub btnBottomLine_Click(sender As Object, e As EventArgs) Handles btnBottomLine.Click
        ColorDialog1.Color = clrBottomLine.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrBottomLine.BackColor = c
            BottomLine = ColorToHex(c)
        End If
    End Sub

    Private Sub btnButtonText_Click(sender As Object, e As EventArgs) Handles btnButtonText.Click
        ColorDialog1.Color = clrButtonText.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrButtonText.BackColor = c
            ButtonText = ColorToHex(c)
        End If
    End Sub

    Private Sub btnButtonTextMask_Click(sender As Object, e As EventArgs) Handles btnButtonTextMask.Click
        ColorDialog1.Color = clrButtonTextMask.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrButtonTextMask.BackColor = c
            ButtonTextMask = ColorToHex(c)
        End If
    End Sub

    Private Sub btnButtonColor_Click(sender As Object, e As EventArgs) Handles btnButtonColor.Click
        ColorDialog1.Color = clrButtonColor.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrButtonColor.BackColor = c
            ButtonColor = ColorToHex(c)
        End If
    End Sub

    Private Sub btnButtonGlow_Click(sender As Object, e As EventArgs) Handles btnButtonGlow.Click
        ColorDialog1.Color = clrButtonGlow.BackColor
        If ColorDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim c As Color = ColorDialog1.Color
            clrButtonGlow.BackColor = c
            ButtonGlow = ColorToHex(c)
        End If
    End Sub
    '----------End color change block----------



    '----------Functions Block----------

    'Converts from hex string to VB color
    Public Function StrToClr(ByVal theColor As String)
        Return ColorTranslator.FromHtml("#" & theColor)
    End Function

    'Converts color to RGB hex value
    Public Function ColorToHex(ByVal c As Color)
        Dim hexcolor As String = Hex(c.ToArgb())
        Return hexcolor.Substring(2, 6)
    End Function

    'Writes RGB hex color to specific offset
    Public Sub WriteColor(ByVal offset As Integer, ByVal replacecolor As String)
        Dim fs As New IO.FileStream(OpenFileDialog1.FileName, FileMode.Open, FileAccess.ReadWrite)
        Dim strHex As String = replacecolor

        fs.Position = offset
        For j As Integer = 0 To strHex.Length - 1 Step 2
            fs.WriteByte(CByte(Conversion.Val("&H" & strHex.Substring(j, 2))))
        Next

        fs.Close()
        fs.Dispose()
    End Sub

    'Read RGB hex color from offset in file
    Public Function ReadColor(ByVal offset As Integer)
        Dim hexout As String
        Dim fs As New IO.FileStream(editfile, FileMode.Open, FileAccess.Read)
        fs.Position = offset
        For j As Integer = 0 To 5 Step 2
            hexout &= Hex(fs.ReadByte()).ToString()
        Next
        fs.Close()
        fs.Dispose()
        Return hexout
    End Function
    '----------End Functions Block----------
End Class
