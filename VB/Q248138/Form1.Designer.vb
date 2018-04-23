Imports Microsoft.VisualBasic
Imports System
Namespace Q248138
	Partial Public Class MainForm
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
			Me.testEdit = New DevExpress.XtraEditors.TextEdit()
			Me.hideButton = New DevExpress.XtraEditors.SimpleButton()
			Me.showButton = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.testEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' testEdit
			' 
			Me.testEdit.Location = New System.Drawing.Point(12, 12)
			Me.testEdit.Name = "testEdit"
			Me.testEdit.Size = New System.Drawing.Size(156, 22)
			Me.testEdit.TabIndex = 0
			' 
			' hideButton
			' 
			Me.hideButton.AllowFocus = False
			Me.hideButton.Location = New System.Drawing.Point(12, 40)
			Me.hideButton.Name = "hideButton"
			Me.hideButton.Size = New System.Drawing.Size(75, 23)
			Me.hideButton.TabIndex = 1
			Me.hideButton.Text = "Hide Caret"
'			Me.hideButton.Click += New System.EventHandler(Me.OnHideCaretClick);
			' 
			' showButton
			' 
			Me.showButton.AllowFocus = False
			Me.showButton.Location = New System.Drawing.Point(93, 40)
			Me.showButton.Name = "showButton"
			Me.showButton.Size = New System.Drawing.Size(75, 23)
			Me.showButton.TabIndex = 2
			Me.showButton.Text = "Show Caret"
'			Me.showButton.Click += New System.EventHandler(Me.showButton_Click);
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(176, 67)
			Me.Controls.Add(Me.showButton)
			Me.Controls.Add(Me.hideButton)
			Me.Controls.Add(Me.testEdit)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
			CType(Me.testEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private testEdit As DevExpress.XtraEditors.TextEdit
		Private WithEvents hideButton As DevExpress.XtraEditors.SimpleButton
		Private WithEvents showButton As DevExpress.XtraEditors.SimpleButton

	End Class
End Namespace

