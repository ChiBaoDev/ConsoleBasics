
### Bài 1
- Nhập n số nguyên.
- Tính tổng.
- Tính trung bình.
- Tìm số lớn nhất.

### Bài 2
- In bảng cửu chương.

### Bài 3
Menu Console:

- Thêm tên.
- Xem danh sách.
- Tìm tên.
- Thoát.

## Kiến thức áp dụng

- for
- while
- do...while
- foreach
- break
- continue
- Menu Console

## Cách chạy

```bash
dotnet restore
dotnet run
```
# 3 lỗi em đã gặp

khai báo chuỗi sai

do em không nhớ cách khai báo chuỗi nên nhầm thành
int[] danhsach;
sửa thành   List<string> danhsach = new List<string>();
chọn menu không hợp lệ

khai báo biến chossing và so sánh bằng if nhưng lại để là string dẫn tới tiếng việt có dấu bị thành ???
sửa thành không giấu hết
chạy không được trương trình do ghi console.writeline không để ý viết hoa

sửa lại thành viết hoa
