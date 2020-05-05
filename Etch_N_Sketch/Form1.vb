'Anthony Shore
'RCET 0265
'Spring 2020
'Etch N Sketch

Public Class Etch_N_Sketch


    'Private Sub Etch_N_Sketch_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
    '    Me.Text = "x: " & e.X & "y: " & e.Y & "Mouse Button: " & e.Button.ToString

    '    'create graphics object
    '    Dim graph As Graphics
    '    graph = Label1.CreateGraphics

    '    Static penColor As Color

    '    If penColor.IsEmpty = True Then
    '        penColor = Color.Black
    '    End If

    '    Dim myPen As New Pen(penColor)

    '    'contructor for pen object
    '    Static oldX As Integer
    '    Static oldY As Integer




    '    If e.Button.ToString = "Left" Then
    '        'draw the line
    '        graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
    '    ElseIf e.Button.ToString = "Right" Then
    '        graph.Clear(Color.Gray)
    '    ElseIf e.Button.ToString = "Middle" Then
    '        ColorPicker.ShowDialog()
    '        penColor = ColorPicker.Color
    '        myPen.Color = ColorPicker.Color
    '    End If

    '    'store position
    '    oldX = e.X
    '    oldY = e.Y

    '    'free up resources
    '    myPen.Dispose()
    '    graph.Dispose()
    'End Sub


    Dim penColor As Color
    Dim myPen As New Pen(penColor)

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawAreaLabel.MouseMove

        Me.Text = "x: " & e.X & "y: " & e.Y & "Mouse Button: " & e.Button.ToString

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

    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click

        DrawAreaLabel.CreateGraphics.Clear(Color.FloralWhite)

    End Sub

    Private Sub CursorColorButton_Click(sender As Object, e As EventArgs) Handles CursorColorButton.Click
        CursorColorPicker.ShowDialog()
        penColor = CursorColorPicker.Color
        myPen.Color = CursorColorPicker.Color
    End Sub

    Private Sub BackgroundColorButton_Click(sender As Object, e As EventArgs) Handles BackgroundColorButton.Click

        BackgroundColorPicker.ShowDialog()

    End Sub

    Private Sub Etch_N_Sketch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DrawAreaLabel.CreateGraphics.Clear(Color.FloralWhite)
        BackgroundColorPicker.Color = Color.FloralWhite
        DrawAreaLabel.BackColor = BackgroundColorPicker.Color
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
