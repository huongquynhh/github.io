using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly_thuexe
{
    public class Xedulich:Xe
    {
    private double sogio;
    private string hoten;
    public override void nhap()
    {
        Console.WriteLine("Nhập họ và tên người thuê:");
        hoten = Console.ReadLine();
        Console.WriteLine("Nhập số giờ thuê xe:");
        sogio = Double.Parse(Console.ReadLine());
    }
        public override double tinhtien()
       
        {
                return 250000 + (sogio - 1) * 70000;

            }
        
    public override void hien()
    {
        Console.WriteLine(" Họ tên người thuê xe là: {0}, với số giờ thuê là {1}, tổng tiền phải trả là {2}",
            hoten, sogio, tinhtien());
    }
}
}
