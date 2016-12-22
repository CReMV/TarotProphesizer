Public Class Intro
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles IntroNextButton.Click
        NameSet.Show()
        Me.Close()
    End Sub
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class