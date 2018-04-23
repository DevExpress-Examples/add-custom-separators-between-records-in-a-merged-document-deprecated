Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Snap.Core.Forms
Imports DevExpress.Snap.Forms
Imports DevExpress.XtraRichEdit.API.Native
' ...

Namespace CustomSeparator
	Partial Public Class MyMailMergeExportForm
		Inherits MailMergeExportForm
		Public Sub New(ByVal controllerParameters As MailMergeExportFormControllerParameters)
			MyBase.New(controllerParameters)
			InitializeComponent()
		End Sub

		Public Enum SeparatorTypeEnum
			Html = 0
			RichText = 1
		End Enum
		Public ReadOnly Property SeparatorType() As SeparatorTypeEnum
			Get
				Return CType(radioGroup1.SelectedIndex, SeparatorTypeEnum)
			End Get
		End Property
		Public ReadOnly Property HtmlSeparator() As String
			Get
				Return htmlSeparatorForm.Result
			End Get
		End Property
		Public ReadOnly Property RichSeparator() As Document
			Get
				Return richSeparatorForm.Result
			End Get
		End Property

		Private Sub simpleButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton3.Click
			Me.radioGroup1.SelectedIndex = 0
			htmlSeparatorForm.ShowDialog()
		End Sub

		Private Sub simpleButton4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton4.Click
			Me.radioGroup1.SelectedIndex = 1
			richSeparatorForm.ShowDialog()
		End Sub

		Private htmlSeparatorForm As New HtmlSeparatorForm()
		Private richSeparatorForm As New RichSeparatorForm()
	End Class
End Namespace
