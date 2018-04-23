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

		Public Sub New(ByVal edit As GridLookUpEdit, ByVal dataSource As ITypedList, ByVal displayMember As String, ByVal valueMember As String)
			_DataSourceWrapper = New MyDataSourceWrapper(dataSource, _MyObject)
			edit.Properties.DisplayMember = displayMember
			edit.Properties.ValueMember = valueMember
			edit.Properties.DataSource = _DataSourceWrapper
			AddHandler edit.Properties.View.CustomRowFilter, AddressOf View_CustomRowFilter
			AddHandler edit.ProcessNewValue, AddressOf edit_ProcessNewValue
			edit.Properties.View.RefreshData()
		End Sub

		Public Shared Sub SetupGridLookUpEdit(ByVal edit As GridLookUpEdit, ByVal dataSource As ITypedList, ByVal displayMember As String, ByVal valueMember As String)
			Dim TempMyGridLookupDataSourceHelper As MyGridLookupDataSourceHelper = New MyGridLookupDataSourceHelper(edit, dataSource, displayMember, valueMember)
		End Sub

		Private Sub View_CustomRowFilter(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowFilterEventArgs)
			If TypeOf _DataSourceWrapper(e.ListSourceRow) Is MyObject Then
				e.Visible = False
				e.Handled = True
			End If
		End Sub

		Private Sub edit_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs)
			_MyObject.Value = e.DisplayValue
			e.Handled = True
		End Sub
	End Class
End Namespace
