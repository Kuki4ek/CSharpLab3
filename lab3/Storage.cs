using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Storage : Place
    {
        public Storage(double length, double width, double height) : base(length, width, height)
        { 
        if (height < 3.0)
            {
                throw new ArgumentException("Высота склада не может быть меньше 3 метров");
            }
        }
    }
}
