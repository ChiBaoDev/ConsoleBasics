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
    Console.WriteLine("số sinh viên trong lớp");
    int n = int.Parse(Console.ReadLine());
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("nhập điểm sinh viên thứ {0}", i + 1);
        arr[i] = int.Parse(Console.ReadLine());
    }
    decimal diemtrungbinh = 0;
    for (int i = 0; i < n; i++)
    {
        diemtrungbinh += arr[i];
    }
    diemtrungbinh /= n;
    Console.WriteLine("điểm trung bình của lớp là: {0}", diemtrungbinh);
    Console.WriteLine("xếp hạng của từng sinh viên là: ");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("sinh viên thứ {0}: {1}", i + 1, arr[i] >= diemtrungbinh ? "đạt" : "không đạt");
    }

}
static void Bai2()
{
  decimal tienhoaDon;
    while (true)
    {
        Console.WriteLine("nhập số tiền hóa đơn");
        
    
        if (decimal.TryParse(Console.ReadLine(), out tienhoaDon) && tienhoaDon >= 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Số tiền hóa đơn không hợp lệ! Vui lòng nhập lại.");
        }
    }
  Console.WriteLine("nhập số % giảm giá");
    if (decimal.TryParse(Console.ReadLine(), out decimal giamgia) && giamgia >= 0 && giamgia <= 100)
    {
        decimal tiengiamgia = tienhoaDon * giamgia / 100;
        decimal tienthanhtoan = tienhoaDon - tiengiamgia;
        Console.WriteLine("số tiền giảm giá là: {0}", tiengiamgia);
        Console.WriteLine("số tiền thanh toán là: {0}", tienthanhtoan);
    }
    else
    {
        Console.WriteLine("số % giảm giá không hợp lệ");
    }
}
static void Bai3()
{
    Console.WriteLine("nhập loại khách hàng (1: thường , 2: bạc , 3: vàng, 4: kim cương )");
    int loaiKhachHang = int.Parse(Console.ReadLine());  
    Console.WriteLine("nhập số tiền hóa đơn");
    decimal tienhoaDon = decimal.Parse(Console.ReadLine());
    switch (loaiKhachHang)
    {
        case 1:
            Console.WriteLine("số tiền thanh toán là: {0}", tienhoaDon);
            break;
        case 2:
            Console.WriteLine("số tiền thanh toán là: {0}", tienhoaDon * 0.9m);
            break;
        case 3:
            Console.WriteLine("số tiền thanh toán là: {0}", tienhoaDon * 0.8m);
            break;
        case 4:
            Console.WriteLine("số tiền thanh toán là: {0}", tienhoaDon * 0.7m);
            break;
        default:
            Console.WriteLine("loại khách hàng không hợp lệ");
            break;
    }
}