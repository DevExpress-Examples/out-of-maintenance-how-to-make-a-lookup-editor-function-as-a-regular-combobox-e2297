Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections

Namespace WindowsApplication1
	Public Class MyObject

		Public Sub New()

		End Sub

		Private _Value As Object
		Public Property Value() As Object
			Get
				Return _Value
			End Get
			Set(ByVal value As Object)
				_Value = value
			End Set
		End Property
	End Class
End Namespace
