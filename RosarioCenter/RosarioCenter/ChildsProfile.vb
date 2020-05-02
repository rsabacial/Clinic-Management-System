Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ChildsProfile

    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=CenterRecord;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Dim CustomerID As String
    Dim txt As Integer
    Private Sub ChildsProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT ChildID,CLast,CFirst,CMiddle,Mother,Weight,CHeight,BirthDate,Address,Sitio FROM ChildProfile ORDER BY CLast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridChild.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'Me.ChildID = rd("ChildID").ToString
                    txtCLast.Text = rd("CLast").ToString
                    txtCFirst.Text = rd("CFirst").ToString
                    txtCMiddle.Text = rd("CMiddle").ToString
                    txtMother.Text = rd("Mother").ToString
                    txtWeight.Text = rd("Weight").ToString
                    txtCHeight.Text = rd("CHeight").ToString
                    dtpBirthDate.Value = rd("BirthDate").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtSitio.Text = rd("Sitio").ToString
                End If

                Dim x As Integer = DataGridChild.Rows.Add()


                DataGridChild.Rows(x).Cells(0).Value = rd("CLast").ToString
                DataGridChild.Rows(x).Cells(1).Value = rd("CFirst").ToString
                DataGridChild.Rows(x).Cells(2).Value = rd("CMiddle").ToString
                DataGridChild.Rows(x).Cells(3).Value = rd("Mother").ToString
                DataGridChild.Rows(x).Cells(4).Value = rd("Weight").ToString
                DataGridChild.Rows(x).Cells(5).Value = rd("CHeight").ToString
                DataGridChild.Rows(x).Cells(6).Value = rd("BirthDate").ToString
                DataGridChild.Rows(x).Cells(7).Value = rd("Address").ToString
                DataGridChild.Rows(x).Cells(8).Value = rd("Address").ToString
                DataGridChild.Rows(x).Cells(9).Value = rd("ChildID").ToString
                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtChildID.ResetText()
        txtCLast.ResetText()
        txtCFirst.ResetText()
        txtCMiddle.ResetText()
        txtMother.ResetText()
        txtWeight.ResetText()
        txtCHeight.ResetText()
        dtpBirthDate.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()

        txtChildID.Text = ""
        txtCLast.Text = ""
        txtCFirst.Text = ""
        txtCMiddle.Text = ""
        txtMother.Text = ""
        txtWeight.Text = ""
        txtCHeight.Text = ""

        txtAddress.Text = ""
        txtSitio.Text = ""

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtChildID.ResetText()
        txtCLast.ResetText()
        txtCFirst.ResetText()
        txtCMiddle.ResetText()
        txtMother.ResetText()
        txtWeight.ResetText()
        txtCHeight.ResetText()
        dtpBirthDate.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()

        txtChildID.Text = ""
        txtCLast.Text = ""
        txtCFirst.Text = ""
        txtCMiddle.Text = ""
        txtMother.Text = ""
        txtWeight.Text = ""
        txtCHeight.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""

        txtChildID.ReadOnly = True
        txtCLast.ReadOnly = False
        txtCFirst.ReadOnly = False
        txtCMiddle.ReadOnly = False
        txtMother.ReadOnly = False
        txtWeight.ReadOnly = False
        txtCHeight.ReadOnly = False
        txtAddress.ReadOnly = False
        txtSitio.ReadOnly = False


        txtCLast.Focus()

        btnUpdate.Enabled = False
        btnSave.Enabled = True
        txtCLast.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If (txtCLast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtCLast.SelectAll()
            txtCLast.Focus()
            Return
        End If

        If (txtCFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtCFirst.SelectAll()
            txtCFirst.Focus()
            Return
        End If

        If (txtCMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtCMiddle.SelectAll()
            txtCMiddle.Focus()
            Return
        End If


        If (txtMother.Text.Trim().Length = 0) Then
            MsgBox("Mother is empty!")
            txtMother.SelectAll()
            txtMother.Focus()
            Return
        End If

        If (txtWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtWeight.SelectAll()
            txtWeight.Focus()
            Return
        End If

        If (txtCHeight.Text.Trim().Length = 0) Then
            MsgBox("Height is empty!")
            txtCHeight.SelectAll()
            txtCHeight.Focus()
            Return
        End If

        If (dtpBirthDate.Text.Trim().Length = 0) Then
            MsgBox("Civil Status is empty!")
            dtpBirthDate.Select()
            dtpBirthDate.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        If (txtSitio.Text.Trim().Length = 0) Then
            MsgBox("Sitio is empty!")
            txtSitio.Select()
            txtSitio.Focus()
            Return
        End If



        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Childs Profile ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO ChildProfile (CLast,CFirst,CMiddle,Mother,Weight,CHeight,BirthDate,Address,Sitio) VALUES ('" & txtCLast.Text.Trim() & "'," _
                    & "'" & txtCFirst.Text.Trim() & "','" & txtCMiddle.Text.Trim() & "','" & txtMother.Text.Trim() & "','" & txtWeight.Text.Trim() & "'," _
                    & "'" & txtCHeight.Text.Trim() & "','" & dtpBirthDate.Value.ToShortDateString & "','" & txtAddress.Text.Trim() & "','" & txtSitio.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully saved!", MsgBoxStyle.Information)

                txtCLast.ResetText()
                txtCFirst.ResetText()
                txtCMiddle.ResetText()
                txtMother.ResetText()
                txtWeight.ResetText()
                txtCHeight.ResetText()
                dtpBirthDate.ResetText()
                txtAddress.ResetText()
                txtSitio.ResetText()

            Catch ex As Exception
                MsgBox(ex.ToString)
                myConn.Close()




            End Try
        End If
    End Sub

    
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtCLast.Text.Trim().Length = 0) Then
            MsgBox("LastName is empty!")
            txtCLast.SelectAll()
            txtCLast.Focus()
            Return
        End If

        If (txtCFirst.Text.Trim().Length = 0) Then
            MsgBox("FirstName is empty!")
            txtCFirst.SelectAll()
            txtCFirst.Focus()
            Return
        End If

        If (txtCMiddle.Text.Trim().Length = 0) Then
            MsgBox("MiddleName is empty!")
            txtCMiddle.SelectAll()
            txtCMiddle.Focus()
            Return
        End If


        If (txtMother.Text.Trim().Length = 0) Then
            MsgBox("Mother is empty!")
            txtMother.SelectAll()
            txtMother.Focus()
            Return
        End If

        If (txtWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtWeight.SelectAll()
            txtWeight.Focus()
            Return
        End If





        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete this Childs Profile ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "Delete From ChildProfile Where ChildID='" & txtChildID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully deleted!", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
                myConn.Close()
            End Try
        End If
        txtChildID.ResetText()
        txtCLast.ResetText()
        txtCFirst.ResetText()
        txtCMiddle.ResetText()
        txtMother.ResetText()
        txtWeight.ResetText()
        txtCHeight.ResetText()
        dtpBirthDate.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()

        txtChildID.Text = ""
        txtCLast.Text = ""
        txtCFirst.Text = ""
        txtCMiddle.Text = ""
        txtMother.Text = ""
        txtWeight.Text = ""
        txtCHeight.Text = ""
        dtpBirthDate.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim count As Integer = 0

        Try


            sql = "SELECT ChildID,CLast,CFirst,CMiddle,Mother,Weight,CHeight,BirthDate,Address,Sitio From ChildProfile order by CLast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridChild.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'Me.ChildID = rd("ChildID").ToString
                    txtCLast.Text = rd("CLast").ToString
                    txtCFirst.Text = rd("CFirst").ToString
                    txtCMiddle.Text = rd("CMiddle").ToString

                    txtMother.Text = rd("Mother").ToString
                    txtWeight.Text = rd("Weight").ToString
                    txtCHeight.Text = rd("CHeight").ToString
                    dtpBirthDate.Value = rd("BirthDate").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtSitio.Text = rd("Sitio").ToString


                End If

                Dim x As Integer = DataGridChild.Rows.Add()

                DataGridChild.Rows(x).Cells(0).Value = rd("ChildID").ToString
                DataGridChild.Rows(x).Cells(1).Value = rd("CLast").ToString
                DataGridChild.Rows(x).Cells(2).Value = rd("CFirst").ToString
                DataGridChild.Rows(x).Cells(3).Value = rd("CMiddle").ToString
                DataGridChild.Rows(x).Cells(4).Value = rd("Mother").ToString
                DataGridChild.Rows(x).Cells(5).Value = rd("Weight").ToString
                DataGridChild.Rows(x).Cells(6).Value = rd("CHeight").ToString
                DataGridChild.Rows(x).Cells(4).Value = rd("BirthDate").ToString
                DataGridChild.Rows(x).Cells(5).Value = rd("Address").ToString
                DataGridChild.Rows(x).Cells(6).Value = rd("Sitio").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        txtChildID.ResetText()
        txtCLast.ResetText()
        txtCFirst.ResetText()
        txtCMiddle.ResetText()
        txtMother.ResetText()
        txtWeight.ResetText()
        txtCHeight.ResetText()
        txtAddress.ResetText()
        dtpBirthDate.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()

        txtChildID.Text = ""
        txtCLast.Text = ""
        txtCFirst.Text = ""
        txtCMiddle.Text = ""
        txtMother.Text = ""
        txtWeight.Text = ""
        txtCHeight.Text = ""
        'dtpBirthDate.Value = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim count As Integer = 0
        myConn.Close()
        sql = "SELECT ChildID,CLast,CFirst,CMiddle,Mother,Weight,CHeight,BirthDate,Address,Sitio FROM ChildProfile WHERE CLast LIKE'%" & txtSearch.Text.Trim() & "%' or CFirst LIKE'%" & txtSearch.Text.Trim() & "%'  ORDER BY CLast"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridChild.Rows.Clear()
        While rd.Read
            If (count = 0) Then


                txtCLast.Text = rd("CLast").ToString
                txtCFirst.Text = rd("CFirst").ToString
                txtCMiddle.Text = rd("CMiddle").ToString
                txtMother.Text = rd("Mother").ToString
                txtWeight.Text = rd("Weight").ToString
                txtCHeight.Text = rd("CHeight").ToString
                dtpBirthDate.Value = rd("BirthDate").ToString
                txtAddress.Text = rd("Address").ToString
                txtSitio.Text = rd("Sitio").ToString
                txtChildID.Text = rd("ChildID").ToString


            End If

            Dim x As Integer = DataGridChild.Rows.Add()


            DataGridChild.Rows(x).Cells(0).Value = rd("CLast").ToString
            DataGridChild.Rows(x).Cells(1).Value = rd("CFirst").ToString
            DataGridChild.Rows(x).Cells(2).Value = rd("CMiddle").ToString
            DataGridChild.Rows(x).Cells(3).Value = rd("Mother").ToString
            DataGridChild.Rows(x).Cells(4).Value = rd("Weight").ToString
            DataGridChild.Rows(x).Cells(5).Value = rd("CHeight").ToString
            DataGridChild.Rows(x).Cells(6).Value = rd("BirthDate").ToString
            DataGridChild.Rows(x).Cells(7).Value = rd("Address").ToString
            DataGridChild.Rows(x).Cells(8).Value = rd("Sitio").ToString
            DataGridChild.Rows(x).Cells(9).Value = rd("ChildID").ToString


            count = count + 1

        End While
        myConn.Close()
    End Sub

    Private Sub DataGridChild_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridChild.SelectionChanged
        Try
            txtCLast.Text = DataGridChild.CurrentRow.Cells(0).Value
            txtCFirst.Text = DataGridChild.CurrentRow.Cells(1).Value
            txtCMiddle.Text = DataGridChild.CurrentRow.Cells(2).Value
            txtMother.Text = DataGridChild.CurrentRow.Cells(3).Value
            txtWeight.Text = DataGridChild.CurrentRow.Cells(4).Value
            txtCHeight.Text = DataGridChild.CurrentRow.Cells(5).Value
            dtpBirthDate.Value = DataGridChild.CurrentRow.Cells(6).Value
            txtAddress.Text = DataGridChild.CurrentRow.Cells(7).Value
            txtSitio.Text = DataGridChild.CurrentRow.Cells(8).Value
            txtChildID.Text = DataGridChild.CurrentRow.Cells(9).Value

        Catch ex As Exception

            txtCLast.Text = ""
            txtCFirst.Text =
            txtCMiddle.Text = ""
            txtMother.Text = ""
            txtWeight.Text = ""
            txtCHeight.Text = ""
            dtpBirthDate.Text = ""
            txtAddress.Text = ""
            txtSitio.Text = ""
            txtChildID.Text = ""
        End Try
    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If (txtSearch.Text.Trim().Length <= 0) Then
            DisplayRecords()
        Else

        End If
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtCLast.Focus()
        txtChildID.ReadOnly = True
        txtCLast.ReadOnly = False
        txtCFirst.ReadOnly = False
        txtCMiddle.ReadOnly = False
        txtMother.ReadOnly = False
        txtWeight.ReadOnly = False
        txtCHeight.ReadOnly = False
        txtAddress.ReadOnly = False
        txtSitio.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

   
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If (txtCLast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtCLast.SelectAll()
            txtCLast.Focus()
            Return
        End If

        If (txtCFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtCFirst.SelectAll()
            txtCFirst.Focus()
            Return
        End If

        If (txtCMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtCMiddle.SelectAll()
            txtCMiddle.Focus()
            Return
        End If

        If (txtMother.Text.Trim().Length = 0) Then
            MsgBox("Mother is empty!")
            txtMother.SelectAll()
            txtMother.Focus()
            Return
        End If

        If (txtWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtWeight.SelectAll()
            txtWeight.Focus()
            Return
        End If

        If (txtCHeight.Text.Trim().Length = 0) Then
            MsgBox("Height is empty!")
            txtCHeight.SelectAll()
            txtCHeight.Focus()
            Return
        End If

        If (dtpBirthDate.Text.Trim().Length = 0) Then
            MsgBox("Birth Date is empty!")
            dtpBirthDate.Select()
            dtpBirthDate.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        If (txtSitio.Text.Trim().Length = 0) Then
            MsgBox("Sitio is empty!")
            txtSitio.Select()
            txtSitio.Focus()
            Return
        End If




        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Childs Profile info ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "UPDATE ChildProfile SET CLast='" & txtCLast.Text.Trim() & "',CFirst='" & txtCFirst.Text.Trim() & "',CMiddle='" & txtCMiddle.Text.Trim() & "',Mother='" & txtMother.Text.Trim() & "',Weight='" & txtWeight.Text.Trim() & "',CHeight='" & txtCHeight.Text.Trim() & "',BirthDate='" & dtpBirthDate.Value.ToShortDateString & "',Address='" & txtAddress.Text.Trim() & "',Sitio='" & txtSitio.Text.Trim() & "' " _
                    & "WHERE ChildID='" & txtChildID.Text.Trim() & "'"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully updated!", MsgBoxStyle.Information)

            Catch ex As Exception
                MsgBox(ex.ToString)
                myConn.Close()
            End Try
        End If


    End Sub
End Class