Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
' ...

Namespace CustomSeparator
    Partial Public Class RichSeparatorForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            Me.richEditControl1.Document.LoadDocument("separator.rtf", DocumentFormat.Rtf)
        End Sub

        Public ReadOnly Property Result() As DevExpress.XtraRichEdit.API.Native.Document
            Get
                Return richEditControl1.Document
            End Get
        End Property

        Private Sub btnCloseReturn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCloseReturn.ItemClick
            Me.Close()
        End Sub
    End Class
End Namespace
