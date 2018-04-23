Imports Microsoft.VisualBasic
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
	Public Class UploadHelper
		Public Event CurrentFileChanged As EventHandler

		Private _DataSource As DataTable
		Public Property DataSource() As DataTable
			Get
				Return _DataSource
			End Get
			Set(ByVal value As DataTable)
				_DataSource = value
			End Set
		End Property


		Public Sub New(ByVal dataSource As DataTable)
			_DataSource = dataSource
		End Sub

		Private _CurrentFile As UploadedFile
		Public Property CurrentFile() As UploadedFile
			Get
				Return _CurrentFile
			End Get
			Set(ByVal value As UploadedFile)
				_CurrentFile = value
				OnCurrentFileChanged()
			End Set
		End Property

		Private Sub OnCurrentFileChanged()
			RaiseEvent CurrentFileChanged(Me, EventArgs.Empty)
		End Sub

		Public Sub UploadFile()
			UploadFile(-1)
		End Sub
		Public Sub UploadFile(ByVal dataSourceRowIndex As Integer)
			If CurrentFile IsNot Nothing Then
				Dim values() As Object = { CurrentFile.FileName, CurrentFile.FileSize, CurrentFile.FileContent }
				If dataSourceRowIndex = -1 Then
					DataSource.Rows.Add(values)
				Else
					DataSource.Rows(dataSourceRowIndex).ItemArray = values
				End If
			End If
			CurrentFile = Nothing
		End Sub

		Public Sub ChooseFile()
			If CurrentFile IsNot Nothing Then
				MessageBox.Show(String.Format("Please upload the{0} file", CurrentFile.FileName))
				Return
			End If
			Dim fd As New OpenFileDialog()
			If fd.ShowDialog() = DialogResult.OK Then
				CurrentFile = New UploadedFile(fd.FileName)
			End If

		End Sub

		Public Sub PostNewFile(ByVal dataSourceRowIndex As Integer)
			ChooseFile()
			UploadFile(dataSourceRowIndex)
		End Sub
	End Class
End Namespace
