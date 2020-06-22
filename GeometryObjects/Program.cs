using System;

namespace GeometryObjects {
    
    class Program {
    
        static void Main(string[] args) {

            var quad1 = new Quadrillateral(1, 2, 3, 4);
            quad1.Perimeter();
            var rect1 = new Rectangle(3, 5);
            rect1.Perimeter();
            rect1.Area();
            var sqr1 = new Square(5);
            sqr1.Perimeter();
            sqr1.Area();

        }
    }
}
