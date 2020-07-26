Imports System.IO
Imports Newtonsoft.Json

Public Class Configuration
	Const CurrentF = "Current.json", ConfigsF = "Configs.json"
	Public Shared Property Current As Config
	Public Shared Property Configs As Dictionary(Of String, Config)

	Public Shared Sub LoadJSON()
		If File.Exists(CurrentF) Then
			Current = JsonConvert.DeserializeObject(Of Config)(File.ReadAllText(CurrentF))
		Else
			Current = New Config
		End If
		If File.Exists(ConfigsF) Then
			Configs = JsonConvert.DeserializeObject(Of Dictionary(Of String, Config))(File.ReadAllText(ConfigsF))
		Else
			Configs = New Dictionary(Of String, Config)
		End If
		'Configs = JsonConvert.DeserializeObject(Of Dictionary(Of String, Config))(My.Settings.JSONConfigs)
	End Sub

	Public Shared Sub SaveJSON()
		File.WriteAllText(CurrentF, JsonConvert.SerializeObject(Current))
		File.WriteAllText(ConfigsF, JsonConvert.SerializeObject(Configs))
		'My.Settings.JSONConfig = JsonConvert.SerializeObject(Current)
		'My.Settings.JSONConfigs = JsonConvert.SerializeObject(Configs)
	End Sub

	Public Shared Sub Delete(Name As String)

	End Sub

	Public Shared Sub SaveAs(Name As String)

	End Sub

	Public Shared Sub SetConfig(Name As String)
	End Sub

End Class