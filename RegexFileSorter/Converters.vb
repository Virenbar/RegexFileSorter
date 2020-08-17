Imports System.Globalization

Namespace Converters
	Public Class IntToGridLengthConverter
		Implements IValueConverter

		Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
			Return New GridLength(Math.Min(10, Math.Max(1, CInt(value))), GridUnitType.Star)
		End Function

		Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

	End Class
End Namespace