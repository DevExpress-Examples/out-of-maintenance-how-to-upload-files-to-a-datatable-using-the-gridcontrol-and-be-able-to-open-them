Imports Microsoft.VisualBasic
Imports System
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
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject3 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.btUploadFile = New DevExpress.XtraEditors.SimpleButton()
			Me.hyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit()
			Me.btOpenFile = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 81)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemButtonEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(733, 373)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
			Me.gridView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "File Name"
			Me.gridColumn1.ColumnEdit = Me.repositoryItemButtonEdit1
			Me.gridColumn1.FieldName = "FileName"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 585
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Upload new file..", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", Nothing, Nothing, True)})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
			Me.repositoryItemButtonEdit1.ReadOnly = True
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "Size"
			Me.gridColumn2.FieldName = "FileSize"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.OptionsColumn.AllowEdit = False
			Me.gridColumn2.UnboundType = DevExpress.Data.UnboundColumnType.String
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 127
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.btUploadFile)
			Me.panelControl1.Controls.Add(Me.hyperLinkEdit1)
			Me.panelControl1.Controls.Add(Me.btOpenFile)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(733, 81)
			Me.panelControl1.TabIndex = 1
			' 
			' btUploadFile
			' 
			Me.btUploadFile.Location = New System.Drawing.Point(610, 12)
			Me.btUploadFile.Name = "btUploadFile"
			Me.btUploadFile.Size = New System.Drawing.Size(111, 23)
			Me.btUploadFile.TabIndex = 2
			Me.btUploadFile.Text = "Upload Now"
'			Me.btUploadFile.Click += New System.EventHandler(Me.btUploadFile_Click);
			' 
			' hyperLinkEdit1
			' 
			Me.hyperLinkEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.hyperLinkEdit1.Location = New System.Drawing.Point(2, 61)
			Me.hyperLinkEdit1.Name = "hyperLinkEdit1"
			Me.hyperLinkEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.hyperLinkEdit1.Size = New System.Drawing.Size(729, 18)
			Me.hyperLinkEdit1.TabIndex = 1
			' 
			' btOpenFile
			' 
			Me.btOpenFile.Location = New System.Drawing.Point(12, 12)
			Me.btOpenFile.Name = "btOpenFile"
			Me.btOpenFile.Size = New System.Drawing.Size(111, 23)
			Me.btOpenFile.TabIndex = 0
			Me.btOpenFile.Text = "Choose file.."
'			Me.btOpenFile.Click += New System.EventHandler(Me.btOpenFile_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(733, 454)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			CType(Me.hyperLinkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private hyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
		Private WithEvents btOpenFile As DevExpress.XtraEditors.SimpleButton
		Private WithEvents btUploadFile As DevExpress.XtraEditors.SimpleButton
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace

