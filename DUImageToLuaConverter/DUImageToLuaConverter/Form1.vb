Public Class Form1
    Dim ImageArray(100, 100, 2) As Byte
    Dim nativeWidth As Integer = 1024
    Dim nativeHeight As Integer = 576
    Dim resolutionScale As Integer = 8
    Dim orientationMod As Integer = 0
    Dim Rchan As Boolean = True
    Dim Gchan As Boolean = True
    Dim Bchan As Boolean = True

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ConvertImage(PictureBox1.Image)
    End Sub

    Private Sub ConvertImage(ByRef bm_combined As Bitmap)
        ReDim ImageArray((nativeWidth / resolutionScale) - 1, (nativeHeight / resolutionScale) - 1, 2)
        Dim bounds As Rectangle = New Rectangle(0, 0, bm_combined.Width, bm_combined.Height)
        If bounds.Width > (nativeWidth / resolutionScale) - 1 Or bounds.Height > (nativeHeight / resolutionScale) - 1 Then
            bm_combined = ResizeImage(bm_combined)
        End If
        Dim output As String = ""
        For Y = 0 To bm_combined.Height - 1
            For X = 0 To bm_combined.Width - 1
                ImageArray(X, Y, 0) = bm_combined.GetPixel(X, Y).R / 2
                ImageArray(X, Y, 1) = bm_combined.GetPixel(X, Y).G / 2
                ImageArray(X, Y, 2) = bm_combined.GetPixel(X, Y).B / 2
            Next X
            Dim progress As Integer = ((Y / (bm_combined.Height - 1)) * 100)
            ProgressBar1.Value = Progress
        Next Y
        For Ya = 0 To (nativeHeight / resolutionScale) - 1
            For Xa = 0 To (nativeWidth / resolutionScale) - 1
                For Za = 0 To 2
                    ImageArray(Xa, Ya, Za) = (ImageArray(Xa, Ya, Za) * 0.356) + 33
                    If ImageArray(Xa, Ya, Za) = 34 Then
                        ImageArray(Xa, Ya, Za) = 33
                    End If
                    If ImageArray(Xa, Ya, Za) = 92 Then
                        ImageArray(Xa, Ya, Za) = 91
                    End If
                    If ImageArray(Xa, Ya, Za) > 126 Then
                        ImageArray(Xa, Ya, Za) = 126
                    End If
                    'If ImageArray(Xa, Ya, Za) > 193 Then
                    'ImageArray(Xa, Ya, Za) = ImageArray(Xa, Ya, Za) + 3
                    'End If
                    'If ImageArray(Xa, Ya, Za) > 197 Then
                    'ImageArray(Xa, Ya, Za) = 197
                    'End If
                Next Za
                output = output & System.Text.Encoding.ASCII.GetString({ImageArray(Xa, Ya, 0), ImageArray(Xa, Ya, 1), ImageArray(Xa, Ya, 2)})
            Next Xa
        Next Ya
        TextBox2.Text = output
    End Sub

    Public Sub NewTextMsg(ByVal input As String)
        TextBox2.Text = TextBox2.Text & input
        TextBox2.ScrollToCaret()
        Application.DoEvents()
    End Sub

    Public Function ResizeImage(ByVal InputImage As Image) As Image
        Dim tempimg = InputImage
        If orientationMod = 1 Then
            tempimg.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        If orientationMod = 2 Then
            tempimg.RotateFlip(RotateFlipType.Rotate180FlipNone)
        End If
        If orientationMod = 3 Then
            tempimg.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End If
        Dim tempbmp As Bitmap = New Bitmap(tempimg, New Size((nativeWidth / resolutionScale), (nativeHeight / resolutionScale)))
        Return tempbmp
    End Function


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Using fs As New System.IO.FileStream(OpenFileDialog1.FileName, IO.FileMode.Open)
                    PictureBox1.Image = New Bitmap(Image.FromStream(fs))
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while loading the file:" & Environment.NewLine & OpenFileDialog1.FileName & Environment.NewLine & Environment.NewLine & "Exception: " & ex.ToString & Environment.NewLine & ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        resolutionScale = NumericUpDown1.Value
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        orientationMod = ComboBox1.SelectedIndex
    End Sub
End Class
