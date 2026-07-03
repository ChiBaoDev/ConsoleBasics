### Bài 1
- Tính điểm trung bình.
- Xếp loại sinh viên.

### Bài 2
- Nhập hóa đơn.
- Áp dụng giảm giá.
- Tính tiền thanh toán.

### Bài 3
- Chọn loại khách hàng.
- Áp dụng mức giảm giá theo từng loại.

## Kiến thức áp dụng

- int.Parse()
- decimal.Parse()
- TryParse()
- if/else
- switch-case
- Validate dữ liệu

# 
| stt | dữ liệu nhập | lý do không hợp lệ               | kết quả                            |
| --- | --------------- | ------------------------------------ | ------------------------------------ |
| tc1 | 5               | quá số bài                        | thông báo bài không hợp lệ     |
| tc2 | 1 ; abc         | không đúng kiểu dữ liệu bài 1 | số sinh viên không hợp lệ       |
| tc3 | 2; 10;1000      | không đúng kiểu dữ liệu bài 2 | % giảm giá không hợp lệ         |
| tc4 | 3;6             | không đúng kiểu dữ liệu bài 3 | loại khách hàng không hợp lệ   |
| tc5 | 2;-100;10       | không đúng kiểu dữ liệu bài 2 | số tiền hóa đơn không hợp lệ |


sự khác nhau của các biến trong tiền tệ là do số thập phân sau dấu phẩy

- int thì nó là số nguyên nên khi tiền tệ là số thập phân thì sẽ sai
- double thì là số nhị phân vẫn dùng được nhưng sẽ bị làm tròn khi số phẩy dài
- decimal là hợp lý nhất vì đây là số thập phân
