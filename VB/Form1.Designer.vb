Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridLookUpEdit1 = New DevExpress.XtraEditors.GridLookUpEdit()
			Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridLookUpEdit1
			' 
			Me.gridLookUpEdit1.Location = New System.Drawing.Point(12, 12)
			Me.gridLookUpEdit1.Name = "gridLookUpEdit1"
			Me.gridLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.gridLookUpEdit1.Properties.ImmediatePopup = True
			Me.gridLookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
			Me.gridLookUpEdit1.Properties.View = Me.gridLookUpEdit1View
			Me.gridLookUpEdit1.Size = New System.Drawing.Size(718, 20)
			Me.gridLookUpEdit1.TabIndex = 0
			' 
			' gridLookUpEdit1View
			' 
			Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
			Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(199, 152)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(100, 20)
			Me.textBox1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(744, 477)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.gridLookUpEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridLookUpEdit1 As GridLookUpEdit
		Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private textBox1 As System.Windows.Forms.TextBox


	End Class
End Namespace

