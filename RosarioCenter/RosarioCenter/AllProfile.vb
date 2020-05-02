Imports System
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class AllProfile

    Dim constr As String = "Data Source=DESKTOP-CTCNV5B\SQLEXPRESS;Initial Catalog=CenterRecord;Trusted_Connection=true;"
    Dim myConn As SqlConnection
    Dim rd As SqlDataReader
    Dim cmd As New SqlCommand
    Dim sql As String
    Dim txt As Integer

    Private Sub AllProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myConn = New SqlConnection(constr)

        DisplayRecords()
    End Sub
    Private Sub DisplayRecords()

        Dim count As Integer = 0

        Try

            sql = "SELECT AllID,ALast,AFirst,AMiddle,Birthday,Age,Address,PhilhealthNo,FourPSNo,Gender,Religion,ACivilStatus,HighestEducation,PhoneNo,ADate,HistoryOfPresentIllness,BP,Temp,PR,RR,AWeight,AHeight,Assessment,Treatment FROM AllProfile ORDER BY ALast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridAll.Rows.Clear()
            While rd.Read


                If (count = 0) Then

                    'Me.txtAllID = rd("AllID").ToString
                    txtALast.Text = rd("ALast").ToString
                    txtAFirst.Text = rd("AFirst").ToString
                    txtAMiddle.Text = rd("AMiddle").ToString
                    dtpBirthday.Value = rd("Birthday").ToString
                    txtAge.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtPhilhealthNo.Text = rd("PhilhealthNo").ToString
                    txtFourPSNo.Text = rd("FourPSNo").ToString
                    txtGender.Text = rd("Gender").ToString
                    txtReligion.Text = rd("Religion").ToString
                    txtACivilStatus.Text = rd("ACivilStatus").ToString
                    txtHighestEducation.Text = rd("HighestEducation").ToString
                    txtPhoneNo.Text = rd("PhoneNo").ToString
                    dtpADate.Value = rd("ADate").ToString
                    txtHistoryOfPresentIllness.Text = rd("HistoryOfPresentIllness").ToString
                    txtBP.Text = rd("BP").ToString
                    txtTemp.Text = rd("Temp").ToString
                    txtPR.Text = rd("PR").ToString
                    txtRR.Text = rd("RR").ToString
                    txtAWeight.Text = rd("AWeight").ToString
                    txtAHeight.Text = rd("AHeight").ToString
                    txtAssessment.Text = rd("Assessment").ToString
                    txtTreatment.Text = rd("Treatment").ToString
                End If

                Dim x As Integer = DataGridAll.Rows.Add()

                DataGridAll.Rows(x).Cells(0).Value = rd("AllID").ToString
                DataGridAll.Rows(x).Cells(1).Value = rd("ALast").ToString
                DataGridAll.Rows(x).Cells(2).Value = rd("AFirst").ToString
                DataGridAll.Rows(x).Cells(3).Value = rd("AMiddle").ToString
                DataGridAll.Rows(x).Cells(4).Value = rd("Birthday").ToString
                DataGridAll.Rows(x).Cells(5).Value = rd("Age").ToString
                DataGridAll.Rows(x).Cells(6).Value = rd("Address").ToString
                DataGridAll.Rows(x).Cells(7).Value = rd("PhilhealthNo").ToString
                DataGridAll.Rows(x).Cells(8).Value = rd("FourPSNo").ToString
                DataGridAll.Rows(x).Cells(9).Value = rd("Gender").ToString
                DataGridAll.Rows(x).Cells(10).Value = rd("Religion").ToString
                DataGridAll.Rows(x).Cells(11).Value = rd("ACivilStatus").ToString
                DataGridAll.Rows(x).Cells(12).Value = rd("HighestEducation").ToString
                DataGridAll.Rows(x).Cells(13).Value = rd("PhoneNo").ToString
                DataGridAll.Rows(x).Cells(14).Value = rd("ADate").ToString
                DataGridAll.Rows(x).Cells(15).Value = rd("HistoryOfPresentIllness").ToString
                DataGridAll.Rows(x).Cells(16).Value = rd("BP").ToString
                DataGridAll.Rows(x).Cells(17).Value = rd("Temp").ToString
                DataGridAll.Rows(x).Cells(18).Value = rd("PR").ToString
                DataGridAll.Rows(x).Cells(19).Value = rd("RR").ToString
                DataGridAll.Rows(x).Cells(20).Value = rd("AWeight").ToString
                DataGridAll.Rows(x).Cells(21).Value = rd("AHeight").ToString
                DataGridAll.Rows(x).Cells(22).Value = rd("Assessment").ToString
                DataGridAll.Rows(x).Cells(23).Value = rd("Treatment").ToString

                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        txtAllID.ResetText()
        txtALast.ResetText()
        txtAFirst.ResetText()
        txtAMiddle.ResetText()
        dtpBirthday.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtPhilhealthNo.ResetText()
        txtFourPSNo.ResetText()
        txtGender.ResetText()
        txtReligion.ResetText()
        txtACivilStatus.ResetText()
        txtHighestEducation.ResetText()
        txtPhoneNo.ResetText()
        dtpADate.ResetText()
        txtHistoryOfPresentIllness.ResetText()
        txtBP.ResetText()
        txtTemp.ResetText()
        txtPR.ResetText()
        txtRR.ResetText()
        txtAWeight.ResetText()
        txtAHeight.ResetText()
        txtAssessment.ResetText()
        txtTreatment.ResetText()


        txtAllID.Text = ""
        txtALast.Text = ""
        txtAFirst.Text = ""
        txtAMiddle.Text = ""
        dtpBirthday.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtPhilhealthNo.Text = ""
        txtFourPSNo.Text = ""
        txtGender.Text = ""
        txtReligion.Text = ""
        txtACivilStatus.Text = ""
        txtHighestEducation.Text = ""
        txtPhoneNo.Text = ""
        dtpADate.Text = ""
        txtHistoryOfPresentIllness.Text = ""
        txtBP.Text = ""
        txtTemp.Text = ""
        txtPR.Text = ""
        txtRR.Text = ""
        txtAWeight.Text = ""
        txtAHeight.Text = ""
        txtAssessment.Text = ""
        txtTreatment.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        txtAllID.ResetText()
        txtALast.ResetText()
        txtAFirst.ResetText()
        txtAMiddle.ResetText()
        dtpBirthday.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtPhilhealthNo.ResetText()
        txtFourPSNo.ResetText()
        txtGender.ResetText()
        txtReligion.ResetText()
        txtACivilStatus.ResetText()
        txtHighestEducation.ResetText()
        txtPhoneNo.ResetText()
        dtpADate.ResetText()
        txtHistoryOfPresentIllness.ResetText()
        txtBP.ResetText()
        txtTemp.ResetText()
        txtPR.ResetText()
        txtRR.ResetText()
        txtAWeight.ResetText()
        txtAHeight.ResetText()
        txtAssessment.ResetText()
        txtTreatment.ResetText()

        txtAllID.Text = ""
        txtALast.Text = ""
        txtAFirst.Text = ""
        txtAMiddle.Text = ""
        dtpBirthday.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtPhilhealthNo.Text = ""
        txtFourPSNo.Text = ""
        txtGender.Text = ""
        txtReligion.Text = ""
        txtACivilStatus.Text = ""
        txtHighestEducation.Text = ""
        txtPhoneNo.Text = ""
        dtpADate.Text = ""
        txtHistoryOfPresentIllness.Text = ""
        txtBP.Text = ""
        txtTemp.Text = ""
        txtPR.Text = ""
        txtRR.Text = ""
        txtAWeight.Text = ""
        txtAHeight.Text = ""
        txtAssessment.Text = ""
        txtTreatment.Text = ""

        txtAllID.ReadOnly = True
        txtALast.ReadOnly = False
        txtAFirst.ReadOnly = False
        txtAMiddle.ReadOnly = False
        dtpBirthday.Enabled = True
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtPhilhealthNo.ReadOnly = False
        txtFourPSNo.ReadOnly = False
        txtGender.Enabled = True
        txtReligion.Enabled = True
        txtACivilStatus.Enabled = True
        txtHighestEducation.Enabled = True
        txtPhoneNo.ReadOnly = False
        dtpADate.Enabled = True
        txtBP.ReadOnly = False
        txtTemp.ReadOnly = False
        txtPR.ReadOnly = False
        txtRR.ReadOnly = False
        txtAWeight.ReadOnly = False
        txtAHeight.ReadOnly = False
        txtHistoryOfPresentIllness.ReadOnly = False
        txtAssessment.ReadOnly = False
        txtTreatment.ReadOnly = False

        txtALast.Focus()

        btnNew.Enabled = False
        btnEdit.Enabled = False
        btnUpdate.Enabled = False
        btnSave.Enabled = True
        btnDelete.Enabled = False
        txtALast.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If (txtALast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtALast.SelectAll()
            txtALast.Focus()
            Return
        End If

        If (txtAFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtAFirst.SelectAll()
            txtAFirst.Focus()
            Return
        End If

        If (txtAMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtAMiddle.SelectAll()
            txtAMiddle.Focus()
            Return
        End If


        If (dtpBirthday.Text.Trim().Length = 0) Then
            MsgBox("Birthday is empty!")
            dtpBirthday.Select()
            dtpBirthday.Focus()
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

        If (txtPhilhealthNo.Text.Trim().Length = 0) Then
            MsgBox("PhilHealth # is empty!")
            txtPhilhealthNo.SelectAll()
            txtPhilhealthNo.Focus()
            Return
        End If

        If (txtFourPSNo.Text.Trim().Length = 0) Then
            MsgBox("NHTS/MCCT/4PS # is empty!")
            txtFourPSNo.SelectAll()
            txtFourPSNo.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If

        If (txtReligion.Text.Trim().Length = 0) Then
            MsgBox("Religion is empty!")
            txtReligion.SelectAll()
            txtReligion.Focus()
            Return
        End If


        If (txtACivilStatus.Text.Trim().Length = 0) Then
            MsgBox("CivilStatus is empty!")
            txtACivilStatus.SelectAll()
            txtACivilStatus.Focus()
            Return
        End If

        If (txtHighestEducation.Text.Trim().Length = 0) Then
            MsgBox("HighestEducation is empty!")
            txtHighestEducation.SelectAll()
            txtHighestEducation.Focus()
            Return
        End If

        If (txtPhoneNo.Text.Trim().Length = 0) Then
            MsgBox("Phone # is empty!")
            txtPhoneNo.SelectAll()
            txtPhoneNo.Focus()
            Return
        End If

        If (dtpADate.Text.Trim().Length = 0) Then
            MsgBox("Date is empty!")
            dtpADate.Select()
            dtpADate.Focus()
            Return
        End If

        If (txtHistoryOfPresentIllness.Text.Trim().Length = 0) Then
            MsgBox("History Of Present Illness is empty!")
            txtHistoryOfPresentIllness.SelectAll()
            txtHistoryOfPresentIllness.Focus()
            Return
        End If

        If (txtBP.Text.Trim().Length = 0) Then
            MsgBox("BP is empty!")
            txtBP.SelectAll()
            txtBP.Focus()
            Return
        End If

        If (txtTemp.Text.Trim().Length = 0) Then
            MsgBox("Temp is empty!")
            txtTemp.SelectAll()
            txtTemp.Focus()
            Return
        End If


        If (txtPR.Text.Trim().Length = 0) Then
            MsgBox("PR is empty!")
            txtPR.SelectAll()
            txtPR.Focus()
            Return
        End If

        If (txtRR.Text.Trim().Length = 0) Then
            MsgBox("RR is empty!")
            txtRR.SelectAll()
            txtRR.Focus()
            Return
        End If

        If (txtAWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtAWeight.SelectAll()
            txtAWeight.Focus()
            Return
        End If

        If (txtAHeight.Text.Trim().Length = 0) Then
            MsgBox("Height is empty!")
            txtAHeight.SelectAll()
            txtAHeight.Focus()
            Return
        End If

        If (txtAssessment.Text.Trim().Length = 0) Then
            MsgBox("Assessment/Impression is empty!")
            txtAssessment.SelectAll()
            txtAssessment.Focus()
            Return
        End If

        If (txtTreatment.Text.Trim().Length = 0) Then
            MsgBox("Treatment/Management Plan is empty!")
            txtTreatment.SelectAll()
            txtTreatment.Focus()
            Return
        End If



        Dim result As DialogResult _
            = MessageBox.Show("Do you want to save this new Profile?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "INSERT  INTO AllProfile (ALast,AFirst,AMiddle,Birthday,Age,Address,PhilhealthNo,FourPSNo,Gender,Religion,ACivilStatus,HighestEducation,PhoneNo,ADate,HistoryOfPresentIllness,BP,Temp,PR,RR,AWeight,AHeight,Assessment,Treatment) VALUES ('" & txtALast.Text.Trim() & "'," _
                    & "'" & txtAFirst.Text.Trim() & "','" & txtAMiddle.Text.Trim() & "','" & dtpBirthday.Value.ToShortDateString & "','" & txtAge.Text.Trim() & "'," _
                     & "'" & txtAddress.Text.Trim() & "','" & txtPhilhealthNo.Text.Trim() & "','" & txtFourPSNo.Text.Trim() & "','" & txtGender.Text.Trim() & "'," _
                      & "'" & txtReligion.Text.Trim() & "','" & txtACivilStatus.Text.Trim() & "','" & txtHighestEducation.Text.Trim() & "','" & txtPhoneNo.Text.Trim() & "'," _
                       & "'" & dtpADate.Value.ToShortDateString & "','" & txtHistoryOfPresentIllness.Text.Trim() & "','" & txtBP.Text.Trim() & "','" & txtTemp.Text.Trim() & "'," _
                    & "'" & txtPR.Text.Trim() & "','" & txtRR.Text.Trim() & "','" & txtAWeight.Text.Trim() & "','" & txtAHeight.Text.Trim() & "','" & txtAssessment.Text.Trim() & "','" & txtTreatment.Text.Trim() & "')"

                cmd = New SqlCommand(sql, myConn)
                myConn.Open()

                cmd.ExecuteNonQuery()

                myConn.Close()
                DisplayRecords()
                MsgBox("Successfully saved!", MsgBoxStyle.Information)

                txtALast.ResetText()
                txtAFirst.ResetText()
                txtAMiddle.ResetText()
                dtpBirthday.ResetText()
                txtAge.ResetText()
                txtAddress.ResetText()
                txtPhilhealthNo.ResetText()
                txtFourPSNo.ResetText()
                txtGender.ResetText()
                txtReligion.ResetText()
                txtACivilStatus.ResetText()
                txtHighestEducation.ResetText()
                txtPhoneNo.ResetText()
                dtpADate.ResetText()
                txtHistoryOfPresentIllness.ResetText()
                txtBP.ResetText()
                txtTemp.ResetText()
                txtPR.ResetText()
                txtRR.ResetText()
                txtAWeight.ResetText()
                txtAHeight.ResetText()
                txtAssessment.ResetText()
                txtTreatment.ResetText()

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
        If (txtALast.Text.Trim().Length = 0) Then
            MsgBox("Last name is empty!")
            txtALast.SelectAll()
            txtALast.Focus()
            Return
        End If

        If (txtAFirst.Text.Trim().Length = 0) Then
            MsgBox("First name is empty!")
            txtAFirst.SelectAll()
            txtAFirst.Focus()
            Return
        End If

        If (txtAMiddle.Text.Trim().Length = 0) Then
            MsgBox("Middle name is empty!")
            txtAMiddle.SelectAll()
            txtAMiddle.Focus()
            Return
        End If

        If (dtpBirthday.Text.Trim().Length = 0) Then
            MsgBox("Birthday is empty!")
            dtpBirthday.Select()
            dtpBirthday.Focus()
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

        If (txtPhilhealthNo.Text.Trim().Length = 0) Then
            MsgBox("PhilhealthNo # is empty!")
            txtPhilhealthNo.SelectAll()
            txtPhilhealthNo.Focus()
            Return
        End If

        If (txtFourPSNo.Text.Trim().Length = 0) Then
            MsgBox("NHTS/MCCT/4PS # is empty!")
            txtFourPSNo.SelectAll()
            txtFourPSNo.Focus()
            Return
        End If

        If (txtGender.Text.Trim().Length = 0) Then
            MsgBox("Gender is empty!")
            txtGender.SelectAll()
            txtGender.Focus()
            Return
        End If

        If (txtReligion.Text.Trim().Length = 0) Then
            MsgBox("Religion is empty!")
            txtReligion.SelectAll()
            txtReligion.Focus()
            Return
        End If

        If (txtACivilStatus.Text.Trim().Length = 0) Then
            MsgBox("Civil Status is empty!")
            txtACivilStatus.SelectAll()
            txtACivilStatus.Focus()
            Return
        End If

        If (txtHighestEducation.Text.Trim().Length = 0) Then
            MsgBox("Highest Education is empty!")
            txtHighestEducation.SelectAll()
            txtHighestEducation.Focus()
            Return
        End If

        If (txtPhoneNo.Text.Trim().Length = 0) Then
            MsgBox("Phone # is empty!")
            txtPhoneNo.SelectAll()
            txtPhoneNo.Focus()
            Return
        End If

        If (dtpADate.Text.Trim().Length = 0) Then
            MsgBox("CivilStatus is empty!")
            dtpADate.Select()
            dtpADate.Focus()
            Return
        End If

        If (txtHistoryOfPresentIllness.Text.Trim().Length = 0) Then
            MsgBox("History Of Present Illness is empty!")
            txtHistoryOfPresentIllness.SelectAll()
            txtHistoryOfPresentIllness.Focus()
            Return
        End If

        If (txtBP.Text.Trim().Length = 0) Then
            MsgBox("BP is empty!")
            txtBP.SelectAll()
            txtBP.Focus()
            Return
        End If

        If (txtTemp.Text.Trim().Length = 0) Then
            MsgBox("Temp is empty!")
            txtTemp.SelectAll()
            txtTemp.Focus()
            Return
        End If

        If (txtPR.Text.Trim().Length = 0) Then
            MsgBox("PR is empty!")
            txtPR.SelectAll()
            txtPR.Focus()
            Return
        End If

        If (txtRR.Text.Trim().Length = 0) Then
            MsgBox("RR is empty!")
            txtRR.SelectAll()
            txtRR.Focus()
            Return
        End If

        If (txtAWeight.Text.Trim().Length = 0) Then
            MsgBox("Weight is empty!")
            txtAWeight.SelectAll()
            txtAWeight.Focus()
            Return
        End If

        If (txtAHeight.Text.Trim().Length = 0) Then
            MsgBox("Height is empty!")
            txtAHeight.SelectAll()
            txtAHeight.Focus()
            Return
        End If

        If (txtAssessment.Text.Trim().Length = 0) Then
            MsgBox("Assessment is empty!")
            txtAssessment.SelectAll()
            txtAssessment.Focus()
            Return
        End If

        If (txtTreatment.Text.Trim().Length = 0) Then
            MsgBox("Treatment is empty!")
            txtTreatment.SelectAll()
            txtTreatment.Focus()
            Return
        End If




        Dim result As DialogResult _
            = MessageBox.Show("Do you want to update Pregnant Profile info ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "UPDATE AllProfile SET ALast='" & txtALast.Text.Trim() & "',AFirst='" & txtAFirst.Text.Trim() & "',AMiddle='" & txtAMiddle.Text.Trim() & "',Birthday='" & dtpBirthday.Value.ToShortDateString & "',Age='" & txtAge.Text.Trim() & "',Address='" & txtAddress.Text.Trim() & "',PhilhealthNo='" & txtPhilhealthNo.Text.Trim() & "',FourPSNo='" & txtFourPSNo.Text.Trim() & "',Gender='" & txtGender.Text.Trim() & "',Religion='" & txtReligion.Text.Trim() & "',ACivilStatus='" & txtACivilStatus.Text.Trim() & "',HighestEducation='" & txtHighestEducation.Text.Trim() & "',PhoneNo='" & txtPhoneNo.Text.Trim() & "',ADate='" & dtpADate.Value.ToShortDateString & "',HistoryOfPresentIllness='" & txtHistoryOfPresentIllness.Text.Trim() & "',BP='" & txtBP.Text.Trim() & "',Temp='" & txtTemp.Text.Trim() & "',PR='" & txtPR.Text.Trim() & "',RR='" & txtRR.Text.Trim() & "',AWeight='" & txtAWeight.Text.Trim() & "',AHeight='" & txtAHeight.Text.Trim() & "',Assessment='" & txtAssessment.Text.Trim() & "',Treatment='" & txtTreatment.Text.Trim() & "' " _
                    & "WHERE AllID='" & txtAllID.Text.Trim() & "'"

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
        ' txtALast.Focus()
        'txtAllID.ReadOnly = True
        ' txtALast.ReadOnly = False
        'txtAFirst.ReadOnly = False
        'txtAMiddle.ReadOnly = False
        ' txtAge.ReadOnly = False
        ' txtAddress.ReadOnly = False
        ' txtPhilhealthNo.ReadOnly = False
        'txtFourPSNo.ReadOnly = False
        'txtPhoneNo.ReadOnly = False
        'txtHistoryOfPresentIllness.ReadOnly = False
        'txtBP.ReadOnly = False
        ' txtTemp.ReadOnly = False
        ' txtPR.ReadOnly = False
        ' txtRR.ReadOnly = False
        ' txtAWeight.ReadOnly = False
        ' txtAHeight.ReadOnly = False
        'txtAssessment.ReadOnly = False
        'txtTreatment.ReadOnly = False

        btnNew.Enabled = True
        btnSave.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If (txtALast.Text.Trim().Length = 0) Then
            MsgBox("LastName is empty!")
            txtALast.SelectAll()
            txtALast.Focus()
            Return
        End If

        If (txtAFirst.Text.Trim().Length = 0) Then
            MsgBox("FirstName is empty!")
            txtAFirst.SelectAll()
            txtAFirst.Focus()
            Return
        End If

        If (txtAMiddle.Text.Trim().Length = 0) Then
            MsgBox("MiddleName is empty!")
            txtAMiddle.SelectAll()
            txtAMiddle.Focus()
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





        Dim result As DialogResult _
            = MessageBox.Show("Do you want to delete this Profile ?", _
              "Save!", MessageBoxButtons.YesNo, _
              MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            Try

                sql = "Delete From AllProfile Where AllID='" & txtAllID.Text.Trim() & "'"

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
        txtAllID.ResetText()
        txtALast.ResetText()
        txtAFirst.ResetText()
        txtAMiddle.ResetText()
        dtpBirthday.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtPhilhealthNo.ResetText()
        txtFourPSNo.ResetText()
        txtGender.ResetText()
        txtReligion.ResetText()
        txtACivilStatus.ResetText()
        txtHighestEducation.ResetText()
        txtPhoneNo.ResetText()
        dtpADate.ResetText()
        txtHistoryOfPresentIllness.ResetText()
        txtBP.ResetText()
        txtTemp.ResetText()
        txtPR.ResetText()
        txtRR.ResetText()
        txtAWeight.ResetText()
        txtAHeight.ResetText()
        txtAssessment.ResetText()
        txtTreatment.ResetText()

        txtAllID.Text = ""
        txtALast.Text = ""
        txtAFirst.Text = ""
        txtAMiddle.Text = ""
        dtpBirthday.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtPhilhealthNo.Text = ""
        txtFourPSNo.Text = ""
        txtGender.Text = ""
        txtReligion.Text = ""
        txtACivilStatus.Text = ""
        txtHighestEducation.Text = ""
        txtPhoneNo.Text = ""
        dtpADate.Text = ""
        txtHistoryOfPresentIllness.Text = ""
        txtBP.Text = ""
        txtTemp.Text = ""
        txtPR.Text = ""
        txtRR.Text = ""
        txtAWeight.Text = ""
        txtAHeight.Text = ""
        txtAssessment.Text = ""
        txtTreatment.Text = ""
    End Sub

    Private Sub DataGridAll_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridAll.SelectionChanged
        Try

            txtAllID.Text = DataGridAll.CurrentRow.Cells(0).Value
            txtALast.Text = DataGridAll.CurrentRow.Cells(1).Value
            txtAFirst.Text = DataGridAll.CurrentRow.Cells(2).Value
            txtAMiddle.Text = DataGridAll.CurrentRow.Cells(3).Value
            dtpBirthday.Value = DataGridAll.CurrentRow.Cells(4).Value
            txtAge.Text = DataGridAll.CurrentRow.Cells(5).Value
            txtAddress.Text = DataGridAll.CurrentRow.Cells(6).Value
            txtPhilhealthNo.Text = DataGridAll.CurrentRow.Cells(7).Value
            txtFourPSNo.Text = DataGridAll.CurrentRow.Cells(8).Value
            txtGender.Text = DataGridAll.CurrentRow.Cells(9).Value
            txtReligion.Text = DataGridAll.CurrentRow.Cells(10).Value
            txtACivilStatus.Text = DataGridAll.CurrentRow.Cells(11).Value
            txtHighestEducation.Text = DataGridAll.CurrentRow.Cells(12).Value
            txtPhoneNo.Text = DataGridAll.CurrentRow.Cells(13).Value
            dtpADate.Text = DataGridAll.CurrentRow.Cells(14).Value
            txtHistoryOfPresentIllness.Text = DataGridAll.CurrentRow.Cells(15).Value
            txtBP.Text = DataGridAll.CurrentRow.Cells(16).Value
            txtTemp.Text = DataGridAll.CurrentRow.Cells(17).Value
            txtPR.Text = DataGridAll.CurrentRow.Cells(18).Value
            txtRR.Text = DataGridAll.CurrentRow.Cells(19).Value
            txtAWeight.Text = DataGridAll.CurrentRow.Cells(20).Value
            txtAHeight.Text = DataGridAll.CurrentRow.Cells(21).Value
            txtAssessment.Text = DataGridAll.CurrentRow.Cells(22).Value
            txtTreatment.Text = DataGridAll.CurrentRow.Cells(23).Value




        Catch ex As Exception


            txtALast.Text = ""
            txtAFirst.Text = ""
            txtAMiddle.Text = ""
            dtpBirthday.Text = ""
            txtAge.Text = ""
            txtAddress.Text = ""
            txtPhilhealthNo.Text = ""
            txtFourPSNo.Text = ""
            txtGender.Text = ""
            txtReligion.Text = ""
            txtACivilStatus.Text = ""
            txtHighestEducation.Text = ""
            txtPhoneNo.Text = ""
            dtpADate.Text = ""
            txtHistoryOfPresentIllness.Text = ""
            txtBP.Text = ""
            txtTemp.Text = ""
            txtPR.Text = ""
            txtRR.Text = ""
            txtAWeight.Text = ""
            txtAHeight.Text = ""
            txtAssessment.Text = ""
            txtTreatment.Text = ""
            txtAllID.Text = ""
        End Try


        txtAllID.ReadOnly = True
        txtALast.ReadOnly = True
        txtAFirst.ReadOnly = True
        txtAMiddle.ReadOnly = True
        dtpBirthday.Enabled = False
        txtAge.ReadOnly = True
        txtAddress.ReadOnly = True
        txtPhilhealthNo.ReadOnly = True
        txtFourPSNo.ReadOnly = True
        txtGender.Enabled = False
        txtReligion.Enabled = False
        txtACivilStatus.Enabled = False
        txtHighestEducation.Enabled = False
        txtPhoneNo.ReadOnly = True
        dtpADate.Enabled = False
        txtBP.ReadOnly = True
        txtTemp.ReadOnly = True
        txtPR.ReadOnly = True
        txtRR.ReadOnly = True
        txtAWeight.ReadOnly = True
        txtAHeight.ReadOnly = True
        txtHistoryOfPresentIllness.ReadOnly = True
        txtAssessment.ReadOnly = True
        txtTreatment.ReadOnly = True

        Label2.Visible = True
        txtAllID.Visible = True

        btnNew.Enabled = True
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = True
    End Sub

    Private Sub txtSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnGo.PerformClick()
        End If
    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim count As Integer = 0
        myConn.Close()
        sql = "SELECT AllID,ALast,AFirst,AMiddle,Birthday,Age,Address,PhilhealthNo,FourPSNo,Gender,Religion,ACivilStatus,HighestEducation,PhoneNo,ADate,HistoryOfPresentIllness,BP,Temp,PR,RR,AWeight,AHeight,Assessment,Treatment FROM AllProfile WHERE ALast LIKE'%" & txtSearch.Text.Trim() & "%' ORDER BY ALast"
        cmd = New SqlCommand(sql, myConn)
        myConn.Open()
        rd = cmd.ExecuteReader
        DataGridAll.Rows.Clear()
        While rd.Read
            If (count = 0) Then

                txtAllID.Text = rd("AllID").ToString
                txtALast.Text = rd("ALast").ToString
                txtAFirst.Text = rd("AFirst").ToString
                txtAMiddle.Text = rd("AMiddle").ToString
                dtpBirthday.Value = rd("Birthday").ToString
                txtAge.Text = rd("Age").ToString
                txtAddress.Text = rd("Address").ToString
                txtPhilhealthNo.Text = rd("PhilhealthNo").ToString
                txtFourPSNo.Text = rd("FourPSNo").ToString
                txtGender.Text = rd("Gender").ToString
                txtReligion.Text = rd("Religion").ToString
                txtACivilStatus.Text = rd("ACivilStatus").ToString
                txtHighestEducation.Text = rd("HighestEducation").ToString
                txtPhoneNo.Text = rd("PhoneNo").ToString
                dtpADate.Value = rd("ADate").ToString
                txtHistoryOfPresentIllness.Text = rd("HistoryOfPresentIllness").ToString
                txtBP.Text = rd("BP").ToString
                txtTemp.Text = rd("Temp").ToString
                txtPR.Text = rd("PR").ToString
                txtRR.Text = rd("RR").ToString
                txtAWeight.Text = rd("AWeight").ToString
                txtAHeight.Text = rd("AHeight").ToString
                txtAssessment.Text = rd("Assessment").ToString
                txtTreatment.Text = rd("Treatment").ToString



            End If

            Dim x As Integer = DataGridAll.Rows.Add()
            DataGridAll.Rows(x).Cells(0).Value = rd("ALast").ToString
            DataGridAll.Rows(x).Cells(1).Value = rd("AFirst").ToString
            DataGridAll.Rows(x).Cells(2).Value = rd("AMiddle").ToString
            DataGridAll.Rows(x).Cells(3).Value = rd("Birthday").ToString
            DataGridAll.Rows(x).Cells(4).Value = rd("Age").ToString
            DataGridAll.Rows(x).Cells(5).Value = rd("Address").ToString
            DataGridAll.Rows(x).Cells(6).Value = rd("PhilhealthNo").ToString
            DataGridAll.Rows(x).Cells(7).Value = rd("FourPSNo").ToString
            DataGridAll.Rows(x).Cells(8).Value = rd("Gender").ToString
            DataGridAll.Rows(x).Cells(9).Value = rd("Religion").ToString
            DataGridAll.Rows(x).Cells(10).Value = rd("ACivilStatus").ToString
            DataGridAll.Rows(x).Cells(11).Value = rd("HighestEducation").ToString
            DataGridAll.Rows(x).Cells(12).Value = rd("PhoneNo").ToString
            DataGridAll.Rows(x).Cells(13).Value = rd("ADate").ToString
            DataGridAll.Rows(x).Cells(14).Value = rd("HistoryOfPresentIllness").ToString
            DataGridAll.Rows(x).Cells(15).Value = rd("BP").ToString
            DataGridAll.Rows(x).Cells(16).Value = rd("Temp").ToString
            DataGridAll.Rows(x).Cells(17).Value = rd("PR").ToString
            DataGridAll.Rows(x).Cells(18).Value = rd("RR").ToString
            DataGridAll.Rows(x).Cells(19).Value = rd("AWeight").ToString
            DataGridAll.Rows(x).Cells(20).Value = rd("AHeight").ToString
            DataGridAll.Rows(x).Cells(21).Value = rd("Assessment").ToString
            DataGridAll.Rows(x).Cells(22).Value = rd("Treatment").ToString
            DataGridAll.Rows(x).Cells(23).Value = rd("AllID").ToString

            count = count + 1

        End While
        myConn.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim count As Integer = 0

        Try


            sql = "SELECT ALast,AFirst,AMiddle,Birthday,Age,Address,PhilhealthNo,FourPSNo,Gender,Religion,ACivilStatus,HighestEducation,PhoneNo,ADate,HistoryOfPresentIllness,BP,Temp,PR,RR,AWeight,AHeight,Assessment,Treatment From AllProfile order by ALast"

            cmd = New SqlCommand(sql, myConn)
            myConn.Open()
            rd = cmd.ExecuteReader
            DataGridAll.Rows.Clear()
            While rd.Read


                If (count = 0) Then


                    txtALast.Text = rd("ALast").ToString
                    txtAFirst.Text = rd("AFirst").ToString
                    txtAMiddle.Text = rd("AMiddle").ToString
                    dtpBirthday.Value = rd("Birthday").ToString
                    txtAge.Text = rd("Age").ToString
                    txtAddress.Text = rd("Address").ToString
                    txtPhilhealthNo.Text = rd("PhilhealthNo").ToString
                    txtFourPSNo.Text = rd("FourPSNo").ToString
                    txtGender.Text = rd("Gender").ToString
                    txtReligion.Text = rd("Religion").ToString
                    txtACivilStatus.Text = rd("ACivilStatus").ToString
                    txtHighestEducation.Text = rd("HighestEducation").ToString
                    txtPhoneNo.Text = rd("PhoneNo").ToString
                    dtpADate.Value = rd("ADate").ToString
                    txtHistoryOfPresentIllness.Text = rd("HistoryOfPresentIllness").ToString
                    txtBP.Text = rd("BP").ToString
                    txtTemp.Text = rd("Temp").ToString
                    txtPR.Text = rd("PR").ToString
                    txtRR.Text = rd("RR").ToString
                    txtAWeight.Text = rd("AWeight").ToString
                    txtAHeight.Text = rd("AHeight").ToString
                    txtAssessment.Text = rd("Assessment").ToString
                    txtTreatment.Text = rd("Treatment").ToString


                End If

                Dim x As Integer = DataGridAll.Rows.Add()





                DataGridAll.Rows(x).Cells(0).Value = rd("ALast").ToString
                DataGridAll.Rows(x).Cells(1).Value = rd("AFirst").ToString
                DataGridAll.Rows(x).Cells(2).Value = rd("AMiddle").ToString
                DataGridAll.Rows(x).Cells(3).Value = rd("Birthday").ToString
                DataGridAll.Rows(x).Cells(4).Value = rd("Age").ToString
                DataGridAll.Rows(x).Cells(5).Value = rd("Address").ToString
                DataGridAll.Rows(x).Cells(6).Value = rd("PhilhealthNo").ToString
                DataGridAll.Rows(x).Cells(7).Value = rd("FourPSNo").ToString
                DataGridAll.Rows(x).Cells(8).Value = rd("Gender").ToString
                DataGridAll.Rows(x).Cells(9).Value = rd("Religion").ToString
                DataGridAll.Rows(x).Cells(10).Value = rd("ACivilStatus").ToString
                DataGridAll.Rows(x).Cells(11).Value = rd("HighestEducation").ToString
                DataGridAll.Rows(x).Cells(12).Value = rd("PhoneNo").ToString
                DataGridAll.Rows(x).Cells(13).Value = rd("ADate").ToString
                DataGridAll.Rows(x).Cells(14).Value = rd("HistoryOfPresentIllness").ToString
                DataGridAll.Rows(x).Cells(15).Value = rd("BP").ToString
                DataGridAll.Rows(x).Cells(16).Value = rd("Temp").ToString
                DataGridAll.Rows(x).Cells(17).Value = rd("PR").ToString
                DataGridAll.Rows(x).Cells(18).Value = rd("RR").ToString
                DataGridAll.Rows(x).Cells(19).Value = rd("AWeight").ToString
                DataGridAll.Rows(x).Cells(20).Value = rd("AHeight").ToString
                DataGridAll.Rows(x).Cells(21).Value = rd("Assessment").ToString
                DataGridAll.Rows(x).Cells(22).Value = rd("Treatment").ToString




                count = count + 1

            End While
            myConn.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        txtAllID.ResetText()
        txtALast.ResetText()
        txtAFirst.ResetText()
        txtAMiddle.ResetText()
        dtpBirthday.ResetText()
        txtAge.ResetText()
        txtAddress.ResetText()
        txtPhilhealthNo.ResetText()
        txtFourPSNo.ResetText()
        txtGender.ResetText()
        txtReligion.ResetText()
        txtACivilStatus.ResetText()
        txtHighestEducation.ResetText()
        txtPhoneNo.ResetText()
        dtpADate.ResetText()
        txtHistoryOfPresentIllness.ResetText()
        txtBP.ResetText()
        txtTemp.ResetText()
        txtPR.ResetText()
        txtRR.ResetText()
        txtAWeight.ResetText()
        txtAHeight.ResetText()
        txtAssessment.ResetText()
        txtTreatment.ResetText()
        txtSearch.ResetText()



        txtALast.Text = ""
        txtAFirst.Text = ""
        txtAMiddle.Text = ""
        dtpBirthday.Text = ""
        txtAge.Text = ""
        txtAddress.Text = ""
        txtPhilhealthNo.Text = ""
        txtFourPSNo.Text = ""
        txtGender.Text = ""
        txtReligion.Text = ""
        txtACivilStatus.Text = ""
        txtHighestEducation.Text = ""
        txtPhoneNo.Text = ""
        dtpADate.Text = ""
        txtHistoryOfPresentIllness.Text = ""
        txtBP.Text = ""
        txtTemp.Text = ""
        txtPR.Text = ""
        txtRR.Text = ""
        txtAWeight.Text = ""
        txtAHeight.Text = ""
        txtAssessment.Text = ""
        txtTreatment.Text = ""
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        txtALast.Focus()
        txtAllID.ReadOnly = True
        txtALast.ReadOnly = False
        txtAFirst.ReadOnly = False
        txtAMiddle.ReadOnly = False
        dtpBirthday.Enabled = True
        txtAge.ReadOnly = False
        txtAddress.ReadOnly = False
        txtPhilhealthNo.ReadOnly = False
        txtFourPSNo.ReadOnly = False
        txtGender.Enabled = True
        txtReligion.Enabled = True
        txtACivilStatus.Enabled = True
        txtHighestEducation.Enabled = True
        txtPhoneNo.ReadOnly = False
        dtpADate.Enabled = True
        txtBP.ReadOnly = False
        txtTemp.ReadOnly = False
        txtPR.ReadOnly = False
        txtRR.ReadOnly = False
        txtAWeight.ReadOnly = False
        txtAHeight.ReadOnly = False
        txtHistoryOfPresentIllness.ReadOnly = False
        txtAssessment.ReadOnly = False
        txtTreatment.ReadOnly = False

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

    Private Sub DataGridAll_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridAll.CellClick


    End Sub
End Class