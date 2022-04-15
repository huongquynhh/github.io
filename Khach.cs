using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly_thuexe
{
    internal class Khach
    {
        private string hoten, loaixe;
        private double sogio;
        public void nhap()
        {
            Console.WriteLine("Nhập tên khách hàng:");
            hoten=Console.ReadLine();
            Console.WriteLine("Nhập tên của loại xe thuê:");
            loaixe=Console.ReadLine();
            Console.WriteLine("Nhập số giờ thuê xe:");
            sogio = Double.Parse(Console.ReadLine());
        }
        public double tinhtien( double sogio)
        {
            if (loaixe == "xetai")
            {
                
                return 220000 + (sogio - 1) * 85000;
            }
            else 
                return 250000 + (sogio - 1) * 70000;
        
        }
        public void hien()
        {
            Console.WriteLine("Thông tin khách hàng là :Họ và tên khách {0}\n" +
                "Loại xe thuê{1}, tiền khách phải trả {2}", hoten, loaixe, tinhtien(sogio));

        }
    }

}
