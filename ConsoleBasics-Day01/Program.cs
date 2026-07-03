


Console.WriteLine("nhập số Bài muốn chạy");
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
    Console.WriteLine("tên:Nguyễn Chi Bảo");
    Console.WriteLine("lớp: 22DTH3");
    Console.WriteLine("mssv: 1822040591");
 }
 static void Bai2()
 {
    Console.WriteLine("nhập tên sản phẩm");
    string tenSanPham = Console.ReadLine();
    Console.WriteLine("nhập số lượng");
    int soLuong = int.Parse(Console.ReadLine());
    Console.WriteLine("nhập đơn giá");
    int donGia = int.Parse(Console.ReadLine());
    Console.WriteLine("thành tiền của {0} là: {1}", tenSanPham, soLuong * donGia);
 }
 static void Bai3()
 {
    Console.WriteLine("nhập năm sinh");
    if(!int.TryParse(Console.ReadLine(), out int a))
    {
        Console.WriteLine("năm sinh không hợp lệ");
        return;
    }
    int tuoi = 2026 - a;
    Console.WriteLine("tuổi của bạn là: {0}", tuoi);
 }