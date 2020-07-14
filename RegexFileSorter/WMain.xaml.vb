Imports System.ComponentModel
Imports System.IO

Class WMain

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		DataContext = New Settings With {
			.SFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			.DFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			.Regex = "",
			.InPlace = True,
			.CreateNew = False}
	End Sub

	Protected Overrides Sub OnClosing(e As CancelEventArgs)
		MySettings.Default.Save()
		MyBase.OnClosing(e)
	End Sub

	Private Sub B_SelectS_Click(sender As Object, e As RoutedEventArgs) Handles B_SelectS.Click
		DataContext = New Settings With {.InPlace = False, .CreateNew = True}
	End Sub

	Private Sub B_SelectD_Click(sender As Object, e As RoutedEventArgs) Handles B_SelectD.Click

	End Sub
End Class
