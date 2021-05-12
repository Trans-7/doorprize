Public Class Form2_display
    Dim cursorX, cursorY As Integer
    Private dragging As Boolean

    Private Sub Form2_display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_display_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.DoubleClick
        Me.WindowState = FormWindowState.Normal
        Me.Width = 800
        Me.Height = 600
    End Sub

    Private Sub Form2_display_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        If Me.WindowState = FormWindowState.Maximized Then
            Me.FormBorderStyle = FormBorderStyle.None
        Else
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
        End If
    End Sub

    Private Function getCurrentScreen() As Screen
        Dim screens() As Screen = Screen.AllScreens

        For Each screen As Screen In screens
            If Me.Top >= screen.WorkingArea.Top And Me.Top < (screen.WorkingArea.Top + screen.WorkingArea.Height) And Me.Left >= screen.WorkingArea.Left And Me.Left < (screen.WorkingArea.Left + screen.WorkingArea.Width) Then
                Return screen
            End If
        Next

        Return Nothing
    End Function
    Private Sub Control_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Set the flag
        dragging = True
        ' Note positions of cursor when pressed
        cursorX = e.X
        cursorY = e.Y
    End Sub

    Private Sub Control_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        ' Reset the flag
        dragging = False
    End Sub

    Private Sub Control_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If dragging Then
            Dim ctrl As Control = CType(sender, Control)
            ' Move the control according to mouse movement
            ctrl.Left = (ctrl.Left + e.X) - cursorX
            ctrl.Top = (ctrl.Top + e.Y) - cursorY
            ' Ensure moved control stays on top of anything it is dragged on to
            ctrl.BringToFront()
        End If
    End Sub

End Class