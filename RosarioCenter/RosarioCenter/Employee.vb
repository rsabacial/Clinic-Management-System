Public Class Employee
    Public user, pass As String

  

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            HeadorEmployee.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtUsername.Text = "R" And txtPassword.Text = "e" Then

            MsgBox("Employee have succesfully login!")

            Me.Hide()


            main.Show()
            txtUsername.ResetText()
            txtPassword.ResetText()
            txtUsername.Focus()


        ElseIf txtUsername.Text = "" Then
            MsgBox("Username is empty!", MsgBoxStyle.Information)

        ElseIf txtPassword.Text = "" Then
            MsgBox("Password is empty!", MsgBoxStyle.Information)


        Else : MsgBox(" The Username or Password is incorrect.", MsgBoxStyle.Critical, "Information")
            txtUsername.Text = ""
            txtPassword.Text = ""
            txtUsername.Focus()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            user = txtUsername.Text
            txtPassword.Clear()
            txtPassword.Focus()
        Else
            txtUsername.Clear()
            txtPassword.Clear()


        End If
    End Sub

    Private Sub Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class