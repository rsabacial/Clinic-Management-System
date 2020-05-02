Public Class main


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        AllProfile.Hide()
        ChildsProfile.Hide()
        ToddlerProfile.Hide()
        Pregnants.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ChildsProfile.Hide()
        ToddlerProfile.Show()
        Pregnants.Hide()
        AllProfile.Hide()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ChildsProfile.Show()
        ToddlerProfile.Hide()
        Pregnants.Hide()
        AllProfile.Hide()
    End Sub



    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If MsgBox("Do you want to Logout?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            MsgBox("Successfully Logout!")

            Me.Hide()


            'Head.Show()
            Head.remember_me()


        ElseIf MsgBoxResult.No Then
            MsgBox("Logout Cancelled!")

        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ChildsProfile.Hide()
        ToddlerProfile.Hide()
        Pregnants.Hide()
        AllProfile.Show()
    End Sub


    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class