'Anthony Shore
'RCET 0265
'Spring 2020
'Etch N Sketch

Public Class Etch_N_Sketch


    Private Sub Etch_N_Sketch_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = "x: " & e.X & "y: " & e.Y & "Mouse Button: " & e.Button.ToString

        'create graphics object
        Dim graph As Graphics
        graph = Me.CreateGraphics

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
            graph.Clear(Color.Gray)
        ElseIf e.Button.ToString = "Middle" Then
            ColorPicker.ShowDialog()
            penColor = ColorPicker.Color
            myPen.Color = ColorPicker.Color
        End If

        'store position
        oldX = e.X
        oldY = e.Y

        'free up resources
        myPen.Dispose()
        graph.Dispose()
    End Sub

End Class
