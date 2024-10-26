using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.week_11_interface
{
    public abstract class Shape
    {
        public abstract void Draw();

        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle: Shape
    {

    }

}
