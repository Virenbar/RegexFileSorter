Imports System.IO
Imports System.Text.RegularExpressions
Imports RegexFileSorter.Configuration

Public Class Sorter

	Public Shared Function ScanFiles() As ILookup(Of String, String)
		Dim Result As New List(Of (Path As String, Match As String))
		Dim S = Directory.GetFiles(Current.SFolder)
		Dim R = New Regex(Current.Regex)
		For Each File In S
			Dim M = R.Match(Path.GetFileName(File))
			If M.Success Then
				'Result.Add(New MatchedFile With {.Path = File, .Match = M.Groups("S").Value})
				Result.Add((File, M.Groups("S").Value))
			End If
		Next
		Return Result.ToLookup(Function(x) x.Match, Function(x) x.Path)
	End Function

	Public Shared Function PrepareFiles(G As IGrouping(Of String, String)) As SortedFolder
		Dim SF = New SortedFolder(G.Key)
		SF.Path = Path.Combine(Current.OutFolder, SF.Name)
		If Directory.Exists(SF.Path) Then
			SF.IsValid = True
			SF.Status = "Found"
		ElseIf Current.SearchFolder Then
			For Each Folder In Directory.GetDirectories(Current.OutFolder)
				Dim FolderName = Path.GetFileName(Folder)
				If FolderName.StartsWith(SF.Name, StringComparison.CurrentCultureIgnoreCase) Then
					SF.Path = Folder
					SF.IsValid = True
					SF.Status = $"Found {FolderName}"
					Exit For
				End If
			Next
		End If
		If Not SF.IsValid Then
			If Current.CreateNew Then
				SF.IsValid = True
				SF.Status = $"Create folder {SF.Name}"
			Else
				SF.Status = "Not found"
			End If
		End If

		For Each File In G
			Dim FileName = Path.GetFileName(File)
			Dim OutFile = Path.Combine(SF.Path, FileName)
			SF.Files.Add(New SortedFolder.SortedFile(FileName, File, OutFile))
		Next
		Return SF
	End Function

	Public Shared Sub MoveFiles(SFList As IEnumerable(Of SortedFolder))
		For Each SF In SFList
			If Not SF.IsValid Then Continue For
			For Each F In SF.Files
				File.Move(F.InPath, F.OutPath)
			Next
		Next
	End Sub

End Class