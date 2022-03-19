using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhan_vien
{
    internal class Program
    {
        static void Main(string[] args)
            
        {   
            Console.OutputEncoding = Encoding.UTF8;

            nhanvien nv1 =new nhanvien();
            nhanvien nv2=new nhanvien();
          
            Console.WriteLine("Nhập thông tin nhân viên thứ nhất:");
            nv1.nhap();
            nv1.xuat();

             Console.WriteLine(" Nhập thông tin nhân viên thứ hai");
            nv2.nhap();
            nv2.xuat();
            Console.ReadLine();
          
        }
    }
}
