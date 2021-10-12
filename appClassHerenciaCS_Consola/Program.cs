using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
  class Program
  {
    static void Main(string[] args)
    {
      Punto2D a;
      a = new Punto2D(-1.45, -2.88);
      Console.WriteLine(a.ToString());

      Punto2D b;
      b = new Punto2D(3.55, 9.02);
      Console.WriteLine(b.ToString());

      double d = a.Distancia(b);
      Console.WriteLine("Distancia "+d);

      Console.ReadKey();



    }
  }
}
