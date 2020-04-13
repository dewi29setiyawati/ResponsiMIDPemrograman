using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2658
{
  class Karyawan
  {
    public string Nik { get; set; }
    public string Nama { get; set; }
    public int Gajibulanan { get; set; }

    public Karyawan(string nik, string nama, int gajibulanan)
    {
      Nik = nik;
      Nama = nama;
      if (gajibulanan > 0)
      {
        Gajibulanan = gajibulanan;
      }
      else
      {
        gajibulanan = 0;
      }
    }
  }
}
