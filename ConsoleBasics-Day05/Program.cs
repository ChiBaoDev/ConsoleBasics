   List<string> danhSachSinhVien = new List<string>();

        while (true)
        {
            HienThiMenu();

            Console.Write("Chọn chức năng: ");
            string luaChon = Console.ReadLine();

            switch (luaChon)
            {
                case "1":
                    TinhHoaDon();
                    break;

                case "2":
                    ThemSinhVien(danhSachSinhVien);
                    break;

                case "3":
                    HienThiDanhSach(danhSachSinhVien);
                    break;

                case "4":
                    TimSinhVien(danhSachSinhVien);
                    break;

                case "5":
                    XoaSinhVien(danhSachSinhVien);
                    break;

                case "0":
                    Console.WriteLine("Thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }
    

    static void HienThiMenu()
    {
        Console.WriteLine("\n========== MENU ==========");
        Console.WriteLine("1. Tính hóa đơn");
        Console.WriteLine("2. Thêm sinh viên");
        Console.WriteLine("3. Hiển thị danh sách");
        Console.WriteLine("4. Tìm sinh viên");
        Console.WriteLine("5. Xóa sinh viên");
        Console.WriteLine("0. Thoát");
    }

    static void TinhHoaDon()
    {
        Console.Write("Nhập loại khách hàng (1-Thường, 2-Bạc, 3-Vàng, 4-Kim cương): ");

        if (!int.TryParse(Console.ReadLine(), out int loai))
        {
            Console.WriteLine("Loại khách hàng không hợp lệ!");
            return;
        }

        Console.Write("Nhập số tiền hóa đơn: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal tien) || tien < 0)
        {
            Console.WriteLine("Số tiền không hợp lệ!");
            return;
        }

        decimal giamGia = 0;

        switch (loai)
        {
            case 1:
                giamGia = 0;
                break;
            case 2:
                giamGia = 0.1m;
                break;
            case 3:
                giamGia = 0.2m;
                break;
            case 4:
                giamGia = 0.3m;
                break;
            default:
                Console.WriteLine("Loại khách hàng không hợp lệ.");
                return;
        }

        decimal tienThanhToan = tien - tien * giamGia;

        Console.WriteLine($"Tiền cần thanh toán: {tienThanhToan}");
    }

    static void ThemSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên sinh viên: ");
        string ten = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(ten))
        {
            Console.WriteLine("Tên không hợp lệ.");
            return;
        }

        danhSach.Add(ten);
        Console.WriteLine("Đã thêm.");
    }

    static void HienThiDanhSach(List<string> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách trống.");
            return;
        }

        Console.WriteLine("\nDanh sách sinh viên:");

        int stt = 1;

        foreach (string ten in danhSach)
        {
            Console.WriteLine($"{stt}. {ten}");
            stt++;
        }
    }

    static void TimSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên cần tìm: ");

        string tuKhoa = Console.ReadLine().Trim().ToLower();

        bool timThay = false;

        foreach (string ten in danhSach)
        {
            if (ten.ToLower().Contains(tuKhoa))
            {
                Console.WriteLine($"Tìm thấy: {ten}");
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine("Không tìm thấy sinh viên.");
        }
    }

    static void XoaSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên cần xóa: ");

        string ten = Console.ReadLine().Trim();

        if (danhSach.Remove(ten))
        {
            Console.WriteLine("Đã xóa.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên.");
        }
    }