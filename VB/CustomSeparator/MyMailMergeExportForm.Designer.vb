Imports Microsoft.VisualBasic
Imports System
Namespace CustomSeparator
	Partial Public Class MyMailMergeExportForm
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
			Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
			Me.simpleButton3 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton4 = New DevExpress.XtraEditors.SimpleButton()
			Me.groupBox1.SuspendLayout()
			CType(Me.radioGroupMode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditCount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEditFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.icbSeparator.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.simpleButton1.Location = New System.Drawing.Point(33, 250)
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles))
			Me.simpleButton2.Location = New System.Drawing.Point(114, 250)
			' 
			' radioGroupMode
			' 
			Me.radioGroupMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroupMode.Properties.Appearance.Options.UseBackColor = True
			' 
			' spinEditCount
			' 
			Me.spinEditCount.Properties.Mask.EditMask = "n0"
			' 
			' spinEditFrom
			' 
			Me.spinEditFrom.Properties.Mask.EditMask = "n0"
			' 
			' icbSeparator
			' 
			Me.icbSeparator.Enabled = False
			Me.icbSeparator.Visible = False
			' 
			' radioGroup1
			' 
			Me.radioGroup1.Location = New System.Drawing.Point(14, 168)
			Me.radioGroup1.Name = "radioGroup1"
			Me.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
			Me.radioGroup1.Properties.Appearance.Options.UseBackColor = True
			Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "HTML"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Rich text")})
			Me.radioGroup1.Size = New System.Drawing.Size(181, 65)
			Me.radioGroup1.TabIndex = 10
			' 
			' simpleButton3
			' 
			Me.simpleButton3.Location = New System.Drawing.Point(114, 172)
			Me.simpleButton3.Name = "simpleButton3"
			Me.simpleButton3.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton3.TabIndex = 11
			Me.simpleButton3.Text = "Edit..."
'			Me.simpleButton3.Click += New System.EventHandler(Me.simpleButton3_Click);
			' 
			' simpleButton4
			' 
			Me.simpleButton4.Location = New System.Drawing.Point(114, 201)
			Me.simpleButton4.Name = "simpleButton4"
			Me.simpleButton4.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton4.TabIndex = 12
			Me.simpleButton4.Text = "Edit..."
'			Me.simpleButton4.Click += New System.EventHandler(Me.simpleButton4_Click);
			' 
			' MyMailMergeExportForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.ClientSize = New System.Drawing.Size(208, 283)
			Me.Controls.Add(Me.simpleButton4)
			Me.Controls.Add(Me.simpleButton3)
			Me.Controls.Add(Me.radioGroup1)
			Me.Name = "MyMailMergeExportForm"
			Me.Controls.SetChildIndex(Me.groupBox1, 0)
			Me.Controls.SetChildIndex(Me.simpleButton1, 0)
			Me.Controls.SetChildIndex(Me.simpleButton2, 0)
			Me.Controls.SetChildIndex(Me.radioGroupMode, 0)
			Me.Controls.SetChildIndex(Me.icbSeparator, 0)
			Me.Controls.SetChildIndex(Me.lblSeparator, 0)
			Me.Controls.SetChildIndex(Me.radioGroup1, 0)
			Me.Controls.SetChildIndex(Me.simpleButton3, 0)
			Me.Controls.SetChildIndex(Me.simpleButton4, 0)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.radioGroupMode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditCount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEditFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.icbSeparator.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
		Private WithEvents simpleButton3 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton4 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace