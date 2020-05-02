Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class ToddlerProfile

    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=CenterRecord;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Dim CustomerID As String
    Dim txt As Integer
    Private Sub ToddlerProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub
    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT ToddlerID,TLast,TFirst,TMiddle,Age,Address,Sitio,DayDate,ImmunizationDate,THeight,TWeight FROM ToddlerProfile ORDER BY TLast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridToddler.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'txtOldID = rd("ToddlerID").ToString
                    txtTLast.Text = rd("TLast").ToString
                    txtTFirst.Text = rd("TFirst").ToString
                    txtTMiddle.Text = rd("TMiddle").ToString
                    txtAgeSelect.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtSitio.Text = rd("Sitio").ToString
                    dtpDayDate.Value = rd("DayDate").ToString
                    txtImmunizationDate.Text = rd("ImmunizationDate").ToString
                    txtTHeight.Text = rd("THeight").ToString
                    txtTWeight.Text = rd("TWeight").ToString


                End If

                Dim x As Integer = DataGridToddler.Rows.Add()


                DataGridToddler.Rows(x).Cells(0).Value = rd("TLast").ToString
                DataGridToddler.Rows(x).Cells(1).Value = rd("TFirst").ToString
                DataGridToddler.Rows(x).Cells(2).Value = rd("TMiddle").ToString
                DataGridToddler.Rows(x).Cells(3).Value = rd("Age").ToString
                DataGridToddler.Rows(x).Cells(4).Value = rd("Address").ToString
                DataGridToddler.Rows(x).Cells(5).Value = rd("Sitio").ToString
                DataGridToddler.Rows(x).Cells(6).Value = rd("DayDate").ToString
                DataGridToddler.Rows(x).Cells(7).Value = rd("ImmunizationDate").ToString
                DataGridToddler.Rows(x).Cells(8).Value = rd("THeight").ToString
                DataGridToddler.Rows(x).Cells(9).Value = rd("TWeight").ToString
                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtToddlerID.ResetText()
        txtTLast.ResetText()
        txtTFirst.ResetText()
        txtTMiddle.ResetText()
        txtAgeSelect.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()
        txtTWeight.ResetText()
        txtImmunizationDate.ResetText()
        dtpDayDate.ResetText()
        txtTHeight.ResetText()
        txtTWeight.ResetText()


        txtToddlerID.Text = ""
        txtTLast.Text = ""
        txtTFirst.Text = ""
        txtTMiddle.Text = ""
        txtAgeSelect.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
        txtImmunizationDate.Text = ""
        dtpDayDate.Text = ""
        txtTHeight.Text = ""
        txtTWeight.Text = ""

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtToddlerID.ResetText()
        txtTLast.ResetText()
        txtTFirst.ResetText()
        txtTMiddle.ResetText()
        txtAgeSelect.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()
        txtTWeight.ResetText()
        txtImmunizationDate.ResetText()
        dtpDayDate.ResetText()


        txtToddlerID.Text = ""
        txtTLast.Text = ""
        txtTFirst.Text = ""
        txtTMiddle.Text = ""
        txtAgeSelect.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
        txtTWeight.Text = ""
        txtImmunizationDate.Text = ""
        dtpDayDate.Text = ""

        txtToddlerID.ReadOnly = True
        txtTLast.ReadOnly = False
        txtTFirst.ReadOnly = False
        txtTMiddle.ReadOnly = False
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtSitio.ReadOnly = False
        txtTWeight.ReadOnly = False

        txtTLast.Focus()



        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        txtTLast.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (txtTLast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtTLast.SelectAll()
            txtTLast.Focus()
            Return
        End If

        If (txtTFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtTFirst.SelectAll()
            txtTFirst.Focus()
            Return
        End If

        If (txtTMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtTMiddle.SelectAll()
            txtTMiddle.Focus()
            Return
        End If


        If (txtAgeSelect.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAgeSelect.SelectAll()
            txtAgeSelect.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        If (txtSitio.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtSitio.SelectAll()
            txtSitio.Focus()
            Return
        End If

        If (txtTWeight.Text.Trim().Length = 0) Then
            MsgBox("Civil Status is empty!")
            txtTWeight.SelectAll()
            txtTWeight.Focus()
            Return
        End If

        If (txtImmunizationDate.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtImmunizationDate.Select()
            txtImmunizationDate.Focus()
            Return
        End If

        If (dtpDayDate.Text.Trim().Length = 0) Then
            MsgBox("Civil Status is empty!")
            dtpDayDate.Select()
            dtpDayDate.Focus()
            Return
        End If



        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Toddler Profile?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO ToddlerProfile (OLast,OFirst,OMiddle,Age,Address,Sitio,Contact,CivilStatus,DayDate) VALUES ('" & txtTLast.Text.Trim() & "'," _
                    & "'" & txtTFirst.Text.Trim() & "','" & txtTMiddle.Text.Trim() & "','" & txtAgeSelect.Text.Trim() & "','" & txtAddress.Text.Trim() & "'," _
                    & "'" & txtSitio.Text.Trim() & "','" & txtTWeight.Text.Trim() & "','" & txtImmunizationDate.Text.Trim() & "','" & dtpDayDate.Value.ToShortDateString & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully saved!", MsgBoxStyle.Information)

                txtToddlerID.ResetText()
                txtTLast.ResetText()
                txtTFirst.ResetText()
                txtTMiddle.ResetText()
                txtAgeSelect.ResetText()
                txtAddress.ResetText()
                txtSitio.ResetText()
                txtTWeight.ResetText()
                txtImmunizationDate.ResetText()
                dtpDayDate.ResetText()

            Catch ex As Exception
                MsgBox(ex.ToString)
                myConn.Close()

            End Try
        End If


        btnUpdate.Enabled = True
        btnNew.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If (txtToddlerID.Text.Trim().Length = 0) Then
            MsgBox(" Patients ID is empty!")
            txtToddlerID.SelectAll()
            txtToddlerID.Focus()
            Return
        End If

        If (txtTLast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtTLast.SelectAll()
            txtTLast.Focus()
            Return
        End If

        If (txtTFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtTFirst.SelectAll()
            txtTFirst.Focus()
            Return
        End If

        If (txtTMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtTMiddle.SelectAll()
            txtTMiddle.Focus()
            Return
        End If

        If (txtAgeSelect.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAgeSelect.SelectAll()
            txtAgeSelect.Focus()
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
            txtSitio.SelectAll()
            txtSitio.Focus()
            Return
        End If

        If (txtTWeight.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtTWeight.SelectAll()
            txtTWeight.Focus()
            Return
        End If

        If (txtImmunizationDate.Text.Trim().Length = 0) Then
            MsgBox("Civil Status is empty!")
            txtImmunizationDate.Select()
            txtImmunizationDate.Focus()
            Return
        End If

        If (dtpDayDate.Text.Trim().Length = 0) Then
            MsgBox("Date is empty!")
            dtpDayDate.Select()
            dtpDayDate.Focus()
            Return
        End If




        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Toddler Profile info ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "UPDATE ToddlerProfile SET OLast='" & txtTLast.Text.Trim() & "',OFirst='" & txtTFirst.Text.Trim() & "',OMiddle='" & txtTMiddle.Text.Trim() & "',Age='" & txtAgeSelect.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "',Sitio='" & txtSitio.Text.Trim() & "',Contact='" & txtTWeight.Text.Trim() & "',CivilStatus='" & txtImmunizationDate.Text.Trim() & "',DayDate='" & dtpDayDate.Value.ToShortDateString & "' " _
                    & "WHERE OldID='" & txtToddlerID.Text.Trim() & "'"

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
        txtTLast.Focus()
        txtToddlerID.ReadOnly = False
        txtTLast.ReadOnly = False
        txtTFirst.ReadOnly = False
        txtTMiddle.ReadOnly = False
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtSitio.ReadOnly = False
        txtTWeight.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtTLast.Text.Trim().Length = 0) Then
            MsgBox("LastName is empty!")
            txtTLast.SelectAll()
            txtTLast.Focus()
            Return
        End If

        If (txtTFirst.Text.Trim().Length = 0) Then
            MsgBox("FirstName is empty!")
            txtTFirst.SelectAll()
            txtTFirst.Focus()
            Return
        End If

        If (txtTMiddle.Text.Trim().Length = 0) Then
            MsgBox("MiddleName is empty!")
            txtTMiddle.SelectAll()
            txtTMiddle.Focus()
            Return
        End If


        If (txtAgeSelect.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAgeSelect.SelectAll()
            txtAgeSelect.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete this Old Profile ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "Delete From ToddlerProfile Where txtOldID='" & txtToddlerID.Text.Trim() & "'"

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
        txtToddlerID.ResetText()
        txtTLast.ResetText()
        txtTFirst.ResetText()
        txtTMiddle.ResetText()
        txtAgeSelect.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()
        txtTWeight.ResetText()
        txtImmunizationDate.ResetText()
        dtpDayDate.ResetText()

        txtToddlerID.Text = ""
        txtTLast.Text = ""
        txtTFirst.Text = ""
        txtTMiddle.Text = ""
        txtAgeSelect.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
        txtTWeight.Text = ""
        txtImmunizationDate.Text = ""
        dtpDayDate.Text = ""
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnGo.PerformClick()
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        Dim count As Integer = 0
        myConn.Close()
        sql = "SELECT OLast,OFirst,OMiddle,Age,Address,Sitio,Contact,CivilStatus,DayDate FROM ToddlerProfile WHERE OLast LIKE'%" & txtSearch.Text.Trim() & "%' ORDER BY OLast"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridToddler.Rows.Clear()
        While rd.Read
            If (count = 0) Then


                txtTLast.Text = rd("OLast").ToString
                txtTFirst.Text = rd("OFirst").ToString
                txtTMiddle.Text = rd("OMiddle").ToString
                txtAgeSelect.Text = rd("Age").ToString
                txtAddress.Text = rd("Address").ToString
                txtSitio.Text = rd("Sitio").ToString
                txtTWeight.Text = rd("Contact").ToString
                txtImmunizationDate.Text = rd("CivilStatus").ToString
                dtpDayDate.Value = rd("DayDate").ToString


            End If

            Dim x As Integer = DataGridToddler.Rows.Add()
            DataGridToddler.Rows(x).Cells(0).Value = rd("OLast").ToString
            DataGridToddler.Rows(x).Cells(1).Value = rd("OFirst").ToString
            DataGridToddler.Rows(x).Cells(2).Value = rd("OMiddle").ToString
            DataGridToddler.Rows(x).Cells(3).Value = rd("Age").ToString
            DataGridToddler.Rows(x).Cells(4).Value = rd("Address").ToString
            DataGridToddler.Rows(x).Cells(5).Value = rd("Sitio").ToString
            DataGridToddler.Rows(x).Cells(6).Value = rd("Contact").ToString
            DataGridToddler.Rows(x).Cells(7).Value = rd("CivilStatus").ToString
            DataGridToddler.Rows(x).Cells(8).Value = rd("DayDate").ToString




            count = count + 1

        End While
        myConn.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim count As Integer = 0

        Try


            sql = "SELECT OLast,OFirst,OMiddle,Age,Address,Sitio,Contact,CivilStatus,DayDate From ToddlerProfile order by OLast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridToddler.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'txtPregnantID = rd("PregantID").ToString
                    txtTLast.Text = rd("OLast").ToString
                    txtTFirst.Text = rd("OFirst").ToString
                    txtTMiddle.Text = rd("OMiddle").ToString
                    txtAgeSelect.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtSitio.Text = rd("Sitio").ToString
                    txtTWeight.Text = rd("Contact").ToString
                    txtImmunizationDate.Text = rd("CivilStatus").ToString
                    dtpDayDate.Value = rd("DayDate").ToString


                End If

                Dim x As Integer = DataGridToddler.Rows.Add()


                DataGridToddler.Rows(x).Cells(0).Value = rd("OLast").ToString
                DataGridToddler.Rows(x).Cells(1).Value = rd("OFirst").ToString
                DataGridToddler.Rows(x).Cells(2).Value = rd("OMiddle").ToString
                DataGridToddler.Rows(x).Cells(3).Value = rd("Age").ToString
                DataGridToddler.Rows(x).Cells(4).Value = rd("Address").ToString
                DataGridToddler.Rows(x).Cells(5).Value = rd("Sitio").ToString
                DataGridToddler.Rows(x).Cells(6).Value = rd("Contact").ToString
                DataGridToddler.Rows(x).Cells(7).Value = rd("CivilStatus").ToString
                DataGridToddler.Rows(x).Cells(8).Value = rd("DayDate").ToString



                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        txtTLast.ResetText()
        txtTFirst.ResetText()
        txtTMiddle.ResetText()
        txtAgeSelect.ResetText()
        txtAddress.ResetText()
        txtSitio.ResetText()
        txtTWeight.ResetText()
        txtImmunizationDate.ResetText()
        dtpDayDate.ResetText()



        txtTLast.Text = ""
        txtTFirst.Text = ""
        txtTMiddle.Text = ""
        txtAgeSelect.Text = ""
        txtAddress.Text = ""
        txtSitio.Text = ""
        txtTWeight.Text = ""
        txtImmunizationDate.Text = ""
        dtpDayDate.Text = ""
    End Sub

    Private Sub DataGridToddler_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridToddler.SelectionChanged
        Try


            txtTLast.Text = DataGridToddler.CurrentRow.Cells(0).Value
            txtTFirst.Text = DataGridToddler.CurrentRow.Cells(1).Value
            txtTMiddle.Text = DataGridToddler.CurrentRow.Cells(2).Value
            txtAgeSelect.Text = DataGridToddler.CurrentRow.Cells(3).Value
            txtAddress.Text = DataGridToddler.CurrentRow.Cells(4).Value
            txtSitio.Text = DataGridToddler.CurrentRow.Cells(5).Value
            txtTWeight.Text = DataGridToddler.CurrentRow.Cells(6).Value
            txtImmunizationDate.Text = DataGridToddler.CurrentRow.Cells(7).Value
            dtpDayDate.Value = DataGridToddler.CurrentRow.Cells(8).Value
            txtToddlerID.Text = DataGridToddler.CurrentRow.Cells(9).Value

        Catch ex As Exception

            txtTLast.Text = ""
            txtTFirst.Text = ""
            txtTMiddle.Text = ""
            txtAgeSelect.Text = ""
            txtAddress.Text = ""
            txtSitio.Text = ""
            txtTWeight.Text = ""
            txtImmunizationDate.Text = ""
            dtpDayDate.Text = ""
            txtToddlerID.Text = ""
        End Try


        txtToddlerID.ReadOnly = True
        txtTLast.ReadOnly = True
        txtTFirst.ReadOnly = True
        txtTMiddle.ReadOnly = True
        txtAge.ReadOnly = True
        txtAddress.ReadOnly = True
        txtSitio.ReadOnly = True
        txtTWeight.ReadOnly = True


        btnNew.Enabled = True
        'btnSave.Enabled = False
        btnSave.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtTLast.Focus()
        txtToddlerID.ReadOnly = True
        txtTLast.ReadOnly = False
        txtTFirst.ReadOnly = False
        txtTMiddle.ReadOnly = False
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtSitio.ReadOnly = False
        txtTWeight.ReadOnly = False

        btnNew.Enabled = False
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If (txtSearch.Text.Trim().Length <= 0) Then
            DisplayRecords()
        Else

        End If
    End Sub

    Private Sub txtAge_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgeSelect.DropDown

    End Sub


    Private Sub txtAgeSelect_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAgeSelect.SelectedIndexChanged
        txtZero.Enabled = True
        txtTwo.Enabled = True
    End Sub

    Private Sub DataGridToddler_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridToddler.CellClick
     

    End Sub
End Class