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


            //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình.
            //Console.WriteLine("Hien thi so ngay cua thang");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap thang muon hien thi: ");
            //    int thang = int.Parse(Console.ReadLine());
            //    switch(thang) 
            //    {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine("Thang {0} co 31 ngay",thang);
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine("Thang {0} co 30 ngay", thang);
            //            break;
            //        case 2:
            //            Console.WriteLine("Thang {0} co 28 ngay va 29 ngay vao LeapYear", thang);
            //            break;
            //        default:
            //            Console.WriteLine("Thang nhap khong hop le");
            //            break;
            //    }
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 6 :Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.
            //Console.WriteLine("Tinh Tong S theo cong thuc");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so nguyen n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    double tong = 0;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        tong += Math.Pow(i,i);
            //    }

            //    Console.WriteLine("Ket qua la {0}",tong);
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình.
            //Console.WriteLine("Tinh tong so le tu 1 den n");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so nguyen n: ");
            //    int n = int.Parse(Console.ReadLine());
            //    double tong = 0;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            tong += i;
            //        }
            //    }

            //    Console.WriteLine("Ket qua la {0}", tong);
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);

            //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            //Console.WriteLine("Hien thi cac so nguyen to tu 1 den n");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so nguyen duong: ");
            //    int n = int.Parse(Console.ReadLine());

            //    for (int i = 2; i <= n; i++)
            //    {
            //        if (i != 2 && i != 3)
            //        {
            //            if (i % 2 == 0 || i % 3 == 0) continue;
            //        }
            //        Console.Write("{0} ",i);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới.
            // Có thể thử vẽ thêm với hình tam giác đều, tam giác xoay ngược.

            //Tam Giac
            //Console.WriteLine("Ve tam giac * voi so hang tuong ung");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so hang: ");
            //    int n = int.Parse(Console.ReadLine());
            //    string tamGiac = "";
            //    for (int i = 1; i <= n; i++)
            //    {
            //        tamGiac += "*";
            //        Console.WriteLine(tamGiac);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Tam Giac Nguoc
            //Console.WriteLine("Ve tam giac nguoc * voi so hang tuong ung");
            //bool dungChuongTrinh = true;
            //do
            //{
            //    Console.Write("Nhap so hang: ");
            //    int n = int.Parse(Console.ReadLine());
            //    string tamGiac = "";
            //    for (int i = 0; i <= n; i++)
            //    {
            //        tamGiac += "*";
            //    }

            //    for (int i = tamGiac.Length - 1; i > 0; i--)
            //    {
            //        tamGiac = tamGiac.Remove(i);
            //        Console.WriteLine(tamGiac);
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Ban co muon tiep tuc Chuong Trinh ko ? (Y/N)");
            //    string tiepTuc = Console.ReadLine().ToLower();
            //    if (tiepTuc == "n")
            //    {
            //        dungChuongTrinh = false;
            //    }
            //} while (dungChuongTrinh);


            //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
            //Console.Write("Nhap so nguyen n: ");
            //int n = int.Parse(Console.ReadLine());
            //int count = 0;
            //int number1 = 0;
            //int number2 = number1 + 1;
            //int number3 = number2 + number1;

            //Console.WriteLine("Day so voi {0} phan tu :",n);
            //while (count <= n)
            //{
            //    if(number1 != 0) Console.Write("{0} ",number1);
            //    number1 = number2;
            //    number2 = number3;
            //    number3 = number1 + number2;
            //    count++;
            //}
            //Console.ReadKey();
        }
    }
}
