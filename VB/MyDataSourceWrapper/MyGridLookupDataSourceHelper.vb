Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Collections

Namespace WindowsApplication1
	Public Class MyGridLookupDataSourceHelper

		Private _MyObject As New MyObject()
		Private _DataSourceWrapper As MyDataSourceWrapper
		Private edit As GridLookUpEdit
		Private popupOpened As Boolean = False
		Public Sub New(ByVal edit As GridLookUpEdit, ByVal dataSource As ITypedList, ByVal displayMember As String, ByVal valueMember As String)
			Me.edit = edit
			_MyObject.ID = Int32.MinValue+5
			_DataSourceWrapper = New MyDataSourceWrapper(dataSource, _MyObject, valueMember, displayMember)
			edit.Properties.DisplayMember = displayMember
			edit.Properties.ValueMember = valueMember
			edit.Properties.DataSource = _DataSourceWrapper
			AddHandler edit.Properties.View.CustomRowFilter, AddressOf View_CustomRowFilter
			AddHandler edit.ProcessNewValue, AddressOf edit_ProcessNewValue
			edit.Properties.View.RefreshData()
			AddHandler edit.Properties.QueryPopUp, AddressOf Properties_QueryPopUp
		End Sub

		Private Sub Properties_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
			Me.popupOpened = True
			edit.Properties.View.DataController.DoRefresh()
		End Sub

		Public Shared Sub SetupGridLookUpEdit(ByVal edit As GridLookUpEdit, ByVal dataSource As ITypedList, ByVal displayMember As String, ByVal valueMember As String)
			Dim TempMyGridLookupDataSourceHelper As MyGridLookupDataSourceHelper = New MyGridLookupDataSourceHelper(edit, dataSource, displayMember, valueMember)
		End Sub

		Private Sub View_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
			If (Not popupOpened) Then
				Return
			End If
			If TypeOf _DataSourceWrapper(e.ListSourceRow) Is MyObject Then
				e.Visible = False
				e.Handled = True
			End If
		End Sub

		Private Sub edit_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs)
			_MyObject.DisplayText = e.DisplayValue
			Me.popupOpened = False
			edit.Properties.View.DataController.DoRefresh()
			e.Handled = True
		End Sub
	End Class
End Namespace
