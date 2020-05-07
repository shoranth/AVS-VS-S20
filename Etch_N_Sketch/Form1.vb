'Anthony Shore
'RCET 0265
'Spring 2020
'Etch N Sketch

Public Class Etch_N_Sketch

    Dim penColor As Color
    Dim myPen As New Pen(penColor)

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawAreaLabel.MouseMove

        'create graphics object
        Dim graph As Graphics
        graph = DrawAreaLabel.CreateGraphics

        Static penColor As Color

        If penColor.IsEmpty = True Then
            penColor = Color.Black
        End If

        Dim myPen As New Pen(penColor)

        'contructor for pen object
        Static oldX As Integer
        Static oldY As Integer

        If e.Button.ToString = "Left" Then
            'draw the line
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            DrawAreaLabel.CreateGraphics.Clear(Color.FloralWhite)
        ElseIf e.Button.ToString = "Middle" Then

        End If

        penColor = CursorColorPicker.Color
        myPen.Color = CursorColorPicker.Color
        DrawAreaLabel.BackColor = BackgroundColorPicker.Color

        'store position
        oldX = e.X
        oldY = e.Y

        'free up resources
        myPen.Dispose()
        graph.Dispose()
    End Sub

    'clears everything in the label
    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click

        DrawAreaLabel.CreateGraphics.Clear(Color.FloralWhite)

    End Sub

    'user selects color
    Private Sub CursorColorButton_Click(sender As Object, e As EventArgs) Handles CursorColorButton.Click
        CursorColorPicker.ShowDialog()
        penColor = CursorColorPicker.Color
        myPen.Color = CursorColorPicker.Color
    End Sub

    'user selects background color. Resets drawing, needs to keep the previos mouse drawings
    Private Sub BackgroundColorButton_Click(sender As Object, e As EventArgs) Handles BackgroundColorButton.Click

        BackgroundColorPicker.ShowDialog()

    End Sub

    'sets defaults when program loads
    Private Sub Etch_N_Sketch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawAreaLabel.CreateGraphics.Clear(Color.FloralWhite)
        BackgroundColorPicker.Color = Color.FloralWhite
        DrawAreaLabel.BackColor = BackgroundColorPicker.Color
    End Sub

    'exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
