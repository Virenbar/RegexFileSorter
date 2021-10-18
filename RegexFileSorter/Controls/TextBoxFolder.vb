Imports System.IO
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class TextBoxFolder
	Inherits TextBox
	Public Shadows ReadOnly IsReadonly As Boolean
	Private Shared ReadOnly COFD As New CommonOpenFileDialog() With {.IsFolderPicker = True}

	Public Sub New()
		MyBase.IsReadOnly = True
	End Sub

	Public Sub SelectFolder()
		COFD.InitialDirectory = Text
		If COFD.ShowDialog = CommonFileDialogResult.Ok Then Text = COFD.FileName
	End Sub

	Protected Overrides Sub OnDragEnter(e As DragEventArgs)
		'MyBase.OnDragEnter(e)
		ProcessDrag(e)
	End Sub

	Protected Overrides Sub OnDragLeave(e As DragEventArgs)
		'MyBase.OnDragLeave(e)
	End Sub

	Protected Overrides Sub OnDragOver(e As DragEventArgs)
		'MyBase.OnDragOver(e)
		ProcessDrag(e)
	End Sub

	Protected Overrides Sub OnDrop(e As DragEventArgs)
		'MyBase.OnDrop(e)
		Dim Folder = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())(0)
		If Directory.Exists(Folder) Then Text = Folder
	End Sub

	Private Sub ProcessDrag(e As DragEventArgs)
		Dim Effect = DragDropEffects.None
		If e.Data.GetDataPresent(DataFormats.FileDrop) Then
			Dim Folder = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())(0)
			If Directory.Exists(Folder) Then
				Effect = DragDropEffects.Link
			End If
		End If
		e.Effects = Effect
		e.Handled = True
	End Sub

End Class