Public Class Head
    Public user, pass As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        
        If txtUsername.Text = "R" And txtPassword.Text = "e" Then

            MsgBox("Head have succesfully login!")

            Me.Hide()


            main.Show()


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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Do you want to Cancel?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            'HeadorEmployee.Show()
        End If
    End Sub


    Private Sub Head_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUsername.Focus()
    End Sub

    Public Sub remember_me()
        If CheckBox1.Checked Then
            user = txtUsername.Text
            txtPassword.Clear()
            txtPassword.Focus()
        Else
            txtUsername.Clear()
            txtPassword.Clear()


        End If



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class