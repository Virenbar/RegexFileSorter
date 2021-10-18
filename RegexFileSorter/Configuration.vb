Imports System.IO
Imports Newtonsoft.Json

Public Class Configuration
	Const CurrentF = "Current.json", ConfigsF = "Configs.json"

	Shared Sub New()
		Current = New Config
		Configs = New Dictionary(Of String, Config) From {{"C1", New Config}, {"C2", New Config}, {"C3", New Config}}
	End Sub

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
		'Configs.Add("Test", New Config())
		'Configs = JsonConvert.DeserializeObject(Of Dictionary(Of String, Config))(My.Settings.JSONConfigs)
	End Sub

	Public Shared Sub SaveJSON()
		File.WriteAllText(CurrentF, JsonConvert.SerializeObject(Current))
		File.WriteAllText(ConfigsF, JsonConvert.SerializeObject(Configs))
		'My.Settings.JSONConfig = JsonConvert.SerializeObject(Current)
		'My.Settings.JSONConfigs = JsonConvert.SerializeObject(Configs)
	End Sub

	Public Shared Sub Delete(Name As String)
		Configs.Remove(Name)
	End Sub

	Public Shared Sub SaveAs(Name As String)
		Configs.Add(Name, New Config(Current))
	End Sub

	Public Shared Sub SetConfig(Name As String)
		Current = New Config(Configs(Name))
	End Sub

End Class