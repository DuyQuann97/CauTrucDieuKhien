using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDieuKhien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đô có chia hết cho 3 hay không. Hiển thị ra kết quả
            //Console.WriteLine("Kiem tra so chia het cho 3");
            //bool dungChuongTrinh = true;
            //do 
            //{
            //    Console.Write("Moi nhap so nguyen: ");
            //    int n = int.Parse(Console.ReadLine());
            //    if (n > 0)
            //    {
            //        if (n % 3 == 0)
            //        {
            //            Console.WriteLine("So {0} chia het cho 3" , n);
            //        }
            //        else
            //        {
            //            Console.WriteLine("So {0} khong chia het cho 3", n);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} khong phai la so nguyen va lon hon 0");
            //    }
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình
            //Console.WriteLine("Hien thi bang cuu chuong");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Bang cuu chuong muon hien thi: ");
            //    int n = int.Parse(Console.ReadLine());

            //    for (int i = 1;i <= n; i++) 
            //    {
            //        for (int j = 1; j < 11; j++)
            //        {
            //            int tich = i * j;
            //            Console.WriteLine("{0} x {1} = {2}",i,j,tich);
            //        }
            //        Console.WriteLine("---------------");
            //        Console.WriteLine();
            //    }

            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 3:Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình
            //Console.WriteLine("Tinh Tong Gia Thua");
            //Console.Write("Nhap so n: ");
            //int n = int.Parse(Console.ReadLine());
            //double tongGiaiThua = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    double GiaiThua = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        GiaiThua *= j;
            //    }
            //    tongGiaiThua += GiaiThua;
            //}

            //Console.WriteLine("Tong giai thua tu 1 den {0} la {1}",n,tongGiaiThua);
            //Console.ReadKey();

            //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            //Console.WriteLine("Kiem tra so chinh phuong");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so muon kiem tra: ");
            //    int n = int.Parse(Console.ReadLine());
            //    double sqrt = Math.Sqrt(n);

            //    if (Math.Pow(sqrt,2) == n)
            //    {
            //        Console.WriteLine("{0} la so chinh Phuong", n);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} ko phai la so chinh Phuong", n);
            //    }


            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);

        }
    }
}
