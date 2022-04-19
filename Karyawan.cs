using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4325
{
    internal class Karyawan
    {
        private int nik;
        private string nama;
        private float gajibulanan;

        public int Nik
        {
            get { return nik; }
            set { nik = value; }
        }

        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        public float GajiBulanan
        {
            get { return gajibulanan; }
            set { gajibulanan = value; }
        }

        public Karyawan(int nik, string nama, float gajibulanan)
        {
            this.nik = nik;
            this.nama = nama;
            this.gajibulanan = (gajibulanan < 0) ? (this.gajibulanan = 0) : (this.gajibulanan = gajibulanan);
        }

        public void NaikGaji(int nik, string nama, float gajibulanan)
        {
            this.nik = nik;
            this.nama = nama;
            gajibulanan = 110 / 100 * gajibulanan;
            Console.WriteLine("1. {0}  {1}  {2}",Nik,Nama,GajiBulanan);
        }
    }
}
