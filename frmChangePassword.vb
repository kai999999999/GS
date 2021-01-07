Public Class frmChangePassword

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChange.Click
        If txtPassword.Text.Trim = txtPasswordAgain.Text.Trim And Len(txtPassword.Text.Trim) >= 3 Then
            MessageBox.Show("Change OK.", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Cannot change...!!!", "Change password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class