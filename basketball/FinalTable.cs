using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basketball
{
    public class FinalTable
    {
        public int i { get; set; }
        public double t { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Vx { get; set; }
        public double Vy { get; set; }
        public double Vz { get; set; }
        public FinalTable(int i, double t, double x1, double x2, double x3, double v1, double v2, double v3)
        {
            this.i = i;
            this.t = t;
            this.X = x1;
            this.Y = x2;
            this.Z = x3;
            this.Vx = v1;
            this.Vy = v2;
            this.Vz = v3;
        }
    }
}
