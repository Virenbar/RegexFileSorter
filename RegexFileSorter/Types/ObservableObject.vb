Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class ObservableObject
	Implements INotifyPropertyChanged

	Protected Sub OnPropertyChanged(<CallerMemberName()> Optional ByVal propertyName As String = Nothing)
		RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
	End Sub

	Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

End Class