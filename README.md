### Bài 1
- In thông tin cá nhân.
- In thông tin lớp học.

### Bài 2
- Nhập tên sản phẩm.
- Nhập số lượng.
- Nhập đơn giá.
- Tính tổng tiền.

### Bài 3
- Nhập năm sinh.
- Tính tuổi gần đúng.
- Xử lý nhập sai bằng `TryParse`.

## Kiến thức áp dụng

- Console.WriteLine()
- Console.ReadLine()
- int
- double
- decimal
- string
- bool
- DateTime
- Toán tử + - * / %
- TryParse()

## Cách chạy

```bash
dotnet restore
dotnet run
```

sự khác nhau của các biến trong tiền tệ là do số thập phân sau dấu phẩy

int thì nó là số nguyên nên khi tiền tệ là số thập phân thì sẽ sai
double thì là số nhị phân vẫn dùng được nhưng sẽ bị làm tròn khi số phẩy dài
decimal là hợp lý nhất vì đây là số thập phân
