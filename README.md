# TryTestDDManh_Day6

Ứng dụng ASP.NET Core MVC quản lý **Phim (Movies)** và **Thể loại (Genres)**, dùng Entity Framework Core với SQL Server LocalDB.

## Chức năng
- Thêm, sửa, xóa, xem chi tiết **Genre**: mỗi thể loại hiện số phim và danh sách phim thuộc thể loại đó.
- Thêm, sửa, xóa, xem chi tiết **Movie**: chọn thể loại bằng danh sách thả xuống.
- Quan hệ một-nhiều Genre → Movie (xóa thể loại sẽ xóa luôn các phim thuộc thể loại đó).

## Công nghệ
- .NET 10, ASP.NET Core MVC
- Entity Framework Core 10 (SqlServer, Tools, Design)
- SQL Server LocalDB

## Chạy project
1. Mở `TryTestDDManh_Day6.slnx` bằng Visual Studio.
2. Trong **Package Manager Console**, chạy:
   ```
   Update-Database
   ```
3. Nhấn **F5** để chạy, sau đó vào **Genres** tạo thể loại trước, rồi vào **Movies** để thêm phim.

## Tác giả
Đặng Đức Mạnh
