Public Class SortedFolder

	Public Sub New()
		Name = "No Name"
		Path = "None"
		Status = "None"
	End Sub

	Public Sub New(name As String)
		Me.Name = name
		Me.IsValid = False
	End Sub

	Public ReadOnly Property Files As New List(Of SortedFile)
	Public Property IsValid As Boolean
	Public Property Name As String
	Public Property Path As String
	Public Property Status As String

	Public Structure SortedFile

		Public Sub New(fileName As String, inPath As String, outPath As String)
			Me.FileName = fileName
			Me.InPath = inPath
			Me.OutPath = outPath
		End Sub

		Public Property FileName As String
		Public Property InPath As String
		Public Property OutPath As String
	End Structure

End Class