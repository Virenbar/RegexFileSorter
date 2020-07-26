Class Application

	' События приложения, например, Startup, Exit и DispatcherUnhandledException,
	' можно обрабатывать в данном файле.
	Protected Overrides Sub OnStartup(e As StartupEventArgs)
		Configuration.LoadJSON()
		MyBase.OnStartup(e)
	End Sub

	Protected Overrides Sub OnExit(e As ExitEventArgs)
		Configuration.SaveJSON()
		MyBase.OnExit(e)
	End Sub

End Class