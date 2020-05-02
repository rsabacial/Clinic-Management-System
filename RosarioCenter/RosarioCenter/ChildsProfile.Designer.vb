<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildsProfile
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DataGridChild = New System.Windows.Forms.DataGridView()
        Me.CLast = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFirst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CMiddle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mother = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Weight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sitio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChildID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMother = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCHeight = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCLast = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCMiddle = New System.Windows.Forms.TextBox()
        Me.txtCFirst = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSitio = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChildID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridChild, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(801, 338)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 225
        Me.Label8.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(878, 334)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(307, 26)
        Me.txtSearch.TabIndex = 224
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(1191, 333)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(61, 29)
        Me.btnGo.TabIndex = 223
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(1305, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(57, 29)
        Me.btnClose.TabIndex = 222
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnDelete.Location = New System.Drawing.Point(475, 311)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(99, 51)
        Me.btnDelete.TabIndex = 221
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnNew.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnNew.Location = New System.Drawing.Point(9, 311)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(99, 51)
        Me.btnNew.TabIndex = 220
        Me.btnNew.TabStop = False
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnSave.Location = New System.Drawing.Point(121, 311)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(99, 51)
        Me.btnSave.TabIndex = 219
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnUpdate.Location = New System.Drawing.Point(361, 311)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 51)
        Me.btnUpdate.TabIndex = 218
        Me.btnUpdate.TabStop = False
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'DataGridChild
        '
        Me.DataGridChild.AllowUserToResizeColumns = False
        Me.DataGridChild.AllowUserToResizeRows = False
        Me.DataGridChild.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridChild.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLast, Me.CFirst, Me.CMiddle, Me.Mother, Me.Weight, Me.CHeight, Me.BirthDate, Me.Address, Me.Sitio, Me.ChildID})
        Me.DataGridChild.Location = New System.Drawing.Point(12, 368)
        Me.DataGridChild.Name = "DataGridChild"
        Me.DataGridChild.ReadOnly = True
        Me.DataGridChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridChild.Size = New System.Drawing.Size(1336, 369)
        Me.DataGridChild.TabIndex = 217
        '
        'CLast
        '
        Me.CLast.HeaderText = "Last Name"
        Me.CLast.Name = "CLast"
        Me.CLast.ReadOnly = True
        Me.CLast.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CLast.ToolTipText = "Reg"
        Me.CLast.Width = 200
        '
        'CFirst
        '
        Me.CFirst.HeaderText = "First Name"
        Me.CFirst.Name = "CFirst"
        Me.CFirst.ReadOnly = True
        Me.CFirst.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CFirst.Width = 200
        '
        'CMiddle
        '
        Me.CMiddle.HeaderText = "Middle Name"
        Me.CMiddle.Name = "CMiddle"
        Me.CMiddle.ReadOnly = True
        Me.CMiddle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CMiddle.Width = 200
        '
        'Mother
        '
        Me.Mother.HeaderText = "Mother"
        Me.Mother.Name = "Mother"
        Me.Mother.ReadOnly = True
        Me.Mother.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Mother.Width = 200
        '
        'Weight
        '
        Me.Weight.HeaderText = "Weight"
        Me.Weight.Name = "Weight"
        Me.Weight.ReadOnly = True
        Me.Weight.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'CHeight
        '
        Me.CHeight.HeaderText = "Height"
        Me.CHeight.Name = "CHeight"
        Me.CHeight.ReadOnly = True
        Me.CHeight.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'BirthDate
        '
        Me.BirthDate.HeaderText = "Date"
        Me.BirthDate.Name = "BirthDate"
        Me.BirthDate.ReadOnly = True
        Me.BirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BirthDate.Width = 150
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Address.Width = 250
        '
        'Sitio
        '
        Me.Sitio.HeaderText = "Sitio"
        Me.Sitio.Name = "Sitio"
        Me.Sitio.ReadOnly = True
        Me.Sitio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Sitio.Width = 200
        '
        'ChildID
        '
        Me.ChildID.HeaderText = "Child ID"
        Me.ChildID.Name = "ChildID"
        Me.ChildID.ReadOnly = True
        Me.ChildID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ChildID.Visible = False
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(699, 65)
        Me.dtpBirthDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(406, 20)
        Me.dtpBirthDate.TabIndex = 213
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(610, 67)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 18)
        Me.Label11.TabIndex = 214
        Me.Label11.Text = "Date"
        '
        'txtMother
        '
        Me.txtMother.AcceptsTab = True
        Me.txtMother.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMother.Location = New System.Drawing.Point(123, 203)
        Me.txtMother.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMother.Name = "txtMother"
        Me.txtMother.ReadOnly = True
        Me.txtMother.Size = New System.Drawing.Size(463, 24)
        Me.txtMother.TabIndex = 205
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 206)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 18)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Mother"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 274)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Height"
        '
        'txtCHeight
        '
        Me.txtCHeight.AcceptsTab = True
        Me.txtCHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCHeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCHeight.Location = New System.Drawing.Point(123, 271)
        Me.txtCHeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCHeight.Name = "txtCHeight"
        Me.txtCHeight.ReadOnly = True
        Me.txtCHeight.Size = New System.Drawing.Size(463, 24)
        Me.txtCHeight.TabIndex = 207
        '
        'txtWeight
        '
        Me.txtWeight.AcceptsTab = True
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(123, 237)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.ReadOnly = True
        Me.txtWeight.Size = New System.Drawing.Size(463, 24)
        Me.txtWeight.TabIndex = 206
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 240)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Weight"
        '
        'txtCLast
        '
        Me.txtCLast.AcceptsTab = True
        Me.txtCLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCLast.Location = New System.Drawing.Point(123, 99)
        Me.txtCLast.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCLast.Name = "txtCLast"
        Me.txtCLast.ReadOnly = True
        Me.txtCLast.Size = New System.Drawing.Size(463, 24)
        Me.txtCLast.TabIndex = 197
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Last Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 169)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 18)
        Me.Label13.TabIndex = 201
        Me.Label13.Text = "Middle Name"
        '
        'txtCMiddle
        '
        Me.txtCMiddle.AcceptsTab = True
        Me.txtCMiddle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMiddle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCMiddle.Location = New System.Drawing.Point(123, 169)
        Me.txtCMiddle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCMiddle.Name = "txtCMiddle"
        Me.txtCMiddle.ReadOnly = True
        Me.txtCMiddle.Size = New System.Drawing.Size(463, 24)
        Me.txtCMiddle.TabIndex = 199
        '
        'txtCFirst
        '
        Me.txtCFirst.AcceptsTab = True
        Me.txtCFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCFirst.Location = New System.Drawing.Point(123, 133)
        Me.txtCFirst.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCFirst.Name = "txtCFirst"
        Me.txtCFirst.ReadOnly = True
        Me.txtCFirst.Size = New System.Drawing.Size(463, 24)
        Me.txtCFirst.TabIndex = 198
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 131)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 18)
        Me.Label14.TabIndex = 200
        Me.Label14.Text = "First Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(611, 136)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 18)
        Me.Label6.TabIndex = 229
        Me.Label6.Text = "Sitio"
        '
        'txtSitio
        '
        Me.txtSitio.AcceptsTab = True
        Me.txtSitio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSitio.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txtSitio.Location = New System.Drawing.Point(699, 133)
        Me.txtSitio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSitio.Name = "txtSitio"
        Me.txtSitio.ReadOnly = True
        Me.txtSitio.Size = New System.Drawing.Size(406, 24)
        Me.txtSitio.TabIndex = 227
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsTab = True
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(699, 99)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(406, 24)
        Me.txtAddress.TabIndex = 226
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(611, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 228
        Me.Label7.Text = "Address"
        '
        'txtChildID
        '
        Me.txtChildID.AcceptsTab = True
        Me.txtChildID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChildID.Location = New System.Drawing.Point(123, 65)
        Me.txtChildID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtChildID.Name = "txtChildID"
        Me.txtChildID.ReadOnly = True
        Me.txtChildID.Size = New System.Drawing.Size(463, 24)
        Me.txtChildID.TabIndex = 230
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "ChildID"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(1258, 333)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 29)
        Me.btnRefresh.TabIndex = 232
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Constantia", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(-1, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 21)
        Me.Label10.TabIndex = 234
        Me.Label10.Text = "Sto. Rosario Health Center"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(544, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(247, 42)
        Me.Label9.TabIndex = 235
        Me.Label9.Text = "Childs Form"
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.PeachPuff
        Me.btnEdit.Location = New System.Drawing.Point(246, 311)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(99, 51)
        Me.btnEdit.TabIndex = 236
        Me.btnEdit.TabStop = False
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'ChildsProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 740)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtChildID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSitio)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DataGridChild)
        Me.Controls.Add(Me.dtpBirthDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtMother)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCLast)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCMiddle)
        Me.Controls.Add(Me.txtCFirst)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChildsProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChildsProfile"
        Me.TopMost = True
        CType(Me.DataGridChild, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Private WithEvents btnNew As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents DataGridChild As System.Windows.Forms.DataGridView
    Friend WithEvents dtpBirthDate As System.Windows.Forms.DateTimePicker
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents txtMother As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCHeight As System.Windows.Forms.TextBox
    Private WithEvents txtWeight As System.Windows.Forms.TextBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtCLast As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label13 As System.Windows.Forms.Label
    Private WithEvents txtCMiddle As System.Windows.Forms.TextBox
    Private WithEvents txtCFirst As System.Windows.Forms.TextBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtSitio As System.Windows.Forms.TextBox
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtChildID As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents CLast As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CFirst As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CMiddle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mother As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Weight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BirthDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sitio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChildID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents btnEdit As System.Windows.Forms.Button
End Class
