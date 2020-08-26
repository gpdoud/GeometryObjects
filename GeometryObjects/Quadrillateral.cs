using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryObjects {
    
    public class Quadrillateral {

        protected int side1 { get; set; }
        protected int side2 { get; set; }
        protected int side3 { get; set; }
        protected int side4 { get; set; }

        public void Perimeter() {
            var perimeter = side1 + side2 + side3 + side4;
            Console.WriteLine($"Perimeter is {perimeter}");
        }

        public Quadrillateral(int s1, int s2, int s3, int s4) {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;
        }

    }
}
