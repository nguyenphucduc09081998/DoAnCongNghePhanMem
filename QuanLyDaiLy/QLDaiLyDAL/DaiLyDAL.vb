Imports System.Configuration
Imports System.Data.SqlClient
Imports QLDaiLyDTO
Imports Utility

Public Class DaiLyDAL
    Private connectionString As String
    Public Sub New()
        connectionString = ConfigurationManager.AppSettings("ConnectionString")

    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    ' lay ma dai ly
    Public Function buildMaDL(ByRef nextMaDL As Integer) As Result 'ex: 18222229

        Dim msOnDB As Integer
        Dim query As String = String.Empty
        query &= "SELECT IDENT_CURRENT('DAILY')"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    'Dim msOnDB As String
                    'msOnDB = Nothing

                    If reader.HasRows = True Then
                        While reader.Read()
                            'msOnDB = reader("madg")
                            msOnDB = Convert.ToInt32(reader.GetValue(0))

                        End While
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using

        query = String.Empty
        query &= "SELECT * FROM [DAILY]"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = Convert.ToInt32(reader.GetValue(0))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        query = String.Empty
        query &= "SELECT * FROM [DAILY]"
        'neu has row thi nextMsdg = "SELECT IDENT_CURRENT('DOCGIA')" + 1
        'neu khong co row thì next Msdg = 1;
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        nextMaDL = 1 + msOnDB

                    Else
                        nextMaDL = 1
                    End If
                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số Học sinh kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        nextMaDL += 0
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dl As DaiLyDTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [DAILY] ([TenDL],[DiaChi],[Email],[DienThoai],[NgTiepNhan],[NoCuaDaiLy],[MaQuan],[MaLoaiDL])"
        query &= "VALUES (@TenDL,@DiaChi,@Email,@DienThoai,@NgTiepNhan,@NoCuaDaiLy,@MaQuan,@MaLoaiDL)"
        'get MSDG
        Dim nextMaDL = "1"
        buildMaDL(nextMaDL)
        dl.MaDL = nextMaDL

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@madg", dg.MaDG)
                    .Parameters.AddWithValue("@TenDL", dl.TenDL)
                    .Parameters.AddWithValue("@DiaChi", dl.DiaChi)
                    .Parameters.AddWithValue("@Email", dl.Email)
                    .Parameters.AddWithValue("@DienThoai", dl.DienThoai)
                    .Parameters.AddWithValue("@NgTiepNhan", dl.NgTiepNhan)
                    .Parameters.AddWithValue("@NoCuaDaiLy", dl.NoCuaDaiLy)
                    .Parameters.AddWithValue("@MaQuan", dl.MaQuan)
                    .Parameters.AddWithValue("@MaLoaiDL", dl.MaLoaiDL)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dl As DaiLyDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [DAILY] SET"
        '  query &= " [MaDL] = @MaDL "
        query &= " [TenDL] = @TenDL "
        query &= " ,[DiaChi] = @DiaChi "
        query &= " ,[Email] = @Email "
        query &= " ,[DienThoai] = @DienThoai "
        query &= " ,[NgTiepNhan] = @NgTiepNhan "
        query &= " ,[NoCuaDaiLy] = @NoCuaDaiLy "
        query &= " ,[MaQuan] = @MaQuan "
        query &= " ,[MaLoaiDL] = @MaLoaiDL "
        query &= " WHERE "
        query &= " [MaDL] = @MaDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    '.Parameters.AddWithValue("@MaDL", dl.MaDL)
                    .Parameters.AddWithValue("@TenDL", dl.TenDL)
                    .Parameters.AddWithValue("@DiaChi", dl.DiaChi)
                    .Parameters.AddWithValue("@Email", dl.Email)
                    .Parameters.AddWithValue("@DienThoai", dl.DienThoai)
                    .Parameters.AddWithValue("@NgTiepNhan", dl.NgTiepNhan)
                    .Parameters.AddWithValue("@NoCuaDaiLy", dl.NoCuaDaiLy)
                    .Parameters.AddWithValue("@MaQuan", dl.MaQuan)
                    .Parameters.AddWithValue("@MaLoaiDL", dl.MaLoaiDL)
                    .Parameters.AddWithValue("@MaDL", dl.MaDL)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function


    Public Function delete(maDaiLy As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [DAILY] "
        query &= " WHERE "
        query &= " [MaDL] = @MaDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaDL", maDaiLy)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Đại Lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function



    Public Function selectALL(ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDL], [TenDL], [DiaChi], [Email],[DienThoai],[NgTiepNhan],[NoCuaDaiLy],[MaQuan],[MaLoaiDL]"
        query &= "FROM [DAILY]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function




    Public Function selectALL_ByMaLoaiDL(maLoaidl As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty
        query &= "SELECT [MaDL], [TenDL], [DiaChi], [Email],[DienThoai],[NgTiepNhan],[NoCuaDaiLy],[MaQuan],[MaLoaiDL]"
        query &= "FROM [DAILY] "
        query &= "WHERE [MaLoaiDL] = @MaLoaiDL "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", maLoaidl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Học sinh theo Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function



    Public Function selectmaquan_ByMaDaiLy(madl As Integer, ByRef maquan As Integer) As Result

        Dim query As String = String.Empty
        query &= "SELECT [NoCuaDaiLy]"
        query &= "FROM [DAILY] "
        query &= "WHERE [MaQuan] = @MaQuan "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", madl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        'NoCuaDaiLy.Clear()
                        While reader.Read()
                            maquan = reader("MaQuan")
                            'listPhieuThuTien.Add(New PhieuThuTienDTO(reader("MaPhieuThu"), reader("MaDaiLy"), reader("NgayThuTien"), reader("SoTienThu")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả dai li theo ma dai ly không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function









    '''tra cuuu''''''''''''



    'search theo madl va maquan
    Public Function search_maloaidl_maquan(maloaidl As Integer, maquan As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        query &= "WHERE  [MaLoaiDL] = @MaLoaiDL  and [MaQuan] = @MaQuan"
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", maloaidl)
                    .Parameters.AddWithValue("@MaQuan", maquan)
                    '.Parameters.AddWithValue("@maloaidai", maloaidai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search theo ten
    Public Function selectALL_Search(ten As String, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        ' query &= "WHERE  ( ([MaQuan] =@maquan) or ([MaQuan] = @maquan and [MaLoaiDL] = @maloaidai) ) "
        query &= "WHERE  [TenDL] Like '%" & ten & "%'" '  "
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("ten", ten)
                    '.Parameters.AddWithValue("@maloaidai", maloaidai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search ten va quna
    Public Function selectALL_ten_quan(ten As String, quan As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        ' query &= "WHERE  ( ([MaQuan] =@maquan) or ([MaQuan] = @maquan and [MaLoaiDL] = @maloaidai) ) "
        query &= "WHERE  [TenDL] Like '%" & ten & "%' and [MaQuan] = @MaQuan" '  "
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("ten", ten)
                    .Parameters.AddWithValue("@MaQuan", quan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search theo ma quan
    Public Function search_maquan(maquan As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        query &= "WHERE  [MaQuan] = @MaQuan"
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaQuan", maquan)
                    '.Parameters.AddWithValue("@maloaidai", maloaidai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search ten va loaidl
    Public Function selectALL_ten_loaidl(ten As String, loaidl As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        ' query &= "WHERE  ( ([MaQuan] =@maquan) or ([MaQuan] = @maquan and [MaLoaiDL] = @maloaidai) ) "
        query &= "WHERE  [TenDL] Like '%" & ten & "%' and [MaLoaiDL] = @MaLoaiDL" '  "
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("ten", ten)
                    .Parameters.AddWithValue("@MaLoaiDL", loaidl)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search theo maloaidl
    Public Function search_loaimadl(loaimadl As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        query &= "WHERE  [MaLoaiDL] = @MaLoaiDL"
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaLoaiDL", loaimadl)
                    '.Parameters.AddWithValue("@maloaidai", maloaidai)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    'search theo ten quan va loai
    Public Function selectALL_ten_loaidl_quan(ten As String, quan As Integer, loaidl As Integer, ByRef listDaiLy As List(Of DaiLyDTO)) As Result

        Dim query As String = String.Empty

        query &= "SELECT * "
        query &= "FROM [DAILY]"
        ' query &= "WHERE  ( ([MaQuan] =@maquan) or ([MaQuan] = @maquan and [MaLoaiDL] = @maloaidai) ) "
        query &= "WHERE  [TenDL] Like '%" & ten & "%' and [MaLoaiDL] = @MaLoaiDL and [Quan] = @MaQuan" '  "
        '[MaQuan] =@maquan) or ([MaLoaiDL] = @maloaidai) or
        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("ten", ten)
                    .Parameters.AddWithValue("@MaLoaiDL", loaidl)
                    .Parameters.AddWithValue("@MaQuan", quan)
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then

                        listDaiLy.Clear()
                        While reader.Read()
                            listDaiLy.Add(New DaiLyDTO(reader("MaDL"), reader("TenDL"), reader("DiaChi"), reader("Email"), reader("DienThoai"), reader("NgTiepNhan"), reader("NoCuaDaiLy"), reader("MaQuan"), reader("MaLoaiDL")))
                        End While
                    End If

                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tất cả Đại lý không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function




End Class













