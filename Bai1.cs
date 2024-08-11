using System;
using System.Collections.Generic;

namespace Ex3
{

    //Tạo 1 chương trình quản lý tài liệu bao gồm sách, tạp chí, báo.
    abstract class TaiLieu
    {
        string ma;
        string tenNXB;
        int sobanPH;
        public TaiLieu()
        {

        }
        public TaiLieu(string ma, string tenNXB, int sobanPH)
        {
            this.ma = ma;
            this.tenNXB = tenNXB;
            this.sobanPH = sobanPH;
        }
        public string getMa()
        {
            return ma;
        }
        public void setMa(string ma)
        {
            this.ma = ma;
        }
        public string getTenNXB()
        {
            return tenNXB;
        }
        public void setTenNXB(string tenNXB)
        {
            this.tenNXB = tenNXB;
        }
        public int getSobanPH()
        {
            return sobanPH;
        }
        public void setSoBanPH(int sobanPH)
        {
            this.sobanPH = sobanPH;
        }
        public virtual string toString()
        {
            return (ma + "\t" + tenNXB + "\t" + sobanPH + "\t");
        }
    }
    class Sach : TaiLieu
    {
        public Sach() : base()
        {

        }
        string tenTG;
        string tenSach;
        int soTrang;
        public Sach(string ma, string tenNXB, int sobanPH, string tenTG, string tenSach, int soTrang) : base(ma, tenNXB, sobanPH)
        {
            this.tenTG = tenTG;
            this.tenSach = tenSach;
            this.soTrang = soTrang;
        }
        public string getTenTG()
        {
            return tenTG;
        }
        public void setTenTG(string tenTG)
        {
            this.tenTG = tenTG;
        }
        public string getTenSach()
        {
            return tenSach;
        }
        public void setTenSach(string tenSach)
        {
            this.tenSach = tenSach;
        }
        public int getSoTrang()
        {
            return soTrang;
        }
        public void setSoTrang(int soTrang)
        {
            this.soTrang = soTrang;
        }
        public override string toString()
        {
            return base.toString() + (tenTG + "\t" + tenSach + "\t" + soTrang + "\t");
        }
    }
    class TapChi : TaiLieu
    {
        int soPH;
        int thangPH;
        public TapChi() : base()
        {

        }
        public TapChi(string ma, string tenNXB, int sobanPH, int soPH, int thangPH) : base(ma, tenNXB, sobanPH)
        {
            this.soPH = soPH;
            this.thangPH = thangPH;
        }
        public int getSoPH()
        {
            return soPH;
        }
        public void setSoPH(int soPH)
        {
            this.soPH = soPH;
        }
        public int getThangPH()
        {
            return thangPH;
        }
        public void setThangPH(int thangPH)
        {
            this.thangPH = thangPH;
        }
        public override string toString()
        {
            return base.toString() + (soPH + "\t" + thangPH + "\t");
        }
    }
    class Bao : TaiLieu
    {
        int ngayPH;
        public Bao() : base()
        {

        }
        public Bao(string ma, string tenNXB, int sobanPH, int ngayPH) : base(ma, tenNXB, sobanPH)
        {
            this.ngayPH = ngayPH;
        }

