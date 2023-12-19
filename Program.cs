using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CauTrucDieuKhien
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                DanhSachBaiTap();
                int userInput = Input();
                switch (userInput)
                {
                    case 1:
                        BaiTap1();
                        break;
                    case 2:
                        BaiTap2();
                        break;
                    case 3:
                        BaiTap3();
                        break;
                    case 4:
                        BaiTap4();
                        break;
                    case 5:
                        BaiTap5();
                        break;
                    case 6:
                        BaiTap6();
                        break;
                    case 7:
                        BaiTap7();
                        break;
                    case 8:
                        BaiTap8();
                        break;
                    case 9:
                        BaiTap9();
                        break;
                    case 10:
                        BaiTap10();
                        break;
                    default:
                        Console.Write("Bai Tap khong hop le");
                        break;
                }
                bool stop = DungChuongTrinh();
                if(stop) break;
            }
        }
        
        public static void DanhSachBaiTap()
        {
            Console.WriteLine("Bai Tap ve Cau Truc Dieu Khien");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Nhap so nguyen n va kiem tra co chia het cho 3 hay khong ?");
            Console.WriteLine("2 - Nhap so nguyen n, hien thi bang cuu chuong tu 1 den n");
            Console.WriteLine("3 - Nhap so nguyen n, tinh tong giai thua tu 1 den n");
            Console.WriteLine("4 - Nhap so tu ban phim va kiem tra so do co phai la so chinh phuong hay khong?");
            Console.WriteLine("5 - Nhap mot thang bat ky va kiem tra thang do co bao nhieu ngay");
            Console.WriteLine("6 - Nhap so nguyen n, tinh Tong S theo cong thuc");
            Console.WriteLine("7 - Nhap so nguyen n, tinh Tong cac so le tu 1 den n");
            Console.WriteLine("8 - Nhap so nguyen n, hien thi ra man hinh cac so nguyen tu 1 dne n");
            Console.WriteLine("9 - Nhap so nguyen n, ve tam giac voi so hang tuong ung");
            Console.WriteLine("10- Nhap so nguyen n,tinh toan va hien thi day so Fibonacci");
            Console.WriteLine();
        }

        public static bool DungChuongTrinh()
        {
            Console.WriteLine();
            Console.WriteLine("Nhan phim bat de tiep tuc Chuong trinh ");
            Console.WriteLine("Nhan phim ESC de thoat chuong trinh");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Escape) return true;
            Console.Clear();
            return false;
        }
        public static int Input() 
        {
            int userInput = 0;
            try 
            {
                userInput = int.Parse(Console.ReadLine());
            }catch (Exception e) 
            {
                Console.WriteLine(e.Message); 
            }
            return userInput;
        }
        public static void BaiTap1()
        {
            //Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đô có chia hết cho 3 hay không. Hiển thị ra kết quả
            Console.WriteLine("Kiem tra so chia het cho 3");
            Console.Write("Moi nhap so nguyen: ");
            int n = Input();
            if (n > 0)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine("So {0} chia het cho 3", n);
                }
                else
                {
                    Console.WriteLine("So {0} khong chia het cho 3", n);
                }
            }
            else
            {
                Console.WriteLine("{0} khong phai la so nguyen va lon hon 0");
            }
        }
        public static void BaiTap2()
        {
            //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình
            Console.WriteLine("Hien thi bang cuu chuong");
            Console.Write("Bang cuu chuong muon hien thi: ");
            int n = Input();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    int tich = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, tich);
                }
                Console.WriteLine("---------------");
                Console.WriteLine();
            }
        }
        public static void BaiTap3()
        {
            //Bài 3:Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình
            Console.WriteLine("Tinh Tong Gia Thua");
            Console.Write("Nhap so n: ");
            int n = Input();
            double tongGiaiThua = 0;
            for (int i = 1; i <= n; i++)
            {
               double GiaiThua = 1;
               for (int j = 1; j <= i; j++)
               {
                   GiaiThua *= j;
               }
               tongGiaiThua += GiaiThua;
            }
            Console.WriteLine("Tong giai thua tu 1 den {0} la {1}",n,tongGiaiThua);
            Console.ReadKey();
        }
        public static void BaiTap4()
        {
            //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
            Console.WriteLine("Kiem tra so chinh phuong");
            Console.Write("Nhap so muon kiem tra: ");
            int n = Input();
            double sqrt = Math.Sqrt(n);
            if (Math.Pow(sqrt, 2) == n)
            {
                Console.WriteLine("{0} la so chinh Phuong", n);
            }
            else
            {
                Console.WriteLine("{0} ko phai la so chinh Phuong", n);
            }
        }
        public static void BaiTap5()
        {
            //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình.
            Console.WriteLine("Hien thi so ngay cua thang");
            Console.Write("Nhap thang muon hien thi: ");
            int thang = Input();
            switch (thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Thang {0} co 31 ngay", thang);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} co 30 ngay", thang);
                    break;
                case 2:
                    Console.WriteLine("Thang {0} co 28 ngay va 29 ngay vao LeapYear", thang);
                    break;
                default:
                    Console.WriteLine("Thang nhap khong hop le");
                    break;
            }
        }
        public static void BaiTap6()
        {
            //Bài 6 :Viết chương trình nhập vào số nguyên n, tính tổng S theo công thức sau và hiển thị kết quả ra màn hình.
            Console.WriteLine("Tinh Tong S theo cong thuc");
            Console.Write("Nhap so nguyen n: ");
            int n = Input();
            double tong = 0;

            for (int i = 1; i <= n; i++)
            {
                tong += Math.Pow(i, i);
            }

            Console.WriteLine("Ket qua la {0}", tong);
        }
        public static void BaiTap7()
        {
            //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình.
            Console.WriteLine("Tinh tong so le tu 1 den n");
            Console.Write("Nhap so nguyen n: ");
            int n = Input();
            double tong = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    tong += i;
                }
            }

            Console.WriteLine("Ket qua la {0}", tong);
        }
        public static void BaiTap8()
        {
            //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            Console.WriteLine("Hien thi cac so nguyen to tu 1 den n");
            Console.Write("Nhap so nguyen duong: ");
            int n = Input();

            for (int i = 2; i <= n; i++)
            {
                if (i != 2 && i != 3)
                {
                    if (i % 2 == 0 || i % 3 == 0) continue;
                }
                Console.Write("{0} ", i);
            }
        }
        public static void BaiTap9()
        {
            //Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác * với số hàng tương ứng. Ví dụ, nhập vào 10 hàng, thì ta sẽ được 1 tam giác như hình bên dưới.
            //Có thể thử vẽ thêm với hình tam giác đều, tam giác xoay ngược.

            //Tam Giac
            Console.WriteLine("Ve tam giac * voi so hang tuong ung");
            Console.Write("Nhap so hang: ");
            int n = Input();
            string tamGiac = "";
            for (int i = 1; i <= n; i++)
            {
                tamGiac += "*";
                Console.WriteLine(tamGiac);
            }

            //Tam Giac Nguoc
            Console.WriteLine("Ve tam giac nguoc * voi so hang tuong ung");
            string tamGiacNguoc = "";
            for (int i = 0; i <= n; i++)
            {
                tamGiacNguoc += "*";
            }

            for (int i = tamGiacNguoc.Length - 1; i > 0; i--)
            {
                tamGiacNguoc = tamGiacNguoc.Remove(i);
                Console.WriteLine(tamGiacNguoc);
            }
        }
        public static void BaiTap10()
        {
            //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
            Console.Write("Nhap so nguyen n: ");
            int n = Input();
            int count = 0;
            int number1 = 0;
            int number2 = number1 + 1;
            int number3 = number2 + number1;

            Console.WriteLine("Day so voi {0} phan tu :", n);
            while (count <= n)
            {
                if (number1 != 0) Console.Write("{0} ", number1);
                number1 = number2;
                number2 = number3;
                number3 = number1 + number2;
                count++;
            }
            Console.ReadKey();
        }
    }
}
