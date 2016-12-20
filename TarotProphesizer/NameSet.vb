Public Class NameSet
    Private Sub NameSetButton_Click(sender As Object, e As EventArgs) Handles NameSetButton.Click
        If NameBox.Text = "" Then
            MsgBox("You have to enter a name!")
            Exit Sub
        End If
        Prophecy.UName = NameBox.Text
        CardPicker.Show()
        Me.Close()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class