using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly_thuexe
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding=Encoding.UTF8;
            /*Xetai xt=new Xetai();
            Xedulich xdl=new Xedulich();

            Khach K =new Khach();
            
            Console.WriteLine("Thông tin xe tải là:");
            xt.hien();
            Console.WriteLine("Thông tin xe du lịch là:");
            xdl.hien();
            Console.WriteLine("Thông tin khách là:");
            k.hien();
            Console.WriteLine("Tiền khách phải trả là: {0}", k.tinhtien());*/
            QuanLy ql = new QuanLy();
            ql.nhapDS();
            ql.xuatDS();

            Console.ReadLine();
        }
    }
}
