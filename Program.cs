using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4325
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(40002, "Indisya", 2400000);
            Karyawan karyawan2 = new Karyawan(30001, "Sismita", 2800000);

            Karyawan karyawan1naikgaji = new Karyawan.NaikGaji(40002, "Indisya", 2400000);
            Karyawan karyawan2naikgaji = new Karyawan.NaikGaji(30001, "Sismita", 2800000);

            Console.WriteLine("No  Nik    Nama     Gaji Bulanan");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("1. {0}  {1}  {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0}  {1}  {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine("");

            Console.WriteLine("Horeeeee ! ada kenaikan gaji 10%");
            Console.WriteLine("No  Nik    Nama     Gaji Bulanan");
            Console.WriteLine("--------------------------------");

            Karyawan.NaikGaji(karyawan1naikgaji);
            Karyawan.NaikGaji(karyawan2naikgaji);

            Console.ReadKey();
        }
    }
}
