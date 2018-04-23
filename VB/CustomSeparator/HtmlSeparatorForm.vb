Imports Microsoft.VisualBasic
Imports System.Windows.Forms
' ...

Namespace CustomSeparator
	Partial Public Class HtmlSeparatorForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property Result() As String
			Get
				Return memoEdit1.Text
			End Get
		End Property

		Private Sub memoEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

		End Sub
	End Class
End Namespace
