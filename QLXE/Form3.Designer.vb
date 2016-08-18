<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkh
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
        Me.btnxoakh = New System.Windows.Forms.Button()
        Me.btnsuakh = New System.Windows.Forms.Button()
        Me.btnthemkh = New System.Windows.Forms.Button()
        Me.dgvkh = New System.Windows.Forms.DataGridView()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtsdt = New System.Windows.Forms.TextBox()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lbldiachi = New System.Windows.Forms.Label()
        Me.lblsdt = New System.Windows.Forms.Label()
        Me.lbltenkh = New System.Windows.Forms.Label()
        Me.lblmakh = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnxoakh
        '
        Me.btnxoakh.Location = New System.Drawing.Point(399, 79)
        Me.btnxoakh.Name = "btnxoakh"
        Me.btnxoakh.Size = New System.Drawing.Size(133, 23)
        Me.btnxoakh.TabIndex = 23
        Me.btnxoakh.Text = "Xóa Sản Phẩm"
        Me.btnxoakh.UseVisualStyleBackColor = True
        '
        'btnsuakh
        '
        Me.btnsuakh.Location = New System.Drawing.Point(399, 43)
        Me.btnsuakh.Name = "btnsuakh"
        Me.btnsuakh.Size = New System.Drawing.Size(133, 23)
        Me.btnsuakh.TabIndex = 22
        Me.btnsuakh.Text = "Sửa Sản Phẩm"
        Me.btnsuakh.UseVisualStyleBackColor = True
        '
        'btnthemkh
        '
        Me.btnthemkh.Location = New System.Drawing.Point(399, 12)
        Me.btnthemkh.Name = "btnthemkh"
        Me.btnthemkh.Size = New System.Drawing.Size(133, 23)
        Me.btnthemkh.TabIndex = 21
        Me.btnthemkh.Text = "Thêm Sản Phẩm"
        Me.btnthemkh.UseVisualStyleBackColor = True
        '
        'dgvkh
        '
        Me.dgvkh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvkh.Location = New System.Drawing.Point(15, 150)
        Me.dgvkh.Name = "dgvkh"
        Me.dgvkh.Size = New System.Drawing.Size(557, 198)
        Me.dgvkh.TabIndex = 20
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(117, 109)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(236, 20)
        Me.txtdiachi.TabIndex = 19
        '
        'txtsdt
        '
        Me.txtsdt.Location = New System.Drawing.Point(117, 76)
        Me.txtsdt.Name = "txtsdt"
        Me.txtsdt.Size = New System.Drawing.Size(236, 20)
        Me.txtsdt.TabIndex = 18
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(117, 43)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(236, 20)
        Me.txttenkh.TabIndex = 17
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(117, 12)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(236, 20)
        Me.txtmakh.TabIndex = 16
        '
        'lbldiachi
        '
        Me.lbldiachi.AutoSize = True
        Me.lbldiachi.Location = New System.Drawing.Point(12, 112)
        Me.lbldiachi.Name = "lbldiachi"
        Me.lbldiachi.Size = New System.Drawing.Size(41, 13)
        Me.lbldiachi.TabIndex = 15
        Me.lbldiachi.Text = "Địa Chỉ"
        '
        'lblsdt
        '
        Me.lblsdt.AutoSize = True
        Me.lblsdt.Location = New System.Drawing.Point(12, 79)
        Me.lblsdt.Name = "lblsdt"
        Me.lblsdt.Size = New System.Drawing.Size(29, 13)
        Me.lblsdt.TabIndex = 14
        Me.lblsdt.Text = "SĐT"
        '
        'lbltenkh
        '
        Me.lbltenkh.AutoSize = True
        Me.lbltenkh.Location = New System.Drawing.Point(12, 46)
        Me.lbltenkh.Name = "lbltenkh"
        Me.lbltenkh.Size = New System.Drawing.Size(89, 13)
        Me.lbltenkh.TabIndex = 13
        Me.lbltenkh.Text = "Tên Khách Hàng"
        '
        'lblmakh
        '
        Me.lblmakh.AutoSize = True
        Me.lblmakh.Location = New System.Drawing.Point(12, 12)
        Me.lblmakh.Name = "lblmakh"
        Me.lblmakh.Size = New System.Drawing.Size(85, 13)
        Me.lblmakh.TabIndex = 12
        Me.lblmakh.Text = "Mã Khách Hàng"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(399, 112)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(133, 23)
        Me.btnexit.TabIndex = 24
        Me.btnexit.Text = "Thoát"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmkh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnxoakh)
        Me.Controls.Add(Me.btnsuakh)
        Me.Controls.Add(Me.btnthemkh)
        Me.Controls.Add(Me.dgvkh)
        Me.Controls.Add(Me.txtdiachi)
        Me.Controls.Add(Me.txtsdt)
        Me.Controls.Add(Me.txttenkh)
        Me.Controls.Add(Me.txtmakh)
        Me.Controls.Add(Me.lbldiachi)
        Me.Controls.Add(Me.lblsdt)
        Me.Controls.Add(Me.lbltenkh)
        Me.Controls.Add(Me.lblmakh)
        Me.Name = "frmkh"
        Me.Text = "Form Khách Hàng"
        CType(Me.dgvkh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnxoakh As System.Windows.Forms.Button
    Friend WithEvents btnsuakh As System.Windows.Forms.Button
    Friend WithEvents btnthemkh As System.Windows.Forms.Button
    Friend WithEvents dgvkh As System.Windows.Forms.DataGridView
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtsdt As System.Windows.Forms.TextBox
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lbldiachi As System.Windows.Forms.Label
    Friend WithEvents lblsdt As System.Windows.Forms.Label
    Friend WithEvents lbltenkh As System.Windows.Forms.Label
    Friend WithEvents lblmakh As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
