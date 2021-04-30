### Trần Nguyễn Đức Huy - 19520604

# Bài 01
![Bài 01](https://github.com/revirven/Network-Programming.Lab-03/blob/4aea827e65ed50f3aa69a615375adb402307d213/Screenshots/Bai01.png)

- Phía Client:
	- Kiểm tra Port và IP, nếu không hợp lệ thì báo lỗi
	- Nếu IP và Port hợp lệ, chuyển message tại TextBox sang kiểu dữ liệu byte rồi gửi đi
	- Đóng kết nối

- Phía Server:
	- Tạo 1 thread mới, tại đó kiểm tra tính hợp lệ của Port rồi bắt đầu listen tại Port đó
	- Nếu có dữ liệu được gửi tới, chuyển dữ liệu từ byte sang string sau đó in ra ListView
	- Khi đóng form, socket cũng sẽ được đóng để ngừng chiếm dụng Endpoint

# Bài 02
![Bài 02](https://github.com/revirven/Network-Programming.Lab-03/blob/4aea827e65ed50f3aa69a615375adb402307d213/Screenshots/Bai02.png)

- Tạo thread mới, tại đó kiểm tra Endpoint và bắt đầu listen tại Endpoint đó
- Accept kết nối từ phía Client, bắt đầu nhận dữ liệu
- Chuyển dữ liệu từ byte sang string và in ra ListView
- Khi đóng form, listenerSocket cũng sẽ được đóng để ngừng chiếm dụng Endpoint 

# Bài 03
![Bài 03](https://github.com/revirven/Network-Programming.Lab-03/blob/4aea827e65ed50f3aa69a615375adb402307d213/Screenshots/Bai03.png)

- Phía Client:
	- Kiểm tra và kết nối đến Endpoint định sẵn (127.0.0.1:8080)
	- Khi được chấp nhận kết nối, bắt đầu gửi dữ liệu thông qua Network Stream
	- Sau khi gửi dữ liệu, đóng kết nối và Network Stream.

- Phía Server:
	- Tương tự như bài 02

# Bài 04
![Bài 04](https://github.com/revirven/Network-Programming.Lab-03/blob/4aea827e65ed50f3aa69a615375adb402307d213/Screenshots/Bai04.png)

- Phía Client:
	- Kiểm tra và kết nối đến Endpoint định sẵn (127.0.0.1:8080)
	- Khi được chấp nhận kết nối, gửi tên người dùng cho Server
	- Mở 1 thread riêng biệt để nhận dữ liệu từ Server
	- Tiến hành trao đổi dữ liệu thông qua Network Stream
	- Khi đóng form, đóng kết nối để ngừng gửi và nhận dữ liệu

- Phía Server:
	- Tạo 1 thread dành riêng cho việc lắng nghe kết nối
	- Khi chấp nhận kết nối, ứng với mỗi kết nối, tạo 1 thread mới để xử lý kết nối đó
	- Tại mỗi TcpClient, nhận dữ liệu và broadcast tới các TcpClient khác thông qua Network Stream
	- Khi đóng form, dừng việc lắng nghe và đóng listenerSocket để ngừng chiếm dụng Endpoint