using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ereditarietà1_cahino
{
    class Poligoni
    {
        private double lato;
        private double alt;
        private double lato2;
        private double lato3;
        class Quadrato:Poligoni
        {
            public Quadrato()
            {
                lato = 0.0;
            }
            public Quadrato(double lato)
            {
                setl(lato);
            }
        }
    public void perimetro(double p)
    {
        p = lato * 4;
    }
    public double getl()
    {
        return lato;
    }
    public double getl2()
    {
        return lato;
    }
    public double getl3()
    {
        return lato;
    }
    public double geth()
    {
        return alt;
    }
    public void seth(double h)
    {
        if (h > 0)
        {
            alt = h;
        }
    }
    public void setl(double l)
    {
        if (l > 0) lato = l;
    }
}
    }
}


