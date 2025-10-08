<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtMaSV = New TextBox()
        txtNgaySinh = New TextBox()
        txtHoTen = New TextBox()
        txtGioiTinh = New TextBox()
        txtMaPhong = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnThem = New Button()
        btnSua = New Button()
        btnXoa = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtMaSV
        ' 
        txtMaSV.Location = New Point(243, 147)
        txtMaSV.Name = "txtMaSV"
        txtMaSV.Size = New Size(404, 27)
        txtMaSV.TabIndex = 0
        ' 
        ' txtNgaySinh
        ' 
        txtNgaySinh.Location = New Point(243, 242)
        txtNgaySinh.Name = "txtNgaySinh"
        txtNgaySinh.Size = New Size(404, 27)
        txtNgaySinh.TabIndex = 1
        ' 
        ' txtHoTen
        ' 
        txtHoTen.Location = New Point(243, 195)
        txtHoTen.Name = "txtHoTen"
        txtHoTen.Size = New Size(404, 27)
        txtHoTen.TabIndex = 2
        ' 
        ' txtGioiTinh
        ' 
        txtGioiTinh.Location = New Point(243, 285)
        txtGioiTinh.Name = "txtGioiTinh"
        txtGioiTinh.Size = New Size(404, 27)
        txtGioiTinh.TabIndex = 3
        ' 
        ' txtMaPhong
        ' 
        txtMaPhong.Location = New Point(243, 330)
        txtMaPhong.Name = "txtMaPhong"
        txtMaPhong.Size = New Size(404, 27)
        txtMaPhong.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(130, 150)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 5
        Label1.Text = "Mã sinh viên"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(130, 198)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 6
        Label2.Text = "Họ tên"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(130, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 7
        Label3.Text = "Ngày sinh"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(130, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 8
        Label4.Text = "Giới tính"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(130, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 20)
        Label5.TabIndex = 9
        Label5.Text = "Mã phòng"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(672, 147)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 10
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnSua
        ' 
        btnSua.Location = New Point(672, 194)
        btnSua.Name = "btnSua"
        btnSua.Size = New Size(94, 29)
        btnSua.TabIndex = 11
        btnSua.Text = "Sửa"
        btnSua.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(672, 241)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 12
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(139, 49)
        Label6.Name = "Label6"
        Label6.Size = New Size(520, 54)
        Label6.TabIndex = 13
        Label6.Text = "Phần mềm quản lý sinh viên"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 455)
        Controls.Add(Label6)
        Controls.Add(btnXoa)
        Controls.Add(btnSua)
        Controls.Add(btnThem)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtMaPhong)
        Controls.Add(txtGioiTinh)
        Controls.Add(txtHoTen)
        Controls.Add(txtNgaySinh)
        Controls.Add(txtMaSV)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtMaSV As TextBox
    Friend WithEvents txtNgaySinh As TextBox
    Friend WithEvents txtHoTen As TextBox
    Friend WithEvents txtGioiTinh As TextBox
    Friend WithEvents txtMaPhong As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnSua As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label6 As Label

End Class
