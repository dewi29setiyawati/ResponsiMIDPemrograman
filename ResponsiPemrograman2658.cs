using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2658
{
  class Program
  {
    static void Main(string[] args)
    {
      Karyawan Krywn1 = new Karyawan("190302123", "Paijo", 3000000);
      Karyawan Krywn2 = new Karyawan("190302124", "Jono", 2000000);

      Console.WriteLine("GAJI BULANAN KARYAWAN");
      Console.WriteLine();
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("No.    NIK/nama           Gaji Bulanan");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1.     {0} {1}          {2}", Krywn1.Nik, Krywn1.Nama, Krywn1.Gajibulanan);
      Console.WriteLine("2.     {0} {1}           {2}", Krywn2.Nik, Krywn2.Nama, Krywn2.Gajibulanan);
      Console.WriteLine("----------------------------------------");
      Console.WriteLine();
      Console.WriteLine("Alhamdulillah Kenaikan Gaji 10%");
      Console.WriteLine();
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("No.    NIK/nama            Gaji Bulanan");
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("1.     {0} {1}          {2}", Krywn1.Nik, Krywn1.Nama, (Krywn1.Gajibulanan)*1.1);
      Console.WriteLine("1.     {0} {1}           {2}", Krywn2.Nik, Krywn2.Nama, (Krywn2.Gajibulanan)*1.1);
      Console.WriteLine("----------------------------------------");
      Console.ReadKey();
    }
  }
}
