﻿Imports System.ComponentModel
Imports RegexFileSorter.Configuration
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports System.Collections.ObjectModel

Class WMain
	Private ReadOnly COFD As New CommonOpenFileDialog() With {.IsFolderPicker = True}
	Private SFValid As New ObservableCollection(Of SortedFolder)
	Private SFInvalid As New ObservableCollection(Of SortedFolder)

	'Private SFValidView = New
	Public Sub New()
		' Этот вызов является обязательным для конструктора.
		InitializeComponent()

		' Добавить код инициализации после вызова InitializeComponent().
		DataContext = Current
		SortValid.ItemsSource = SFValid
		SortValid.Items.SortDescriptions.Add(New SortDescription("Name", ListSortDirection.Ascending))
		SortInvalid.ItemsSource = SFInvalid
		SortInvalid.Items.SortDescriptions.Add(New SortDescription("Files.Count", ListSortDirection.Descending))
	End Sub

	Protected Overrides Sub OnClosing(e As CancelEventArgs)
		MySettings.Default.Save()
		MyBase.OnClosing(e)
	End Sub

	Private Sub B_Preview_Click(sender As Object, e As RoutedEventArgs) Handles B_Preview.Click
		If Not Current.Regex.Contains("?<S>") Then MessageBoxWPF.Show("Test") : Exit Sub
		SFValid.Clear()
		SFInvalid.Clear()

		'Dim SFV = New List(Of SortedFolder)
		'Dim SFVI = New List(Of SortedFolder)

		Dim L = Sorter.ScanFiles
		For Each G In L
			Dim SF = Sorter.PrepareFiles(G)
			If SF.IsValid Then
				SFValid.Add(SF)
			Else
				SFInvalid.Add(SF)
			End If
		Next
		B_Sort.IsEnabled = SFValid.Count > 0
		'Dim ll = New List(Of String)
		'll.

		'SFInvalid.OrderByDescending(Function(x) x.Count)
		'SFInvalid = New ObservableCollection(Of SortedFolder)()
	End Sub

	Private Sub B_SelectD_Click(sender As Object, e As RoutedEventArgs) Handles B_SelectD.Click
		COFD.InitialDirectory = Current.DFolder
		If COFD.ShowDialog = CommonFileDialogResult.Ok Then Current.DFolder = COFD.FileName
	End Sub

	Private Sub B_SelectS_Click(sender As Object, e As RoutedEventArgs) Handles B_SelectS.Click
		COFD.InitialDirectory = Current.SFolder
		If COFD.ShowDialog = CommonFileDialogResult.Ok Then Current.SFolder = COFD.FileName
		'DataContext = New Config With {.InPlace = False, .CreateNew = True}
	End Sub

	Private Sub B_Sort_Click(sender As Object, e As RoutedEventArgs) Handles B_Sort.Click
		Try
			Sorter.MoveFiles(SFValid)
			SFValid.Clear()
		Catch ex As Exception
		Finally
			B_Sort.IsEnabled = False
		End Try
	End Sub

End Class