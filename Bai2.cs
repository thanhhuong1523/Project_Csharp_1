using System;
namespace Phanso
{

    //Nhập, hiển thị và tính tổng, hiệu, tích, thương các phân số
    public class PhanSo
    {
        public int tu, mau;
        public PhanSo() { }
        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }
        int ucln(PhanSo ps)
        {
            int a = Math.Abs(ps.tu);
            int b = Math.Abs(ps.mau);
            if (a == 0) return 1;
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        public void Rutgon(PhanSo ps)
        {
            int uoc = ucln(ps);
            ps.tu /= uoc;
            ps.mau /= uoc;
        }
        public void printPs(PhanSo ps)
        {
            Rutgon(ps);
            if (ps.tu % ps.mau == 0)
            {
                Console.WriteLine(ps.tu / ps.mau);
            }
            else if (ps.tu < 0 && ps.mau < 0)
            {
                Console.WriteLine(Math.Abs(ps.tu) + "/" + Math.Abs(ps.mau));
            }
            else if (ps.tu > 0 && ps.mau < 0)
            {
                Console.WriteLine("-" + ps.tu + "/" + Math.Abs(ps.mau));
            }
            else
                Console.WriteLine(ps.tu + "/" + ps.mau);
        }

        public void tong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo pt = new PhanSo(1, 1);
            pt.tu = ps1.tu * ps2.mau + ps1.mau * ps2.tu;
            pt.mau = ps1.mau * ps2.mau;
            printPs(pt);
        }
        public void hieu(PhanSo ps1, PhanSo ps2)
        {
            PhanSo pt = new PhanSo(1, 1);
            pt.tu = ps1.tu * ps2.mau - ps1.mau * ps2.tu;
            pt.mau = ps1.mau * ps2.mau;
            printPs(pt);
        }
        public void tich(PhanSo ps1, PhanSo ps2)
        {
            PhanSo pt = new PhanSo(1, 1);
            pt.tu = ps1.tu * ps2.tu;
            pt.mau = ps1.mau * ps2.mau;
            printPs(pt);
        }
        public void thuong(PhanSo ps1, PhanSo ps2)
        {
            PhanSo pt = new PhanSo(1, 1);
            pt.tu = ps1.tu * ps2.mau;
            pt.mau = ps1.mau * ps2.tu;
            printPs(pt);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            PhanSo pt = null;
            PhanSo ps = new PhanSo();
            PhanSo ps1 = null, ps2 = null;
            while (true)
            {
                Console.WriteLine("*************************");
                Console.WriteLine("Chon tu 0 -> 8");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("1. Nhap mot phan so");
                Console.WriteLine("2. Hien thi phan so");
                Console.WriteLine("3. Nhap hai phan so");
                Console.WriteLine("4. Hien thi hai phan so");
                Console.WriteLine("5. Tong hai phan so");
                Console.WriteLine("6. Hieu hai phan so");
                Console.WriteLine("7. Tich hai phan so");
                Console.WriteLine("8. Thuong hai phan so");
                Console.WriteLine("**************************");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 0:
                        Console.WriteLine("The end. Press any keys to close the program.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        int tu, mau;
                        do
                        {
                            Console.WriteLine("1. Nhap mot phan so: ");
                            tu = int.Parse(Console.ReadLine());
                            mau = int.Parse(Console.ReadLine());
                        } while (mau == 0);
                        pt = new PhanSo(tu, mau);
                        break;
                    case 2:
                        Console.Write("2. Hien thi phan so: ");
                        pt.printPs(pt);
                        break;
                    case 3:

                        int tu1, mau1, tu2, mau2;
                        do
                        {
                            Console.WriteLine("3. Nhap hai phan so: ");
                            tu1 = int.Parse(Console.ReadLine());
                            mau1 = int.Parse(Console.ReadLine());
                            tu2 = int.Parse(Console.ReadLine());
                            mau2 = int.Parse(Console.ReadLine());
                        } while (mau1 == 0 || mau2 == 0);

                        ps1 = new PhanSo(tu1, mau1);
                        ps2 = new PhanSo(tu2, mau2);
                        break;
                    case 4:
                        Console.WriteLine("4. Hien thi hai phan so: ");
                        ps1.printPs(ps1);
                        ps2.printPs(ps2);
                        break;
                    case 5:
                        Console.Write("5. Tong hai phan so la: ");
                        ps.tong(ps1, ps2);
                        break;
                    case 6:
                        Console.Write("6. Hieu hai phan so la: ");
                        ps.hieu(ps1, ps2);
                        break;
                    case 7:
                        Console.Write("7. Tich hai phan so la: ");
                        ps.tich(ps1, ps2);
                        break;
                    case 8:
                        Console.Write("8. Thuong hai phan so la: ");
                        ps.thuong(ps1, ps2);
                        break;
                    default:
                        Console.WriteLine("Chon tu 0 -> 8");
                        break;
                }
            }
            Console.ReadKey();
            ;
        }
    }
}