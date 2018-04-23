Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports System.Runtime.InteropServices

Namespace Q248138
	Partial Public Class MainForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Function IsMaskBoxAvailable(ByVal editor As TextEdit) As Boolean
			Return editor.MaskBox IsNot Nothing AndAlso editor.MaskBox.Visible AndAlso editor.MaskBox.IsHandleCreated
		End Function

		<DllImport("user32.dll")> _
		Friend Shared Function HideCaret(ByVal hWnd As IntPtr) As Boolean
		End Function
		<DllImport("user32.dll")> _
		Friend Shared Function ShowCaret(ByVal hWnd As IntPtr) As Boolean
		End Function

		Private Sub OnHideCaretClick(ByVal sender As Object, ByVal e As EventArgs) Handles hideButton.Click
			If IsMaskBoxAvailable(testEdit) Then
				HideCaret(testEdit.MaskBox.Handle)
			End If
		End Sub

		Private Sub showButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles showButton.Click
			If IsMaskBoxAvailable(testEdit) Then
				ShowCaret(testEdit.MaskBox.Handle)
			End If
		End Sub
	End Class
End Namespace