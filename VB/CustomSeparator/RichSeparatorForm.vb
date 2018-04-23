Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
' ...

Namespace CustomSeparator
	Partial Public Class RichSeparatorForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Me.richEditControl1.Document.LoadDocument("..\..\..\Data\separator.rtf", DocumentFormat.Rtf)
		End Sub

		Public ReadOnly Property Result() As DevExpress.XtraRichEdit.API.Native.Document
			Get
				Return richEditControl1.Document
			End Get
		End Property
	End Class
End Namespace
