Public Class frmmain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnsp_Click(sender As Object, e As EventArgs) Handles btnsp.Click
        frmsp.Show()
    End Sub

    Private Sub btnkh_Click(sender As Object, e As EventArgs) Handles btnkh.Click
        frmkh.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class
