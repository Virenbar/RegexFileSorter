Public Class WInputBox

	Public ReadOnly Property Input As String
		Get
			Return TB_Input.Text
		End Get
	End Property

	Private Sub B_Save_Click(sender As Object, e As RoutedEventArgs) Handles B_Save.Click
		If Input.Length = 0 Then Exit Sub
		DialogResult = True
		Close()
	End Sub

	Private Sub B_Cancel_Click(sender As Object, e As RoutedEventArgs) Handles B_Cancel.Click
		DialogResult = False
		Close()
	End Sub

End Class