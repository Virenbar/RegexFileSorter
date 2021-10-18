Imports System.Collections.ObjectModel

Public Class ConfigurationVM
	Inherits ObservableObject

	Public Sub New()
		UpdateMenu()
	End Sub

	Public Property Current As Config
		Get
			Return Configuration.Current
		End Get
		Set(value As Config)
			Configuration.Current = value
			OnPropertyChanged()
		End Set
	End Property

	Public Sub SaveAs(Name As String)
		Configuration.SaveAs(Name)
		UpdateMenu()
	End Sub

	Public ReadOnly Property LoadMenu As ObservableCollection(Of MenuItem) = New ObservableCollection(Of MenuItem)
	Public ReadOnly Property DeleteMenu As ObservableCollection(Of MenuItem) = New ObservableCollection(Of MenuItem)

	Private Sub UpdateMenu()
		LoadMenu.Clear()
		DeleteMenu.Clear()
		For Each Config In Configuration.Configs
			Dim Name = Config.Key
			Dim LMI = New MenuItem() With {.Header = Name}
			AddHandler LMI.Click,
				Sub()
					Configuration.SetConfig(Name)
					OnPropertyChanged(NameOf(Current))
				End Sub
			LoadMenu.Add(LMI)

			Dim DMI = New MenuItem() With {.Header = Name}
			AddHandler DMI.Click,
				Sub()
					Configuration.Delete(Name)
					UpdateMenu()
				End Sub
			DeleteMenu.Add(DMI)
		Next
	End Sub

	'Public Property Configs As ObservableDictionary(Of String, Config)
End Class