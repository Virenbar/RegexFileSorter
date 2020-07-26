Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Config
	Implements INotifyPropertyChanged

	Private _DFolder As String
	Private _SFolder As String

	Public Sub New()
		SFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
		DFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
		Regex = "(?<S>[\w]+?)_" '^\d+\.(?<S>[\w-]+?)_
		InPlace = False
		CreateNew = False
		SearchFolder = True
	End Sub

	Public Property CreateNew As Boolean

	Public Property DFolder As String
		Get
			Return _DFolder
		End Get
		Set
			_DFolder = Value
			OnPropertyChanged()
		End Set
	End Property

	Public Property InPlace As Boolean

	Public ReadOnly Property OutFolder As String
		Get
			Return If(InPlace, SFolder, DFolder)
		End Get
	End Property

	Public Property Regex As String

	Public Property SearchFolder As Boolean

	Public Property SFolder As String
		Get
			Return _SFolder
		End Get
		Set
			_SFolder = Value
			OnPropertyChanged()
		End Set
	End Property

	Private Sub OnPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	End Sub

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

End Class