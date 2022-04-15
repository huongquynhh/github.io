using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly_thuexe
{
    internal class QuanLy
    {
        int n, i;
        Khach[] a;

        public void nhapDS()
        {
            Console.WriteLine("Nhap so luong Hành khách:");
            n = Convert.ToInt32(Console.ReadLine());
            a = new Khach[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap hành khách thứ {0}", i + 1);
                a[i] = new Khach();
                a[i].nhap();



            }
        }
        public void xuatDS()
        {
            Console.WriteLine("DSHK la: ");
            for (i = 0; i < n; i++)
                a[i].hien();
        }
    }
}

