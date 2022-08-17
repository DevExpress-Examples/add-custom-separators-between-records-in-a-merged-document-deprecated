Imports System
Imports System.Windows.Forms
Imports DevExpress.Snap
Imports DevExpress.Snap.Core.API
Imports DevExpress.Snap.Core.Forms
Imports DevExpress.Snap.Core.Options
Imports System.Data
Imports System.Data.SqlClient

Namespace CustomSeparator

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            ribbonControl1.SelectedPage = mailMergeRibbonPage1
        End Sub

'#Region "#SnapMailMergeExportOptions"
        ' Provide a user interface to select a custom separator.
        Private Sub snapControl1_MailMergeExportFormShowing(ByVal sender As Object, ByVal e As MailMergeExportFormShowingEventArgs)
            Dim eOptions As SnapMailMergeExportOptions = e.Options
            Dim controllerParameters As MailMergeExportFormControllerParameters = New MailMergeExportFormControllerParameters(snapControl1, eOptions)
            eOptions.RecordSeparator = RecordSeparator.Custom
            e.Handled = True
            Using mergeForm As MyMailMergeExportForm = New MyMailMergeExportForm(controllerParameters)
                mergeForm.LookAndFeel.ParentLookAndFeel = snapControl1.LookAndFeel
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

'#End Region  ' #SnapMailMergeExportOptions
'#Region "#FormLoad"
        ' Register a Snap data source and open a document template.
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Load a template.
            snapControl1.Document.LoadDocument("template.snx", SnapDocumentFormat.Snap)
            ' After loading a template, add data sources to the collection.
            snapControl1.DataSources.Add("MyDS", CreateDataSource())
            ' And specify the data source used for mail merge (the Categories table of the MyDS data source).
            snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = "MyDS"
            snapControl1.Options.SnapMailMergeVisualOptions.DataMember = "Categories"
        End Sub

        Private Shared Function CreateDataSource() As Object
            Dim ds As DataSet = New DataSet()
            Dim adapter As SqlDataAdapter = New SqlDataAdapter("SELECT * FROM Categories; SELECT * FROM Products", New SqlConnection(Properties.Settings.Default.NWindConnectionString))
            adapter.TableMappings.Add("Table", "Categories")
            adapter.TableMappings.Add("Table1", "Products")
            adapter.Fill(ds)
            ds.Relations.Add("CategoriesProducts", ds.Tables("Categories").Columns("CategoryId"), ds.Tables("Products").Columns("CategoryId"))
            Return ds
        End Function
'#End Region  ' #FormLoad
    End Class
End Namespace
