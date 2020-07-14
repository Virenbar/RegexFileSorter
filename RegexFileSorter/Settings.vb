Public Class Settings
	Public Property SFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
	Public Property DFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
	Public Property Regex As String = ""
	Public Property InPlace As Boolean = False
	Public Property CreateNew As Boolean = False
End Class
