Public Class frmkh
    Dim db As New DataTable
    Dim chuoiketnoi As String = "Data Source=RIUSPULL;Initial Catalog=ASM_INF205;Integrated Security=True"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private DBAccess As New DataBaseAccess
    Private Function themsp() As Boolean
        Dim lenhsql As String = "insert into Khach_hang(Ma_KH, Ten_KH, SDT, Dia_chi)"
        lenhsql += String.Format("values('{0}','{1}','{2}','{3}')", txtmakh.Text, txttenkh.Text, txtsdt.Text, txtdiachi.Text)
        Return DBAccess.ExecuteNoneQuery(lenhsql)
    End Function
    Private Function kiemtra() As Boolean
        Return (String.IsNullOrEmpty(txtmakh.Text) OrElse String.IsNullOrEmpty(txttenkh.Text) OrElse String.IsNullOrEmpty(txtsdt.Text) OrElse String.IsNullOrEmpty(txtdiachi.Text))
    End Function
    Private Sub frmkh_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sqlquery As String = String.Format("select Ma_KH as 'Mã Khách Hàng', Ten_KH as 'Tên Khách Hàng', SDT as 'SĐT', Dia_chi as 'Địa Chỉ' from Khach_hang")
        Dim dtable As DataTable = DBAccess.GetDataTable(sqlquery)
        Me.dgvkh.DataSource = dtable
    End Sub

    Private Sub btnthemkh_Click(sender As Object, e As EventArgs) Handles btnthemkh.Click
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

    Private Sub dgvkh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvkh.CellContentClick
        Dim click As Integer = dgvkh.CurrentCell.RowIndex
        txtmakh.Text = dgvkh.Item(0, click).Value
        txttenkh.Text = dgvkh.Item(1, click).Value
        txtsdt.Text = dgvkh.Item(2, click).Value
        txtdiachi.Text = dgvkh.Item(3, click).Value
    End Sub

    Private Sub btnsuakh_Click(sender As Object, e As EventArgs) Handles btnsuakh.Click
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim updatequery As String = "update Khach_hang set Ma_KH=@makh, Ten_KH=@tenkh, SDT=@SDT, Dia_chi=@diachi where Ma_KH=@makh"
        Dim addupdate As SqlClient.SqlCommand = New SqlClient.SqlCommand(updatequery, conn)
        conn.open()
        If txtmakh.Text = "" Or txttenkh.Text = "" Or txtsdt.Text = "" Or txtdiachi.Text = "" Then
            MessageBox.Show("bạn chưa nhập đầy đủ", "Nhập Thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            addupdate.Parameters.AddWithValue("@masp", txtmakh.Text)
            addupdate.Parameters.AddWithValue("@tensp", txttenkh.Text)
            addupdate.Parameters.AddWithValue("@machungloai", txtsdt.Text)
            addupdate.Parameters.AddWithValue("@hangsx", txtdiachi.Text)
            conn.close()
            MessageBox.Show("Cập nhật thành công")
        End If
    End Sub

    Private Sub btnxoakh_Click(sender As Object, e As EventArgs) Handles btnxoakh.Click
        Dim delquery As String = "delete from san_pham where Ma_SP=@masp"
        Dim delete As SqlClient.SqlCommand = New SqlClient.SqlCommand(delquery, conn)
        Dim resulft As DialogResult = MessageBox.Show("Bạn có muốn xóa không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        conn.open()
        If txtmakh.Text = "" Then
            MessageBox.Show("Bạn cần nhập mã khách hàng", "Nhập thiếu", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        Else
            If resulft = Windows.Forms.DialogResult.Yes Then
                delete.Parameters.AddWithValue("@masp", txtmakh.Text)
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