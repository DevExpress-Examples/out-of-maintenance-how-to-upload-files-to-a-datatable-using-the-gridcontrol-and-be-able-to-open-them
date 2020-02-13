Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Diagnostics

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Private tbl As DataTable

		Private helper As UploadHelper

		Public ReadOnly Property CurrentFile() As UploadedFile
			Get
				Return If(helper Is Nothing, Nothing, helper.CurrentFile)
			End Get
		End Property

		Public Sub New()
			InitializeComponent()
			Dim table As DataTable = CreateTable()
			gridControl1.DataSource = table
			helper = New UploadHelper(table)
			AddHandler helper.CurrentFileChanged, AddressOf helper_CurrentFileChanged
			AddHandler repositoryItemButtonEdit1.ButtonClick, AddressOf repositoryItemButtonEdit1_ButtonClick
		End Sub

		Private Sub helper_CurrentFileChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateHyperLink()
		End Sub

		Public Function CreateTable() As DataTable
			tbl = New DataTable()
			tbl.Columns.Add("FileName", GetType(String))
			tbl.Columns.Add("FileSize", GetType(Integer))
			tbl.Columns.Add("FileContent", GetType(Object))
			Return tbl
		End Function


		Private Sub UpdateHyperLink()
			If helper.CurrentFile Is Nothing Then
				hyperLinkEdit1.Enabled = False
				hyperLinkEdit1.Text = "No file chosen"
			Else
				hyperLinkEdit1.Enabled = True
				hyperLinkEdit1.Text = String.Format("{0} ({1})", CurrentFile.FullPath, CurrentFile.FileSize)
			End If
		End Sub


		Private Function GetFocusedFile() As UploadedFile
			Dim dataRow As DataRow =gridView1.GetFocusedDataRow()
			If dataRow Is Nothing Then
				helper.PostNewFile(-1)
				Return GetFocusedFile()
			End If
			Return New UploadedFile(DirectCast(dataRow("FileContent"), Byte()), DirectCast(dataRow("FileName"), String))
		End Function

		Private Sub repositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
			Select Case e.Button.Index
				Case 0
					GetFocusedFile().OpenFile()
				Case 1
					helper.PostNewFile(gridView1.GetFocusedDataSourceRowIndex())
					gridView1.UpdateCurrentRow()
			End Select
		End Sub

		Private Sub btOpenFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btOpenFile.Click
			helper.ChooseFile()
		End Sub

		Private Sub btUploadFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btUploadFile.Click
			helper.UploadFile()
		End Sub
	End Class
End Namespace