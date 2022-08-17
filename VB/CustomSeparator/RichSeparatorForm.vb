Imports DevExpress.XtraRichEdit

' ...
Namespace CustomSeparator

    Public Partial Class RichSeparatorForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            richEditControl1.Document.LoadDocument("separator.rtf", DocumentFormat.Rtf)
        End Sub

        Public ReadOnly Property Result As API.Native.Document
            Get
                Return richEditControl1.Document
            End Get
        End Property

        Private Sub btnCloseReturn_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            Close()
        End Sub
    End Class
End Namespace
