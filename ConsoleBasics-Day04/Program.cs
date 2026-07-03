  List<string> danhSach = new List<string>();

        while (true)
        {
            Console.WriteLine("1. Thêm sinh viên");
            Console.WriteLine("2. Xóa sinh viên");
            Console.WriteLine("3. Hiển thị danh sách");
            Console.WriteLine("4. Đếm số lượng sinh viên");
            Console.WriteLine("5. Tìm kiếm sinh viên");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");

            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    ThemSinhVien(danhSach);
                    break;

                case "2":
                    XoaSinhVien(danhSach);
                    break;

                case "3":
                    HienThiDanhSach(danhSach);
                    break;

                case "4":
                    DemSinhVien(danhSach);
                    break;

                case "5":
                    TimKiemSinhVien(danhSach);
                    break;

                case "0":
                    Console.WriteLine("Đã thoát chương trình.");
                    return;

                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    break;
            }
        }

    static void ThemSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên sinh viên: ");
        string ten = Console.ReadLine()?.Trim();

        if (string.IsNullOrWhiteSpace(ten))
        {
            Console.WriteLine("Tên không được để trống!");
            return;
        }

        danhSach.Add(ten);
        Console.WriteLine("Đã thêm thành công.");
    }


    static void XoaSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên cần xóa: ");
        string ten = Console.ReadLine()?.Trim();

        if (danhSach.Remove(ten))
            Console.WriteLine("Đã xóa thành công.");
        else
            Console.WriteLine("Không tìm thấy sinh viên.");
    }


    static void HienThiDanhSach(List<string> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine("Danh sách đang trống.");
            return;
        }

        int stt = 1;
        foreach (string ten in danhSach)
        {
            Console.WriteLine($"{stt}. {ten}");
            stt++;
        }
    }


    static void DemSinhVien(List<string> danhSach)
    {
        Console.WriteLine($"Số lượng sinh viên: {danhSach.Count}");
    }

    // Tìm kiếm không phân biệt hoa/thường
    static void TimKiemSinhVien(List<string> danhSach)
    {
        Console.Write("Nhập tên cần tìm: ");

        string tuKhoa = Console.ReadLine()
            ?.Trim()
            .ToLower();

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