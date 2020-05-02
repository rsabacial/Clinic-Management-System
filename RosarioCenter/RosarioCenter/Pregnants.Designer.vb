<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pregnants
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridPregnants = New System.Windows.Forms.DataGridView()
        Me.Last = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArmsWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVaccine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Period = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastVisitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyCheckUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpPeriod = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMiddle = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCivilStatus = New System.Windows.Forms.ComboBox()
        Me.txtPregnantID = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtPHeight = New System.Windows.Forms.TextBox()
        Me.txtPWeight = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtArmsWidth = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtPVaccine = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpLastVisitDate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpMonthlyCheckUp = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtHistoryOfPresentIllness = New System.Windows.Forms.RichTextBox()
        Me.DataGridHistory = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridPregnants, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridPregnants
        '
        Me.DataGridPregnants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPregnants.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Last, Me.First, Me.Middle, Me.Age, Me.Address, Me.Contact, Me.CivilStatus, Me.PHeight, Me.PWeight, Me.ArmsWidth, Me.PVaccine, Me.DayDate, Me.Period, Me.LastVisitDate, Me.MonthlyCheckUp, Me.column1})
        Me.DataGridPregnants.Location = New System.Drawing.Point(13, 453)
        Me.DataGridPregnants.Name = "DataGridPregnants"
        Me.DataGridPregnants.ReadOnly = True
        Me.DataGridPregnants.RowHeadersWidth = 25
        Me.DataGridPregnants.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DataGridPregnants.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridPregnants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPregnants.Size = New System.Drawing.Size(1335, 287)
        Me.DataGridPregnants.TabIndex = 188
        '
        'Last
        '
        Me.Last.HeaderText = "Last Name"
        Me.Last.Name = "Last"
        Me.Last.ReadOnly = True
        Me.Last.Width = 200
        '
        'First
        '
        Me.First.HeaderText = "First Name"
        Me.First.Name = "First"
        Me.First.ReadOnly = True
        Me.First.Width = 200
        '
        'Middle
        '
        Me.Middle.HeaderText = "Middle Name"
        Me.Middle.Name = "Middle"
        Me.Middle.ReadOnly = True
        Me.Middle.Width = 150
        '
        'Age
        '
        Me.Age.HeaderText = "Age"
        Me.Age.Name = "Age"
        Me.Age.ReadOnly = True
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Width = 250
        '
        'Contact
        '
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        Me.Contact.Width = 150
        '
        'CivilStatus
        '
        Me.CivilStatus.HeaderText = "Civil Status"
        Me.CivilStatus.Name = "CivilStatus"
        Me.CivilStatus.ReadOnly = True
        Me.CivilStatus.Width = 150
        '
        'PHeight
        '
        Me.PHeight.HeaderText = "Height"
        Me.PHeight.Name = "PHeight"
        Me.PHeight.ReadOnly = True
        '
        'PWeight
        '
        Me.PWeight.HeaderText = "Weight"
        Me.PWeight.Name = "PWeight"
        Me.PWeight.ReadOnly = True
        '
        'ArmsWidth
        '
        Me.ArmsWidth.HeaderText = "Arms Width"
        Me.ArmsWidth.Name = "ArmsWidth"
        Me.ArmsWidth.ReadOnly = True
        '
        'PVaccine
        '
        Me.PVaccine.HeaderText = "Vaccine"
        Me.PVaccine.Name = "PVaccine"
        Me.PVaccine.ReadOnly = True
        '
        'DayDate
        '
        Me.DayDate.HeaderText = "Date"
        Me.DayDate.Name = "DayDate"
        Me.DayDate.ReadOnly = True
        Me.DayDate.Width = 200
        '
        'Period
        '
        Me.Period.HeaderText = "Last Menstrual Period"
        Me.Period.Name = "Period"
        Me.Period.ReadOnly = True
        Me.Period.Width = 250
        '
        'LastVisitDate
        '
        Me.LastVisitDate.HeaderText = "Last Visit Date"
        Me.LastVisitDate.Name = "LastVisitDate"
        Me.LastVisitDate.ReadOnly = True
        '
        'MonthlyCheckUp
        '
        Me.MonthlyCheckUp.HeaderText = "Monthly Check-Up"
        Me.MonthlyCheckUp.Name = "MonthlyCheckUp"
        Me.MonthlyCheckUp.ReadOnly = True
        '
        'column1
        '
        Me.column1.HeaderText = "Pregnant ID"
        Me.column1.Name = "column1"
        Me.column1.ReadOnly = True
        Me.column1.Visible = False
        '
        'dtpPeriod
        '
        Me.dtpPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPeriod.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPeriod.Location = New System.Drawing.Point(649, 90)
        Me.dtpPeriod.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpPeriod.Name = "dtpPeriod"
        Me.dtpPeriod.Size = New System.Drawing.Size(164, 24)
        Me.dtpPeriod.TabIndex = 186
        Me.dtpPeriod.Value = New Date(2017, 9, 27, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 91)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 18)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Last Menstrual Period"
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(565, 62)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(248, 24)
        Me.dtpDate.TabIndex = 184
        Me.dtpDate.Value = New Date(2017, 9, 27, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(473, 62)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 18)
        Me.Label11.TabIndex = 185
        Me.Label11.Text = "Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 242)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 183
        Me.Label7.Text = "Civil Status"
        '
        'txtAge
        '
        Me.txtAge.AcceptsTab = True
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(122, 160)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(339, 24)
        Me.txtAge.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 163)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 18)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 214)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Contact"
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsTab = True
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(122, 186)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(339, 24)
        Me.txtAddress.TabIndex = 177
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 189)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 18)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "Address"
        '
        'txtLast
        '
        Me.txtLast.AcceptsTab = True
        Me.txtLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLast.Location = New System.Drawing.Point(122, 83)
        Me.txtLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.ReadOnly = True
        Me.txtLast.Size = New System.Drawing.Size(339, 24)
        Me.txtLast.TabIndex = 168
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 86)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 175
        Me.Label4.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "PregnantID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 137)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 18)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = "Middle Name"
        '
        'txtMiddle
        '
        Me.txtMiddle.AcceptsTab = True
        Me.txtMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMiddle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMiddle.Location = New System.Drawing.Point(122, 134)
        Me.txtMiddle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMiddle.Name = "txtMiddle"
        Me.txtMiddle.ReadOnly = True
        Me.txtMiddle.Size = New System.Drawing.Size(339, 24)
        Me.txtMiddle.TabIndex = 170
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 112)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 18)
        Me.Label14.TabIndex = 171
        Me.Label14.Text = "First Name"
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Location = New System.Drawing.Point(13, 396)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 51)
        Me.btnNew.TabIndex = 191
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnSave.Location = New System.Drawing.Point(122, 396)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 51)
        Me.btnSave.TabIndex = 190
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnUpdate.Location = New System.Drawing.Point(334, 396)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 51)
        Me.btnUpdate.TabIndex = 189
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClose.Location = New System.Drawing.Point(1288, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 29)
        Me.btnClose.TabIndex = 193
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnDelete.Location = New System.Drawing.Point(443, 396)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(99, 51)
        Me.btnDelete.TabIndex = 192
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(744, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(826, 410)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(365, 26)
        Me.txtSearch.TabIndex = 195
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(1197, 409)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(62, 29)
        Me.btnGo.TabIndex = 194
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1265, 409)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 29)
        Me.btnRefresh.TabIndex = 233
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(365, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(342, 42)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "Pregnant Women"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Constantia", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 21)
        Me.Label10.TabIndex = 236
        Me.Label10.Text = "Sto. Rosario Health Care Center"
        '
        'txtCivilStatus
        '
        Me.txtCivilStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCivilStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCivilStatus.FormattingEnabled = True
        Me.txtCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        Me.txtCivilStatus.Location = New System.Drawing.Point(122, 239)
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.Size = New System.Drawing.Size(337, 26)
        Me.txtCivilStatus.TabIndex = 238
        '
        'txtPregnantID
        '
        Me.txtPregnantID.AcceptsTab = True
        Me.txtPregnantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregnantID.Location = New System.Drawing.Point(122, 56)
        Me.txtPregnantID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPregnantID.Name = "txtPregnantID"
        Me.txtPregnantID.ReadOnly = True
        Me.txtPregnantID.Size = New System.Drawing.Size(339, 24)
        Me.txtPregnantID.TabIndex = 266
        '
        'txtContact
        '
        Me.txtContact.AcceptsTab = True
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(122, 211)
        Me.txtContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(339, 24)
        Me.txtContact.TabIndex = 267
        '
        'txtFirst
        '
        Me.txtFirst.AcceptsTab = True
        Me.txtFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(122, 109)
        Me.txtFirst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.ReadOnly = True
        Me.txtFirst.Size = New System.Drawing.Size(339, 24)
        Me.txtFirst.TabIndex = 268
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(227, 396)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 51)
        Me.btnEdit.TabIndex = 269
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtPHeight
        '
        Me.txtPHeight.AcceptsTab = True
        Me.txtPHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHeight.Location = New System.Drawing.Point(122, 268)
        Me.txtPHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPHeight.Name = "txtPHeight"
        Me.txtPHeight.ReadOnly = True
        Me.txtPHeight.Size = New System.Drawing.Size(337, 24)
        Me.txtPHeight.TabIndex = 320
        '
        'txtPWeight
        '
        Me.txtPWeight.AcceptsTab = True
        Me.txtPWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPWeight.Location = New System.Drawing.Point(122, 292)
        Me.txtPWeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPWeight.Name = "txtPWeight"
        Me.txtPWeight.ReadOnly = True
        Me.txtPWeight.Size = New System.Drawing.Size(337, 24)
        Me.txtPWeight.TabIndex = 315
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 291)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 18)
        Me.Label22.TabIndex = 319
        Me.Label22.Text = "Weight"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(17, 267)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 18)
        Me.Label23.TabIndex = 318
        Me.Label23.Text = "Height"
        '
        'txtArmsWidth
        '
        Me.txtArmsWidth.AcceptsTab = True
        Me.txtArmsWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArmsWidth.Location = New System.Drawing.Point(120, 326)
        Me.txtArmsWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtArmsWidth.Name = "txtArmsWidth"
        Me.txtArmsWidth.ReadOnly = True
        Me.txtArmsWidth.Size = New System.Drawing.Size(337, 24)
        Me.txtArmsWidth.TabIndex = 316
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(17, 313)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(95, 18)
        Me.Label24.TabIndex = 317
        Me.Label24.Text = "Arms Width"
        '
        'txtPVaccine
        '
        Me.txtPVaccine.AcceptsTab = True
        Me.txtPVaccine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPVaccine.Location = New System.Drawing.Point(130, 351)
        Me.txtPVaccine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPVaccine.Name = "txtPVaccine"
        Me.txtPVaccine.ReadOnly = True
        Me.txtPVaccine.Size = New System.Drawing.Size(327, 24)
        Me.txtPVaccine.TabIndex = 321
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 338)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 18)
        Me.Label12.TabIndex = 322
        Me.Label12.Text = "Given Vaccine"
        '
        'dtpLastVisitDate
        '
        Me.dtpLastVisitDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLastVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLastVisitDate.Location = New System.Drawing.Point(622, 115)
        Me.dtpLastVisitDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpLastVisitDate.Name = "dtpLastVisitDate"
        Me.dtpLastVisitDate.Size = New System.Drawing.Size(191, 24)
        Me.dtpLastVisitDate.TabIndex = 325
        Me.dtpLastVisitDate.Value = New Date(2017, 9, 27, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(473, 115)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 18)
        Me.Label15.TabIndex = 326
        Me.Label15.Text = "Last Visit Date"
        '
        'dtpMonthlyCheckUp
        '
        Me.dtpMonthlyCheckUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMonthlyCheckUp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpMonthlyCheckUp.Location = New System.Drawing.Point(622, 145)
        Me.dtpMonthlyCheckUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpMonthlyCheckUp.Name = "dtpMonthlyCheckUp"
        Me.dtpMonthlyCheckUp.Size = New System.Drawing.Size(191, 24)
        Me.dtpMonthlyCheckUp.TabIndex = 323
        Me.dtpMonthlyCheckUp.Value = New Date(2017, 9, 27, 0, 0, 0, 0)
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(473, 145)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(141, 18)
        Me.Label16.TabIndex = 324
        Me.Label16.Text = "Monthly Check Up"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(821, 41)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 18)
        Me.Label17.TabIndex = 328
        Me.Label17.Text = "Check-Up History :"
        '
        'txtHistoryOfPresentIllness
        '
        Me.txtHistoryOfPresentIllness.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHistoryOfPresentIllness.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtHistoryOfPresentIllness.Location = New System.Drawing.Point(468, 172)
        Me.txtHistoryOfPresentIllness.Name = "txtHistoryOfPresentIllness"
        Me.txtHistoryOfPresentIllness.Size = New System.Drawing.Size(345, 203)
        Me.txtHistoryOfPresentIllness.TabIndex = 329
        Me.txtHistoryOfPresentIllness.Text = ""
        '
        'DataGridHistory
        '
        Me.DataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridHistory.Location = New System.Drawing.Point(819, 62)
        Me.DataGridHistory.Name = "DataGridHistory"
        Me.DataGridHistory.ReadOnly = True
        Me.DataGridHistory.RowHeadersWidth = 25
        Me.DataGridHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DataGridHistory.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridHistory.Size = New System.Drawing.Size(529, 313)
        Me.DataGridHistory.TabIndex = 330
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Height"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Weight"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Arms Width"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Given Vaccine"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Last Visit Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 250
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monthly Check-Up"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Pregnants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 740)
        Me.Controls.Add(Me.DataGridHistory)
        Me.Controls.Add(Me.txtHistoryOfPresentIllness)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpLastVisitDate)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.dtpMonthlyCheckUp)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtPVaccine)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPHeight)
        Me.Controls.Add(Me.txtPWeight)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtArmsWidth)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.txtPregnantID)
        Me.Controls.Add(Me.txtCivilStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridPregnants)
        Me.Controls.Add(Me.dtpPeriod)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLast)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtMiddle)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pregnants"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pregnants"
        Me.TopMost = True
        CType(Me.DataGridPregnants, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridPregnants As System.Windows.Forms.DataGridView
    Friend WithEvents dtpPeriod As System.Windows.Forms.DateTimePicker
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtAge As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtLast As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents txtMiddle As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCivilStatus As System.Windows.Forms.ComboBox
    Private WithEvents txtPregnantID As System.Windows.Forms.TextBox
    Private WithEvents txtContact As System.Windows.Forms.TextBox
    Private WithEvents txtFirst As System.Windows.Forms.TextBox
    Private WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents PregnantID As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents txtPHeight As System.Windows.Forms.TextBox
    Private WithEvents txtPWeight As System.Windows.Forms.TextBox
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents txtArmsWidth As System.Windows.Forms.TextBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents txtPVaccine As System.Windows.Forms.TextBox
    Private WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpLastVisitDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpMonthlyCheckUp As System.Windows.Forms.DateTimePicker
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents txtHistoryOfPresentIllness As System.Windows.Forms.RichTextBox
    Friend WithEvents Last As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Middle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contact As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CivilStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PHeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArmsWidth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVaccine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DayDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Period As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastVisitDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthlyCheckUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridHistory As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
