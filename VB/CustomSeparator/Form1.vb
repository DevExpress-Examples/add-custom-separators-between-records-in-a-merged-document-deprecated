Imports Microsoft.VisualBasic
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports CustomSeparator.nwindDataSetTableAdapters
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Forms
Imports DevExpress.Snap.Core.Options
' ...

Namespace CustomSeparator
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		' Provide a user interface to select a custom separator.
		Private Sub snapControl1_MailMergeExportFormShowing(ByVal sender As Object, ByVal e As MailMergeExportFormShowingEventArgs) Handles snapControl1.MailMergeExportFormShowing
			Dim controllerParameters As New MailMergeExportFormControllerParameters(Me.snapControl1, e.Options)
			e.Options.RecordSeparator = RecordSeparator.Custom
			e.Handled = True

			Using mergeForm As New MyMailMergeExportForm(controllerParameters)
				mergeForm.LookAndFeel.ParentLookAndFeel = Me.snapControl1.LookAndFeel
				e.DialogResult = mergeForm.ShowDialog(Me)
				Select Case mergeForm.SeparatorType
					Case MyMailMergeExportForm.SeparatorTypeEnum.Html
						e.Options.CustomSeparator.HtmlText = mergeForm.HtmlSeparator
					Case MyMailMergeExportForm.SeparatorTypeEnum.RichText
						e.Options.CustomSeparator.Text = String.Empty
						e.Options.CustomSeparator.AppendDocumentContent(mergeForm.RichSeparator.Range)
				End Select
			End Using
		End Sub

		' Register a Snap data source and open a document template.
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.snapControl1.DataSources.Add(String.Empty, CreateDataSource())
			Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = String.Empty
			Me.snapControl1.Document.LoadDocument("..\..\..\Data\template.snx", SnapDocumentFormat.Snap)
		End Sub

		' Specify and populate a new data source.
		Private Shared Function CreateDataSource() As Object
			Dim dataSource = New nwindDataSet()
			Dim connection = New OleDbConnection()
			connection.ConnectionString = My.Settings.Default.nwindConnectionString

			Dim categories As New CategoriesTableAdapter()
			categories.Connection = connection
			categories.Fill(dataSource.Categories)

			Dim products As New ProductsTableAdapter()
			products.Connection = connection
			products.Fill(dataSource.Products)

			Dim bindingSource = New BindingSource()
			bindingSource.DataSource = dataSource
			bindingSource.DataMember = "Categories"
			Return bindingSource
		End Function
	End Class
End Namespace
