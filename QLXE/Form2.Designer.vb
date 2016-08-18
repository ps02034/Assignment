<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsp
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
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lbltensp = New System.Windows.Forms.Label()
        Me.lblloaisp = New System.Windows.Forms.Label()
        Me.lblhangsx = New System.Windows.Forms.Label()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtloaisp = New System.Windows.Forms.TextBox()
        Me.txthangsx = New System.Windows.Forms.TextBox()
        Me.dgvsp = New System.Windows.Forms.DataGridView()
        Me.btnthemsp = New System.Windows.Forms.Button()
        Me.btnsuasp = New System.Windows.Forms.Button()
        Me.btnxoasp = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblmasp
        '
        Me.lblmasp.AutoSize = True
        Me.lblmasp.Location = New System.Drawing.Point(12, 13)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(74, 13)
        Me.lblmasp.TabIndex = 0
        Me.lblmasp.Text = "Mã Sản Phẩm"
        '
        'lbltensp
        '
        Me.lbltensp.AutoSize = True
        Me.lbltensp.Location = New System.Drawing.Point(12, 47)
        Me.lbltensp.Name = "lbltensp"
        Me.lbltensp.Size = New System.Drawing.Size(78, 13)
        Me.lbltensp.TabIndex = 1
        Me.lbltensp.Text = "Tên Sản Phẩm"
        '
        'lblloaisp
        '
        Me.lblloaisp.AutoSize = True
        Me.lblloaisp.Location = New System.Drawing.Point(12, 80)
        Me.lblloaisp.Name = "lblloaisp"
        Me.lblloaisp.Size = New System.Drawing.Size(79, 13)
        Me.lblloaisp.TabIndex = 2
        Me.lblloaisp.Text = "Loại Sản Phẩm"
        '
        'lblhangsx
        '
        Me.lblhangsx.AutoSize = True
        Me.lblhangsx.Location = New System.Drawing.Point(12, 113)
        Me.lblhangsx.Name = "lblhangsx"
        Me.lblhangsx.Size = New System.Drawing.Size(80, 13)
        Me.lblhangsx.TabIndex = 3
        Me.lblhangsx.Text = "Hãng Sản Xuất"
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(117, 13)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(236, 20)
        Me.txtmasp.TabIndex = 4
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(117, 44)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(236, 20)
        Me.txttensp.TabIndex = 5
        '
        'txtloaisp
        '
        Me.txtloaisp.Location = New System.Drawing.Point(117, 77)
        Me.txtloaisp.Name = "txtloaisp"
        Me.txtloaisp.Size = New System.Drawing.Size(236, 20)
        Me.txtloaisp.TabIndex = 6
        '
        'txthangsx
        '
        Me.txthangsx.Location = New System.Drawing.Point(117, 110)
        Me.txthangsx.Name = "txthangsx"
        Me.txthangsx.Size = New System.Drawing.Size(236, 20)
        Me.txthangsx.TabIndex = 7
        '
        'dgvsp
        '
        Me.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsp.Location = New System.Drawing.Point(15, 151)
        Me.dgvsp.Name = "dgvsp"
        Me.dgvsp.Size = New System.Drawing.Size(557, 198)
        Me.dgvsp.TabIndex = 8
        '
        'btnthemsp
        '
        Me.btnthemsp.Location = New System.Drawing.Point(399, 13)
        Me.btnthemsp.Name = "btnthemsp"
        Me.btnthemsp.Size = New System.Drawing.Size(133, 23)
        Me.btnthemsp.TabIndex = 9
        Me.btnthemsp.Text = "Thêm Sản Phẩm"
        Me.btnthemsp.UseVisualStyleBackColor = True
        '
        'btnsuasp
        '
        Me.btnsuasp.Location = New System.Drawing.Point(399, 47)
        Me.btnsuasp.Name = "btnsuasp"
        Me.btnsuasp.Size = New System.Drawing.Size(133, 23)
        Me.btnsuasp.TabIndex = 10
        Me.btnsuasp.Text = "Sửa Sản Phẩm"
        Me.btnsuasp.UseVisualStyleBackColor = True
        '
        'btnxoasp
        '
        Me.btnxoasp.Location = New System.Drawing.Point(399, 80)
        Me.btnxoasp.Name = "btnxoasp"
        Me.btnxoasp.Size = New System.Drawing.Size(133, 23)
        Me.btnxoasp.TabIndex = 11
        Me.btnxoasp.Text = "Xóa Sản Phẩm"
        Me.btnxoasp.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(399, 113)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(133, 23)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = "Thoát"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmsp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnxoasp)
        Me.Controls.Add(Me.btnsuasp)
        Me.Controls.Add(Me.btnthemsp)
        Me.Controls.Add(Me.dgvsp)
        Me.Controls.Add(Me.txthangsx)
        Me.Controls.Add(Me.txtloaisp)
        Me.Controls.Add(Me.txttensp)
        Me.Controls.Add(Me.txtmasp)
        Me.Controls.Add(Me.lblhangsx)
        Me.Controls.Add(Me.lblloaisp)
        Me.Controls.Add(Me.lbltensp)
        Me.Controls.Add(Me.lblmasp)
        Me.Name = "frmsp"
        Me.Text = "Form Sản Phẩm"
        CType(Me.dgvsp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents lbltensp As System.Windows.Forms.Label
    Friend WithEvents lblloaisp As System.Windows.Forms.Label
    Friend WithEvents lblhangsx As System.Windows.Forms.Label
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtloaisp As System.Windows.Forms.TextBox
    Friend WithEvents txthangsx As System.Windows.Forms.TextBox
    Friend WithEvents dgvsp As System.Windows.Forms.DataGridView
    Friend WithEvents btnthemsp As System.Windows.Forms.Button
    Friend WithEvents btnsuasp As System.Windows.Forms.Button
    Friend WithEvents btnxoasp As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
