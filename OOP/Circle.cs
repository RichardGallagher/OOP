using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Circle
    {
        private int radius;

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle()
        {
            Radius = 1;   
        }
        public Circle(int r)
        {
            // creates an object with values assigned to attributes
            radius = r;
            
        }
        public double GetArea()
        {
          return  radius * radius * 3.14;
        }
        public override string ToString()
        {
            return String.Format("The radius of this circle is {0}", Radius);
        }
    }
}
