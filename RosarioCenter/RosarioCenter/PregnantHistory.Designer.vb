<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PregnantHistory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DataGridHistory = New System.Windows.Forms.DataGridView()
        Me.PHeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PWeight = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArmsWidth = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PVaccine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastVisitDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthlyCheckUp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtPregnantID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 159)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(152, 18)
        Me.Label17.TabIndex = 330
        Me.Label17.Text = "Check-Up History :"
        '
        'DataGridHistory
        '
        Me.DataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridHistory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PHeight, Me.PWeight, Me.ArmsWidth, Me.PVaccine, Me.LastVisitDate, Me.MonthlyCheckUp})
        Me.DataGridHistory.Location = New System.Drawing.Point(12, 180)
        Me.DataGridHistory.Name = "DataGridHistory"
        Me.DataGridHistory.ReadOnly = True
        Me.DataGridHistory.RowHeadersWidth = 25
        Me.DataGridHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.SeaShell
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkCyan
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DataGridHistory.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridHistory.Size = New System.Drawing.Size(840, 298)
        Me.DataGridHistory.TabIndex = 329
        '
        'PHeight
        '
        Me.PHeight.HeaderText = "Height"
        Me.PHeight.Name = "PHeight"
        Me.PHeight.ReadOnly = True
        Me.PHeight.Width = 200
        '
        'PWeight
        '
        Me.PWeight.HeaderText = "Weight"
        Me.PWeight.Name = "PWeight"
        Me.PWeight.ReadOnly = True
        Me.PWeight.Width = 200
        '
        'ArmsWidth
        '
        Me.ArmsWidth.HeaderText = "Arms Width"
        Me.ArmsWidth.Name = "ArmsWidth"
        Me.ArmsWidth.ReadOnly = True
        Me.ArmsWidth.Width = 150
        '
        'PVaccine
        '
        Me.PVaccine.HeaderText = "Given Vaccine"
        Me.PVaccine.Name = "PVaccine"
        Me.PVaccine.ReadOnly = True
        '
        'LastVisitDate
        '
        Me.LastVisitDate.HeaderText = "Last Visit Date"
        Me.LastVisitDate.Name = "LastVisitDate"
        Me.LastVisitDate.ReadOnly = True
        Me.LastVisitDate.Width = 250
        '
        'MonthlyCheckUp
        '
        Me.MonthlyCheckUp.HeaderText = "Monthly Check-Up"
        Me.MonthlyCheckUp.Name = "MonthlyCheckUp"
        Me.MonthlyCheckUp.ReadOnly = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(764, 147)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(90, 29)
        Me.btnRefresh.TabIndex = 334
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(243, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 333
        Me.Label8.Text = "Search :"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(325, 148)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(365, 26)
        Me.txtSearch.TabIndex = 332
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(696, 147)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(62, 29)
        Me.btnGo.TabIndex = 331
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtPregnantID
        '
        Me.txtPregnantID.AcceptsTab = True
        Me.txtPregnantID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPregnantID.Location = New System.Drawing.Point(118, 14)
        Me.txtPregnantID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPregnantID.Name = "txtPregnantID"
        Me.txtPregnantID.ReadOnly = True
        Me.txtPregnantID.Size = New System.Drawing.Size(341, 24)
        Me.txtPregnantID.TabIndex = 336
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 335
        Me.Label2.Text = "PregnantID"
        '
        'PregnantHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 490)
        Me.Controls.Add(Me.txtPregnantID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.DataGridHistory)
        Me.Name = "PregnantHistory"
        Me.Text = "PregnantHistory"
        CType(Me.DataGridHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents DataGridHistory As System.Windows.Forms.DataGridView
    Friend WithEvents PHeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PWeight As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArmsWidth As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PVaccine As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastVisitDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthlyCheckUp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Private WithEvents txtPregnantID As System.Windows.Forms.TextBox
    Private WithEvents Label2 As System.Windows.Forms.Label
End Class
