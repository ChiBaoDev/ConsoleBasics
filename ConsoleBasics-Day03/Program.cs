Console.WriteLine("nhap số Bài muốn chạy");
int bai = int.Parse(Console.ReadLine());
switch (bai)
{
    case 1:
        Bai1();
        break;
    case 2:
        Bai2();
        break;
    case 3:
        Bai3();
        break;
    default:
        Console.WriteLine("Bài không tồn tại");
        break;
}
static void Bai1()
{
    Console.WriteLine("nhập n số nguyên");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("nhập số nguyên thứ {0}", i + 1);
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("tổng các số nguyên là: {0}", arr.Sum());
    Console.WriteLine("trung bình cộng các số nguyên là: {0}", arr.Average());
    Console.WriteLine("số nguyên lớn nhất là: {0}", arr.Max());
}
static void Bai2()
{
    Console.WriteLine("nhập số nguyên dương n");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine("bảng cửu chương của {0} là:", n);
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("{0} x {1} = {2}", n, i, n * i);
    }
}
static void Bai3()
{
  string Ten;
  List<string> danhsach = new List<string>();

  while (true)
  {
    Console.WriteLine("chọn 1 trong các lựa chọn sau: thêm tên , hiển thị danh sách , tìm kiếm, thoát");
    string choice = Console.ReadLine().Trim().ToLower();
    if (choice == "them ten")
    {
        Console.WriteLine("nhập tên cần thêm");
        Ten = Console.ReadLine();
        danhsach.Add(Ten);
    }
    else if (choice == "hien thi danh sach")
    {
        Console.WriteLine("danh sách các tên là:");
        foreach (string name in danhsach)
        {
            Console.WriteLine(name);
        }
    }
    else if (choice == "tim kiem")
    {
        Console.WriteLine("nhập tên cần tìm kiếm");
        Ten = Console.ReadLine();
        if (danhsach.Contains(Ten))
        {
            Console.WriteLine("tên {0} có trong danh sách", Ten);
        }
        else
        {
            Console.WriteLine("tên {0} không có trong danh sách", Ten);
        }
    }
    else if (choice == "thoat")
    {
        break;
    }
    else
    {
        Console.WriteLine("lựa chọn không hợp lệ");
    }
  }
}