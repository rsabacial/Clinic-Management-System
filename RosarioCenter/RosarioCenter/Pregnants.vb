Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Pregnants

    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=CenterRecord;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    'Dim sql1 As String

    Dim txt As Integer
    Private Sub Pregnants_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub

    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT PregnantID,Last,First,Middle,Age,Address,Contact,CivilStatus,DayDate,Period,PHeight,PWeight,ArmsWidth,PVaccine,LastVisitDate,MonthlyCheckUp FROM PregnantProfile ORDER BY Last"
            'sql1 = "SELECT PHeight,PWeight,ArmsWidth,PVaccine,LastVisitDate,MonthlyCheckUp FROM PregnantProfile ORDER BY PWeight"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridPregnants.Rows.Clear()
            'DataGridHistory.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'Me.txtPregnantID = rd("PregnantID").ToString
                    txtLast.Text = rd("Last").ToString
                    txtFirst.Text = rd("First").ToString
                    txtMiddle.Text = rd("Middle").ToString
                    txtAge.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtContact.Text = rd("Contact").ToString
                    txtCivilStatus.Text = rd("CivilStatus").ToString
                    dtpDate.Value = rd("DayDate").ToString
                    dtpPeriod.Value = rd("Period").ToString

                    txtPHeight.Text = rd("PHeight").ToString
                    txtPWeight.Text = rd("PWeight").ToString
                    txtArmsWidth.Text = rd("ArmsWidth").ToString
                    txtPVaccine.Text = rd("PVaccine").ToString
                    dtpLastVisitDate.Value = rd("LastVisitDate").ToString
                    dtpMonthlyCheckUp.Value = rd("MonthlyCheckUp").ToString


                    Dim x As Integer = DataGridPregnants.Rows.Add()


                    DataGridPregnants.Rows(x).Cells(0).Value = rd("Last").ToString
                    DataGridPregnants.Rows(x).Cells(1).Value = rd("First").ToString
                    DataGridPregnants.Rows(x).Cells(2).Value = rd("Middle").ToString
                    DataGridPregnants.Rows(x).Cells(3).Value = rd("Age").ToString
                    DataGridPregnants.Rows(x).Cells(4).Value = rd("Address").ToString
                    DataGridPregnants.Rows(x).Cells(5).Value = rd("Contact").ToString
                    DataGridPregnants.Rows(x).Cells(6).Value = rd("CivilStatus").ToString
                    DataGridPregnants.Rows(x).Cells(7).Value = rd("DayDate").ToString
                    DataGridPregnants.Rows(x).Cells(8).Value = rd("Period").ToString


                    ' Dim xe As Integer = DataGridHistory.Rows.Add()


                    DataGridPregnants.Rows(x).Cells(9).Value = rd("PHeight").ToString
                    DataGridPregnants.Rows(x).Cells(10).Value = rd("PWeight").ToString
                    DataGridPregnants.Rows(x).Cells(11).Value = rd("ArmsWidth").ToString
                    DataGridPregnants.Rows(x).Cells(12).Value = rd("PVaccine").ToString
                    DataGridPregnants.Rows(x).Cells(13).Value = rd("LastVisitDate").ToString
                    DataGridPregnants.Rows(x).Cells(14).Value = rd("MonthlyCheckUp").ToString
                    DataGridPregnants.Rows(x).Cells(15).Value = rd("PregnantID").ToString
                End If

                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtPregnantID.ResetText()
        txtLast.ResetText()
        txtFirst.ResetText()
        txtMiddle.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtContact.ResetText()
        txtCivilStatus.ResetText()
        dtpDate.ResetText()
        dtpPeriod.ResetText()

        txtPHeight.ResetText()
        txtPWeight.ResetText()
        txtArmsWidth.ResetText()
        txtPVaccine.ResetText()
        dtpLastVisitDate.ResetText()
        dtpMonthlyCheckUp.ResetText()

        txtPregnantID.Text = ""
        txtLast.Text = ""
        txtFirst.Text = ""
        txtMiddle.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtCivilStatus.Text = ""
        dtpDate.Text = ""
        dtpPeriod.Text = ""

        txtPHeight.Text = ""
        txtPWeight.Text = ""
        txtArmsWidth.Text = ""
        txtPVaccine.Text = ""
        dtpLastVisitDate.Text = ""
        dtpMonthlyCheckUp.Text = ""

    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtPregnantID.ResetText()
        txtLast.ResetText()
        txtFirst.ResetText()
        txtMiddle.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtContact.ResetText()
        txtCivilStatus.ResetText()
        dtpDate.ResetText()
        dtpPeriod.ResetText()

        txtPHeight.ResetText()
        txtPWeight.ResetText()
        txtArmsWidth.ResetText()
        txtPVaccine.ResetText()
        dtpLastVisitDate.ResetText()
        dtpMonthlyCheckUp.ResetText()

        txtPregnantID.Text = ""
        txtLast.Text = ""
        txtFirst.Text = ""
        txtMiddle.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtCivilStatus.Text = ""
        dtpDate.Text = ""
        dtpPeriod.Text = ""

        txtPHeight.Text = ""
        txtPWeight.Text = ""
        txtArmsWidth.Text = ""
        txtPVaccine.Text = ""
        dtpLastVisitDate.Text = ""
        dtpMonthlyCheckUp.Text = ""

        txtPregnantID.ReadOnly = True
        txtLast.ReadOnly = False
        txtFirst.ReadOnly = False
        txtMiddle.ReadOnly = False
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtContact.ReadOnly = False

        txtPHeight.ReadOnly = False
        txtPWeight.ReadOnly = False
        txtArmsWidth.ReadOnly = False
        txtPVaccine.ReadOnly = False

        


        txtLast.Focus()

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        txtLast.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If (txtLast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtLast.SelectAll()
            txtLast.Focus()
            Return
        End If

        If (txtFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtFirst.SelectAll()
            txtFirst.Focus()
            Return
        End If

        If (txtMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtMiddle.SelectAll()
            txtMiddle.Focus()
            Return
        End If


        If (txtAge.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAge.SelectAll()
            txtAge.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If

        If (txtPHeight.Text.Trim().Length = 0) Then
            MsgBox("Height is empty!")
            txtPHeight.SelectAll()
            txtPHeight.Focus()
            Return
        End If


        If (txtPWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtPWeight.SelectAll()
            txtPWeight.Focus()
            Return
        End If

        If (txtArmsWidth.Text.Trim().Length = 0) Then
            MsgBox("Arms Width is empty!")
            txtArmsWidth.SelectAll()
            txtArmsWidth.Focus()
            Return
        End If

        If (txtPVaccine.Text.Trim().Length = 0) Then
            MsgBox("Vaccine is empty!")
            txtPVaccine.SelectAll()
            txtPVaccine.Focus()
            Return
        End If
        



        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save new Pregnant's Profile?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT INTO PregnantProfile (Last,First,Middle,Age,Address,Contact,CivilStatus,DayDate,Period,PHeight,PWeight,ArmsWidth,PVaccine,LastVisitDate,MonthlyCheckUp) VALUES ('" & txtLast.Text.Trim() & "'," _
                    & "'" & txtFirst.Text.Trim() & "','" & txtMiddle.Text.Trim() & "','" & txtAge.Text.Trim() & "','" & txtAddress.Text.Trim() & "'," _
                    & "'" & txtContact.Text.Trim() & "','" & txtCivilStatus.Text.Trim() & "','" & dtpDate.Value.ToShortDateString & "','" & dtpPeriod.Value.ToShortDateString & "'," _
                    & "'" & txtPHeight.Text.Trim() & "','" & txtPWeight.Text.Trim() & "'," _
                    & "'" & txtArmsWidth.Text.Trim() & "','" & txtPVaccine.Text.Trim() & "','" & dtpLastVisitDate.Value.ToShortDateString & "','" & dtpMonthlyCheckUp.Value.ToShortDateString & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully saved!", MsgBoxStyle.Information)

                txtLast.ResetText()
                txtFirst.ResetText()
                txtMiddle.ResetText()
                txtAge.ResetText()
                txtAddress.ResetText()
                txtContact.ResetText()
                txtCivilStatus.ResetText()
                txtPHeight.ResetText()
                txtPWeight.ResetText()
                txtArmsWidth.ResetText()
                txtPVaccine.ResetText()
                dtpLastVisitDate.ResetText()
                

            Catch ex As Exception
                MsgBox(ex.ToString)
                myConn.Close()

            End Try
        End If


        btnUpdate.Enabled = True
        btnNew.Enabled = True
        btnDelete.Enabled = True
    End Sub
    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim count As Integer = 0
        myConn.Close()
        sql = "SELECT Last,First,Middle,Age,Address,Contact,CivilStatus,DayDate,Period,PHeight,PWeight,ArmsWidth,PVaccine,LastVisitDate,MonthlyCheckUp FROM PregnantProfile WHERE Last LIKE'%" & txtSearch.Text.Trim() & "%' ORDER BY Last"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridPregnants.Rows.Clear()
        'DataGridHistory.Rows.Clear()
        While rd.Read
            If (count = 0) Then


                txtLast.Text = rd("Last").ToString
                txtFirst.Text = rd("First").ToString
                txtMiddle.Text = rd("Middle").ToString
                txtAge.Text = rd("Age").ToString
                txtAddress.Text = rd("Address").ToString
                txtContact.Text = rd("Contact").ToString
                txtCivilStatus.Text = rd("CivilStatus").ToString
                dtpDate.Value = rd("DayDate").ToString
                dtpPeriod.Value = rd("Period").ToString

                txtPHeight.Text = rd("PHeight").ToString
                txtPWeight.Text = rd("PWeight").ToString
                txtArmsWidth.Text = rd("ArmsWidth").ToString
                txtPVaccine.Text = rd("PVaccine").ToString
                dtpLastVisitDate.Value = rd("LastVisitDate").ToString
                dtpMonthlyCheckUp.Value = rd("MonthlyCheckUp").ToString


            End If

            Dim x As Integer = DataGridPregnants.Rows.Add()
            DataGridPregnants.Rows(x).Cells(0).Value = rd("Last").ToString
            DataGridPregnants.Rows(x).Cells(1).Value = rd("First").ToString
            DataGridPregnants.Rows(x).Cells(2).Value = rd("Middle").ToString
            DataGridPregnants.Rows(x).Cells(3).Value = rd("Age").ToString
            DataGridPregnants.Rows(x).Cells(4).Value = rd("Address").ToString
            DataGridPregnants.Rows(x).Cells(5).Value = rd("Contact").ToString
            DataGridPregnants.Rows(x).Cells(6).Value = rd("CivilStatus").ToString
            DataGridPregnants.Rows(x).Cells(7).Value = rd("DayDate").ToString
            DataGridPregnants.Rows(x).Cells(8).Value = rd("Period").ToString

            'Dim xe As Integer = DataGridHistory.Rows.Add()


            ' DataGridHistory.Rows(xe).Cells(0).Value = rd("PHeight").ToString
            '  DataGridHistory.Rows(xe).Cells(1).Value = rd("PWeight").ToString
            ' DataGridHistory.Rows(xe).Cells(2).Value = rd("ArmsWidth").ToString
            '   DataGridHistory.Rows(xe).Cells(3).Value = rd("PVaccine").ToString
            '  DataGridHistory.Rows(xe).Cells(4).Value = rd("LastVisitDate").ToString
            '    DataGridHistory.Rows(xe).Cells(5).Value = rd("MonthlyCheckUp").ToString


            count = count + 1

        End While
        myConn.Close()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtLast.Text.Trim().Length = 0) Then
            MsgBox("LastName is empty!")
            txtLast.SelectAll()
            txtLast.Focus()
            Return
        End If

        If (txtFirst.Text.Trim().Length = 0) Then
            MsgBox("FirstName is empty!")
            txtFirst.SelectAll()
            txtFirst.Focus()
            Return
        End If

        If (txtMiddle.Text.Trim().Length = 0) Then
            MsgBox("MiddleName is empty!")
            txtMiddle.SelectAll()
            txtMiddle.Focus()
            Return
        End If


        If (txtAge.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAge.SelectAll()
            txtAge.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If





        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete this Pregnant Profile ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "Delete From PregnantProfile Where PregnantID='" & txtPregnantID.Text.Trim() & "'"

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
        txtPregnantID.ResetText()
        txtLast.ResetText()
        txtFirst.ResetText()
        txtMiddle.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtContact.ResetText()
        txtCivilStatus.ResetText()
        dtpDate.ResetText()
        dtpPeriod.ResetText()

        txtPHeight.ResetText()
        txtPWeight.ResetText()
        txtArmsWidth.ResetText()
        txtPVaccine.ResetText()
        dtpLastVisitDate.ResetText()
        dtpMonthlyCheckUp.ResetText()

        txtPregnantID.Text = ""
        txtLast.Text = ""
        txtFirst.Text = ""
        txtMiddle.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtCivilStatus.Text = ""

        txtPHeight.Text = ""
        txtPWeight.Text = ""
        txtArmsWidth.Text = ""
        txtPVaccine.Text = ""
        dtpLastVisitDate.Text = ""
        dtpMonthlyCheckUp.Text = ""


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim count As Integer = 0

        Try


            sql = "SELECT Last,First,Middle,Age,Address,Contact,CivilStatus,DayDate,Period From PregnantProfile order by Last"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridPregnants.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'txtPregnantID = rd("PregantID").ToString
                    txtLast.Text = rd("Last").ToString
                    txtFirst.Text = rd("First").ToString
                    txtMiddle.Text = rd("Middle").ToString

                    txtAge.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtContact.Text = rd("Contact").ToString
                    txtCivilStatus.Text = rd("CivilStatus").ToString
                    dtpDate.Value = rd("DayDate").ToString
                    dtpPeriod.Value = rd("Period").ToString


                End If

                Dim x As Integer = DataGridPregnants.Rows.Add()


                DataGridPregnants.Rows(x).Cells(0).Value = rd("Last").ToString
                DataGridPregnants.Rows(x).Cells(1).Value = rd("First").ToString
                DataGridPregnants.Rows(x).Cells(2).Value = rd("Middle").ToString
                DataGridPregnants.Rows(x).Cells(3).Value = rd("Age").ToString
                DataGridPregnants.Rows(x).Cells(4).Value = rd("Address").ToString
                DataGridPregnants.Rows(x).Cells(5).Value = rd("Contact").ToString
                DataGridPregnants.Rows(x).Cells(6).Value = rd("CivilStatus").ToString
                DataGridPregnants.Rows(x).Cells(7).Value = rd("DayDate").ToString
                DataGridPregnants.Rows(x).Cells(8).Value = rd("Period").ToString

                ' Dim xe As Integer = DataGridHistory.Rows.Add()

                ' DataGridHistory.Rows(xe).Cells(0).Value = rd("PHeight").ToString
                '  DataGridHistory.Rows(xe).Cells(1).Value = rd("PWeight").ToString
                '  DataGridHistory.Rows(xe).Cells(2).Value = rd("ArmsWidth").ToString
                '  DataGridHistory.Rows(xe).Cells(3).Value = rd("PVaccine").ToString
              '   DataGridHistory.Rows(xe).Cells(5).Value = rd("MonthlyCheckUp").ToString


                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        txtLast.ResetText()
        txtFirst.ResetText()
        txtMiddle.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtContact.ResetText()
        txtCivilStatus.ResetText()
        dtpDate.ResetText()
        dtpPeriod.ResetText()

        txtPHeight.ResetText()
        txtPWeight.ResetText()
        txtArmsWidth.ResetText()
        txtPVaccine.ResetText()
        dtpLastVisitDate.ResetText()
        dtpMonthlyCheckUp.ResetText()



        txtLast.Text = ""
        txtFirst.Text = ""
        txtMiddle.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtContact.Text = ""
        txtCivilStatus.Text = ""
        dtpDate.Text = ""
        dtpPeriod.Text = ""


        txtPHeight.Text = ""
        txtPWeight.Text = ""
        txtArmsWidth.Text = ""
        txtPVaccine.Text = ""
        dtpLastVisitDate.Text = ""
        dtpMonthlyCheckUp.Text = ""


    End Sub


    Private Sub DataGridPregnants_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridPregnants.SelectionChanged
        Try


            txtLast.Text = DataGridPregnants.CurrentRow.Cells(0).Value
            txtFirst.Text = DataGridPregnants.CurrentRow.Cells(1).Value
            txtMiddle.Text = DataGridPregnants.CurrentRow.Cells(2).Value
            txtAge.Text = DataGridPregnants.CurrentRow.Cells(3).Value
            txtAddress.Text = DataGridPregnants.CurrentRow.Cells(4).Value
            txtContact.Text = DataGridPregnants.CurrentRow.Cells(5).Value
            txtCivilStatus.Text = DataGridPregnants.CurrentRow.Cells(6).Value
            dtpDate.Value = DataGridPregnants.CurrentRow.Cells(7).Value
            dtpPeriod.Value = DataGridPregnants.CurrentRow.Cells(8).Value
            txtPregnantID.Text = DataGridPregnants.CurrentRow.Cells(9).Value

        Catch ex As Exception

            txtPregnantID.Text = ""
            txtLast.Text = ""
            txtFirst.Text =
            txtMiddle.Text = ""
            txtAge.Text = ""
            txtAddress.Text = ""
            txtContact.Text = ""
            txtCivilStatus.Text = ""
            dtpDate.Text = ""
            dtpPeriod.Text = ""

        End Try


        txtPregnantID.ReadOnly = True
        txtLast.ReadOnly = True
        txtFirst.ReadOnly = True
        txtMiddle.ReadOnly = True
        txtAge.ReadOnly = True
        txtAddress.ReadOnly = True
        txtContact.ReadOnly = True

        btnNew.Enabled = True
        'btnSave.Enabled = False
        btnSave.Enabled = True
        btnEdit.Enabled = True
        'btnUpdate.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = True

    End Sub

  
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        

        If (txtLast.Text.Trim().Length = 0) Then
            MsgBox("Last is empty!")
            txtLast.SelectAll()
            txtLast.Focus()
            Return
        End If

        If (txtFirst.Text.Trim().Length = 0) Then
            MsgBox("First is empty!")
            txtFirst.SelectAll()
            txtFirst.Focus()
            Return
        End If

        If (txtMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle is empty!")
            txtMiddle.SelectAll()
            txtMiddle.Focus()
            Return
        End If

        If (txtAge.Text.Trim().Length = 0) Then
            MsgBox("Age is empty!")
            txtAge.SelectAll()
            txtAge.Focus()
            Return
        End If

        If (txtAddress.Text.Trim().Length = 0) Then
            MsgBox("Address is empty!")
            txtAddress.SelectAll()
            txtAddress.Focus()
            Return
        End If

        If (txtContact.Text.Trim().Length = 0) Then
            MsgBox("Contact is empty!")
            txtContact.SelectAll()
            txtContact.Focus()
            Return
        End If

        If (txtCivilStatus.Text.Trim().Length = 0) Then
            MsgBox("CivilStatus is empty!")
            txtCivilStatus.SelectAll()
            txtCivilStatus.Focus()
            Return
        End If




        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Pregnant Profile info ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "UPDATE PregnantProfile SET Last='" & txtLast.Text.Trim() & "',First='" & txtFirst.Text.Trim() & "',Middle='" & txtMiddle.Text.Trim() & "',Age='" & txtAge.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "',Contact='" & txtContact.Text.Trim() & "',CivilStatus='" & txtCivilStatus.Text.Trim() & "',DayDate='" & dtpDate.Value.ToShortDateString & "',Period='" & dtpPeriod.Value.ToShortDateString & "',PHeight='" & txtPHeight.Text.Trim() & "',PWeight='" & txtPWeight.Text.Trim() & "',ArmsWidth='" & txtArmsWidth.Text.Trim() & "',PVaccine='" & txtPVaccine.Text.Trim() & "',LastVisitDate='" & dtpLastVisitDate.Value.ToShortDateString & "',MonthlyCheckUp='" & dtpMonthlyCheckUp.Value.ToShortDateString & "' " _
                    & "WHERE PregnantID='" & txtPregnantID.Text.Trim() & "'"

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

 
    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnGo.PerformClick()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtLast.Focus()
        txtPregnantID.ReadOnly = True
        txtLast.ReadOnly = False
        txtFirst.ReadOnly = False
        txtMiddle.ReadOnly = False
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtContact.ReadOnly = False

        txtPHeight.ReadOnly = False
        txtPWeight.ReadOnly = False
        txtArmsWidth.ReadOnly = False
        txtPVaccine.ReadOnly = False

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        btnDelete.Enabled = False
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        If (txtSearch.Text.Trim().Length <= 0) Then
            DisplayRecords()
        Else

        End If
    End Sub

    Private Sub txtLast_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLast.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtFirst_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFirst.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtMiddle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMiddle.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtAge_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAge.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtContact_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContact.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub txtCivilStatus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCivilStatus.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub dtpDate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpDate.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub dtpPeriod_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpPeriod.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub DataGridHistory_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Try


            txtPHeight.Text = DataGridPregnants.CurrentRow.Cells(0).Value
            txtPWeight.Text = DataGridPregnants.CurrentRow.Cells(1).Value
            txtArmsWidth.Text = DataGridPregnants.CurrentRow.Cells(2).Value
            txtPVaccine.Text = DataGridPregnants.CurrentRow.Cells(3).Value
            dtpLastVisitDate.Value = DataGridPregnants.CurrentRow.Cells(4).Value
            dtpMonthlyCheckUp.Value = DataGridPregnants.CurrentRow.Cells(5).Value

        Catch ex As Exception

            txtPHeight.Text = ""
            txtPWeight.Text = ""
            txtArmsWidth.Text = ""
            txtPVaccine.Text = ""
            dtpLastVisitDate.Text = ""
            dtpMonthlyCheckUp.Text = ""

        End Try

        txtPHeight.ReadOnly = True
        txtPWeight.ReadOnly = True
        txtArmsWidth.ReadOnly = True
        txtPVaccine.ReadOnly = True

        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = True
    End Sub

 
End Class