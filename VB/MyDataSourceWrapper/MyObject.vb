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

		Private _ID As Integer
		Public Property ID() As Integer
			Get
				Return _ID
			End Get
			Set(ByVal value As Integer)
				_ID = value
			End Set
		End Property

		Private _DisplayText As Object
		Public Property DisplayText() As Object
			Get
				Return _DisplayText
			End Get
			Set(ByVal value As Object)
				_DisplayText = value
			End Set
		End Property
	End Class
End Namespace
