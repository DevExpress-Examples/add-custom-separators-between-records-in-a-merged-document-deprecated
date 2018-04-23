Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Forms
Imports DevExpress.Snap.Core.Options
Imports System.Data
Imports System.Data.SqlClient

Namespace CustomSeparator
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = Me.mailMergeRibbonPage1
        End Sub
        #Region "#SnapMailMergeExportOptions"
        ' Provide a user interface to select a custom separator.
        Private Sub snapControl1_MailMergeExportFormShowing(ByVal sender As Object, ByVal e As MailMergeExportFormShowingEventArgs) Handles snapControl1.MailMergeExportFormShowing

            Dim eOptions As SnapMailMergeExportOptions = e.Options

            Dim controllerParameters As New MailMergeExportFormControllerParameters(Me.snapControl1, eOptions)
            eOptions.RecordSeparator = RecordSeparator.Custom
            e.Handled = True

            Using mergeForm As New MyMailMergeExportForm(controllerParameters)
                mergeForm.LookAndFeel.ParentLookAndFeel = Me.snapControl1.LookAndFeel
                e.DialogResult = mergeForm.ShowDialog(Me)
                Select Case mergeForm.SeparatorType
                    Case MyMailMergeExportForm.SeparatorTypeEnum.Html
                        eOptions.CustomSeparator.HtmlText = mergeForm.HtmlSeparator
                    Case MyMailMergeExportForm.SeparatorTypeEnum.RichText
                        eOptions.CustomSeparator.Text = String.Empty
                        eOptions.CustomSeparator.AppendDocumentContent(mergeForm.RichSeparator.Range)
                End Select
            End Using
        End Sub
        #End Region ' #SnapMailMergeExportOptions

        #Region "#FormLoad"
        ' Register a Snap data source and open a document template.
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Load a template.
            Me.snapControl1.Document.LoadDocument("template.snx", SnapDocumentFormat.Snap)
            ' After loading a template, add data sources to the collection.
            Me.snapControl1.DataSources.Add("MyDS", CreateDataSource())
            ' And specify the data source used for mail merge (the Categories table of the MyDS data source).
            Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "MyDS"
            Me.snapControl1.Options.SnapMailMergeVisualOptions.DataMember = "Categories"
        End Sub

        Private Shared Function CreateDataSource() As Object
            Dim ds As New DataSet()
            Dim adapter As New SqlDataAdapter("SELECT * FROM Categories; SELECT * FROM Products", New SqlConnection(My.Settings.Default.NWindConnectionString))
            adapter.TableMappings.Add("Table", "Categories")
            adapter.TableMappings.Add("Table1", "Products")
            adapter.Fill(ds)
            ds.Relations.Add("CategoriesProducts", ds.Tables("Categories").Columns("CategoryId"), ds.Tables("Products").Columns("CategoryId"))
            Return ds
        End Function
        #End Region ' #FormLoad
    End Class
End Namespace