        public int getNgayPH()
        {
            return ngayPH;
        }
        public void setNgayPH(int ngayPH)
        {
            this.ngayPH = ngayPH;
        }
        public override string toString()
        {
            return base.toString() + ngayPH + "\t";
        }
    }
    public class QuanLy
    {
        List<Sach> sach = new List<Sach>(10);
        List<TapChi> tapchi = new List<TapChi>(10);
        List<Bao> bao = new List<Bao>(10);
        public void NhapThongTin()
        {
            Console.Write("Nhap ma : ");
            string ma = Console.ReadLine()!;
            Console.Write("Nhap ten nha xuat ban: ");
            string tenNXB = Console.ReadLine()!;
            Console.Write("Nhap so ban phat hanh: ");
            int sobanPH = int.Parse(Console.ReadLine()!);

            Console.WriteLine("\t1. Sach");
            Console.WriteLine("\t2. Tap chi");
            Console.WriteLine("\t3. Bao");
            Console.Write("Chon loai tai lieu muon nhap: ");
            int x = int.Parse(Console.ReadLine()!);

            switch (x)
            {
                case 1:
                    Console.WriteLine("******************************* SACH ************************************");
                    Console.Write("Nhap ten tac gia: ");
                    string tenTG = Console.ReadLine()!;
                    Console.Write("Nhap ten sach: ");
                    string tenSach = Console.ReadLine()!;
                    Console.Write("Nhap so trang: ");
                    int soTrang = int.Parse(Console.ReadLine()!);
                    Sach s = new Sach(ma, tenNXB, sobanPH, tenTG, tenSach, soTrang);
                    sach.Add(s);
                    break;
                case 2:
                    Console.WriteLine("****************************** TAP CHI **********************************");
                    Console.Write("Nhap so phat hanh: ");
                    int soPH = int.Parse(Console.ReadLine()!);
                    Console.Write("Nhap thang phat hanh: ");
                    int thangPH = int.Parse(Console.ReadLine()!);
                    TapChi t = new TapChi(ma, tenNXB, sobanPH, soPH, thangPH);
                    tapchi.Add(t);
                    break;
                case 3:
                    Console.WriteLine("******************************** BAO ************************************");
                    Console.Write("Nhap ngay phat hanh: ");
                    int ngayPH = int.Parse(Console.ReadLine()!);
                    Bao b = new Bao(ma, tenNXB, sobanPH, ngayPH);
                    bao.Add(b);
                    break;
                default:
                    break;
            }
        }
        public void HienThi()
        {
            Console.WriteLine("\t1. Sach");
            Console.WriteLine("\t2. Tap chi");
            Console.WriteLine("\t3. Bao");
            Console.WriteLine("\t4. Tat ca");
            Console.Write("Chon loai tai lieu muon hien thi:");
            int x = int.Parse(Console.ReadLine()!);
            switch (x)
            {
                case 1:
                    Console.WriteLine("******************************** SACH ***********************************");
                    foreach (Sach kt in sach)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    break;
                case 2:
                    Console.WriteLine("****************************** TAP CHI **********************************");
                    foreach (TapChi kt in tapchi)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    break;
                case 3:
                    Console.WriteLine("******************************** BAO ************************************");
                    foreach (Bao kt in bao)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    break;
                case 4:
                    Console.WriteLine("******************************** SACH ***********************************");
                    foreach (Sach kt in sach)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    Console.WriteLine("******************************* TAP CHI *********************************");
                    foreach (TapChi kt in tapchi)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    Console.WriteLine("********************************* BAO ***********************************");
                    foreach (Bao kt in bao)
                    {
                        Console.WriteLine("\t" + kt.toString() + "\t");
                    }
                    break;
            }
        }
        public void timKiemTheoMa(string ma)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getMa() == ma)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (Bao s in bao)
            {
                if (s.getMa() == ma)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (TapChi s in tapchi)
            {
                if (s.getMa() == ma)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoTenNXB(string tenNXB)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getTenNXB() == tenNXB)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (Bao s in bao)
            {
                if (s.getTenNXB() == tenNXB)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (TapChi s in tapchi)
            {
                if (s.getTenNXB() == tenNXB)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoTenTacGia(string tenTG)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getTenTG() == tenTG)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoTenSach(string tenSach)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getTenSach() == tenSach)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoNgayPH(int ngayPH)
        {
            bool check = false;
            foreach (Bao s in bao)
            {
                if (s.getNgayPH() == ngayPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoKhoangThangPH(int firstThangPH, int lastThangPH)
        {
            bool check = false;
            foreach (TapChi s in tapchi)
            {
                if (s.getThangPH() >= firstThangPH && s.getThangPH() <= lastThangPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoKhoangNgayPH(int firstNgayPH, int lastNgayPH)
        {
            bool check = false;
            foreach (Bao s in bao)
            {
                if (s.getNgayPH() >= firstNgayPH && s.getNgayPH() <= lastNgayPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoKhoangSoTrang(int firstTrang, int lastTrang)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getSoTrang() >= firstTrang && s.getSoTrang() <= lastTrang)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }

        public void timKiemTheoSoBanPH(int firstSoBanPH, int lastSoBanPH)
        {
            bool check = false;
            foreach (Sach s in sach)
            {
                if (s.getSobanPH() >= firstSoBanPH && s.getSobanPH() <= lastSoBanPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (Bao s in bao)
            {
                if (s.getSobanPH() >= firstSoBanPH && s.getSobanPH() <= lastSoBanPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            foreach (TapChi s in tapchi)
            {
                if (s.getSobanPH() >= firstSoBanPH && s.getSobanPH() <= lastSoBanPH)
                {
                    Console.WriteLine("\t" + s.toString() + "\t");
                    check = true;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }
        public int checkExistSach(string ma)
        {
            for (int i = 0; i < sach.Count; i++)
            {
                if (sach[i].getMa() == ma) return i;
            }
            return -1;
        }
        public int checkExistTapChi(string ma)
        {
            for (int i = 0; i < tapchi.Count; i++)
            {
                if (tapchi[i].getMa() == ma) return i;
            }
            return -1;
        }
        public int checkExistBao(string ma)
        {
            for (int i = 0; i < bao.Count; i++)
            {
                if (bao[i].getMa() == ma) return i;
            }
            return -1;
        }
        public void xoaTaiLieu(string ma)
        {
            bool check = false;
            if (checkExistSach(ma) != -1)
            {
                sach.RemoveAt(checkExistSach(ma));
                check = true;
                Console.WriteLine("Da xoa mot tai lieu Sach");
            }
            if (checkExistTapChi(ma) != -1)
            {
                tapchi.RemoveAt(checkExistTapChi(ma));
                check = true;
                Console.WriteLine("Da xoa mot tai lieu Tap chi");
            }
            if (checkExistBao(ma) != -1)
            {
                bao.RemoveAt(checkExistBao(ma));
                check = true;
                Console.WriteLine("Da xoa mot tai lieu Bao");
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }
        public void suaTaiLieu(string ma)
        {
            bool check = false;
            if (checkExistSach(ma) != -1)
            {
                check = true;
                Console.WriteLine("\t1. Ten NXB");
                Console.WriteLine("\t2. So ban phat hanh");
                Console.WriteLine("\t3. Ten tac gia");
                Console.WriteLine("\t4. Ten sach");
                Console.WriteLine("\t5. So trang");
                Console.Write("Chon hang muc muon sua: ");
                int sua = int.Parse(Console.ReadLine()!);
                switch (sua)
                {
                    case 1:
                        Console.Write("Nhap ten NXB moi: ");
                        string newtennxb = Console.ReadLine();
                        sach[checkExistSach(ma)].setTenNXB(newtennxb);
                        Console.WriteLine(sach[checkExistSach(ma)].toString());
                        break;
                    case 2:
                        Console.Write("Nhap so ban phat hanh moi: ");
                        int newsobanph = int.Parse(Console.ReadLine()!);
                        sach[checkExistSach(ma)].setSoBanPH(newsobanph);
                        Console.WriteLine(sach[checkExistSach(ma)].toString());
                        break;
                    case 3:
                        Console.Write("Nhap ten tac gia moi: ");
                        string newtentg = Console.ReadLine()!;
                        sach[checkExistSach(ma)].setTenTG(newtentg);
                        Console.WriteLine(sach[checkExistSach(ma)].toString());
                        break;
                    case 4:
                        Console.Write("Nhap ten sach moi: ");
                        string newtensach = Console.ReadLine()!;
                        sach[checkExistSach(ma)].setTenSach(newtensach);
                        Console.WriteLine(sach[checkExistSach(ma)].toString());
                        break;
                    case 5:
                        Console.Write("Nhap so trang moi: ");
                        int newsotrang = int.Parse(Console.ReadLine()!);
                        sach[checkExistSach(ma)].setSoTrang(newsotrang);
                        Console.WriteLine(sach[checkExistSach(ma)].toString());
                        break;
                    default:

                        break;
                }
            }
            if (checkExistTapChi(ma) != -1)
            {
                check = true;
                Console.WriteLine("\t1. Ten NXB");
                Console.WriteLine("\t2. So ban phat hanh");
                Console.WriteLine("\t3. So phat hanh");
                Console.WriteLine("\t4. Thang phat hanh");
                Console.Write("Chon hang muc muon sua: ");
                int sua = int.Parse(Console.ReadLine()!);
                switch (sua)
                {
                    case 1:
                        Console.Write("Nhap ten NXB moi: ");
                        string newtennxb = Console.ReadLine();
                        tapchi[checkExistTapChi(ma)].setTenNXB(newtennxb);
                        Console.WriteLine(tapchi[checkExistTapChi(ma)].toString());
                        break;
                    case 2:
                        Console.Write("Nhap so ban phat hanh moi: ");
                        int newsobanph = int.Parse(Console.ReadLine()!);
                        tapchi[checkExistTapChi(ma)].setSoBanPH(newsobanph);
                        Console.WriteLine(tapchi[checkExistTapChi(ma)].toString());
                        break;
                    case 3:
                        Console.Write("Nhap so phat hanh moi: ");
                        int newsoph = int.Parse(Console.ReadLine()!);
                        tapchi[checkExistTapChi(ma)].setSoPH(newsoph);
                        Console.WriteLine(tapchi[checkExistTapChi(ma)].toString());
                        break;
                    case 4:
                        Console.Write("Nhap thang phat hanh moi: ");
                        int newthangph = int.Parse(Console.ReadLine()!);
                        tapchi[checkExistTapChi(ma)].setThangPH(newthangph);
                        Console.WriteLine(tapchi[checkExistTapChi(ma)].toString());
                        break;
                    default:

                        break;
                }
            }
            if (checkExistBao(ma) != -1)
            {
                check = true;
                Console.WriteLine("\t1. Ten NXB");
                Console.WriteLine("\t2. So ban phat hanh");
                Console.WriteLine("\t3. Ngay phat hanh");
                Console.Write("Chon hang muc muon sua: ");
                int sua = int.Parse(Console.ReadLine()!);
                switch (sua)
                {
                    case 1:
                        Console.Write("Nhap ten NXB moi: ");
                        string newtennxb = Console.ReadLine()!;
                        bao[checkExistBao(ma)].setTenNXB(newtennxb);
                        Console.WriteLine(bao[checkExistBao(ma)].toString());
                        break;
                    case 2:
                        Console.Write("Nhap so ban phat hanh moi: ");
                        int newsobanph = int.Parse(Console.ReadLine()!);
                        bao[checkExistBao(ma)].setSoBanPH(newsobanph);
                        Console.WriteLine(bao[checkExistBao(ma)].toString());
                        break;
                    case 3:
                        Console.Write("Nhap ngay phat hanh moi: ");
                        int newngayph = int.Parse(Console.ReadLine()!);
                        bao[checkExistBao(ma)].setNgayPH(newngayph);
                        Console.WriteLine(bao[checkExistBao(ma)].toString());
                        break;
                    default:

                        break;
                }
            }
            if (!check) Console.WriteLine("Khong tim thay");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuanLy quanly = new QuanLy();
            int dem = 0;
            while (true)
            {
                Console.WriteLine("*************************************************************************");
                Console.WriteLine("\t1. Nhap thong tin");
                Console.WriteLine("\t2. Hien thi thong tin");
                Console.WriteLine("\t3. Tim kiem");
                Console.WriteLine("\t4. Xoa");
                Console.WriteLine("\t5. Sua");
                Console.WriteLine("\t6. Thoat chuong trinh");
                Console.Write("Chon lenh thuc hien: ");
                int x = int.Parse(Console.ReadLine()!);
                Console.WriteLine("*************************************************************************");
                switch (x)
                {
                    case 1:
                        quanly.NhapThongTin();
                        dem++;
                        break;
                    case 2:
                        quanly.HienThi();
                        Console.WriteLine("Tong co " + dem + " tai lieu.");
                        break;
                    case 3:
                        Console.WriteLine("\t1. Ma");
                        Console.WriteLine("\t2. Ten NXB");
                        Console.WriteLine("\t3. Ten tac gia");
                        Console.WriteLine("\t4. Ten sach");
                        Console.WriteLine("\t5. Ngay phat hanh");
                        Console.WriteLine("\t6. Khoang thang phat hanh");
                        Console.WriteLine("\t7. Khoang ngay phat hanh");
                        Console.WriteLine("\t8. Khoang so trang");
                        Console.WriteLine("\t9. Khoang so ban phat hanh");
                        Console.Write("Chon hang muc muon tim kiem: ");
                        int tk = int.Parse(Console.ReadLine()!);
                        switch (tk)
                        {
                            case 1:
                                Console.Write("Nhap ma: ");
                                string tkma = Console.ReadLine()!;
                                quanly.timKiemTheoMa(tkma);
                                break;
                            case 2:
                                Console.Write("Nhap ten NXB: ");
                                string tktennxb = Console.ReadLine()!;
                                quanly.timKiemTheoTenNXB(tktennxb);
                                break;
                            case 3:
                                Console.Write("Nhap ten tac gia: ");
                                string tktentg = Console.ReadLine()!;
                                quanly.timKiemTheoTenTacGia(tktentg);
                                break;
                            case 4:
                                Console.Write("Nhap ten sach: ");
                                string tktensach = Console.ReadLine()!;
                                quanly.timKiemTheoTenSach(tktensach);
                                break;
                            case 5:
                                Console.Write("Nhap ngay phat hanh: ");
                                int tkngayph = int.Parse(Console.ReadLine()!);
                                quanly.timKiemTheoNgayPH(tkngayph);
                                break;
                            case 6:
                                Console.WriteLine("Nhap khoang thang phat hanh: ");
                                int tkfirstthangph = int.Parse(Console.ReadLine()!);
                                int tklastthangph = int.Parse(Console.ReadLine()!);
                                quanly.timKiemTheoKhoangThangPH(tkfirstthangph, tklastthangph);
                                break;
                            case 7:
                                Console.WriteLine("Nhap khoang ngay phat hanh: ");
                                int tkfirstngayph = int.Parse(Console.ReadLine()!);
                                int tklastngayph = int.Parse(Console.ReadLine()!);
                                quanly.timKiemTheoKhoangNgayPH(tkfirstngayph, tklastngayph);
                                break;
                            case 8:
                                Console.WriteLine("Nhap khoang so trang: ");
                                int tkfirstsotrang = int.Parse(Console.ReadLine()!);
                                int tklastsotrang = int.Parse(Console.ReadLine()!);
                                quanly.timKiemTheoKhoangSoTrang(tkfirstsotrang, tklastsotrang);
                                break;
                            case 9:
                                Console.WriteLine("Nhap khoang so ban phat hanh: ");
                                int tkfirstsobanph = int.Parse(Console.ReadLine()!);
                                int tklastsobanph = int.Parse(Console.ReadLine()!);
                                quanly.timKiemTheoSoBanPH(tkfirstsobanph, tklastsobanph);
                                break;
                            default:
                                Console.WriteLine("Nhap sai");
                                break;
                        }
                        break;
                    case 4:
                        Console.Write("Nhap ma muon xoa: ");
                        string maxoa = Console.ReadLine()!;
                        if (quanly.checkExistSach(maxoa) != -1 || quanly.checkExistBao(maxoa) != -1 || quanly.checkExistTapChi(maxoa) != -1) dem--;
                        quanly.xoaTaiLieu(maxoa);
                        break;
                    case 5:
                        Console.Write("Nhap ma muon sua: ");
                        string masua = Console.ReadLine()!;
                        quanly.suaTaiLieu(masua);
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Nhap lai !");
                        break;
                }
            }
        }

    }
}
