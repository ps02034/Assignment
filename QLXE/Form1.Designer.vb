<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.btnsp = New System.Windows.Forms.Button()
        Me.btnkh = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnsp
        '
        Me.btnsp.Location = New System.Drawing.Point(12, 12)
        Me.btnsp.Name = "btnsp"
        Me.btnsp.Size = New System.Drawing.Size(75, 23)
        Me.btnsp.TabIndex = 0
        Me.btnsp.Text = "Sản Phẩm"
        Me.btnsp.UseVisualStyleBackColor = True
        '
        'btnkh
        '
        Me.btnkh.Location = New System.Drawing.Point(93, 12)
        Me.btnkh.Name = "btnkh"
        Me.btnkh.Size = New System.Drawing.Size(75, 23)
        Me.btnkh.TabIndex = 1
        Me.btnkh.Text = "Khách Hàng"
        Me.btnkh.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(174, 12)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(75, 23)
        Me.btnexit.TabIndex = 2
        Me.btnexit.Text = "Thoát"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnkh)
        Me.Controls.Add(Me.btnsp)
        Me.Name = "frmmain"
        Me.Text = "Form Main"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsp As System.Windows.Forms.Button
    Friend WithEvents btnkh As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
