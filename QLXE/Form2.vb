Public Class frmsp
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=RIUSPULL;Initial Catalog=ASM_INF205;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As New DataBaseAccess
    Private Function themsp() As Boolean
        Dim lenhsql As String = "insert into san_pham(Ma_SP, Ten_SP, Ma_chung_loai, Hang_SX)"
        lenhsql += String.Format("values('{0}','{1}','{2}','{3}')", txtmasp.Text, txttensp.Text, txtloaisp.Text, txthangsx.Text)
        Return DBAccess.ExecuteNoneQuery(lenhsql)
    End Function
    Private Function kiemtra() As Boolean
        Return (String.IsNullOrEmpty(txtmasp.Text) OrElse String.IsNullOrEmpty(txttensp.Text) OrElse String.IsNullOrEmpty(txtloaisp.Text) OrElse String.IsNullOrEmpty(txthangsx.Text))
    End Function


    Private Sub frmsp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlquery As String = String.Format("select Ma_SP as 'Mã Sản Phẩm', Ten_SP as 'Tên Sản Phẩm', Ma_chung_loai as 'Mã Chủng Loại', Hang_SX as 'Hãng Sản Xuất' from san_pham")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvsp.DataSource = dtable
    End Sub

    Private Sub btnthemsp_Click(sender As Object, e As EventArgs) Handles btnthemsp.Click
        If kiemtra() Then
            MessageBox.Show("Thiếu dữ liệu", "Error", MessageBoxButtons.OK)
        Else
            If themsp() Then
                MessageBox.Show("Thêm dữ liệu thành công", "OK", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Lỗi", "Error", MessageBoxButtons.OK)
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
        End If
    End Sub

    Private Sub dgvsp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvsp.CellContentClick
        Dim click As Integer = dgvsp.CurrentCell.RowIndex
        txtmasp.Text = dgvsp.Item(0, click).Value
        txttensp.Text = dgvsp.Item(1, click).Value
        txtloaisp.Text = dgvsp.Item(2, click).Value
        txthangsx.Text = dgvsp.Item(3, click).Value
    End Sub

    Private Sub btnsuasp_Click(sender As Object, e As EventArgs) Handles btnsuasp.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update san_pham set Ma_SP=@masp, Ten_SP=@tensp, Ma_chung_loai=@machungloai, Hang_SX=@hangsx where Ma_SP=@masp"
        Dim addupdate As SqlClient.SqlCommand = New SqlClient.SqlCommand(updatequery, conn)
        conn.open()
        If txtmasp.Text = "" Or txttensp.Text = "" Or txthangsx.Text = "" Or txtloaisp.Text = "" Then
            MessageBox.Show("bạn chưa nhập đầy đủ", "Nhập Thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            addupdate.Parameters.AddWithValue("@masp", txtmasp.Text)
            addupdate.Parameters.AddWithValue("@tensp", txttensp.Text)
            addupdate.Parameters.AddWithValue("@machungloai", txtloaisp.Text)
            addupdate.Parameters.AddWithValue("@hangsx", txthangsx.Text)
            conn.close()
            MessageBox.Show("Cập nhật thành công")
        End If
    End Sub

    Private Sub btnxoasp_Click(sender As Object, e As EventArgs) Handles btnxoasp.Click
        Dim delquery As String = "delete from san_pham where Ma_SP=@masp"
        Dim delete As SqlClient.SqlCommand = New SqlClient.SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.open()
        If txtmasp.Text = "" Then
            MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@masp", txtmasp.Text)
                delete.ExecuteNonQuery()
                conn.close()
                MessageBox.Show("Xóa thành công")
            End If
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub
End Class