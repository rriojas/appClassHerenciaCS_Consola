﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
  class Punto
  {
    protected double x;

    public double X
    {
      get
      {
        return x;
      }
      set
      {
        x = value;
      }
    }

    public Punto()
    {
      x = 0;
    }
    public Punto(double x)
    {
      this.x  = x;
    }
    public double Distancia(Punto p)
    {
      double d = 0;
      d = x - p.x; // Valor Absoluto
      return d;
    }
    public override string ToString()
    {
      return "X=" + x;
    }
  }
}
