Namespace CustomSeparator

    Partial Class HtmlSeparatorForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomSeparator.HtmlSeparatorForm))
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
            Me.memoEdit1.Location = New System.Drawing.Point(0, 0)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(284, 262)
            Me.memoEdit1.TabIndex = 0
            Me.memoEdit1.UseOptimizedRendering = True
            ' 
            ' HtmlSeparatorForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(284, 262)
            Me.Controls.Add(Me.memoEdit1)
            Me.Name = "HtmlSeparatorForm"
            Me.Text = "HtmlSeparatorForm"
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace
